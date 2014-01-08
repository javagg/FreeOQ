using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNewOrderSingleEventArgs : EventArgs
  {
    private FIXNewOrderSingle lVXYgxRTvp;

    public FIXNewOrderSingle NewOrderSingle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lVXYgxRTvp;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.lVXYgxRTvp = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNewOrderSingleEventArgs(FIXNewOrderSingle NewOrderSingle)
    {
      this.lVXYgxRTvp = NewOrderSingle;
    }
  }
}
