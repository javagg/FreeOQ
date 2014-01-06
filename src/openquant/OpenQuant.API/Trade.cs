using System;

namespace OpenQuant.API
{
  public class Trade
  {
    internal SmartQuant.Data.Trade trade;

    public DateTime DateTime
    {
      get
      {
        return this.trade.DateTime;
      }
    }

    public byte ProviderId
    {
      get
      {
        return this.trade.ProviderId;
      }
    }

    public double Price
    {
      get
      {
        return this.trade.Price;
      }
    }

    public int Size
    {
      get
      {
        return this.trade.Size;
      }
    }

    public Trade(DateTime dateTime, double price, int size)
    {
      this.trade = new SmartQuant.Data.Trade(dateTime, price, size);
    }

    internal Trade(SmartQuant.Data.Trade trade)
    {
      this.trade = trade;
    }

    public override string ToString()
    {
      return this.trade.ToString();
    }
  }
}
