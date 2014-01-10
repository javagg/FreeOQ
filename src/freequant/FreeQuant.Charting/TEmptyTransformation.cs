using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TEmptyTransformation : IChartTransformation
  {
    
    public double CalculateNotInSessionTicks(double X, double Y)
    {
      return 0.0;
    }

    
    public double CalculateRealQuantityOfTicks_Right(double X, double Y)
    {
      return Y - X;
    }

    
    public double CalculateRealQuantityOfTicks_Left(double X, double Y)
    {
      return Y - X;
    }

    
    public void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime)
    {
      GridSize = Axis.CalculateSize(Max - Min);
    }

    
    public double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize)
    {
      return MajorCount != 0 ? (double) Axis.GetNextMajor((long) PrevMajor, GridSize) : FirstTick;
    }
  }
}
