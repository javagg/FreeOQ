using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class TransactionEventArgs : EventArgs
	{
		private Transaction transaction;

		public Transaction Transaction
		{
			get
			{
				return this.transaction;
			}
		}

		public TransactionEventArgs(Transaction transaction) : base()
		{

			this.transaction = transaction; 
		}
	}
}
