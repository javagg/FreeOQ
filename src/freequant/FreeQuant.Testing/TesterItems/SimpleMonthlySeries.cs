// Type: SmartQuant.Testing.TesterItems.SimpleMonthlySeries
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Series;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.TesterItems
{
  public class SimpleMonthlySeries : SeriesTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleMonthlySeries(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2460) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleMonthlySeries(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      if (firstIndex > lastIndex)
        return;
      DateTime dateTime1 = this.parentSeries.GetDateTime(firstIndex);
      DateTime dateTime2 = this.parentSeries.GetDateTime(lastIndex);
      for (DateTime DateTime = new DateTime(dateTime1.Year, dateTime1.Month, 1); DateTime <= dateTime2; DateTime = DateTime.AddMonths(1))
        this.series.Add(DateTime, this.parentSeries[DateTime.AddMonths(1).AddTicks(-1L), EIndexOption.Prev]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      return this.parentSeries[new DateTime(date.Year, date.Month, 1).AddMonths(1), EIndexOption.Prev];
    }
  }
}
