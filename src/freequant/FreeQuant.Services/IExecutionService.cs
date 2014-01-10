using FreeQuant.FIX;

namespace FreeQuant.Services
{
	public interface IExecutionService : IMarketService, IService
	{
		event FIXNewOrderSingleEventHandler NewOrderSingle;
		event FIXOrderCancelRequestEventHandler OrderCancelRequest;
		event FIXOrderCancelReplaceRequestEventHandler OrderCancelReplaceRequest;

		void Send(FIXExecutionReport message);

		void Send(FIXOrderCancelReject message);
	}
}
