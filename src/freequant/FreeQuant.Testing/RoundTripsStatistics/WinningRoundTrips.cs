// Type: SmartQuant.Testing.RoundTripsStatistics.WinningRoundTrips
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTripsStatistics
{
  public class WinningRoundTrips : RoundTripsTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WinningRoundTrips(RoundTripList parentRoundTripList, string title)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentRoundTripList, title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      double Data = this.series.Count != 0 ? this.series.Last : 0.0;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        if (this.parentRoundTripList[index].RoundTripResultWithoutCost > 0.0)
          ++Data;
        this.series.Add(this.parentRoundTripList[index].ExitDateTime, Data);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(int lastIndex)
    {
      double num = 0.0;
      for (int index = 0; index <= lastIndex; ++index)
      {
        if (this.parentRoundTripList[index].RoundTripResultWithoutCost > 0.0)
          ++num;
      }
      return num;
    }
  }
}
