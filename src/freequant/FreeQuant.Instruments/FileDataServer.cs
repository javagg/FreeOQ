using FreeQuant;
using FreeQuant.Data;
using FreeQuant.File;
using FreeQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class FileDataServer : IDataServer
  {
		private DataFile file; 

    public DataFile File
    {
      get
      {
        return this.file;
      }
    }

    public FileDataServer()
    {
      this.file = new DataFile(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(6390), Framework.Installation.DataDir.FullName);
    }

    public void Add(string series, IDataObject obj)
    {
      ((IDataSeries) this.file.Series[series] ?? (IDataSeries) this.file.Series.Add(series)).Add(obj.DateTime, (object) obj);
    }

    public void Remove(string series, DateTime dateTime)
    {
      IDataSeries dataSeries = (IDataSeries) this.file.Series[series];
      if (dataSeries == null)
        return;
      dataSeries.Remove(dateTime);
    }

    public void Update(string series, IDataObject obj)
    {
      ((IDataSeries) this.file.Series[series] ?? (IDataSeries) this.file.Series.Add(series)).Update(obj.DateTime, (object) obj);
    }

    public TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
    {
      TradeArray tradeArray = new TradeArray();
      if (this.file.Series[series] != null)
      {
        foreach (Trade trade in this.file.Series[series].GetArray(datetime1, datetime2))
          tradeArray.Add((IDataObject) trade);
      }
      return tradeArray;
    }

    public QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
    {
      QuoteArray quoteArray = new QuoteArray();
      if (this.file.Series[series] != null)
      {
        foreach (Quote quote in this.file.Series[series].GetArray(datetime1, datetime2))
          quoteArray.Add((IDataObject) quote);
      }
      return quoteArray;
    }

    public BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
    {
      BarSeries barSeries = new BarSeries();
      if (this.file.Series[series] != null)
      {
        foreach (Bar bar in this.file.Series[series].GetArray(datetime1, datetime2))
          barSeries.Add(bar);
      }
      return barSeries;
    }

    public DailySeries GetDailySeries(string seriesName, DateTime datetime1, DateTime datetime2)
    {
      DailySeries dailySeries = new DailySeries();
      FileSeries fileSeries = this.file.Series[seriesName];
      if (fileSeries != null)
      {
        foreach (Daily daily in fileSeries.GetArray(datetime1, datetime2))
          dailySeries.Add((Bar) daily);
      }
      return dailySeries;
    }

    public MarketDepthArray GetMarketDepthArray(string seriesName, DateTime datetime1, DateTime datetime2)
    {
      MarketDepthArray marketDepthArray = new MarketDepthArray();
      FileSeries fileSeries = this.file.Series[seriesName];
      if (fileSeries != null)
      {
        foreach (MarketDepth marketDepth in fileSeries.GetArray(datetime1, datetime2))
          marketDepthArray.Add((IDataObject) marketDepth);
      }
      return marketDepthArray;
    }

    public IDataSeries GetDataSeries(string series)
    {
      return (IDataSeries) this.file.Series[series];
    }

    public IDataSeries AddDataSeries(string series)
    {
      return (IDataSeries) this.file.Series.Add(series);
    }

    public void Delete(string series)
    {
      this.file.Series.Remove(series);
    }

    public void Clear(string series)
    {
      this.file.Series[series].Clear();
    }

    public void Rename(string oldSeries, string newSeries)
    {
      this.file.Series.Rename(oldSeries, newSeries);
    }

    public DataSeriesList GetDataSeries()
    {
      DataSeriesList dataSeriesList = new DataSeriesList();
      foreach (FileSeries fileSeries in this.file.Series)
        dataSeriesList.Add((IDataSeries) fileSeries);
      return dataSeriesList;
    }

    public void Flush()
    {
      foreach (FileSeries fileSeries in this.file.Series)
        fileSeries.Flush();
    }

    public void Close()
    {
      this.file.Close();
    }
  }
}
