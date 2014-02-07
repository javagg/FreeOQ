using System;
using System.Collections;

namespace FreeQuant.Trading
{
	public class StrategyList : ICollection
	{
		private SortedList strategies; 

		public bool IsSynchronized
		{
			get
			{
				return this.strategies.IsSynchronized;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.strategies.SyncRoot;
			}
		}

		public int Count
		{
			get
			{
				return this.strategies.Count;
			}
		}

		public StrategyBase this[string name]
		{
			get
			{
				return this.strategies[name] as StrategyBase;
			}
		}

		internal StrategyList()
		{
			this.strategies = new SortedList();
		}

		public void CopyTo(Array array, int index)
		{
			this.strategies.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.strategies.Values.GetEnumerator();
		}

		internal void Add(StrategyBase strategy)
		{
			if (this.strategies.Contains(strategy.Name))
				throw new ApplicationException(strategy.Name);
			this.strategies.Add(strategy.Name, strategy);
		}

		internal void Remove(StrategyBase strategy)
		{
			this.strategies.Remove(strategy.Name);
		}

		public bool Contains(string name)
		{
			return this.strategies.ContainsKey(name);
		}
	}
}
