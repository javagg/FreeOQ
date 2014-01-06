namespace OpenQuant.API
{
  public class MarketDataFilter
  {
    internal SQMarketDataFilter SQfilter { get; private set; }

    public MarketDataFilter()
    {
      this.SQfilter = new SQMarketDataFilter(this);
    }

    public virtual Quote FilterQuote(Quote quote, string symbol)
    {
      return quote;
    }

    public virtual Trade FilterTrade(Trade trade, string symbol)
    {
      return trade;
    }

    public virtual Bar FilterBar(Bar bar, string symbol)
    {
      return bar;
    }

    public virtual Bar FilterBarOpen(Bar bar, string symbol)
    {
      return bar;
    }
  }
}
