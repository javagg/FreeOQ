using FreeQuant.Providers;

namespace OpenQuant.API
{
  internal class SQMarketDataFilter : IMarketDataFilter
  {
    private MarketDataFilter oqFilter;

    internal SQMarketDataFilter(MarketDataFilter oqFilter)
    {
      this.oqFilter = oqFilter;
    }

    public SmartQuant.Data.Quote FilterQuote(SmartQuant.Data.Quote quote, string symbol)
    {
      Quote quote1 = this.oqFilter.FilterQuote(new Quote(quote), symbol);
      if (quote1 == null)
        return (SmartQuant.Data.Quote) null;
      else
        return quote1.quote;
    }

    public SmartQuant.Data.Trade FilterTrade(SmartQuant.Data.Trade trade, string symbol)
    {
      Trade trade1 = this.oqFilter.FilterTrade(new Trade(trade), symbol);
      if (trade1 == null)
        return (SmartQuant.Data.Trade) null;
      else
        return trade1.trade;
    }

    public SmartQuant.Data.Bar FilterBar(SmartQuant.Data.Bar bar, string symbol)
    {
      Bar bar1 = this.oqFilter.FilterBar(new Bar(bar), symbol);
      if (bar1 != null)
        return bar1.bar;
      else
        return (SmartQuant.Data.Bar) null;
    }

    public SmartQuant.Data.Bar FilterBarOpen(SmartQuant.Data.Bar bar, string symbol)
    {
      Bar bar1 = this.oqFilter.FilterBarOpen(new Bar(bar), symbol);
      if (bar1 != null)
        return bar1.bar;
      else
        return (SmartQuant.Data.Bar) null;
    }
  }
}
