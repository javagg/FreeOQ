using OpenQuant.ObjectMap;
using FreeQuant.Data;
using FreeQuant.Execution;

namespace OpenQuant.API
{
	internal class ObjectConverter : IObjectConverter
	{
		public object Convert(FreeQuant.Data.Bar bar)
		{
			return new Bar(bar);
		}

		public object Convert(FreeQuant.Instruments.Portfolio portfolio)
		{
			return new Portfolio(portfolio);
		}

		public object Convert(SingleOrder order)
		{
			return new Order(order);
		}

		public object Convert(FreeQuant.Data.Trade trade)
		{
			return new Trade(trade);
		}

		public object Convert(FreeQuant.Data.Quote quote)
		{
			return new Quote(quote);
		}

		public object Convert(FreeQuant.Providers.ProviderError error)
		{
			return new ProviderError(error);
		}

		public object Convert(MarketDepth marketDepth)
		{
			return new OrderBookUpdate(marketDepth);
		}
	}
}
