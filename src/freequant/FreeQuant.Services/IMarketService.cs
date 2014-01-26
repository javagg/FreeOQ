using FreeQuant.FIX;

namespace FreeQuant.Services
{
	public interface IMarketService : IService
	{
		event FIXLogonEventHandler Logon;
		event FIXLogoutEventHandler Logout;
		void Send(FIXLogon message);
		void Send(FIXLogout message);
	}
}
