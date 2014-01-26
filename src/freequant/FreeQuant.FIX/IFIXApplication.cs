namespace FreeQuant.FIX
{
	public interface IFIXApplication
	{
		event FIXLogonEventHandler Logon;
		event FIXLogoutEventHandler Logout;
		event FIXMarketDataRequestEventHandler MarketDataRequest;
		event FIXMarketDataSnapshotEventHandler MarketDataSnapshot;
		event FIXMarketDataIncrementalRefreshEventHandler MarketDataIncrementalRefresh;
		event FIXMarketDataRequestRejectEventHandler MarketDataRequestReject;
		event FIXNewOrderSingleEventHandler NewOrderSingle;
		event FIXExecutionReportEventHandler ExecutionReport;
		event FIXSecurityDefinitionRequestEventHandler SecurityDefinitionRequest;
		event FIXRequestForPositionsEventHandler RequestForPositions;
		void Send(FIXLogon logon);
		void Send(FIXLogout logout);
		void Send(FIXMarketDataRequest request);
		void Send(FIXMarketDataSnapshot snapshot);
		void Send(FIXMarketDataIncrementalRefresh refresh);
		void Send(FIXMarketDataRequestReject reject);
		void Send(FIXNewOrderSingle order);
		void Send(FIXExecutionReport report);
		void Send(FIXOrderCancelRequest cancel);
		void Send(FIXOrderCancelReplaceRequest replace);
		void Send(FIXSecurityDefinitionRequest request);
		void Send(FIXRequestForPositions request);
	}
}
