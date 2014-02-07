using System;

namespace FreeQuant.Data
{
	public class OrderBookEventArgs : EventArgs
	{
		public MDSide Side { get; private set; }
		public MDOperation Operation { get; private set; }
		public int Position { get; private set; }

		public OrderBookEventArgs(MDSide size, MDOperation operation, int position)
		{
			this.Side = size;
			this.Operation = operation;
			this.Position = position;
		}
	}
}