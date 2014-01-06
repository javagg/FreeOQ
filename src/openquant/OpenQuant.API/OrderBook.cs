using System;

namespace OpenQuant.API
{
  public class OrderBook
  {
    private SmartQuant.Data.OrderBook book;

    public int Count
    {
      get
      {
        return Math.Max(this.book.Ask.Count, this.book.Bid.Count);
      }
    }

    internal OrderBook(SmartQuant.Data.OrderBook book)
    {
      this.book = book;
    }

    public Quote GetQuote(int level)
    {
      return new Quote(this.book.GetQuote(level));
    }

    public int GetBidVolume()
    {
      return this.book.GetBidVolume();
    }

    public int GetAskVolume()
    {
      return this.book.GetAskVolume();
    }

    public double GetAvgBidPrice()
    {
      return this.book.GetAvgBidPrice();
    }

    public double GetAvgAskPrice()
    {
      return this.book.GetAvgAskPrice();
    }
  }
}
