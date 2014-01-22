using FreeQuant.Testing.RoundTrips;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTripsStatistics
{
  public class WinningRoundTripsValues : RoundTripsTesterItem
  {
    
    public WinningRoundTripsValues(RoundTripList parentRoundTripList, string title)
			: base(parentRoundTripList, title) {

    }

    
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
