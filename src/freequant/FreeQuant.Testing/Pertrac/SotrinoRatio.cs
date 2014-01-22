using FreeQuant.Testing.TesterItems;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class SotrinoRatio : SeriesTesterItem
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

    
    public SotrinoRatio(string name, SeriesTesterItem parentSeriesItem, double riskFreeRate)
			:      base(name, parentSeriesItem,  parentSeriesItem.Series.Title)
		 {
      this.riskFreeRate = riskFreeRate;
    }

    
		public SotrinoRatio(string name) : base(name)
    {

    }

    
    protected override double GetValue(DateTime date)
    {
      int index1 = this.parentSeries.GetIndex(date);
      double num1 = 0.0;
      double num2 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (this.parentSeries[index2] < 0.0)
        {
          num1 += this.parentSeries[index2];
          ++num2;
        }
      }
      double num3 = num1 / num2;
      double num4 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (this.parentSeries[index2] < 0.0)
          num4 += (this.parentSeries[index2] - num3) * (this.parentSeries[index2] - num3);
      }
      double num5 = Math.Sqrt(num4 / (num2 - 1.0));
      return (num3 - (Math.Pow(this.riskFreeRate / 100.0 + 1.0, 0.004) - 1.0) * 100.0) / num5;
    }
  }
}
