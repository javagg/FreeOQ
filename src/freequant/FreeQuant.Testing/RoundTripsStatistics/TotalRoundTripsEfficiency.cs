using FreeQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTripsStatistics
{
  public class TotalRoundTripsEfficiency : RoundTripsTesterItem
  {
    
    public TotalRoundTripsEfficiency(RoundTripList parentRoundTripList, string title)
			: base(parentRoundTripList, title) {

    }

    
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

    
    protected override double GetValue(int lastIndex)
    {
      if (lastIndex < 0)
        return double.NaN;
      else
        return this.parentRoundTripList[lastIndex].TotalEfficiency;
    }
  }
}
