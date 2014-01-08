using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXLegStipulationsEventArgs : EventArgs
  {
    private FIXLegStipulations kHfZyFxaCC;

    public FIXLegStipulations LegStipulations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kHfZyFxaCC;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.kHfZyFxaCC = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegStipulationsEventArgs(FIXLegStipulations LegStipulations)
    {
      this.kHfZyFxaCC = LegStipulations;
    }
  }
}
