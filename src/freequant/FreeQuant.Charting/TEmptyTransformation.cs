// Type: SmartQuant.Charting.TEmptyTransformation
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Charting
{
  [Serializable]
  public class TEmptyTransformation : IChartTransformation
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TEmptyTransformation()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateNotInSessionTicks(double X, double Y)
    {
      return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateRealQuantityOfTicks_Right(double X, double Y)
    {
      return Y - X;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateRealQuantityOfTicks_Left(double X, double Y)
    {
      return Y - X;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime)
    {
      GridSize = Axis.CalculateSize(Max - Min);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize)
    {
      return MajorCount != 0 ? (double) Axis.GetNextMajor((long) PrevMajor, GridSize) : FirstTick;
    }
  }
}
