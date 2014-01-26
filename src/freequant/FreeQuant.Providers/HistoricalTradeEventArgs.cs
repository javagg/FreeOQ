using FreeQuant.Data;
using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class HistoricalTradeEventArgs : HistoricalDataEventArgs
	{
		public Trade Trade { get; private set; }

		public HistoricalTradeEventArgs(Trade trade, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
			: base(requestId, instrument, provider, dataLength)
		{
			this.Trade = trade; 
		}
	}
}
