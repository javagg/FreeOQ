using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXQuoteStatusRequestEventArgs : EventArgs
  {
    private FIXQuoteStatusRequest ALhUDee7q;

    public FIXQuoteStatusRequest QuoteStatusRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ALhUDee7q;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ALhUDee7q = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXQuoteStatusRequestEventArgs(FIXQuoteStatusRequest QuoteStatusRequest)
    {
      this.ALhUDee7q = QuoteStatusRequest;
    }
  }
}
