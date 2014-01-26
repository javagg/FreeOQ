using FreeQuant.FIX;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
	public class InstrumentList : FIXGroupList
	{
		private SortedList instrumentsBySymbol = new SortedList();
		private SortedList s1kB8GECjT = new SortedList();
		private Hashtable SB4BlaFNT0 = new Hashtable();

		public string Name { get; private set; }
		public string Description { get; set; }

		new public Instrument this[int index]
		{
			get
			{
				return this.instrumentsBySymbol.GetByIndex(index) as Instrument;
			}
		}

		public Instrument this[string symbol]
		{
			get
			{
				return this.instrumentsBySymbol[symbol] as Instrument;
			}
		}

		public Instrument this[string symbol, string source]
		{
			get
			{
				return this.s1kB8GECjT[symbol + "" + source] as Instrument ?? this[symbol];
			}
		}

	public InstrumentList(string name = null, string description = null) : base()
		{
			this.Name = name ?? String.Empty;
			this.Description = description ?? String.Empty;
		}

		public static implicit operator Instrument[](InstrumentList list)
		{
			return list.fList.ToArray(typeof(Instrument)) as Instrument[];
		}

		public void Add(Instrument instrument)
		{
//      if (this.ex3B24tuTL.Contains(instrument.Symbol))
//        throw new ApplicationException(instrument.Symbol);
			this.instrumentsBySymbol.Add(instrument.Symbol, instrument);
			this.SB4BlaFNT0.Add(instrument, true);
			foreach (FIXSecurityAltIDGroup group in instrument.SecurityAltIDGroup)
				this.s1kB8GECjT[group.SecurityAltID + "" + group.SecurityAltIDSource] = instrument;
			base.Add(instrument);
		}

		public void Remove(Instrument instrument)
		{
			this.instrumentsBySymbol.Remove(instrument.Symbol);
			this.SB4BlaFNT0.Remove(instrument);
			foreach (DictionaryEntry dictionaryEntry in new SortedList((IDictionary) this.s1kB8GECjT))
			{
				if (instrument == dictionaryEntry.Value)
					this.s1kB8GECjT.Remove(dictionaryEntry.Key);
			}
			base.Remove(instrument);
		}

		public override void Clear()
		{
			this.instrumentsBySymbol.Clear();
			this.SB4BlaFNT0.Clear();
			this.s1kB8GECjT.Clear();
			base.Clear();
		}

		public bool Contains(string symbol)
		{
			return this.instrumentsBySymbol.ContainsKey(symbol);
		}

		public bool Contains(string symbol, string source)
		{
			return this.s1kB8GECjT.ContainsKey(symbol + "" + source);
		}

		public bool Contains(Instrument instrument)
		{
			return this.SB4BlaFNT0.ContainsKey(instrument);
		}

		new public Instrument GetById(int id)
		{
			return base.GetById(id) as Instrument;
		}

		public override IEnumerator GetEnumerator()
		{
			return this.instrumentsBySymbol.Values.GetEnumerator();
		}
	}
}
