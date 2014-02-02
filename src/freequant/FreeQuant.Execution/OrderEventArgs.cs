namespace FreeQuant.Execution
{
	public class OrderEventArgs
	{
		public SingleOrder Order { get; private set; }

		public OrderEventArgs(SingleOrder order)
		{
			this.Order = order;
		}
	}
}
