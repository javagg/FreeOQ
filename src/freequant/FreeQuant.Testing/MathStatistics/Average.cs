// Type: SmartQuant.Testing.MathStatistics.Average
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.MathStatistics
{
  public class Average : SeriesTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Average(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, name + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2520) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Average(string name)
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
      DateTime dateTime1 = this.parentSeries.GetDateTime(lastIndex);
      if (this.series.Contains(dateTime1))
      {
        if (this.series.Count == 1)
          this.series.Add(dateTime1, this.parentSeries[dateTime1]);
        else
          this.series.Add(dateTime1, (this.series[this.series.Count - 2] * (double) (this.series.Count - 1) + this.parentSeries[dateTime1]) / (double) this.series.Count);
      }
      else
      {
        for (int index = firstIndex; index <= lastIndex; ++index)
        {
          DateTime dateTime2 = this.parentSeries.GetDateTime(index);
          if (this.series.Count == 0)
            this.series.Add(dateTime2, this.parentSeries[dateTime2]);
          else
            this.series.Add(dateTime2, ((double) this.series.Count * this.series.Last + this.parentSeries[dateTime2]) / (double) (this.series.Count + 1));
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      double num1 = 0.0;
      int index1 = this.parentSeries.GetIndex(date);
      int num2 = 0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        this.parentSeries.GetDateTime(index2);
        num1 += this.parentSeries[index2];
        ++num2;
      }
      return num1 / (double) num2;
    }
  }
}
