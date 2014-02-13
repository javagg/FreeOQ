using OpenQuant.Shared.Data;
using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.TAQ
{
  internal abstract class ImportEngine
  {
    protected ImportSettings settings;
    protected BinaryReader indexReader;
    protected BinaryReader dataReader;
    protected bool doNext;

    public int PercentDone
    {
      get
      {
        Stream baseStream = this.indexReader.BaseStream;
        return (int) (baseStream.Position * 100L / baseStream.Length);
      }
    }

    public event EventHandler Progress;

    public event EventHandler Stopped;

    public void SetSettings(ImportSettings settings)
    {
      this.settings = settings;
    }

    public void Run()
    {
      switch (this.settings.DataType)
      {
        case DataType.Trade:
          this.ImportTrades();
          break;
        case DataType.Quote:
          this.ImportQuotes();
          break;
      }
    }

    public void Stop()
    {
      this.doNext = false;
    }

    protected void EmitProgressEvent()
    {
      if (this.Progress == null)
        return;
      this.Progress((object) this, EventArgs.Empty);
    }

    protected void EmitStoppedEvent()
    {
      if (this.Stopped == null)
        return;
      this.Stopped((object) this, EventArgs.Empty);
    }

    private void ImportQuotes()
    {
      try
      {
        this.indexReader = new BinaryReader((Stream) new FileStream(this.settings.TAQIndexFile.FullName, FileMode.Open, FileAccess.Read));
        this.dataReader = new BinaryReader((Stream) new FileStream(this.settings.TAQDataFile.FullName, FileMode.Open, FileAccess.Read));
        this.doNext = true;
        while (this.indexReader.PeekChar() != -1)
        {
          QuoteIndexRecord quoteIndexRecord = this.ReadQuoteIndexRecord();
          string str = "";
          for (int index = 0; index < 10; ++index)
            str = str + (object) Convert.ToChar(quoteIndexRecord.SYMBOL[index]);
          Instrument instrument = this.GetInstrument(str.Replace(" ", ""));
          if (instrument != null)
          {
            DateTime date = this.GetDate(quoteIndexRecord.QDATE);
            for (int num = quoteIndexRecord.BEGREC; num <= quoteIndexRecord.ENDREC; ++num)
            {
              IQuoteRecord quoteRecord = this.ReadQuoteDataRecord(num);
              Quote quote = new Quote(date.AddSeconds((double) quoteRecord.Time), quoteRecord.Bid, quoteRecord.BidSize, quoteRecord.Ask, quoteRecord.AskSize);
              instrument.Add(quote);
            }
          }
          this.EmitProgressEvent();
          if (!this.doNext)
            break;
        }
        DataManager.Server.Flush();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(((object) ex).ToString());
      }
      finally
      {
        this.EmitStoppedEvent();
      }
    }

    private void ImportTrades()
    {
      try
      {
        this.indexReader = new BinaryReader((Stream) new FileStream(this.settings.TAQIndexFile.FullName, FileMode.Open, FileAccess.Read));
        this.dataReader = new BinaryReader((Stream) new FileStream(this.settings.TAQDataFile.FullName, FileMode.Open, FileAccess.Read));
        this.doNext = true;
        while (this.indexReader.PeekChar() != -1)
        {
          TradeIndexRecord tradeIndexRecord = this.ReadTradeIndexRecord();
          string str = "";
          for (int index = 0; index < 10; ++index)
            str = str + (object) Convert.ToChar(tradeIndexRecord.SYMBOL[index]);
          Instrument instrument = this.GetInstrument(str.Replace(" ", ""));
          if (instrument != null)
          {
            DateTime date = this.GetDate(tradeIndexRecord.TDATE);
            for (int num = tradeIndexRecord.BEGREC; num <= tradeIndexRecord.ENDREC; ++num)
            {
              ITradeRecord tradeRecord = this.ReadTradeDataRecord(num);
              Trade trade = new Trade(date.AddSeconds((double) tradeRecord.Time), tradeRecord.Price, tradeRecord.Size);
              instrument.Add(trade);
            }
          }
          this.EmitProgressEvent();
          if (!this.doNext)
            break;
        }
        DataManager.Server.Flush();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(((object) ex).ToString());
      }
      finally
      {
        this.EmitStoppedEvent();
      }
    }

    private Instrument GetInstrument(string symbol)
    {
			Instrument instrument = InstrumentManager.Instruments[symbol];
      switch (this.settings.SymbolOption)
      {
        case SymbolOption.All:
          if (instrument == null)
          {
            instrument = new Instrument(symbol);
            instrument.Save();
            break;
          }
          else
            break;
        case SymbolOption.Custom:
          if (!this.ContainsSymbol(symbol))
          {
            instrument = (Instrument) null;
            break;
          }
          else
            break;
      }
      return instrument;
    }

    private bool ContainsSymbol(string symbol)
    {
      foreach (string str in this.settings.Symbols)
      {
        if (str == symbol)
          return true;
      }
      return false;
    }

    private TradeIndexRecord ReadTradeIndexRecord()
    {
      return new TradeIndexRecord()
      {
        SYMBOL = this.indexReader.ReadBytes(10),
        TDATE = this.indexReader.ReadInt32(),
        BEGREC = this.indexReader.ReadInt32(),
        ENDREC = this.indexReader.ReadInt32()
      };
    }

    protected abstract ITradeRecord ReadTradeDataRecord(int num);

    private QuoteIndexRecord ReadQuoteIndexRecord()
    {
      return new QuoteIndexRecord()
      {
        SYMBOL = this.indexReader.ReadBytes(10),
        QDATE = this.indexReader.ReadInt32(),
        BEGREC = this.indexReader.ReadInt32(),
        ENDREC = this.indexReader.ReadInt32()
      };
    }

    protected abstract IQuoteRecord ReadQuoteDataRecord(int num);

    protected abstract DateTime GetDate(int talDate);
  }
}
