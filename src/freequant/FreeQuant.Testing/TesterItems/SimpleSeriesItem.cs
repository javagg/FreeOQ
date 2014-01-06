// Type: SmartQuant.Testing.TesterItems.SimpleSeriesItem
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Series;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.TesterItems
{
  public class SimpleSeriesItem : SeriesTesterItem
  {
    [Browsable(false)]
    public override SeriesTesterItem ParentComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (SeriesTesterItem) null;
      }
    }

    [Browsable(false)]
    public override bool FillSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fillSeries;
      }
    }

    [Browsable(false)]
    public override bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.enabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    public override double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.series.Count > 0)
          return this.series.Last;
        else
          return double.NaN;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleSeriesItem(string name, DoubleSeries parentSeries)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.enabled = true;
      this.parentSeries = parentSeries;
      this.name = name;
      this.series = parentSeries;
      this.fillSeries = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleSeriesItem(string name)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(name);
      this.enabled = true;
    }
  }
}
