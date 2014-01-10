using System;

namespace FreeQuant.Charting
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
