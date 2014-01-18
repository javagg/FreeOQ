using FreeQuant;
using FreeQuant.Execution;
using FreeQuant.FIX;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FreeQuant.FinChart
{
  public class OrderView : IChartDrawable
  {
    private SingleOrder Ynnw28rK7h;
    private bool hO3wgSeHU8;
    private Color aoOwHWbfJ4;
    private Color vfIwYklUGT;
    private Color VEIwC98m6Z;
    private Color GM4wmd54o9;
    private Color xNSw3se3iH;
    private Color d3XwNSK42k;
    private Color cCOw8XFtec;
    private bool ksiwBkoxAO;
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
       get
      {
        return this.xNSw3se3iH;
      }
       set
      {
        this.xNSw3se3iH = value;
      }
    }

    [Browsable(false)]
    [Category("Drawing Style")]
    public Color SellColor
    {
       get
      {
        return this.d3XwNSK42k;
      }
       set
      {
        this.d3XwNSK42k = value;
      }
    }

    [Browsable(false)]
    [Category("Drawing Style")]
    public Color SellShortColor
    {
       get
      {
        return this.cCOw8XFtec;
      }
       set
      {
        this.cCOw8XFtec = value;
      }
    }

    [Browsable(false)]
    [Category("Drawing Style")]
    public bool TextEnabled
    {
       get
      {
        return this.ksiwBkoxAO;
      }
       set
      {
        this.ksiwBkoxAO = value;
      }
    }

    [Description("Enable or disable tooltip appearance for this marker.")]
    [Category("ToolTip")]
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

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
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

    
    public OrderView(SingleOrder order, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.hO3wgSeHU8 = true;
      this.aoOwHWbfJ4 = Color.Gold;
      this.vfIwYklUGT = Color.SpringGreen;
      this.VEIwC98m6Z = Color.Crimson;
      this.GM4wmd54o9 = Color.Crimson;
      this.xNSw3se3iH = Color.Blue;
      this.d3XwNSK42k = Color.Red;
      this.cCOw8XFtec = Color.Yellow;
      this.ksiwBkoxAO = true;
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Ynnw28rK7h = order;
      this.pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(314);
    }

    
    public void Paint()
    {
      if (this.Ynnw28rK7h.Reports[0].TransactTime > this.lastDate || this.Ynnw28rK7h.Reports[this.Ynnw28rK7h.Reports.Count - 1].TransactTime < this.firstDate)
        return;
      Color color1 = Color.Green;
      Pen pen1 = this.Ynnw28rK7h.OrdStatus == OrdStatus.Cancelled ? new Pen(this.VEIwC98m6Z, 2f) : new Pen(this.aoOwHWbfJ4, 2f);
      pen1.DashStyle = DashStyle.Dash;
      Pen pen2 = this.Ynnw28rK7h.OrdStatus == OrdStatus.Cancelled ? new Pen(this.GM4wmd54o9, 2f) : new Pen(this.vfIwYklUGT, 2f);
      pen2.DashStyle = DashStyle.Dash;
      switch (this.Ynnw28rK7h.OrdStatus)
      {
        case OrdStatus.Filled:
          color1 = Color.Green;
          break;
        case OrdStatus.Cancelled:
          color1 = Color.Gray;
          break;
        case OrdStatus.Stopped:
          color1 = Color.Red;
          break;
      }
      DateTime dateTime1 = new DateTime(1, 1, 1);
      DateTime dateTime2 = new DateTime(1, 1, 1);
      DateTime dateTime3 = new DateTime(1, 1, 1);
      DateTime dateTime4 = new DateTime(1, 1, 1);
      float num1 = 12f;
      DateTime dateTime5 = DateTime.MaxValue;
      if (this.Ynnw28rK7h.OrdStatus == OrdStatus.Cancelled || this.Ynnw28rK7h.OrdStatus == OrdStatus.Rejected || this.Ynnw28rK7h.OrdStatus == OrdStatus.PendingNew)
        dateTime5 = this.Ynnw28rK7h.Reports[this.Ynnw28rK7h.Reports.Count - 1].TransactTime;
      if (this.Ynnw28rK7h.OrdStatus == OrdStatus.Filled)
      {
        dateTime5 = this.Ynnw28rK7h.Reports[this.Ynnw28rK7h.Reports.Count - 1].TransactTime;
        double avgPx = this.Ynnw28rK7h.AvgPx;
        int x = this.pad.ClientX(this.pad.MainSeries.GetDateTime(this.pad.MainSeries.GetIndex(dateTime5, EIndexOption.Prev)));
        int y = this.pad.ClientY(avgPx);
        if (this.hO3wgSeHU8)
        {
          switch (this.Ynnw28rK7h.Side)
          {
            case Side.Buy:
              Color color2 = this.xNSw3se3iH;
              PointF[] points1 = new PointF[3]
              {
                (PointF) new Point(x, y),
                (PointF) new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y + (double) num1 / 2.0)),
                (PointF) new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y + (double) num1 / 2.0))
              };
              this.pad.Graphics.DrawPolygon(new Pen(Color.Black), points1);
              this.pad.Graphics.DrawRectangle(new Pen(Color.Black), (float) x - num1 / 4f, (float) y + num1 / 2f, num1 / 2f, num1 / 2f);
              this.pad.Graphics.FillPolygon((Brush) new SolidBrush(color2), points1);
              this.pad.Graphics.FillRectangle((Brush) new SolidBrush(color2), (float) x - num1 / 4f, (float) ((double) y + (double) num1 / 2.0 - 1.0), num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
              break;
            case Side.Sell:
              Color color3 = this.d3XwNSK42k;
              Point[] points2 = new Point[3]
              {
                new Point(x, y),
                new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0)),
                new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0))
              };
              this.pad.Graphics.DrawPolygon(new Pen(Color.Black), points2);
              this.pad.Graphics.DrawRectangle(new Pen(Color.Black), (float) x - num1 / 4f, (float) y - num1, num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
              this.pad.Graphics.FillPolygon((Brush) new SolidBrush(color3), points2);
              this.pad.Graphics.FillRectangle((Brush) new SolidBrush(color3), (float) x - num1 / 4f, (float) y - num1, num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
              break;
            case Side.SellShort:
              Color color4 = this.cCOw8XFtec;
              Point[] points3 = new Point[3]
              {
                new Point(x, y),
                new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0)),
                new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0))
              };
              this.pad.Graphics.DrawPolygon(new Pen(Color.Black), points3);
              this.pad.Graphics.DrawRectangle(new Pen(Color.Black), (float) x - num1 / 4f, (float) y - num1, num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
              this.pad.Graphics.FillPolygon((Brush) new SolidBrush(color4), points3);
              this.pad.Graphics.FillRectangle((Brush) new SolidBrush(color4), (float) x - num1 / 4f, (float) y - num1, num1 / 2f, (float) ((double) num1 / 2.0 + 1.0));
              break;
          }
        }
      }
      if (this.Ynnw28rK7h.OrdType == OrdType.Stop || this.Ynnw28rK7h.OrdType == OrdType.StopLimit)
      {
        DateTime transactTime = this.Ynnw28rK7h.Reports[0].TransactTime;
        dateTime2 = new DateTime(Math.Min(Clock.Now.Ticks, dateTime5.Ticks));
        float num2 = (float) this.pad.ClientY(this.Ynnw28rK7h.StopPx);
        int index1 = this.pad.MainSeries.GetIndex(transactTime, EIndexOption.Prev);
        int index2 = this.pad.MainSeries.GetIndex(dateTime2, EIndexOption.Prev);
        if (index1 == -1 || index2 == -1)
          return;
        int num3 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index1));
        int num4 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index2));
        this.pad.Graphics.DrawLine(pen2, (float) num3, num2, (float) num4, num2);
        string priceDisplay = this.Ynnw28rK7h.Instrument.PriceDisplay;
        string str = this.Ynnw28rK7h.OrdStatus != OrdStatus.Filled ? (this.Ynnw28rK7h.OrdStatus != OrdStatus.Cancelled ? ((object) this.Ynnw28rK7h.Side).ToString() + FJDHryrxb1WIq5jBAt.mT707pbkgT(472) + this.Ynnw28rK7h.StopPx.ToString(priceDisplay) + FJDHryrxb1WIq5jBAt.mT707pbkgT(494) : ((object) this.Ynnw28rK7h.Side).ToString() + FJDHryrxb1WIq5jBAt.mT707pbkgT(424) + this.Ynnw28rK7h.StopPx.ToString(priceDisplay) + FJDHryrxb1WIq5jBAt.mT707pbkgT(446)) : ((object) this.Ynnw28rK7h.Side).ToString() + FJDHryrxb1WIq5jBAt.mT707pbkgT(376) + this.Ynnw28rK7h.StopPx.ToString(priceDisplay) + FJDHryrxb1WIq5jBAt.mT707pbkgT(398);
        Font font = new Font(FJDHryrxb1WIq5jBAt.mT707pbkgT(518), 8f);
        double num5 = this.Ynnw28rK7h.Side != Side.Buy ? (double) num2 + 2.0 : (double) num2 - 2.0 - (double) (int) this.pad.Graphics.MeasureString(str, font).Height;
        double num6 = (double) (num4 - (int) this.pad.Graphics.MeasureString(str, font).Width - 2);
        this.pad.Graphics.DrawString(str, font, Brushes.Black, (float) num6, (float) num5);
      }
      if (this.Ynnw28rK7h.OrdType != OrdType.Limit && this.Ynnw28rK7h.OrdType != OrdType.StopLimit)
        return;
      DateTime transactTime1 = this.Ynnw28rK7h.Reports[0].TransactTime;
      dateTime4 = new DateTime(Math.Min(Clock.Now.Ticks, dateTime5.Ticks));
      float num7 = (float) this.pad.ClientY(this.Ynnw28rK7h.Price);
      int index3 = this.pad.MainSeries.GetIndex(transactTime1, EIndexOption.Prev);
      int index4 = this.pad.MainSeries.GetIndex(dateTime4, EIndexOption.Prev);
      if (index3 == -1 || index4 == -1)
        return;
      int num8 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index3));
      int num9 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index4));
      this.pad.Graphics.DrawLine(pen1, (float) num8, num7, (float) num9, num7);
      string priceDisplay1 = this.Ynnw28rK7h.Instrument.PriceDisplay;
      string str1;
      if (this.Ynnw28rK7h.OrdStatus == OrdStatus.Filled)
        str1 = ((object) this.Ynnw28rK7h.Side).ToString() + FJDHryrxb1WIq5jBAt.mT707pbkgT(532) + this.Ynnw28rK7h.Price.ToString(priceDisplay1) + FJDHryrxb1WIq5jBAt.mT707pbkgT(556);
      else if (this.Ynnw28rK7h.OrdStatus == OrdStatus.Cancelled)
      {
        str1 = ((object) this.Ynnw28rK7h.Side).ToString() + FJDHryrxb1WIq5jBAt.mT707pbkgT(582) + this.Ynnw28rK7h.Price.ToString(priceDisplay1) + FJDHryrxb1WIq5jBAt.mT707pbkgT(606);
      }
      else
      {
        bool flag = false;
        if (this.Ynnw28rK7h.OrdType == OrdType.StopLimit)
        {
          for (int index1 = 0; index1 < this.Ynnw28rK7h.Reports.Count; ++index1)
          {
            if (this.Ynnw28rK7h.Reports[index1].OrdStatus == OrdStatus.PendingNew)
            {
              flag = true;
              break;
            }
          }
        }
        str1 = flag || this.Ynnw28rK7h.OrdType == OrdType.Limit ? ((object) this.Ynnw28rK7h.Side).ToString() + FJDHryrxb1WIq5jBAt.mT707pbkgT(632) + this.Ynnw28rK7h.Price.ToString(priceDisplay1) + FJDHryrxb1WIq5jBAt.mT707pbkgT(656) : ((object) this.Ynnw28rK7h.Side).ToString() + FJDHryrxb1WIq5jBAt.mT707pbkgT(680) + this.Ynnw28rK7h.Price.ToString(priceDisplay1) + FJDHryrxb1WIq5jBAt.mT707pbkgT(704);
      }
      Font font1 = new Font(FJDHryrxb1WIq5jBAt.mT707pbkgT(720), 8f);
      double num10 = this.Ynnw28rK7h.Side == Side.Buy ? (double) num7 + 2.0 : (double) num7 - 2.0 - (double) (int) this.pad.Graphics.MeasureString(str1, font1).Height;
      double num11 = (double) (num9 - (int) this.pad.Graphics.MeasureString(str1, font1).Width - 2);
      this.pad.Graphics.DrawString(str1, font1, Brushes.Black, (float) num11, (float) num10);
    }

    
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    
    public Distance Distance(int x, double y)
    {
      return (Distance) null;
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }
  }
}
