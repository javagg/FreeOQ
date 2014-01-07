using dW79p7NPlS6ZxObcx3;
using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  [Serializable]
  public class MarketDataEventArgs : IntradayEventArgs
  {
    private IMarketData tcgLjqTb7Y;

    public IMarketData MarketData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tcgLjqTb7Y;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDataEventArgs(IMarketData data, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.tcgLjqTb7Y = data;
    }
  }
}
