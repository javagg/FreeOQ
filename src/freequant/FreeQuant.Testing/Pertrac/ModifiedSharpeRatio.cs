using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class ModifiedSharpeRatio : SeriesTesterItem
  {
    
    public ModifiedSharpeRatio(string name, SeriesTesterItem parentSeriesItem)
			:      base(name, parentSeriesItem,  parentSeriesItem.Series.Title)  {
     }

    
		public ModifiedSharpeRatio(string name) : base(name)
    {

    }

    
    protected override double GetValue(DateTime date)
    {
      int index1 = this.parentSeries.GetIndex(date);
      double num1 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
        num1 += this.parentSeries[index2];
      double num2 = num1 / (double) (index1 + 1);
      double num3 = 0.0;
      for (int index2 = 0; index2 < this.parentSeries.Count; ++index2)
        num3 += (this.parentSeries[index2] - num2) * (this.parentSeries[index2] - num2);
      double x = Math.Sqrt(num3 / (double) index1);
      return 12.0 * num2 / Math.Pow(x, 0.0);
    }
  }
}
