// Type: SmartQuant.Testing.MathStatistics.Division
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.MathStatistics
{
  public class Division : SeriesTesterItem
  {
    private SeriesTesterItem Q6TKkEvoQ;
    private SeriesTesterItem BMbVKSFYY;
    private double KVogOByx1;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Division(string name, SeriesTesterItem numeratorSeriesItem, SeriesTesterItem denominatorSeriesItem, SeriesTesterItem signalSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, numeratorSeriesItem, denominatorSeriesItem, signalSeriesItem, 1.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Division(string name, SeriesTesterItem numeratorSeriesItem, SeriesTesterItem denominatorSeriesItem, SeriesTesterItem signalSeriesItem, double multiplier)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, signalSeriesItem, name);
      this.Q6TKkEvoQ = numeratorSeriesItem;
      this.BMbVKSFYY = denominatorSeriesItem;
      this.parentList.Add((object) numeratorSeriesItem);
      this.parentList.Add((object) denominatorSeriesItem);
      this.KVogOByx1 = multiplier;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
