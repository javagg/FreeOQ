using FreeQuant.FIX;

namespace FreeQuant.Providers
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
