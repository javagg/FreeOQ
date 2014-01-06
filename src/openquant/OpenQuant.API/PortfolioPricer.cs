using System;

namespace OpenQuant.API
{
  public class PortfolioPricer
  {
    private static DefaultPortfolioPricer defaultPricer;

    public static PortfolioPricer Default
    {
      get
      {
        if (PortfolioPricer.defaultPricer == null)
          PortfolioPricer.defaultPricer = new DefaultPortfolioPricer();
        return (PortfolioPricer) PortfolioPricer.defaultPricer;
      }
    }

    public virtual double Price(Position position)
    {
      if (position.Instrument.Quote.DateTime != DateTime.MinValue)
      {
        switch (position.Side)
        {
          case PositionSide.Long:
            if (position.Instrument.Quote.Bid != 0.0)
              return position.Instrument.Quote.Bid;
            else
              break;
          case PositionSide.Short:
            if (position.Instrument.Quote.Ask != 0.0)
              return position.Instrument.Quote.Ask;
            else
              break;
        }
      }
      if (position.Instrument.Trade.DateTime != DateTime.MinValue)
        return position.Instrument.Trade.Price;
      if (position.Instrument.Bar.DateTime != DateTime.MinValue)
        return position.Instrument.Bar.Close;
      else
        return 0.0;
    }
  }
}
