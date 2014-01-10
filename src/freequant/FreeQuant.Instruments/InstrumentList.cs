using FreeQuant.FIX;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
  public class InstrumentList : FIXGroupList
  {
    private string name;
    private string description;
    private SortedList ex3B24tuTL;
    private SortedList s1kB8GECjT;
    private Hashtable SB4BlaFNT0;

    public string Name
    {
       get
      {
				return this.name; 
      }
    }

    public string Description
    {
       get
      {
				return this.description; 
      }
       set
      {
        this.description = value;
      }
    }

    public Instrument this[int index]
    {
       get
      {
        return this.ex3B24tuTL.GetByIndex(index) as Instrument;
      }
    }

    public Instrument this[string symbol]
    {
       get
      {
        return this.ex3B24tuTL[(object) symbol] as Instrument;
      }
    }

    public Instrument this[string symbol, string source]
    {
       get
      {
        return this.s1kB8GECjT[(object) (symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2372) + source)] as Instrument ?? this[symbol];
      }
    }

    
		public InstrumentList() :base()
    {

      this.ex3B24tuTL = new SortedList();
      this.s1kB8GECjT = new SortedList();
      this.SB4BlaFNT0 = new Hashtable();

    }

    
		public InstrumentList(string name):base()
    {

      this.ex3B24tuTL = new SortedList();
      this.s1kB8GECjT = new SortedList();
      this.SB4BlaFNT0 = new Hashtable();

      this.name = name;
    }

    
		public InstrumentList(string name, string description):base()
    {

      this.ex3B24tuTL = new SortedList();
      this.s1kB8GECjT = new SortedList();
      this.SB4BlaFNT0 = new Hashtable();

      this.name = name;
      this.description = description;
    }

    
    public static implicit operator Instrument[](InstrumentList list)
    {
      return list.fList.ToArray(typeof (Instrument)) as Instrument[];
    }

    
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

    
    public override void Clear()
    {
      this.ex3B24tuTL.Clear();
      this.SB4BlaFNT0.Clear();
      this.s1kB8GECjT.Clear();
      base.Clear();
    }

    
    public bool Contains(string symbol)
    {
      return this.ex3B24tuTL.ContainsKey((object) symbol);
    }

    
    public bool Contains(string symbol, string source)
    {
      return this.s1kB8GECjT.ContainsKey((object) (symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2366) + source));
    }

    
    public bool Contains(Instrument instrument)
    {
      return this.SB4BlaFNT0.ContainsKey((object) instrument);
    }

    
    public Instrument GetById(int id)
    {
      return base.GetById(id) as Instrument;
    }

    
    public override IEnumerator GetEnumerator()
    {
      return this.ex3B24tuTL.Values.GetEnumerator();
    }
  }
}
