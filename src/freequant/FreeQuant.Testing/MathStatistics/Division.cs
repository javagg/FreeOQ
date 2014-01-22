using FreeQuant.Series;
using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.MathStatistics
{
  public class Division : SeriesTesterItem
  {
    private SeriesTesterItem Q6TKkEvoQ;
    private SeriesTesterItem BMbVKSFYY;
    private double KVogOByx1;

    
    public Division(string name, SeriesTesterItem numeratorSeriesItem, SeriesTesterItem denominatorSeriesItem, SeriesTesterItem signalSeriesItem)
			:this(name, numeratorSeriesItem, denominatorSeriesItem, signalSeriesItem, 1.0) {
    }

    
    public Division(string name, SeriesTesterItem numeratorSeriesItem, SeriesTesterItem denominatorSeriesItem, SeriesTesterItem signalSeriesItem, double multiplier)
			: base(name, signalSeriesItem, name) {
      this.Q6TKkEvoQ = numeratorSeriesItem;
      this.BMbVKSFYY = denominatorSeriesItem;
      this.parentList.Add((object) numeratorSeriesItem);
      this.parentList.Add((object) denominatorSeriesItem);
      this.KVogOByx1 = multiplier;
    }

    
    protected override double GetValue(DateTime date)
    {
      double num1 = double.NaN;
      if (this.Q6TKkEvoQ.Series.Count <= 0 || this.BMbVKSFYY.Series.Count <= 0)
        return this.Q6TKkEvoQ.LastValue / this.BMbVKSFYY.LastValue;
      if (this.Q6TKkEvoQ.Series.FirstDateTime <= date && this.BMbVKSFYY.Series.FirstDateTime <= date)
      {
        double num2 = this.Q6TKkEvoQ.Series[date, EIndexOption.Prev];
        double num3 = this.BMbVKSFYY.Series[date, EIndexOption.Prev];
        if (num3 != 0.0)
          num1 = num2 / num3;
      }
      return num1 * this.KVogOByx1;
    }
  }
}
