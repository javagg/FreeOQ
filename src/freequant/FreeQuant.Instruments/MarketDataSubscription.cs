using FreeQuant.Providers;

namespace FreeQuant.Instruments
{
	public class MarketDataSubscription
	{
		public IMarketDataProvider Provider { get; private set; }

		public Instrument Instrument { get; private set; }

		public MarketDataType MDType { get; private set; }

		public int Count { get; private set; }

		internal MarketDataSubscription(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, int count)
		{
			this.Provider = provider;
			this.Instrument = instrument;
			this.MDType = mdType;
			this.Count = count;
		}
	}
}
