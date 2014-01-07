using dW79p7NPlS6ZxObcx3;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class FundamentalEventArgs : IntradayEventArgs
  {
    private Fundamental u9ub8Cvnd;

    public Fundamental Fundamental
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.u9ub8Cvnd;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FundamentalEventArgs(Fundamental fundamental, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.u9ub8Cvnd = fundamental;
    }
  }
}
