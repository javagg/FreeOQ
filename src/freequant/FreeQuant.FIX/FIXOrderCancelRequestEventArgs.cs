using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderCancelRequestEventArgs : EventArgs
  {
    private FIXOrderCancelRequest A82twUXinA;

    public FIXOrderCancelRequest OrderCancelRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.A82twUXinA;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.A82twUXinA = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderCancelRequestEventArgs(FIXOrderCancelRequest OrderCancelRequest)
    {
      this.A82twUXinA = OrderCancelRequest;
    }
  }
}
