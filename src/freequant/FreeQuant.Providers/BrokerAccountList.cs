// Type: SmartQuant.Providers.BrokerAccountList
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class BrokerAccountList : ICollection, IEnumerable
  {
    private SortedList<string, BrokerAccount> hr2ghYQhPV;
    private List<BrokerAccount> gXQgVvIuK4;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gXQgVvIuK4.Count;
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
        return this.gXQgVvIuK4[index];
      }
    }

    public BrokerAccount this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hr2ghYQhPV[name];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BrokerAccountList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.hr2ghYQhPV = new SortedList<string, BrokerAccount>();
      this.gXQgVvIuK4 = new List<BrokerAccount>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.gXQgVvIuK4.ToArray().CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.gXQgVvIuK4.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(BrokerAccount account)
    {
      this.hr2ghYQhPV.Add(account.Name, account);
      this.gXQgVvIuK4.Add(account);
    }
  }
}
