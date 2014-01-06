// Type: SmartQuant.Providers.QuoteEventArgs
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using SmartQuant.Data;
using SmartQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  [Serializable]
  public class QuoteEventArgs : IntradayEventArgs
  {
    private Quote jrhtC26GMY;

    public Quote Quote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jrhtC26GMY;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuoteEventArgs(Quote quote, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.jrhtC26GMY = quote;
    }
  }
}
