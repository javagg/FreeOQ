using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMarketDataIncrementalRefreshEventArgs : EventArgs
  {
    private FIXMarketDataIncrementalRefresh e1bAdq5Qo5;

    public FIXMarketDataIncrementalRefresh MarketDataIncrementalRefresh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.e1bAdq5Qo5;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.e1bAdq5Qo5 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMarketDataIncrementalRefreshEventArgs(FIXMarketDataIncrementalRefresh MarketDataIncrementalRefresh)
    {
      this.e1bAdq5Qo5 = MarketDataIncrementalRefresh;
    }
  }
}
