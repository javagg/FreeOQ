using FreeQuant.Providers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Design
{
  public class ExecutionProviderTypeEditor : ComboBoxTypeEditor
  {
    
		public ExecutionProviderTypeEditor():base(true)
    {
    }

    
    protected override List<KeyValuePair<string, object>> GetItems()
    {
      List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
      foreach (IProvider provider in (ProviderList) ProviderManager.ExecutionProviders)
        list.Add(new KeyValuePair<string, object>(provider.Name, (object) provider));
      return list;
    }
  }
}
