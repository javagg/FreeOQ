using System;

namespace FreeQuant.FIX
{
	public class MarketDataRequestRejectEventArgs : EventArgs
	{
		public MarketDataRequestReject MarketDataRequestReject { get; private set; }

		public MarketDataRequestRejectEventArgs(MarketDataRequestReject reject)
		{

			this.MarketDataRequestReject = reject;
		}
	}
}
