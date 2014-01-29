using FreeQuant.Charting;
using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class Transaction : IComparable, IDrawable, ICloneable
	{
		private int tpgWxTxbUx;
		private string clOrdID;
		private int reportId;
		private DateTime dateTime;
		private Instrument instrument;
		private Side side;
		private double price;
		private double qty;
		private string text;
		private Currency currency;
		private TransactionCost transactionCost;
		private double pnl;
		private double realizedPnL;
		private string strategy;
		private bool toolTipEnabled;
		private string toolTipFormat;
		private Color buyColor;
		private Color sellColor;
		private Color sellShortColor;
		private bool textEnabled;

		[ReadOnly(true)]
		[Description("")]
		[Category("Order")]
		public string ClOrdID
		{
			get
			{
				return this.clOrdID; 
			}
			set
			{
				this.clOrdID = value;
			}
		}

		[Category("Order")]
		[Description("")]
		[ReadOnly(true)]
		public int ReportId
		{
			get
			{
				return this.reportId; 
			}
			set
			{
				this.reportId = value;
			}
		}

		[Description("")]
		[ReadOnly(true)]
		[Category("Transaction")]
		public DateTime DateTime
		{
			get
			{
				return this.dateTime; 
			}
			set
			{
				this.dateTime = value;
			}
		}

		[Description("")]
		[Category("Transaction")]
		public Instrument Instrument
		{
			get
			{
				return this.instrument; 
			}
			set
			{
				this.instrument = value;
			}
		}

		[Description("")]
		[Category("Transaction")]
		[ReadOnly(true)]
		public Side Side
		{
			get
			{
				return this.side; 
			}
			set
			{
				this.side = value;
			}
		}

		[Category("Transaction")]
		[ReadOnly(true)]
		[Description("")]
		public double Price
		{
			get
			{
				return this.price; 
			}
			set
			{
				this.price = value;
			}
		}

		[Category("Transaction")]
		[ReadOnly(true)]
		[Description("")]
		public double Qty
		{
			get
			{
				return this.qty; 
			}
			set
			{
				this.qty = Math.Abs(value);
			}
		}

		[Category("Transaction")]
		[Description("")]
		public double Amount
		{
			get
			{
				switch (this.side)
				{
					case Side.Buy:
					case Side.BuyMinus:
						return this.Qty;
					case Side.Sell:
					case Side.SellPlus:
					case Side.SellShort:
					case Side.SellShortExempt:
						return -this.Qty;
					default:
						throw new NotSupportedException("" + (object)this.side);
				}
			}
		}

		[Category("Transaction")]
		[Description("")]
		public Currency Currency
		{
			get
			{
				return this.currency; 
			}
			set
			{
				this.currency = value;
			}
		}

		[Browsable(false)]
		public TransactionCost TransactionCost
		{
			get
			{
				return this.transactionCost; 
			}
			set
			{
				this.transactionCost = value;
			}
		}

		[Description("")]
		[Category("Transaction")]
		public double Cost
		{
			get
			{
				if (this.transactionCost == null)
					return 0.0;
				else
					return this.transactionCost.GetCost(this);
			}
		}

		[Category("Value")]
		[Description("")]
		public virtual double Value
		{
			get
			{
				if (this.instrument.Factor != 0.0)
					return this.price * this.qty * this.instrument.Factor;
				else
					return this.price * this.qty;
			}
		}

		[Category("Value")]
		[Description("")]
		public virtual double NetCashFlow
		{
			get
			{
				if (this.instrument.Factor != 0.0)
					return -(this.Amount * this.price * this.instrument.Factor);
				else
					return -(this.Amount * this.price);
			}
		}

		[Category("Value")]
		[Description("")]
		public virtual double CashFlow
		{
			get
			{
				return this.NetCashFlow - this.Cost;
			}
		}

		[ReadOnly(true)]
		public string Strategy
		{
			get
			{
				return this.strategy; 
			}
			set
			{
				this.strategy = value;
			}
		}

		[Description("")]
		[Category("Text")]
		public string Text
		{
			get
			{
				return this.text; 
			}
			set
			{
				this.text = value;
			}
		}

		[Category("Drawing Style")]
		[Browsable(false)]
		public Color BuyColor
		{
			get
			{
				return this.buyColor; 
			}
			set
			{
				this.buyColor = value;
			}
		}

		[Category("Drawing Style")]
		[Browsable(false)]
		public Color SellColor
		{
			get
			{
				return this.sellColor; 
			}
			set
			{
				this.sellColor = value;
			}
		}

		[Category("Drawing Style")]
		[Browsable(false)]
		public Color SellShortColor
		{
			get
			{
				return this.sellShortColor; 
			}
			set
			{
				this.sellShortColor = value;
			}
		}

		[Category("Drawing Style")]
		[Browsable(false)]
		public bool TextEnabled
		{
			get
			{
				return this.textEnabled; 
			}
			set
			{
				this.textEnabled = value;
			}
		}

		[ReadOnly(true)]
		[Category("Transaction")]
		[Description("")]
		public double PnL
		{
			get
			{
				return this.pnl; 
			}
			internal set
			{
				this.pnl = value;
			}
		}

		[Description("")]
		[ReadOnly(true)]
		[Category("Transaction")]
		public double RealizedPnL
		{
			get
			{
				return this.realizedPnL; 
			}
			internal set
			{
				this.realizedPnL = value;
			}
		}

		[ReadOnly(true)]
		[Description("Transaction margin")]
		[Category("Margin")]
		public double Margin
		{
			get
			{
				return this.instrument.Margin * this.qty;
			}
		}

		[Description("Transaction debt")]
		[ReadOnly(true)]
		[Category("Margin")]
		public double Debt
		{
			get
			{
				double num = this.instrument.Margin * this.qty;
				if (num == 0.0)
					return 0.0;
				else
					return this.Value - num;
			}
		}

		[Description("Enable or disable tooltip appearance for this marker.")]
		[Category("ToolTip")]
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

		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
		[Category("ToolTip")]
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

		public Transaction()
		{
			this.tpgWxTxbUx = -1;
			this.clOrdID = "";
			this.reportId = -1;
			this.text = "";
			this.currency = CurrencyManager.DefaultCurrency;
			this.transactionCost = new TransactionCost();
			this.toolTipEnabled = true;
			this.toolTipFormat = "fs";
			this.buyColor = Color.Blue;
			this.sellColor = Color.Red;
			this.sellShortColor = Color.Yellow;
		}

		public Transaction(DateTime dateTime, Side side, double qty, Instrument instrument, double price)
		{
			this.tpgWxTxbUx = -1;
			this.clOrdID = "";
			this.reportId = -1;
			this.text = "";
			this.currency = CurrencyManager.DefaultCurrency;
			this.transactionCost = new TransactionCost();
			this.toolTipEnabled = true;
			this.toolTipFormat = "sf";
			this.buyColor = Color.Blue;
			this.sellColor = Color.Red;
			this.sellShortColor = Color.Yellow;
			this.dateTime = dateTime;
			this.instrument = instrument;
			this.side = side;
			this.price = price;
			this.qty = Math.Abs(qty);
		}

		public Transaction(DateTime dateTime, Side side, double qty, Instrument instrument, double price, double commission, CommType commType)
			: this(dateTime, side, qty, instrument, price)
		{

      
			this.transactionCost.Commission = commission;
			this.transactionCost.CommType = commType;
		}

		[SpecialName]
    
		internal int AumWZ22XK3()
		{
			return this.tpgWxTxbUx;
		}

		[SpecialName]
    
		internal void nx8WA03O1L(int value)
		{
			this.tpgWxTxbUx = value;
		}

		public void Draw(string option)
		{
			if (option.IndexOf("textEnabled") != -1)
				this.textEnabled = true;
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("CName", "cTitle");
			}
			Chart.Pad.Add((IDrawable)this);
		}

		public void Draw()
		{
			this.Draw("");
		}

		public override string ToString()
		{
			return (string)(object)this.dateTime + ((object)this.side).ToString() + (string)(object)this.qty + this.instrument.Symbol + (string)(object)this.price;
		}

		public int CompareTo(object obj)
		{
			Transaction transaction = obj as Transaction;
			if (this.dateTime > transaction.DateTime)
				return 1;
			return this.dateTime < transaction.DateTime ? -1 : 0;
		}

		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			if ((double)this.DateTime.Ticks > MaxX || (double)this.DateTime.Ticks < MinX)
				return;
			int x = Pad.ClientX((double)this.DateTime.Ticks);
			int y = Pad.ClientY(this.Price);
			float num1 = 12f;
			string str = ((object)this.Side).ToString() + (string)(object)this.Qty + this.Instrument.Symbol + this.Price.ToString();
			Font font = new Font("airal", 8f);
			switch (this.Side)
			{
				case Side.Buy:
					Color color1 = this.buyColor;
					PointF[] points1 = new PointF[3]
					{
						(PointF)new Point(x, y),
						(PointF)new Point((int)((double)x - (double)num1 / 2.0), (int)((double)y + (double)num1 / 2.0)),
						(PointF)new Point((int)((double)x + (double)num1 / 2.0), (int)((double)y + (double)num1 / 2.0))
					};
					Pad.Graphics.DrawPolygon(new Pen(Color.Black), points1);
					Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)x - num1 / 4f, (float)y + num1 / 2f, num1 / 2f, num1 / 2f);
					Pad.Graphics.FillPolygon((Brush)new SolidBrush(color1), points1);
					Pad.Graphics.FillRectangle((Brush)new SolidBrush(color1), (float)x - num1 / 4f, (float)((double)y + (double)num1 / 2.0 - 1.0), num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
					break;
				case Side.Sell:
					Color color2 = this.sellColor;
					Point[] points2 = new Point[3]
					{
						new Point(x, y),
						new Point((int)((double)x - (double)num1 / 2.0), (int)((double)y - (double)num1 / 2.0)),
						new Point((int)((double)x + (double)num1 / 2.0), (int)((double)y - (double)num1 / 2.0))
					};
					Pad.Graphics.DrawPolygon(new Pen(Color.Black), points2);
					Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)x - num1 / 4f, (float)y - num1, num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
					Pad.Graphics.FillPolygon((Brush)new SolidBrush(color2), points2);
					Pad.Graphics.FillRectangle((Brush)new SolidBrush(color2), (float)x - num1 / 4f, (float)y - num1, num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
					break;
				case Side.SellShort:
					Color color3 = this.sellShortColor;
					Point[] points3 = new Point[3]
					{
						new Point(x, y),
						new Point((int)((double)x - (double)num1 / 2.0), (int)((double)y - (double)num1 / 2.0)),
						new Point((int)((double)x + (double)num1 / 2.0), (int)((double)y - (double)num1 / 2.0))
					};
					Pad.Graphics.DrawPolygon(new Pen(Color.Black), points3);
					Pad.Graphics.DrawRectangle(new Pen(Color.Black), (float)x - num1 / 4f, (float)y - num1, num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
					Pad.Graphics.FillPolygon((Brush)new SolidBrush(color3), points3);
					Pad.Graphics.FillRectangle((Brush)new SolidBrush(color3), (float)x - num1 / 4f, (float)y - num1, num1 / 2f, (float)((double)num1 / 2.0 + 1.0));
					break;
			}
			if (!this.textEnabled)
				return;
			int num2 = (int)Pad.Graphics.MeasureString(str, font).Width;
			int num3 = (int)Pad.Graphics.MeasureString(str, font).Height;
			switch (this.Side)
			{
				case Side.Buy:
					Pad.Graphics.DrawString(str, font, (Brush)new SolidBrush(Color.Black), (float)(x - num2 / 2), (float)((double)y + (double)num1 + 2.0));
					break;
				case Side.Sell:
					Pad.Graphics.DrawString(str, font, (Brush)new SolidBrush(Color.Black), (float)(x - num2 / 2), (float)((double)y - (double)num1 - 2.0) - (float)num3);
					break;
				case Side.SellShort:
					Pad.Graphics.DrawString(str, font, (Brush)new SolidBrush(Color.Black), (float)(x - num2 / 2), (float)((double)y + (double)num1 + 2.0));
					break;
			}
		}

		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			tdistance.X = (double)this.DateTime.Ticks;
			tdistance.Y = this.Price;
			tdistance.dX = Math.Abs(X - tdistance.X);
			tdistance.dY = Math.Abs(Y - tdistance.Y);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.DateTime.Second != 0 || this.DateTime.Minute != 0 || this.DateTime.Hour != 0)
				stringBuilder.AppendFormat(this.toolTipFormat, (object)((object)this.Side).ToString(), (object)this.Instrument.Symbol, (object)this.Qty, (object)this.Price, (object)this.DateTime);
			else
				stringBuilder.AppendFormat(this.toolTipFormat, (object)((object)this.Side).ToString(), (object)this.Instrument.Symbol, (object)this.Qty, (object)this.Price, (object)this.DateTime.ToShortDateString());
			tdistance.ToolTipText = ((object)stringBuilder).ToString();
			return tdistance;
		}

		public object Clone()
		{
			return new Transaction()
			{
				clOrdID = this.clOrdID,
				currency = this.currency,
				dateTime = this.dateTime,
				tpgWxTxbUx = this.tpgWxTxbUx,
				instrument = this.instrument,
				pnl = this.pnl,
				price = this.price,
				qty = this.qty,
				realizedPnL = this.realizedPnL,
				reportId = this.reportId,
				side = this.side,
				strategy = this.strategy,
				text = this.text,
				transactionCost = this.transactionCost
			};
		}
	}
}
