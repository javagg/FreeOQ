using System;
using System.Collections;

namespace FreeQuant.Simulation
{
	public class IntervalList : IList
	{
		private ArrayList intervals;

		public bool IsReadOnly
		{
			get
			{
				return this.intervals.IsReadOnly;
			}
		}

		public bool IsFixedSize
		{
			get
			{
				return this.intervals.IsFixedSize;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return this.intervals.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.intervals.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.intervals.SyncRoot;
			}
		}

		public object this [int index]
		{
			get
			{
				return this.intervals[index];
			}
			set
			{
				this.intervals[index] = value;
			}
		}

		public IntervalList()
		{
			this.intervals = new ArrayList();
		}

		object IList.this [int index]
		{
			get
			{
				return this.intervals[index];
			}
		
			set
			{
			}
		}

		public void RemoveAt(int index)
		{
			this.intervals.RemoveAt(index);
		}

		void IList.Insert(int index, object value)
		{
			this.intervals.Insert(index, value);
		}

		void IList.Remove(object value)
		{
			this.intervals.Remove(value);
		}

		bool IList.Contains(object value)
		{
			return this.intervals.Contains(value);
		}

		public void Clear()
		{
			this.intervals.Clear();
		}

		int IList.IndexOf(object value)
		{
			return this.intervals.IndexOf(value);
		}

		int IList.Add(object value)
		{
			return this.intervals.Add(value);
		}

		public void CopyTo(Array array, int index)
		{
			this.intervals.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.intervals.GetEnumerator();
		}

		public void Remove(Interval interval)
		{
			this.intervals.Remove(interval);
		}

		public bool Contains(Interval interval)
		{
			return this.intervals.Contains(interval);
		}

		public int IndexOf(Interval interval)
		{
			return this.intervals.IndexOf(interval);
		}

		public int Add(Interval interval)
		{
			return this.intervals.Add(interval);
		}

		public int Add(DateTime begin, DateTime end)
		{
			return this.Add(new Interval(begin, end));
		}
	}
}
