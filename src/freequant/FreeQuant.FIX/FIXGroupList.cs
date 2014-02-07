using System;
using System.Collections;

namespace FreeQuant.FIX
{
	public class FIXGroupList : IList
	{
		protected ArrayList fList;
		protected Hashtable fId;

		public bool IsReadOnly
		{
			get
			{
				return this.fList.IsReadOnly;
			}
		}

		public bool IsFixedSize
		{
			get
			{
				return this.fList.IsFixedSize;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return this.fList.IsSynchronized;
			}
		}

		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this.fList.SyncRoot;
			}
		}

		object IList.this [int index]
		{
			get
			{
				return this.fList[index];
			}
			set
			{
				this.fList[index] = value;
			}
		}

		public FIXGroup this [int index]
		{
			get
			{
				return this[index] as FIXGroup;
			}

			set
			{
				this[index] = value as FIXGroup;
			}

		}

		public FIXGroupList() : base()
		{
			this.fList = new ArrayList();
			this.fId = new Hashtable();
		}

		public void RemoveAt(int index)
		{
			this.Remove((FIXGroup)this[index]);
		}

		void IList.Insert(int index, object value)
		{
			this.Insert(index, value as FIXGroup);
		}

		void IList.Remove(object value)
		{
			this.Remove(value as FIXGroup);
		}

		bool IList.Contains(object value)
		{
			return this.Contains(value as FIXGroup);
		}

		public virtual void Clear()
		{
			this.fList.Clear();
			this.fId.Clear();
		}

		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as FIXGroup);
		}

		int IList.Add(object value)
		{
			return this.Add(value as FIXGroup);
		}

		public void CopyTo(Array array, int index)
		{
			this.fList.CopyTo(array, index);
		}

		public virtual IEnumerator GetEnumerator()
		{
			return this.fList.GetEnumerator();
		}

		public FIXGroup GetById(int id)
		{
			return this.fId[(object)id] as FIXGroup;
		}

		public int Add(FIXGroup group)
		{
			if (group.Id != -1)
			{
//        if (this.fId.ContainsKey((object) group.Id))
//          throw new ApplicationException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(24) + (object) group.Id);
				this.fId.Add((object)group.Id, (object)group);
			}
			return this.fList.Add((object)group);
		}

		public void Remove(FIXGroup group)
		{
			this.fList.Remove((object)group);
			this.fId.Remove((object)group.Id);
		}

		public void RegisterById(FIXGroup group)
		{
//      if (this.fId.ContainsKey((object) group.Id))
//        throw new ApplicationException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(158) + (object) group.Id);
			this.fId.Add((object)group.Id, (object)group);
		}

		public bool Contains(FIXGroup group)
		{
			return this.fList.Contains((object)group);
		}

		public bool Contains(int groupId)
		{
			return this.fId.ContainsKey((object)groupId);
		}

		public int IndexOf(FIXGroup group)
		{
			return this.fList.IndexOf((object)group);
		}

		public void Insert(int index, FIXGroup group)
		{
//      if (this.Contains(group))
//        throw new ApplicationException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(292) + (object) group.Id);
			this.fList.Insert(index, (object)group);
			this.fId.Add((object)group.Id, (object)group);
		}
	}
}
