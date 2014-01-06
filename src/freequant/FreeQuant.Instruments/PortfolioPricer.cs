// Type: SmartQuant.Instruments.PortfolioPricer
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using System.Runtime.CompilerServices;

namespace SmartQuant.Instruments
{
  public class PortfolioPricer : IPortfolioPricer
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PortfolioPricer()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double Price(Position position)
    {
      switch (position.Side)
      {
        case PositionSide.Long:
          if (position.Instrument.OrderBook.Bid.Count != 0)
            return position.Instrument.OrderBook.GetAvgBidPrice(position.Qty);
          if (position.Instrument.Quote.Bid != 0.0)
            return position.Instrument.Quote.Bid;
          else
            break;
        case PositionSide.Short:
          if (position.Instrument.OrderBook.Ask.Count != 0)
            return position.Instrument.OrderBook.GetAvgAskPrice(position.Qty);
          if (position.Instrument.Quote.Ask != 0.0)
            return position.Instrument.Quote.Ask;
          else
            break;
      }
      return position.Instrument.Price();
    }
  }
}
