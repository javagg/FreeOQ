using dW79p7NPlS6ZxObcx3;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class InstrumentProviderList : ProviderList
  {
    public IInstrumentProvider this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[name] as IInstrumentProvider;
      }
    }

    public IInstrumentProvider this[byte id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[id] as IInstrumentProvider;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal InstrumentProviderList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
