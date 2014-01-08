using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMarketDataRequestEventArgs : EventArgs
  {
    private FIXMarketDataRequest l1XhJsJ2p5;

    public FIXMarketDataRequest MarketDataRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.l1XhJsJ2p5;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.l1XhJsJ2p5 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMarketDataRequestEventArgs(FIXMarketDataRequest MarketDataRequest)
    {
      this.l1XhJsJ2p5 = MarketDataRequest;
    }
  }
}
