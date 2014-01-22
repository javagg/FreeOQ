using System;

namespace FreeQuant.Series
{
	public class TradeArrayEventArgs : EventArgs
	{
		public TradeArray TradeArray
		{
			get;
			private set;
		}

		public TradeArrayEventArgs(TradeArray array) : base()
		{
			this.TradeArray = array;
		}
	}
}
