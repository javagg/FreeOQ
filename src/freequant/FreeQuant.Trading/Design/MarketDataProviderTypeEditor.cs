// Type: SmartQuant.Trading.Design.MarketDataProviderTypeEditor
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Providers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Design
{
  public class MarketDataProviderTypeEditor : ComboBoxTypeEditor
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarketDataProviderTypeEditor()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector(true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override List<KeyValuePair<string, object>> GetItems()
    {
      List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
      foreach (IProvider provider in (ProviderList) ProviderManager.MarketDataProviders)
        list.Add(new KeyValuePair<string, object>(provider.Name, (object) provider));
      return list;
    }
  }
}
