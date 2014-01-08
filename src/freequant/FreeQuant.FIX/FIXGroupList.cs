using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXGroupList : IList, ICollection, IEnumerable
  {
    protected ArrayList fList;
    protected Hashtable fId;

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList.IsReadOnly;
      }
    }

    public bool IsFixedSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList.IsFixedSize;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList.SyncRoot;
      }
    }

    public FIXGroup this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as FIXGroup;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXGroupList()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.fList = new ArrayList();
      this.fId = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    object IList.get_Item(int index)
    {
      return this.fList[index];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.set_Item(int index, object value)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.Remove(this[index]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.Insert(int index, object value)
    {
      this.Insert(index, value as FIXGroup);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList.Remove(object value)
    {
      this.Remove(value as FIXGroup);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IList.Contains(object value)
    {
      return this.Contains(value as FIXGroup);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Clear()
    {
      this.fList.Clear();
      this.fId.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.IndexOf(object value)
    {
      return this.IndexOf(value as FIXGroup);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList.Add(object value)
    {
      return this.Add(value as FIXGroup);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.fList.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IEnumerator GetEnumerator()
    {
      return this.fList.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXGroup GetById(int id)
    {
      return this.fId[(object) id] as FIXGroup;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(FIXGroup group)
    {
      if (group.Id != -1)
      {
        if (this.fId.ContainsKey((object) group.Id))
          throw new ApplicationException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(24) + (object) group.Id);
        this.fId.Add((object) group.Id, (object) group);
      }
      return this.fList.Add((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(FIXGroup group)
    {
      this.fList.Remove((object) group);
      this.fId.Remove((object) group.Id);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterById(FIXGroup group)
    {
      if (this.fId.ContainsKey((object) group.Id))
        throw new ApplicationException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(158) + (object) group.Id);
      this.fId.Add((object) group.Id, (object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(FIXGroup group)
    {
      return this.fList.Contains((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(int groupId)
    {
      return this.fId.ContainsKey((object) groupId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(FIXGroup group)
    {
      return this.fList.IndexOf((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, FIXGroup group)
    {
      if (this.Contains(group))
        throw new ApplicationException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(292) + (object) group.Id);
      this.fList.Insert(index, (object) group);
      this.fId.Add((object) group.Id, (object) group);
    }
  }
}
