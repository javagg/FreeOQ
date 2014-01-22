using FreeQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTripsStatistics
{
  public class RoundTripsEntryEfficiency : RoundTripsTesterItem
  {
    
    public RoundTripsEntryEfficiency(RoundTripList parentRoundTripList, string title)
			: base(parentRoundTripList, title) {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      int num = 0;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        double entryEfficiency = this.parentRoundTripList[index].EntryEfficiency;
        if (!double.IsNaN(entryEfficiency))
        {
          if (this.series.Contains(this.parentRoundTripList[index].ExitDateTime))
          {
            this.series.Add(this.parentRoundTripList[index].ExitDateTime.AddTicks((long) num), entryEfficiency);
            ++num;
          }
          else
            num = 0;
          this.series.Add(this.parentRoundTripList[index].ExitDateTime, entryEfficiency);
        }
      }
    }

    
    protected override double GetValue(int lastIndex)
    {
      if (lastIndex < 0)
        return double.NaN;
      else
        return this.parentRoundTripList[lastIndex].EntryEfficiency;
    }
  }
}
