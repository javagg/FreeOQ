using FreeQuant.FIX;
using FreeQuant.FIXData;

namespace FreeQuant.Providers
{
	public class CorporateActionEventArgs : IntradayEventArgs
	{
		public CorporateAction CorporateAction { get; private set; }

		public CorporateActionEventArgs(CorporateAction corporateAction, IFIXInstrument instrument, IMarketDataProvider provider) 
			: base(instrument, provider)
		{
			this.CorporateAction = corporateAction; 
		}
	}
}
