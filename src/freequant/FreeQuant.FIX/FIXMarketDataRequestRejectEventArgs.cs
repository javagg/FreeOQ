using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
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
      this.GucZkCFb6F = MarketDataRequestReject;
    }
  }
}
