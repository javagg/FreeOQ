using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	[Serializable]
	public class MarketDataEventArgs : IntradayEventArgs
	{
		private IMarketData marketData;

		public IMarketData MarketData
		{
			get
			{
				return this.marketData; 
			}
		}

		public MarketDataEventArgs(IMarketData data, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{

			this.marketData = data;
		}
	}
}
