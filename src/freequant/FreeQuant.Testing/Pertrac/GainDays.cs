// Type: SmartQuant.Testing.Pertrac.GainDays
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
  public class GainDays : SeriesTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GainDays(string name, SeriesTesterItem parentSeriesItem)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2106) + parentSeriesItem.Series.Title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GainDays(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        DateTime dateTime = this.parentSeries.GetDateTime(index);
        if (this.series.Count == 0)
        {
          if (this.parentSeries[dateTime] > 0.0)
            this.series.Add(dateTime, 1.0);
          else
            this.series.Add(dateTime, 0.0);
        }
        else if (this.parentSeries[dateTime] > 0.0)
          this.series.Add(dateTime, this.series.Last + 1.0);
        else
          this.series.Add(dateTime, this.series.Last);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      double num = 0.0;
      int index1 = this.parentSeries.GetIndex(date);
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        if (this.parentSeries[index2] > 0.0)
          ++num;
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ValueToSrting()
    {
      return ((int) this.LastValue).ToString();
    }
  }
}
