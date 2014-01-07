using dW79p7NPlS6ZxObcx3;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class MarketDataSnapshotEventArgs : EventArgs
  {
    private FIXMarketDataSnapshot aAwLZAiufn;

    public FIXMarketDataSnapshot Snapshot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aAwLZAiufn;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDataSnapshotEventArgs(FIXMarketDataSnapshot snapshot)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aAwLZAiufn = snapshot;
    }
  }
}
