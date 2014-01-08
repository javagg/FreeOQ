using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXStipulationsEventArgs : EventArgs
  {
    private FIXStipulations a8dudTm6jP;

    public FIXStipulations Stipulations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a8dudTm6jP;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a8dudTm6jP = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStipulationsEventArgs(FIXStipulations Stipulations)
    {
      this.a8dudTm6jP = Stipulations;
    }
  }
}
