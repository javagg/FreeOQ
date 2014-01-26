using System;

namespace FreeQuant.FIX
{
	public class FIXMarketDataRequestEventArgs : EventArgs
	{
		public FIXMarketDataRequest MarketDataRequest { get; set; }

		public FIXMarketDataRequestEventArgs(FIXMarketDataRequest marketDataRequest)
		{
			this.MarketDataRequest = marketDataRequest;
		}
	}
}
