using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TLine : IDrawable
	{
		public bool ToolTipEnabled { get; set; }
		public string ToolTipFormat { get; set; }
		public double X1 { get; set; }
		public double Y1 { get; set; }
		public double X2 { get; set; }
		public double Y2 { get; set; }
		public DashStyle DashStyle  { get; set; }
		public Color Color { get; set; }
		public int Width { get; set; }

		public TLine(double x1, double y1, double x2, double y2)
		{
			this.X1 = x1;
			this.Y1 = y1;
			this.X2 = x2;
			this.Y2 = y2;
			this.Color = Color.Black;
			this.DashStyle = DashStyle.Solid;
			this.Width = 1;
		}

		public TLine(DateTime x1, double y1, DateTime x2, double y2)
		{
			this.X1 = x1.Ticks;
			this.Y1 = y1;
			this.X2 = x2.Ticks;
			this.Y2 = y2;
			this.Color = Color.Black;
			this.DashStyle = DashStyle.Solid;
			this.Width = 1;
		}

		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("d", "d");
			}
			Chart.Pad.Add(this);
		}

		public virtual void Paint(Pad pad, double xMin, double xMax, double yMin, double yMax)
		{
			pad.DrawLine(new Pen(this.Color)
			{
				Width = this.Width,
				DashStyle = this.DashStyle
			}, this.X1, this.Y1, this.X2, this.Y2);
		}

		public TDistance Distance(double x, double y)
		{
			return null;
		}
	}
}
