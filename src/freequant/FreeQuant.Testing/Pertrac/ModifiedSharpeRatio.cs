// Type: SmartQuant.Testing.Pertrac.ModifiedSharpeRatio
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Pertrac
{
  public class ModifiedSharpeRatio : SeriesTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModifiedSharpeRatio(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2198) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModifiedSharpeRatio(string name)
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
