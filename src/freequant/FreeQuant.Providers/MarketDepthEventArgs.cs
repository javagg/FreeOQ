using dW79p7NPlS6ZxObcx3;
using FreeQuant.Data;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class MarketDepthEventArgs : IntradayEventArgs
  {
    private MarketDepth vpDgkM91fI;

    public MarketDepth MarketDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vpDgkM91fI;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepthEventArgs(MarketDepth marketDepth, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.vpDgkM91fI = marketDepth;
    }
  }
}
