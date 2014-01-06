// Type: SmartQuant.Testing.MathStatistics.Minimum
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
  public class Minimum : SeriesTesterItem
  {
    private double h7MhwLxuw;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Minimum(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      this.h7MhwLxuw = double.MaxValue;
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, name + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1376) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Minimum(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      this.h7MhwLxuw = double.MaxValue;
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
        this.h7MhwLxuw = this.series.Count != 1 ? Math.Min(this.parentSeries[dateTime1], this.series[this.series.Count - 2]) : this.parentSeries[dateTime1];
        this.series.Add(dateTime1, this.h7MhwLxuw);
      }
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        DateTime dateTime2 = this.parentSeries.GetDateTime(index);
        this.h7MhwLxuw = Math.Min(this.parentSeries[dateTime2], this.h7MhwLxuw);
        this.series.Add(dateTime2, this.h7MhwLxuw);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      double val2 = double.MaxValue;
      int index1 = this.parentSeries.GetIndex(date);
      for (int index2 = 0; index2 <= index1; ++index2)
        val2 = Math.Min(this.parentSeries[index2], val2);
      return val2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset()
    {
      this.h7MhwLxuw = double.MaxValue;
      base.Reset();
    }
  }
}
