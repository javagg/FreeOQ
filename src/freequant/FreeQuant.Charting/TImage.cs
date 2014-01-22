using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
	public class TImage : IDrawable, IMovable
	{
		private Image image;

		[Description("X position of this image on the pad. (World coordinate system)")]
		[Category("Position")]
		public double X { get; set; }

		[Description("Y position of this image on the pad. (World coordinate system)")]
		[Category("Position")]
		public double Y  { get; set; }

		[Description("Enable or disable tooltip appearance for this image.")]
		[Category("ToolTip")]
		public bool ToolTipEnabled { get; set; }

		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
		[Category("ToolTip")]
		public string ToolTipFormat { get; set; }

		public TImage(Image Image, double X, double Y) : base()
		{
			this.image = Image;
			this.X = X;
			this.Y = Y;
			this.yee3w4ff2w();
		}

		public TImage(Image Image, DateTime X, double Y) : base()
		{
			this.image = Image;
			this.X = (double)X.Ticks;
			this.Y = Y;
			this.yee3w4ff2w();
		}

		public TImage(string FileName, double X, double Y) : base()
		{
			this.image = Image.FromFile(FileName);
			this.X = X;
			this.Y = Y;
			this.yee3w4ff2w();
		}

		public TImage(string FileName, DateTime X, double Y) : base()
		{
			this.image = Image.FromFile(FileName);
			this.X = X.Ticks;
			this.Y = Y;
			this.yee3w4ff2w();
		}

		[SpecialName] 
		private Image T343SKhwwY()
		{
			return this.image;
		}

		[SpecialName]
		private void uYZ3jN1m5i(Image value)
		{
			this.image = value;
		}

		private void yee3w4ff2w()
		{
			this.ToolTipEnabled = true;
			this.ToolTipFormat = "{0} {1}";  //FIXME:
		}

		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("Canvas Name", "Canvas Title");
			}
			Chart.Pad.Add((IDrawable)this);
		}

		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			int x = Pad.ClientX(this.X);
			int y = Pad.ClientY(this.Y);
			Pad.Graphics.DrawImage(this.image, x, y);
		}

		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			tdistance.X = this.X;
			tdistance.Y = this.Y;
			tdistance.dX = Math.Abs(X - this.X);
			tdistance.dY = Math.Abs(Y - this.Y);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(this.ToolTipFormat, this.X, this.Y);
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		public void Move(double X, double Y, double dX, double dY)
		{
			this.X += dX;
			this.Y += dY;
		}
	}
}
