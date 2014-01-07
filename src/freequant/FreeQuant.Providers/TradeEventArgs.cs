using dW79p7NPlS6ZxObcx3;
using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  [Serializable]
  public class TradeEventArgs : IntradayEventArgs
  {
    private Trade Nr4sx9X4G;

    public Trade Trade
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Nr4sx9X4G;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TradeEventArgs(Trade trade, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.Nr4sx9X4G = trade;
    }
  }
}
