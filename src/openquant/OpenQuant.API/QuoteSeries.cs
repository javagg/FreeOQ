using FreeQuant.Data;
using FreeQuant.Series;
using System.Collections;

namespace OpenQuant.API
{
  public class QuoteSeries : IEnumerable
  {
    internal QuoteArray series;

    public int Count
    {
      get
      {
        return this.series.Count;
      }
    }

    public Quote Last
    {
      get
      {
        if (this.series.Count > 0)
          return new Quote(this.series[this.series.Count - 1]);
        else
          return (Quote) null;
      }
    }

    public Quote this[int index]
    {
      get
      {
        return new Quote(this.series[index]);
      }
    }

    internal QuoteSeries(QuoteArray series)
    {
      this.series = series;
    }

    public QuoteSeries()
    {
      this.series = new QuoteArray();
    }

    public void Add(Quote quote)
    {
      this.series.Add((IDataObject) quote.quote);
    }

    public BarSeries CompressBars(QuoteData input, BarType barType, long barSize)
    {
      return DataManager.CompressBars(this, input, barType, barSize);
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) new QuoteSeries.QuoteSeriesEnumerator(this.series);
    }

    private class QuoteSeriesEnumerator : IEnumerator
    {
      private QuoteArray series;
      private IEnumerator enumerator;

      public object Current
      {
        get
        {
          return (object) new Quote(this.enumerator.Current as SmartQuant.Data.Quote);
        }
      }

      internal QuoteSeriesEnumerator(QuoteArray series)
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
