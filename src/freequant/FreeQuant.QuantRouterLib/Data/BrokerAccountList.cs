using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Data
{
  public class BrokerAccountList : ICollection, IEnumerable
  {
    private SortedList<string, BrokerAccount> yJ5u1odcpC;
    private List<BrokerAccount> ufGuL3AIDY;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ufGuL3AIDY.Count;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return false;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (object) null;
      }
    }

    public BrokerAccount this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ufGuL3AIDY[index];
      }
    }

    public BrokerAccount this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yJ5u1odcpC[name];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
		internal BrokerAccountList() : base()
    {
      this.yJ5u1odcpC = new SortedList<string, BrokerAccount>();
      this.ufGuL3AIDY = new List<BrokerAccount>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.ufGuL3AIDY.ToArray().CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.ufGuL3AIDY.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(BrokerAccount account)
    {
      this.yJ5u1odcpC.Add(account.Name, account);
      this.ufGuL3AIDY.Add(account);
    }
  }
}
