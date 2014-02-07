using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace FreeQuant.FinChart
{
	public class SimpleBSView : SeriesView
	{
		private BarSeries barSeries;

		[Category("Drawing Style")]
		public Color UpColor { get; set; }

		[Category("Drawing Style")]
		public Color DownColor { get; set; }

		public SimpleBSStyle Style { get; set; }

		public override TimeSeries MainSeries
		{
			get
			{
				return this.barSeries;
			}
		}

		[Browsable(false)]
		public override Color Color
		{
			get
			{
				return this.DownColor;
			}
			set
			{
			}
		}

		public override double LastValue
		{
			get
			{
				return this.barSeries[this.lastDate, EIndexOption.Prev].Close;
			}
		}

		public SimpleBSView(Pad pad, BarSeries series) : base(pad)
		{
			this.UpColor = Color.Black;
			this.DownColor = Color.Lime;
			this.barSeries = series;
		}

		public override PadRange GetPadRangeY(Pad Pad)
		{
			double min = this.barSeries.LowestLow(this.firstDate, this.lastDate);
			double max = this.barSeries.HighestHigh(this.firstDate, this.lastDate);
			if (min >= max)
			{
				double num = min / 10.0;
				min -= num;
				max += num;
			}
			return new PadRange(min, max);
		}

		public override void Paint()
		{
			Color color = this.DownColor;
			Pen pen1 = new Pen(color);
			Pen pen2 = new Pen(color);
			Pen pen3 = new Pen(color);
			Brush brush1 = new SolidBrush(this.DownColor);
			Brush brush2 = new SolidBrush(this.UpColor);
			long num1 = -1L;
			long num2 = -1L;
			int index1 = this.barSeries.GetIndex(this.firstDate);
			int index2 = this.barSeries.GetIndex(this.lastDate);
			if (index1 == -1 || index2 == -1)
				return;
			int width = (int)Math.Max(2.0, (double)(int)this.pad.IntervalWidth / 1.4);
			int num3 = 0;
			for (int index3 = index1; index3 <= index2; ++index3)
			{
				int num4 = this.pad.ClientX(this.barSeries.GetDateTime(index3));
				Bar bar = this.barSeries[index3];
				double high = bar.High;
				double low = bar.Low;
				double open = bar.Open;
				double close = bar.Close;
				if (this.Style == SimpleBSStyle.Candle)
				{
					this.pad.Graphics.DrawLine(pen1, num4, this.pad.ClientY(low), num4, this.pad.ClientY(high));
					if (open != 0.0 && close != 0.0)
					{
						if (open > close)
						{
							int height = this.pad.ClientY(close) - this.pad.ClientY(open);
							if (height == 0)
								height = 1;
							this.pad.Graphics.FillRectangle(brush1, num4 - width / 2, this.pad.ClientY(open), width, height);
						}
						else
						{
							int height = this.pad.ClientY(open) - this.pad.ClientY(close);
							if (height == 0)
								height = 1;
							this.pad.Graphics.DrawRectangle(pen1, num4 - width / 2, this.pad.ClientY(close), width, height);
							this.pad.Graphics.FillRectangle(brush2, num4 - width / 2 + 1, this.pad.ClientY(close) + 1, width - 1, height - 1);
						}
					}
				}
				if (this.Style == SimpleBSStyle.Bar)
				{
					this.pad.Graphics.DrawLine(pen1, num4, this.pad.ClientY(low), num4, this.pad.ClientY(high));
					this.pad.Graphics.DrawLine(pen1, num4 - width / 2, this.pad.ClientY(open), num4, this.pad.ClientY(open));
					this.pad.Graphics.DrawLine(pen1, num4 + width / 2, this.pad.ClientY(close), num4, this.pad.ClientY(close));
				}
				if (this.Style == SimpleBSStyle.Line)
				{
					long num5 = (long)num4;
					int num6 = this.pad.ClientY(bar.Close);
					if (num1 != -1L && num2 != -1L)
						this.pad.Graphics.DrawLine(pen1, (float)num5, (float)num6, (float)num1, (float)num2);
					num1 = num5;
					num2 = (long)num6;
					++num3;
				}
			}
		}

		public override Distance Distance(int x, double y)
		{
			Distance distance = new Distance();
			Bar bar = this.barSeries[this.pad.GetDateTime(x)];
			distance.DX = 0.0;
			if (y >= bar.Low && y <= bar.High)
				distance.DY = 0.0;
			if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
				return null;
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat(this.toolTipFormat, new object[]
			{
				this.barSeries.Name,
				this.barSeries.Title,
				bar.DateTime,
				bar.High,
				bar.Low,
				bar.Open,
				bar.Close,
				bar.Volume
			});
			distance.ToolTipText = sb.ToString();

			return distance;
		}
	}
}
