using FreeQuant.Charting;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting.Draw3D
{
	public abstract class TFunction
	{
		protected double MinX;
		protected double MaxX;
		protected double MinY;
		protected double MaxY;
		protected int nx;
		protected int ny;
		public EChartLook Look;
		public TSurface Surface;
		public bool Grid;
		public bool LevelLines;
		private TLight trP3fdnMpS;
		private int FP43FHdtWy;
		private int uq63OYZaax;
		private int Jm23JdRAV2;
		private int C843M1JDuK;
		private TVec3 Sp23PRDLnW;
		private TVec3 tn83Ged55u;
		private TVec3 PqY3RZfYIU;
		private TVec3 gcU3NtonPe;
		private bool hH1321Stt8;

		public TFunction()
		{
			this.MaxX = 1.0;
			this.MaxY = 1.0;
			this.Surface = new TSurface();
			this.hH1321Stt8 = true;
			this.Surface.Diffuse = 0.59 * new TColor(0.5, 0.7, 1.0);
		}

		public abstract double f(double x, double y);

		public virtual TColor color0(double x, double y)
		{
			return this.Surface.Diffuse;
		}

		public unsafe void Paint(Pad pad)
		{
			TView tview = TView.View(pad);
			this.uq63OYZaax = tview.Left;
			this.FP43FHdtWy = tview.Top;
			this.Jm23JdRAV2 = tview.H;
			this.C843M1JDuK = tview.H;
			this.Sp23PRDLnW = tview.o - new TVec3((double)this.uq63OYZaax, (double)this.FP43FHdtWy, 0.0);
			this.tn83Ged55u = tview.Lx;
			this.PqY3RZfYIU = tview.Ly;
			this.gcU3NtonPe = tview.Lz;
			this.trP3fdnMpS = tview.Light;
			if (this.Look == EChartLook.SurfaceOnly)
				this.hH1321Stt8 = false;
			Bitmap bitmap = new Bitmap(this.Jm23JdRAV2, this.C843M1JDuK, PixelFormat.Format32bppRgb);
			this.qDx3lDiW7U(pad, bitmap);
			Rectangle rect = new Rectangle(0, 0, this.Jm23JdRAV2, this.C843M1JDuK);
			BitmapData bitmapdata = bitmap.LockBits(rect, this.hH1321Stt8 ? ImageLockMode.WriteOnly : ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
			this.Pnx3KTVZoc((int*)bitmapdata.Scan0.ToPointer());
			bitmap.UnlockBits(bitmapdata);
			Color transparentColor = Color.FromArgb((int)byte.MaxValue, 0, 0, 0);
			bitmap.MakeTransparent(transparentColor);
			pad.Graphics.DrawImage((Image)bitmap, this.uq63OYZaax, this.FP43FHdtWy);
		}

		private TColor E0C3BMxUWS(double obj0, double obj1, double obj2, double obj3, TColor obj4)
		{
			TVec3 n = new TVec3(obj2, 0.0, this.f(obj0 + obj2, obj1) - this.f(obj0, obj1)) ^ new TVec3(0.0, obj3, this.f(obj0, obj1 + obj3) - this.f(obj0, obj1));
			return this.trP3fdnMpS.Result(new TVec3(obj0, obj1, this.f(obj0, obj1)), n, obj4);
		}

		private void qDx3lDiW7U([In] Pad obj0, [In] Bitmap obj1)
		{
			if (this.Look != EChartLook.SurfaceOnly)
				return;
			Graphics g = Graphics.FromImage((Image)obj1);
			TView.View(obj0).PaintAxes(g, obj0, 0, 0, this.C843M1JDuK);
		}

		private unsafe void Pnx3KTVZoc([In] int* obj0)
		{
			int[,] numArray = new int[this.Jm23JdRAV2, this.C843M1JDuK];
			if (!this.hH1321Stt8)
			{
				int* numPtr = obj0;
				for (int index1 = 0; index1 < this.C843M1JDuK; ++index1)
				{
					for (int index2 = 0; index2 < this.Jm23JdRAV2; ++index2)
						numArray[index2, index1] = *numPtr++;
				}
			}
			double normInf1 = this.tn83Ged55u.NormInf;
			double normInf2 = this.PqY3RZfYIU.NormInf;
			TVec3 Origin = this.Sp23PRDLnW - 0.5 * this.tn83Ged55u - 0.5 * this.PqY3RZfYIU;
			TVec3 tvec3_1 = this.tn83Ged55u / normInf1;
			TVec3 tvec3_2 = this.PqY3RZfYIU / normInf2;
			double num1 = (this.MaxX - this.MinX) / normInf1;
			double num2 = (this.MaxY - this.MinY) / normInf2;
			double num3 = num1;
			double num4 = num2;
			if ((double)(2 * this.nx) >= normInf1 && (double)(2 * this.ny) >= normInf2)
			{
				num3 = (this.MaxX - this.MinX) / (double)this.nx;
				num4 = (this.MaxY - this.MinY) / (double)this.ny;
			}
			double ValO1 = this.MinX + 0.01 * num3;
			double ValO2 = this.MinY + 0.01 * num4;
			TVec3 tvec3_3 = this.tn83Ged55u;
			TVec3 tvec3_4 = this.PqY3RZfYIU;
			if (this.tn83Ged55u.z > 0.0)
			{
				ValO1 = this.MaxX - 0.99 * num3;
				num1 = -num1;
				num3 = -num3;
				Origin += this.tn83Ged55u;
				tvec3_3 = -this.tn83Ged55u;
				tvec3_1 = -tvec3_1;
			}
			if (this.PqY3RZfYIU.z > 0.0)
			{
				ValO2 = this.MaxY - 0.99 * num4;
				num2 = -num2;
				num4 = -num4;
				Origin += this.PqY3RZfYIU;
				tvec3_4 = -this.PqY3RZfYIU;
				tvec3_2 = -tvec3_2;
			}
			int num5 = (int)normInf1;
			int num6 = (int)normInf2;
			int num7 = (int)this.gcU3NtonPe.NormInf;
			bool[] flagArray1 = new bool[num5 + 2];
			bool[] flagArray2 = new bool[num6 + 2];
			bool[] flagArray3 = new bool[num7 + 2];
			if (this.Grid)
			{
				TAxisCalc taxisCalc1 = new TAxisCalc(Origin, Origin + tvec3_3, ValO1, ValO1 + normInf1 * num1, 10);
				TAxisCalc taxisCalc2 = new TAxisCalc(Origin, Origin + tvec3_4, ValO2, ValO2 + normInf2 * num2, 10);
				double Val1 = ValO1;
				int index1 = 0;
				while (index1 <= num5)
				{
					if (taxisCalc1.TickPassed(Val1))
						flagArray1[index1] = true;
					++index1;
					Val1 += num1;
				}
				double Val2 = ValO2;
				int index2 = 0;
				while (index2 <= num6)
				{
					if (taxisCalc2.TickPassed(Val2))
						flagArray2[index2] = true;
					++index2;
					Val2 += num2;
				}
			}
			if (this.LevelLines)
			{
				for (int index = 0; index < num7; ++index)
					flagArray3[index] = (index & 4) != 0;
			}
			switch (this.Look)
			{
				case EChartLook.FromZeroToSurface:
					double x1 = ValO1;
					int index3 = 0;
					while (index3 <= num5)
					{
						bool flag = flagArray1[index3];
						TVec3 tvec3_5 = Origin;
						double y = ValO2;
						int index1 = 0;
						while (index1 <= num6)
						{
							double num8 = this.f(x1, y);
							if (num8 > 0.0)
							{
								int num9 = (int)tvec3_5.y;
								int num10 = (int)(tvec3_5.y - num8);
								if (num10 < 0)
									num10 = 0;
								TColor tcolor1 = this.color0(x1, y);
								if (this.Grid && (flag || flagArray2[index1]))
									tcolor1 = this.Surface.GridDiffuse;
								TColor tcolor2 = this.E0C3BMxUWS(x1, y, num3, num4, tcolor1);
								tcolor2.Clip();
								int num11 = tcolor2.Get888();
								int index2 = (int)tvec3_5.x;
								if (this.LevelLines)
								{
									TColor tcolor3 = 0.81 * tcolor2;
									tcolor3.Clip();
									int num12 = tcolor3.Get888();
									for (int index4 = num9; index4 >= num10; --index4)
										numArray[index2, index4] = flagArray3[num9 - index4] ? num12 : num11;
								}
								else
								{
									for (int index4 = num9; index4 >= num10; --index4)
										numArray[index2, index4] = num11;
								}
							}
							++index1;
							y += num2;
							tvec3_5 += tvec3_2;
						}
						++index3;
						x1 += num1;
						Origin += tvec3_1;
					}
					break;
				case EChartLook.SurfaceOnly:
					double x2 = ValO1;
					int index5 = 0;
					while (index5 < num5)
					{
						bool flag = flagArray1[index5];
						TVec3 tvec3_5 = Origin;
						double y = ValO2;
						int index1 = 0;
						while (index1 < num6)
						{
							double num8 = this.f(x2, y);
							double num9 = this.f(x2 + num1, y);
							double num10 = this.f(x2, y + num2);
							double num11 = this.f(x2 + num1, y + num2);
							double num12 = num8;
							double num13 = num8;
							if (num9 < num12)
								num12 = num9;
							if (num10 < num12)
								num12 = num10;
							if (num11 < num12)
								num12 = num11;
							if (num9 > num13)
								num13 = num9;
							if (num10 > num13)
								num13 = num10;
							if (num11 > num13)
								num13 = num11;
							int num14 = (int)tvec3_5.y;
							int num15 = (int)(tvec3_5.y - num12 + 1.0);
							int num16 = (int)(tvec3_5.y - num13);
							if (num15 < this.C843M1JDuK && num15 >= 0 && (num16 < this.C843M1JDuK && num16 >= 0))
							{
								TColor tcolor1 = this.color0(x2, y);
								if (this.Grid && (flag || flagArray2[index1]))
									tcolor1 = this.Surface.GridDiffuse;
								TColor tcolor2 = this.E0C3BMxUWS(x2, y, num3, num4, tcolor1);
								tcolor2.Clip();
								int num17 = tcolor2.Get888();
								int index2 = (int)tvec3_5.x;
								if (this.LevelLines)
								{
									TColor tcolor3 = 0.81 * tcolor2;
									tcolor3.Clip();
									int num18 = tcolor3.Get888();
									for (int index4 = num15; index4 >= num16; --index4)
									{
										if (num12 > 0.0 || numArray[index2, index4] >= 0 || numArray[index2, index4] == -1)
											numArray[index2, index4] = (num14 - index4 & 4) != 0 ? num18 : num17;
									}
								}
								else
								{
									for (int index4 = num15; index4 >= num16; --index4)
									{
										if (num12 > 0.0 || numArray[index2, index4] >= 0 || numArray[index2, index4] == -1)
											numArray[index2, index4] = num17;
									}
								}
							}
							++index1;
							y += num2;
							tvec3_5 += tvec3_2;
						}
						++index5;
						x2 += num1;
						Origin += tvec3_1;
					}
					break;
			}
			for (int index1 = 0; index1 < this.C843M1JDuK; ++index1)
			{
				for (int index2 = 0; index2 < this.Jm23JdRAV2; ++index2)
					*obj0++ = numArray[index2, index1];
			}
		}
	}
}
