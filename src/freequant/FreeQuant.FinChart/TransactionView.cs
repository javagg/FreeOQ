// Type: SmartQuant.FinChart.TransactionView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.Data;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class TransactionView : IChartDrawable, IDateDrawable
  {
    private Transaction AMKwObevl9;
    private Color aPewsePQDS;
    private Color lZ5wLD8PkC;
    private Color xEkwqNT82W;
    private bool T1lwVYQLqj;
    protected Pad pad;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;

    [Category("Drawing Style")]
    [Browsable(false)]
    public Color BuyColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aPewsePQDS;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aPewsePQDS = value;
      }
    }

    [Category("Drawing Style")]
    [Browsable(false)]
    public Color SellColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lZ5wLD8PkC;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.lZ5wLD8PkC = value;
      }
    }

    [Browsable(false)]
    [Category("Drawing Style")]
    public Color SellShortColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.xEkwqNT82W;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.xEkwqNT82W = value;
      }
    }

    [Category("Drawing Style")]
    [Browsable(false)]
    public bool TextEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.T1lwVYQLqj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.T1lwVYQLqj = value;
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
        if (!(this.pad.Series is BarSeries))
          return this.AMKwObevl9.DateTime;
        Bar bar = this.pad.Series[this.AMKwObevl9.DateTime, EIndexOption.Prev] as Bar;
        if (bar != null)
          return bar.DateTime;
        else
          return DateTime.MinValue;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransactionView(Transaction transaction, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.aPewsePQDS = Color.Blue;
      this.lZ5wLD8PkC = Color.Red;
      this.xEkwqNT82W = Color.Yellow;
      this.T1lwVYQLqj = true;
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.AMKwObevl9 = transaction;
      this.pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(216);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool v0vwQdHGPo()
    {
      return this.selected;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void GBIw6qlqgC(bool value)
    {
      this.selected = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint()
    {
      int index = this.pad.Series.GetIndex(this.AMKwObevl9.DateTime, EIndexOption.Prev);
      int x = this.pad.ClientX(this.pad.Series.GetDateTime(index));
      int num1 = this.pad.ClientY(this.AMKwObevl9.Price);
      if (this.pad.Series is BarSeries)
      {
        Bar bar = (this.pad.Series as BarSeries)[index];
        if (bar.BeginTime != bar.EndTime)
        {
          int num2 = Math.Max(2, (int) this.pad.IntervalWidth);
          x = x - num2 / 2 + (int) ((double) num2 * ((double) (this.AMKwObevl9.DateTime - bar.BeginTime).Ticks / (double) (bar.EndTime - bar.BeginTime).Ticks));
        }
      }
      float num3 = 8f;
      string str = ((object) this.AMKwObevl9.Side).ToString() + (object) FJDHryrxb1WIq5jBAt.mT707pbkgT(270) + (string) (object) this.AMKwObevl9.Qty + FJDHryrxb1WIq5jBAt.mT707pbkgT(276) + this.AMKwObevl9.Price.ToString(this.AMKwObevl9.Instrument.PriceDisplay);
      Font font = !this.selected ? new Font(FJDHryrxb1WIq5jBAt.mT707pbkgT(300), 7f) : new Font(FJDHryrxb1WIq5jBAt.mT707pbkgT(286), 9f);
      int y = this.AMKwObevl9.Side != Side.Buy ? num1 - 5 : num1 + 5;
      switch (this.AMKwObevl9.Side)
      {
        case Side.Buy:
          Color color1 = this.aPewsePQDS;
          PointF[] points1 = new PointF[3]
          {
            (PointF) new Point(x, y),
            (PointF) new Point((int) ((double) x - (double) num3 / 2.0), (int) ((double) y + (double) num3 / 2.0)),
            (PointF) new Point((int) ((double) x + (double) num3 / 2.0), (int) ((double) y + (double) num3 / 2.0))
          };
          this.pad.Graphics.DrawPolygon(new Pen(Color.LightGray), points1);
          this.pad.Graphics.DrawRectangle(new Pen(Color.LightGray), (float) x - num3 / 4f, (float) y + num3 / 2f, num3 / 2f, num3 / 2f);
          this.pad.Graphics.FillPolygon((Brush) new SolidBrush(color1), points1);
          this.pad.Graphics.FillRectangle((Brush) new SolidBrush(color1), (float) x - num3 / 4f, (float) ((double) y + (double) num3 / 2.0 - 1.0), num3 / 2f, (float) ((double) num3 / 2.0 + 1.0));
          break;
        case Side.Sell:
          Color color2 = this.lZ5wLD8PkC;
          Point[] points2 = new Point[3]
          {
            new Point(x, y),
            new Point((int) ((double) x - (double) num3 / 2.0), (int) ((double) y - (double) num3 / 2.0)),
            new Point((int) ((double) x + (double) num3 / 2.0), (int) ((double) y - (double) num3 / 2.0))
          };
          this.pad.Graphics.DrawPolygon(new Pen(Color.LightGray), points2);
          this.pad.Graphics.DrawRectangle(new Pen(Color.LightGray), (float) x - num3 / 4f, (float) y - num3, num3 / 2f, (float) ((double) num3 / 2.0 + 1.0));
          this.pad.Graphics.FillPolygon((Brush) new SolidBrush(color2), points2);
          this.pad.Graphics.FillRectangle((Brush) new SolidBrush(color2), (float) x - num3 / 4f, (float) y - num3, num3 / 2f, (float) ((double) num3 / 2.0 + 1.0));
          break;
        case Side.SellShort:
          Color color3 = this.xEkwqNT82W;
          Point[] points3 = new Point[3]
          {
            new Point(x, y),
            new Point((int) ((double) x - (double) num3 / 2.0), (int) ((double) y - (double) num3 / 2.0)),
            new Point((int) ((double) x + (double) num3 / 2.0), (int) ((double) y - (double) num3 / 2.0))
          };
          this.pad.Graphics.DrawPolygon(new Pen(Color.LightGray), points3);
          this.pad.Graphics.DrawRectangle(new Pen(Color.LightGray), (float) x - num3 / 4f, (float) y - num3, num3 / 2f, (float) ((double) num3 / 2.0 + 1.0));
          this.pad.Graphics.FillPolygon((Brush) new SolidBrush(color3), points3);
          this.pad.Graphics.FillRectangle((Brush) new SolidBrush(color3), (float) x - num3 / 4f, (float) y - num3, num3 / 2f, (float) ((double) num3 / 2.0 + 1.0));
          break;
      }
      if (!this.T1lwVYQLqj)
        return;
      int num4 = (int) this.pad.Graphics.MeasureString(str, font).Width;
      int num5 = (int) this.pad.Graphics.MeasureString(str, font).Height;
      Color color4 = this.pad.Chart.ItemTextColor;
      if (this.selected)
        color4 = this.pad.Chart.SelectedItemTextColor;
      switch (this.AMKwObevl9.Side)
      {
        case Side.Buy:
          this.pad.Graphics.DrawString(str, font, (Brush) new SolidBrush(color4), (float) (x - num4 / 2), (float) ((double) y + (double) num3 + 2.0));
          break;
        case Side.Sell:
          this.pad.Graphics.DrawString(str, font, (Brush) new SolidBrush(color4), (float) (x - num4 / 2), (float) ((double) y - (double) num3 - 2.0) - (float) num5);
          break;
        case Side.SellShort:
          this.pad.Graphics.DrawString(str, font, (Brush) new SolidBrush(color4), (float) (x - num4 / 2), (float) ((double) y + (double) num3 + 2.0));
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Compare(object obj)
    {
      return obj == this.AMKwObevl9;
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
      Distance distance = new Distance();
      int index = this.pad.Series.GetIndex(this.AMKwObevl9.DateTime, EIndexOption.Prev);
      distance.X = (double) this.pad.ClientX(this.pad.Series.GetDateTime(index));
      distance.Y = this.AMKwObevl9.Price;
      distance.DX = Math.Abs((double) x - distance.X);
      distance.DY = Math.Abs(y - distance.Y);
      StringBuilder stringBuilder = new StringBuilder();
      if (this.AMKwObevl9.DateTime.Second != 0 || this.AMKwObevl9.DateTime.Minute != 0 || this.AMKwObevl9.DateTime.Hour != 0)
        stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.AMKwObevl9.Side).ToString(), (object) this.AMKwObevl9.Instrument.Symbol, (object) this.AMKwObevl9.Qty, (object) this.AMKwObevl9.Price.ToString(this.AMKwObevl9.Instrument.PriceDisplay), (object) this.AMKwObevl9.DateTime, (object) this.AMKwObevl9.Text);
      else
        stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.AMKwObevl9.Side).ToString(), (object) this.AMKwObevl9.Instrument.Symbol, (object) this.AMKwObevl9.Qty, (object) this.AMKwObevl9.Price.ToString(this.AMKwObevl9.Instrument.PriceDisplay), (object) this.AMKwObevl9.DateTime.ToShortDateString(), (object) this.AMKwObevl9.Text);
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
