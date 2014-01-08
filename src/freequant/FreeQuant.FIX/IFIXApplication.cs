// Type: SmartQuant.FIX.IFIXApplication
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

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
