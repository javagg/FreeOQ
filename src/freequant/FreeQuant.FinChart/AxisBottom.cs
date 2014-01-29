using FreeQuant.Series;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace FreeQuant.FinChart
{
	public class AxisBottom : Axis
	{
		protected double x1;
		protected double x2;
		protected double y;

		public double X1
		{
			get
			{
				return this.x1;
			}
			set
			{
				this.x1 = value;
			}
		}

		public double X2
		{
			get
			{
				return this.x2;
			}
			set
			{
				this.x2 = value;
			}
		}

		public double Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		public AxisBottom(Chart chart, int x1, int x2, int y) : base()
		{
			this.chart = chart;
			this.x1 = x1;
			this.x2 = x2;
			this.y = y;
			this.Init();
		}

		private void Init()
		{
			this.enabled = true;
			this.zoomed = false;
			this.color = Color.LightGray;
			this.title = "";
			this.titleEnabled = true;
			this.titlePosition = EAxisTitlePosition.Centre;
			this.titleFont = this.chart.Font;
			this.titleColor = Color.Black;
			this.titleOffset = 2;
			this.labelEnabled = true;
			this.labelFont = this.chart.Font;
			this.labelColor = Color.LightGray;
			this.labelFormat = null;
			this.labelOffset = 2;
			this.labelAlignment = EAxisLabelAlignment.Centre;
			this.gridEnabled = true;
			this.gridColor = Color.LightGray;
			this.gridDashStyle = DashStyle.DashDotDot;
			this.gridWidth = 0.5f;
			this.minorGridEnabled = false;
			this.minorGridColor = Color.LightGray;
			this.minorGridDashStyle = DashStyle.Solid;
			this.minorGridWidth = 0.5f;
			this.majorTicksEnabled = true;
			this.majorTicksColor = Color.LightGray;
			this.majorTicksWidth = 0.5f;
			this.majorTicksLength = 4;
			this.minorTicksEnabled = true;
			this.minorTicksColor = Color.LightGray;
			this.minorTicksWidth = 0.5f;
			this.minorTicksLength = 1;
			this.width = -1;
			this.height = -1;
		}

		public void SetBounds(int x1, int x2, int y)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.y = y;
		}

		private long c9T0e1qB80([In] DateTime obj0, [In] EGridSize obj1)
		{
			long num;
			switch (obj1)
			{
				case EGridSize.year5:
					num = new DateTime(obj0.Year, 1, 1).AddYears(1 + (4 - obj0.Year % 5)).Ticks;
					break;
				case EGridSize.year10:
					num = new DateTime(obj0.Year, 1, 1).AddYears(1 + (9 - obj0.Year % 10)).Ticks;
					break;
				case EGridSize.year20:
					num = new DateTime(obj0.Year, 1, 1).AddYears(1 + (19 - obj0.Year % 20)).Ticks;
					break;
				case EGridSize.year3:
					num = new DateTime(obj0.Year, 1, 1).AddYears(1 + (2 - obj0.Year % 3)).Ticks;
					break;
				case EGridSize.year4:
					num = new DateTime(obj0.Year, 1, 1).AddYears(1 + (3 - obj0.Year % 4)).Ticks;
					break;
				case EGridSize.month6:
					DateTime dateTime1 = new DateTime(obj0.Year, obj0.Month, 1);
					dateTime1 = dateTime1.AddMonths(1 + (12 - obj0.Month) % 6);
					num = dateTime1.Ticks;
					break;
				case EGridSize.year1:
					num = new DateTime(obj0.Year, 1, 1).AddYears(1).Ticks;
					break;
				case EGridSize.year2:
					num = new DateTime(obj0.Year, 1, 1).AddYears(1 + (1 - obj0.Year % 2)).Ticks;
					break;
				case EGridSize.month3:
					DateTime dateTime2 = new DateTime(obj0.Year, obj0.Month, 1);
					dateTime2 = dateTime2.AddMonths(1 + (12 - obj0.Month) % 3);
					num = dateTime2.Ticks;
					break;
				case EGridSize.month4:
					DateTime dateTime3 = new DateTime(obj0.Year, obj0.Month, 1);
					dateTime3 = dateTime3.AddMonths(1 + (12 - obj0.Month) % 4);
					num = dateTime3.Ticks;
					break;
				case EGridSize.week2:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day).AddDays(8.0 - (double)obj0.DayOfWeek + (double)(7 * (1 - (int)Math.Floor(new TimeSpan(obj0.AddDays(8.0 - (double)obj0.DayOfWeek).Ticks).TotalDays) / 7 % 2))).Ticks;
					break;
				case EGridSize.month1:
					DateTime dateTime4 = new DateTime(obj0.Year, obj0.Month, 1);
					dateTime4 = dateTime4.AddMonths(1);
					num = dateTime4.Ticks;
					break;
				case EGridSize.month2:
					DateTime dateTime5 = new DateTime(obj0.Year, obj0.Month, 1);
					dateTime5 = dateTime5.AddMonths(1 + obj0.Month % 2);
					num = dateTime5.Ticks;
					break;
				case EGridSize.day5:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day).AddDays((double)(1 + (4 - (int)new TimeSpan(obj0.Ticks).TotalDays % 5))).Ticks;
					break;
				case EGridSize.week1:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day).AddDays(8.0 - (double)obj0.DayOfWeek).Ticks;
					break;
				case EGridSize.day2:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day).AddDays((double)(1 + (int)new TimeSpan(obj0.Ticks).TotalDays % 2)).Ticks;
					break;
				case EGridSize.day3:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day).AddDays((double)(1 + (2 - (int)new TimeSpan(obj0.Ticks).TotalDays % 3))).Ticks;
					break;
				case EGridSize.hour12:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, 0, 0).AddHours((double)(1 + (11 - (int)new TimeSpan(obj0.Ticks).TotalHours % 12))).Ticks;
					break;
				case EGridSize.day1:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day).AddDays(1.0).Ticks;
					break;
				case EGridSize.hour3:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, 0, 0).AddHours((double)(1 + (2 - (int)new TimeSpan(obj0.Ticks).TotalHours % 3))).Ticks;
					break;
				case EGridSize.hour4:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, 0, 0).AddHours((double)(1 + (3 - (int)new TimeSpan(obj0.Ticks).TotalHours % 4))).Ticks;
					break;
				case EGridSize.hour6:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, 0, 0).AddHours((double)(1 + (5 - (int)new TimeSpan(obj0.Ticks).TotalHours % 6))).Ticks;
					break;
				case EGridSize.hour1:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, 0, 0).AddHours(1.0).Ticks;
					break;
				case EGridSize.hour2:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, 0, 0).AddHours((double)(1 + (1 - (int)new TimeSpan(obj0.Ticks).TotalHours % 2))).Ticks;
					break;
				case EGridSize.min20:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, 0).AddMinutes((double)(1 + (19 - (int)new TimeSpan(obj0.Ticks).TotalMinutes % 20))).Ticks;
					break;
				case EGridSize.min30:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, 0).AddMinutes((double)(1 + (29 - (int)new TimeSpan(obj0.Ticks).TotalMinutes % 30))).Ticks;
					break;
				case EGridSize.min10:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, 0).AddMinutes((double)(1 + (9 - (int)new TimeSpan(obj0.Ticks).TotalMinutes % 10))).Ticks;
					break;
				case EGridSize.min15:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, 0).AddMinutes((double)(1 + (14 - (int)new TimeSpan(obj0.Ticks).TotalMinutes % 15))).Ticks;
					break;
				case EGridSize.min1:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, 0).AddMinutes(1.0).Ticks;
					break;
				case EGridSize.min2:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, 0).AddMinutes((double)(1 + (1 - (int)new TimeSpan(obj0.Ticks).TotalMinutes % 2))).Ticks;
					break;
				case EGridSize.min5:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, 0).AddMinutes((double)(1 + (4 - (int)new TimeSpan(obj0.Ticks).TotalMinutes % 5))).Ticks;
					break;
				case EGridSize.sec20:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, obj0.Second).AddSeconds((double)(1 + (19 - (int)new TimeSpan(obj0.Ticks).TotalSeconds % 20))).Ticks;
					break;
				case EGridSize.sec30:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, obj0.Second).AddSeconds((double)(1 + (29 - (int)new TimeSpan(obj0.Ticks).TotalSeconds % 30))).Ticks;
					break;
				case EGridSize.sec5:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, obj0.Second).AddSeconds((double)(1 + (4 - (int)new TimeSpan(obj0.Ticks).TotalSeconds % 5))).Ticks;
					break;
				case EGridSize.sec10:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, obj0.Second).AddSeconds((double)(1 + (9 - (int)new TimeSpan(obj0.Ticks).TotalSeconds % 10))).Ticks;
					break;
				case EGridSize.sec1:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, obj0.Second).AddSeconds(1.0).Ticks;
					break;
				case EGridSize.sec2:
					num = new DateTime(obj0.Year, obj0.Month, obj0.Day, obj0.Hour, obj0.Minute, obj0.Second).AddSeconds((double)(1 + (1 - (int)new TimeSpan(obj0.Ticks).TotalSeconds % 2))).Ticks;
					break;
				default:
					num = (long)(obj0.Ticks + obj1);
					break;
			}
			return num;
		}

		public void PaintWithDates(DateTime minDate, DateTime maxDate)
		{
			SolidBrush solidBrush1 = new SolidBrush(this.titleColor);
			SolidBrush solidBrush2 = new SolidBrush(this.labelColor);
			Pen pen1 = new Pen(this.titleColor);
			Pen pen2 = new Pen(this.gridColor);
			Pen pen3 = new Pen(this.minorGridColor);
			Pen pen4 = new Pen(this.minorTicksColor);
			Pen pen5 = new Pen(this.majorTicksColor);
			pen2.Width = this.gridWidth;
			pen2.DashStyle = this.gridDashStyle;
			pen3.Width = this.minorGridWidth;
			pen3.DashStyle = this.minorGridDashStyle;
			long ticks1 = minDate.Ticks;
			long ticks2 = maxDate.Ticks;
			DateTime dateTime1 = new DateTime(Math.Max(0, ticks1));
			EGridSize GridSize = AxisBottom.CalculateSize(ticks2 - ticks1);
			long num1 = 0L;
			long num2 = this.c9T0e1qB80(dateTime1, GridSize);
			int num3 = 0;
			long num4 = num2;
			long num5 = 0L;
			int num6 = 0;
			long num7 = ticks2;
			int num8 = -1;
			while (num4 < num7)
			{
				if (num6 != 0)
					num4 = AxisBottom.GetNextMajor(num5, GridSize);
				long num9 = num4;
				int index = this.chart.MainSeries.GetIndex(new DateTime(num4 - 1L), EIndexOption.Next);
				if (num8 == index)
				{
					num5 = num4;
				}
				else
				{
					num8 = index;
					if (index != -1)
					{
						DateTime dateTime2 = this.chart.MainSeries.GetDateTime(index);
						TimeSpan timeOfDay = dateTime2.TimeOfDay;
						long ticks3 = dateTime2.Ticks;
						if (ticks3 < num7)
						{
							if (this.gridEnabled)
								this.chart.IXrxgFKyT(pen2, ticks3);
							if (this.majorTicksEnabled)
								this.chart.NXKu7WiuX(pen1, ticks3, -5);
							if (this.labelEnabled)
							{
								string format;
								if (ticks3 % 864000000000L == this.chart.SessionStart.Ticks || ticks3 % 864000000000 == this.chart.SessionEnd.Ticks)
									format = num5 != 0 ? (new DateTime(num5).Year == new DateTime(ticks3).Year ? "years" : "month") : "days";
								else if (num5 == 0L)
								{
									format = "days";
								}
								else
								{
									DateTime dateTime3 = new DateTime(num5);
									DateTime dateTime4 = new DateTime(ticks3);
									format = dateTime3.Year == dateTime4.Year ? (dateTime3.Month == dateTime4.Month ? (dateTime3.Day == dateTime4.Day ? (dateTime3.Minute != dateTime4.Minute || dateTime3.Hour != dateTime4.Hour ? "hour" : "minute") : "second") : "aaaa") : "bbbb";
								}
								string str = new DateTime(ticks3).ToString(format);
								SizeF sizeF = this.chart.Graphics.MeasureString(str, this.labelFont);
								int num10 = (int)sizeF.Width;
								int num11 = (int)sizeF.Height;
								if (this.labelAlignment == EAxisLabelAlignment.Right)
									this.chart.Graphics.DrawString(str, this.labelFont, (Brush)solidBrush2, (float)this.chart.ClientX(new DateTime(ticks3)), (float)(int)(this.y + (double)this.labelOffset));
								if (this.labelAlignment == EAxisLabelAlignment.Left)
									this.chart.Graphics.DrawString(str, this.labelFont, (Brush)solidBrush2, (float)(this.chart.ClientX(new DateTime(ticks3)) - num10), (float)(int)(this.y + (double)this.labelOffset));
								if (this.labelAlignment == EAxisLabelAlignment.Centre)
								{
									int num12 = this.chart.ClientX(new DateTime(ticks3)) - num10 / 2;
									int num13 = (int)(this.y + (double)this.labelOffset);
									if (num6 == 0 || num12 - num3 >= 1)
									{
										this.chart.Graphics.DrawString(str, this.labelFont, (Brush)solidBrush2, (float)num12, (float)num13);
										num3 = num12 + num10;
									}
								}
							}
						}
						num1 = ticks3;
						num4 = num9;
						num5 = num4;
						++num6;
					}
				}
			}
			if (this.chart.SessionGridEnabled && (EGridSize)(this.chart.SessionEnd - this.chart.SessionStart).Ticks >= GridSize)
			{
				int num9 = 0;
				long num10;
				for (long index = ticks1 / 864000000000L * 864000000000L + this.chart.SessionStart.Ticks; (num10 = index + (long)num9 * 864000000000L) < ticks2; ++num9)
					this.chart.pw9AQjMR6(new Pen(this.chart.SessionGridColor), num10);
			}
			if (!this.titleEnabled)
				return;
			int num14 = (int)this.chart.Graphics.MeasureString("", this.labelFont).Height;
			int num15 = (int)this.chart.Graphics.MeasureString(ticks2.ToString("D"), this.labelFont).Width;
			double num16 = (double)this.chart.Graphics.MeasureString(this.title, this.titleFont).Height;
			int num17 = (int)this.chart.Graphics.MeasureString(this.title, this.titleFont).Width;
			if (this.titlePosition == EAxisTitlePosition.Left)
				this.chart.Graphics.DrawString(this.title, this.titleFont, (Brush)solidBrush1, (float)(int)this.x1, (float)(int)(this.y + (double)this.labelOffset + (double)num14 + (double)this.titleOffset));
			if (this.titlePosition == EAxisTitlePosition.Right)
				this.chart.Graphics.DrawString(this.title, this.titleFont, (Brush)solidBrush1, (float)((int)this.x2 - num17), (float)(int)(this.y + (double)this.labelOffset + (double)num14 + (double)this.titleOffset));
			if (this.titlePosition != EAxisTitlePosition.Centre)
				return;
			this.chart.Graphics.DrawString(this.title, this.titleFont, (Brush)solidBrush1, (float)(int)(this.x1 + (this.x2 - this.x1 - (double)num17) / 2.0), (float)(int)(this.y + (double)this.labelOffset + (double)num14 + (double)this.titleOffset));
		}

		public static EGridSize CalculateSize(double ticks)
		{
			int num1 = 7;
			int num2 = 3;
			double num3 = Math.Floor(ticks / 10000000.0);
			if (num3 >= (double)num2 && num3 <= (double)num1)
				return EGridSize.sec1;
			double num4 = num3 / 2.0;
			if (num4 >= (double)num2 && num4 <= (double)num1)
				return EGridSize.sec2;
			double num5 = num4 / 2.5;
			if (num5 >= (double)num2 && num5 <= (double)num1)
				return EGridSize.sec5;
			double num6 = num5 / 2.0;
			if (num6 >= (double)num2 && num6 <= (double)num1)
				return EGridSize.sec10;
			double num7 = num6 / 2.0;
			if (num7 >= (double)num2 && num7 <= (double)num1)
				return EGridSize.sec20;
			double num8 = num7 / 1.5;
			if (num8 >= (double)num2 && num8 <= (double)num1)
				return EGridSize.sec30;
			double num9 = num8 / 2.0;
			if (num9 >= (double)num2 && num9 <= (double)num1)
				return EGridSize.min1;
			double num10 = num9 / 2.0;
			if (num10 >= (double)num2 && num10 <= (double)num1)
				return EGridSize.min2;
			double num11 = num10 / 2.5;
			if (num11 >= (double)num2 && num11 <= (double)num1)
				return EGridSize.min5;
			double num12 = num11 / 2.0;
			if (num12 >= (double)num2 && num12 <= (double)num1)
				return EGridSize.min10;
			double num13 = num12 / 1.5;
			if (num13 >= (double)num2 && num13 <= (double)num1)
				return EGridSize.min15;
			double num14 = num13 / (4.0 / 3.0);
			if (num14 >= (double)num2 && num14 <= (double)num1)
				return EGridSize.min20;
			double num15 = num14 / 1.5;
			if (num15 >= (double)num2 && num15 <= (double)num1)
				return EGridSize.min30;
			double num16 = num15 / 2.0;
			if (num16 >= (double)num2 && num16 <= (double)num1)
				return EGridSize.hour1;
			double num17 = num16 / 2.0;
			if (num17 >= (double)num2 && num17 <= (double)num1)
				return EGridSize.hour2;
			double num18 = num17 / 1.5;
			if (num18 >= (double)num2 && num18 <= (double)num1)
				return EGridSize.hour3;
			double num19 = num18 / (4.0 / 3.0);
			if (num19 >= (double)num2 && num19 <= (double)num1)
				return EGridSize.hour4;
			double num20 = num19 / 1.5;
			if (num20 >= (double)num2 && num20 <= (double)num1)
				return EGridSize.hour6;
			double num21 = num20 / 2.0;
			if (num21 >= (double)num2 && num21 <= (double)num1)
				return EGridSize.hour12;
			double num22 = num21 / 2.0;
			if (num22 >= (double)num2 && num22 <= (double)num1)
				return EGridSize.day1;
			double num23 = num22 / 2.0;
			if (num23 >= (double)num2 && num23 <= (double)num1)
				return EGridSize.day2;
			double num24 = num23 / 1.5;
			if (num24 >= (double)num2 && num24 <= (double)num1)
				return EGridSize.day3;
			double num25 = num24 / (5.0 / 3.0);
			if (num25 >= (double)num2 && num25 <= (double)num1)
				return EGridSize.day5;
			double num26 = num25 / 1.4;
			if (num26 >= (double)num2 && num26 <= (double)num1)
				return EGridSize.week1;
			double num27 = num26 / 2.0;
			if (num27 >= (double)num2 && num27 <= (double)num1)
				return EGridSize.week2;
			double num28 = num27 / (15.0 / 7.0);
			if (num28 >= (double)num2 && num28 <= (double)num1)
				return EGridSize.month1;
			double num29 = num28 / 2.0;
			if (num29 >= (double)num2 && num29 <= (double)num1)
				return EGridSize.month2;
			double num30 = num29 / 1.5;
			if (num30 >= (double)num2 && num30 <= (double)num1)
				return EGridSize.month3;
			double num31 = num30 / (4.0 / 3.0);
			if (num31 >= (double)num2 && num31 <= (double)num1)
				return EGridSize.month4;
			double num32 = num31 / 1.5;
			if (num32 >= (double)num2 && num32 <= (double)num1)
				return EGridSize.month6;
			double num33 = num32 / 2.0;
			if (num33 >= (double)num2 && num33 <= (double)num1)
				return EGridSize.year1;
			double num34 = num33 / 2.0;
			if (num34 >= (double)num2 && num34 <= (double)num1)
				return EGridSize.year2;
			double num35 = num34 / 1.5;
			if (num35 >= (double)num2 && num35 <= (double)num1)
				return EGridSize.year3;
			double num36 = num35 / (4.0 / 3.0);
			if (num36 >= (double)num2 && num36 <= (double)num1)
				return EGridSize.year4;
			double num37 = num36 / 0.8;
			if (num37 >= (double)num2 && num37 <= (double)num1)
				return EGridSize.year5;
			double num38 = num37 / 2.0;
			if (num38 >= (double)num2 && num38 <= (double)num1)
				return EGridSize.year10;
			double num39 = num38 / 2.0;
			return num39 >= (double)num2 && num39 <= (double)num1 ? EGridSize.year20 : EGridSize.year20;
		}

		public static long GetNextMajor(long PrevMajor, EGridSize GridSize)
		{
			long num;
			switch (GridSize)
			{
				case EGridSize.year5:
					num = new DateTime(PrevMajor).AddYears(5).Ticks;
					break;
				case EGridSize.year10:
					num = new DateTime(PrevMajor).AddYears(10).Ticks;
					break;
				case EGridSize.year20:
					num = new DateTime(PrevMajor).AddYears(20).Ticks;
					break;
				case EGridSize.year2:
					num = new DateTime(PrevMajor).AddYears(2).Ticks;
					break;
				case EGridSize.year3:
					num = new DateTime(PrevMajor).AddYears(3).Ticks;
					break;
				case EGridSize.year4:
					num = new DateTime(PrevMajor).AddYears(4).Ticks;
					break;
				case EGridSize.month4:
					num = new DateTime(PrevMajor).AddMonths(4).Ticks;
					break;
				case EGridSize.month6:
					num = new DateTime(PrevMajor).AddMonths(6).Ticks;
					break;
				case EGridSize.year1:
					num = new DateTime(PrevMajor).AddYears(1).Ticks;
					break;
				case EGridSize.month1:
					num = new DateTime(PrevMajor).AddMonths(1).Ticks;
					break;
				case EGridSize.month2:
					num = new DateTime(PrevMajor).AddMonths(2).Ticks;
					break;
				case EGridSize.month3:
					num = new DateTime(PrevMajor).AddMonths(3).Ticks;
					break;
				default:
					num = (long)(PrevMajor + GridSize);
					break;
			}
			return num;
		}
	}
}
