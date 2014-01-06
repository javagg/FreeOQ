// Type: SmartQuant.Providers.IHistoricalDataProvider
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

namespace SmartQuant.Providers
{
  public interface IHistoricalDataProvider : IProvider
  {
    HistoricalDataType DataType { get; }

    HistoricalDataRange DataRange { get; }

    int[] BarSizes { get; }

    int MaxConcurrentRequests { get; }

    event HistoricalTradeEventHandler NewHistoricalTrade;

    event HistoricalQuoteEventHandler NewHistoricalQuote;

    event HistoricalBarEventHandler NewHistoricalBar;

    event HistoricalMarketDepthEventHandler NewHistoricalMarketDepth;

    event HistoricalDataEventHandler HistoricalDataRequestCompleted;

    event HistoricalDataEventHandler HistoricalDataRequestCancelled;

    event HistoricalDataErrorEventHandler HistoricalDataRequestError;

    void SendHistoricalDataRequest(HistoricalDataRequest request);

    void CancelHistoricalDataRequest(string requestId);
  }
}
