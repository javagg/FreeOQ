// Type: SmartQuant.Testing.RoundTrips.RoundTripsTesterItem
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Testing.RoundTrips
{
  public class RoundTripsTesterItem : SeriesTesterItem
  {
    protected RoundTripList parentRoundTripList;
    protected int lastNotUpdatedIndex;

    [Browsable(false)]
    public override DoubleSeries ParentSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (DoubleSeries) null;
      }
    }

    [Browsable(false)]
    public override SeriesTesterItem ParentComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (SeriesTesterItem) null;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    [Browsable(false)]
    public override double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (!this.enabled)
          return double.NaN;
        if (this.fillSeries)
        {
          if (this.series.Count > 0)
            return this.series.Last;
          else
            return double.NaN;
        }
        else if (this.parentRoundTripList.Count > 0)
          return this.GetValue(this.parentRoundTripList.Count - 1);
        else
          return double.NaN;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTripsTesterItem(RoundTripList parentRoundTripList, string title)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(title);
      this.isUpdating = false;
      this.lastDateTime = DateTime.MinValue;
      this.series = new DoubleSeries();
      this.series.Name = this.name;
      this.series.Title = title;
      this.parentRoundTripList = parentRoundTripList;
      this.lastNotUpdatedIndex = -1;
      this.Connect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int lastIndex1 = firstIndex; lastIndex1 <= lastIndex; ++lastIndex1)
      {
        double num = this.GetValue(lastIndex1);
        if (!double.IsNaN(num))
          this.series.Add(this.parentRoundTripList[lastIndex1].ExitDateTime, num);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual double GetValue(int lastIndex)
    {
      return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Connect()
    {
      this.parentRoundTripList.Updated += new RoundTripListEventHandler(this.cfMXcZVei);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Disconnect()
    {
      this.parentRoundTripList.Updated -= new RoundTripListEventHandler(this.cfMXcZVei);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset()
    {
      this.lastNotUpdatedIndex = -1;
      base.Reset();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void cfMXcZVei([In] RoundTripListEventArgs obj0)
    {
      this.lastNotUpdatedIndex = obj0.LastNotUpdatedIndex;
      if (this.isUpdating || !this.fillSeries)
        return;
      this.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Calculate()
    {
      if (!this.enabled)
        return;
      int firstIndex = this.lastIndex != -1 ? this.lastNotUpdatedIndex + 1 : 0;
      this.lastIndex = this.parentRoundTripList.Count - 1;
      if (this.lastNotUpdatedIndex >= 0)
      {
        int index = this.series.GetIndex(this.parentRoundTripList[this.lastNotUpdatedIndex].ExitDateTime.AddTicks(1L), EIndexOption.Next);
        if (index != -1)
        {
          while (this.series.Count > index)
            this.series.Remove(this.series.Count - 1);
        }
      }
      else
        this.series.Clear();
      this.CalculateSeries(firstIndex, this.lastIndex);
    }
  }
}
