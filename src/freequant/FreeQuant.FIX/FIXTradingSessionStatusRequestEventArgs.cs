using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
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
      this.jkjZAysbNb = TradingSessionStatusRequest;
    }
  }
}
