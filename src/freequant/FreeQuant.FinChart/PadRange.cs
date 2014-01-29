using System;

namespace FreeQuant.FinChart
{
	[Serializable]
	public class PadRange
	{
		public double Min { get; set; }
		public double Max { get; set; }
		public bool IsValid  { get; private set; }

		public PadRange(double min, double max)
		{
			this.Min = min;
			this.Max = max;
			this.IsValid = max - min > 4.94065645841247E-324;
		}
	}
}
