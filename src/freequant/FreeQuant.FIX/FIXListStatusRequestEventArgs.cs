using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXListStatusRequestEventArgs : EventArgs
  {
    private FIXListStatusRequest wtqUaFP9AA;

    public FIXListStatusRequest ListStatusRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wtqUaFP9AA;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.wtqUaFP9AA = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXListStatusRequestEventArgs(FIXListStatusRequest ListStatusRequest)
    {

      this.wtqUaFP9AA = ListStatusRequest;
    }
  }
}
