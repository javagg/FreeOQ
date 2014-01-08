using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXQuoteCancelEventArgs : EventArgs
  {
    private FIXQuoteCancel Fjm8NJ05ts;

    public FIXQuoteCancel QuoteCancel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Fjm8NJ05ts;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Fjm8NJ05ts = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXQuoteCancelEventArgs(FIXQuoteCancel QuoteCancel)
    {
      this.Fjm8NJ05ts = QuoteCancel;
    }
  }
}
