using FreeQuant.Business;
using FreeQuant.Testing.TesterItems;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class SharpeRatio : SeriesTesterItem
  {
    protected double riskFreeRate;

    [Category("Parameters")]
    public double RiskFreeRate
    {
       get
      {
        return this.riskFreeRate;
      }
       set
      {
        this.riskFreeRate = value;
        this.EmitPropertyChanged();
      }
    }

    
    public SharpeRatio(string name, SeriesTesterItem parentSeriesItem, double riskFreeRate)
			:      base(name, parentSeriesItem,  parentSeriesItem.Series.Title)
		{
       this.riskFreeRate = riskFreeRate;
    }

    
		public SharpeRatio(string name) : base(name)
    {

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
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)))
        {
          num5 += (this.parentSeries[index2] - num3) * (this.parentSeries[index2] - num3);
          ++num4;
        }
      }
      double num6 = Math.Sqrt(num5 / (num4 - 1.0));
      return (num3 - (Math.Pow(this.riskFreeRate / 100.0 + 1.0, 0.004) - 1.0) * 100.0) / num6;
    }
  }
}
