using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class BrokerAccountList : ICollection, IEnumerable
  {
    private SortedList<string, BrokerAccount> hr2ghYQhPV;
    private List<BrokerAccount> gXQgVvIuK4;

    public int Count
    {
       get
      {
        return this.gXQgVvIuK4.Count;
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

    public BrokerAccount this[int index]
    {
       get
      {
        return this.gXQgVvIuK4[index];
      }
    }

    public BrokerAccount this[string name]
    {
       get
      {
        return this.hr2ghYQhPV[name];
      }
    }

    
    internal BrokerAccountList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.hr2ghYQhPV = new SortedList<string, BrokerAccount>();
      this.gXQgVvIuK4 = new List<BrokerAccount>();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.gXQgVvIuK4.ToArray().CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.gXQgVvIuK4.GetEnumerator();
    }

    
    public void Add(BrokerAccount account)
    {
      this.hr2ghYQhPV.Add(account.Name, account);
      this.gXQgVvIuK4.Add(account);
    }
  }
}
