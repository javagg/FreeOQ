using FreeQuant.Data;
using FreeQuant.FIX;
using System;

namespace FreeQuant.Providers
{
	[Serializable]
	public class BarEventArgs : IntradayEventArgs
	{
		public Bar Bar { get; private set; }
		public BarEventArgs(Bar bar, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.Bar = bar;
		}
	}
}
