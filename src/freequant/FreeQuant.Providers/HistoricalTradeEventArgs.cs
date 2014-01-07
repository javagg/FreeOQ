using dW79p7NPlS6ZxObcx3;
using FreeQuant.Data;
using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class HistoricalTradeEventArgs : HistoricalDataEventArgs
  {
    private Trade lehtRHhNfe;

    public Trade Trade
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lehtRHhNfe;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistoricalTradeEventArgs(Trade trade, string requestId, IFIXInstrument instrument, IHistoricalDataProvider provider, int dataLength)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(requestId, instrument, provider, dataLength);
      this.lehtRHhNfe = trade;
    }
  }
}
