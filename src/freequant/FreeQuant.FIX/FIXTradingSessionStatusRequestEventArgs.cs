// Type: SmartQuant.FIX.FIXTradingSessionStatusRequestEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXTradingSessionStatusRequestEventArgs : EventArgs
  {
    private FIXTradingSessionStatusRequest jkjZAysbNb;

    public FIXTradingSessionStatusRequest TradingSessionStatusRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jkjZAysbNb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jkjZAysbNb = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradingSessionStatusRequestEventArgs(FIXTradingSessionStatusRequest TradingSessionStatusRequest)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.jkjZAysbNb = TradingSessionStatusRequest;
    }
  }
}
