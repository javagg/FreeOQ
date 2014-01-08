using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPegInstructionsEventArgs : EventArgs
  {
    private FIXPegInstructions SW0tYcdOSu;

    public FIXPegInstructions PegInstructions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.SW0tYcdOSu;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SW0tYcdOSu = value;
      }
    }

    public FIXPegInstructionsEventArgs(FIXPegInstructions PegInstructions)
    {
      this.SW0tYcdOSu = PegInstructions;
    }
  }
}
