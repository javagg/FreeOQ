// Type: SmartQuant.Testing.Pertrac.SotrinoRatio
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.TesterItems;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Pertrac
{
  public class SotrinoRatio : SeriesTesterItem
  {
    protected double riskFreeRate;

    [Category("Parameters")]
    public double RiskFreeRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.riskFreeRate;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.riskFreeRate = value;
        this.EmitPropertyChanged();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SotrinoRatio(string name, SeriesTesterItem parentSeriesItem, double riskFreeRate)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2628) + parentSeriesItem.Series.Title);
      this.riskFreeRate = riskFreeRate;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SotrinoRatio(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
