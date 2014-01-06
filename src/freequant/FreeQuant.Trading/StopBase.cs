// Type: SmartQuant.Trading.StopBase
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant;
using SmartQuant.Charting;
using SmartQuant.Data;
using SmartQuant.Instruments;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text;

namespace SmartQuant.Trading
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTraceOnBar;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTraceOnBar = value;
      }
    }

    public bool TraceOnBarOpen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTraceOnBarOpen;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTraceOnBarOpen = value;
      }
    }

    public bool TraceOnTrade
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTraceOnTrade;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTraceOnTrade = value;
      }
    }

    public bool TraceOnQuote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTraceOnQuote;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTraceOnQuote = value;
      }
    }

    public bool TrailOnOpen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTrailOnOpen;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTrailOnOpen = value;
      }
    }

    public bool TrailOnHighLow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTrailOnHighLow;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTrailOnHighLow = value;
      }
    }

    public double Level
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLevel;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLevel = value;
      }
    }

    public StopType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fType;
      }
    }

    public StopMode Mode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMode;
      }
    }

    public StopStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fStatus;
      }
    }

    public DateTime CreationTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fCreationTime;
      }
    }

    public DateTime CompletionTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fCompletionTime;
      }
    }

    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPosition;
      }
    }

    [Category("Drawing Style")]
    public Color ExecutedColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.executedColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.executedColor = value;
      }
    }

    [Category("Drawing Style")]
    public Color ActiveColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.activeColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.activeColor = value;
      }
    }

    [Category("Drawing Style")]
    public Color CanceledColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.canceledColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.canceledColor = value;
      }
    }

    [Category("Drawing Style")]
    public bool TextEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.textEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.textEnabled = value;
      }
    }

    [Category("ToolTip")]
    [Description("Enable or disable tooltip appearance for this marker.")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.toolTipEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.toolTipEnabled = value;
      }
    }

    [Category("ToolTip")]
    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.toolTipFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.toolTipFormat = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StopBase()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
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
      this.toolTipFormat = USaG3GpjZagj1iVdv4u.Y4misFk9D9(4608);
      this.activeColor = Color.Purple;
      this.executedColor = Color.RoyalBlue;
      this.canceledColor = Color.Gray;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public abstract void Disconnect();

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBarFilter(long barSize, BarType barType)
    {
      this.fFilterBarSize = barSize;
      this.fFilterBarType = barType;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBarFilter(long barSize)
    {
      this.SetBarFilter(barSize, BarType.Time);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      double WorldY = this.fStatus != StopStatus.Executed ? Math.Abs(this.fStopPrice) : Math.Abs(this.fFillPrice);
      if (this.fType == StopType.Time)
        WorldY = this.fStopPrice;
      int num1 = Pad.ClientX((double) this.fCreationTime.Ticks);
      int num2 = Pad.ClientY(WorldY);
      string str = USaG3GpjZagj1iVdv4u.Y4misFk9D9(4670) + WorldY.ToString(this.fInstrument.PriceDisplay) + USaG3GpjZagj1iVdv4u.Y4misFk9D9(4690) + ((object) this.fStatus).ToString() + USaG3GpjZagj1iVdv4u.Y4misFk9D9(4698);
      Font font = new Font(USaG3GpjZagj1iVdv4u.Y4misFk9D9(4704), 8f);
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
      double val2 = (double) Pad.ClientX((double) Clock.Now.Ticks);
      double val1_1 = (double) Pad.ClientX(MinX);
      double val1_2 = (double) Pad.ClientX(MaxX);
      if (this.fStatus != StopStatus.Active)
        val2 = (double) Pad.ClientX((double) this.fCompletionTime.Ticks);
      float x1 = (float) Math.Max(val1_1, (double) num1);
      float x2 = (float) Math.Min(val1_2, val2);
      if ((double) x1 > (double) x2)
        return;
      Pad.Graphics.DrawLine(pen, x1, (float) num2, x2, (float) num2);
      if (!this.textEnabled)
        return;
      double num3 = (double) (num1 + 2);
      double num4 = this.fSide != PositionSide.Long ? (double) (num2 + 2) : (double) (num2 - 2 - (int) Pad.Graphics.MeasureString(str, font).Height);
      Pad.Graphics.DrawString(str, font, Brushes.Black, (float) num3, (float) num4);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      double num = Math.Abs(this.fStopPrice);
      tdistance.X = X;
      tdistance.Y = num;
      tdistance.dX = X < (double) this.fCreationTime.Ticks || (this.fStatus != StopStatus.Active || X > (double) Clock.Now.Ticks) && X > (double) this.fCompletionTime.Ticks ? double.MaxValue : 0.0;
      tdistance.dY = Math.Abs(Y - tdistance.Y);
      StringBuilder stringBuilder = new StringBuilder();
      if (!this.isFixedPrice)
      {
        if (this.fCreationTime.Second != 0 || this.fCreationTime.Minute != 0 || this.fCreationTime.Hour != 0)
          stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.fStatus).ToString(), (object) ((object) this.fType).ToString(), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4718), (object) this.fLevel.ToString(this.fPosition.Instrument.PriceDisplay), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4736), (object) this.fPosition.Instrument.Symbol, (object) num.ToString(this.fPosition.Instrument.PriceDisplay), (object) this.fCreationTime);
        else
          stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.fStatus).ToString(), (object) ((object) this.fType).ToString(), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4746), (object) this.fLevel.ToString(this.fPosition.Instrument.PriceDisplay), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4764), (object) this.fPosition.Instrument.Symbol, (object) num.ToString(this.fPosition.Instrument.PriceDisplay), (object) this.fCreationTime.ToShortDateString());
      }
      else if (this.fCreationTime.Second != 0 || this.fCreationTime.Minute != 0 || this.fCreationTime.Hour != 0)
        stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.fStatus).ToString(), (object) ((object) this.fType).ToString(), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4774), (object) this.fStopPrice.ToString(this.fPosition.Instrument.PriceDisplay), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4796), (object) this.fPosition.Instrument.Symbol, (object) num.ToString(this.fPosition.Instrument.PriceDisplay), (object) this.fCreationTime);
      else
        stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.fStatus).ToString(), (object) ((object) this.fType).ToString(), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4804), (object) this.fStopPrice.ToString(this.fPosition.Instrument.PriceDisplay), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4826), (object) this.fPosition.Instrument.Symbol, (object) num.ToString(this.fPosition.Instrument.PriceDisplay), (object) this.fCreationTime.ToShortDateString());
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw()
    {
      Chart.Pad.Add((IDrawable) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPadRangeY()
    {
      return true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadRange GetPadRangeY(Pad pad)
    {
      if (!(new DateTime((long) pad.XMin) <= this.fCompletionTime) || !(new DateTime((long) pad.XMax) >= this.fCreationTime) || this.fStatus == StopStatus.Canceled)
        return new PadRange(0.0, 0.0);
      double num = Math.Abs(this.fStopPrice);
      return new PadRange(num - 0.0 / 1.0, num + 0.0 / 1.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPadRangeX()
    {
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadRange GetPadRangeX(Pad pad)
    {
      return (PadRange) null;
    }
  }
}
