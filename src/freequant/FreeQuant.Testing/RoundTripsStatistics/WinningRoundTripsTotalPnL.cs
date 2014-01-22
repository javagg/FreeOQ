using FreeQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTripsStatistics
{
  public class WinningRoundTripsTotalPnL : RoundTripsTesterItem
  {
   
    public WinningRoundTripsTotalPnL(RoundTripList parentRoundTripList, string title)
			: base(parentRoundTripList, title)   {

    }

   
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      double Data = this.series.Count != 0 ? this.series.Last : 0.0;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        double resultWithoutCost = this.parentRoundTripList[index].RoundTripResultWithoutCost;
        if (resultWithoutCost > 0.0)
          Data += resultWithoutCost;
        this.series.Add(this.parentRoundTripList[index].ExitDateTime, Data);
      }
    }

   
    protected override double GetValue(int lastIndex)
    {
      double num = 0.0;
      for (int index = 0; index <= lastIndex; ++index)
      {
        double resultWithoutCost = this.parentRoundTripList[index].RoundTripResultWithoutCost;
        if (resultWithoutCost > 0.0)
          num += resultWithoutCost;
      }
      return num;
    }
  }
}
