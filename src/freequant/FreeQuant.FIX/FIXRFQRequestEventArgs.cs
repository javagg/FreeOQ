using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRFQRequestEventArgs : EventArgs
  {
    private FIXRFQRequest ygyto9aVnE;

    public FIXRFQRequest RFQRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ygyto9aVnE;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ygyto9aVnE = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRFQRequestEventArgs(FIXRFQRequest RFQRequest)
    {

      this.ygyto9aVnE = RFQRequest;
    }
  }
}
