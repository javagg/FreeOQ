using FreeQuant.Charting;
using FreeQuant.Data;
using System;
using System.Drawing;
using System.Text;

namespace FreeQuant.Series
{
	public class QuoteArray : DataArray, IDrawable, IZoomable
	{
		private bool toolTipEnabled;
		private string toolTipFormat;
		private string toolTipDateTimeFormat;
		private Color bidColor;
		private Color askColor;

		new public Quote this[int index]
		{
			get
			{
				return this.list[index] as Quote;
			}
		}

		public Color BidColor
		{
			get
			{
				return this.bidColor; 
			}
			set
			{
				this.bidColor = value;
			}
		}

		public Color AskColor
		{
			get
			{
				return this.askColor; 
			}
			set
			{
				this.askColor = value;
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

		public string ToolTipDateTimeFormat
		{
			get
			{
				return this.toolTipDateTimeFormat;  
			}
			set
			{
				this.toolTipDateTimeFormat = value;
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

		public QuoteArray() : base()
		{
			this.toolTipEnabled = true;
			this.toolTipFormat = "default format";
			this.bidColor = Color.Red;
			this.askColor = Color.Blue;
		}

		public void Paint(Pad pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			Pen pen1 = new Pen(this.askColor);
			Pen pen2 = new Pen(this.bidColor);
			int num1 = 0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			int x1_1 = 0;
			int x2_1 = 0;
			int y1_1 = 0;
			int y2_1 = 0;
			int y1_2 = 0;
			int y2_2 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			DateTime datetime1 = new DateTime((long)MinX);
			DateTime datetime2 = new DateTime((long)MaxX);
			int num11 = !(datetime1 < this.FirstDateTime) ? this.GetIndex(datetime1) : 0;
			int num12 = !(datetime2 > this.LastDateTime) ? this.GetIndex(datetime2) : this.Count - 1;
			if (num11 < 0 || num12 < 0)
				return;
			for (int index = num11; index <= num12; ++index)
			{
				Quote quote = this[index];
				double num13 = (double)quote.DateTime.Ticks;
				double ask = quote.Ask;
				double bid = quote.Bid;
				if (num1 != 0)
				{
					int x1_2 = pad.ClientX(num2);
					y1_1 = pad.ClientY(num3);
					int x2_2 = pad.ClientX(num13);
					y2_1 = pad.ClientY(ask);
					if (ask != 0.0 && num3 != 0.0 && (pad.IsInRange(num13, ask) || pad.IsInRange(num2, num3)) && (x1_2 != num5 || x2_2 != num6 || (y1_1 != num7 || y2_1 != num8)))
						pad.Graphics.DrawLine(pen1, x1_2, y1_1, x2_2, y2_1);
					x1_1 = pad.ClientX(num2);
					y1_2 = pad.ClientY(num4);
					x2_1 = pad.ClientX(num13);
					y2_2 = pad.ClientY(bid);
					if (bid != 0.0 && num4 != 0.0 && (pad.IsInRange(num13, bid) || pad.IsInRange(num2, num4)) && (x1_1 != num5 || x2_1 != num6 || (y1_2 != num9 || y2_2 != num10)))
						pad.Graphics.DrawLine(pen2, x1_1, y1_2, x2_1, y2_2);
				}
				num7 = y1_1;
				num8 = y2_1;
				num3 = ask;
				num5 = x1_1;
				num9 = y1_2;
				num6 = x2_1;
				num10 = y2_2;
				num2 = num13;
				num4 = bid;
				++num1;
			}
		}

		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			int index = this.GetIndex(new DateTime((long)X));
			if (index == -1)
				return (TDistance)null;
			Quote quote = this[index];
			double num = Math.Abs(X - (double)quote.DateTime.Ticks);
			double val1 = Math.Abs(Y - quote.Ask);
			double val2 = Math.Abs(Y - quote.Bid);
			tdistance.dX = num;
			tdistance.dY = Math.Min(val1, val2);
			tdistance.X = (double)quote.DateTime.Ticks;
			tdistance.Y = Y;
			if (quote == null)
				return (TDistance)null;
			DateTime dateTime = new DateTime((long)tdistance.X);
			StringBuilder stringBuilder = new StringBuilder();
			this.toolTipFormat = "tooltipFormat";
//			stringBuilder.AppendFormat(this.toolTipFormat, "{0}", (object) dateTime.ToString(this.toolTipDateTimeFormat), (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(278), (object) quote.Bid, (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(288), (object) quote.Ask);
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		public void Draw()
		{
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("CavName", "Cavtitle");
			}
			Chart.Pad.Add(this);
			Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
			Chart.Pad.AxisBottom.LabelFormat = "LabelFormat";
			double num1 = (double)this.FirstDateTime.Ticks;
			double num2 = (double)this.LastDateTime.Ticks;
			double num3 = double.MaxValue;
			double num4 = double.MinValue;
			for (int index = 0; index < this.Count; ++index)
			{
				Quote quote = this[index];
				if (Math.Max(quote.Bid, quote.Ask) > num4)
					num4 = Math.Max(quote.Bid, quote.Ask);
				if (Math.Min(quote.Bid, quote.Ask) < num3)
					num3 = Math.Min(quote.Bid, quote.Ask);
			}
			double num5 = num3;
			double num6 = num4;
			Chart.Pad.SetRange(num1 - (num2 - num1) / 20.0, num2 + (num2 - num1) / 20.0, num5 - (num6 - num5) / 20.0, num6 + (num6 - num5) / 20.0);
		}

		public bool IsPadRangeY()
		{
			return true;
		}

		public PadRange GetPadRangeY(Pad pad)
		{
			if (this.Count == 0)
				return new PadRange(0.0, 0.0);
			double min = double.MaxValue;
			double max = double.MinValue;
			DateTime datetime1 = new DateTime((long)pad.XMin);
			DateTime datetime2 = new DateTime((long)pad.XMax);
			int num1 = !(datetime1 <= this.FirstDateTime) ? this.GetIndex(datetime1) : 0;
			if (num1 == -1)
				return new PadRange(0.0, 0.0);
			int num2 = !(datetime2 >= this.LastDateTime) ? this.GetIndex(datetime2) : this.Count - 1;
			for (int index = num1; index <= num2; ++index)
			{
				Quote quote = this[index];
				if (Math.Max(quote.Bid, quote.Ask) > max)
					max = Math.Max(quote.Bid, quote.Ask);
				if (Math.Min(quote.Bid, quote.Ask) < min && quote.Bid != 0.0 && quote.Ask != 0.0)
					min = Math.Min(quote.Bid, quote.Ask);
			}
			return new PadRange(min, max);
		}

		public bool IsPadRangeX()
		{
			return false;
		}

		public PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}
	}
}
