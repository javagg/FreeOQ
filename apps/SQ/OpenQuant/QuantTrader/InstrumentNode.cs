// Type: OpenQuant.QuantTrader.InstrumentNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Instruments;

namespace OpenQuant.QuantTrader
{
  internal class InstrumentNode : ExportItemNode
  {
    public Instrument Instrument { get; private set; }

    public InstrumentNode(Instrument instrument)
      : base(instrument.Symbol, 4)
    {
      this.Instrument = instrument;
    }
  }
}
