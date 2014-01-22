using FreeQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTripsStatistics
{
  public class NumberOfRoundTrips : RoundTripsTesterItem
  {
    
    public NumberOfRoundTrips(RoundTripList parentRoundTripList, string title)
			: base(parentRoundTripList, title) {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      for (int index = firstIndex; index <= lastIndex; ++index)
        this.series.Add(this.parentRoundTripList[index].ExitDateTime, (double) (index + 1));
    }

    
    protected override double GetValue(int lastIndex)
    {
      return (double) (lastIndex + 1);
    }
  }
}
