using System;

namespace FreeQuant.Series
{
	public class TradeArrayEventArgs : EventArgs
	{
		private TradeArray tradeArray;

		public TradeArray TradeArray
		{
			get
			{
				return this.tradeArray; 
			}
		}

		public TradeArrayEventArgs(TradeArray array) : base()
		{
			this.tradeArray = array;
		}
	}
}
