using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXQuoteResponseEventArgs : EventArgs
  {
    private FIXQuoteResponse EGkZaStAhp;

    public FIXQuoteResponse QuoteResponse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EGkZaStAhp;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.EGkZaStAhp = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXQuoteResponseEventArgs(FIXQuoteResponse QuoteResponse)
    {
      this.EGkZaStAhp = QuoteResponse;
    }
  }
}
