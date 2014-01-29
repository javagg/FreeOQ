using System;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TDistance
	{
		public double dX { get; set; }
		public double dY{ get; set; }
		public double X { get; set; }
		public double Y { get; set; }
		public string ToolTipText { get; set; }

		public TDistance()
		{
			this.dX = double.MaxValue;
			this.dY = double.MaxValue;
			this.ToolTipText = String.Empty;
		}
	}
}
