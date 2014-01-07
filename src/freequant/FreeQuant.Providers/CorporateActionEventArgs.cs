using dW79p7NPlS6ZxObcx3;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
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
