using System;

namespace OpenQuant.API
{
  public class Trade
  {
    internal FreeQuant.Data.Trade trade;

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
      this.trade = new FreeQuant.Data.Trade(dateTime, price, size);
    }

    internal Trade(FreeQuant.Data.Trade trade)
    {
      this.trade = trade;
    }

    public override string ToString()
    {
      return this.trade.ToString();
    }
  }
}
