// Type: SmartQuant.Providers.IMarketDataFilter
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using SmartQuant.Data;

namespace SmartQuant.Providers
{
  public interface IMarketDataFilter
  {
    Quote FilterQuote(Quote quote, string symbol);

    Trade FilterTrade(Trade trade, string symbol);

    Bar FilterBarOpen(Bar bar, string symbol);

    Bar FilterBar(Bar bar, string symbol);
  }
}
