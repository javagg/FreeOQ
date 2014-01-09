using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXConfirmationEventArgs : EventArgs
  {
    private FIXConfirmation rMxYwaVcfG;

    public FIXConfirmation Confirmation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rMxYwaVcfG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rMxYwaVcfG = value;
      }
    }

    public FIXConfirmationEventArgs(FIXConfirmation Confirmation) :base()
    {
      this.rMxYwaVcfG = Confirmation;
    }
  }
}
