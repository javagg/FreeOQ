using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.MathStatistics
{
  public class Maximum : SeriesTesterItem
  {
    private double Vn2ymVwktw;

    
		public Maximum(string name, SeriesTesterItem parentSeriesItem)  :  base(name, parentSeriesItem, name + parentSeriesItem.Series.Title)

    {
      this.Vn2ymVwktw = double.MinValue;
    }

    
		public Maximum(string name): base(name)
    {
      this.Vn2ymVwktw = double.MinValue;
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(lastIndex);
      if (this.series.Contains(dateTime1))
      {
        this.Vn2ymVwktw = this.series.Count != 1 ? Math.Max(this.parentSeries[dateTime1], this.series[this.series.Count - 2]) : this.parentSeries[dateTime1];
        this.series.Add(dateTime1, this.Vn2ymVwktw);
      }
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        DateTime dateTime2 = this.parentSeries.GetDateTime(index);
        this.Vn2ymVwktw = Math.Max(this.parentSeries[dateTime2], this.Vn2ymVwktw);
        this.series.Add(dateTime2, this.Vn2ymVwktw);
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      double val2 = double.MinValue;
      int index1 = this.parentSeries.GetIndex(date);
      for (int index2 = 0; index2 <= index1; ++index2)
        val2 = Math.Max(this.parentSeries[index2], val2);
      return val2;
    }

    
    public override void Reset()
    {
      this.Vn2ymVwktw = double.MinValue;
      base.Reset();
    }
  }
}
