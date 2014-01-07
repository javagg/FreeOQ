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

    public FreeQuant.Data.Quote FilterQuote(FreeQuant.Data.Quote quote, string symbol)
    {
      Quote quote1 = this.oqFilter.FilterQuote(new Quote(quote), symbol);
      if (quote1 == null)
        return (FreeQuant.Data.Quote) null;
      else
        return quote1.quote;
    }

    public FreeQuant.Data.Trade FilterTrade(FreeQuant.Data.Trade trade, string symbol)
    {
      Trade trade1 = this.oqFilter.FilterTrade(new Trade(trade), symbol);
      if (trade1 == null)
        return (FreeQuant.Data.Trade) null;
      else
        return trade1.trade;
    }

    public FreeQuant.Data.Bar FilterBar(FreeQuant.Data.Bar bar, string symbol)
    {
      Bar bar1 = this.oqFilter.FilterBar(new Bar(bar), symbol);
      if (bar1 != null)
        return bar1.bar;
      else
        return (FreeQuant.Data.Bar) null;
    }

    public FreeQuant.Data.Bar FilterBarOpen(FreeQuant.Data.Bar bar, string symbol)
    {
      Bar bar1 = this.oqFilter.FilterBarOpen(new Bar(bar), symbol);
      if (bar1 != null)
        return bar1.bar;
      else
        return (FreeQuant.Data.Bar) null;
    }
  }
}
