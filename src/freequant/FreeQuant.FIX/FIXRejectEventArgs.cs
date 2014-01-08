using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRejectEventArgs : EventArgs
  {
    private FIXReject AjgUoLL3YZ;

    public FIXReject Reject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.AjgUoLL3YZ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AjgUoLL3YZ = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRejectEventArgs(FIXReject Reject)
    {

      this.AjgUoLL3YZ = Reject;
    }
  }
}
