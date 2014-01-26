using System;

namespace FreeQuant.Series
{
	public class QuoteArrayEventArgs : EventArgs
	{
		public QuoteArray QuoteArray { get; private set; }

		public QuoteArrayEventArgs(QuoteArray array) : base()
		{
			this.QuoteArray = array;
		}
	}
}
