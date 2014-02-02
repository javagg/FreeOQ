using FreeQuant.Data;
using FreeQuant.Execution;
using FreeQuant.Instruments;
using FreeQuant.Providers;

namespace OpenQuant.ObjectMap
{
	public interface IObjectConverter
	{
		object Convert(Bar bar);
		object Convert(Portfolio portfolio);
		object Convert(SingleOrder order);
		object Convert(Trade trade);
		object Convert(Quote quote);
		object Convert(ProviderError error);
		object Convert(MarketDepth marketDepth);
	}
}
