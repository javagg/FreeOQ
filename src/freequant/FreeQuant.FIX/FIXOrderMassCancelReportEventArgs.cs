using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXOrderMassCancelReportEventArgs : EventArgs
  {
    private FIXOrderMassCancelReport E1nu1hsOcK;

    public FIXOrderMassCancelReport OrderMassCancelReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.E1nu1hsOcK;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.E1nu1hsOcK = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXOrderMassCancelReportEventArgs(FIXOrderMassCancelReport OrderMassCancelReport)
    {
      this.E1nu1hsOcK = OrderMassCancelReport;
    }
  }
}
