using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionMaintenanceReportEventArgs : EventArgs
  {
    private FIXPositionMaintenanceReport oJsYU0AWvE;

    public FIXPositionMaintenanceReport PositionMaintenanceReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.oJsYU0AWvE;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.oJsYU0AWvE = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionMaintenanceReportEventArgs(FIXPositionMaintenanceReport PositionMaintenanceReport)
    {
      this.oJsYU0AWvE = PositionMaintenanceReport;
    }
  }
}
