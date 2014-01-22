using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class GainDays : SeriesTesterItem
  {
    
		public GainDays(string name, SeriesTesterItem parentSeriesItem):  base(name, parentSeriesItem, parentSeriesItem.Series.Title)

    {
    }

    
		public GainDays(string name):base(name)
    {
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        DateTime dateTime = this.parentSeries.GetDateTime(index);
        if (this.series.Count == 0)
        {
          if (this.parentSeries[dateTime] > 0.0)
            this.series.Add(dateTime, 1.0);
          else
            this.series.Add(dateTime, 0.0);
        }
        else if (this.parentSeries[dateTime] > 0.0)
          this.series.Add(dateTime, this.series.Last + 1.0);
        else
          this.series.Add(dateTime, this.series.Last);
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      double num = 0.0;
      int index1 = this.parentSeries.GetIndex(date);
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (this.parentSeries[index2] > 0.0)
          ++num;
      }
      return num;
    }

    
    public override string ValueToSrting()
    {
      return ((int) this.LastValue).ToString();
    }
  }
}
