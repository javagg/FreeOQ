using System;
using System.Collections;

namespace FreeQuant.FinChart
{
	[Serializable]
	public class PadList : IList
	{
		private ArrayList pads; 

		public bool IsReadOnly
		{
			get
			{
				return this.pads.IsReadOnly;
			}
		}

		public bool IsFixedSize
		{
			get
			{
				return this.pads.IsFixedSize;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return this.pads.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.pads.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.pads.SyncRoot;
			}
		}

		public Pad this[int index]
		{
			get
			{
				return this.pads[index] as Pad;
			}
		}

		public PadList()
		{
			this.pads = new ArrayList();
		}

		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
//				this[index] = value;
			}
		}

		public void RemoveAt(int index)
		{
			this.pads.RemoveAt(index);
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
			this.Remove(value as Pad);
		}

		bool IList.Contains(object value)
		{
			return this.pads.Contains(value);
		}

		public void Clear()
		{
			this.pads.Clear();
		}

		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as Pad);
		}

		int IList.Add(object value)
		{
			return this.Add(value as Pad);
		}

		public void CopyTo(Array array, int index)
		{
			this.pads.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.pads.GetEnumerator();
		}

		public int Add(Pad pad)
		{
			return this.pads.Add(pad);
		}

		public void Remove(Pad pad)
		{
			this.pads.Remove(pad);
		}

		public void Insert(int index, Pad pad)
		{
			this.pads.Insert(index, pad);
		}

		public int IndexOf(Pad pad)
		{
			return this.pads.IndexOf(pad);
		}
	}
}
