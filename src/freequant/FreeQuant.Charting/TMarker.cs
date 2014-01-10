using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.Charting
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
       get
      {
        return this.fBuyColor;
      }
       set
      {
        this.fBuyColor = value;
      }
    }

    public Color SellColor
    {
       get
      {
        return this.fSellColor;
      }
       set
      {
        this.fSellColor = value;
      }
    }

    public Color BuyShortColor
    {
       get
      {
        return this.fBuyShortColor;
      }
       set
      {
        this.fBuyShortColor = value;
      }
    }

    public Color SellShortColor
    {
       get
      {
        return this.fSellShortColor;
      }
       set
      {
        this.fSellShortColor = value;
      }
    }

    [Description("Enable or disable tooltip appearance for this marker.")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
       get
      {
        return this.fToolTipEnabled;
      }
       set
      {
        this.fToolTipEnabled = value;
      }
    }

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
    public string ToolTipFormat
    {
       get
      {
        return this.fToolTipFormat;
      }
       set
      {
        this.fToolTipFormat = value;
      }
    }

    [Category("Position")]
    [Description("X position of this marker on the pad. (World coordinate system)")]
    public double X
    {
       get
      {
        return this.fX;
      }
       set
      {
        this.fX = value;
      }
    }

    [Description("Y position of this marker on the pad. (World coordinate system)")]
    [Category("Position")]
    public double Y
    {
       get
      {
        return this.fY;
      }
       set
      {
        this.fY = value;
      }
    }

    [Browsable(false)]
    public double Z
    {
       get
      {
        return this.fZ;
      }
       set
      {
        this.fZ = value;
      }
    }

    [Description("Marker style")]
    [Category("Marker")]
    public EMarkerStyle Style
    {
       get
      {
        return this.fStyle;
      }
       set
      {
        this.fStyle = value;
      }
    }

    [Description("Marker color")]
    [Category("Marker")]
    public Color Color
    {
       get
      {
        return this.fColor;
      }
       set
      {
        this.fColor = value;
      }
    }

    [Category("Marker")]
    [Description("Marker size in pixels")]
    public int Size
    {
       get
      {
        return this.fSize;
      }
       set
      {
        this.fSize = value;
      }
    }

    [Category("Marker")]
    [Description("Marker interior will be filled if this propery is set to true, otherwise it will be transparent")]
    public bool Filled
    {
       get
      {
        return this.fFilled;
      }
       set
      {
        this.fFilled = value;
      }
    }

    [Description("High of bar marker")]
    [Category("Value")]
    public double High
    {
       get
      {
        return this.fHigh;
      }
       set
      {
        this.fHigh = value;
      }
    }

    [Category("Value")]
    [Description("Low of bar marker")]
    public double Low
    {
       get
      {
        return this.fLow;
      }
       set
      {
        this.fLow = value;
      }
    }

    [Category("Value")]
    [Description("Open of bar marker")]
    public double Open
    {
       get
      {
        return this.fOpen;
      }
       set
      {
        this.fOpen = value;
      }
    }

    [Description("Close of bar marker")]
    [Category("Value")]
    public double Close
    {
       get
      {
        return this.fClose;
      }
       set
      {
        this.fClose = value;
      }
    }

    public string Text
    {
       get
      {
        return this.fText;
      }
       set
      {
        this.fText = value;
      }
    }

    public bool TextEnabled
    {
       get
      {
        return this.fTextEnabled;
      }
       set
      {
        this.fTextEnabled = value;
      }
    }

    public EMarkerTextPosition TextPosition
    {
       get
      {
        return this.fTextPosition;
      }
       set
      {
        this.fTextPosition = value;
      }
    }

    public int TextOffset
    {
       get
      {
        return this.fTextOffset;
      }
       set
      {
        this.fTextOffset = value;
      }
    }

    public Color TextColor
    {
       get
      {
        return this.fTextColor;
      }
       set
      {
        this.fTextColor = value;
      }
    }

    public Font TextFont
    {
       get
      {
        return this.fTextFont;
      }
       set
      {
        this.fTextFont = value;
      }
    }


    public TMarker(double X, double Y):base()
    {

      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = X;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
    }

    
    public TMarker(DateTime X, double Y)
    {
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = (double) X.Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
    }

    
    public TMarker(string X, double Y)
    {
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = (double) DateTime.Parse(X).Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
    }


    public TMarker(double X, double Y, Color Color):base()
    {

      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = X;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
      this.fColor = Color;
    }


    public TMarker(double X, double Y, EMarkerStyle Style):base()
    {

      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = X;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
      this.fStyle = Style;
      if (this.fStyle != EMarkerStyle.Buy && this.fStyle != EMarkerStyle.Sell && (this.fStyle != EMarkerStyle.SellShort && this.fStyle != EMarkerStyle.BuyShort))
        return;
      this.fSize = 10;
    }


    public TMarker(DateTime X, double Y, EMarkerStyle Style):base()
    {

      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = (double) X.Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
      this.fStyle = Style;
      if (this.fStyle != EMarkerStyle.Buy && this.fStyle != EMarkerStyle.Sell && (this.fStyle != EMarkerStyle.SellShort && this.fStyle != EMarkerStyle.BuyShort))
        return;
      this.fSize = 10;
    }


    public TMarker(string X, double Y, EMarkerStyle Style):base()
    {

      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = (double) DateTime.Parse(X).Ticks;
      this.fY = Y;
      this.fZ = 0.0;
      this.syl3vbh6Kv();
      this.fStyle = Style;
      if (this.fStyle != EMarkerStyle.Buy && this.fStyle != EMarkerStyle.Sell && (this.fStyle != EMarkerStyle.SellShort && this.fStyle != EMarkerStyle.BuyShort))
        return;
      this.fSize = 10;
    }


    public TMarker(double X, double Y, double Z):base()
    {
 
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;
 
      this.fX = X;
      this.fY = Y;
      this.fZ = Z;
      this.syl3vbh6Kv();
    }


    public TMarker(double X, double Y, double Z, Color Color):base()
    {

      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = X;
      this.fY = Y;
      this.fZ = Z;
      this.syl3vbh6Kv();
      this.fColor = Color;
    }


    public TMarker(double X, double High, double Low, double Open, double Close):base()
    {
     
      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

      this.fX = X;
      this.fY = 0.0;
      this.fZ = 0.0;
      this.fHigh = High;
      this.fLow = Low;
      this.fOpen = Open;
      this.fClose = Close;
      this.syl3vbh6Kv();
    }


    public TMarker(double X, double High, double Low, double Open, double Close, Color Color):base()
    {

      this.fBuyColor = Color.Blue;
      this.fSellColor = Color.Red;
      this.fSellShortColor = Color.Yellow;
      this.fBuyShortColor = Color.Green;

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

    
    private void syl3vbh6Kv()
    {
      this.fStyle = EMarkerStyle.Rectangle;
      this.fColor = Color.Black;
      this.fSize = 5;
      this.fFilled = true;
      this.fTextEnabled = true;
      this.fTextOffset = 2;
      this.fTextPosition = EMarkerTextPosition.Bottom;
			this.fTextFont = new Font("Times New Roman", 8);
      this.fTextColor = Color.Black;
      this.fToolTipEnabled = true;
			this.fToolTipFormat = "";
    }

    
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
				Canvas canvas = new Canvas("CNAme", "CText");
      }
      Chart.Pad.Add((IDrawable) this);
    }

    
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

    
    public void Move(double X, double Y, double dX, double dY)
    {
      this.fX += dX;
      this.fY += dY;
    }
  }
}
