// Type: SmartQuant.FinChart.SignalView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.Series;
using SmartQuant.Trading;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class SignalView : IChartDrawable, IDateDrawable
  {
    private Signal VP3yN9Uek6;
    private Color JVpy8D2xUR;
    private Color zMOyBnpkt3;
    private Color tHoyjarrU1;
    private Color XNayo9fgOU;
    protected Pad pad;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;

    [Category("Drawing Style")]
    public Color BuyColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JVpy8D2xUR;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.JVpy8D2xUR = value;
      }
    }

    [Category("Drawing Style")]
    public Color BuyCoverColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.zMOyBnpkt3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.zMOyBnpkt3 = value;
      }
    }

    [Category("Drawing Style")]
    public Color SellColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tHoyjarrU1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.tHoyjarrU1 = value;
      }
    }

    [Category("Drawing Style")]
    public Color SellShortColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XNayo9fgOU;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XNayo9fgOU = value;
      }
    }

    [Description("Enable or disable tooltip appearance for this marker.")]
    [Category("ToolTip")]
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

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
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

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VP3yN9Uek6.DateTime;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SignalView(Signal signal, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.JVpy8D2xUR = Color.SkyBlue;
      this.zMOyBnpkt3 = Color.SkyBlue;
      this.tHoyjarrU1 = Color.Pink;
      this.XNayo9fgOU = Color.Red;
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.VP3yN9Uek6 = signal;
      this.pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3144);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint()
    {
      if (this.VP3yN9Uek6.DateTime < this.firstDate || this.VP3yN9Uek6.DateTime > this.lastDate)
        return;
      int num1 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(this.pad.MainSeries.GetIndex(this.VP3yN9Uek6.DateTime, EIndexOption.Next)));
      int num2 = this.pad.ClientY(this.VP3yN9Uek6.Price);
      Font font = new Font(FJDHryrxb1WIq5jBAt.mT707pbkgT(3194), 8f);
      Color color = this.JVpy8D2xUR;
      switch (this.VP3yN9Uek6.Side)
      {
        case SignalSide.Buy:
          color = this.JVpy8D2xUR;
          break;
        case SignalSide.BuyCover:
          color = this.zMOyBnpkt3;
          break;
        case SignalSide.Sell:
          color = this.tHoyjarrU1;
          break;
        case SignalSide.SellShort:
          color = this.XNayo9fgOU;
          break;
      }
      Pen pen = new Pen(color, 2f);
      int num3 = 8;
      this.pad.Graphics.DrawEllipse(pen, num1 - num3 / 2, num2 - num3 / 2, num3, num3);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Distance Distance(int x, double y)
    {
      if (this.VP3yN9Uek6.DateTime < this.firstDate || this.VP3yN9Uek6.DateTime > this.lastDate)
        return (Distance) null;
      Distance distance = new Distance();
      int index = this.pad.MainSeries.GetIndex(this.VP3yN9Uek6.DateTime, EIndexOption.Next);
      distance.X = (double) this.pad.ClientX(this.pad.MainSeries.GetDateTime(index));
      distance.Y = this.VP3yN9Uek6.Price;
      distance.DX = Math.Abs((double) x - distance.X);
      distance.DY = Math.Abs(y - distance.Y);
      StringBuilder stringBuilder = new StringBuilder();
      if (this.VP3yN9Uek6.DateTime.Second != 0 || this.VP3yN9Uek6.DateTime.Minute != 0 || this.VP3yN9Uek6.DateTime.Hour != 0)
        stringBuilder.AppendFormat(this.toolTipFormat, (object) FJDHryrxb1WIq5jBAt.mT707pbkgT(3208), (object) ((object) this.VP3yN9Uek6.Side).ToString(), (object) this.VP3yN9Uek6.Instrument.Symbol, (object) this.VP3yN9Uek6.Price, (object) this.VP3yN9Uek6.DateTime, (object) ((object) this.VP3yN9Uek6.Status).ToString());
      else
        stringBuilder.AppendFormat(this.toolTipFormat, (object) FJDHryrxb1WIq5jBAt.mT707pbkgT(3228), (object) ((object) this.VP3yN9Uek6.Side).ToString(), (object) this.VP3yN9Uek6.Instrument.Symbol, (object) this.VP3yN9Uek6.Price, (object) this.VP3yN9Uek6.DateTime.ToShortDateString(), (object) ((object) this.VP3yN9Uek6.Status).ToString());
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Select()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnSelect()
    {
    }
  }
}
