using dW79p7NPlS6ZxObcx3;
using FreeQuant.Data;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class HistoricalQuoteEventArgs : HistoricalDataEventArgs
  {
    private Quote uEQLnSMVw2;

    public Quote Quote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.uEQLnSMVw2;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistoricalQuoteEventArgs(Quote quote, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(requestId, instrument, provider, dataLength);
      this.uEQLnSMVw2 = quote;
    }
  }
}
