// Type: SmartQuant.Shared.Data.Import.TAQ.ImportEngine
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.Data;
using SmartQuant.Instruments;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.TAQ
{
  public abstract class ImportEngine
  {
    protected ImportSettings settings;
    protected BinaryReader indexReader;
    protected BinaryReader dataReader;
    protected bool doNext;

    public int PercentDone
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        Stream baseStream = this.indexReader.BaseStream;
        return (int) (baseStream.Position * 100L / baseStream.Length);
      }
    }

    public event EventHandler Progress;

    public event EventHandler Stopped;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ImportEngine()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSettings(ImportSettings settings)
    {
      this.settings = settings;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Run()
    {
      switch (this.settings.DataType)
      {
        case DataType.Trades:
          this.e52FjXBrXj();
          break;
        case DataType.Quotes:
          this.gUaFUAZrM2();
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop()
    {
      this.doNext = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitProgressEvent()
    {
      if (this.gg7FqIJCOR == null)
        return;
      this.gg7FqIJCOR((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitStoppedEvent()
    {
      if (this.gCGFCCppLr == null)
        return;
      this.gCGFCCppLr((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gUaFUAZrM2()
    {
      try
      {
        this.indexReader = new BinaryReader((Stream) new FileStream(this.settings.TAQIndexFile.FullName, FileMode.Open, FileAccess.Read));
        this.dataReader = new BinaryReader((Stream) new FileStream(this.settings.TAQDataFile.FullName, FileMode.Open, FileAccess.Read));
        this.doNext = true;
        while (this.indexReader.PeekChar() != -1)
        {
          QuoteIndexRecord quoteIndexRecord = this.ehcF5JyrAG();
          string str = "";
          for (int index = 0; index < 10; ++index)
            str = str + (object) Convert.ToChar(quoteIndexRecord.SYMBOL[index]);
          Instrument instrument = this.ikWF6aB2Pa(str.Replace(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12274), ""));
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void e52FjXBrXj()
    {
      try
      {
        this.indexReader = new BinaryReader((Stream) new FileStream(this.settings.TAQIndexFile.FullName, FileMode.Open, FileAccess.Read));
        this.dataReader = new BinaryReader((Stream) new FileStream(this.settings.TAQDataFile.FullName, FileMode.Open, FileAccess.Read));
        this.doNext = true;
        while (this.indexReader.PeekChar() != -1)
        {
          TradeIndexRecord tradeIndexRecord = this.aw5F84pdO9();
          string str = "";
          for (int index = 0; index < 10; ++index)
            str = str + (object) Convert.ToChar(tradeIndexRecord.SYMBOL[index]);
          Instrument instrument = this.ikWF6aB2Pa(str.Replace(RNaihRhYEl0wUmAftnB.aYu7exFQKN(12280), ""));
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Instrument ikWF6aB2Pa([In] string obj0)
    {
      Instrument instrument = InstrumentManager.Instruments[obj0];
      switch (this.settings.SymbolOption)
      {
        case SymbolOption.All:
          if (instrument == null)
          {
            instrument = new Instrument(obj0);
            instrument.Save();
            break;
          }
          else
            break;
        case SymbolOption.Custom:
          if (!this.JhZFrG4Wao(obj0))
          {
            instrument = (Instrument) null;
            break;
          }
          else
            break;
      }
      return instrument;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool JhZFrG4Wao([In] string obj0)
    {
      foreach (string str in this.settings.Symbols)
      {
        if (str == obj0)
          return true;
      }
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TradeIndexRecord aw5F84pdO9()
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuoteIndexRecord ehcF5JyrAG()
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
