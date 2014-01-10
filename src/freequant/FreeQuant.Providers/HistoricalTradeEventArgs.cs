using FreeQuant.Data;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class HistoricalTradeEventArgs : HistoricalDataEventArgs
	{
		private Trade trade;

		public Trade Trade
		{
			get
			{
				return this.trade; 
			}
		}

		public HistoricalTradeEventArgs(Trade trade, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
			: base(requestId, instrument, provider, dataLength)
		{

			this.trade = trade; 
		}
	}
}
