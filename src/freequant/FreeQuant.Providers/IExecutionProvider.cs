using FreeQuant.FIX;

namespace FreeQuant.Providers
{
  public interface IExecutionProvider : IProvider
  {
    event ExecutionReportEventHandler ExecutionReport;

    event OrderCancelRejectEventHandler OrderCancelReject;

    void SendNewOrderSingle(NewOrderSingle order);

    void SendOrderCancelRequest(OrderCancelRequest request);

    void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request);

    void SendOrderStatusRequest(OrderStatusRequest request);

    BrokerInfo GetBrokerInfo();

    void RegisterOrder(NewOrderSingle order);
  }
}
