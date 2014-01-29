using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FreeQuant.FinChart
{
	public class OrderView : IChartDrawable
	{
		private SingleOrder order; 
		private bool hO3wgSeHU8;
		private Color aoOwHWbfJ4;
		private Color vfIwYklUGT;
		private Color VEIwC98m6Z;
		private Color GM4wmd54o9;

		protected Pad pad;
		protected DateTime firstDate;
		protected DateTime lastDate;
//		protected bool toolTipEnabled;
//		protected string toolTipFormat;
		protected bool selected;

		[Category("Drawing Style")]
		[Browsable(false)]
		public Color BuyColor { get; set; }

		[Browsable(false)]
		[Category("Drawing Style")]
		public Color SellColor { get; set; }

		[Browsable(false)]
		[Category("Drawing Style")]
		public Color SellShortColor { get; set; }

		[Browsable(false)]
		[Category("Drawing Style")]
		public bool TextEnabled { get; set; }

		[Description("Enable or disable tooltip appearance for this marker.")]
		[Category("ToolTip")]
		public bool ToolTipEnabled { get; set; }

		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
		[Category("ToolTip")]
		public string ToolTipFormat { get; set; }

		public OrderView(SingleOrder order, Pad pad) : base()
		{
			this.hO3wgSeHU8 = true;
			this.aoOwHWbfJ4 = Color.Gold;
			this.vfIwYklUGT = Color.SpringGreen;
			this.VEIwC98m6Z = Color.Crimson;
			this.GM4wmd54o9 = Color.Crimson;
			this.BuyColor = Color.Blue;
			this.SellColor = Color.Red;
			this.SellShortColor = Color.Yellow;
			this.TextEnabled = true;
			this.ToolTipEnabled = true;
			this.ToolTipFormat = "";

			this.order = order;
			this.pad = pad;
		}

		public void Paint()
		{
			if (this.order.Reports[0].TransactTime > this.lastDate || this.order.Reports[this.order.Reports.Count - 1].TransactTime < this.firstDate)
				return;
			Color color1 = Color.Green;
			Pen pen1 = this.order.OrdStatus == OrdStatus.Cancelled ? new Pen(this.VEIwC98m6Z, 2f) : new Pen(this.aoOwHWbfJ4, 2f);
			pen1.DashStyle = DashStyle.Dash;
			Pen pen2 = this.order.OrdStatus == OrdStatus.Cancelled ? new Pen(this.GM4wmd54o9, 2f) : new Pen(this.vfIwYklUGT, 2f);
			pen2.DashStyle = DashStyle.Dash;
			switch (this.order.OrdStatus)
			{
				case OrdStatus.Filled:
					color1 = Color.Green;
					break;
				case OrdStatus.Cancelled:
					color1 = Color.Gray;
					break;
				case OrdStatus.Stopped:
					color1 = Color.Red;
					break;
			}
			DateTime dateTime1 = new DateTime(1, 1, 1);
			DateTime dateTime2 = new DateTime(1, 1, 1);
			DateTime dateTime3 = new DateTime(1, 1, 1);
			DateTime dateTime4 = new DateTime(1, 1, 1);
			float num1 = 12f;
			DateTime dateTime5 = DateTime.MaxValue;
			if (this.order.OrdStatus == OrdStatus.Cancelled || this.order.OrdStatus == OrdStatus.Rejected || this.order.OrdStatus == OrdStatus.PendingNew)
				dateTime5 = this.order.Reports[this.order.Reports.Count - 1].TransactTime;
			if (this.order.OrdStatus == OrdStatus.Filled)
			{
				dateTime5 = this.order.Reports[this.order.Reports.Count - 1].TransactTime;
				double avgPx = this.order.AvgPx;
				int x = this.pad.ClientX(this.pad.MainSeries.GetDateTime(this.pad.MainSeries.GetIndex(dateTime5, EIndexOption.Prev)));
				int y = this.pad.ClientY(avgPx);
				if (this.hO3wgSeHU8)
				{
					switch (this.order.Side)
					{
						case Side.Buy:
							Color color2 = this.BuyColor;
							PointF[] points1 = new PointF[3]
							{
								(PointF)new Point(x, y),
								(PointF)new Point((int)((double)x - (double)num1 / 2.0), (int)((double)y + (double)num1 / 2.0)),
								(PointF)new Point((int)((double)x + (double)num1 / 2.0), (int)((double)y + (double)num1 / 2.0))
							};
							this.pad.Graphics.DrawPolygon(new Pen(Color.Black), points1);
							this.pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)x - num1 / 4f, (float)y + num1 / 2f, num1 / 2f, num1 / 2f);
							this.pad.Graphics.FillPolygon((Brush)new SolidBrush(color2), points1);
							this.pad.Graphics.FillRectangle((Brush)new SolidBrush(color2), (float)x - num1 / 4f, (float)((double)y + (double)num1 / 2.0 - 1.0), num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
							break;
						case Side.Sell:
							Color color3 = this.SellColor;
							Point[] points2 = new Point[3]
							{
								new Point(x, y),
								new Point((int)((double)x - (double)num1 / 2.0), (int)((double)y - (double)num1 / 2.0)),
								new Point((int)((double)x + (double)num1 / 2.0), (int)((double)y - (double)num1 / 2.0))
							};
							this.pad.Graphics.DrawPolygon(new Pen(Color.Black), points2);
							this.pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)x - num1 / 4f, (float)y - num1, num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
							this.pad.Graphics.FillPolygon((Brush)new SolidBrush(color3), points2);
							this.pad.Graphics.FillRectangle((Brush)new SolidBrush(color3), (float)x - num1 / 4f, (float)y - num1, num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
							break;
						case Side.SellShort:
							Color color4 = this.SellShortColor;
							Point[] points3 = new Point[3]
							{
								new Point(x, y),
								new Point((int)((double)x - (double)num1 / 2.0), (int)((double)y - (double)num1 / 2.0)),
								new Point((int)((double)x + (double)num1 / 2.0), (int)((double)y - (double)num1 / 2.0))
							};
							this.pad.Graphics.DrawPolygon(new Pen(Color.Black), points3);
							this.pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)x - num1 / 4f, (float)y - num1, num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
							this.pad.Graphics.FillPolygon((Brush)new SolidBrush(color4), points3);
							this.pad.Graphics.FillRectangle((Brush)new SolidBrush(color4), (float)x - num1 / 4f, (float)y - num1, num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
							break;
					}
				}
			}
			if (this.order.OrdType == OrdType.Stop || this.order.OrdType == OrdType.StopLimit)
			{
				DateTime transactTime = this.order.Reports[0].TransactTime;
				dateTime2 = new DateTime(Math.Min(Clock.Now.Ticks, dateTime5.Ticks));
				float num2 = (float)this.pad.ClientY(this.order.StopPx);
				int index1 = this.pad.MainSeries.GetIndex(transactTime, EIndexOption.Prev);
				int index2 = this.pad.MainSeries.GetIndex(dateTime2, EIndexOption.Prev);
				if (index1 == -1 || index2 == -1)
					return;
				int num3 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index1));
				int num4 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index2));
				this.pad.Graphics.DrawLine(pen2, (float)num3, num2, (float)num4, num2);
				string priceDisplay = this.order.Instrument.PriceDisplay;
				string str = this.order.OrdStatus != OrdStatus.Filled ? (this.order.OrdStatus != OrdStatus.Cancelled ? this.order.Side.ToString() + this.order.StopPx.ToString(priceDisplay) : this.order.Side.ToString() + this.order.StopPx.ToString(priceDisplay)) :  this.order.Side.ToString() + this.order.StopPx.ToString(priceDisplay);
				Font font = new Font("Arial", 8);
				double num5 = this.order.Side != Side.Buy ? (double)num2 + 2.0 : (double)num2 - 2.0 - (double)(int)this.pad.Graphics.MeasureString(str, font).Height;
				double num6 = (double)(num4 - (int)this.pad.Graphics.MeasureString(str, font).Width - 2);
				this.pad.Graphics.DrawString(str, font, Brushes.Black, (float)num6, (float)num5);
			}
			if (this.order.OrdType != OrdType.Limit && this.order.OrdType != OrdType.StopLimit)
				return;
			DateTime transactTime1 = this.order.Reports[0].TransactTime;
			dateTime4 = new DateTime(Math.Min(Clock.Now.Ticks, dateTime5.Ticks));
			float num7 = (float)this.pad.ClientY(this.order.Price);
			int index3 = this.pad.MainSeries.GetIndex(transactTime1, EIndexOption.Prev);
			int index4 = this.pad.MainSeries.GetIndex(dateTime4, EIndexOption.Prev);
			if (index3 == -1 || index4 == -1)
				return;
			int num8 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index3));
			int num9 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index4));
			this.pad.Graphics.DrawLine(pen1, (float)num8, num7, (float)num9, num7);
			string priceDisplay1 = this.order.Instrument.PriceDisplay;
			string str1;
			if (this.order.OrdStatus == OrdStatus.Filled)
				str1 = this.order.Side.ToString() + this.order.Price.ToString(priceDisplay1);
			else if (this.order.OrdStatus == OrdStatus.Cancelled)
			{
				str1 =  this.order.Side.ToString() + this.order.Price.ToString(priceDisplay1);
			}
			else
			{
				bool flag = false;
				if (this.order.OrdType == OrdType.StopLimit)
				{
					for (int index1 = 0; index1 < this.order.Reports.Count; ++index1)
					{
						if (this.order.Reports[index1].OrdStatus == OrdStatus.PendingNew)
						{
							flag = true;
							break;
						}
					}
				}
				str1 = flag || this.order.OrdType == OrdType.Limit ? this.order.Side.ToString() + this.order.Price.ToString(priceDisplay1) : ((object)this.order.Side).ToString() + this.order.Price.ToString(priceDisplay1);
			}
			Font font1 = new Font("Arial", 8);
			double num10 = this.order.Side == Side.Buy ? (double)num7 + 2.0 : (double)num7 - 2.0 - (int)this.pad.Graphics.MeasureString(str1, font1).Height;
			double num11 = (double)(num9 - (int)this.pad.Graphics.MeasureString(str1, font1).Width - 2);
			this.pad.Graphics.DrawString(str1, font1, Brushes.Black, (float)num11, (float)num10);
		}

		public void SetInterval(DateTime minDate, DateTime maxDate)
		{
			this.firstDate = minDate;
			this.lastDate = maxDate;
		}

		public Distance Distance(int x, double y)
		{
			return null;
		}

		public void Select()
		{
		}

		public void UnSelect()
		{
		}
	}
}
