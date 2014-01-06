using OpenQuant.API;

namespace OpenQuant.API.Compression
{
  internal class TradeDataEnumerator : DataEntryEnumerator
  {
    private TradeSeries series;

    public override DataEntry Current
    {
      get
      {
        Trade trade = this.series[this.index];
        return new DataEntry(trade.DateTime, new PriceSizeItem[1]
        {
          new PriceSizeItem(trade.Price, trade.Size)
        });
      }
    }

    public TradeDataEnumerator(TradeSeries series)
      : base(series.Count)
    {
      this.series = series;
    }
  }
}
