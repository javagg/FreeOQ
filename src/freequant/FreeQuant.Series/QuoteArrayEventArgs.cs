using System;

namespace FreeQuant.Series
{
	public class QuoteArrayEventArgs : EventArgs
	{
		private QuoteArray quotes;

		public QuoteArray QuoteArray
		{
			get
			{
				return this.quotes; 
			}
		}

		public QuoteArrayEventArgs(QuoteArray array) : base()
		{
			this.quotes = array;
		}
	}
}
