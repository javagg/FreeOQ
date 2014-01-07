// Type: OpenQuant.Projects.UI.Items.InstrumentNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.ObjectMap;
using SmartQuant.Instruments;
using System.Collections;

namespace OpenQuant.Projects.UI.Items
{
  internal class InstrumentNode : ObjectNode
  {
    private Instrument instrument;

    public Instrument Instrument
    {
      get
      {
        return this.instrument;
      }
    }

    public InstrumentNode(Instrument instrument)
      : base(instrument.Symbol, 3)
    {
      this.instrument = instrument;
      this.nodeObject = ((Hashtable) Map.SQ_OQ_Instrument)[(object) instrument];
    }
  }
}
