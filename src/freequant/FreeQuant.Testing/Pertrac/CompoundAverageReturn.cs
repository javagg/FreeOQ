// Type: SmartQuant.Testing.Pertrac.CompoundAverageReturn
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
  public class CompoundAverageReturn : SeriesTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompoundAverageReturn(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, name + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2156) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompoundAverageReturn(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset()
    {
      base.Reset();
    }
  }
}
