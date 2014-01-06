using OpenQuant.ObjectMap;
using FreeQuant.Data;
using FreeQuant.Execution;

namespace OpenQuant.API
{
  internal class ObjectConverter : IObjectConverter
  {
    public object Convert(SmartQuant.Data.Bar bar)
    {
      return (object) new Bar(bar);
    }

    public object Convert(SmartQuant.Instruments.Portfolio portfolio)
    {
      return (object) new Portfolio(portfolio);
    }

    public object Convert(SingleOrder order)
    {
      return (object) new Order(order);
    }

    public object Convert(SmartQuant.Data.Trade trade)
    {
      return (object) new Trade(trade);
    }

    public object Convert(SmartQuant.Data.Quote quote)
    {
      return (object) new Quote(quote);
    }

    public object Convert(SmartQuant.Providers.ProviderError error)
    {
      return (object) new ProviderError(error);
    }

    public object Convert(MarketDepth marketDepth)
    {
      return (object) new OrderBookUpdate(marketDepth);
    }
  }
}
