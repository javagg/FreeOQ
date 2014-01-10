using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class AccountTransactionList : ICollection, IEnumerable
	{
		private ArrayList transactions;

		public bool IsSynchronized
		{
			get
			{
				return this.transactions.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.transactions.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.transactions.SyncRoot;
			}
		}

		public AccountTransaction this [int index]
		{
			get
			{
				return this.transactions[index] as AccountTransaction;
			}
		}

		public AccountTransactionList()
		{
			this.transactions = new ArrayList();
		}

		public void CopyTo(Array array, int index)
		{
			this.transactions.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.transactions.GetEnumerator();
		}

		public void Clear()
		{
			this.transactions.Clear();
		}

		public void Add(AccountTransaction transaction)
		{
			int count;
			for (count = this.transactions.Count; count > 0; --count)
			{
				AccountTransaction accountTransaction = this[count - 1];
				if (transaction.DateTime >= accountTransaction.DateTime)
					break;
			}
			this.transactions.Insert(count, (object)transaction);
		}
	}
}
