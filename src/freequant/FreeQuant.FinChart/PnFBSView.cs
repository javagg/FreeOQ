using FreeQuant.Data;
using FreeQuant.Indicators;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.FinChart
{
	public class PnFBSView : SeriesView
	{
		private BarSeries barSeries; 
		private Color upColor;
		private Color downColor;
		private Color gKtJiYQi50;
		private PointAndFigure pGlJXklPGE;

		[Category("Color scheme")]
		public Color UpColor
		{
			get
			{
				return this.upColor; 
			}
			set
			{
				this.upColor = value;
			}
		}

		[Category("Color scheme")]
		public Color DownColor
		{
			get
			{
				return this.downColor; 
			}
			set
			{
				this.downColor = value;
			}
		}

		[Category("Color scheme")]
		public override Color Color
		{
			get
			{
				if (this.pGlJXklPGE[this.lastDate].Open > this.pGlJXklPGE[this.lastDate].Close)
					return this.upColor;
				else
					return this.downColor;
			}
			set
			{
				this.gKtJiYQi50 = value;
			}
		}

		public override double LastValue
		{
			get
			{
				if (this.lastDate == this.pGlJXklPGE.LastDateTime)
					return this.barSeries.Last.Close;
				else
					return this.barSeries[this.lastDate, EIndexOption.Prev].Close;
			}
		}

		public override TimeSeries MainSeries
		{
			get
			{
				return this.pGlJXklPGE;
			}
		}

		public PnFBSView(Pad pad, BarSeries series, double boxSize, int reversalAmount) : base(pad)
		{
			this.upColor = Color.OrangeRed;
			this.downColor = Color.LawnGreen;
			this.gKtJiYQi50 = Color.FromArgb(0, (int)byte.MaxValue, 0);
			this.barSeries = series;
			this.pad = pad;
			this.ToolTipFormat = "";
			this.pGlJXklPGE = new PointAndFigure(series, boxSize, reversalAmount);
			this.pGlJXklPGE.Calculate();
		}

		public override PadRange GetPadRangeY(Pad Pad)
		{
			return new PadRange(this.pGlJXklPGE.LowestLow(this.firstDate, this.lastDate), this.pGlJXklPGE.HighestHigh(this.firstDate, this.lastDate));
		}

		public void Calculate()
		{
			this.pGlJXklPGE.Calculate();
		}

		public override void Paint()
		{
			Pen pen1 = new Pen(this.upColor);
			Pen pen2 = new Pen(this.downColor);
			int index1 = this.pGlJXklPGE.GetIndex(this.firstDate);
			int index2 = this.pGlJXklPGE.GetIndex(this.lastDate);
			if (index2 == -1 || index2 == -1)
				return;
			int width = Math.Max(2, (int)this.pad.IntervalWidth);
			for (int index3 = index1; index3 <= index2; ++index3)
			{
				int num = this.pad.ClientX(this.pGlJXklPGE.GetDateTime(index3));
				PnF pnF = this.pGlJXklPGE[index3];
				double low = pnF.Low;
				while (low < pnF.High)
				{
					if (pnF.Kind == PnFKind.Down)
					{
						this.pad.Graphics.DrawEllipse(pen1, num - width / 2, this.pad.ClientY(low), width, this.pad.ClientY(low + pnF.BoxSize) - this.pad.ClientY(low));
					}
					else
					{
						this.pad.Graphics.DrawLine(pen2, num - width / 2, this.pad.ClientY(low), num + width / 2, this.pad.ClientY(low + pnF.BoxSize));
						this.pad.Graphics.DrawLine(pen2, num + width / 2, this.pad.ClientY(low), num - width / 2, this.pad.ClientY(low + pnF.BoxSize));
					}
					low += pnF.BoxSize;
				}
			}
		}

		public override Distance Distance(int x, double y)
		{
			Distance distance = new Distance();
			PnF pnF = this.pGlJXklPGE[this.pad.GetDateTime(x)];
			distance.DX = 0.0;
			if (y >= pnF.Low && y <= pnF.High)
				distance.DY = 0.0;
			if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
				return (Distance)null;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(this.ToolTipFormat, this.barSeries.Name, this.barSeries.Title, (object)pnF.DateTime.ToString(this.barSeries.ToolTipDateTimeFormat), (object)pnF.High, (object)pnF.Low, (object)pnF.Open, (object)pnF.Close, (object)pnF.Volume);
			distance.ToolTipText = stringBuilder.ToString();
			return distance;
		}
	}
}
