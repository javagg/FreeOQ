// Type: SmartQuant.Testing.Pertrac.LossStandardDeviation
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Pertrac
{
  public class LossStandardDeviation : SeriesTesterItem
  {
    protected double mean;
    protected double n;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LossStandardDeviation(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2530) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LossStandardDeviation(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index1 = firstIndex; index1 <= lastIndex; ++index1)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index1)) && this.parentSeries[index1] < 0.0)
        {
          this.mean = (this.mean * this.n + this.parentSeries[index1]) / ++this.n;
          double num = 0.0;
          for (int index2 = 0; index2 <= index1; ++index2)
          {
            if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)) && this.parentSeries[index2] < 0.0)
              num += (this.parentSeries[index2] - this.mean) * (this.parentSeries[index2] - this.mean);
          }
          this.series.Add(this.parentSeries.GetDateTime(index1), Math.Sqrt(num / (this.n - 1.0)));
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      int index1 = this.parentSeries.GetIndex(date);
      double num1 = 0.0;
      double num2 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)) && this.parentSeries[index2] < 0.0)
        {
          num1 += this.parentSeries[index2];
          ++num2;
        }
      }
      double num3 = num1 / num2;
      double num4 = 0.0;
      double num5 = 0.0;
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (!Calendar.IsWeekend(this.parentSeries.GetDateTime(index2)) && this.parentSeries[index2] < 0.0)
        {
          num5 += (this.parentSeries[index2] - num3) * (this.parentSeries[index2] - num3);
          ++num4;
        }
      }
      return Math.Sqrt(num5 / (num4 - 1.0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset()
    {
      this.mean = 0.0;
      this.n = 0.0;
      base.Reset();
    }
  }
}
