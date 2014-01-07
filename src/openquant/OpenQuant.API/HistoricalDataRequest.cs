using OpenQuant.ObjectMap;
using FreeQuant.Providers;
using System;

namespace OpenQuant.API
{
  public class HistoricalDataRequest
  {
		internal FreeQuant.Providers.HistoricalDataRequest request;

    public Instrument Instrument
    {
      get
      {
        return Map.SQ_OQ_Instrument[(object) this.request.Instrument] as Instrument;
      }
    }

    public DataType DataType
    {
      get
      {
        switch (this.request.DataType)
        {
          case HistoricalDataType.Trade:
            return DataType.Trade;
          case HistoricalDataType.Quote:
            return DataType.Quote;
          case HistoricalDataType.Bar:
            return DataType.Bar;
          case HistoricalDataType.Daily:
            return DataType.Daily;
          default:
            throw new ArgumentException(string.Format("Not supported data type - {0}", (object) this.request.DataType));
        }
      }
    }

    public long BarSize
    {
      get
      {
        return this.request.BarSize;
      }
    }

    public DateTime BeginDate
    {
      get
      {
        return this.request.BeginDate;
      }
    }

    public DateTime EndDate
    {
      get
      {
        return this.request.EndDate;
      }
    }

		internal HistoricalDataRequest(FreeQuant.Providers.HistoricalDataRequest request)
    {
      this.request = request;
    }
  }
}
