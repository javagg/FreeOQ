using FreeQuant.Data;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Series
{
  [Serializable]
  public class DailySeries : BarSeries
  {
    public Daily First
    {
       get
      {
          return this[0];
      }
    }

    public Daily Last
    {
       get
      {
          return this[this.Count - 1];
      }
    }

    public Daily this[int index]
    {
       get
      {
        return (Daily) base[index];
      }
    }

    public Daily this[DateTime date]
    {
       get
      {
        return (Daily) base[date];
      }
    }

    public Daily this[DateTime date, EIndexOption option]
    {
       get
      {
        return ((TimeSeries) this)[date, option] as Daily;
      }
    }

    
		public DailySeries(string name, string title): base(name, title)
    {
      this.fArray = (IDataSeries) new MemorySeries<Daily>();
    }

    
		public DailySeries(string name): base(name, "")
    {

    }

    
		public DailySeries():base("")
    {
    }

    
    public DailySeries Clone()
    {
      return base.Clone() as DailySeries;
    }

    
    public DailySeries Clone(int index1, int index2)
    {
      return base.Clone(index1, index2) as DailySeries;
    }

    
    public DailySeries Clone(DateTime dateTime1, DateTime dateTime2)
    {
      return base.Clone(dateTime1, dateTime2) as DailySeries;
    }

    
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

    
    public Daily Ago(int n)
    {
      int index = this.Count - 1 - n;
      return this[index];
    }
  }
}
