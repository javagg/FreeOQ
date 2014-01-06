// Type: SmartQuant.Testing.RoundTripsStatistics.LargestWinningRoundTrip
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.RoundTrips;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTripsStatistics
{
  public class LargestWinningRoundTrip : RoundTripsTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LargestWinningRoundTrip(RoundTripList parentRoundTripList, string title)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentRoundTripList, title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      double num = this.series.Count != 0 ? this.series.Last : double.MinValue;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        num = Math.Max(num, this.parentRoundTripList[index].RoundTripResultWithoutCost);
        this.series.Add(this.parentRoundTripList[index].ExitDateTime, num);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(int lastIndex)
    {
      double val1 = double.MinValue;
      for (int index = 0; index <= lastIndex; ++index)
        val1 = Math.Max(val1, this.parentRoundTripList[index].RoundTripResultWithoutCost);
      return val1;
    }
  }
}
