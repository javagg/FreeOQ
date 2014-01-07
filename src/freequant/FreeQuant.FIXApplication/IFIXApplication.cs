using FreeQuant.FIX;

namespace FreeQuant.FIXApplication
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

    event ExecutionReportEventHandler ExecutionReport;

    event OrderCancelRejectEventHandler OrderCancelReject;

    event FIXSecurityDefinitionRequestEventHandler SecurityDefinitionRequest;

    event FIXSecurityDefinitionEventHandler SecurityDefinition;

    void Send(FIXMarketDataRequest request);

    void Send(FIXMarketDataSnapshot snapshot);

    void Send(FIXMarketDataIncrementalRefresh refresh);

    void Send(FIXMarketDataRequestReject reject);

    void Send(FIXNewOrderSingle order);

    void Send(FIXExecutionReport report);

    void Send(FIXOrderCancelRequest request);

    void Send(FIXOrderCancelReplaceRequest request);

    void Send(FIXSecurityDefinitionRequest request);

    void Send(FIXTestRequest request);

    void Send(FIXResendRequest resuest);
  }
}
