using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
  public class BrokerPositionFieldList : ICollection, IEnumerable
  {
    private SmartQuant.Providers.BrokerPositionField[] fields;
    private Dictionary<string, SmartQuant.Providers.BrokerPositionField> table;

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
        return this.fields.IsSynchronized;
      }
    }

    public object SyncRoot
    {
      get
      {
        return this.fields.SyncRoot;
      }
    }

    public BrokerPositionField this[string name]
    {
      get
      {
        SmartQuant.Providers.BrokerPositionField field;
        if (this.table.TryGetValue(name, out field))
          return new BrokerPositionField(field);
        else
          return (BrokerPositionField) null;
      }
    }

    internal BrokerPositionFieldList(SmartQuant.Providers.BrokerPositionField[] fields)
    {
      this.fields = fields;
      this.table = new Dictionary<string, SmartQuant.Providers.BrokerPositionField>();
      foreach (SmartQuant.Providers.BrokerPositionField brokerPositionField in fields)
        this.table.Add(brokerPositionField.Name, brokerPositionField);
    }

    public void CopyTo(Array array, int index)
    {
      ArrayList arrayList = new ArrayList();
      foreach (BrokerPositionField brokerPositionField in this)
        arrayList.Add((object) brokerPositionField);
      arrayList.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator()
    {
      foreach (SmartQuant.Providers.BrokerPositionField field in this.fields)
        yield return (object) new BrokerPositionField(field);
    }
  }
}
