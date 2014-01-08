using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class PositionReportEventArgs : EventArgs
  {
    private PositionReport APAyjTPyig;

    public PositionReport PositionReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.APAyjTPyig;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionReportEventArgs(PositionReport report)
    {

      this.APAyjTPyig = report;
    }
  }
}
