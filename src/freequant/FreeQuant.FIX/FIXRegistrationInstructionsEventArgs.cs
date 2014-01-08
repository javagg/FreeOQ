using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRegistrationInstructionsEventArgs : EventArgs
  {
    private FIXRegistrationInstructions TrcU7TBOHN;

    public FIXRegistrationInstructions RegistrationInstructions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TrcU7TBOHN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.TrcU7TBOHN = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRegistrationInstructionsEventArgs(FIXRegistrationInstructions RegistrationInstructions)
    {
      this.TrcU7TBOHN = RegistrationInstructions;
    }
  }
}
