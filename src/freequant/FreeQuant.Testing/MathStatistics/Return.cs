using FreeQuant.Series;
using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.MathStatistics
{
  public class Return : SeriesTesterItem
  {
    
    public Return(string name, SeriesTesterItem parentSeriesItem)
			:     base(name, parentSeriesItem, parentSeriesItem.Series.Title)
		 {
    }

    
		public Return(string name):   base(name)
    {
    }

    
    protected override double GetValue(DateTime date)
    {
      int index = this.parentSeries.GetIndex(date, EIndexOption.Prev);
      if (index > 0)
        return (this.parentSeries[index] / this.parentSeries[index - 1] - 1.0) * 100.0;
      else
        return 0.0;
    }

    
    public override void Reset()
    {
      base.Reset();
    }
  }
}
