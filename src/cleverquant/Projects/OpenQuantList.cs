using System;
using System.Collections;
using System.Collections.Generic;

namespace CleverQuant.Projects
{
	internal class OpenQuantList<T> : IList, ICollection, IEnumerable
	{
		private List<T> list;
		private Dictionary<T, bool> table;

		public T this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
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
				return (object) null;
			}
		}

		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		bool IList.IsReadOnly
		{
			get
			{
				return this.IsReadOnly;
			}
		}

		public event OpenQuantListEventHandler<T> Added;

		public event OpenQuantListEventHandler<T> Removed;

		public event EventHandler Cleared;

		protected OpenQuantList()
		{
			this.list = new List<T>();
			this.table = new Dictionary<T, bool>();
		}

		public override string ToString()
		{
			return "(Collection)";
		}

		public T[] ToArray()
		{
			return this.list.ToArray();
		}

		public void Add(T item)
		{
			if (this.table.ContainsKey(item))
				return;
			this.table[item] = true;
			this.list.Add(item);
			this.EmitAdded(item);
		}

		public void Clear()
		{
			this.list.Clear();
			this.table.Clear();
			this.EmitCleared();
		}

		public bool Contains(T item)
		{
			return this.table.ContainsKey(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			this.list.CopyTo(array, arrayIndex);
		}

		public bool Remove(T item)
		{
			bool flag = this.list.Remove(item);
			if (flag)
			{
				this.table.Remove(item);
				this.EmitRemoved(item);
			}
			return flag;
		}

		private void EmitAdded(T item)
		{
			if (this.Added == null)
				return;
			this.Added((object) this, new OpenQuantListEventArgs<T>(item));
		}

		private void EmitRemoved(T item)
		{
			if (this.Removed == null)
				return;
			this.Removed((object) this, new OpenQuantListEventArgs<T>(item));
		}

		private void EmitCleared()
		{
			if (this.Cleared == null)
				return;
			this.Cleared((object) this, EventArgs.Empty);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator) this.list.GetEnumerator();
		}

		public void CopyTo(Array array, int index)
		{
			this.list.ToArray().CopyTo(array, index);
		}

		int IList.Add(object value)
		{
			this.Add((T) value);
			return this.Count;
		}

		void IList.Clear()
		{
			this.Clear();
		}

		bool IList.Contains(object value)
		{
			return this.Contains((T) value);
		}

		int IList.IndexOf(object value)
		{
			return this.list.IndexOf((T) value);
		}

		void IList.Insert(int index, object value)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		void IList.Remove(object value)
		{
			this.Remove((T) value);
		}

		void IList.RemoveAt(int index)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		object IList.get_Item(int index)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		void IList.set_Item(int index, object value)
		{
			throw new Exception("The method or operation is not implemented.");
		}
	}

	class MarketDataRequestList : OpenQuantList<MarketDataRequest>
	{
	}

}
