// Type: SmartQuant.Providers.BarEventArgs
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using SmartQuant.Data;
using SmartQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
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
