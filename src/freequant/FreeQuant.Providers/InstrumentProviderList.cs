using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class InstrumentProviderList : ProviderList
  {
    public IInstrumentProvider this[string name]
    {
       get
      {
        return base[name] as IInstrumentProvider;
      }
    }

    public IInstrumentProvider this[byte id]
    {
       get
      {
        return base[id] as IInstrumentProvider;
      }
    }
  }
}
