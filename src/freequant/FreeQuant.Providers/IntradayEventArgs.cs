using dW79p7NPlS6ZxObcx3;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class IntradayEventArgs : EventArgs
  {
    protected IFIXInstrument instrument;
    protected IMarketDataProvider provider;

    public IFIXInstrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.instrument;
      }
    }

    public IMarketDataProvider Provider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.provider;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected IntradayEventArgs(IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.instrument = instrument;
      this.provider = provider;
    }
  }
}
