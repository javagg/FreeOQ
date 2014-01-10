using System;

namespace FreeQuant.Charting
{
	[Serializable]
	public class PadRange
	{
		public double Min;
		public double Max;
		protected bool isValid;

		public bool IsValid
		{
			get
			{
				return this.isValid;
			}
		}

		public PadRange(double min, double max)
		{
			this.Min = min;
			this.Max = max;
			this.isValid = max - min > 4.94065645841247E-324;
		}
	}
}
