using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDiscretionInstructionsEventArgs : EventArgs
  {
    private FIXDiscretionInstructions x7vtPCi8ym;

    public FIXDiscretionInstructions DiscretionInstructions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.x7vtPCi8ym;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.x7vtPCi8ym = value;
      }
    }

    public FIXDiscretionInstructionsEventArgs(FIXDiscretionInstructions DiscretionInstructions)
    {
      this.x7vtPCi8ym = DiscretionInstructions;
    }
  }
}
