using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TText : IDrawable
	{
		protected double fX;
		protected double fY;
		protected double fZ;
		protected string fText;
		protected ETextPosition fPosition;
		protected Font fFont;
		protected Color fColor;

		[Description("")]
		[Category("ToolTip")]
		public bool ToolTipEnabled { get; set; }

		[Description("")]
		[Category("ToolTip")]
		public string ToolTipFormat { get; set; }

		[Category("Position")]
		[Description("")]
		public double X
		{
			get
			{
				return this.fX;
			}
			set
			{
				this.fX = value;
			}
		}

		[Description("")]
		[Category("Position")]
		public double Y
		{
			get
			{
				return this.fY;
			}
			set
			{
				this.fY = value;
			}
		}

		[Browsable(false)]
		public double Z
		{
			get
			{
				return this.fZ;
			}
			set
			{
				this.fZ = value;
			}
		}

		[Category("Text")]
		[Description("")]
		public string Text
		{
			get
			{
				return this.fText;
			}
			set
			{
				this.fText = value;
			}
		}

		[Category("Text")]
		[Description("")]
		public ETextPosition Position
		{
			get
			{
				return this.fPosition;
			}
			set
			{
				this.fPosition = value;
			}
		}

		[Category("Text")]
		[Description("")]
		public Font Font
		{
			get
			{
				return this.fFont;
			}
			set
			{
				this.fFont = value;
			}
		}

		[Description("")]
		[Category("Text")]
		public Color Color
		{
			get
			{
				return this.fColor;
			}
			set
			{
				this.fColor = value;
			}
		}

		public TText(string text, double x, double y, Color color = default(Color))
		{

			this.fX = x;
			this.fY = y;
			this.fZ = 0.0;
			this.fText = text;
			this.Init();
			this.fColor = color;
		}

		public TText(string text, DateTime X, double y, Color color = default(Color))
		{
			this.fX = (double)X.Ticks;
			this.fY = y;
			this.fZ = 0.0;
			this.fText = text;
			this.Init();
			this.fColor = color;
		}

		private void Init()
		{
			this.fPosition = ETextPosition.RightBottom;
			this.fFont = new Font("Times New Roman", 8);
			this.fColor = Color.Black;
		}

		public virtual void Draw()
		{
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("CName", "CTEXt");
			}
			Chart.Pad.Add((IDrawable)this);
		}

		public void Paint(Pad pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			if (this.fText == null)
				return;
			int num1 = (int)pad.Graphics.MeasureString(this.fText, this.fFont).Width;
			double num2 = (double)pad.Graphics.MeasureString(this.fText, this.fFont).Height;
			switch (this.fPosition)
			{
				case ETextPosition.RightBottom:
					pad.Graphics.DrawString(this.fText, this.fFont, (Brush)new SolidBrush(this.fColor), (float)pad.ClientX(this.fX), (float)pad.ClientY(this.fY));
					break;
				case ETextPosition.LeftBottom:
					pad.Graphics.DrawString(this.fText, this.fFont, (Brush)new SolidBrush(this.fColor), (float)(pad.ClientX(this.fX) - num1), (float)pad.ClientY(this.fY));
					break;
				case ETextPosition.CentreBottom:
					pad.Graphics.DrawString(this.fText, this.fFont, (Brush)new SolidBrush(this.fColor), (float)(pad.ClientX(this.fX) - num1 / 2), (float)pad.ClientY(this.fY));
					break;
			}
		}

		public TDistance Distance(double X, double Y)
		{
			return null;
		}
	}
}
