using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXQuoteEventArgs : EventArgs
  {
    private FIXQuote ddhZjSWK83;

    public FIXQuote Quote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ddhZjSWK83;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ddhZjSWK83 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXQuoteEventArgs(FIXQuote Quote)
    {

      this.ddhZjSWK83 = Quote;
    }
  }
}
