using FreeQuant.Business;
using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class LossStandardDeviation : SeriesTesterItem
  {
    protected double mean;
    protected double n;

    
    public LossStandardDeviation(string name, SeriesTesterItem parentSeriesItem)
			:      base(name, parentSeriesItem,  parentSeriesItem.Series.Title) {

		    }

    
		public LossStandardDeviation(string name) : base(name)
    {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index1 = firstIndex; index1 <= lastIndex; ++index1)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index1)) && this.parentSeries[index1] < 0.0)
        {
          this.mean = (this.mean * this.n + this.parentSeries[index1]) / ++this.n;
          double num = 0.0;
          for (int index2 = 0; index2 <= index1; ++index2)
          {
            if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)) && this.parentSeries[index2] < 0.0)
              num += (this.parentSeries[index2] - this.mean) * (this.parentSeries[index2] - this.mean);
          }
          this.series.Add(this.parentSeries.GetDateTime(index1), Math.Sqrt(num / (this.n - 1.0)));
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
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)) && this.parentSeries[index2] < 0.0)
        {
          num1 += this.parentSeries[index2];
          ++num2;
        }
      }
      double num3 = num1 / num2;
      double num4 = 0.0;
      double num5 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)) && this.parentSeries[index2] < 0.0)
        {
          num5 += (this.parentSeries[index2] - num3) * (this.parentSeries[index2] - num3);
          ++num4;
        }
      }
      return Math.Sqrt(num5 / (num4 - 1.0));
    }

    
    public override void Reset()
    {
      this.mean = 0.0;
      this.n = 0.0;
      base.Reset();
    }
  }
}
