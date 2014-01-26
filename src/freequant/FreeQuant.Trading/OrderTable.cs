using FreeQuant.Execution;
using FreeQuant.Instruments;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class OrderTable : ICollection, IEnumerable
  {
    private Hashtable Nu5iGXwNr9;

    public bool IsSynchronized
    {
       get
      {
        return this.Nu5iGXwNr9.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.Nu5iGXwNr9.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.Nu5iGXwNr9.SyncRoot;
      }
    }

    public NamedOrderTable this[Instrument instrument]
    {
       get
      {
        if (!this.Nu5iGXwNr9.ContainsKey((object) instrument))
          this.Nu5iGXwNr9.Add((object) instrument, (object) new NamedOrderTable());
        return this.Nu5iGXwNr9[(object) instrument] as NamedOrderTable;
      }
    }

    public SingleOrder this[Instrument instrument, string name]
    {
       get
      {
        return (this.Nu5iGXwNr9[(object) instrument] as NamedOrderTable)[name];
      }
    }

    
		public OrderTable():base()
    {
      this.Nu5iGXwNr9 = new Hashtable();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.Nu5iGXwNr9.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      ArrayList arrayList = new ArrayList();
      foreach (DictionaryEntry dictionaryEntry1 in this.Nu5iGXwNr9)
      {
        foreach (DictionaryEntry dictionaryEntry2 in (IEnumerable) dictionaryEntry1.Value)
          arrayList.Add(dictionaryEntry2.Value);
      }
      return arrayList.GetEnumerator();
    }

    
    public void Add(Instrument instrument, string name, SingleOrder order)
    {
      NamedOrderTable namedOrderTable;
      if (this.Nu5iGXwNr9.ContainsKey((object) instrument))
      {
        namedOrderTable = this.Nu5iGXwNr9[(object) instrument] as NamedOrderTable;
      }
      else
      {
        namedOrderTable = new NamedOrderTable();
        this.Nu5iGXwNr9.Add((object) instrument, (object) namedOrderTable);
      }
      namedOrderTable.vxbiSOygU5(name, order);
    }

    
    public void Clear()
    {
      this.Nu5iGXwNr9.Clear();
    }
  }
}
