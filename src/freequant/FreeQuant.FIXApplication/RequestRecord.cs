// Type: SmartQuant.FIXApplication.RequestRecord
// Assembly: SmartQuant.FIXApplication, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 44426555-807E-4D6E-87F0-79C6A497EF45
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIXApplication.dll

using aX1YwCE8tvUgZCyfib;
using SmartQuant.FIX;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIXApplication
{
  public class RequestRecord
  {
    public string Symbol { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public FIXMarketDataRequest Request { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public int RequestCount { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] internal set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RequestRecord(string symbol, FIXMarketDataRequest request)
    {
      Ni0n2nNTxpPQwXYoJS.cvl3IaMzFxY5E();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Symbol = symbol;
      this.Request = request;
      this.RequestCount = 0;
    }
  }
}
