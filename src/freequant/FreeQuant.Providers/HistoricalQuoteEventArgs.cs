using FreeQuant.Data;
using FreeQuant.FIX;

namespace FreeQuant.Providers
{
	public class HistoricalQuoteEventArgs : HistoricalDataEventArgs
	{
		public Quote Quote { get; private set; }
		public HistoricalQuoteEventArgs(Quote quote, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
			: base(requestId, instrument, provider, dataLength)
		{
			this.Quote = quote; 
		}
	}
}
