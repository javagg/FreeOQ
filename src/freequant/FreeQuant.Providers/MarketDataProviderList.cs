using dW79p7NPlS6ZxObcx3;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class MarketDataProviderList : ProviderList
  {
    public IMarketDataProvider this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[name] as IMarketDataProvider;
      }
    }

    public IMarketDataProvider this[byte id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[id] as IMarketDataProvider;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal MarketDataProviderList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
