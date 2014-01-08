using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAllocationReportEventArgs : EventArgs
  {
    private FIXAllocationReport y4UIdWAPE;

    public FIXAllocationReport AllocationReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.y4UIdWAPE;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.y4UIdWAPE = value;
      }
    }

    public FIXAllocationReportEventArgs(FIXAllocationReport AllocationReport)
    {
      this.y4UIdWAPE = AllocationReport;
    }
  }
}
