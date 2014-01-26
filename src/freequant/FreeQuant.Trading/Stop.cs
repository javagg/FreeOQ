using FreeQuant;
using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class Stop : StopBase
  {
    private StrategyBase Udd6EeE9v6;
    private bool c866VDWdRV;

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

    [Browsable(false)]
    public override Instrument Instrument
    {
       get
      {
        return this.fInstrument;
      }
    }

    [Browsable(false)]
    public bool Connected
    {
       get
      {
        return this.c866VDWdRV;
      }
    }

    
    public Stop(StrategyBase strategy, Position position, double level, StopType type, StopMode mode)
			:base(){
      this.Udd6EeE9v6 = strategy;
      this.fPosition = position;
      this.fInstrument = position.Instrument;
      this.fQty = position.Qty;
      this.fSide = position.Side;
      this.fLevel = level;
      this.fType = type;
      this.fMode = mode;
      this.fCurrPrice = this.fInstrument.Price();
      this.fTrailPrice = this.fCurrPrice;
      this.fStopPrice = this.SlN6PMZ5Ct();
      this.fCreationTime = Clock.Now;
      this.fCompletionTime = DateTime.MinValue;
      this.Udd6EeE9v6.AddStop((StopBase) this);
      this.t276DXCuDr();
    }

    
		public Stop(StrategyBase strategy, Position position, DateTime time):base()
    {
      this.Udd6EeE9v6 = strategy;
      this.fPosition = position;
      this.fInstrument = position.Instrument;
      this.fQty = position.Qty;
      this.fSide = position.Side;
      this.fType = StopType.Time;
      this.fCreationTime = Clock.Now;
      this.fCompletionTime = time;
      this.fStopPrice = this.fInstrument.Price();
      if (!(this.fCompletionTime > this.fCreationTime))
        return;
      Clock.AddReminder(new ReminderEventHandler(this.mSa6vRBe3Z), this.fCompletionTime, (object) null);
      this.Udd6EeE9v6.AddStop((StopBase) this);
    }

    
    public Stop(StrategyBase strategy, double level, StopType type, StopMode mode)
			:  this(strategy, (Position) null, level, type, mode) {
    }

    
    private double SlN6PMZ5Ct()
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

    
    public void Cancel()
    {
      if (this.fStatus != StopStatus.Active)
        return;
      this.Disconnect();
      this.Lk960PQCI8(StopStatus.Canceled);
    }

    
    private void t276DXCuDr()
    {
      this.c866VDWdRV = true;
    }

    
    public override void Disconnect()
    {
      if (this.Type == StopType.Time)
        Clock.RemoveReminder(new ReminderEventHandler(this.mSa6vRBe3Z), this.fCompletionTime);
      else
        this.c866VDWdRV = false;
    }

    
    private void XqY6FAU6Mj()
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
							this.Udd6EeE9v6.ClosePosition(this.fInstrument, this.fFillPrice, ComponentType.Stop, "");
              this.Disconnect();
              this.Lk960PQCI8(StopStatus.Executed);
              break;
            }
            else
            {
              if (this.fType != StopType.Trailing || this.fTrailPrice <= this.fInitPrice)
                break;
              this.fStopPrice = this.SlN6PMZ5Ct();
              break;
            }
          case PositionSide.Short:
            if (this.fCurrPrice >= this.fStopPrice)
            {
							this.Udd6EeE9v6.ClosePosition(this.fInstrument, this.fFillPrice, ComponentType.Stop, "");
              this.Disconnect();
              this.Lk960PQCI8(StopStatus.Executed);
              break;
            }
            else
            {
              if (this.fType != StopType.Trailing || this.fTrailPrice >= this.fInitPrice)
                break;
              this.fStopPrice = this.SlN6PMZ5Ct();
              break;
            }
        }
      }
    }

    
    internal void xbx6LKbgmx([In] Position obj0)
    {
      if (obj0 != this.fPosition)
        return;
      this.Disconnect();
      this.Lk960PQCI8(StopStatus.Canceled);
    }

    
    internal void t2b63VoTkG([In] Bar obj0)
    {
      if (!this.fTraceOnBar || this.fFilterBarSize >= 0L && (this.fFilterBarSize != obj0.Size || this.fFilterBarType != BarType.Time))
        return;
      this.fTrailPrice = obj0.Close;
      switch (this.fSide)
      {
        case PositionSide.Long:
          this.fCurrPrice = obj0.Low;
          this.fFillPrice = obj0.Low;
          if (this.fTrailOnHighLow)
          {
            this.fTrailPrice = obj0.High;
            break;
          }
          else
            break;
        case PositionSide.Short:
          this.fCurrPrice = obj0.High;
          this.fFillPrice = obj0.High;
          if (this.fTrailOnHighLow)
          {
            this.fTrailPrice = obj0.Low;
            break;
          }
          else
            break;
      }
      switch (this.fFillMode)
      {
        case StopFillMode.Close:
          this.fFillPrice = obj0.Close;
          break;
        case StopFillMode.Stop:
          this.fFillPrice = this.fStopPrice;
          break;
      }
      this.XqY6FAU6Mj();
    }

    
    internal void M2g6st8BRD([In] Bar obj0)
    {
      if (!this.fTraceOnBar || !this.fTraceOnBarOpen || this.fFilterBarSize >= 0L && (this.fFilterBarSize != obj0.Size || this.fFilterBarType != BarType.Time))
        return;
      this.fCurrPrice = obj0.Open;
      this.fFillPrice = obj0.Open;
      if (this.fTrailOnOpen)
        this.fTrailPrice = obj0.Open;
      this.XqY6FAU6Mj();
    }

    
    internal void yu56453Z5Z([In] Trade obj0)
    {
      if (!this.fTraceOnTrade)
        return;
      this.fCurrPrice = obj0.Price;
      this.fFillPrice = obj0.Price;
      this.fTrailPrice = obj0.Price;
      this.XqY6FAU6Mj();
    }

    
    internal void ddk6JqyZZD([In] Quote obj0)
    {
      if (!this.fTraceOnQuote)
        return;
      switch (this.fSide)
      {
        case PositionSide.Long:
          this.fCurrPrice = obj0.Bid;
          break;
        case PositionSide.Short:
          this.fCurrPrice = obj0.Ask;
          break;
      }
      this.fFillPrice = this.fCurrPrice;
      this.fTrailPrice = this.fCurrPrice;
      this.XqY6FAU6Mj();
    }

    
    private void Lk960PQCI8([In] StopStatus obj0)
    {
      this.fStatus = obj0;
      this.fCompletionTime = Clock.Now;
      this.Udd6EeE9v6.BSDIytBhT((StopBase) this);
    }

    
    private void mSa6vRBe3Z([In] ReminderEventArgs obj0)
    {
      this.fStopPrice = this.fInstrument.Price();
      this.Lk960PQCI8(StopStatus.Executed);
			this.Udd6EeE9v6.ClosePosition(this.fInstrument, this.fStopPrice, ComponentType.Stop, "");
    }
  }
}
