using FreeQuant.FIX;

namespace FreeQuant.Services
{
	public class LogoutEventArgs : MarketServiceEventArgs
	{
		private FIXLogout logout;

		public FIXLogout Logout
		{
			get
			{
				return this.logout; 
			}
		}

		public LogoutEventArgs(IMarketService service, FIXLogout logout) : base(service)
		{
			this.logout = logout;
		}
	}
}
