using FreeQuant.Instruments;

namespace OpenQuant.API
{
  internal class SQPortfolioPricer : IPortfolioPricer
  {
    private PortfolioPricer pricer;

    public SQPortfolioPricer(PortfolioPricer pricer)
    {
      this.pricer = pricer;
    }

    public double Price(SmartQuant.Instruments.Position position)
    {
      return this.pricer.Price(new Position(position));
    }
  }
}
