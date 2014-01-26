using FreeQuant.Data;
using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	[Serializable]
	public class MarketDataEventArgs : IntradayEventArgs
	{
		public IMarketData MarketData { get; private set; }

		public MarketDataEventArgs(IMarketData data, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{

			this.MarketData = data;
		}
	}
}
