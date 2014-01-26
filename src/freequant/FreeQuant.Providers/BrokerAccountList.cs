using System;
using System.Collections;
using System.Collections.Generic;

namespace FreeQuant.Providers
{
	public class BrokerAccountList : ICollection, IEnumerable
	{
		private SortedList<string, BrokerAccount> accountsByName;
		private List<BrokerAccount> accountsByIndex;

		public int Count
		{
			get
			{
				return this.accountsByIndex.Count;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		public BrokerAccount this[int index]
		{
			get
			{
				return this.accountsByIndex[index];
			}
		}

		public BrokerAccount this[string name]
		{
			get
			{
				return this.accountsByName[name];
			}
		}

		internal BrokerAccountList()
		{
			this.accountsByName = new SortedList<string, BrokerAccount>();
			this.accountsByIndex = new List<BrokerAccount>();
		}

		public void CopyTo(Array array, int index)
		{
			this.accountsByIndex.ToArray().CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.accountsByIndex.GetEnumerator();
		}

		public void Add(BrokerAccount account)
		{
			this.accountsByName.Add(account.Name, account);
			this.accountsByIndex.Add(account);
		}
	}
}
