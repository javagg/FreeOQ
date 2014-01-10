namespace FreeQuant.Providers
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
