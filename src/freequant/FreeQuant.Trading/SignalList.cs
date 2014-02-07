using System;
using System.Collections;

namespace FreeQuant.Trading
{
	public class SignalList : ICollection
	{
		private ArrayList signals;

		public bool IsSynchronized
		{
			get
			{
				return this.signals.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.signals.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.signals.SyncRoot;
			}
		}

		public Signal this[int index]
		{
			get
			{
				return this.signals[index] as Signal;
			}
		}

		public SignalList() : base()
		{
			this.signals = new ArrayList();
		}

		public void CopyTo(Array array, int index)
		{
			this.signals.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.signals.GetEnumerator();
		}

		public void Clear()
		{
			this.signals.Clear();
		}

		public void Add(Signal signal)
		{
			this.signals.Add(signal);
		}
	}
}
