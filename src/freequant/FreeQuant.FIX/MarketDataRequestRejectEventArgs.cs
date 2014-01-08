using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class MarketDataRequestRejectEventArgs : EventArgs
  {
    private MarketDataRequestReject ArcQzX6KuU;

    public MarketDataRequestReject MarketDataRequestReject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ArcQzX6KuU;
      }
    }

    public MarketDataRequestRejectEventArgs(MarketDataRequestReject reject)
    {

      this.ArcQzX6KuU = reject;
    }
  }
}
