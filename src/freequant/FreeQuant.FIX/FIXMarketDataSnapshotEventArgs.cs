using System;

namespace FreeQuant.FIX
{
	public class FIXMarketDataSnapshotEventArgs : EventArgs
	{
		public FIXMarketDataSnapshot MarketDataSnapshotFullRefresh { get; set; }

		public FIXMarketDataSnapshotEventArgs(FIXMarketDataSnapshot marketDataSnapshotFullRefresh)
		{
			this.MarketDataSnapshotFullRefresh = marketDataSnapshotFullRefresh;
		}
	}
}
