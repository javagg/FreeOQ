using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  [Serializable]
  public class BarEventArgs : IntradayEventArgs
  {
		private Bar bar; 

    public Bar Bar
    {
      get
      {
        return this.bar;
      }
    }

    public BarEventArgs(Bar bar, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.bar = bar;
    }

    public override string ToString()
    {
      return string.Format(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1020), (object) this.provider.Name, (object) this.instrument.Symbol, (object) this.bar);
    }
  }
}
