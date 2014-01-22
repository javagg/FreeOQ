using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.MathStatistics
{
  public class Minimum : SeriesTesterItem
  {
    private double h7MhwLxuw;

    
    public Minimum(string name, SeriesTesterItem parentSeriesItem)
			:      base(name, parentSeriesItem, name + parentSeriesItem.Series.Title)
		 {
      this.h7MhwLxuw = double.MaxValue;
    }

    
		public Minimum(string name):  base(name)
    {
      this.h7MhwLxuw = double.MaxValue;
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(lastIndex);
      if (this.series.Contains(dateTime1))
      {
        this.h7MhwLxuw = this.series.Count != 1 ? Math.Min(this.parentSeries[dateTime1], this.series[this.series.Count - 2]) : this.parentSeries[dateTime1];
        this.series.Add(dateTime1, this.h7MhwLxuw);
      }
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        DateTime dateTime2 = this.parentSeries.GetDateTime(index);
        this.h7MhwLxuw = Math.Min(this.parentSeries[dateTime2], this.h7MhwLxuw);
        this.series.Add(dateTime2, this.h7MhwLxuw);
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      double val2 = double.MaxValue;
      int index1 = this.parentSeries.GetIndex(date);
      for (int index2 = 0; index2 <= index1; ++index2)
        val2 = Math.Min(this.parentSeries[index2], val2);
      return val2;
    }

    
    public override void Reset()
    {
      this.h7MhwLxuw = double.MaxValue;
      base.Reset();
    }
  }
}
