using FreeQuant.Data;
using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class HistoricalMarketDepthEventArgs : HistoricalDataEventArgs
	{
		public MarketDepth MarketDepth { get; private set; }

		public HistoricalMarketDepthEventArgs(MarketDepth marketDepth, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
			: base(requestId, instrument, provider, dataLength)
		{
			this.MarketDepth = marketDepth;
		}
	}
}
