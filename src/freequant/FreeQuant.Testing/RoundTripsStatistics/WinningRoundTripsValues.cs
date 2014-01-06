// Type: SmartQuant.Testing.RoundTripsStatistics.WinningRoundTripsValues
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.RoundTrips;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTripsStatistics
{
  public class WinningRoundTripsValues : RoundTripsTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WinningRoundTripsValues(RoundTripList parentRoundTripList, string title)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentRoundTripList, title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(int lastIndex)
    {
      double num = 0.0;
      DateTime exitDateTime = this.parentRoundTripList[lastIndex].ExitDateTime;
      for (int index = lastIndex; index != -1 && exitDateTime == this.parentRoundTripList[index].ExitDateTime; --index)
      {
        double resultWithoutCost = this.parentRoundTripList[index].RoundTripResultWithoutCost;
        if (resultWithoutCost > 0.0)
          num += resultWithoutCost;
      }
      return num;
    }
  }
}
