// Type: SmartQuant.Providers.ISimulationMarketDataProvider
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
  public interface ISimulationMarketDataProvider
  {
    void EmitTrade(IFIXInstrument instrument, Trade trade);

    void EmitQuote(IFIXInstrument instrument, Quote quote);
  }
}
