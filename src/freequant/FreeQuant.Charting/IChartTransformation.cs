// Type: SmartQuant.Charting.IChartTransformation
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using System;

namespace SmartQuant.Charting
{
  public interface IChartTransformation
  {
    double CalculateNotInSessionTicks(double X, double Y);

    double CalculateRealQuantityOfTicks_Right(double X, double Y);

    double CalculateRealQuantityOfTicks_Left(double X, double Y);

    void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime);

    double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize);
  }
}
