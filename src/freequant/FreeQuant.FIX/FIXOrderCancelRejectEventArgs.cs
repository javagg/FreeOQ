using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderCancelRejectEventArgs : EventArgs
  {
    private FIXOrderCancelReject iKCQBodXOb;

    public FIXOrderCancelReject OrderCancelReject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.iKCQBodXOb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.iKCQBodXOb = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderCancelRejectEventArgs(FIXOrderCancelReject OrderCancelReject)
    {
      this.iKCQBodXOb = OrderCancelReject;
    }
  }
}
