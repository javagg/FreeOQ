using System;

namespace FreeQuant.FIX
{
	public class FIXNewOrderSingleEventArgs : EventArgs
	{
		public FIXNewOrderSingle NewOrderSingle { get; set; }

		public FIXNewOrderSingleEventArgs(FIXNewOrderSingle newOrderSingle)
		{
			this.NewOrderSingle = newOrderSingle;
		}
	}
}
