using dW79p7NPlS6ZxObcx3;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class HistoricalDataProviderList : ProviderList
  {
    public IHistoricalDataProvider this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[name] as IHistoricalDataProvider;
      }
    }

    public IHistoricalDataProvider this[byte id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[id] as IHistoricalDataProvider;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal HistoricalDataProviderList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
