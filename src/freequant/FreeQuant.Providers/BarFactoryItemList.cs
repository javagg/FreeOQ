using FreeQuant.Data;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

namespace FreeQuant.Providers
{
	//  [Editor(typeof (BarFactoryItemListEditor), typeof (UITypeEditor))]
	public class BarFactoryItemList : IList
	{
		private ArrayList list;

		public bool IsReadOnly
		{
			get
			{
				return this.list.IsReadOnly;
			}
		}

		public bool IsFixedSize
		{
			get
			{
				return this.list.IsFixedSize;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		public BarFactoryItem this[int index]
		{
			get
			{
				return this.list[index] as BarFactoryItem;
			}
		}

		object IList.this[int index]
		{
			get
			{
				return this.list[index];
			}
			set 
			{
				this.list[index] = value;
			}
		}

		public BarFactoryItemList()
		{
			this.list = new ArrayList();
		}

		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		public void Insert(int index, object value)
		{
			this.list.Insert(index, value);
		}

		public void Remove(object value)
		{
			this.list.Remove(value);
		}

		public bool Contains(object value)
		{
			return this.list.Contains(value);
		}

		public void Clear()
		{
			this.list.Clear();
		}

		public int IndexOf(object value)
		{
			return this.list.IndexOf(value);
		}

		int IList.Add(object value)
		{
			return this.Add(value as BarFactoryItem);
		}

		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		public int Add(BarFactoryItem item)
		{
			this.list.Add(item);
			this.list.Sort();
			return this.list.IndexOf(item);
		}

		public int Add(BarType barType, long barSize, bool enabled)
		{
			return this.Add(new BarFactoryItem(barType, barSize, enabled));
		}
	}
}
