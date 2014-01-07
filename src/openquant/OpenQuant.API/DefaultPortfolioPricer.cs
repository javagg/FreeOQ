namespace OpenQuant.API
{
  internal class DefaultPortfolioPricer : PortfolioPricer
  {
		public FreeQuant.Instruments.PortfolioPricer Pricer { get; set; }

    public DefaultPortfolioPricer()
    {
			this.Pricer = new FreeQuant.Instruments.PortfolioPricer();
    }

    public override double Price(Position position)
    {
      return this.Pricer.Price(position.position);
    }
  }
}
