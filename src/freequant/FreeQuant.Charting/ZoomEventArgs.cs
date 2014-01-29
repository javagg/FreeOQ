using System;

namespace FreeQuant.Charting
{
	public class ZoomEventArgs : EventArgs
	{
		public double XMin { get; set; }
		public double XMax { get; set; }
		public double YMin { get; set; }
		public double YMax { get; set; }
		public bool ZoomUnzoom { get; set; }

		public ZoomEventArgs(double xMin, double xMax, double yMin, double yMax, bool zoomUnzoom) : base()
		{
			this.XMin = xMin;
			this.XMax = xMax;
			this.YMin = yMin;
			this.YMax = yMax;
			this.ZoomUnzoom = zoomUnzoom;
		}
	}
}
