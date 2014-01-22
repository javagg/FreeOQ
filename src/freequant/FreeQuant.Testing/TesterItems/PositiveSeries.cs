using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.TesterItems
{
  public class PositiveSeries : SeriesTesterItem
  {
    
    public PositiveSeries(string name, SeriesTesterItem parentSeriesItem)
			: base(name, parentSeriesItem, parentSeriesItem.Series.Title)    {
     }

    
		public PositiveSeries(string name) : base(name)
    {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        if (this.parentSeries[index] > 0.0)
          this.series.Add(this.parentSeries.GetDateTime(index), this.parentSeries[index]);
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      double d = double.NaN;
      for (int index = this.parentSeries.GetIndex(date); double.IsNaN(d) && index > -1; --index)
      {
        if (this.parentSeries[index] > 0.0)
          d = this.parentSeries[index];
      }
      return d;
    }
  }
}
