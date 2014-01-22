using FreeQuant.Testing.RoundTrips;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTripsStatistics
{
  public class LargestWinningRoundTrip : RoundTripsTesterItem
  {
    
    public LargestWinningRoundTrip(RoundTripList parentRoundTripList, string title)
			: base(parentRoundTripList, title) {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      double num = this.series.Count != 0 ? this.series.Last : double.MinValue;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        num = Math.Max(num, this.parentRoundTripList[index].RoundTripResultWithoutCost);
        this.series.Add(this.parentRoundTripList[index].ExitDateTime, num);
      }
    }

    
    protected override double GetValue(int lastIndex)
    {
      double val1 = double.MinValue;
      for (int index = 0; index <= lastIndex; ++index)
        val1 = Math.Max(val1, this.parentRoundTripList[index].RoundTripResultWithoutCost);
      return val1;
    }
  }
}
