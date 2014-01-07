// Type: SmartQuant.Charting.TMarker
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using gyr6NSGRxNZcTviJZk;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace SmartQuant.Charting
{
  [Serializable]
  public class TMarker : IDrawable, IMovable
  {
    protected double fX;
    protected double fY;
    protected double fZ;
    protected double fHigh;
    protected double fLow;
    protected double fOpen;
    protected double fClose;
    protected EMarkerStyle fStyle;
    protected Color fColor;
    protected int fSize;
    protected bool fFilled;
    protected Color fBuyColor;
    protected Color fSellColor;
    protected Color fSellShortColor;
    protected Color fBuyShortColor;
    [NonSerialized]
    protected string fText;
    [NonSerialized]
    protected bool fTextEnabled;
    [NonSerialized]
    protected EMarkerTextPosition fTextPosition;
    [NonSerialized]
    protected int fTextOffset;
    [NonSerialized]
    protected Color fTextColor;
    [NonSerialized]
    protected Font fTextFont;
    protected bool fToolTipEnabled;
    protected string fToolTipFormat;

    public Color BuyColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fBuyColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fBuyColor = value;
      }
    }

    public Color SellColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSellColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSellColor = value;
      }
    }

    public Color BuyShortColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fBuyShortColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fBuyShortColor = value;
      }
    }

    public Color SellShortColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSellShortColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSellShortColor = value;
      }
    }

    [Description("Enable or disable tooltip appearance for this marker.")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fToolTipEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fToolTipEnabled = value;
      }
    }

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fToolTipFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fToolTipFormat = value;
      }
    }

    [Category("Position")]
    [Description("X position of this marker on the pad. (World coordinate system)")]
    public double X
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fX = value;
      }
    }

    [Description("Y position of this marker on the pad. (World coordinate system)")]
    [Category("Position")]
    public double Y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fY = value;
      }
    }

    [Browsable(false)]
    public double Z
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fZ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fZ = value;
      }
    }

    [Description("Marker style")]
    [Category("Marker")]
    public EMarkerStyle Style
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fStyle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fStyle = value;
      }
    }

    [Description("Marker color")]
    [Category("Marker")]
    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fColor = value;
      }
    }

    [Category("Marker")]
    [Description("Marker size in pixels")]
    public int Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSize;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSize = value;
      }
    }

    [Category("Marker")]
    [Description("Marker interior will be filled if this propery is set to true, otherwise it will be transparent")]
    public bool Filled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fFilled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fFilled = value;
      }
    }

    [Description("High of bar marker")]
    [Category("Value")]
    public double High
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fHigh;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fHigh = value;
      }
    }

    [Category("Value")]
    [Description("Low of bar marker")]
    public double Low
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLow;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLow = value;
      }
    }

    [Category("Value")]
    [Description("Open of bar marker")]
    public double Open
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fOpen;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fOpen = value;
      }
    }

    [Description("Close of bar marker")]
    [Category("Value")]
    public double Close
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fClose;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fClose = value;
      }
    }

    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fText;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fText = value;
      }
    }

    public bool TextEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTextEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTextEnabled = value;
      }
    }

    public EMarkerTextPosition TextPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTextPosition;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTextPosition = value;
      }
    }

    public int TextOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTextOffset;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTextOffset = value;
      }
    }

    public Color TextColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTextColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTextColor = value;
      }
    }

    public Font TextFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTextFont;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTextFont = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(double X, double Y)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = X;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(DateTime X, double Y)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = (double) X.Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(string X, double Y)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = (double) DateTime.Parse(X).Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(double X, double Y, Color Color)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = X;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
      this.fColor = Color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(double X, double Y, EMarkerStyle Style)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = X;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
      this.fStyle = Style;
      if (this.fStyle != EMarkerStyle.Buy && this.fStyle != EMarkerStyle.Sell && (this.fStyle != EMarkerStyle.SellShort && this.fStyle != EMarkerStyle.BuyShort))
        return;
      this.fSize = 10;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(DateTime X, double Y, EMarkerStyle Style)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = (double) X.Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
      this.fStyle = Style;
      if (this.fStyle != EMarkerStyle.Buy && this.fStyle != EMarkerStyle.Sell && (this.fStyle != EMarkerStyle.SellShort && this.fStyle != EMarkerStyle.BuyShort))
        return;
      this.fSize = 10;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(string X, double Y, EMarkerStyle Style)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = (double) DateTime.Parse(X).Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
      this.fStyle = Style;
      if (this.fStyle != EMarkerStyle.Buy && this.fStyle != EMarkerStyle.Sell && (this.fStyle != EMarkerStyle.SellShort && this.fStyle != EMarkerStyle.BuyShort))
        return;
      this.fSize = 10;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(double X, double Y, double Z)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = X;
      this.fY = Y;
      this.fZ = Z;
      this.syl3vbh6Kv();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(double X, double Y, double Z, Color Color)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = X;
      this.fY = Y;
      this.fZ = Z;
      this.syl3vbh6Kv();
      this.fColor = Color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(double X, double High, double Low, double Open, double Close)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = X;
      this.fY = 0.0;
      this.fZ = 0.0;
      this.fHigh = High;
      this.fLow = Low;
      this.fOpen = Open;
      this.fClose = Close;
      this.syl3vbh6Kv();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TMarker(double X, double High, double Low, double Open, double Close, Color Color)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fX = X;
      this.fY = 0.0;
      this.fZ = 0.0;
      this.fHigh = High;
      this.fLow = Low;
      this.fOpen = Open;
      this.fClose = Close;
      this.syl3vbh6Kv();
      this.fColor = Color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void syl3vbh6Kv()
    {
      this.fStyle = EMarkerStyle.Rectangle;
      this.fColor = Color.Black;
      this.fSize = 5;
      this.fFilled = true;
      this.fTextEnabled = true;
      this.fTextOffset = 2;
      this.fTextPosition = EMarkerTextPosition.Bottom;
      this.fTextFont = new Font(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(338), 8f);
      this.fTextColor = Color.Black;
      this.fToolTipEnabled = true;
      this.fToolTipFormat = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(352);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(398), RA7k7APgXK5aSsnmA9.qBCYFXVOKp(414));
      }
      Chart.Pad.Add((IDrawable) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
    {
      int num1 = Pad.ClientX(this.fX);
      int y = Pad.ClientY(this.fY);
      float num2 = (float) this.fSize;
      switch (this.fStyle)
      {
        case EMarkerStyle.Rectangle:
          if (this.fFilled)
          {
            Pad.Graphics.FillRectangle((Brush) new SolidBrush(this.fColor), (float) num1 - num2 / 2f, (float) y - num2 / 2f, num2, num2);
            break;
          }
          else
          {
            Pen pen = new Pen(this.fColor);
            Pad.Graphics.DrawRectangle(pen, (float) num1 - num2 / 2f, (float) y - num2 / 2f, num2, num2);
            break;
          }
        case EMarkerStyle.Triangle:
          float num3 = (float) ((double) num2 / 2.0 * Math.Tan(Math.PI / 6.0));
          float num4 = num2 * (float) Math.Cos(Math.PI / 6.0) - num3;
          PointF pointF1 = new PointF((float) num1, (float) y - num4);
          PointF pointF2 = new PointF((float) num1 - num2 / 2f, (float) y + num3);
          PointF pointF3 = new PointF((float) num1 + num2 / 2f, (float) y + num3);
          PointF[] points1 = new PointF[4]
          {
            pointF1,
            pointF2,
            pointF3,
            pointF1
          };
          if (this.fFilled)
          {
            Pad.Graphics.FillPolygon((Brush) new SolidBrush(this.fColor), points1);
            break;
          }
          else
          {
            Pen pen = new Pen(this.fColor);
            Pad.Graphics.DrawLines(pen, points1);
            break;
          }
        case EMarkerStyle.Circle:
          if (this.fFilled)
          {
            Pad.Graphics.FillEllipse((Brush) new SolidBrush(this.fColor), (float) num1 - num2 / 2f, (float) y - num2 / 2f, num2, num2);
            break;
          }
          else
          {
            Pen pen = new Pen(this.fColor);
            Pad.Graphics.DrawEllipse(pen, (float) num1 - num2 / 2f, (float) y - num2 / 2f, num2, num2);
            break;
          }
        case EMarkerStyle.Bar:
          Pen pen1 = new Pen(this.fColor);
          Pad.Graphics.DrawLine(pen1, num1, Pad.ClientY(this.fLow), Pad.ClientX(this.fX), Pad.ClientY(this.fHigh));
          Pad.Graphics.DrawLine(pen1, num1, Pad.ClientY(this.fLow), Pad.ClientX(this.fX) - 3, Pad.ClientY(this.fLow));
          Pad.Graphics.DrawLine(pen1, num1, Pad.ClientY(this.fHigh), Pad.ClientX(this.fX) + 3, Pad.ClientY(this.fHigh));
          break;
        case EMarkerStyle.Buy:
          PointF[] points2 = new PointF[3]
          {
            (PointF) new Point(num1, y),
            (PointF) new Point((int) ((double) num1 - (double) num2 / 2.0), (int) ((double) y + (double) num2)),
            (PointF) new Point((int) ((double) num1 + (double) num2 / 2.0), (int) ((double) y + (double) num2))
          };
          Pad.Graphics.FillPolygon((Brush) new SolidBrush(this.fBuyColor), points2);
          break;
        case EMarkerStyle.Sell:
          Point[] points3 = new Point[3]
          {
            new Point(num1, y),
            new Point((int) ((double) num1 - (double) num2 / 2.0), (int) ((double) y - (double) num2)),
            new Point((int) ((double) num1 + (double) num2 / 2.0), (int) ((double) y - (double) num2))
          };
          Pad.Graphics.FillPolygon((Brush) new SolidBrush(this.fSellColor), points3);
          break;
        case EMarkerStyle.SellShort:
          Point[] points4 = new Point[3]
          {
            new Point(num1, y),
            new Point((int) ((double) num1 - (double) num2 / 2.0), (int) ((double) y - (double) num2)),
            new Point((int) ((double) num1 + (double) num2 / 2.0), (int) ((double) y - (double) num2))
          };
          Pad.Graphics.FillPolygon((Brush) new SolidBrush(this.fSellShortColor), points4);
          break;
        case EMarkerStyle.BuyShort:
          Point[] points5 = new Point[3]
          {
            new Point(num1, y),
            new Point((int) ((double) num1 - (double) num2 / 2.0), (int) ((double) y + (double) num2)),
            new Point((int) ((double) num1 + (double) num2 / 2.0), (int) ((double) y + (double) num2))
          };
          Pad.Graphics.FillPolygon((Brush) new SolidBrush(this.fBuyShortColor), points5);
          break;
        case EMarkerStyle.Plus:
          Pen pen2 = new Pen(this.fColor);
          Pad.Graphics.DrawLine(pen2, (float) num1 - num2 / 2f, (float) y, (float) num1 + num2 / 2f, (float) y);
          Pad.Graphics.DrawLine(pen2, (float) num1, (float) y - num2 / 2f, (float) num1, (float) y + num2 / 2f);
          break;
        case EMarkerStyle.Cross:
          Pen pen3 = new Pen(this.fColor);
          Pad.Graphics.DrawLine(pen3, (float) num1 - num2 / 2f, (float) y - num2 / 2f, (float) num1 + num2 / 2f, (float) y + num2 / 2f);
          Pad.Graphics.DrawLine(pen3, (float) num1 - num2 / 2f, (float) y + num2 / 2f, (float) num1 + num2 / 2f, (float) y - num2 / 2f);
          break;
      }
      if (!this.fTextEnabled || this.fText == null || !(this.fText != ""))
        return;
      int num5 = (int) Pad.Graphics.MeasureString(this.fText, this.fTextFont).Width;
      int num6 = (int) Pad.Graphics.MeasureString(this.fText, this.fTextFont).Height;
      switch (this.fStyle)
      {
        case EMarkerStyle.Buy:
          Pad.Graphics.DrawString(this.fText, this.fTextFont, (Brush) new SolidBrush(this.fTextColor), (float) (Pad.ClientX(this.fX) - num5 / 2), (float) Pad.ClientY(this.fY) + num2 + (float) this.fTextOffset);
          break;
        case EMarkerStyle.Sell:
          Pad.Graphics.DrawString(this.fText, this.fTextFont, (Brush) new SolidBrush(this.fTextColor), (float) (Pad.ClientX(this.fX) - num5 / 2), (float) Pad.ClientY(this.fY) - num2 - (float) this.fTextOffset - (float) num6);
          break;
        case EMarkerStyle.SellShort:
          Pad.Graphics.DrawString(this.fText, this.fTextFont, (Brush) new SolidBrush(this.fTextColor), (float) (Pad.ClientX(this.fX) - num5 / 2), (float) Pad.ClientY(this.fY) + num2 + (float) this.fTextOffset);
          break;
        case EMarkerStyle.BuyShort:
          Pad.Graphics.DrawString(this.fText, this.fTextFont, (Brush) new SolidBrush(this.fTextColor), (float) (Pad.ClientX(this.fX) - num5 / 2), (float) Pad.ClientY(this.fY) + num2 + (float) this.fTextOffset);
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      tdistance.X = this.fX;
      tdistance.Y = this.fY;
      tdistance.dX = Math.Abs(X - this.fX);
      tdistance.dY = Math.Abs(Y - this.fY);
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.fToolTipFormat, (object) this.fX, (object) this.fY);
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Move(double X, double Y, double dX, double dY)
    {
      this.fX += dX;
      this.fY += dY;
    }
  }
}
