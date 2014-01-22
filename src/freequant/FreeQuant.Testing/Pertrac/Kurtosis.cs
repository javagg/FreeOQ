using FreeQuant.Business;
using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class Kurtosis : SeriesTesterItem
  {
    protected double mean;
    protected double n;

   
    public Kurtosis(string name, SeriesTesterItem parentSeriesItem)
			:      base(name, parentSeriesItem,  parentSeriesItem.Series.Title)
		{
    }

		public Kurtosis(string name) : base(name)
    {

    }

   
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index1 = firstIndex; index1 <= lastIndex; ++index1)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index1)))
        {
          this.mean = (this.mean * this.n + this.parentSeries[index1]) / ++this.n;
          double num1 = 0.0;
          double num2 = 0.0;
          for (int index2 = 0; index2 <= index1; ++index2)
          {
            if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)))
            {
              num1 += Math.Pow(this.parentSeries[index2] - this.mean, 2.0);
              num2 += Math.Pow(this.parentSeries[index2] - this.mean, 4.0);
            }
          }
          double x = Math.Sqrt(num1 / (this.n - 1.0));
          this.series.Add(this.parentSeries.GetDateTime(index1), this.n * (this.n - 1.0) / ((this.n - 1.0) * (this.n - 2.0) * (this.n - 3.0)) * num2 / Math.Pow(x, 4.0) - 3.0 * (this.n - 1.0) * (this.n - 1.0) / ((this.n - 2.0) * (this.n - 3.0)));
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
      double num5 = 0.0;
      double num6 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)))
        {
          num5 += Math.Pow(this.parentSeries[index2] - num3, 2.0);
          num6 += Math.Pow(this.parentSeries[index2] - num3, 4.0);
          ++num4;
        }
      }
      double x = Math.Sqrt(num5 / (num4 - 1.0));
      if (num4 > 3.0)
        return num4 * (num4 + 1.0) / ((num4 - 1.0) * (num4 - 2.0) * (num4 - 3.0)) * num6 / Math.Pow(x, 4.0) - 3.0 * (num4 - 1.0) * (num4 - 1.0) / ((num4 - 2.0) * (num4 - 3.0));
      else
        return double.NaN;
    }

   
    public override void Reset()
    {
      this.mean = 0.0;
      this.n = 0.0;
      base.Reset();
    }
  }
}
