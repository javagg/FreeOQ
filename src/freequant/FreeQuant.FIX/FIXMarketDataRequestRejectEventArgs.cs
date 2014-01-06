// Type: SmartQuant.FIX.FIXMarketDataRequestRejectEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXMarketDataRequestRejectEventArgs : EventArgs
  {
    private FIXMarketDataRequestReject GucZkCFb6F;

    public FIXMarketDataRequestReject MarketDataRequestReject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GucZkCFb6F;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GucZkCFb6F = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMarketDataRequestRejectEventArgs(FIXMarketDataRequestReject MarketDataRequestReject)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.GucZkCFb6F = MarketDataRequestReject;
    }
  }
}
