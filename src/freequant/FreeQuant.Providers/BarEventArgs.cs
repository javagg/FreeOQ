using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	[Serializable]
	public class BarEventArgs : IntradayEventArgs
	{
		private FreeQuant.Data.Bar bar;

		public Bar Bar
		{
			get
			{
				return this.bar;
			}
		}

		public BarEventArgs(FreeQuant.Data.Bar bar, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.bar = bar;
		}
	}
}
