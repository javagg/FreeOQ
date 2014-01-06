using OpenQuant.API;

namespace OpenQuant.API.Compression
{
  internal class BarDataEnumerator : DataEntryEnumerator
  {
    private BarSeries series;

    public override DataEntry Current
    {
      get
      {
        Bar bar = this.series[this.index];
        return new DataEntry(bar.DateTime, new PriceSizeItem[4]
        {
          new PriceSizeItem(bar.Open, (int) bar.Volume),
          new PriceSizeItem(bar.High, 0),
          new PriceSizeItem(bar.Low, 0),
          new PriceSizeItem(bar.Close, 0)
        });
      }
    }

    public BarDataEnumerator(BarSeries series)
      : base(series.Count)
    {
      this.series = series;
    }
  }
}
