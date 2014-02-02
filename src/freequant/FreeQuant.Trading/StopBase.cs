using FreeQuant;
using FreeQuant.Charting;
using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace FreeQuant.Trading
{
	public abstract class StopBase : IStop, IDrawable, IZoomable
	{
		protected internal StopType fType;
		protected internal StopMode fMode;
		protected internal StopStatus fStatus;
		protected internal bool isFixedPrice;
		protected internal Position fPosition;
		protected internal Instrument fInstrument;
		protected internal double fLevel;
		protected internal double fInitPrice;
		protected internal double fCurrPrice;
		protected internal double fStopPrice;
		protected internal double fFillPrice;
		protected internal double fTrailPrice;
		protected internal double fQty;
		protected internal PositionSide fSide;
		protected internal DateTime fCreationTime;
		protected internal DateTime fCompletionTime;
		protected internal bool fTraceOnQuote;
		protected internal bool fTraceOnTrade;
		protected internal bool fTraceOnBar;
		protected internal bool fTraceOnBarOpen;
		protected internal bool fTrailOnOpen;
		protected internal bool fTrailOnHighLow;
		protected internal long fFilterBarSize;
		protected internal BarType fFilterBarType;
		protected internal StopFillMode fFillMode;
		protected internal bool textEnabled;
		protected internal bool toolTipEnabled;
		protected internal string toolTipFormat;
		protected internal Color activeColor;
		protected internal Color executedColor;
		protected internal Color canceledColor;

		public abstract Instrument Instrument { get; }

		public bool TraceOnBar
		{
			get
			{
				return this.fTraceOnBar;
			}
			set
			{
				this.fTraceOnBar = value;
			}
		}

		public bool TraceOnBarOpen
		{
			get
			{
				return this.fTraceOnBarOpen;
			}
			set
			{
				this.fTraceOnBarOpen = value;
			}
		}

		public bool TraceOnTrade
		{
			get
			{
				return this.fTraceOnTrade;
			}
			set
			{
				this.fTraceOnTrade = value;
			}
		}

		public bool TraceOnQuote
		{
			get
			{
				return this.fTraceOnQuote;
			}
			set
			{
				this.fTraceOnQuote = value;
			}
		}

		public bool TrailOnOpen
		{
			get
			{
				return this.fTrailOnOpen;
			}
			set
			{
				this.fTrailOnOpen = value;
			}
		}

		public bool TrailOnHighLow
		{
			get
			{
				return this.fTrailOnHighLow;
			}
			set
			{
				this.fTrailOnHighLow = value;
			}
		}

		public double Level
		{
			get
			{
				return this.fLevel;
			}
			set
			{
				this.fLevel = value;
			}
		}

		public StopType Type
		{
			get
			{
				return this.fType;
			}
		}

		public StopMode Mode
		{
			get
			{
				return this.fMode;
			}
		}

		public StopStatus Status
		{
			get
			{
				return this.fStatus;
			}
		}

		public DateTime CreationTime
		{
			get
			{
				return this.fCreationTime;
			}
		}

		public DateTime CompletionTime
		{
			get
			{
				return this.fCompletionTime;
			}
		}

		public Position Position
		{
			get
			{
				return this.fPosition;
			}
		}

		[Category("Drawing Style")]
		public Color ExecutedColor
		{
			get
			{
				return this.executedColor;
			}
			set
			{
				this.executedColor = value;
			}
		}

		[Category("Drawing Style")]
		public Color ActiveColor
		{
			get
			{
				return this.activeColor;
			}
			set
			{
				this.activeColor = value;
			}
		}

		[Category("Drawing Style")]
		public Color CanceledColor
		{
			get
			{
				return this.canceledColor;
			}
			set
			{
				this.canceledColor = value;
			}
		}

		[Category("Drawing Style")]
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

		[Category("ToolTip")]
		[Description("Enable or disable tooltip appearance for this marker.")]
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

		[Category("ToolTip")]
		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
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

		public StopBase() : base()
		{
			this.fType = StopType.Trailing;
			this.fMode = StopMode.Percent;
			this.fTraceOnQuote = true;
			this.fTraceOnTrade = true;
			this.fTraceOnBar = true;
			this.fTraceOnBarOpen = true;
			this.fTrailOnOpen = true;
			this.fFilterBarSize = -1L;
			this.fFilterBarType = BarType.Time;
			this.fFillMode = StopFillMode.Stop;
			this.textEnabled = true;
			this.toolTipEnabled = true;
			this.toolTipFormat = "";
			this.activeColor = Color.Purple;
			this.executedColor = Color.RoyalBlue;
			this.canceledColor = Color.Gray;
		}

		public abstract void Disconnect();

		public void SetBarFilter(long barSize, BarType barType)
		{
			this.fFilterBarSize = barSize;
			this.fFilterBarType = barType;
		}

		public void SetBarFilter(long barSize)
		{
			this.SetBarFilter(barSize, BarType.Time);
		}

		public void Paint(Pad pad, double minX, double maxX, double minY, double maxY)
		{
			double WorldY = this.fStatus != StopStatus.Executed ? Math.Abs(this.fStopPrice) : Math.Abs(this.fFillPrice);
			if (this.fType == StopType.Time)
				WorldY = this.fStopPrice;
			int num1 = pad.ClientX(this.fCreationTime.Ticks);
			int num2 = pad.ClientY(WorldY);
			string str = WorldY.ToString(this.fInstrument.PriceDisplay) + this.fStatus.ToString();
			Font font = new Font("Arial", 8f);
			Color color = this.canceledColor;
			switch (this.fStatus)
			{
				case StopStatus.Active:
					color = this.activeColor;
					break;
				case StopStatus.Executed:
					color = this.executedColor;
					break;
				case StopStatus.Canceled:
					color = this.canceledColor;
					break;
			}
			Pen pen = new Pen(color, 2f);
			pen.DashStyle = DashStyle.Dash;
//			double val2 = (double)pad.ClientX(Clock.Now.Ticks);
			double val2 = pad.ClientX(DateTime.Now.Ticks);
			double val1_1 = pad.ClientX(minX);
			double val1_2 = pad.ClientX(maxX);
			if (this.fStatus != StopStatus.Active)
				val2 = pad.ClientX(this.fCompletionTime.Ticks);
			float x1 = (float)Math.Max(val1_1, num1);
			float x2 = (float)Math.Min(val1_2, val2);
			if ((double)x1 > (double)x2)
				return;
			pad.Graphics.DrawLine(pen, x1, (float)num2, x2, (float)num2);
			if (!this.textEnabled)
				return;
			double num3 = num1 + 2;
			double num4 = this.fSide != PositionSide.Long ? (double)(num2 + 2) : (double)(num2 - 2 - (int)pad.Graphics.MeasureString(str, font).Height);
			pad.Graphics.DrawString(str, font, Brushes.Black, (float)num3, (float)num4);
		}

		public TDistance Distance(double x, double y)
		{
			TDistance tdistance = new TDistance();
			double num = Math.Abs(this.fStopPrice);
			tdistance.X = x;
			tdistance.Y = num;
			tdistance.dX = x < (double)this.fCreationTime.Ticks || (this.fStatus != StopStatus.Active || x > (double)Clock.Now.Ticks) && x > (double)this.fCompletionTime.Ticks ? double.MaxValue : 0.0;
			tdistance.dY = Math.Abs(y - tdistance.Y);
			StringBuilder stringBuilder = new StringBuilder();
			if (!this.isFixedPrice)
			{
				if (this.fCreationTime.Second != 0 || this.fCreationTime.Minute != 0 || this.fCreationTime.Hour != 0)
					stringBuilder.AppendFormat(this.toolTipFormat, (object)((object)this.fStatus).ToString(), (object)((object)this.fType).ToString(), "", (object)this.fLevel.ToString(this.fPosition.Instrument.PriceDisplay), "", (object)this.fPosition.Instrument.Symbol, (object)num.ToString(this.fPosition.Instrument.PriceDisplay), (object)this.fCreationTime);
				else
					stringBuilder.AppendFormat(this.toolTipFormat, (object)((object)this.fStatus).ToString(), (object)((object)this.fType).ToString(), "", (object)this.fLevel.ToString(this.fPosition.Instrument.PriceDisplay), "", (object)this.fPosition.Instrument.Symbol, (object)num.ToString(this.fPosition.Instrument.PriceDisplay), (object)this.fCreationTime.ToShortDateString());
			}
			else if (this.fCreationTime.Second != 0 || this.fCreationTime.Minute != 0 || this.fCreationTime.Hour != 0)
				stringBuilder.AppendFormat(this.toolTipFormat, (object)((object)this.fStatus).ToString(), (object)((object)this.fType).ToString(), "", (object)this.fStopPrice.ToString(this.fPosition.Instrument.PriceDisplay), "", (object)this.fPosition.Instrument.Symbol, (object)num.ToString(this.fPosition.Instrument.PriceDisplay), (object)this.fCreationTime);
			else
				stringBuilder.AppendFormat(this.toolTipFormat, (object)((object)this.fStatus).ToString(), (object)((object)this.fType).ToString(), "", (object)this.fStopPrice.ToString(this.fPosition.Instrument.PriceDisplay), "", (object)this.fPosition.Instrument.Symbol, (object)num.ToString(this.fPosition.Instrument.PriceDisplay), (object)this.fCreationTime.ToShortDateString());
			tdistance.ToolTipText = ((object)stringBuilder).ToString();
			return tdistance;
		}

		public void Draw()
		{
			Chart.Pad.Add(this);
		}

		public bool IsPadRangeY()
		{
			return true;
		}

		public PadRange GetPadRangeY(Pad pad)
		{
			if (!(new DateTime((long)pad.XMin) <= this.fCompletionTime) || !(new DateTime((long)pad.XMax) >= this.fCreationTime) || this.fStatus == StopStatus.Canceled)
				return new PadRange(0.0, 0.0);
			double num = Math.Abs(this.fStopPrice);
			return new PadRange(num - 0.0 / 1.0, num + 0.0 / 1.0);
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