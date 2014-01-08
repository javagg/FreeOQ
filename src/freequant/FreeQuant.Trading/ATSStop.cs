// Type: SmartQuant.Trading.ATSStop
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
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
    private bool AF7iOty7LR;
    private DoubleSeries nKliQLK5MZ;

    [Browsable(false)]
    public DoubleSeries Series
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nKliQLK5MZ;
      }
    }

    [Browsable(false)]
    public PositionSide Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSide;
      }
    }

    [Browsable(false)]
    public override Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fInstrument;
      }
    }

    [Browsable(false)]
    public double FillPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fFillPrice;
      }
    }

    [Browsable(false)]
    public double StopPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fStopPrice;
      }
    }

    [Browsable(false)]
    public bool Connected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.AF7iOty7LR;
      }
    }

    public StopFillMode FillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fFillMode;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fFillMode = value;
      }
    }

    public event StopEventHandler StatusChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATSStop(Position position, double level, StopType type, StopMode mode)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
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
      this.nKliQLK5MZ = new DoubleSeries();
      if (this.fType == StopType.Trailing)
        this.nKliQLK5MZ.Add(this.fCreationTime, this.lkZijZtYnj());
      this.fcqiWXKbqW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATSStop(Position position, DateTime time)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fPosition = position;
      this.fInstrument = position.Instrument;
      this.fQty = position.Qty;
      this.fSide = position.Side;
      this.fType = StopType.Time;
      this.fCreationTime = Clock.Now;
      this.fCompletionTime = time;
      this.fStopPrice = this.fInstrument.Price();
      this.nKliQLK5MZ = new DoubleSeries();
      if (this.fType == StopType.Trailing)
        this.nKliQLK5MZ.Add(this.fCreationTime, this.lkZijZtYnj());
      if (!(this.fCompletionTime > this.fCreationTime))
        return;
      Clock.AddReminder(new ReminderEventHandler(this.tQYi7Nff5A), this.fCompletionTime, (object) null);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ATSStop(Position position, double price)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
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
      this.nKliQLK5MZ = new DoubleSeries();
      if (this.fType == StopType.Trailing)
        this.nKliQLK5MZ.Add(this.fCreationTime, this.lkZijZtYnj());
      this.fcqiWXKbqW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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
              throw new ArgumentException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(16214) + (object) this.fPosition.Side);
          }
        case StopMode.Percent:
          switch (this.fPosition.Side)
          {
            case PositionSide.Long:
              return this.fTrailPrice - Math.Abs(this.fTrailPrice * this.fLevel);
            case PositionSide.Short:
              return this.fTrailPrice + Math.Abs(this.fTrailPrice * this.fLevel);
            default:
              throw new ArgumentException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(16266) + (object) this.fPosition.Side);
          }
        default:
          throw new ArgumentException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(16318) + (object) this.fMode);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fcqiWXKbqW()
    {
      this.AF7iOty7LR = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Disconnect()
    {
      if (this.Type == StopType.Time)
        Clock.RemoveReminder(new ReminderEventHandler(this.tQYi7Nff5A), this.fCompletionTime);
      else
        this.AF7iOty7LR = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPositionClosed(Position position)
    {
      if (position != this.fPosition)
        return;
      this.Disconnect();
      this.Lf6iiLBYf9(StopStatus.Canceled);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
      this.nKliQLK5MZ.Add(bar.DateTime, this.fStopPrice);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnNewTrade(Trade trade)
    {
      if (!this.fTraceOnTrade)
        return;
      this.fCurrPrice = trade.Price;
      this.fFillPrice = trade.Price;
      this.fTrailPrice = trade.Price;
      this.oEtiRP16ys();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Lf6iiLBYf9([In] StopStatus obj0)
    {
      this.fStatus = obj0;
      this.fCompletionTime = Clock.Now;
      if (this.fType == StopType.Trailing)
        this.nKliQLK5MZ.Add(this.fCompletionTime, this.fStopPrice);
      this.fZIiHsKOSJ();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tQYi7Nff5A([In] ReminderEventArgs obj0)
    {
      this.fStopPrice = this.fInstrument.Price();
      this.Lf6iiLBYf9(StopStatus.Executed);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fZIiHsKOSJ()
    {
      if (this.xNwiUt6aan == null)
        return;
      this.xNwiUt6aan(new StopEventArgs((IStop) this));
    }
  }
}
