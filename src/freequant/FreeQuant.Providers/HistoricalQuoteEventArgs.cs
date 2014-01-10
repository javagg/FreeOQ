using FreeQuant.Data;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class HistoricalQuoteEventArgs : HistoricalDataEventArgs
	{
		private Quote quote;

		public Quote Quote
		{
			get
			{
				return this.quote;
			}
		}

		public HistoricalQuoteEventArgs(Quote quote, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
			: base(requestId, instrument, provider, dataLength)
		{
			this.quote = quote; 
		}
	}
}
