using FreeQuant.FIX;

namespace FreeQuant.Services
{
	public class NewOrderSingleEventArgs : ExecutionServiceEventArgs
	{
		public FIXNewOrderSingle Order { get; private set; }

		public NewOrderSingleEventArgs(IExecutionService service, FIXNewOrderSingle order) : base(service)
		{
			this.Order = order;
		}
	}
}
