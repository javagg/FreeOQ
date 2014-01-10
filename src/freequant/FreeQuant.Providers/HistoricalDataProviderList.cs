using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class HistoricalDataProviderList : ProviderList
  {
    public IHistoricalDataProvider this[string name]
    {
       get
      {
        return base[name] as IHistoricalDataProvider;
      }
    }

    public IHistoricalDataProvider this[byte id]
    {
       get
      {
        return base[id] as IHistoricalDataProvider;
      }
    }

//    
//	internal HistoricalDataProviderList() : base()
//    {
//    }
  }
}
