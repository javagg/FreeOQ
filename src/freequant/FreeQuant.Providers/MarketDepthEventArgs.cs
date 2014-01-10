using FreeQuant.Data;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class MarketDepthEventArgs : IntradayEventArgs
	{
		private MarketDepth marketDepth;

		public MarketDepth MarketDepth
		{
			get
			{
				return this.marketDepth; 
			}
		}

		public MarketDepthEventArgs(MarketDepth marketDepth, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.marketDepth = marketDepth;
		}
	}
}
