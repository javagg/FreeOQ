namespace FreeQuant.Instruments
{
  public interface IPortfolioPricer
  {
    double Price(Position position);
  }
}
