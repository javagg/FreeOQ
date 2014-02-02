using FreeQuant;
using FreeQuant.Data;
using FreeQuant.Instruments;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
	public class ATSStop : StopBase
	{
		private bool connected;
		private DoubleSeries series;

		[Browsable(false)]
		public DoubleSeries Series
		{
			get
			{
				return this.series; 
			}
		}

		[Browsable(false)]
		public PositionSide Side
		{
			get
			{
				return this.fSide;
			}
		}

		[Browsable(false)]
		public override Instrument Instrument
		{
			get
			{
				return this.fInstrument;
			}
		}

		[Browsable(false)]
		public double FillPrice
		{
			get
			{
				return this.fFillPrice;
			}
		}

		[Browsable(false)]
		public double StopPrice
		{
			get
			{
				return this.fStopPrice;
			}
		}

		[Browsable(false)]
		public bool Connected
		{
			get
			{
				return this.connected; 
			}
		}

		public StopFillMode FillMode
		{
			get
			{
				return this.fFillMode;
			}
			set
			{
				this.fFillMode = value;
			}
		}

		public event StopEventHandler StatusChanged;

		public ATSStop(Position position, double level, StopType type, StopMode mode)	: base()
		{
			this.fPosition = position;
			this.fInstrument = position.Instrument;
			this.fQty = position.Qty;
			this.fSide = position.Side;
			this.fLevel = level;
			this.fType = type;
			this.fMode = mode;
			this.fCurrPrice = this.fInstrument.Price();
			this.fTrailPrice = this.fCurrPrice;
			this.fStopPrice = this.lkZijZtYnj();
			this.fCreationTime = Clock.Now;
			this.fCompletionTime = DateTime.MinValue;
			this.series = new DoubleSeries();
			if (this.fType == StopType.Trailing)
				this.series.Add(this.fCreationTime, this.lkZijZtYnj());
			this.Connect();
		}

		public ATSStop(Position position, DateTime time) : base()
		{
			this.fPosition = position;
			this.fInstrument = position.Instrument;
			this.fQty = position.Qty;
			this.fSide = position.Side;
			this.fType = StopType.Time;
			this.fCreationTime = Clock.Now;
			this.fCompletionTime = time;
			this.fStopPrice = this.fInstrument.Price();
			this.series = new DoubleSeries();
			if (this.fType == StopType.Trailing)
				this.series.Add(this.fCreationTime, this.lkZijZtYnj());
			if (!(this.fCompletionTime > this.fCreationTime))
				return;
			Clock.AddReminder(new ReminderEventHandler(this.tQYi7Nff5A), this.fCompletionTime, (object)null);
		}

		public ATSStop(Position position, double price) : base()
		{
			this.fPosition = position;
			this.fInstrument = position.Instrument;
			this.fQty = position.Qty;
			this.fSide = position.Side;
			this.fType = StopType.Fixed;
			this.fMode = StopMode.Absolute;
			this.isFixedPrice = true;
			this.fCurrPrice = this.fInstrument.Price();
			this.fTrailPrice = this.fCurrPrice;
			this.fStopPrice = price;
			this.fCreationTime = Clock.Now;
			this.fCompletionTime = DateTime.MinValue;
			this.series = new DoubleSeries();
			if (this.fType == StopType.Trailing)
				this.series.Add(this.fCreationTime, this.lkZijZtYnj());
			this.Connect();
		}

		public void Cancel()
		{
			if (this.fStatus != StopStatus.Active)
				return;
			if (this.fType == StopType.Time)
				Clock.RemoveReminder(new ReminderEventHandler(this.tQYi7Nff5A));
			else
				this.Disconnect();
			this.Lf6iiLBYf9(StopStatus.Canceled);
		}

		private double lkZijZtYnj()
		{
			this.fInitPrice = this.fTrailPrice;
			switch (this.fMode)
			{
				case StopMode.Absolute:
					switch (this.fSide)
					{
						case PositionSide.Long:
							return this.fTrailPrice - Math.Abs(this.fLevel);
						case PositionSide.Short:
							return this.fTrailPrice + Math.Abs(this.fLevel);
						default:
							throw new ArgumentException(this.fPosition.Side.ToString());
					}
				case StopMode.Percent:
					switch (this.fPosition.Side)
					{
						case PositionSide.Long:
							return this.fTrailPrice - Math.Abs(this.fTrailPrice * this.fLevel);
						case PositionSide.Short:
							return this.fTrailPrice + Math.Abs(this.fTrailPrice * this.fLevel);
						default:
							throw new ArgumentException(this.fPosition.Side.ToString());
					}
				default:
					throw new ArgumentException(this.fMode.ToString());
			}
		}

		private void Connect()
		{
			this.connected = true;
		}

		public override void Disconnect()
		{
			if (this.Type == StopType.Time)
				Clock.RemoveReminder(new ReminderEventHandler(this.tQYi7Nff5A), this.fCompletionTime);
			else
				this.connected = false;
		}

		private void oEtiRP16ys()
		{
			if (this.fCurrPrice == 0.0)
				return;
			lock (this)
			{
				switch (this.fSide)
				{
					case PositionSide.Long:
						if (this.fCurrPrice <= this.fStopPrice)
						{
							this.Disconnect();
							this.Lf6iiLBYf9(StopStatus.Executed);
							break;
						}
						else
						{
							if (this.fType != StopType.Trailing || this.fTrailPrice <= this.fInitPrice)
								break;
							this.fStopPrice = this.lkZijZtYnj();
							break;
						}
					case PositionSide.Short:
						if (this.fCurrPrice >= this.fStopPrice)
						{
							this.Disconnect();
							this.Lf6iiLBYf9(StopStatus.Executed);
							break;
						}
						else
						{
							if (this.fType != StopType.Trailing || this.fTrailPrice >= this.fInitPrice)
								break;
							this.fStopPrice = this.lkZijZtYnj();
							break;
						}
				}
			}
		}

		public void OnPositionClosed(Position position)
		{
			if (position != this.fPosition)
				return;
			this.Disconnect();
			this.Lf6iiLBYf9(StopStatus.Canceled);
		}

		public void OnNewBar(Bar bar)
		{
			if (this.fTraceOnBar && (this.fFilterBarSize < 0L || this.fFilterBarSize == bar.Size && this.fFilterBarType == BarType.Time))
			{
				this.fTrailPrice = bar.Close;
				switch (this.fSide)
				{
					case PositionSide.Long:
						this.fCurrPrice = bar.Low;
						this.fFillPrice = bar.Low;
						if (this.fTrailOnHighLow)
						{
							this.fTrailPrice = bar.High;
							break;
						}
						else
							break;
					case PositionSide.Short:
						this.fCurrPrice = bar.High;
						this.fFillPrice = bar.High;
						if (this.fTrailOnHighLow)
						{
							this.fTrailPrice = bar.Low;
							break;
						}
						else
							break;
				}
				switch (this.fFillMode)
				{
					case StopFillMode.Close:
						this.fFillPrice = bar.Close;
						break;
					case StopFillMode.Stop:
						this.fFillPrice = this.fStopPrice;
						break;
				}
				this.oEtiRP16ys();
			}
			if (this.fType != StopType.Trailing)
				return;
			this.series.Add(bar.DateTime, this.fStopPrice);
		}

		public void OnNewBarOpen(Bar bar)
		{
			if (!this.fTraceOnBar || !this.fTraceOnBarOpen || this.fFilterBarSize >= 0L && (this.fFilterBarSize != bar.Size || this.fFilterBarType != BarType.Time))
				return;
			this.fCurrPrice = bar.Open;
			this.fFillPrice = bar.Open;
			if (this.fTrailOnOpen)
				this.fTrailPrice = bar.Open;
			this.oEtiRP16ys();
		}

		public void OnNewTrade(Trade trade)
		{
			if (!this.fTraceOnTrade)
				return;
			this.fCurrPrice = trade.Price;
			this.fFillPrice = trade.Price;
			this.fTrailPrice = trade.Price;
			this.oEtiRP16ys();
		}

		public void OnNewQuote(Quote quote)
		{
			if (!this.fTraceOnQuote)
				return;
			switch (this.fSide)
			{
				case PositionSide.Long:
					this.fCurrPrice = quote.Ask;
					break;
				case PositionSide.Short:
					this.fCurrPrice = quote.Bid;
					break;
			}
			this.fFillPrice = this.fCurrPrice;
			this.fTrailPrice = this.fCurrPrice;
			this.oEtiRP16ys();
		}

		private void Lf6iiLBYf9(StopStatus status)
		{
			this.fStatus = status;
			this.fCompletionTime = Clock.Now;
			if (this.fType == StopType.Trailing)
				this.series.Add(this.fCompletionTime, this.fStopPrice);
			this.fZIiHsKOSJ();
		}

		private void tQYi7Nff5A([In] ReminderEventArgs obj0)
		{
			this.fStopPrice = this.fInstrument.Price();
			this.Lf6iiLBYf9(StopStatus.Executed);
		}

		private void fZIiHsKOSJ()
		{
			if (this.StatusChanged != null)
				this.StatusChanged(new StopEventArgs(this));
		}
	}
}
