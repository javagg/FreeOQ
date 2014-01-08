using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXUnderlyingStipulationsEventArgs : EventArgs
  {
    private FIXUnderlyingStipulations Hl8A3xCLb8;

    public FIXUnderlyingStipulations UnderlyingStipulations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Hl8A3xCLb8;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Hl8A3xCLb8 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXUnderlyingStipulationsEventArgs(FIXUnderlyingStipulations UnderlyingStipulations)
    {
      this.Hl8A3xCLb8 = UnderlyingStipulations;
    }
  }
}
