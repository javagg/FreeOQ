using FreeQuant.Data;
using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class HistoricalMarketDepthEventArgs : HistoricalDataEventArgs
	{
		private MarketDepth marketDepth;

		public MarketDepth MarketDepth
		{
			get
			{
				return this.marketDepth; 
			}
		}

		public HistoricalMarketDepthEventArgs(MarketDepth marketDepth, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
			: base(requestId, instrument, provider, dataLength)
		{
			this.marketDepth = marketDepth;
		}
	}
}
