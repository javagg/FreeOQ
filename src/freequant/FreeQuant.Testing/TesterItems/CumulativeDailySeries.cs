using FreeQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.TesterItems
{
  public class CumulativeDailySeries : SeriesTesterItem
  {
    
    public CumulativeDailySeries(string name, SeriesTesterItem parentSeriesItem)
			: base(name, parentSeriesItem, parentSeriesItem.Series.Title)  {
     }

    
		public CumulativeDailySeries(string name):   base(name)
    {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      double Data = 0.0;
      DateTime dateTime = this.parentSeries.GetDateTime(firstIndex);
      DateTime index1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      if (this.series.Contains(index1))
        Data = this.series[index1];
      for (int index2 = firstIndex; index2 <= lastIndex; ++index2)
      {
        dateTime = this.parentSeries.GetDateTime(index2);
        if (dateTime > index1.AddDays(1.0).AddTicks(-1L))
        {
          index1 = index1.AddDays(1.0);
          Data = 0.0;
        }
        Data += this.parentSeries[dateTime];
        this.series.Add(index1, Data);
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      double num = 0.0;
      DateTime dateTime1 = new DateTime(date.Year, date.Month, date.Day);
      DateTime dateTime2 = new DateTime(date.Year, date.Month, date.Day).AddDays(1.0).AddTicks(-1L);
      int index1 = this.parentSeries.GetIndex(dateTime1, EIndexOption.Next);
      int index2 = this.parentSeries.GetIndex(dateTime2, EIndexOption.Prev);
      for (int index3 = index1; index3 <= index2; ++index3)
        num += this.parentSeries[index3];
      return num;
    }
  }
}
