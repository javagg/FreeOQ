using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API
{
  public class BrokerAccountFieldList : ICollection, IEnumerable
  {
		private FreeQuant.Providers.BrokerAccountField[] fields;
		private Dictionary<string, Dictionary<string, FreeQuant.Providers.BrokerAccountField>> table;

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

    public BrokerAccountField this[string name, string currency]
    {
      get
      {
				Dictionary<string, FreeQuant.Providers.BrokerAccountField> dictionary;
        if (!this.table.TryGetValue(name, out dictionary))
          return (BrokerAccountField) null;
				FreeQuant.Providers.BrokerAccountField field;
        if (dictionary.TryGetValue(currency, out field))
          return new BrokerAccountField(field);
        else
          return (BrokerAccountField) null;
      }
    }

    public BrokerAccountField this[string name]
    {
      get
      {
        return this[name, string.Empty];
      }
    }

		internal BrokerAccountFieldList(FreeQuant.Providers.BrokerAccountField[] fields)
    {
      this.fields = fields;
			this.table = new Dictionary<string, Dictionary<string, FreeQuant.Providers.BrokerAccountField>>();
			foreach (FreeQuant.Providers.BrokerAccountField brokerAccountField in fields)
      {
				Dictionary<string, FreeQuant.Providers.BrokerAccountField> dictionary;
        if (!this.table.TryGetValue(brokerAccountField.Name, out dictionary))
        {
					dictionary = new Dictionary<string, FreeQuant.Providers.BrokerAccountField>();
          this.table.Add(brokerAccountField.Name, dictionary);
        }
        dictionary.Add(brokerAccountField.Currency, brokerAccountField);
      }
    }

    public void CopyTo(Array array, int index)
    {
      ArrayList arrayList = new ArrayList();
      foreach (BrokerAccountField brokerAccountField in this)
        arrayList.Add((object) brokerAccountField);
      arrayList.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator()
    {
			foreach (FreeQuant.Providers.BrokerAccountField field in this.fields)
        yield return (object) new BrokerAccountField(field);
    }

    public BrokerAccountField[] GetAllByName(string name)
    {
			Dictionary<string, FreeQuant.Providers.BrokerAccountField> dictionary;
      if (!this.table.TryGetValue(name, out dictionary))
        return new BrokerAccountField[0];
      List<BrokerAccountField> list = new List<BrokerAccountField>();
			foreach (FreeQuant.Providers.BrokerAccountField field in dictionary.Values)
        list.Add(new BrokerAccountField(field));
      return list.ToArray();
    }

    public bool Contains(string name, string currency)
    {
      Dictionary<string, SmartQuant.Providers.BrokerAccountField> dictionary;
      if (this.table.TryGetValue(name, out dictionary))
        return dictionary.ContainsKey(currency);
      else
        return false;
    }

    public bool Contains(string name)
    {
      return this.Contains(name, string.Empty);
    }
  }
}
