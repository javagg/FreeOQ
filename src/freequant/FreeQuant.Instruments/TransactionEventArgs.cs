using System;

namespace FreeQuant.Instruments
{
	public class TransactionEventArgs : EventArgs
	{
		public Transaction Transaction { get; private set; }
		public TransactionEventArgs(Transaction transaction) : base()
		{
			this.Transaction = transaction; 
		}
	}
}
