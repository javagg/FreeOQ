using System;
using System.Collections;

namespace FreeQuant.Trading
{
	public class TriggerList : ICollection
	{
		private ArrayList triggers;

		public bool IsSynchronized
		{
			get
			{
				return this.triggers.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.triggers.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.triggers.SyncRoot;
			}
		}

		public TriggerList()
		{
			this.triggers = new ArrayList();
		}

		public void CopyTo(Array array, int index)
		{
			this.triggers.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.triggers.GetEnumerator();
		}

		public void Add(Trigger trigger)
		{
			this.triggers.Add(trigger);
		}

		public void Clear()
		{
			this.triggers.Clear();
		}
	}
}
