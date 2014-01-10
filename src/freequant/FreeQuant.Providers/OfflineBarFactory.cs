using FreeQuant.Data;
using FreeQuant.FIX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Providers
{
  public class OfflineBarFactory : IBarFactory
  {
    private const bool FNll06Lmb = true;
    private const BarFactoryInput U0W77l8lB = BarFactoryInput.Trade;
    private Dictionary<IFIXInstrument, Dictionary<BarType, SortedList<long, OfflineBarFactory.PVGcuMn6TQoRUEfhwr>>> ReSeeRRAl;
    private Dictionary<IFIXInstrument, Quote> ALv6cyCmM;

    [DefaultValue(true)]
    public bool Enabled {  get;  set; }

    [DefaultValue(BarFactoryInput.Trade)]
    public BarFactoryInput Input {  get;  set; }

    public BarFactoryItemList Items {  get;  private set; }

    public event BarEventHandler NewBar;

    public event BarEventHandler NewBarOpen;

    public event BarSliceEventHandler NewBarSlice;

    
    public OfflineBarFactory()
    {
      this.Enabled = true;
      this.Input = BarFactoryInput.Trade;
      this.Items = new BarFactoryItemList();
      this.ReSeeRRAl = new Dictionary<IFIXInstrument, Dictionary<BarType, SortedList<long, OfflineBarFactory.PVGcuMn6TQoRUEfhwr>>>();
      this.ALv6cyCmM = new Dictionary<IFIXInstrument, Quote>();
    }

    
    public void OnNewTrade(IFIXInstrument instrument, Trade trade)
    {
      if (!this.Enabled || this.Input != BarFactoryInput.Trade)
        return;
      this.WJWi7M4Wg(instrument, trade.DateTime, trade.Price, trade.Size);
    }

    
    public void OnNewQuote(IFIXInstrument instrument, Quote quote)
    {
      if (!this.Enabled)
        return;
      Quote quote1;
      if (!this.ALv6cyCmM.TryGetValue(instrument, out quote1))
      {
        quote1 = new Quote();
        this.ALv6cyCmM.Add(instrument, quote1);
      }
      switch (this.Input)
      {
        case BarFactoryInput.Bid:
          if (quote.Bid != quote1.Bid || quote.BidSize != quote1.BidSize)
          {
            this.WJWi7M4Wg(instrument, quote.DateTime, quote.Bid, quote.BidSize);
            break;
          }
          else
            break;
        case BarFactoryInput.Ask:
          if (quote.Ask != quote1.Ask || quote.AskSize != quote1.AskSize)
          {
            this.WJWi7M4Wg(instrument, quote.DateTime, quote.Ask, quote.AskSize);
            break;
          }
          else
            break;
        case BarFactoryInput.BidAsk:
          if (quote.Ask != quote1.Ask || quote.AskSize != quote1.AskSize)
            this.WJWi7M4Wg(instrument, quote.DateTime, quote.Ask, quote.AskSize);
          if (quote.Bid != quote1.Bid || quote.BidSize != quote1.BidSize)
          {
            this.WJWi7M4Wg(instrument, quote.DateTime, quote.Bid, quote.BidSize);
            break;
          }
          else
            break;
        case BarFactoryInput.Middle:
          if (quote.Ask != quote1.Ask || quote.AskSize != quote1.AskSize || (quote.Bid != quote1.Bid || quote.BidSize != quote1.BidSize))
          {
            this.WJWi7M4Wg(instrument, quote.DateTime, (quote.Ask + quote.Bid) / 2.0, (quote.AskSize + quote.BidSize) / 2);
            break;
          }
          else
            break;
        case BarFactoryInput.Spread:
          if (quote.Ask != quote1.Ask || quote.AskSize != quote1.AskSize || (quote.Bid != quote1.Bid || quote.BidSize != quote1.BidSize))
          {
            this.WJWi7M4Wg(instrument, quote.DateTime, quote.Ask - quote.Bid, 0);
            break;
          }
          else
            break;
      }
      quote1.Ask = quote.Ask;
      quote1.Bid = quote.Bid;
      quote1.AskSize = quote.AskSize;
      quote1.BidSize = quote.BidSize;
    }

    
    public void Reset()
    {
      this.ReSeeRRAl.Clear();
      this.ALv6cyCmM.Clear();
    }

    
    private void WJWi7M4Wg([In] IFIXInstrument obj0, [In] DateTime obj1, [In] double obj2, [In] int obj3)
    {
      foreach (BarFactoryItem barFactoryItem in this.Items)
      {
        if (barFactoryItem.Enabled)
        {
          Dictionary<BarType, SortedList<long, OfflineBarFactory.PVGcuMn6TQoRUEfhwr>> dictionary;
          if (!this.ReSeeRRAl.TryGetValue(obj0, out dictionary))
          {
            dictionary = new Dictionary<BarType, SortedList<long, OfflineBarFactory.PVGcuMn6TQoRUEfhwr>>();
            this.ReSeeRRAl.Add(obj0, dictionary);
          }
          SortedList<long, OfflineBarFactory.PVGcuMn6TQoRUEfhwr> sortedList;
          if (!dictionary.TryGetValue(barFactoryItem.BarType, out sortedList))
          {
            sortedList = new SortedList<long, OfflineBarFactory.PVGcuMn6TQoRUEfhwr>();
            dictionary.Add(barFactoryItem.BarType, sortedList);
          }
          OfflineBarFactory.PVGcuMn6TQoRUEfhwr gcuMn6TqoRuEfhwr;
          if (!sortedList.TryGetValue(barFactoryItem.BarSize, out gcuMn6TqoRuEfhwr))
          {
            gcuMn6TqoRuEfhwr = new OfflineBarFactory.PVGcuMn6TQoRUEfhwr();
            sortedList.Add(barFactoryItem.BarSize, gcuMn6TqoRuEfhwr);
          }
          switch (barFactoryItem.BarType)
          {
            case BarType.Time:
              if (gcuMn6TqoRuEfhwr.rwG1TvUU0 == null || gcuMn6TqoRuEfhwr.rwG1TvUU0.EndTime <= obj1)
              {
                if (gcuMn6TqoRuEfhwr.rwG1TvUU0 != null)
                  this.M28GqE2S2(obj0, gcuMn6TqoRuEfhwr.rwG1TvUU0);
                DateTime dateTime1;
                DateTime dateTime2;
                this.iYlXRwvKS(obj1, barFactoryItem.BarSize, out dateTime1, out dateTime2);
                gcuMn6TqoRuEfhwr.rwG1TvUU0 = this.ssgZj9bjo(BarType.Time, barFactoryItem.BarSize, dateTime1, dateTime2, obj2);
              }
              this.jtf8pUBX1(gcuMn6TqoRuEfhwr.rwG1TvUU0, obj2, obj3);
              continue;
            case BarType.Tick:
              if (gcuMn6TqoRuEfhwr.rwG1TvUU0 == null)
                gcuMn6TqoRuEfhwr.rwG1TvUU0 = this.ssgZj9bjo(BarType.Tick, barFactoryItem.BarSize, obj1, obj1, obj2);
              this.jtf8pUBX1(gcuMn6TqoRuEfhwr.rwG1TvUU0, obj2, obj3);
              gcuMn6TqoRuEfhwr.rwG1TvUU0.EndTime = obj1;
              if ((long) ++gcuMn6TqoRuEfhwr.WWlIn4O0w == barFactoryItem.BarSize)
              {
                this.M28GqE2S2(obj0, gcuMn6TqoRuEfhwr.rwG1TvUU0);
                gcuMn6TqoRuEfhwr.rwG1TvUU0 = (Bar) null;
                gcuMn6TqoRuEfhwr.WWlIn4O0w = 0;
                continue;
              }
              else
                continue;
            case BarType.Volume:
              if (gcuMn6TqoRuEfhwr.rwG1TvUU0 == null)
                gcuMn6TqoRuEfhwr.rwG1TvUU0 = this.ssgZj9bjo(BarType.Volume, barFactoryItem.BarSize, obj1, obj1, obj2);
              this.jtf8pUBX1(gcuMn6TqoRuEfhwr.rwG1TvUU0, obj2, obj3);
              gcuMn6TqoRuEfhwr.rwG1TvUU0.EndTime = obj1;
              if (gcuMn6TqoRuEfhwr.rwG1TvUU0.Volume >= barFactoryItem.BarSize)
              {
                this.M28GqE2S2(obj0, gcuMn6TqoRuEfhwr.rwG1TvUU0);
                gcuMn6TqoRuEfhwr.rwG1TvUU0 = (Bar) null;
                continue;
              }
              else
                continue;
            default:
              continue;
          }
        }
      }
    }

    
    private void jtf8pUBX1([In] Bar obj0, [In] double obj1, [In] int obj2)
    {
      if (obj1 > obj0.High)
        obj0.High = obj1;
      if (obj1 < obj0.Low)
        obj0.Low = obj1;
      obj0.Close = obj1;
      obj0.Volume += (long) obj2;
    }

    
    private Bar ssgZj9bjo([In] BarType obj0, [In] long obj1, [In] DateTime obj2, [In] DateTime obj3, [In] double obj4)
    {
      return new Bar(obj0, obj1, obj2, obj3, obj4, obj4, obj4, obj4, 0L, 0L);
    }

    
    private void iYlXRwvKS([In] DateTime obj0, [In] long obj1, out DateTime _param3, out DateTime _param4)
    {
      long num = (long) obj0.TimeOfDay.TotalSeconds / obj1 * obj1;
      param2 = obj0.Date.AddSeconds((double) num);
      param3 = param2.AddSeconds((double) obj1);
    }

    
    private void CgiTKf5gQ([In] IFIXInstrument obj0, [In] Bar obj1)
    {
      if (this.JL8oPByHO == null)
        return;
      this.JL8oPByHO((object) this, new BarEventArgs(obj1, obj0, (IMarketDataProvider) null));
    }

    
    private void M28GqE2S2([In] IFIXInstrument obj0, [In] Bar obj1)
    {
      if (this.CSbm1wLhQ == null)
        return;
      this.CSbm1wLhQ((object) this, new BarEventArgs(obj1, obj0, (IMarketDataProvider) null));
    }

    
    private void jsgfiCe1q([In] IFIXInstrument obj0, [In] long obj1)
    {
      if (this.W79MPhgAi == null)
        return;
      this.W79MPhgAi((object) this, new BarSliceEventArgs(obj1, (IMarketDataProvider) null));
    }

    
    public override string ToString()
    {
      return GojrKtfk5NMi1fou68.a17L2Y7Wnd(400);
    }

    private class PVGcuMn6TQoRUEfhwr
    {
      public Bar rwG1TvUU0;
      public int WWlIn4O0w;

      
      public PVGcuMn6TQoRUEfhwr()
      {
        Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.rwG1TvUU0 = (Bar) null;
        this.WWlIn4O0w = 0;
      }
    }
  }
}
