// Type: SmartQuant.Testing.RoundTripsStatistics.TotalRoundTripsEfficiency
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTripsStatistics
{
  public class TotalRoundTripsEfficiency : RoundTripsTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TotalRoundTripsEfficiency(RoundTripList parentRoundTripList, string title)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentRoundTripList, title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      int num = 0;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        double totalEfficiency = this.parentRoundTripList[index].TotalEfficiency;
        if (!double.IsNaN(totalEfficiency))
        {
          if (this.series.Contains(this.parentRoundTripList[index].ExitDateTime))
          {
            this.series.Add(this.parentRoundTripList[index].ExitDateTime.AddTicks((long) num), totalEfficiency);
            ++num;
          }
          else
            num = 0;
          this.series.Add(this.parentRoundTripList[index].ExitDateTime, totalEfficiency);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(int lastIndex)
    {
      if (lastIndex < 0)
        return double.NaN;
      else
        return this.parentRoundTripList[lastIndex].TotalEfficiency;
    }
  }
}
