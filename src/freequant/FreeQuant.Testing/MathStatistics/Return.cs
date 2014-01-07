using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using FreeQuant.Series;
using FreeQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.MathStatistics
{
  public class Return : SeriesTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Return(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2134) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Return(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      int index = this.parentSeries.GetIndex(date, EIndexOption.Prev);
      if (index > 0)
        return (this.parentSeries[index] / this.parentSeries[index - 1] - 1.0) * 100.0;
      else
        return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset()
    {
      base.Reset();
    }
  }
}
