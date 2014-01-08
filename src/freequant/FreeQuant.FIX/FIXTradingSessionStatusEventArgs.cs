using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTradingSessionStatusEventArgs : EventArgs
  {
    private FIXTradingSessionStatus sE07SwvC7k;

    public FIXTradingSessionStatus TradingSessionStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sE07SwvC7k;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.sE07SwvC7k = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTradingSessionStatusEventArgs(FIXTradingSessionStatus TradingSessionStatus)
    {
      this.sE07SwvC7k = TradingSessionStatus;
    }
  }
}
