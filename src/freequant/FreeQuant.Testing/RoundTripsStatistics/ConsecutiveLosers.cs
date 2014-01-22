using FreeQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTripsStatistics
{
  public class ConsecutiveLosers : RoundTripsTesterItem
  {
    
    public ConsecutiveLosers(RoundTripList parentRoundTripList, string title)
			: base(parentRoundTripList, title) {
    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      double Data = this.series.Count != 0 ? this.series.Last : 0.0;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        double resultWithoutCost = this.parentRoundTripList[index].RoundTripResultWithoutCost;
        if (resultWithoutCost > 0.0)
          Data = 0.0;
        if (resultWithoutCost < 0.0)
          ++Data;
        this.series.Add(this.parentRoundTripList[index].ExitDateTime, Data);
      }
    }

    
    protected override double GetValue(int lastIndex)
    {
      double num = 0.0;
      for (int index = lastIndex; index >= 0; ++index)
      {
        double resultWithoutCost = this.parentRoundTripList[index].RoundTripResultWithoutCost;
        if (resultWithoutCost < 0.0)
          ++num;
        if (resultWithoutCost > 0.0)
          return num;
      }
      return num;
    }
  }
}
