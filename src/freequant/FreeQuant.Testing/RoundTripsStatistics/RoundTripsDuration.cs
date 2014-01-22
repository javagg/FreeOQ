using FreeQuant.Testing.RoundTrips;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTripsStatistics
{
  public class RoundTripsDuration : RoundTripsTesterItem
  {
    
    public RoundTripsDuration(RoundTripList parentRoundTripList, string title)
			: base(parentRoundTripList, title) {

    }

    
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      int num1 = 0;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        DateTime entryDateTime = this.parentRoundTripList[index].EntryDateTime;
        DateTime exitDateTime = this.parentRoundTripList[index].ExitDateTime;
        long num2 = exitDateTime.Ticks - entryDateTime.Ticks;
        if ((num2 + 1L) % 864000000000L == 0L)
          ++num2;
        if (this.series.Contains(exitDateTime))
        {
          this.series.Add(exitDateTime.AddTicks((long) num1), (double) num2);
          ++num1;
        }
        else
          num1 = 0;
        this.series.Add(this.parentRoundTripList[index].ExitDateTime, (double) num2);
      }
    }

    
    protected override double GetValue(int lastIndex)
    {
      double num = 0.0;
      if (lastIndex >= 0)
        num = (double) (this.parentRoundTripList[lastIndex].ExitDateTime.Ticks - this.parentRoundTripList[lastIndex].EntryDateTime.Ticks);
      if ((num + 1.0) % 864000000000.0 == 0.0)
        ++num;
      return num;
    }
  }
}
