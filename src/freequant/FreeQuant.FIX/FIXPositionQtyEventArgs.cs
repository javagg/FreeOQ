using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionQtyEventArgs : EventArgs
  {
    private FIXPositionQty q1sZVU5OaW;

    public FIXPositionQty PositionQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.q1sZVU5OaW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.q1sZVU5OaW = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionQtyEventArgs(FIXPositionQty PositionQty)
    {
      this.q1sZVU5OaW = PositionQty;
    }
  }
}
