// Type: OpenQuant.Projects.UI.InstrumentItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Instruments;

namespace OpenQuant.Projects.UI
{
  public class InstrumentItem
  {
    private Instrument instrument;

    public Instrument Instrument
    {
      get
      {
        return this.instrument;
      }
    }

    public InstrumentItem(Instrument instrument)
    {
      this.instrument = instrument;
    }

    public override string ToString()
    {
      return this.instrument.Symbol;
    }
  }
}
