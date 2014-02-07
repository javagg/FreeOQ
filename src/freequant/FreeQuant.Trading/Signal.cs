using FreeQuant.Charting;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Simulation;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace FreeQuant.Trading
{
	public class Signal : IDrawable
	{
		internal FillOnBarMode R2djQy947W;
		internal bool Fuwj5CvMiW;
		internal bool QvSj2cjRxv;

		public Strategy Strategy { get; set; }
		public DateTime DateTime { get; private set; }
		public ComponentType Sender { get; set; }
		public ComponentType Rejecter { get; set; }
		public string RejectReason { get; set; }
		public SignalType Type { get; set; }
		public SignalSide Side { get; set; }
		public double Price { get; set; }
		public double StopPrice { get; set; }
		public double LimitPrice { get; set; }
		public double Qty { get; set; }
		public TimeInForce TimeInForce { get; set; }
		public double StrategyPrice { get; set; }
		public bool StrategyFill { get; set; }
		public Instrument Instrument { get; set; }
		public string Text { get; set; }
		public SignalStatus Status { get; set; }

		[Category("Drawing Style")]
		public Color BuyColor { get; set; }

		[Category("Drawing Style")]
		public Color BuyCoverColor { get; set; }

		[Category("Drawing Style")]
		public Color SellColor { get; set; }

		[Category("Drawing Style")]
		public Color SellShortColor { get; set; }

		[Description("Enable or disable tooltip appearance for this marker.")]
		[Category("ToolTip")]
		public bool ToolTipEnabled { get; set; }

		[Category("ToolTip")]
		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
		public string ToolTipFormat { get; set; }

		public Signal(DateTime datetime, ComponentType sender, SignalType type, SignalSide side, double qty, double strategyPrice, Instrument instrument, string text)
			: base()
		{
			this.BuyColor = Color.Blue;
			this.BuyCoverColor = Color.SkyBlue;
			this.SellColor = Color.Pink;
			this.SellShortColor = Color.Red;
			this.ToolTipEnabled = true;
			this.ToolTipFormat = "dfdfs";

			this.DateTime = datetime;
			this.Sender = sender;
			this.Type = type;
			this.Side = side;
			this.Qty = qty;
			this.StrategyPrice = strategyPrice;
			this.Instrument = instrument;
			this.Price = this.Instrument.Price();
			this.TimeInForce = TimeInForce.GTC;
			this.Text = text;
			this.Strategy = (Strategy)null;
			this.Rejecter = ComponentType.Unknown;
			this.StopPrice = 0.0;
			this.LimitPrice = 0.0;
			this.Status = SignalStatus.New;
		}

		public Signal(DateTime datetime, ComponentType sender, SignalType type, SignalSide side, Instrument instrument, string text)
			: this(datetime, sender, type, side, 0.0, 0.0, instrument, text)
		{
		}

		public void Paint(Pad pad, double minX, double maxX, double minY, double maxY)
		{
			int num1 = pad.ClientX(this.DateTime.Ticks);
			int num2 = pad.ClientY(this.Price);
//      USaG3GpjZagj1iVdv4u.Y4misFk9D9(11044) + this.RxjAeNd9om.ToString(USaG3GpjZagj1iVdv4u.Y4misFk9D9(11064)) + USaG3GpjZagj1iVdv4u.Y4misFk9D9(11072) + ((object) this.Status).ToString() + USaG3GpjZagj1iVdv4u.Y4misFk9D9(11080);
			Font font = new Font("Arial", 8);
			Color color = this.BuyColor;
			switch (this.Side)
			{
				case SignalSide.Buy:
					color = this.BuyColor;
					break;
				case SignalSide.BuyCover:
					color = this.BuyCoverColor;
					break;
				case SignalSide.Sell:
					color = this.SellColor;
					break;
				case SignalSide.SellShort:
					color = this.SellShortColor;
					break;
			}
			Pen pen = new Pen(color, 2f);
			int num3 = 8;
			double num4 = pad.ClientX(minX);
			double num5 = pad.ClientX(maxX);
			if ((double)(num1 - num3 / 2) > num5 || (double)(num1 + num3 / 2) < num4)
				return;
			pad.Graphics.DrawEllipse(pen, num1 - num3 / 2, num2 - num3 / 2, num3, num3);
		}

		public TDistance Distance(double x, double y)
		{
			TDistance tdistance = new TDistance();
			tdistance.X = this.DateTime.Ticks;
			tdistance.Y = this.Price;
			tdistance.dX = Math.Abs(x - tdistance.X);
			tdistance.dY = Math.Abs(y - tdistance.Y);
			StringBuilder sb = new StringBuilder();
			if (this.DateTime.Second != 0 || this.DateTime.Minute != 0 || this.DateTime.Hour != 0)
				sb.AppendFormat(this.ToolTipFormat, "ffs", (object)((object)this.Side).ToString(), (object)this.Instrument.Symbol, (object)this.Price, (object)this.DateTime, (object)((object)this.Status).ToString());
			else
				sb.AppendFormat(this.ToolTipFormat, "fddsf", this.Side.ToString(), this.Instrument.Symbol, this.Price, (object)this.DateTime.ToShortDateString(), (object)((object)this.Status).ToString());
			tdistance.ToolTipText = sb.ToString();
			return tdistance;
		}

		public void Draw()
		{
			Chart.Pad.Add(this);
		}
	}
}
