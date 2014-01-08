using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class ExecutionReportEventArgs : EventArgs
  {
    public ExecutionReport Report { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionReportEventArgs(ExecutionReport report)
    {
      this.Report = report;
    }
  }
}
