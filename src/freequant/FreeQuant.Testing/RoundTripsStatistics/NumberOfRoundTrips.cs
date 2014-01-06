// Type: SmartQuant.Testing.RoundTripsStatistics.NumberOfRoundTrips
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTripsStatistics
{
  public class NumberOfRoundTrips : RoundTripsTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberOfRoundTrips(RoundTripList parentRoundTripList, string title)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentRoundTripList, title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index = firstIndex; index <= lastIndex; ++index)
        this.series.Add(this.parentRoundTripList[index].ExitDateTime, (double) (index + 1));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(int lastIndex)
    {
      return (double) (lastIndex + 1);
    }
  }
}
