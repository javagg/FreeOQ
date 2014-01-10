using FreeQuant.FIX;
using FreeQuant.FIXData;

namespace FreeQuant.Providers
{
	public class CorporateActionEventArgs : IntradayEventArgs
	{
		private CorporateAction action;

		public CorporateAction CorporateAction
		{
			get
			{
				return this.action;
			}
		}

		public CorporateActionEventArgs(CorporateAction corporateAction, IFIXInstrument instrument, IMarketDataProvider provider) : base(instrument, provider)
		{
			this.action = corporateAction; 
		}
	}
}
