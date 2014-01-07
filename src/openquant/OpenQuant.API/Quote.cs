using System;

namespace OpenQuant.API
{
  public class Quote
  {
    internal FreeQuant.Data.Quote quote;

    public DateTime DateTime
    {
      get
      {
        return this.quote.DateTime;
      }
    }

    public byte ProviderId
    {
      get
      {
        return this.quote.ProviderId;
      }
    }

    public double Bid
    {
      get
      {
        return this.quote.Bid;
      }
    }

    public double Ask
    {
      get
      {
        return this.quote.Ask;
      }
    }

    public int BidSize
    {
      get
      {
        return this.quote.BidSize;
      }
    }

    public int AskSize
    {
      get
      {
        return this.quote.AskSize;
      }
    }

    public Quote(DateTime dateTime, double bid, int bidSize, double ask, int askSize)
    {
      this.quote = new FreeQuant.Data.Quote(dateTime, bid, bidSize, ask, askSize);
    }

    internal Quote(FreeQuant.Data.Quote quote)
    {
      this.quote = quote;
    }

    public override string ToString()
    {
      return this.quote.ToString();
    }
  }
}
