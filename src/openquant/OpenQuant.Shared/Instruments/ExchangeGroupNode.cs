using FreeQuant.FIX;
using FreeQuant.Instruments;

namespace OpenQuant.Shared.Instruments
{
  internal class ExchangeGroupNode : GroupNode
  {
    private string securityExchange;

    public ExchangeGroupNode(string securityExchange)
    {
      this.securityExchange = securityExchange;
      this.SetText(securityExchange);
    }

    public override bool IsInstrumentValid(Instrument instrument)
    {
      return ((FIXInstrument) instrument).SecurityExchange == this.securityExchange;
    }
  }
}
