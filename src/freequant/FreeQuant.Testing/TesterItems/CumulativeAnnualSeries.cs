// Type: SmartQuant.Testing.TesterItems.CumulativeAnnualSeries
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
  public class CumulativeAnnualSeries : SeriesTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CumulativeAnnualSeries(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2176) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CumulativeAnnualSeries(string name)
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
      double Data = 0.0;
      DateTime index1 = new DateTime(this.parentSeries.GetDateTime(firstIndex).Year, 1, 1);
      if (this.series.Contains(index1))
        Data = this.series[index1];
      for (int index2 = firstIndex; index2 <= lastIndex; ++index2)
      {
        DateTime dateTime = this.parentSeries.GetDateTime(index2);
        if (dateTime > index1.AddYears(1).AddTicks(-2L))
        {
          index1 = index1.AddYears(1);
          Data = 0.0;
        }
        Data += this.parentSeries[dateTime];
        this.series.Add(index1, Data);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      double num = 0.0;
      DateTime dateTime1 = new DateTime(date.Year, 1, 1);
      DateTime dateTime2 = new DateTime(date.Year, 1, 1).AddYears(1);
      int index1 = this.parentSeries.GetIndex(dateTime1, EIndexOption.Next);
      int index2 = this.parentSeries.GetIndex(dateTime2, EIndexOption.Prev);
      for (int index3 = index1; index3 <= index2; ++index3)
        num += this.parentSeries[index3];
      return num;
    }
  }
}
