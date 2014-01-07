using dW79p7NPlS6ZxObcx3;
using FreeQuant.Data;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class HistoricalBarEventArgs : HistoricalDataEventArgs
  {
    private Bar yOoLKNvoEU;

    public Bar Bar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yOoLKNvoEU;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistoricalBarEventArgs(Bar bar, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(requestId, instrument, provider, dataLength);
      this.yOoLKNvoEU = bar;
    }
  }
}
