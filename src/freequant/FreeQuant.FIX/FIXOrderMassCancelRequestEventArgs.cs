using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderMassCancelRequestEventArgs : EventArgs
  {
    private FIXOrderMassCancelRequest R5Y8JLAhIW;

    public FIXOrderMassCancelRequest OrderMassCancelRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.R5Y8JLAhIW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.R5Y8JLAhIW = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderMassCancelRequestEventArgs(FIXOrderMassCancelRequest OrderMassCancelRequest)
    {
      this.R5Y8JLAhIW = OrderMassCancelRequest;
    }
  }
}
