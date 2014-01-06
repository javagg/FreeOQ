using FreeQuant.Data;
using System;

namespace OpenQuant.API
{
  public class OrderBookUpdate
  {
    internal MarketDepth marketDepth;

    public DateTime DateTime
    {
      get
      {
        return this.marketDepth.DateTime;
      }
    }

    public BidAsk Side
    {
      get
      {
        return EnumConverter.Convert(this.marketDepth.Side);
      }
    }

    public OrderBookAction Action
    {
      get
      {
        return EnumConverter.Convert(this.marketDepth.Operation);
      }
    }

    public double Price
    {
      get
      {
        return this.marketDepth.Price;
      }
    }

    public int Size
    {
      get
      {
        return this.marketDepth.Size;
      }
    }

    public int Position
    {
      get
      {
        return this.marketDepth.Position;
      }
    }

    internal OrderBookUpdate(MarketDepth marketDepth)
    {
      this.marketDepth = marketDepth;
    }

    public override string ToString()
    {
      return string.Format("{0} {1} {2} price={3} size={4} position={5}", (object) this.DateTime, (object) this.Side, (object) this.Action, (object) this.Price, (object) this.Size, (object) this.Position);
    }
  }
}
