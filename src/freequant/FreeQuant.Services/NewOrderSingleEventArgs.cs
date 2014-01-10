using FreeQuant.FIX;

namespace FreeQuant.Services
{
	public class NewOrderSingleEventArgs : ExecutionServiceEventArgs
	{
		private FIXNewOrderSingle order;

		public FIXNewOrderSingle Order
		{
			get
			{
				return this.order;
			}
		}

		public NewOrderSingleEventArgs(IExecutionService service, FIXNewOrderSingle order) : base(service)
		{
			this.order = order;
		}
	}
}
