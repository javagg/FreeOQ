using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXConfirmationRequestEventArgs : EventArgs
  {
    private FIXConfirmationRequest mmeZNXGP3Y;

    public FIXConfirmationRequest ConfirmationRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mmeZNXGP3Y;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.mmeZNXGP3Y = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXConfirmationRequestEventArgs(FIXConfirmationRequest ConfirmationRequest)
    {
      this.mmeZNXGP3Y = ConfirmationRequest;
    }
  }
}
