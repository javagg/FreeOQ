// Type: SmartQuant.Trading.Trigger
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant;
using SmartQuant.Charting;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SmartQuant.Trading
{
  public class Trigger : IDrawable, IZoomable
  {
    private Strategy nquAKcUOSY;
    private TriggerType k5kAXvwmyK;
    private TriggerStatus lh4APrSwVL;
    private DoubleSeries fISADbUH9Z;
    private double J3YAFHAWt0;
    private Signal eiNALoFbZL;
    private DateTime a9QA39LDVd;
    private DateTime gixAsE4W2J;
    private Color pEXA4yCenN;
    private Color pZXAJFXyGb;
    private Color YCKA0R33mr;
    private bool yXsAvQ0snw;
    private bool wuIAEWD0JW;
    private string HKDAVnUw46;

    public TriggerType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.k5kAXvwmyK;
      }
    }

    public TriggerStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lh4APrSwVL;
      }
    }

    public DoubleSeries Series
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fISADbUH9Z;
      }
    }

    public double Level
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.J3YAFHAWt0;
      }
    }

    public Signal Signal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.eiNALoFbZL;
      }
    }

    public DateTime CreationTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a9QA39LDVd;
      }
    }

    public DateTime CompletionTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gixAsE4W2J;
      }
    }

    [Category("Drawing Style")]
    public Color ExecutedColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pZXAJFXyGb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.pZXAJFXyGb = value;
      }
    }

    [Category("Drawing Style")]
    public Color ActiveColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pEXA4yCenN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.pEXA4yCenN = value;
      }
    }

    [Category("Drawing Style")]
    public Color CanceledColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YCKA0R33mr;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.YCKA0R33mr = value;
      }
    }

    [Category("Drawing Style")]
    public bool TextEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yXsAvQ0snw;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.yXsAvQ0snw = value;
      }
    }

    [Category("ToolTip")]
    [Description("Enable or disable tooltip appearance for this marker.")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wuIAEWD0JW;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.wuIAEWD0JW = value;
      }
    }

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.HKDAVnUw46;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.HKDAVnUw46 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Trigger(Strategy strategy, TriggerType type, DoubleSeries series, double level, Signal signal)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.pEXA4yCenN = Color.Brown;
      this.pZXAJFXyGb = Color.Green;
      this.YCKA0R33mr = Color.DarkGray;
      this.yXsAvQ0snw = true;
      this.wuIAEWD0JW = true;
      this.HKDAVnUw46 = USaG3GpjZagj1iVdv4u.Y4misFk9D9(10204);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.nquAKcUOSY = strategy;
      this.k5kAXvwmyK = type;
      this.fISADbUH9Z = series;
      this.J3YAFHAWt0 = level;
      this.eiNALoFbZL = signal;
      this.lh4APrSwVL = TriggerStatus.Active;
      this.a9QA39LDVd = Clock.Now;
      this.gixAsE4W2J = DateTime.MinValue;
      this.nquAKcUOSY.YFmhKSovu(this);
      this.ULWAhR6fQR();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void rKEA9ZLnkT()
    {
      this.fISADbUH9Z.ItemAdded -= new ItemAddedEventHandler(this.oq2A1bOgQG);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ULWAhR6fQR()
    {
      this.fISADbUH9Z.ItemAdded += new ItemAddedEventHandler(this.oq2A1bOgQG);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void oq2A1bOgQG([In] object obj0, [In] DateTimeEventArgs obj1)
    {
      DateTime index = obj1.DateTime;
      switch (this.k5kAXvwmyK)
      {
        case TriggerType.Above:
          if (this.fISADbUH9Z[index] <= this.J3YAFHAWt0)
            break;
          this.rKEA9ZLnkT();
          this.eiNALoFbZL = new Signal(Clock.Now, this.eiNALoFbZL.Sender, this.eiNALoFbZL.Type, this.eiNALoFbZL.Side, this.eiNALoFbZL.Qty, this.eiNALoFbZL.Price, this.eiNALoFbZL.Instrument, this.eiNALoFbZL.Text);
          this.nquAKcUOSY.BgvpSPpUAD(this.eiNALoFbZL);
          this.KWCAC961IE(TriggerStatus.Executed);
          break;
        case TriggerType.Below:
          if (this.fISADbUH9Z[index] >= this.J3YAFHAWt0)
            break;
          this.rKEA9ZLnkT();
          this.eiNALoFbZL = new Signal(Clock.Now, this.eiNALoFbZL.Sender, this.eiNALoFbZL.Type, this.eiNALoFbZL.Side, this.eiNALoFbZL.Qty, this.eiNALoFbZL.Price, this.eiNALoFbZL.Instrument, this.eiNALoFbZL.Text);
          this.nquAKcUOSY.BgvpSPpUAD(this.eiNALoFbZL);
          this.KWCAC961IE(TriggerStatus.Executed);
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KWCAC961IE([In] TriggerStatus obj0)
    {
      this.lh4APrSwVL = obj0;
      this.gixAsE4W2J = Clock.Now;
      this.nquAKcUOSY.l7R1qp1JA(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      double WorldY = this.J3YAFHAWt0;
      int num1 = Pad.ClientX((double) this.CreationTime.Ticks);
      int num2 = Pad.ClientY(WorldY);
      string str = USaG3GpjZagj1iVdv4u.Y4misFk9D9(10266) + WorldY.ToString(USaG3GpjZagj1iVdv4u.Y4misFk9D9(10290)) + USaG3GpjZagj1iVdv4u.Y4misFk9D9(10298) + ((object) this.Status).ToString() + USaG3GpjZagj1iVdv4u.Y4misFk9D9(10306);
      Font font = new Font(USaG3GpjZagj1iVdv4u.Y4misFk9D9(10312), 8f);
      Color color = this.YCKA0R33mr;
      switch (this.Status)
      {
        case TriggerStatus.Active:
          color = this.pEXA4yCenN;
          break;
        case TriggerStatus.Executed:
          color = this.pZXAJFXyGb;
          break;
      }
      Pen pen = new Pen(color, 1f);
      pen.DashStyle = DashStyle.DashDot;
      double val2 = (double) Pad.ClientX((double) Clock.Now.Ticks);
      double val1_1 = (double) Pad.ClientX(MinX);
      double val1_2 = (double) Pad.ClientX(MaxX);
      if (this.Status != TriggerStatus.Active)
        val2 = (double) Pad.ClientX((double) this.CompletionTime.Ticks);
      float x1 = (float) Math.Max(val1_1, (double) num1);
      float x2 = (float) Math.Min(val1_2, val2);
      if ((double) x1 > (double) x2)
        return;
      Pad.Graphics.DrawLine(pen, x1, (float) num2, x2, (float) num2);
      if (!this.yXsAvQ0snw)
        return;
      double num3 = (double) (num1 + 2);
      double num4 = this.k5kAXvwmyK != TriggerType.Above ? (double) (num2 + 2) : (double) (num2 - 2 - (int) Pad.Graphics.MeasureString(str, font).Height);
      Pad.Graphics.DrawString(str, font, Brushes.Black, (float) num3, (float) num4);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      double num = this.J3YAFHAWt0;
      tdistance.X = X;
      tdistance.Y = num;
      tdistance.dX = X < (double) this.CreationTime.Ticks || (this.Status != TriggerStatus.Active || X > (double) Clock.Now.Ticks) && X > (double) this.CompletionTime.Ticks ? double.MaxValue : 0.0;
      tdistance.dY = Math.Abs(Y - tdistance.Y);
      StringBuilder stringBuilder = new StringBuilder();
      if (this.CreationTime.Second != 0 || this.CreationTime.Minute != 0 || this.CreationTime.Hour != 0)
        stringBuilder.AppendFormat(this.HKDAVnUw46, (object) ((object) this.lh4APrSwVL).ToString(), (object) ((object) this.k5kAXvwmyK).ToString(), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(10326), (object) this.J3YAFHAWt0.ToString(this.Signal.Instrument.PriceDisplay), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(10350), (object) this.fISADbUH9Z.Name, (object) num.ToString(this.Signal.Instrument.PriceDisplay), (object) this.CreationTime);
      else
        stringBuilder.AppendFormat(this.HKDAVnUw46, (object) ((object) this.lh4APrSwVL).ToString(), (object) ((object) this.k5kAXvwmyK).ToString(), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(10360), (object) this.J3YAFHAWt0.ToString(this.Signal.Instrument.PriceDisplay), (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(10384), (object) this.fISADbUH9Z.Name, (object) num.ToString(this.Signal.Instrument.PriceDisplay), (object) this.CreationTime.ToShortDateString());
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
      if (!(new DateTime((long) pad.XMin) <= this.CompletionTime) || !(new DateTime((long) pad.XMax) >= this.CreationTime))
        return new PadRange(0.0, 0.0);
      double num = this.J3YAFHAWt0;
      return new PadRange(num - 4.94065645841247E-324, num + 4.94065645841247E-324);
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
