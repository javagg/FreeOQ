using FreeQuant.Business;
using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class StandardDeviation : SeriesTesterItem
  {
    protected double mean;
    protected double n;
    private double wQjy5WcoBc;

    
    public StandardDeviation(string name, SeriesTesterItem parentSeriesItem)
			:      base(name, parentSeriesItem,  parentSeriesItem.Series.Title) {
      this.FillSeries = true;
    }

    
		public StandardDeviation(string name) : base(name)
    {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index)))
        {
          double num1 = this.mean;
          double num2 = (this.mean * this.n + this.parentSeries[index]) / (this.n + 1.0);
          double num3 = this.parentSeries[index];
          this.wQjy5WcoBc = this.series.Count != 0 ? this.wQjy5WcoBc + (num3 - num2) * (num3 - num2) + this.n * (num2 * num2 - num1 * num1 - 2.0 * (num2 - num1) * num1) : 0.0;
          ++this.n;
          this.mean = num2;
          this.series.Add(this.parentSeries.GetDateTime(index), Math.Sqrt(this.wQjy5WcoBc / (this.n - 1.0)));
        }
      }
    }

    
    protected override double GetValue(DateTime date)
    {
      int index1 = this.parentSeries.GetIndex(date);
      double num1 = 0.0;
      double num2 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)))
        {
          num1 += this.parentSeries[index2];
          ++num2;
        }
      }
      double num3 = num1 / num2;
      double num4 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)))
          num4 += (this.parentSeries[index2] - num3) * (this.parentSeries[index2] - num3);
      }
      return Math.Sqrt(num4 / (num2 - 1.0));
    }

    
    public override void Reset()
    {
      this.mean = 0.0;
      this.n = 0.0;
      this.wQjy5WcoBc = 0.0;
      base.Reset();
    }
  }
}
