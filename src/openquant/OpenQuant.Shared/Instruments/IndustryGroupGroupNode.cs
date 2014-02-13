using FreeQuant.Instruments;

namespace OpenQuant.Shared.Instruments
{
  internal class IndustryGroupGroupNode : GroupNode
  {
    private string group;

    public IndustryGroupGroupNode(string group)
    {
      this.group = group;
      this.SetText(group);
    }

    public override bool IsInstrumentValid(Instrument instrument)
    {
      return instrument.IndustryGroup == this.group;
    }
  }
}
