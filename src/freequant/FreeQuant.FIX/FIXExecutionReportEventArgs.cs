using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXExecutionReportEventArgs : EventArgs
  {
    private FIXExecutionReport VhfuUiEk7S;

    public FIXExecutionReport ExecutionReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VhfuUiEk7S;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.VhfuUiEk7S = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXExecutionReportEventArgs(FIXExecutionReport ExecutionReport)
    {
      this.VhfuUiEk7S = ExecutionReport;
    }
  }
}
