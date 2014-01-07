using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  [Serializable]
  public class BarEventArgs : IntradayEventArgs
  {
    private Bar IS9g0Vkaj4;

    public Bar Bar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.IS9g0Vkaj4;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarEventArgs(Bar bar, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.IS9g0Vkaj4 = bar;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1020), (object) this.provider.Name, (object) this.instrument.Symbol, (object) this.IS9g0Vkaj4);
    }
  }
}
