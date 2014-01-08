using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSpreadOrBenchmarkCurveDataEventArgs : EventArgs
  {
    private FIXSpreadOrBenchmarkCurveData eei873y2k7;

    public FIXSpreadOrBenchmarkCurveData SpreadOrBenchmarkCurveData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.eei873y2k7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.eei873y2k7 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSpreadOrBenchmarkCurveDataEventArgs(FIXSpreadOrBenchmarkCurveData SpreadOrBenchmarkCurveData)
    {
      this.eei873y2k7 = SpreadOrBenchmarkCurveData;
    }
  }
}
