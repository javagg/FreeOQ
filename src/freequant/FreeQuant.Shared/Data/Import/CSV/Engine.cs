// Type: SmartQuant.Shared.Data.Import.CSV.Engine
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.Instruments;
using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public abstract class Engine
  {
    protected Template template;
    private string[] zk1Y2Rukuw;
    private FileInfo[] toaYXwOc9v;
    private EngineState wMOYKdjT8I;
    private FileInfo Al2YmA6eU4;
    private int DyZYwKrQP9;
    private Hashtable uESY0nGd5r;
    private bool crdYphkUUs;
    private bool UY6YNDKXaq;

    public EngineState State
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wMOYKdjT8I;
      }
    }

    public event EventHandler StateChanged;

    public event ErrorEventHandler Error;

    public event ProgressEventHandler TotalProgress;

    public event ProgressEventHandler CurrentFileProgress;

    public event FileEventHandler FileStatusChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Engine()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.wMOYKdjT8I = EngineState.Stopped;
      this.uESY0nGd5r = new Hashtable();
      new Thread(new ThreadStart(this.s6aY4lp6hS))
      {
        Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5304)
      }.Start();
    }

    protected abstract IDataObject Process();

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Add(IDataSeries series, IDataObject obj)
    {
      series.Add(obj.DateTime, (object) obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Engine GetEngine(DataType dataType)
    {
      switch (dataType)
      {
        case DataType.Daily:
          return (Engine) new BarEngine(true);
        case DataType.Trade:
          return (Engine) new TradeEngine();
        case DataType.Quote:
          return (Engine) new QuoteEngine();
        case DataType.Bar:
          return (Engine) new BarEngine(false);
        default:
          throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(5334) + ((object) dataType).ToString());
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start(FileInfo[] files, Template template, bool storeObjects)
    {
      this.toaYXwOc9v = files;
      this.template = template;
      this.UY6YNDKXaq = storeObjects;
      this.wMOYKdjT8I = EngineState.Running;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Finish()
    {
      this.wMOYKdjT8I = EngineState.Finished;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop()
    {
      this.wMOYKdjT8I = EngineState.Stopped;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pause()
    {
      this.wMOYKdjT8I = EngineState.Paused;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Continue()
    {
      this.wMOYKdjT8I = EngineState.Running;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SkipCurrentFile()
    {
      this.crdYphkUUs = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void khmYZ1ca86([In] FileInfo obj0, [In] string obj1, [In] string obj2, [In] int obj3, [In] int obj4)
    {
      if (this.BxHYEdBqIf == null)
        return;
      this.BxHYEdBqIf((object) this, new ErrorEventArgs(obj0, obj1, obj2, obj3, obj4));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DateTime GetDateTime()
    {
      this.DyZYwKrQP9 = -1;
      if (this.template.DataOptions.DataType == DataType.Daily)
      {
        this.DyZYwKrQP9 = this.GetColumnIndex(ColumnType.Date);
        return this.rMuYj3m6MH(this.zk1Y2Rukuw[this.DyZYwKrQP9], this.template.Columns[this.DyZYwKrQP9].ColumnFormat);
      }
      else
      {
        switch (this.template.DateOptions.DateType)
        {
          case DateType.Column:
            this.DyZYwKrQP9 = this.GetColumnIndex(ColumnType.DateTime);
            if (this.DyZYwKrQP9 != -1)
              return this.rMuYj3m6MH(this.zk1Y2Rukuw[this.DyZYwKrQP9], this.template.Columns[this.DyZYwKrQP9].ColumnFormat);
            this.DyZYwKrQP9 = this.GetColumnIndex(ColumnType.Date);
            DateTime dateTime1 = this.rMuYj3m6MH(this.zk1Y2Rukuw[this.DyZYwKrQP9], this.template.Columns[this.DyZYwKrQP9].ColumnFormat);
            this.DyZYwKrQP9 = this.GetColumnIndex(ColumnType.Time);
            DateTime dateTime2 = this.sLbY6JtOmJ(this.zk1Y2Rukuw[this.DyZYwKrQP9], this.template.Columns[this.DyZYwKrQP9].ColumnFormat);
            return dateTime1.Add(dateTime2.TimeOfDay);
          case DateType.Manually:
            DateTime date = this.template.DateOptions.Date;
            this.DyZYwKrQP9 = this.GetColumnIndex(ColumnType.Time);
            DateTime dateTime3 = this.sLbY6JtOmJ(this.zk1Y2Rukuw[this.DyZYwKrQP9], this.template.Columns[this.DyZYwKrQP9].ColumnFormat);
            return date.Add(dateTime3.TimeOfDay);
          default:
            throw new ArgumentException();
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected double GetDoubleValue(ColumnType columnType)
    {
      this.DyZYwKrQP9 = this.GetColumnIndex(columnType);
      if (this.DyZYwKrQP9 != -1)
        return double.Parse(this.zk1Y2Rukuw[this.DyZYwKrQP9], (IFormatProvider) this.template.CSVOptions.CultureInfo);
      else
        return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected int GetIntValue(ColumnType columnType)
    {
      this.DyZYwKrQP9 = this.GetColumnIndex(columnType);
      if (this.DyZYwKrQP9 != -1)
        return int.Parse(this.zk1Y2Rukuw[this.DyZYwKrQP9]);
      else
        return 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected int GetColumnIndex(ColumnType columnType)
    {
      for (int index = 0; index < this.template.Columns.Count; ++index)
      {
        if (this.template.Columns[index].ColumnType == columnType)
          return index;
      }
      return -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void s6aY4lp6hS()
    {
      while (true)
      {
        this.kdRYU0k0L6(new EngineState[2]
        {
          EngineState.Running,
          EngineState.Finished
        });
        if (this.wMOYKdjT8I != EngineState.Finished)
        {
          this.RVDYrOBxap();
          this.LDcY85Y27P(0);
          this.uESY0nGd5r.Clear();
          for (int index = 0; index < this.toaYXwOc9v.Length; ++index)
          {
            if (this.wMOYKdjT8I == EngineState.Paused)
            {
              this.RVDYrOBxap();
              this.kdRYU0k0L6(new EngineState[2]
              {
                EngineState.Running,
                EngineState.Stopped
              });
              this.RVDYrOBxap();
            }
            if (this.wMOYKdjT8I != EngineState.Stopped)
            {
              this.wNkYI3uLB3(this.toaYXwOc9v[index]);
              this.LDcY85Y27P(index + 1);
            }
            else
              break;
          }
          DataManager.Server.Flush();
          this.wMOYKdjT8I = EngineState.Stopped;
          this.RVDYrOBxap();
        }
        else
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wNkYI3uLB3([In] FileInfo obj0)
    {
      this.Al2YmA6eU4 = obj0;
      this.crdYphkUUs = false;
      this.TKwYCfei9V(obj0, this.UY6YNDKXaq ? FileStatus.Importing : FileStatus.Testing);
      this.fVsY5trsT0(0);
      StreamReader streamReader;
      try
      {
        streamReader = new StreamReader((Stream) obj0.OpenRead());
      }
      catch (IOException ex)
      {
        this.khmYZ1ca86(obj0, (string) null, ex.Message, -1, -1);
        this.TKwYCfei9V(obj0, FileStatus.DoneError);
        return;
      }
      int headerLineCount1 = this.template.CSVOptions.HeaderLineCount;
      while (headerLineCount1-- > 0)
        streamReader.ReadLine();
      int num1 = 0;
      bool flag = false;
      int headerLineCount2 = this.template.CSVOptions.HeaderLineCount;
      int num2 = 0;
      string str1;
      while ((str1 = streamReader.ReadLine()) != null)
      {
        ++headerLineCount2;
        if (this.wMOYKdjT8I == EngineState.Paused)
        {
          this.RVDYrOBxap();
          this.kdRYU0k0L6(new EngineState[2]
          {
            EngineState.Running,
            EngineState.Stopped
          });
          this.RVDYrOBxap();
        }
        if (this.wMOYKdjT8I == EngineState.Stopped)
        {
          this.RVDYrOBxap();
          break;
        }
        else
        {
          string str2 = str1.Trim();
          if (!(str2 == ""))
          {
            this.zk1Y2Rukuw = str2.Split((char[]) this.template.CSVOptions.Separator);
            if (this.zk1Y2Rukuw.Length == this.template.Columns.Count)
            {
              try
              {
                IDataObject dataObject = this.Process();
                if (this.UY6YNDKXaq)
                  this.Add(this.kPpYSImTDN(), dataObject);
                ++num1;
              }
              catch (Exception ex)
              {
                if (Trace.IsLevelEnabled(TraceLevel.Error))
                  Trace.WriteLine(((object) ex).ToString());
                flag = true;
                this.khmYZ1ca86(this.Al2YmA6eU4, str2, ex.Message, headerLineCount2, this.DyZYwKrQP9);
                if (this.crdYphkUUs)
                  break;
              }
            }
            else
            {
              flag = true;
              this.khmYZ1ca86(obj0, str2, string.Concat(new object[4]
              {
                (object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(5378),
                (object) this.zk1Y2Rukuw.Length,
                (object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(5426),
                (object) this.template.Columns.Count
              }), headerLineCount2, -1);
              if (this.crdYphkUUs)
                break;
            }
            int num3 = (int) (streamReader.BaseStream.Position * 100L / streamReader.BaseStream.Length);
            if (num3 > num2)
            {
              num2 = num3;
              this.fVsY5trsT0(num2);
            }
          }
        }
      }
      streamReader.Close();
      FileStatus fileStatus = FileStatus.DoneOk;
      if (flag)
        fileStatus = FileStatus.DoneError;
      if (this.crdYphkUUs)
        fileStatus = FileStatus.Aborted;
      this.zpMYqh8Vyu(obj0, fileStatus, num1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IDataSeries kPpYSImTDN()
    {
      string symbol = (string) null;
      switch (this.template.SymbolOptions.Option)
      {
        case SymbolOption.FileName:
          symbol = this.Al2YmA6eU4.Name;
          if (this.template.SymbolOptions.CutFileExt && this.Al2YmA6eU4.Extension != "")
          {
            symbol = symbol.Substring(0, symbol.IndexOf('.'));
            break;
          }
          else
            break;
        case SymbolOption.Column:
          symbol = this.zk1Y2Rukuw[this.GetColumnIndex(ColumnType.Symbol)].Trim();
          break;
        case SymbolOption.Manually:
          symbol = this.template.SymbolOptions.Name;
          break;
      }
      if (this.template.OtherOptions.CreateInstrument && InstrumentManager.Instruments[symbol] == null)
        new Instrument(symbol, this.template.OtherOptions.SecurityType).Save();
      string str = (string) null;
      switch (this.template.SeriesOptions.Option)
      {
        case SeriesNameOption.Standard:
          switch (this.template.DataOptions.DataType)
          {
            case DataType.Daily:
              str = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5466);
              break;
            case DataType.Trade:
              str = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5494);
              break;
            case DataType.Quote:
              str = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5480);
              break;
            case DataType.Bar:
              str = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5456) + (object) '.' + ((object) BarType.Time).ToString() + (string) (object) '.' + this.template.DataOptions.BarSize.ToString();
              break;
          }
        case SeriesNameOption.Custom:
          str = this.template.SeriesOptions.SeriesSuffix;
          break;
      }
      string series = symbol + (object) '.' + str;
      IDataSeries dataSeries = DataManager.Server.GetDataSeries(series) ?? DataManager.Server.AddDataSeries(series);
      if (this.template.OtherOptions.ClearSeries && !this.uESY0nGd5r.ContainsKey((object) dataSeries))
      {
        dataSeries.Clear();
        this.uESY0nGd5r.Add((object) dataSeries, (object) true);
      }
      return dataSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kdRYU0k0L6([In] EngineState[] obj0)
    {
      while (true)
      {
        foreach (EngineState engineState in obj0)
        {
          if (this.wMOYKdjT8I == engineState)
            return;
        }
        Thread.Sleep(1);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DateTime rMuYj3m6MH([In] string obj0, [In] string obj1)
    {
      return DateTime.ParseExact(obj0, obj1, (IFormatProvider) this.template.CSVOptions.CultureInfo);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DateTime sLbY6JtOmJ([In] string obj0, [In] string obj1)
    {
      if (obj1.Length > obj0.Length)
        obj0 = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5508) + obj0;
      return this.rMuYj3m6MH(obj0, obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RVDYrOBxap()
    {
      if (this.an5Ytt2QPe == null)
        return;
      this.an5Ytt2QPe((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LDcY85Y27P([In] int obj0)
    {
      if (this.fXaYQE1fyE == null)
        return;
      this.fXaYQE1fyE((object) this, new ProgressEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fVsY5trsT0([In] int obj0)
    {
      if (this.uBBYvEPNQU == null)
        return;
      this.uBBYvEPNQU((object) this, new ProgressEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zpMYqh8Vyu([In] FileInfo obj0, [In] FileStatus obj1, [In] int obj2)
    {
      if (this.TrhYoMg74f == null)
        return;
      this.TrhYoMg74f((object) this, new FileEventArgs(obj0, obj1, obj2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TKwYCfei9V([In] FileInfo obj0, [In] FileStatus obj1)
    {
      this.zpMYqh8Vyu(obj0, obj1, 0);
    }
  }
}
