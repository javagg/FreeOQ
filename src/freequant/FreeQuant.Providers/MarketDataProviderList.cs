namespace FreeQuant.Providers
{
	public class MarketDataProviderList : ProviderList
	{
		new public IMarketDataProvider this[string name]
		{
			get
			{
				return base[name] as IMarketDataProvider;
			}
		}

		new public IMarketDataProvider this [byte id]
		{
			get
			{
				return base[id] as IMarketDataProvider;
			}
		}
	}
}
