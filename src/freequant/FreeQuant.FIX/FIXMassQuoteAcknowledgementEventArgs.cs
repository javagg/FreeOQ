using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMassQuoteAcknowledgementEventArgs : EventArgs
  {
    private FIXMassQuoteAcknowledgement DVOuopgjrN;

    public FIXMassQuoteAcknowledgement MassQuoteAcknowledgement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DVOuopgjrN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.DVOuopgjrN = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMassQuoteAcknowledgementEventArgs(FIXMassQuoteAcknowledgement MassQuoteAcknowledgement)
    {
      this.DVOuopgjrN = MassQuoteAcknowledgement;
    }
  }
}
