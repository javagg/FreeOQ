using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMarketDataSnapshotEventArgs : EventArgs
  {
    private FIXMarketDataSnapshot BTZtMe5TS7;

    public FIXMarketDataSnapshot MarketDataSnapshotFullRefresh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.BTZtMe5TS7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.BTZtMe5TS7 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMarketDataSnapshotEventArgs(FIXMarketDataSnapshot MarketDataSnapshotFullRefresh)
    {
      this.BTZtMe5TS7 = MarketDataSnapshotFullRefresh;
    }
  }
}
