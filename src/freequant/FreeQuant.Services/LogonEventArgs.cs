// Type: SmartQuant.Services.LogonEventArgs
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using SmartQuant.FIX;
using System.Runtime.CompilerServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public class LogonEventArgs : MarketServiceEventArgs
  {
    private FIXLogon R4Afl1Y81;

    public FIXLogon Logon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.R4Afl1Y81;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogonEventArgs(IMarketService service, FIXLogon logon)
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector(service);
      this.R4Afl1Y81 = logon;
    }
  }
}
