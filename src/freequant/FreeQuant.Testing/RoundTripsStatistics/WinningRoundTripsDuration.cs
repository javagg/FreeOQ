// Type: SmartQuant.Testing.RoundTripsStatistics.WinningRoundTripsDuration
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.RoundTrips;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTripsStatistics
{
  public class WinningRoundTripsDuration : RoundTripsTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WinningRoundTripsDuration(RoundTripList parentRoundTripList, string title)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentRoundTripList, title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      int num1 = 0;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        if (this.parentRoundTripList[index].RoundTripResultWithCost > 0.0)
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
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(int lastIndex)
    {
      double num = 0.0;
      for (int index = lastIndex; index >= 0; --index)
      {
        if (this.parentRoundTripList[index].RoundTripResultWithCost > 0.0)
        {
          num = (double) (this.parentRoundTripList[index].ExitDateTime.Ticks - this.parentRoundTripList[index].EntryDateTime.Ticks);
          break;
        }
      }
      if ((num + 1.0) % 864000000000.0 == 0.0)
        ++num;
      return num;
    }
  }
}
