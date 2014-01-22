using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class CompoundAverageReturn : SeriesTesterItem
  {
    
    public CompoundAverageReturn(string name, SeriesTesterItem parentSeriesItem)
			:     base(name, parentSeriesItem, name + parentSeriesItem.Series.Title)
		{
    }

    
		public CompoundAverageReturn(string name):     base(name)
    {
    }

    
    protected override double GetValue(DateTime date)
    {
      double num1 = 1.0;
      int index1 = this.parentSeries.GetIndex(date);
      int num2 = 0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (this.parentSeries[index2] != 0.0)
        {
          num1 *= this.parentSeries[index2];
          ++num2;
        }
      }
      return Math.Pow(Math.Abs(num1), 1.0 / (double) num2);
    }

    
    public override void Reset()
    {
      base.Reset();
    }
  }
}
