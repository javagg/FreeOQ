using System;

namespace FreeQuant.Data
{
	public class OrderBookEventArgs : EventArgs
	{
		private MDSide side;
		private MDOperation operation;
		private int position;

		public MDSide Side
		{
			get
			{
				return this.side; 
			}
		}

		public MDOperation Operation
		{
			get
			{
				return this.operation; 
			}
		}

		public int Position
		{
			get
			{
				return this.position; 
			}
		}

		public OrderBookEventArgs(MDSide side, MDOperation operation, int position)
		{
			this.side = side;
			this.operation = operation;
			this.position = position;
		}
	}
}
