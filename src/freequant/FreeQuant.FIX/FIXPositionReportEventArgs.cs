using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionReportEventArgs : EventArgs
  {
    private FIXPositionReport kLQ7bDqKXJ;

    public FIXPositionReport PositionReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kLQ7bDqKXJ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.kLQ7bDqKXJ = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionReportEventArgs(FIXPositionReport PositionReport)
    {

      this.kLQ7bDqKXJ = PositionReport;
    }
  }
}
