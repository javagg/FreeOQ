using FreeQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.TesterItems
{
  public class SimpleMonthlySeries : SeriesTesterItem
  {
    
    public SimpleMonthlySeries(string name, SeriesTesterItem parentSeriesItem)
			: base(name, parentSeriesItem, parentSeriesItem.Series.Title)   {
     }

    
		public SimpleMonthlySeries(string name):  base(name)
    {
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(firstIndex);
      DateTime dateTime2 = this.parentSeries.GetDateTime(lastIndex);
      for (DateTime DateTime = new DateTime(dateTime1.Year, dateTime1.Month, 1); DateTime <= dateTime2; DateTime = DateTime.AddMonths(1))
        this.series.Add(DateTime, this.parentSeries[DateTime.AddMonths(1).AddTicks(-1L), EIndexOption.Prev]);
    }

    
    protected override double GetValue(DateTime date)
    {
      return this.parentSeries[new DateTime(date.Year, date.Month, 1).AddMonths(1), EIndexOption.Prev];
    }
  }
}
