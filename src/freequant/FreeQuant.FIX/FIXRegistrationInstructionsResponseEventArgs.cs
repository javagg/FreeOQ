using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXRegistrationInstructionsResponseEventArgs : EventArgs
  {
    private FIXRegistrationInstructionsResponse eI47ZR4J0A;

    public FIXRegistrationInstructionsResponse RegistrationInstructionsResponse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.eI47ZR4J0A;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.eI47ZR4J0A = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXRegistrationInstructionsResponseEventArgs(FIXRegistrationInstructionsResponse RegistrationInstructionsResponse)
    {
      this.eI47ZR4J0A = RegistrationInstructionsResponse;
    }
  }
}
