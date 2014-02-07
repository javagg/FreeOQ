using FreeQuant.FIX;

namespace FreeQuant.Services
{
	public class LogonEventArgs : MarketServiceEventArgs
	{
		public FIXLogon Logon { get; private set; }

		public LogonEventArgs(IMarketService service, FIXLogon logon) : base(service)
		{
			this.Logon = logon;
		}
	}
}
