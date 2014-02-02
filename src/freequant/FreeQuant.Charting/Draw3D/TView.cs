using FreeQuant.Charting;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting.Draw3D
{
	public class TView
	{
		public TLight Light;
		private TMat3x3 QaLoUk71gW;
		private TMat3x3 E6Oo4awtTa;
		private TVec3 mWHorsKIXa;
		private TVec3 lx;
		private TVec3 ly;
		private TVec3 lz;
		private int left;
		private int top;
		private int h;
		private double scaleZ;
		private static TMat3x3 rQFoIpIoe9;
		private static TMat3x3 miCoqACXHl;
		private static TMat3x3 R8ootJZDc1;

		public int Left
		{
			get
			{
				return this.left; 
			}
		}

		public int Top
		{
			get
			{
				return this.top; 
			}
		}

		public int H
		{
			get
			{
				return this.h; 
			}
		}

		public TVec3 o
		{
			get
			{
				return this.mWHorsKIXa;
			}
		}

		public TVec3 Lx
		{
			get
			{
				return this.lx; 
			}
		}

		public TVec3 Ly
		{
			get
			{
				return this.ly;
			}
		}

		public TVec3 Lz
		{
			get
			{
				return this.lz;
			}
		}

		public double ScaleZ
		{
			get
			{
				return this.scaleZ;
			}
			set
			{
				if (value < 0.0)
					this.scaleZ = 1.0;
				else
					this.scaleZ = value;
			}
		}

		static TView()
		{
			TView.rQFoIpIoe9 = (TMat3x3)new TMat3x3Diagonal(1.0, -1.0, 1.0);
			TView.miCoqACXHl = (TMat3x3)new TExchangeYZ();
			TView.R8ootJZDc1 = TView.rQFoIpIoe9 * TView.miCoqACXHl;
		}

		public TView()
		{
			this.Light = new TLight();
			this.scaleZ = 1.0;
			this.SetProjectionSpecial(-2.0, Math.PI / 6.0);
		}

		public static TView View(Pad pad)
		{
			if (pad.View3D == null)
				pad.View3D = new TView();
			return (TView)pad.View3D;
		}

		public void SetProjectionOrthogonal(double AngleXY, double ViewAngle)
		{
			this.QaLoUk71gW = (TMat3x3)new TRotZ(AngleXY);
			this.QaLoUk71gW = (TMat3x3)new TRotX(ViewAngle) * this.QaLoUk71gW;
			this.E6Oo4awtTa = TView.R8ootJZDc1 * this.QaLoUk71gW;
		}

		public void SetProjectionSpecial(double AngleXY, double ViewAngle)
		{
			this.QaLoUk71gW = (TMat3x3)new TRotZ(AngleXY);
			this.QaLoUk71gW = (TMat3x3)new TSpecialProjection(ViewAngle) * this.QaLoUk71gW;
			this.E6Oo4awtTa = TView.R8ootJZDc1 * this.QaLoUk71gW;
		}

		public void CalculateAxes(Pad Pad, int Left, int Top, int H)
		{
			this.left = Left;
			this.top = Top;
			this.h = H;
			this.mWHorsKIXa = new TVec3((double)(Left + H / 2), (double)(Top + 3 * H / 4), 0.0);
			if (this.ScaleZ < 1.0)
				this.mWHorsKIXa.y -= (1.0 - this.ScaleZ) * 0.25 * (double)H;
			double num = 0.7 * (double)H;
			double Z = 0.5 * this.ScaleZ * (double)H;
			this.lx = new TVec3(num, 0.0, 0.0);
			this.ly = new TVec3(0.0, num, 0.0);
			this.lz = new TVec3(0.0, 0.0, Z);
			this.lx = this.E6Oo4awtTa * this.Lx;
			this.ly = this.E6Oo4awtTa * this.Ly;
			this.lz = this.E6Oo4awtTa * this.Lz;
		}

		private static void lF6ovwu8P3([In] Pad obj0)
		{
			if (obj0.Grid3D)
			{
				foreach (Axis axis in obj0.Axes3D)
					axis.GridEnabled = true;
			}
			else
			{
				foreach (Axis axis in obj0.Axes3D)
					axis.GridEnabled = false;
			}
		}

		public void PaintAxisGridAndTicks(Graphics g, Axis a, bool Marks, TVec3 o, TVec3 o_, TVec3 L)
		{
			a.MinorGridEnabled = false;
			a.MinorTicksEnabled = false;
			int nTicks = (int)(L.NormInf / 10.0);
			if (nTicks < 3)
				nTicks = 3;
			if (nTicks > 10)
				nTicks = 10;
			TAxisCalc taxisCalc = new TAxisCalc(o, o + L, a.Min, a.Max, nTicks);
			TVec3 tvec3_1 = o_ - o;
			TVec3 tvec3_2 = TVec3.O;
			TVec3 tvec3_3 = -0.04 * tvec3_1;
			if (o_.y > o.y)
			{
				tvec3_2 = tvec3_1;
				tvec3_3 = -tvec3_3;
			}
			TVec3 tvec3_4 = tvec3_2 + 1.04 * tvec3_3;
			if (a.GridEnabled)
			{
				Pen pen = new Pen(a.GridColor, a.GridWidth);
				for (int i = 0; i < taxisCalc.nTicks; ++i)
					g.DrawLine(pen, (Point)taxisCalc.TickPos(i), (Point)(taxisCalc.TickPos(i) + tvec3_1));
			}
			if (a.Position == EAxisPosition.Right && tvec3_3.x <= 0.0)
				Marks = false;
			if (!Marks)
				return;
			int num1 = a.Position == EAxisPosition.Bottom ? 0 : 1;
			int num2 = a.Position == EAxisPosition.Bottom ? taxisCalc.nTicks - 1 : taxisCalc.nTicks;
			float num3 = 0.0f;
			if (a.MajorTicksEnabled)
			{
				Pen pen = new Pen(a.GridColor, a.GridWidth);
				for (int i = num1; i < num2; ++i)
					g.DrawLine(pen, (Point)(taxisCalc.TickPos(i) + tvec3_2), (Point)(taxisCalc.TickPos(i) + tvec3_2 + tvec3_3));
			}
			if (a.LabelEnabled)
			{
				Font labelFont = a.LabelFont;
				float height = labelFont.GetHeight(g);
				SolidBrush solidBrush = new SolidBrush(a.LabelColor);
				StringFormat format = new StringFormat();
				float num4;
				if (a.Position == EAxisPosition.Bottom)
				{
					format.FormatFlags = StringFormatFlags.DirectionVertical;
					num4 = (float)Math.Abs(taxisCalc.TickPos(1).x - taxisCalc.TickPos(0).x);
				}
				else
				{
					tvec3_4.y -= 0.5 * (double)a.LabelFont.GetHeight();
					num4 = (float)Math.Abs(taxisCalc.TickPos(1).y - taxisCalc.TickPos(0).y);
				}
				if (tvec3_3.x < 0.0)
					tvec3_4.x -= (double)a.LabelFont.GetHeight();
				if ((double)num4 > 0.0)
				{
					int num5 = (int)((double)height / (double)num4 + 1.0);
					if (num1 + num5 < num2)
					{
						int i = num1;
						while (i < num2)
						{
							if (i + num5 >= num2)
								i = num2 - 1;
							TVec3 tvec3_5 = taxisCalc.TickPos(i) + tvec3_4;
							string str = taxisCalc.TickVal(i).ToString();
							g.DrawString(str, labelFont, (Brush)solidBrush, (PointF)tvec3_5, format);
							SizeF sizeF = g.MeasureString(str, labelFont);
							if ((double)sizeF.Width > (double)num3)
								num3 = sizeF.Width;
							i += num5;
						}
					}
					else if (num2 > 0)
					{
						int i = num2 - 1;
						TVec3 tvec3_5 = taxisCalc.TickPos(i) + tvec3_4;
						string str = taxisCalc.TickVal(i).ToString();
						g.DrawString(str, labelFont, (Brush)solidBrush, (PointF)tvec3_5, format);
						num3 = g.MeasureString(str, labelFont).Width;
					}
				}
			}
			if (!a.TitleEnabled)
				return;
			SizeF sizeF1 = g.MeasureString(a.Title, a.TitleFont);
			PointF point1;
			PointF point2;
			float angle;
			if (a.Position == EAxisPosition.Bottom)
			{
				if (tvec3_3.x < 0.0)
				{
					point1 = taxisCalc.TickPos(0).x > taxisCalc.TickPos(1).x ? (PointF)(taxisCalc.TickPos(taxisCalc.nTicks - 1) + tvec3_4) : (PointF)(taxisCalc.TickPos(0) + tvec3_4);
					point1.Y += num3;
					point2 = point1;
					angle = (float)(Math.Atan2(Math.Abs(L.y), Math.Abs(L.x)) * 180.0 / Math.PI);
				}
				else
				{
					point1 = taxisCalc.TickPos(0).x > taxisCalc.TickPos(1).x ? (PointF)(taxisCalc.TickPos(0) + tvec3_4) : (PointF)(taxisCalc.TickPos(taxisCalc.nTicks - 1) + tvec3_4);
					point1.X += a.LabelFont.GetHeight(g);
					point1.Y += num3;
					point2 = point1;
					point2.X -= sizeF1.Width;
					angle = (float)(-Math.Atan2(Math.Abs(L.y), Math.Abs(L.x)) * 180.0 / Math.PI);
				}
			}
			else
			{
				point1 = taxisCalc.TickPos(0).z > taxisCalc.TickPos(1).z ? (PointF)(taxisCalc.TickPos(0) + tvec3_4) : (PointF)(taxisCalc.TickPos(taxisCalc.nTicks - 1) + tvec3_4);
				point1.X += num3;
				point2 = point1;
				point2.X -= sizeF1.Width;
				angle = -90f;
			}
			Matrix matrix = new Matrix();
			matrix.RotateAt(angle, point1, MatrixOrder.Append);
			g.Transform = matrix;
			g.DrawString(a.Title, a.LabelFont, (Brush)new SolidBrush(a.LabelColor), point2);
			matrix.Reset();
			g.Transform = matrix;
		}

		public void PaintAxes(Graphics g, Pad Pad, int Left, int Top, int H)
		{
			Graphics graphics = Pad.Graphics;
			int x1 = Pad.X1;
			int x2 = Pad.X2;
			int y1 = Pad.Y1;
			int y2 = Pad.Y2;
			Pad.Graphics = g;
			Pad.X1 = Left;
			Pad.X2 = Left + H;
			Pad.Y1 = Top;
			Pad.Y2 = Top + H;
			this.PaintAxes(Pad, Left, Top, H);
			Pad.Graphics = graphics;
			Pad.X1 = x1;
			Pad.X2 = x2;
			Pad.Y1 = y1;
			Pad.Y2 = y2;
		}

		public void PaintAxes(Pad Pad, int Left, int Top, int H)
		{
			this.CalculateAxes(Pad, Left, Top, H);
			TVec3[] v = new TVec3[4]
			{
				this.o - 0.5 * this.Lx - 0.5 * this.Ly,
				this.o + 0.5 * this.Lx - 0.5 * this.Ly,
				this.o + 0.5 * this.Lx + 0.5 * this.Ly,
				this.o - 0.5 * this.Lx + 0.5 * this.Ly
			};
			double num1 = -1.0;
			int num2 = -1;
			for (int index = 0; index < v.Length; ++index)
			{
				if (v[index].y > num1)
				{
					num1 = v[index].y;
					num2 = index;
				}
			}
			int index1 = 0;
			int index2 = 0;
			int index3 = 0;
			switch (num2)
			{
				case 0:
					index1 = 1;
					index2 = 2;
					index3 = 3;
					break;
				case 1:
					index1 = 2;
					index2 = 3;
					index3 = 0;
					break;
				case 2:
					index1 = 3;
					index2 = 0;
					index3 = 1;
					break;
				case 3:
					index1 = 0;
					index2 = 1;
					index3 = 2;
					break;
			}
			Point[] points1 = TVec3.PointArray(v);
			Point[] points2 = new Point[4]
			{
				(Point)v[index1],
				(Point)v[index2],
				(Point)(v[index2] + this.Lz),
				(Point)(v[index1] + this.Lz)
			};
			Point[] points3 = new Point[4]
			{
				(Point)v[index2],
				(Point)v[index3],
				(Point)(v[index3] + this.Lz),
				(Point)(v[index2] + this.Lz)
			};
			Graphics graphics = Pad.Graphics;
			graphics.Clip = new Region(new Rectangle(Pad.X1, Pad.Y1, Pad.Width + 1, Pad.Height + 1));
			Pen pen = new Pen(Color.Black, 1f);
			Brush brush = (Brush)new SolidBrush(Color.White);
			graphics.FillPolygon(brush, points1);
			graphics.FillPolygon(brush, points2);
			graphics.FillPolygon(brush, points3);
			graphics.DrawPolygon(pen, points1);
			graphics.DrawPolygon(pen, points2);
			graphics.DrawPolygon(pen, points3);
			TView.lF6ovwu8P3(Pad);
			Pad.AxisX3D.Position = EAxisPosition.Bottom;
			Pad.AxisY3D.Position = EAxisPosition.Bottom;
			Pad.AxisZ3D.Position = EAxisPosition.Right;
			this.PaintAxisGridAndTicks(graphics, Pad.AxisX3D, true, v[0], v[0] + this.Ly, this.Lx);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisY3D, true, v[0], v[0] + this.Lx, this.Ly);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisX3D, false, v[index2], v[index2] + this.Lz, this.Lx);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisY3D, false, v[index2], v[index2] + this.Lz, this.Ly);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisZ3D, true, v[index2], v[index2] + this.Lx, this.Lz);
			this.PaintAxisGridAndTicks(graphics, Pad.AxisZ3D, true, v[index2], v[index2] + this.Ly, this.Lz);
		}
	}
}
