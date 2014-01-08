using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMassQuoteEventArgs : EventArgs
  {
    private FIXMassQuote yPQYNnbOXb;

    public FIXMassQuote MassQuote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yPQYNnbOXb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.yPQYNnbOXb = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMassQuoteEventArgs(FIXMassQuote MassQuote)
    {
       this.yPQYNnbOXb = MassQuote;
    }
  }
}
