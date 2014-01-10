using FreeQuant.FIX;

namespace FreeQuant.Services
{
  public class LogonEventArgs : MarketServiceEventArgs
  {
    private FIXLogon logon;

    public FIXLogon Logon
    {
       get
      {
				return this.logon; 
      }
    }
    
		public LogonEventArgs(IMarketService service, FIXLogon logon):base(service)
    {
      this.logon = logon;
    }
  }
}
