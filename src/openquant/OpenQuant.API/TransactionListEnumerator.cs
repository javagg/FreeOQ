using FreeQuant.Instruments;
using System.Collections;

namespace OpenQuant.API
{
	internal class TransactionListEnumerator : IEnumerator
	{
		private FreeQuant.Instruments.TransactionList transactionList;
		private IEnumerator enumerator;

		public object Current
		{
			get
			{
				return new Transaction(this.enumerator.Current as FreeQuant.Instruments.Transaction);
			}
		}

		internal TransactionListEnumerator(FreeQuant.Instruments.TransactionList transactionList)
		{
			this.transactionList = transactionList;
			this.enumerator = transactionList.GetEnumerator();
		}

		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		public void Reset()
		{
			this.enumerator.Reset();
		}
	}
}
