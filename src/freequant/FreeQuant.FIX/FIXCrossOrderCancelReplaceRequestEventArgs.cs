using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCrossOrderCancelReplaceRequestEventArgs : EventArgs
  {
    private FIXCrossOrderCancelReplaceRequest Vq38VWgxQj;

    public FIXCrossOrderCancelReplaceRequest CrossOrderCancelReplaceRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Vq38VWgxQj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Vq38VWgxQj = value;
      }
    }

    public FIXCrossOrderCancelReplaceRequestEventArgs(FIXCrossOrderCancelReplaceRequest CrossOrderCancelReplaceRequest)
    {
      this.Vq38VWgxQj = CrossOrderCancelReplaceRequest;
    }
  }
}
