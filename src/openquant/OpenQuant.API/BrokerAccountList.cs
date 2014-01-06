using System;
using System.Collections;

namespace OpenQuant.API
{
  public class BrokerAccountList : ICollection, IEnumerable
  {
    private SmartQuant.Providers.BrokerAccountList list;

    public int Count
    {
      get
      {
        return this.list.Count;
      }
    }

    public bool IsSynchronized
    {
      get
      {
        return this.list.IsSynchronized;
      }
    }

    public object SyncRoot
    {
      get
      {
        return this.list.SyncRoot;
      }
    }

    public BrokerAccount this[int index]
    {
      get
      {
        return new BrokerAccount(this.list[index]);
      }
    }

    public BrokerAccount this[string name]
    {
      get
      {
        return new BrokerAccount(this.list[name]);
      }
    }

    internal BrokerAccountList(SmartQuant.Providers.BrokerAccountList list)
    {
      this.list = list;
    }

    public void CopyTo(Array array, int index)
    {
      ArrayList arrayList = new ArrayList();
      foreach (BrokerAccount brokerAccount in this)
        arrayList.Add((object) brokerAccount);
      arrayList.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator()
    {
      foreach (SmartQuant.Providers.BrokerAccount brokerAccount in this.list)
        yield return (object) new BrokerAccount(brokerAccount);
    }
  }
}
