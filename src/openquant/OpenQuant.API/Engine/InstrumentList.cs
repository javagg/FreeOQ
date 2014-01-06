using OpenQuant.API;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.API.Engine
{
  public class InstrumentList : IEnumerable
  {
    private Dictionary<string, Instrument> instruments;

    public int Count
    {
      get
      {
        return this.instruments.Count;
      }
    }

    public Instrument this[string symbol]
    {
      get
      {
        return this.instruments[symbol];
      }
    }

    internal InstrumentList()
    {
      this.instruments = new Dictionary<string, Instrument>();
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.instruments.Values.GetEnumerator();
    }

    public bool Contains(string name)
    {
      return this.instruments.ContainsKey(name);
    }

    public bool TryGetValue(string name, out Instrument instrument)
    {
      return this.instruments.TryGetValue(name, out instrument);
    }

    public void Add(Instrument instrument)
    {
      this.instruments.Add(instrument.Symbol, instrument);
    }

    public void Add(string symbol)
    {
      this.Add(InstrumentManager.Instruments[symbol]);
    }

    public void Clear()
    {
      this.instruments.Clear();
    }

    public void Remove(string symbol)
    {
      this.instruments.Clear();
    }

    public void Remove(Instrument instrument)
    {
      this.Remove(instrument.Symbol);
    }
  }
}
