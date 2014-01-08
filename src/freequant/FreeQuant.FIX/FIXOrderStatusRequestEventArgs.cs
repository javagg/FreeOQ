using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderStatusRequestEventArgs : EventArgs
  {
    private FIXOrderStatusRequest gILXhmsFP;

    public FIXOrderStatusRequest OrderStatusRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gILXhmsFP;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gILXhmsFP = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderStatusRequestEventArgs(FIXOrderStatusRequest OrderStatusRequest)
    {
      this.gILXhmsFP = OrderStatusRequest;
    }
  }
}
