using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting
{
	[Serializable]
	public class Pie : IDrawable
	{
		private string title;
		private ArrayList pieces;
		private bool enableContour;
		private Color contourColor;
		private int gap;
		private Color[] xZYCQ9Q5Ts;
		private bool toolTipEnabled;
		private string toolTipFormat;

		public string Name { get; set; }

		public string Title
		{
			get
			{
				return this.title; 
			}
			set
			{
				this.title = value;
			}
		}

		public bool ToolTipEnabled
		{
			get
			{
				return this.toolTipEnabled; 
			}
			set
			{
				this.toolTipEnabled = value;
			}
		}

		public string ToolTipFormat
		{
			get
			{
				return this.toolTipFormat; 
			}
			set
			{
				this.toolTipFormat = value;
			}
		}

		public ArrayList Pieces
		{
			get
			{
				return this.pieces; 
			}
		}

		public bool EnableContour
		{
			get
			{
				return this.enableContour; 
			}
			set
			{
				this.enableContour = value;
			}
		}

		public Color ContourColor
		{
			get
			{
				return this.contourColor; 
			}
			set
			{
				this.contourColor = value;
			}
		}

		public int Gap
		{
			get
			{
				return this.gap; 
			}
			set
			{
				this.gap = value;
			}
		}

		public string Format { get; set; }

		public Pie() : base()
		{
			this.Xa6CkQ4RMs();
		}

		public Pie(string Name) : base()
		{
			this.Name = Name;
			this.Xa6CkQ4RMs();
		}

		public Pie(string Name, string Title) : base()
		{
			this.Name = Name;
			this.title = Title; 
			this.Xa6CkQ4RMs();
		}

		private void Xa6CkQ4RMs()
		{
			this.pieces = new ArrayList();
			this.enableContour = true;
			this.contourColor = Color.Gray;
			this.gap = 0;
			this.Format = "invalid Format";
			this.xZYCQ9Q5Ts = this.XCwC0hNY1C();
		}

		public void Add(double Weight)
		{
			this.pieces.Add(new L43w3fFP7y8JGLlRK3(Weight, "", Color.Empty));
		}

		public void Add(double Weight, string Text, Color Color)
		{
			this.pieces.Add((object)new L43w3fFP7y8JGLlRK3(Weight, Text, Color));
		}

		public void Add(double Weight, string Text)
		{
			this.pieces.Add(new L43w3fFP7y8JGLlRK3(Weight, Text, Color.Empty));
		}

		public virtual void Draw(string Option)
		{
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("Canvas Name", "Canvas Title");
			}
			Chart.Pad.AxisBottom.Enabled = false;
			Chart.Pad.AxisLeft.Enabled = false;
			Chart.Pad.AxisRight.Enabled = false;
			Chart.Pad.AxisTop.Enabled = false;
			Chart.Pad.ForeColor = Color.LightGray;
			Chart.Pad.Title.Text = this.Name;
			this.aFKCuY06Ci();
			Chart.Pad.Add((IDrawable)this);
		}

		private void aFKCuY06Ci()
		{
			int num1 = 0;
			foreach (L43w3fFP7y8JGLlRK3 l43w3fFp7y8JgLlRk3 in this.pieces)
			{
				if (l43w3fFp7y8JgLlRk3.EogCymxYKu() == Color.Empty)
					l43w3fFp7y8JgLlRk3.kdHCWt1JfA(this.xZYCQ9Q5Ts[num1 * 160 / this.pieces.Count]);
				++num1;
			}
			double num2 = 0.0;
			foreach (L43w3fFP7y8JGLlRK3 l43w3fFp7y8JgLlRk3 in this.pieces)
				num2 += l43w3fFp7y8JgLlRk3.spNC4XmohN();
			foreach (L43w3fFP7y8JGLlRK3 l43w3fFp7y8JgLlRk3 in this.pieces)
			{
				double num3 = l43w3fFp7y8JgLlRk3.spNC4XmohN() / num2;
				string Text = l43w3fFp7y8JgLlRk3.aGNCpFmwcx().Replace(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(806), (num3 * 100.0).ToString(this.format));
				Chart.Pad.Title.Add(Text, l43w3fFp7y8JgLlRk3.EogCymxYKu());
				Chart.Pad.Legend.Add(Text, l43w3fFp7y8JgLlRk3.EogCymxYKu());
			}
		}

		public virtual void Draw()
		{
			this.Draw(String.Empty);
		}

		private Color[] UMpCmdQhJy([In] Color obj0, [In] Color obj1, [In] int obj2)
		{
			Color[] colorArray = new Color[obj2];
			double num1 = (double)((int)obj1.R - (int)obj0.R) / (double)obj2;
			double num2 = (double)((int)obj1.G - (int)obj0.G) / (double)obj2;
			double num3 = (double)((int)obj1.B - (int)obj0.B) / (double)obj2;
			double num4 = (double)obj0.R;
			double num5 = (double)obj0.G;
			double num6 = (double)obj0.B;
			colorArray[0] = obj0;
			for (int index = 1; index < obj2; ++index)
			{
				num4 += num1;
				num5 += num2;
				num6 += num3;
				colorArray[index] = Color.FromArgb((int)num4, (int)num5, (int)num6);
			}
			return colorArray;
		}

		private Color[] XCwC0hNY1C()
		{
			Color[] colorArray = new Color[160];
			int num = 0;
			foreach (Color color in this.UMpCmdQhJy(Color.Purple, Color.Blue, 32))
				colorArray[num++] = color;
			foreach (Color color in this.UMpCmdQhJy(Color.Blue, Color.Green, 32))
				colorArray[num++] = color;
			foreach (Color color in this.UMpCmdQhJy(Color.Green, Color.Yellow, 32))
				colorArray[num++] = color;
			foreach (Color color in this.UMpCmdQhJy(Color.Yellow, Color.Orange, 32))
				colorArray[num++] = color;
			foreach (Color color in this.UMpCmdQhJy(Color.Orange, Color.Red, 32))
				colorArray[num++] = color;
			return colorArray;
		}

		public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
		{
			double num1 = 0.0;
			for (int index = 0; index < this.pieces.Count; ++index)
				num1 += ((L43w3fFP7y8JGLlRK3)this.pieces[index]).spNC4XmohN();
			int num2 = Pad.ClientX(0.0);
			int num3 = Pad.ClientY(100.0);
			int num4 = Math.Abs(Pad.ClientX(100.0) - Pad.ClientX(0.0));
			int num5 = Math.Abs(Pad.ClientY(100.0) - Pad.ClientY(0.0));
			int num6 = 0;
			int num7 = 0;
			if (num4 > num5)
			{
				num6 = (num4 - num5) / 2;
				num4 = num5;
			}
			else
			{
				num7 = (num5 - num4) / 2;
				num5 = num4;
			}
			int num8 = num5 / 10;
			double num9 = 0.0;
			double num10 = 0.0;
			for (int index = 0; index < this.pieces.Count; ++index)
			{
				double num11 = ((L43w3fFP7y8JGLlRK3)this.pieces[index]).spNC4XmohN() / num1;
				Brush brush = (Brush)new SolidBrush(((L43w3fFP7y8JGLlRK3)this.pieces[index]).EogCymxYKu());
				double num12 = num10 + (double)this.gap;
				num10 += 360.0 * num11;
				double num13 = num10 - num12 + 1.0;
				Pad.Graphics.FillPie(brush, num2 + num6 + num8, num3 + num7 + num8, num4 - 2 * num8, num5 - 2 * num8, (int)num12, (int)num13);
			}
			if (this.enableContour)
			{
				num9 = 0.0;
				double num11 = 0.0;
				for (int index = 0; index < this.pieces.Count; ++index)
				{
					double num12 = ((L43w3fFP7y8JGLlRK3)this.pieces[index]).spNC4XmohN() / num1;
					Pen pen = new Pen(this.contourColor);
					double num13 = num11 + (double)this.gap;
					num11 += 360.0 * num12;
					double num14 = num11 - num13 + 1.0;
					Pad.Graphics.DrawPie(pen, (float)(num2 + num6 + num8), (float)(num3 + num7 + num8), (float)(num4 - 2 * num8), (float)(num5 - 2 * num8), (float)num13, (float)num14);
				}
			}
			num9 = 0.0;
			double num15 = 0.0;
			for (int index = 0; index < this.pieces.Count; ++index)
			{
				double num11 = ((L43w3fFP7y8JGLlRK3)this.pieces[index]).spNC4XmohN() / num1;
				Pen pen = new Pen(this.contourColor);
				double num12 = num15 + (double)this.gap;
				num15 += 360.0 * num11;
				double num13 = num12 + (num15 - num12) / 2.0 + 90.0;
				int num14 = (num4 - 2 * num8) / 4;
				int num16 = (num4 - 2 * num8) / 2;
				Math.Sin(Math.PI / 180.0 * num13);
				int num17 = (num4 - 2 * num8) / 2;
				Math.Cos(Math.PI / 180.0 * num13);
				int num18 = (num4 - 2 * num8) / 2;
				int num19 = (num4 - 2 * num8) / 2 + 10;
				int x1 = (int)((double)(num2 + num6 + num8 + (num4 - 2 * num8) / 2) + (double)num18 * Math.Sin(Math.PI / 180.0 * num13));
				int y1 = (int)((double)(num3 + num7 + num8 + (num4 - 2 * num8) / 2) - (double)num18 * Math.Cos(Math.PI / 180.0 * num13));
				int num20 = (int)((double)(num2 + num6 + num8 + (num4 - 2 * num8) / 2) + (double)num19 * Math.Sin(Math.PI / 180.0 * num13));
				int num21 = (int)((double)(num3 + num7 + num8 + (num4 - 2 * num8) / 2) - (double)num19 * Math.Cos(Math.PI / 180.0 * num13));
				Font font = new Font("Arial", 8);
				Pad.Graphics.DrawLine(new Pen(Color.Gray), x1, y1, num20, num21);
				string str = ((L43w3fFP7y8JGLlRK3)this.pieces[index]).aGNCpFmwcx().Replace(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(828), (num11 * 100.0).ToString(this.format));
				if (num20 > num2 + num6 + num4 / 2)
				{
					Pad.Graphics.DrawLine(new Pen(Color.Gray), num20, num21, num20 + 5, num21);
					SizeF sizeF = Pad.Graphics.MeasureString(str, font);
					Pad.Graphics.DrawString(str, font, (Brush)new SolidBrush(Color.Black), (float)(num20 + 5), (float)num21 - sizeF.Height / 2f);
				}
				else
				{
					Pad.Graphics.DrawLine(new Pen(Color.Gray), num20, num21, num20 - 5, num21);
					SizeF sizeF = Pad.Graphics.MeasureString(str, font);
					Pad.Graphics.DrawString(str, font, (Brush)new SolidBrush(Color.Black), (float)(num20 - 5) - sizeF.Width, (float)num21 - sizeF.Height / 2f);
				}
			}
		}

		public TDistance Distance(double X, double Y)
		{
			return (TDistance)null;
		}
	}
}
