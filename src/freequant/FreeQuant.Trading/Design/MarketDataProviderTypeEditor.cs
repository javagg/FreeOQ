using FreeQuant.Providers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Design
{
  public class MarketDataProviderTypeEditor : ComboBoxTypeEditor
  {
   
    public MarketDataProviderTypeEditor()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector(true);
    }

   
    protected override List<KeyValuePair<string, object>> GetItems()
    {
      List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
      foreach (IProvider provider in (ProviderList) ProviderManager.MarketDataProviders)
        list.Add(new KeyValuePair<string, object>(provider.Name, (object) provider));
      return list;
    }
  }
}
