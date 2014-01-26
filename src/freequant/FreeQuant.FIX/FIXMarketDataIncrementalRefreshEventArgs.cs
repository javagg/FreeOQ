using System;

namespace FreeQuant.FIX
{
	public class FIXMarketDataIncrementalRefreshEventArgs : EventArgs
	{
		public FIXMarketDataIncrementalRefresh MarketDataIncrementalRefresh { get; set; }

		public FIXMarketDataIncrementalRefreshEventArgs(FIXMarketDataIncrementalRefresh marketDataIncrementalRefresh)
		{
			this.MarketDataIncrementalRefresh = marketDataIncrementalRefresh;
		}
	}
}
