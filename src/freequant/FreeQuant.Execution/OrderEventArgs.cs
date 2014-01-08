namespace FreeQuant.Execution
{
	public class OrderEventArgs
	{
		private SingleOrder order;

		public SingleOrder Order
		{
			get
			{
				return this.order; 
			}
		}

		public OrderEventArgs(SingleOrder order)
		{
			this.order = order;
		}
	}
}
