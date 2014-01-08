using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderMassStatusRequestEventArgs : EventArgs
  {
    private FIXOrderMassStatusRequest O0YQTsxGZM;

    public FIXOrderMassStatusRequest OrderMassStatusRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.O0YQTsxGZM;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.O0YQTsxGZM = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderMassStatusRequestEventArgs(FIXOrderMassStatusRequest OrderMassStatusRequest)
    {
      this.O0YQTsxGZM = OrderMassStatusRequest;
    }
  }
}
