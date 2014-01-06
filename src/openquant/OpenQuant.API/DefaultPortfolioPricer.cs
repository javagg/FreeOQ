namespace OpenQuant.API
{
  internal class DefaultPortfolioPricer : PortfolioPricer
  {
    public SmartQuant.Instruments.PortfolioPricer Pricer { get; set; }

    public DefaultPortfolioPricer()
    {
      this.Pricer = new SmartQuant.Instruments.PortfolioPricer();
    }

    public override double Price(Position position)
    {
      return this.Pricer.Price(position.position);
    }
  }
}
