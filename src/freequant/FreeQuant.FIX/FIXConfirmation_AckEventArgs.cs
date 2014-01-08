using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXConfirmation_AckEventArgs : EventArgs
  {
    private FIXConfirmation_Ack Gt4ZlaGnbh;

    public FIXConfirmation_Ack Confirmation_Ack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Gt4ZlaGnbh;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Gt4ZlaGnbh = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXConfirmation_AckEventArgs(FIXConfirmation_Ack Confirmation_Ack)
    {
       this.Gt4ZlaGnbh = Confirmation_Ack;
    }
  }
}
