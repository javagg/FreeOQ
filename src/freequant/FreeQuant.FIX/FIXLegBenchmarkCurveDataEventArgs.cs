using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXLegBenchmarkCurveDataEventArgs : EventArgs
  {
    private FIXLegBenchmarkCurveData AQNUV1SAkJ;

    public FIXLegBenchmarkCurveData LegBenchmarkCurveData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.AQNUV1SAkJ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AQNUV1SAkJ = value;
      }
    }

    public FIXLegBenchmarkCurveDataEventArgs(FIXLegBenchmarkCurveData LegBenchmarkCurveData)
    {
      this.AQNUV1SAkJ = LegBenchmarkCurveData;
    }
  }
}
