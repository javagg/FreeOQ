// Type: SmartQuant.Instruments.FileDataServer
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.File;
using SmartQuant.Series;
using System;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class FileDataServer : IDataServer
  {
    private DataFile k66E5AjfUE;

    public DataFile File
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.k66E5AjfUE;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileDataServer()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.k66E5AjfUE = new DataFile(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(6390), Framework.Installation.DataDir.FullName);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string series, IDataObject obj)
    {
      ((IDataSeries) this.k66E5AjfUE.Series[series] ?? (IDataSeries) this.k66E5AjfUE.Series.Add(series)).Add(obj.DateTime, (object) obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(string series, DateTime dateTime)
    {
      IDataSeries dataSeries = (IDataSeries) this.k66E5AjfUE.Series[series];
      if (dataSeries == null)
        return;
      dataSeries.Remove(dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(string series, IDataObject obj)
    {
      ((IDataSeries) this.k66E5AjfUE.Series[series] ?? (IDataSeries) this.k66E5AjfUE.Series.Add(series)).Update(obj.DateTime, (object) obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
    {
      TradeArray tradeArray = new TradeArray();
      if (this.k66E5AjfUE.Series[series] != null)
      {
        foreach (Trade trade in this.k66E5AjfUE.Series[series].GetArray(datetime1, datetime2))
          tradeArray.Add((IDataObject) trade);
      }
      return tradeArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
    {
      QuoteArray quoteArray = new QuoteArray();
      if (this.k66E5AjfUE.Series[series] != null)
      {
        foreach (Quote quote in this.k66E5AjfUE.Series[series].GetArray(datetime1, datetime2))
          quoteArray.Add((IDataObject) quote);
      }
      return quoteArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
    {
      BarSeries barSeries = new BarSeries();
      if (this.k66E5AjfUE.Series[series] != null)
      {
        foreach (Bar bar in this.k66E5AjfUE.Series[series].GetArray(datetime1, datetime2))
          barSeries.Add(bar);
      }
      return barSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries GetDailySeries(string seriesName, DateTime datetime1, DateTime datetime2)
    {
      DailySeries dailySeries = new DailySeries();
      FileSeries fileSeries = this.k66E5AjfUE.Series[seriesName];
      if (fileSeries != null)
      {
        foreach (Daily daily in fileSeries.GetArray(datetime1, datetime2))
          dailySeries.Add((Bar) daily);
      }
      return dailySeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepthArray GetMarketDepthArray(string seriesName, DateTime datetime1, DateTime datetime2)
    {
      MarketDepthArray marketDepthArray = new MarketDepthArray();
      FileSeries fileSeries = this.k66E5AjfUE.Series[seriesName];
      if (fileSeries != null)
      {
        foreach (MarketDepth marketDepth in fileSeries.GetArray(datetime1, datetime2))
          marketDepthArray.Add((IDataObject) marketDepth);
      }
      return marketDepthArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDataSeries GetDataSeries(string series)
    {
      return (IDataSeries) this.k66E5AjfUE.Series[series];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDataSeries AddDataSeries(string series)
    {
      return (IDataSeries) this.k66E5AjfUE.Series.Add(series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Delete(string series)
    {
      this.k66E5AjfUE.Series.Remove(series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(string series)
    {
      this.k66E5AjfUE.Series[series].Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Rename(string oldSeries, string newSeries)
    {
      this.k66E5AjfUE.Series.Rename(oldSeries, newSeries);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataSeriesList GetDataSeries()
    {
      DataSeriesList dataSeriesList = new DataSeriesList();
      foreach (FileSeries fileSeries in this.k66E5AjfUE.Series)
        dataSeriesList.Add((IDataSeries) fileSeries);
      return dataSeriesList;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Flush()
    {
      foreach (FileSeries fileSeries in this.k66E5AjfUE.Series)
        fileSeries.Flush();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close()
    {
      this.k66E5AjfUE.Close();
    }
  }
}
