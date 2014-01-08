using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXQuoteRequestRejectEventArgs : EventArgs
  {
    private FIXQuoteRequestReject wRkArB7e9F;

    public FIXQuoteRequestReject QuoteRequestReject
    {
        get
      {
        return this.wRkArB7e9F;
      }
       set
      {
        this.wRkArB7e9F = value;
      }
    }

    public FIXQuoteRequestRejectEventArgs(FIXQuoteRequestReject QuoteRequestReject)
    {
      this.wRkArB7e9F = QuoteRequestReject;
    }
  }
}
