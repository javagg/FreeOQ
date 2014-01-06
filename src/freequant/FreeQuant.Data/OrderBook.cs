// Type: SmartQuant.Data.OrderBook
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using oL6nXjcX2wYBRbhX2q;
using RadDBE9P5I945u5gCE;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Data
{
  public class OrderBook
  {
    private OrderBookEntryList C4Ju1ReVD;
    private OrderBookEntryList tr1AfmP21;

    public OrderBookEntryList Bid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.C4Ju1ReVD;
      }
    }

    public OrderBookEntryList Ask
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tr1AfmP21;
      }
    }

    public event OrderBookEventHandler Changed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderBook()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.C4Ju1ReVD = new OrderBookEntryList();
      this.tr1AfmP21 = new OrderBookEntryList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.C4Ju1ReVD.EeBM3flam();
      this.tr1AfmP21.EeBM3flam();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(MarketDepth marketDepth)
    {
      try
      {
        OrderBookEntryList orderBookEntryList;
        switch (marketDepth.Side)
        {
          case MDSide.Bid:
            orderBookEntryList = this.C4Ju1ReVD;
            break;
          case MDSide.Ask:
            orderBookEntryList = this.tr1AfmP21;
            break;
          default:
            throw new ArgumentException(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(806) + ((object) marketDepth.Side).ToString());
        }
        switch (marketDepth.Operation)
        {
          case MDOperation.Insert:
            if (marketDepth.Position == -1)
            {
              int index = -1;
              switch (marketDepth.Side)
              {
                case MDSide.Bid:
                  index = 0;
                  while (index < orderBookEntryList.Count && marketDepth.Price <= orderBookEntryList[index].Price)
                    ++index;
                  break;
                case MDSide.Ask:
                  index = orderBookEntryList.Count;
                  while (index > 0 && marketDepth.Price <= orderBookEntryList[index - 1].Price)
                    --index;
                  break;
              }
              orderBookEntryList.H7WIwp9Mh(index, new OrderBookEntry(marketDepth.DateTime, marketDepth.Price, marketDepth.Size));
              this.UYB6RbhX2(marketDepth.Side, marketDepth.Operation, index);
              break;
            }
            else
            {
              orderBookEntryList.H7WIwp9Mh(marketDepth.Position, new OrderBookEntry(marketDepth.DateTime, marketDepth.Price, marketDepth.Size));
              this.UYB6RbhX2(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
              break;
            }
          case MDOperation.Update:
            if (marketDepth.Position == -1 || marketDepth.Position >= orderBookEntryList.Count)
              break;
            OrderBookEntry orderBookEntry = orderBookEntryList[marketDepth.Position];
            orderBookEntry.DateTime = marketDepth.DateTime;
            orderBookEntry.Size = marketDepth.Size;
            if (marketDepth.Price > 0.0)
              orderBookEntry.Price = marketDepth.Price;
            this.UYB6RbhX2(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
            break;
          case MDOperation.Delete:
            if (marketDepth.Position == -1)
              break;
            orderBookEntryList.EpiQxWKO6(marketDepth.Position);
            this.UYB6RbhX2(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
            break;
          case MDOperation.Reset:
            orderBookEntryList.EeBM3flam();
            this.UYB6RbhX2(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
            break;
          case MDOperation.Undefined:
            break;
          default:
            throw new ArgumentException(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(840) + ((object) marketDepth.Operation).ToString());
        }
      }
      catch (Exception ex)
      {
        Trace.WriteLine(((object) ex).ToString());
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quote GetQuote(int level)
    {
      DateTime datetime = DateTime.MinValue;
      double bid = 0.0;
      double ask = 0.0;
      int bidSize = 0;
      int askSize = 0;
      if (level < this.C4Ju1ReVD.Count)
      {
        OrderBookEntry orderBookEntry = this.C4Ju1ReVD[level];
        bid = orderBookEntry.Price;
        bidSize = orderBookEntry.Size;
        if (orderBookEntry.DateTime > datetime)
          datetime = orderBookEntry.DateTime;
      }
      if (level < this.tr1AfmP21.Count)
      {
        OrderBookEntry orderBookEntry = this.tr1AfmP21[level];
        ask = orderBookEntry.Price;
        askSize = orderBookEntry.Size;
        if (orderBookEntry.DateTime > datetime)
          datetime = orderBookEntry.DateTime;
      }
      return new Quote(datetime, bid, bidSize, ask, askSize);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetBidVolume()
    {
      int num = 0;
      foreach (OrderBookEntry orderBookEntry in this.C4Ju1ReVD)
        num += orderBookEntry.Size;
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetAskVolume()
    {
      int num = 0;
      foreach (OrderBookEntry orderBookEntry in this.tr1AfmP21)
        num += orderBookEntry.Size;
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAvgBidPrice()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      foreach (OrderBookEntry orderBookEntry in this.C4Ju1ReVD)
      {
        num1 += orderBookEntry.Price * (double) orderBookEntry.Size;
        num2 += (double) orderBookEntry.Size;
      }
      return num1 / num2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAvgAskPrice()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      foreach (OrderBookEntry orderBookEntry in this.tr1AfmP21)
      {
        num1 += orderBookEntry.Price * (double) orderBookEntry.Size;
        num2 += (double) orderBookEntry.Size;
      }
      return num1 / num2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAvgBidPrice(double qty)
    {
      lock (this.C4Ju1ReVD.SyncRoot)
      {
        if (this.C4Ju1ReVD.Count == 0)
          return 0.0;
        double local_0 = 0.0;
        double local_1 = qty;
        foreach (OrderBookEntry item_0 in this.C4Ju1ReVD)
        {
          if (local_1 >= (double) item_0.Size)
          {
            local_0 += item_0.Price * (double) item_0.Size;
            local_1 -= (double) item_0.Size;
          }
          else
          {
            local_0 += item_0.Price * local_1;
            local_1 = 0.0;
          }
          if (local_1 <= 0.0)
            break;
        }
        if (local_1 > 0.0)
          local_0 += this.C4Ju1ReVD[this.C4Ju1ReVD.Count - 1].Price * local_1;
        return local_0 / qty;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAvgAskPrice(double qty)
    {
      lock (this.tr1AfmP21.SyncRoot)
      {
        if (this.tr1AfmP21.Count == 0)
          return 0.0;
        double local_0 = 0.0;
        double local_1 = qty;
        foreach (OrderBookEntry item_0 in this.tr1AfmP21)
        {
          if (local_1 >= (double) item_0.Size)
          {
            local_0 += item_0.Price * (double) item_0.Size;
            local_1 -= (double) item_0.Size;
          }
          else
          {
            local_0 += item_0.Price * local_1;
            local_1 = 0.0;
          }
          if (local_1 <= 0.0)
            break;
        }
        if (local_1 > 0.0)
          local_0 += this.tr1AfmP21[this.tr1AfmP21.Count - 1].Price * local_1;
        return local_0 / qty;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UYB6RbhX2([In] MDSide obj0, [In] MDOperation obj1, [In] int obj2)
    {
      if (this.PBAs33WQb == null)
        return;
      this.PBAs33WQb((object) this, new OrderBookEventArgs(obj0, obj1, obj2));
    }
  }
}
