using System;
using System.Collections;

namespace FreeQuant.FinChart
{
	public class SortedRangeList : ICollection
	{
		private SortedList ranges; 

		public ArrayList this[int index]
		{
			get
			{
				return this.ranges.GetByIndex(index) as ArrayList;
			}
		}

		public ArrayList this[DateTime dateTime]
		{
			get
			{
				return this.ranges[dateTime] as ArrayList;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return this.ranges.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.ranges.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.ranges.SyncRoot;
			}
		}

		public SortedRangeList(bool right = false)
		{
			this.ranges = new SortedList();
//			right = true;
		}

		public void Add(IDateDrawable item)
		{
			if (this.ranges.ContainsKey(item.DateTime))
				(this.ranges[item.DateTime] as ArrayList).Add(item);
			else
				this.ranges.Add(item.DateTime, new ArrayList() { item	});
		}

		public void Clear()
		{
			this.ranges.Clear();
		}

		public int GetNextIndex(DateTime dateTime)
		{
			if (this.ranges.ContainsKey(dateTime))
				return this.ranges.IndexOfKey(dateTime);
			this.ranges.Add(dateTime, null);
			int num = this.ranges.IndexOfKey(dateTime);
			this.ranges.Remove(dateTime);

			return num == this.ranges.Count ? -1 : num;
		}

		public int GetPrevIndex(DateTime dateTime)
		{
			if (this.ranges.ContainsKey(dateTime))
				return this.ranges.IndexOfKey(dateTime);
			this.ranges.Add(dateTime, null);
			int num = this.ranges.IndexOfKey(dateTime);
			this.ranges.Remove(dateTime);

			return num == 0 ? -1 : num - 1;
		}

		public DateTime GetDateTime(int index)
		{
			return (DateTime)this.ranges.GetKey(index);
		}

		public bool Contains(DateTime dateTime)
		{
			return this.ranges.ContainsKey(dateTime);
		}

		public void CopyTo(Array array, int index)
		{
			this.ranges.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.ranges.Values.GetEnumerator();
		}
	}
}