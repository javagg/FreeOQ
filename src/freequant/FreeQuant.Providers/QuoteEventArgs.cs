using dW79p7NPlS6ZxObcx3;
using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  [Serializable]
  public class QuoteEventArgs : IntradayEventArgs
  {
    private Quote jrhtC26GMY;

    public Quote Quote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jrhtC26GMY;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuoteEventArgs(Quote quote, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.jrhtC26GMY = quote;
    }
  }
}
