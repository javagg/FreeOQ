using FreeQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.TesterItems
{
  public class SimpleAnnualSeries : SeriesTesterItem
  {
    
    public SimpleAnnualSeries(string name, SeriesTesterItem parentSeriesItem)
			: base(name, parentSeriesItem, parentSeriesItem.Series.Title)   {
     }

    
		public SimpleAnnualSeries(string name) :  base(name)
    {
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(firstIndex);
      DateTime dateTime2 = this.parentSeries.GetDateTime(lastIndex);
      for (DateTime DateTime = new DateTime(dateTime1.Year, 1, 1); DateTime <= dateTime2; DateTime = DateTime.AddYears(1))
        this.series.Add(DateTime, this.parentSeries[DateTime.AddYears(1).AddTicks(-1L), EIndexOption.Prev]);
    }

    
    protected override double GetValue(DateTime date)
    {
      return this.parentSeries[new DateTime(date.Year, 1, 1).AddYears(1), EIndexOption.Prev];
    }
  }
}
