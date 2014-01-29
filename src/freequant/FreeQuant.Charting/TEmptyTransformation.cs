using System;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TEmptyTransformation : IChartTransformation
	{
		public double CalculateNotInSessionTicks(double x, double y)
		{
			return 0.0;
		}

		public double CalculateRealQuantityOfTicks_Right(double x, double y)
		{
			return y - x;
		}

		public double CalculateRealQuantityOfTicks_Left(double x, double y)
		{
			return y - x;
		}

		public void GetFirstGridDivision(ref EGridSize gridSize, ref double min, ref double max, ref DateTime firstDateTime)
		{
			gridSize = Axis.CalculateSize(max - min);
		}

		public double GetNextGridDivision(double firstTick, double prevMajor, int majorCount, EGridSize gridSize)
		{
			return majorCount != 0 ? (double)Axis.GetNextMajor((long)prevMajor, gridSize) : firstTick;
		}
	}
}
