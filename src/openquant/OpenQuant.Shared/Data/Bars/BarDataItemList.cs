using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.Data.Bars
{
	internal class BarDataItemList : ICollection
	{
		private List<BarDataItem> list;

		public int Count
		{
			get
			{
				return this.list.Count;
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

		public BarDataItem this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		public BarDataItemList()
		{
			this.list = new List<BarDataItem>();
		}

		public void CopyTo(Array array, int index)
		{
			this.list.ToArray().CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		public void Add(BarDataItem item)
		{
			this.list.Add(item);
		}
	}
}
