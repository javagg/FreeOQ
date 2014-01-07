// Type: SmartQuant.Services.LogoutEventArgs
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using SmartQuant.FIX;
using System.Runtime.CompilerServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public class LogoutEventArgs : MarketServiceEventArgs
  {
    private FIXLogout KygeJ11YV;

    public FIXLogout Logout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KygeJ11YV;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogoutEventArgs(IMarketService service, FIXLogout logout)
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector(service);
      this.KygeJ11YV = logout;
    }
  }
}
