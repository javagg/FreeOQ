using FreeQuant.Data;
using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	[Serializable]
	public class TradeEventArgs : IntradayEventArgs
	{
		public Trade Trade { get; private set; }

		public TradeEventArgs(Trade trade, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.Trade = trade;
		}
	}
}
