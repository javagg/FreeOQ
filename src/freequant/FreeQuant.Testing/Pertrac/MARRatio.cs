// Type: SmartQuant.Testing.Pertrac.MARRatio
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Pertrac
{
  public class MARRatio : SeriesTesterItem
  {
    protected SeriesTesterItem maxDrawDown;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MARRatio(string name, SeriesTesterItem parentSeriesItem, SeriesTesterItem maxDrawDownSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, name + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2844) + parentSeriesItem.Series.Title);
      this.maxDrawDown = maxDrawDownSeriesItem;
      this.maxDrawDown.FillSeries = true;
      this.parentList.Add((object) this.maxDrawDown);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MARRatio(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      double num1 = double.NaN;
      int index1 = this.parentSeries.GetIndex(date);
      if (this.maxDrawDown.Series.Count == 0 || date < this.maxDrawDown.Series.FirstDateTime)
        return num1;
      double num2 = 1.0;
      int num3 = 0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (this.parentSeries[index2] != 0.0)
        {
          num2 *= this.parentSeries[index2];
          ++num3;
        }
      }
      return Math.Pow(Math.Abs(num2), 1.0 / (double) num3) / -this.maxDrawDown.Series[date, EIndexOption.Prev];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset()
    {
      base.Reset();
    }
  }
}
