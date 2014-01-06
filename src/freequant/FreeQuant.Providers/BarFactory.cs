// Type: SmartQuant.Providers.BarFactory
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.FIX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Providers
{
  public class BarFactory : IBarFactory
  {
    private const string hFtLyipXRG = "Status";
    private const string w00L1kRu8f = "Items";
    private const bool uT5LIErCBA = true;
    internal const BarFactoryInput W30Lx1mRp2 = BarFactoryInput.Trade;
    private BarFactoryItemList n6XLE9i7XS;
    private Hashtable A3ELH6L4QJ;
    private Hashtable NJNLAPvWPO;
    private bool f30LaZttrW;
    private BarFactoryInput zEYL4Du9Q1;
    private Hashtable cqyLFWMOvs;

    [DefaultValue(true)]
    [Category("Status")]
    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.f30LaZttrW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.f30LaZttrW = value;
      }
    }

    [DefaultValue(BarFactoryInput.Trade)]
    public BarFactoryInput Input
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.zEYL4Du9Q1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.zEYL4Du9Q1 = value;
      }
    }

    [Category("Items")]
    public BarFactoryItemList Items
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.n6XLE9i7XS;
      }
    }

    public event BarEventHandler NewBar;

    public event BarEventHandler NewBarOpen;

    public event BarSliceEventHandler NewBarSlice;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFactory(bool enabled)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.f30LaZttrW = enabled;
      this.zEYL4Du9Q1 = BarFactoryInput.Trade;
      this.cqyLFWMOvs = new Hashtable();
      this.n6XLE9i7XS = new BarFactoryItemList();
      this.n6XLE9i7XS.Add(new BarFactoryItem());
      this.A3ELH6L4QJ = new Hashtable();
      this.NJNLAPvWPO = Hashtable.Synchronized(new Hashtable());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFactory()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      this.\u002Ector(true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnNewTrade(IFIXInstrument instrument, Trade trade)
    {
      if (!this.f30LaZttrW || this.zEYL4Du9Q1 != BarFactoryInput.Trade)
        return;
      this.h0TLeQWiAU(instrument, Clock.Now, trade.Price, trade.Size);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnNewQuote(IFIXInstrument instrument, Quote quote)
    {
      if (!this.f30LaZttrW)
        return;
      double num1;
      int num2;
      switch (this.zEYL4Du9Q1)
      {
        case BarFactoryInput.Bid:
          num1 = quote.Bid;
          num2 = quote.BidSize;
          break;
        case BarFactoryInput.Ask:
          num1 = quote.Ask;
          num2 = quote.AskSize;
          break;
        case BarFactoryInput.BidAsk:
          this.h0TLeQWiAU(instrument, Clock.Now, quote.Bid, quote.BidSize);
          this.h0TLeQWiAU(instrument, Clock.Now, quote.Ask, quote.AskSize);
          return;
        case BarFactoryInput.Middle:
          this.h0TLeQWiAU(instrument, Clock.Now, (quote.Ask + quote.Bid) / 2.0, (quote.AskSize + quote.BidSize) / 2);
          return;
        case BarFactoryInput.Spread:
          num1 = quote.Ask - quote.Bid;
          num2 = 0;
          break;
        default:
          return;
      }
      BarFactory.mU5OEr88NSmCpsBxeD u5Oer88NsmCpsBxeD = this.cqyLFWMOvs[(object) instrument] as BarFactory.mU5OEr88NSmCpsBxeD;
      if (u5Oer88NsmCpsBxeD == null)
      {
        u5Oer88NsmCpsBxeD = new BarFactory.mU5OEr88NSmCpsBxeD();
        this.cqyLFWMOvs.Add((object) instrument, (object) u5Oer88NsmCpsBxeD);
      }
      if (num1 == u5Oer88NsmCpsBxeD.m8FLQ7V52X && num2 == u5Oer88NsmCpsBxeD.MpnLJAJ41c)
        return;
      this.h0TLeQWiAU(instrument, Clock.Now, num1, num2);
      u5Oer88NsmCpsBxeD.m8FLQ7V52X = num1;
      u5Oer88NsmCpsBxeD.MpnLJAJ41c = num2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset()
    {
      this.A3ELH6L4QJ.Clear();
      this.NJNLAPvWPO.Clear();
      this.cqyLFWMOvs.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void h0TLeQWiAU([In] IFIXInstrument obj0, [In] DateTime obj1, [In] double obj2, [In] int obj3)
    {
      List<BarFactory.zNxuFsXhPSM7NAan2D> list = new List<BarFactory.zNxuFsXhPSM7NAan2D>();
      lock (this)
      {
        foreach (BarFactoryItem item_0 in this.n6XLE9i7XS)
        {
          if (item_0.Enabled)
          {
            Hashtable local_2 = this.A3ELH6L4QJ[(object) obj0] as Hashtable;
            if (local_2 == null)
            {
              local_2 = new Hashtable();
              this.A3ELH6L4QJ.Add((object) obj0, (object) local_2);
            }
            SortedList local_3 = local_2[(object) item_0.BarType] as SortedList;
            if (local_3 == null)
            {
              local_3 = new SortedList();
              local_2.Add((object) item_0.BarType, (object) local_3);
            }
            switch (item_0.BarType)
            {
              case BarType.Time:
                Bar local_4 = local_3[(object) item_0.BarSize] as Bar;
                if (local_4 == null)
                {
                  DateTime local_5 = this.qJpLNA6Aiq(obj1, item_0.BarSize);
                  Bar local_4_1 = new Bar(BarType.Time, item_0.BarSize, local_5, local_5, obj2, obj2, obj2, obj2, (long) obj3, 0L);
                  local_3.Add((object) item_0.BarSize, (object) local_4_1);
                  list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6) 0, local_4_1));
                  goto case BarType.Dynamic;
                }
                else
                {
                  local_4.EndTime = obj1;
                  if (obj2 > local_4.High)
                    local_4.High = obj2;
                  if (obj2 < local_4.Low)
                    local_4.Low = obj2;
                  local_4.Close = obj2;
                  local_4.Volume += (long) obj3;
                  goto case BarType.Dynamic;
                }
              case BarType.Tick:
                BarFactory.l9JS6GiROvEy77Co1R local_6 = local_3[(object) item_0.BarSize] as BarFactory.l9JS6GiROvEy77Co1R;
                if (local_6 == null)
                {
                  local_6 = new BarFactory.l9JS6GiROvEy77Co1R();
                  local_6.zvqLhZRhjT = new Bar(BarType.Tick, item_0.BarSize, obj1, obj1, obj2, obj2, obj2, obj2, (long) obj3, 0L);
                  local_3.Add((object) item_0.BarSize, (object) local_6);
                  list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6) 0, local_6.zvqLhZRhjT));
                }
                else
                {
                  local_6.zvqLhZRhjT.EndTime = obj1;
                  if (obj2 > local_6.zvqLhZRhjT.High)
                    local_6.zvqLhZRhjT.High = obj2;
                  if (obj2 < local_6.zvqLhZRhjT.Low)
                    local_6.zvqLhZRhjT.Low = obj2;
                  local_6.zvqLhZRhjT.Close = obj2;
                  local_6.zvqLhZRhjT.Volume += (long) obj3;
                  ++local_6.VMmLV7HilK;
                }
                if (local_6.VMmLV7HilK == item_0.BarSize)
                {
                  list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6) 1, local_6.zvqLhZRhjT));
                  local_3.Remove((object) item_0.BarSize);
                  goto case BarType.Dynamic;
                }
                else
                  goto case BarType.Dynamic;
              case BarType.Volume:
                Bar local_7 = local_3[(object) item_0.BarSize] as Bar;
                if (local_7 == null)
                {
                  local_7 = new Bar(BarType.Volume, item_0.BarSize, obj1, obj1, obj2, obj2, obj2, obj2, (long) obj3, 0L);
                  local_3.Add((object) item_0.BarSize, (object) local_7);
                  list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6) 0, local_7));
                }
                else
                {
                  local_7.EndTime = obj1;
                  if (obj2 > local_7.High)
                    local_7.High = obj2;
                  if (obj2 < local_7.Low)
                    local_7.Low = obj2;
                  local_7.Close = obj2;
                  local_7.Volume += (long) obj3;
                }
                if (local_7.Volume >= item_0.BarSize)
                {
                  list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6) 1, local_7));
                  local_3.Remove((object) item_0.BarSize);
                  goto case BarType.Dynamic;
                }
                else
                  goto case BarType.Dynamic;
              case BarType.Range:
                Bar local_8 = local_3[(object) item_0.BarSize] as Bar;
                if (local_8 == null)
                {
                  Bar local_8_1 = new Bar(BarType.Range, item_0.BarSize, obj1, obj1, obj2, obj2, obj2, obj2, (long) obj3, 0L);
                  local_3.Add((object) item_0.BarSize, (object) local_8_1);
                  list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6) 0, local_8_1));
                  goto case BarType.Dynamic;
                }
                else
                {
                  local_8.EndTime = obj1;
                  if (obj2 > local_8.High)
                    local_8.High = obj2;
                  if (obj2 < local_8.Low)
                    local_8.Low = obj2;
                  local_8.Volume += (long) obj3;
                  bool local_9 = false;
                  while (!local_9)
                  {
                    if (10000.0 * (local_8.High - local_8.Low) >= (double) item_0.BarSize)
                    {
                      Bar local_10 = new Bar(BarType.Range, item_0.BarSize, obj1, obj1, obj2, obj2, obj2, obj2, 0L, 0L);
                      if (local_8.High == obj2)
                      {
                        local_8.High = local_8.Low + (double) item_0.BarSize / 10000.0;
                        local_8.Close = local_8.High;
                        local_10.Low = local_8.High;
                      }
                      if (local_8.Low == obj2)
                      {
                        local_8.Low = local_8.High - (double) item_0.BarSize / 10000.0;
                        local_8.Close = local_8.Low;
                        local_10.High = local_8.Low;
                      }
                      list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6) 1, local_8));
                      list.Add(new BarFactory.zNxuFsXhPSM7NAan2D((BarFactory.yPiBmEZIjD7IoCdXp6) 0, local_10));
                      local_3[(object) item_0.BarSize] = (object) local_10;
                      if (10000.0 * (local_10.High - local_10.Low) >= (double) item_0.BarSize)
                      {
                        local_8 = local_10;
                        local_9 = false;
                      }
                      else
                        local_9 = true;
                    }
                    else
                      local_9 = true;
                  }
                  goto case BarType.Dynamic;
                }
              case BarType.Dynamic:
                if (local_3.Count == 0)
                {
                  local_2.Remove((object) item_0.BarType);
                  if (local_2.Count == 0)
                  {
                    this.A3ELH6L4QJ.Remove((object) obj0);
                    continue;
                  }
                  else
                    continue;
                }
                else
                  continue;
              default:
                throw new NotSupportedException(GojrKtfk5NMi1fou68.a17L2Y7Wnd(1344) + ((object) item_0.BarType).ToString());
            }
          }
        }
      }
      foreach (BarFactory.zNxuFsXhPSM7NAan2D nxuFsXhPsM7Naan2D in list)
      {
        switch (nxuFsXhPsM7Naan2D.XUfLqKE3Ac)
        {
          case (BarFactory.yPiBmEZIjD7IoCdXp6) 0:
            Bar bar = nxuFsXhPsM7Naan2D.o86LP53OBW;
            this.tTOLoA7c7B(bar, obj0);
            if (bar.BarType == BarType.Time)
            {
              this.nxZL6NXVXL(bar.BeginTime.AddSeconds((double) bar.Size));
              continue;
            }
            else
              continue;
          case (BarFactory.yPiBmEZIjD7IoCdXp6) 1:
            this.LMyLmGC5QQ(nxuFsXhPsM7Naan2D.o86LP53OBW, obj0);
            continue;
          default:
            continue;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return GojrKtfk5NMi1fou68.a17L2Y7Wnd(1436);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void nxZL6NXVXL([In] DateTime obj0)
    {
      if (this.NJNLAPvWPO.Contains((object) obj0))
        return;
      Clock.AddReminder(new ReminderEventHandler(this.nAMLprxZKC), obj0, (object) null);
      this.NJNLAPvWPO.Add((object) obj0, (object) null);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LMyLmGC5QQ([In] Bar obj0, [In] IFIXInstrument obj1)
    {
      obj0.IsComplete = true;
      if (this.KEmLUcpLMO == null)
        return;
      this.KEmLUcpLMO((object) null, new BarEventArgs(obj0, obj1, (IMarketDataProvider) null));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tTOLoA7c7B([In] Bar obj0, [In] IFIXInstrument obj1)
    {
      if (this.lvHLkGUxTn == null)
        return;
      this.lvHLkGUxTn((object) null, new BarEventArgs(obj0, obj1, (IMarketDataProvider) null));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MPfLM438w2([In] long obj0)
    {
      if (this.TjfL0V3blS == null)
        return;
      this.TjfL0V3blS((object) null, new BarSliceEventArgs(obj0, (IMarketDataProvider) null));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void nAMLprxZKC([In] ReminderEventArgs obj0)
    {
      SortedList sortedList = new SortedList();
      lock (this)
      {
        foreach (DictionaryEntry item_1 in new Hashtable((IDictionary) this.A3ELH6L4QJ))
        {
          IFIXInstrument local_2 = (IFIXInstrument) item_1.Key;
          Hashtable local_3 = (Hashtable) item_1.Value;
          SortedList local_4 = local_3[(object) BarType.Time] as SortedList;
          if (local_4 != null)
          {
            foreach (DictionaryEntry item_0 in new SortedList((IDictionary) local_4))
            {
              long local_6 = (long) item_0.Key;
              Bar local_7 = (Bar) item_0.Value;
              if (local_7.BeginTime.AddSeconds((double) local_6) == obj0.SignalTime)
              {
                local_7.EndTime = obj0.SignalTime;
                ArrayList local_8 = sortedList[(object) local_6] as ArrayList;
                if (local_8 == null)
                {
                  local_8 = new ArrayList();
                  sortedList.Add((object) local_6, (object) local_8);
                }
                local_8.Add((object) new KeyValuePair<IFIXInstrument, Bar>(local_2, local_7));
                local_4.Remove((object) local_6);
              }
            }
            if (local_4.Count == 0)
              local_3.Remove((object) BarType.Time);
            if (local_3.Count == 0)
              this.A3ELH6L4QJ.Remove((object) local_2);
          }
        }
      }
      foreach (DictionaryEntry dictionaryEntry in sortedList)
      {
        long num = (long) dictionaryEntry.Key;
        foreach (KeyValuePair<IFIXInstrument, Bar> keyValuePair in (ArrayList) dictionaryEntry.Value)
          this.LMyLmGC5QQ(keyValuePair.Value, keyValuePair.Key);
        this.MPfLM438w2(num);
      }
      this.NJNLAPvWPO.Remove((object) obj0.SignalTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DateTime qJpLNA6Aiq([In] DateTime obj0, [In] long obj1)
    {
      long num = (long) obj0.TimeOfDay.TotalSeconds / obj1 * obj1;
      return obj0.Date.AddSeconds((double) num);
    }

    private class l9JS6GiROvEy77Co1R
    {
      public Bar zvqLhZRhjT;
      public long VMmLV7HilK;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public l9JS6GiROvEy77Co1R()
      {
        Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
        this.VMmLV7HilK = 1L;
        // ISSUE: explicit constructor call
        base.\u002Ector();
      }
    }

    private class mU5OEr88NSmCpsBxeD
    {
      public double m8FLQ7V52X;
      public int MpnLJAJ41c;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public mU5OEr88NSmCpsBxeD()
      {
        Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
        // ISSUE: explicit constructor call
        base.\u002Ector();
      }
    }

    private enum yPiBmEZIjD7IoCdXp6
    {
    }

    private class zNxuFsXhPSM7NAan2D
    {
      public BarFactory.yPiBmEZIjD7IoCdXp6 XUfLqKE3Ac;
      public Bar o86LP53OBW;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public zNxuFsXhPSM7NAan2D([In] BarFactory.yPiBmEZIjD7IoCdXp6 obj0, [In] Bar obj1)
      {
        Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.XUfLqKE3Ac = obj0;
        this.o86LP53OBW = obj1;
      }
    }
  }
}
