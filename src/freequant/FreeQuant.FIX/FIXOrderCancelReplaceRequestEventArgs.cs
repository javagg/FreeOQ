using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderCancelReplaceRequestEventArgs : EventArgs
  {
    private FIXOrderCancelReplaceRequest aHbUeFvBSk;

    public FIXOrderCancelReplaceRequest OrderCancelReplaceRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aHbUeFvBSk;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aHbUeFvBSk = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderCancelReplaceRequestEventArgs(FIXOrderCancelReplaceRequest OrderCancelReplaceRequest)
    {
      this.aHbUeFvBSk = OrderCancelReplaceRequest;
    }
  }
}
