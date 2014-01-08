using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCollateralReportEventArgs : EventArgs
  {
    private FIXCollateralReport Sk5U2MgiGi;

    public FIXCollateralReport CollateralReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Sk5U2MgiGi;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Sk5U2MgiGi = value;
      }
    }

    public FIXCollateralReportEventArgs(FIXCollateralReport CollateralReport)
    {
      this.Sk5U2MgiGi = CollateralReport;
    }
  }
}
