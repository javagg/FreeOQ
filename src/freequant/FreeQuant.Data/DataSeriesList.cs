using System;
using System.Collections;

namespace FreeQuant.Data
{
	public class DataSeriesList : IList
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
		//		object get_Item(int index)
		//		{
		//			return (object)this[index];
		//		}
		//
		//		void set_Item(int index, object value)
		//		{
		//			this[index] = value as IDataSeries;
		//		}
		public object this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				this.list[index] = (object)value;
			}
		}

		public DataSeriesList()
		{
			this.list = new ArrayList();
		}

		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		void IList.Insert(int index, object value)
		{
			this.Insert(index, value as IDataSeries);
		}

		void IList.Remove(object value)
		{
			this.Remove(value as IDataSeries);
		}

		bool IList.Contains(object value)
		{
			return this.Contains(value as IDataSeries);
		}

		public void Clear()
		{
			this.list.Clear();
		}

		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as IDataSeries);
		}

		int IList.Add(object value)
		{
			return this.Add(value as IDataSeries);
		}

		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		public void Insert(int index, IDataSeries series)
		{
			this.list.Insert(index, series);
		}

		public void Remove(IDataSeries series)
		{
			this.list.Remove(series);
		}

		public bool Contains(IDataSeries series)
		{
			return this.list.Contains(series);
		}

		public int IndexOf(IDataSeries series)
		{
			return this.list.IndexOf(series);
		}

		public int Add(IDataSeries series)
		{
			return this.list.Add(series);
		}
	}
}
