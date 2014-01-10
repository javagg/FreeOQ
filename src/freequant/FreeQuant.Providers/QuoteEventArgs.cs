using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	[Serializable]
	public class QuoteEventArgs : IntradayEventArgs
	{
		private Quote quote;

		public Quote Quote
		{
			get
			{
				return this.quote; 
			}
		}

		public QuoteEventArgs(Quote quote, IFIXInstrument instrument, IMarketDataProvider provider)
			: base(instrument, provider)
		{
			this.quote = quote;
		}
	}
}
