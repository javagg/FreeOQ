// Type: SmartQuant.Testing.Pertrac.VaR
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using SmartQuant.Business;
using SmartQuant.Testing.TesterItems;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Pertrac
{
  public class VaR : SeriesTesterItem
  {
    protected double level;
    protected ArrayList sortedSeries;

    [Category("Parameters")]
    public double Level
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.level;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.level = value;
        this.EmitPropertyChanged();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VaR(string name, SeriesTesterItem parentSeriesItem, double level)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, parentSeriesItem, s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1386) + parentSeriesItem.Series.Title);
      this.level = level;
      this.sortedSeries = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VaR(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(DateTime date)
    {
      int index1 = this.parentSeries.GetIndex(date);
      ArrayList arrayList = new ArrayList();
      for (int index2 = 0; index2 <= index1; ++index2)
      {
        DateTime dateTime = this.parentSeries.GetDateTime(index2);
        if (!Calendar.IsWeekend(dateTime))
          arrayList.Add((object) this.parentSeries[dateTime]);
      }
      arrayList.Sort();
      int index3 = arrayList.Count - (int) (this.level * (double) arrayList.Count / 100.0) - 1;
      if (index3 > arrayList.Count - 1 || index3 < 0)
        return double.NaN;
      else
        return (double) arrayList[index3];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset()
    {
      base.Reset();
      this.sortedSeries = new ArrayList();
    }
  }
}
