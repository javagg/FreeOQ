using System;
using System.Collections;

namespace OpenQuant.API
{
  public class BrokerOrderFieldList : ICollection, IEnumerable
  {
    private SmartQuant.Providers.BrokerOrderField[] fields;

    public int Count
    {
      get
      {
        return this.fields.Length;
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

    public BrokerOrderField this[string name]
    {
      get
      {
        foreach (SmartQuant.Providers.BrokerOrderField field in this.fields)
        {
          if (field.Name == name)
            return new BrokerOrderField(field);
        }
        return (BrokerOrderField) null;
      }
    }

    internal BrokerOrderFieldList(SmartQuant.Providers.BrokerOrderField[] fields)
    {
      this.fields = fields;
    }

    public void CopyTo(Array array, int index)
    {
      ArrayList arrayList = new ArrayList();
      foreach (BrokerOrderField brokerOrderField in this)
        arrayList.Add((object) brokerOrderField);
      arrayList.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator()
    {
      foreach (SmartQuant.Providers.BrokerOrderField field in this.fields)
        yield return (object) new BrokerOrderField(field);
    }
  }
}
