using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	public class MarketDataSnapshotEventArgs : EventArgs
	{
		public FIXMarketDataSnapshot Snapshot { get; private set; }
		public MarketDataSnapshotEventArgs(FIXMarketDataSnapshot snapshot) : base()
		{
			this.Snapshot = snapshot;
		}
	}
}
