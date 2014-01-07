using System;
using System.Collections;

namespace OpenQuant.API
{
  public class BrokerOrderList : ICollection, IEnumerable
  {
		private FreeQuant.Providers.BrokerOrder[] orders;

    public int Count
    {
      get
      {
        return this.orders.Length;
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

    public BrokerOrder this[int index]
    {
      get
      {
        if (index < 0 || index >= this.orders.Length)
          return (BrokerOrder) null;
        else
          return new BrokerOrder(this.orders[index]);
      }
    }

		internal BrokerOrderList(FreeQuant.Providers.BrokerOrder[] orders)
    {
      this.orders = orders;
    }

    public void CopyTo(Array array, int index)
    {
      ArrayList arrayList = new ArrayList();
      foreach (BrokerOrder brokerOrder in this)
        arrayList.Add((object) brokerOrder);
      arrayList.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator()
    {
			foreach (FreeQuant.Providers.BrokerOrder brokerOrder in this.orders)
        yield return (object) new BrokerOrder(brokerOrder);
    }
  }
}
