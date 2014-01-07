using dW79p7NPlS6ZxObcx3;
using FreeQuant.Data;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class HistoricalMarketDepthEventArgs : HistoricalDataEventArgs
  {
    private MarketDepth PLdgDQjduA;

    public MarketDepth MarketDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PLdgDQjduA;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistoricalMarketDepthEventArgs(MarketDepth marketDepth, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(requestId, instrument, provider, dataLength);
      this.PLdgDQjduA = marketDepth;
    }
  }
}
