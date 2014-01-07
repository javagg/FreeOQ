using FreeQuant.Data;

namespace FreeQuant.Providers
{
  public interface IMarketDataFilter
  {
    Quote FilterQuote(Quote quote, string symbol);

    Trade FilterTrade(Trade trade, string symbol);

    Bar FilterBarOpen(Bar bar, string symbol);

    Bar FilterBar(Bar bar, string symbol);
  }
}
