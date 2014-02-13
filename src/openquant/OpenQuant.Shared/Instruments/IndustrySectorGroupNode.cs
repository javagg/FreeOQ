using FreeQuant.Instruments;

namespace OpenQuant.Shared.Instruments
{
  internal class IndustrySectorGroupNode : GroupNode
  {
    private string sector;

    public IndustrySectorGroupNode(string sector)
    {
      this.sector = sector;
      this.SetText(sector);
    }

    public override bool IsInstrumentValid(Instrument instrument)
    {
      return instrument.IndustrySector == this.sector;
    }
  }
}
