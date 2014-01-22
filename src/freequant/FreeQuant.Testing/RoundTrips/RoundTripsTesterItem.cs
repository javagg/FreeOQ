using FreeQuant.Series;
using FreeQuant.Testing.TesterItems;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing.RoundTrips
{
  public class RoundTripsTesterItem : SeriesTesterItem
  {
    protected RoundTripList parentRoundTripList;
    protected int lastNotUpdatedIndex;

    [Browsable(false)]
    public override DoubleSeries ParentSeries
    {
       get
      {
        return (DoubleSeries) null;
      }
    }

    [Browsable(false)]
    public override SeriesTesterItem ParentComponent
    {
       get
      {
        return (SeriesTesterItem) null;
      }
       set
      {
      }
    }

    [Browsable(false)]
    public override double LastValue
    {
       get
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

    
    public RoundTripsTesterItem(RoundTripList parentRoundTripList, string title)
			: base(title) {
      this.isUpdating = false;
      this.lastDateTime = DateTime.MinValue;
      this.series = new DoubleSeries();
      this.series.Name = this.name;
      this.series.Title = title;
      this.parentRoundTripList = parentRoundTripList;
      this.lastNotUpdatedIndex = -1;
      this.Connect();
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int lastIndex1 = firstIndex; lastIndex1 <= lastIndex; ++lastIndex1)
      {
        double num = this.GetValue(lastIndex1);
        if (!double.IsNaN(num))
          this.series.Add(this.parentRoundTripList[lastIndex1].ExitDateTime, num);
      }
    }

    
    protected virtual double GetValue(int lastIndex)
    {
      return double.NaN;
    }

    
    public override void Connect()
    {
      this.parentRoundTripList.Updated += new RoundTripListEventHandler(this.cfMXcZVei);
    }

    
    public override void Disconnect()
    {
      this.parentRoundTripList.Updated -= new RoundTripListEventHandler(this.cfMXcZVei);
    }

    
    public override void Reset()
    {
      this.lastNotUpdatedIndex = -1;
      base.Reset();
    }

    
    private void cfMXcZVei([In] RoundTripListEventArgs obj0)
    {
      this.lastNotUpdatedIndex = obj0.LastNotUpdatedIndex;
      if (this.isUpdating || !this.fillSeries)
        return;
      this.Calculate();
    }

    
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
