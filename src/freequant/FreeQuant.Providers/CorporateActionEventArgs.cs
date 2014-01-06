// Type: SmartQuant.Providers.CorporateActionEventArgs
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using SmartQuant.FIX;
using SmartQuant.FIXData;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class CorporateActionEventArgs : IntradayEventArgs
  {
    private CorporateAction HFILXDKaEA;

    public CorporateAction CorporateAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.HFILXDKaEA;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CorporateActionEventArgs(CorporateAction corporateAction, IFIXInstrument instrument, IMarketDataProvider provider)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector(instrument, provider);
      this.HFILXDKaEA = corporateAction;
    }
  }
}
