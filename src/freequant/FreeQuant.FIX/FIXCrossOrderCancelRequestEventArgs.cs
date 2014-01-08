using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCrossOrderCancelRequestEventArgs : EventArgs
  {
    private FIXCrossOrderCancelRequest nohQX6Ij2m;

    public FIXCrossOrderCancelRequest CrossOrderCancelRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nohQX6Ij2m;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nohQX6Ij2m = value;
      }
    }

    public FIXCrossOrderCancelRequestEventArgs(FIXCrossOrderCancelRequest CrossOrderCancelRequest)
    {
      this.nohQX6Ij2m = CrossOrderCancelRequest;
    }
  }
}
