using FreeQuant.Data;
using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class MarketDepthEventArgs : IntradayEventArgs
	{
		public MarketDepth MarketDepth { get; private set; }

		public MarketDepthEventArgs(MarketDepth marketDepth, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.MarketDepth = marketDepth;
		}
	}
}
