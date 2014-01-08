using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionAmountDataEventArgs : EventArgs
  {
    private FIXPositionAmountData Fb1tQqmGXx;

    public FIXPositionAmountData PositionAmountData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Fb1tQqmGXx;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Fb1tQqmGXx = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionAmountDataEventArgs(FIXPositionAmountData PositionAmountData)
    {
      this.Fb1tQqmGXx = PositionAmountData;
    }
  }
}
