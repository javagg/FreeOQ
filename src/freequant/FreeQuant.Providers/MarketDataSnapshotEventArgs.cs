using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	public class MarketDataSnapshotEventArgs : EventArgs
	{
		private FIXMarketDataSnapshot snapshot;

		public FIXMarketDataSnapshot Snapshot
		{
			get
			{
				return this.snapshot; 
			}
		}

		public MarketDataSnapshotEventArgs(FIXMarketDataSnapshot snapshot) : base()
		{
			this.snapshot = snapshot;
		}
	}
}
