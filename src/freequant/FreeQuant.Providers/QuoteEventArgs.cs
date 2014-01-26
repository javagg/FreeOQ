using FreeQuant.Data;
using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	[Serializable]
	public class QuoteEventArgs : IntradayEventArgs
	{
		public Quote Quote { get; private set; }

		public QuoteEventArgs(Quote quote, IFIXInstrument instrument, IMarketDataProvider provider)
			: base(instrument, provider)
		{
			this.Quote = quote;
		}
	}
}
