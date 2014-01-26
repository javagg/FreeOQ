using System;

namespace FreeQuant.FIX
{
	public class FIXMarketDataRequestRejectEventArgs : EventArgs
	{
		public FIXMarketDataRequestReject MarketDataRequestReject { get; set; }

		public FIXMarketDataRequestRejectEventArgs(FIXMarketDataRequestReject marketDataRequestReject)
		{
			this.MarketDataRequestReject = marketDataRequestReject;
		}
	}
}
