using System;
using System.Collections;

namespace FreeQuant.Trading
{
	public class StopList : ICollection
	{
		private ArrayList stops; 

		public bool IsSynchronized
		{
			get
			{
				return this.stops.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.stops.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.stops.SyncRoot;
			}
		}

		public IStop this[int index]
		{
			get
			{
				return this.stops[index] as IStop;
			}
		}

		public StopList()
		{
			this.stops = new ArrayList();
		}

		public void CopyTo(Array array, int index)
		{
			this.stops.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.stops.GetEnumerator();
		}

		public void Add(IStop stop)
		{
			this.Add(stop, true);
		}

		public void Add(IStop stop, bool sort)
		{
			this.stops.Add(stop);
		}

		public void Remove(IStop stop)
		{
			this.stops.Remove(stop);
		}

		public void RemoveAt(int index)
		{
			this.stops.RemoveAt(index);
		}

		public void Clear()
		{
			this.stops.Clear();
		}

		public bool Contains(IStop stop)
		{
			return this.stops.Contains(stop);
		}

		public void Sort()
		{
			this.stops.Sort();
		}
	}
}
