// Type: SmartQuant.Trading.OrderTable
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Execution;
using SmartQuant.Instruments;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public class OrderTable : ICollection, IEnumerable
  {
    private Hashtable Nu5iGXwNr9;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Nu5iGXwNr9.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Nu5iGXwNr9.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Nu5iGXwNr9.SyncRoot;
      }
    }

    public NamedOrderTable this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (!this.Nu5iGXwNr9.ContainsKey((object) instrument))
          this.Nu5iGXwNr9.Add((object) instrument, (object) new NamedOrderTable());
        return this.Nu5iGXwNr9[(object) instrument] as NamedOrderTable;
      }
    }

    public SingleOrder this[Instrument instrument, string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (this.Nu5iGXwNr9[(object) instrument] as NamedOrderTable)[name];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderTable()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Nu5iGXwNr9 = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.Nu5iGXwNr9.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.Nu5iGXwNr9.Clear();
    }
  }
}
