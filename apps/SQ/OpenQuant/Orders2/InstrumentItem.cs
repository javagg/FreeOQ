// Type: OpenQuant.Orders2.InstrumentItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Instruments;

namespace OpenQuant.Orders2
{
  internal class InstrumentItem
  {
    public Instrument Instrument { get; private set; }

    public InstrumentItem(Instrument instrument)
    {
      this.Instrument = instrument;
    }

    public override string ToString()
    {
      return this.Instrument.Symbol;
    }
  }
}
