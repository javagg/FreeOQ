using FreeQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.TesterItems
{
  public class CumulativeMonthlySeries : SeriesTesterItem
  {
    
    public CumulativeMonthlySeries(string name, SeriesTesterItem parentSeriesItem)
			: base(name, parentSeriesItem, parentSeriesItem.Series.Title)  {
    }

    
		public CumulativeMonthlySeries(string name) : base(name)
    {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      double Data = 0.0;
      DateTime dateTime1 = this.parentSeries.GetDateTime(firstIndex);
      DateTime index1 = new DateTime(dateTime1.Year, dateTime1.Month, 1);
      if (this.series.Contains(index1))
        Data = this.series[index1];
      for (int index2 = firstIndex; index2 <= lastIndex; ++index2)
      {
        DateTime dateTime2 = this.parentSeries.GetDateTime(index2);
        if (dateTime2 > index1.AddMonths(1).AddTicks(-1L))
        {
          index1 = index1.AddMonths(1);
          Data = 0.0;
        }
        Data += this.parentSeries[dateTime2];
        this.series.Add(index1, Data);
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      double num = 0.0;
      DateTime dateTime1 = new DateTime(date.Year, date.Month, 1);
      DateTime dateTime2 = new DateTime(date.Year, date.Month, 1).AddMonths(1).AddTicks(-1L);
      int index1 = this.parentSeries.GetIndex(dateTime1, EIndexOption.Next);
      int index2 = this.parentSeries.GetIndex(dateTime2, EIndexOption.Prev);
      for (int index3 = index1; index3 <= index2; ++index3)
        num += this.parentSeries[index3];
      return num;
    }
  }
}
