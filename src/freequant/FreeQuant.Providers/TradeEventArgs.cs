using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	[Serializable]
	public class TradeEventArgs : IntradayEventArgs
	{
		private Trade trade;

		public Trade Trade
		{
			get
			{
				return this.trade; 
			}
		}

		public TradeEventArgs(Trade trade, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.trade = trade;
		}
	}
}
