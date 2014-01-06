// Type: SmartQuant.Instruments.InstrumentList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.FIX;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class InstrumentList : FIXGroupList
  {
    private string QJlBP9ZG9A;
    private string fegBe316xn;
    private SortedList ex3B24tuTL;
    private SortedList s1kB8GECjT;
    private Hashtable SB4BlaFNT0;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QJlBP9ZG9A;
      }
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fegBe316xn;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fegBe316xn = value;
      }
    }

    public Instrument this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ex3B24tuTL.GetByIndex(index) as Instrument;
      }
    }

    public Instrument this[string symbol]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ex3B24tuTL[(object) symbol] as Instrument;
      }
    }

    public Instrument this[string symbol, string source]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.s1kB8GECjT[(object) (symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2372) + source)] as Instrument ?? this[symbol];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InstrumentList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.ex3B24tuTL = new SortedList();
      this.s1kB8GECjT = new SortedList();
      this.SB4BlaFNT0 = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InstrumentList(string name)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.ex3B24tuTL = new SortedList();
      this.s1kB8GECjT = new SortedList();
      this.SB4BlaFNT0 = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.QJlBP9ZG9A = name;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InstrumentList(string name, string description)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.ex3B24tuTL = new SortedList();
      this.s1kB8GECjT = new SortedList();
      this.SB4BlaFNT0 = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.QJlBP9ZG9A = name;
      this.fegBe316xn = description;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator Instrument[](InstrumentList list)
    {
      return list.fList.ToArray(typeof (Instrument)) as Instrument[];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Instrument instrument)
    {
      if (this.ex3B24tuTL.Contains((object) instrument.Symbol))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2234) + instrument.Symbol);
      this.ex3B24tuTL.Add((object) instrument.Symbol, (object) instrument);
      this.SB4BlaFNT0.Add((object) instrument, (object) true);
      foreach (FIXSecurityAltIDGroup securityAltIdGroup in (FIXGroupList) instrument.SecurityAltIDGroup)
        this.s1kB8GECjT[(object) (securityAltIdGroup.SecurityAltID + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2360) + securityAltIdGroup.SecurityAltIDSource)] = (object) instrument;
      base.Add((FIXGroup) instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Instrument instrument)
    {
      this.ex3B24tuTL.Remove((object) instrument.Symbol);
      this.SB4BlaFNT0.Remove((object) instrument);
      foreach (DictionaryEntry dictionaryEntry in new SortedList((IDictionary) this.s1kB8GECjT))
      {
        if (instrument == dictionaryEntry.Value)
          this.s1kB8GECjT.Remove(dictionaryEntry.Key);
      }
      base.Remove((FIXGroup) instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Clear()
    {
      this.ex3B24tuTL.Clear();
      this.SB4BlaFNT0.Clear();
      this.s1kB8GECjT.Clear();
      base.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string symbol)
    {
      return this.ex3B24tuTL.ContainsKey((object) symbol);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string symbol, string source)
    {
      return this.s1kB8GECjT.ContainsKey((object) (symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2366) + source));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Instrument instrument)
    {
      return this.SB4BlaFNT0.ContainsKey((object) instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instrument GetById(int id)
    {
      return base.GetById(id) as Instrument;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IEnumerator GetEnumerator()
    {
      return this.ex3B24tuTL.Values.GetEnumerator();
    }
  }
}
