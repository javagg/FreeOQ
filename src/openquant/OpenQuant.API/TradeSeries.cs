using FreeQuant.Data;
using FreeQuant.Series;
using System.Collections;

namespace OpenQuant.API
{
  public class TradeSeries : IEnumerable
  {
    internal TradeArray series;

    public int Count
    {
      get
      {
        return this.series.Count;
      }
    }

    public Trade Last
    {
      get
      {
        if (this.series.Count > 0)
          return new Trade(this.series[this.series.Count - 1]);
        else
          return (Trade) null;
      }
    }

    public Trade this[int index]
    {
      get
      {
        return new Trade(this.series[index]);
      }
    }

    internal TradeSeries(TradeArray series)
    {
      this.series = series;
    }

    public TradeSeries()
    {
      this.series = new TradeArray();
    }

    public void Add(Trade trade)
    {
      this.series.Add((IDataObject) trade.trade);
    }

    public BarSeries CompressBars(BarType barType, long barSize)
    {
      return DataManager.CompressBars(this, barType, barSize);
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) new TradeSeries.TradeSeriesEnumerator(this.series);
    }

    private class TradeSeriesEnumerator : IEnumerator
    {
      private TradeArray series;
      private IEnumerator enumerator;

      public object Current
      {
        get
        {
          return (object) new Trade(this.enumerator.Current as SmartQuant.Data.Trade);
        }
      }

      public TradeSeriesEnumerator(TradeArray series)
      {
        this.series = series;
        this.enumerator = series.GetEnumerator();
      }

      public bool MoveNext()
      {
        return this.enumerator.MoveNext();
      }

      public void Reset()
      {
        this.enumerator.Reset();
      }
    }
  }
}
