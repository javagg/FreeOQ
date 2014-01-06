// Type: SmartQuant.Providers.BarSliceEventArgs
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class BarSliceEventArgs : EventArgs
  {
    private IMarketDataProvider KQkLDM92Gw;
    private long x4NL5wtq6U;

    public IMarketDataProvider Provider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KQkLDM92Gw;
      }
    }

    public long BarSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.x4NL5wtq6U;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarSliceEventArgs(long barSize, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.x4NL5wtq6U = barSize;
      this.KQkLDM92Gw = provider;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1118), (object) this.KQkLDM92Gw.Name, (object) this.x4NL5wtq6U);
    }
  }
}
