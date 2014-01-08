using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXQuoteRequestEventArgs : EventArgs
  {
    private FIXQuoteRequest PB2U63pJV1;

    public FIXQuoteRequest QuoteRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PB2U63pJV1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.PB2U63pJV1 = value;
      }
    }

    public FIXQuoteRequestEventArgs(FIXQuoteRequest QuoteRequest)
    {
      this.PB2U63pJV1 = QuoteRequest;
    }
  }
}
