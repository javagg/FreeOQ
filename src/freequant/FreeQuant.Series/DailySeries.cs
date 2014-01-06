// Type: SmartQuant.Series.DailySeries
// Assembly: SmartQuant.Series, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: E9488B3A-52DD-4064-9514-4FAD9D0B10AA
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Series.dll

using mXqpVnllGuXP6crdfN;
using NEVPmg8vBnJoRISXwf;
using SmartQuant.Data;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Series
{
  [Serializable]
  public class DailySeries : BarSeries
  {
    public Daily First
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fArray.Count <= 0)
          throw new ApplicationException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13400));
        else
          return this[0];
      }
    }

    public Daily Last
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fArray.Count <= 0)
          return (Daily) null;
        else
          return this[this.Count - 1];
      }
    }

    public Daily this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (Daily) base[index];
      }
    }

    public Daily this[DateTime date]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (Daily) base[date];
      }
    }

    public Daily this[DateTime date, EIndexOption option]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return ((TimeSeries) this)[date, option] as Daily;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries(string name, string title)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, title);
      this.fArray = (IDataSeries) new MemorySeries<Daily>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries(string name)
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries()
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      this.\u002Ector("");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries Clone()
    {
      return base.Clone() as DailySeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries Clone(int index1, int index2)
    {
      return base.Clone(index1, index2) as DailySeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries Clone(DateTime dateTime1, DateTime dateTime2)
    {
      return base.Clone(dateTime1, dateTime2) as DailySeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailySeries Shift(int offset)
    {
      DailySeries dailySeries = new DailySeries(this.Name, this.Title);
      int num = 0;
      if (offset < 0)
        num += Math.Abs(offset);
      for (int index1 = num; index1 < this.Count; ++index1)
      {
        int index2 = index1 + offset;
        if (index2 < this.Count)
        {
          DateTime dateTime = this.GetDateTime(index2);
          dailySeries.Add(new Bar((Bar) this[index1])
          {
            DateTime = dateTime
          });
        }
        else
          break;
      }
      return dailySeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Daily Ago(int n)
    {
      int index = this.Count - 1 - n;
      if (index < 0)
        throw new ArgumentException(oK6F3TB73XXXGhdieP.wF6SgrNUO(13446) + (object) n + oK6F3TB73XXXGhdieP.wF6SgrNUO(13492));
      else
        return this[index];
    }
  }
}
