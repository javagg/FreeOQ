// Type: SmartQuant.Providers.MarketDepthEventArgs
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using SmartQuant.Data;
using SmartQuant.FIX;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class MarketDepthEventArgs : IntradayEventArgs
  {
    private MarketDepth vpDgkM91fI;

    public MarketDepth MarketDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vpDgkM91fI;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDepthEventArgs(MarketDepth marketDepth, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.vpDgkM91fI = marketDepth;
    }
  }
}
