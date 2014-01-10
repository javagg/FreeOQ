using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class MarketDataProviderList : ProviderList
	{
		public IMarketDataProvider this [string name]
		{
			get
			{
				return base[name] as IMarketDataProvider;
			}
		}

		public IMarketDataProvider this [byte id]
		{
			get
			{
				return base[id] as IMarketDataProvider;
			}
		}
	}
}
