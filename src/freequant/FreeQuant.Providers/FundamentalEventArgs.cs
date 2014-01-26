using FreeQuant.FIX;
using FreeQuant.FIXData;

namespace FreeQuant.Providers
{
	public class FundamentalEventArgs : IntradayEventArgs
	{
		public Fundamental Fundamental { get; private set; }

		public FundamentalEventArgs(Fundamental fundamental, IFIXInstrument instrument, IMarketDataProvider provider) 
			: base(instrument, provider)
		{
			this.Fundamental = fundamental; 
		}
	}
}
