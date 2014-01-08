using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAllocationReportAckEventArgs : EventArgs
  {
    private FIXAllocationReportAck l4Ghgoi1ZH;

    public FIXAllocationReportAck AllocationReportAck
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.l4Ghgoi1ZH;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.l4Ghgoi1ZH = value;
      }
    }

    public FIXAllocationReportAckEventArgs(FIXAllocationReportAck AllocationReportAck)
    {
      this.l4Ghgoi1ZH = AllocationReportAck;
    }
  }
}
