using FreeQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.TesterItems
{
  public class SimpleDailySeries : SeriesTesterItem
  {
    
    public SimpleDailySeries(string name, SeriesTesterItem parentSeriesItem)
			: base(name, parentSeriesItem, parentSeriesItem.Series.Title) {
   }

    
		public SimpleDailySeries(string name):  base(name)
    {
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(firstIndex);
      DateTime dateTime2 = this.parentSeries.GetDateTime(lastIndex);
      for (DateTime DateTime = new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day); DateTime <= dateTime2; DateTime = DateTime.AddDays(1.0))
        this.series.Add(DateTime, this.parentSeries[DateTime.AddDays(1.0).AddTicks(-1L), EIndexOption.Prev]);
    }

    
    protected override double GetValue(DateTime date)
    {
      return this.parentSeries[new DateTime(date.Year, date.Month, date.Day).AddDays(1.0), EIndexOption.Prev];
    }
  }
}
