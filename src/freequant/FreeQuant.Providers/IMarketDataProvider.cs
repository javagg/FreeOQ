// Type: SmartQuant.Providers.IMarketDataProvider
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using SmartQuant.FIX;

namespace SmartQuant.Providers
{
  public interface IMarketDataProvider : IProvider
  {
    IBarFactory BarFactory { get; set; }

    IMarketDataFilter MarketDataFilter { get; set; }

    event MarketDataRequestRejectEventHandler MarketDataRequestReject;

    event MarketDataSnapshotEventHandler MarketDataSnapshot;

    event MarketDataEventHandler NewMarketData;

    event QuoteEventHandler NewQuote;

    event TradeEventHandler NewTrade;

    event BarEventHandler NewBar;

    event BarEventHandler NewBarOpen;

    event BarSliceEventHandler NewBarSlice;

    event BarEventHandler NewMarketBar;

    event MarketDepthEventHandler NewMarketDepth;

    event FundamentalEventHandler NewFundamental;

    event CorporateActionEventHandler NewCorporateAction;

    void SendMarketDataRequest(FIXMarketDataRequest request);
  }
}
