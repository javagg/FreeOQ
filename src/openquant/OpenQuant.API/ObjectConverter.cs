using OpenQuant.ObjectMap;
using FreeQuant.Data;
using FreeQuant.Execution;

namespace OpenQuant.API
{
  internal class ObjectConverter : IObjectConverter
  {
    public object Convert(FreeQuant.Data.Bar bar)
    {
      return (object) new Bar(bar);
    }

    public object Convert(FreeQuant.Instruments.Portfolio portfolio)
    {
      return (object) new Portfolio(portfolio);
    }

    public object Convert(SingleOrder order)
    {
      return (object) new Order(order);
    }

    public object Convert(FreeQuant.Data.Trade trade)
    {
      return (object) new Trade(trade);
    }

    public object Convert(FreeQuant.Data.Quote quote)
    {
      return (object) new Quote(quote);
    }

    public object Convert(FreeQuant.Providers.ProviderError error)
    {
      return (object) new ProviderError(error);
    }

    public object Convert(MarketDepth marketDepth)
    {
      return (object) new OrderBookUpdate(marketDepth);
    }
  }
}
