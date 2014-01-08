using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAssignmentReportEventArgs : EventArgs
  {
    private FIXAssignmentReport WM0YJpOHnM;

    public FIXAssignmentReport AssignmentReport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WM0YJpOHnM;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WM0YJpOHnM = value;
      }
    }

   public FIXAssignmentReportEventArgs(FIXAssignmentReport AssignmentReport)
    {
      this.WM0YJpOHnM = AssignmentReport;
    }
  }
}
