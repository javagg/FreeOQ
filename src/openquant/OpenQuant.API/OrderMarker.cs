using FreeQuant.Charting;
using FreeQuant.Execution;
using FreeQuant.FIX;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace OpenQuant.API
{
  internal class OrderMarker : IDrawable, IZoomable
  {
    protected bool toolTipEnabled = true;
    protected string toolTipFormat = "{0} {1} {2} {3} @ {4} {5} {6}";
    private bool drawArrow = true;
    private Color limitColor = Color.Green;
    private Color stopColor = Color.Brown;
    private Color limitCancelColor = Color.Gray;
    private Color stopCancelColor = Color.Gray;
    private Color buyColor = Color.Blue;
    private Color sellColor = Color.Red;
    private Color sellShortColor = Color.Yellow;
    protected SingleOrder order;

    public SingleOrder Order
    {
      get
      {
        return this.order;
      }
    }

    public bool DrawArrow
    {
      get
      {
        return this.drawArrow;
      }
      set
      {
        this.drawArrow = value;
      }
    }

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

    public OrderMarker(SingleOrder order)
    {
      this.order = order;
    }

    public void Paint(Pad pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      if (((NewOrderSingle) this.order).OrdType == OrdType.TrailingStop || ((NewOrderSingle) this.order).OrdType == OrdType.TrailingStopLimit)
        return;
      DateTime now = Clock.Now;
      Color color1 = Color.Green;
      Pen pen1 = this.order.get_OrdStatus() == OrdStatus.Cancelled || this.order.get_OrdStatus() == OrdStatus.Rejected ? new Pen(this.limitCancelColor, 2f) : new Pen(this.limitColor, 2f);
      pen1.DashStyle = DashStyle.Dash;
      Pen pen2 = this.order.get_OrdStatus() == OrdStatus.Cancelled || this.order.get_OrdStatus() == OrdStatus.Rejected ? new Pen(this.stopCancelColor, 2f) : new Pen(this.stopColor, 2f);
      pen2.DashStyle = DashStyle.Dash;
      switch (this.order.get_OrdStatus())
      {
        case OrdStatus.Filled:
          color1 = Color.Green;
          break;
        case OrdStatus.Cancelled:
        case OrdStatus.Rejected:
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
      if (this.order.get_OrdStatus() == OrdStatus.Cancelled || this.order.get_OrdStatus() == OrdStatus.Rejected || (this.order.get_OrdStatus() == OrdStatus.PendingNew || this.order.get_OrdStatus() == OrdStatus.Filled))
        dateTime5 = this.order.get_Reports()[this.order.get_Reports().Count - 1].TransactTime;
      if (((NewOrderSingle) this.order).OrdType == OrdType.Stop || ((NewOrderSingle) this.order).OrdType == OrdType.StopLimit)
      {
        dateTime1 = this.order.get_Reports()[0].TransactTime;
        dateTime2 = this.order.get_OrdStatus() != OrdStatus.PendingNew ? new DateTime(Math.Min(now.Ticks, dateTime5.Ticks)) : new DateTime(Math.Min(now.Ticks, (long) MaxX));
        if ((double) dateTime1.Ticks > MaxX || (double) dateTime2.Ticks <= MinX)
          return;
        float num2 = (float) pad.ClientY(((FIXNewOrderSingle) this.order).StopPx);
        float x1 = (float) pad.ClientX((double) dateTime1.Ticks);
        float x2 = (float) pad.ClientX((double) dateTime2.Ticks);
        pad.Graphics.DrawLine(pen2, x1, num2, x2, num2);
        string priceDisplay = this.order.get_Instrument().PriceDisplay;
        string str = this.order.get_OrdStatus() != OrdStatus.Filled ? (this.order.get_OrdStatus() != OrdStatus.Cancelled ? (this.order.get_OrdStatus() != OrdStatus.Rejected ? ((object) ((NewOrderSingle) this.order).Side).ToString() + " Stop at " + ((FIXNewOrderSingle) this.order).StopPx.ToString(priceDisplay) + " (Pending)" : ((object) ((NewOrderSingle) this.order).Side).ToString() + " Stop at " + ((FIXNewOrderSingle) this.order).StopPx.ToString(priceDisplay) + " (Rejected)") : ((object) ((NewOrderSingle) this.order).Side).ToString() + " Stop at " + ((FIXNewOrderSingle) this.order).StopPx.ToString(priceDisplay) + " (Canceled)") : ((object) ((NewOrderSingle) this.order).Side).ToString() + " Stop at " + ((FIXNewOrderSingle) this.order).StopPx.ToString(priceDisplay) + " (Executed)";
        Font font = new Font("Arial", 8f);
        double num3 = ((NewOrderSingle) this.order).Side != Side.Buy ? (double) num2 + 2.0 : (double) num2 - 2.0 - (double) (int) pad.Graphics.MeasureString(str, font).Height;
        double num4 = (double) x2 - (double) (int) pad.Graphics.MeasureString(str, font).Width - 2.0;
        pad.Graphics.DrawString(str, font, Brushes.Black, (float) num4, (float) num3);
      }
      if (((NewOrderSingle) this.order).OrdType == OrdType.Limit || ((NewOrderSingle) this.order).OrdType == OrdType.StopLimit)
      {
        dateTime3 = this.order.get_Reports()[0].TransactTime;
        dateTime4 = this.order.get_OrdStatus() != OrdStatus.New ? new DateTime(Math.Min(now.Ticks, dateTime5.Ticks)) : new DateTime(Math.Min(now.Ticks, (long) MaxX));
        if ((double) dateTime3.Ticks > MaxX || (double) dateTime4.Ticks <= MinX)
          return;
        float num2 = (float) pad.ClientY(((FIXNewOrderSingle) this.order).Price);
        float x1 = (float) pad.ClientX((double) dateTime3.Ticks);
        float x2 = (float) pad.ClientX((double) dateTime4.Ticks);
        pad.Graphics.DrawLine(pen1, x1, num2, x2, num2);
        string priceDisplay = this.order.get_Instrument().PriceDisplay;
        string str;
        if (this.order.get_OrdStatus() == OrdStatus.Filled)
          str = ((object) ((NewOrderSingle) this.order).Side).ToString() + " Limit at " + ((FIXNewOrderSingle) this.order).Price.ToString(priceDisplay) + " (Executed)";
        else if (this.order.get_OrdStatus() == OrdStatus.Cancelled)
          str = ((object) ((NewOrderSingle) this.order).Side).ToString() + " Limit at " + ((FIXNewOrderSingle) this.order).Price.ToString(priceDisplay) + " (Canceled)";
        else if (this.order.get_OrdStatus() == OrdStatus.Rejected)
        {
          str = ((object) ((NewOrderSingle) this.order).Side).ToString() + " Limit at " + ((FIXNewOrderSingle) this.order).Price.ToString(priceDisplay) + " (Rejected)";
        }
        else
        {
          bool flag = false;
          if (((NewOrderSingle) this.order).OrdType == OrdType.StopLimit)
          {
            for (int index = 0; index < this.order.get_Reports().Count; ++index)
            {
              if (this.order.get_Reports()[index].OrdStatus == OrdStatus.PendingNew)
              {
                flag = true;
                break;
              }
            }
          }
          str = flag || ((NewOrderSingle) this.order).OrdType == OrdType.Limit ? ((object) ((NewOrderSingle) this.order).Side).ToString() + " Limit at " + ((FIXNewOrderSingle) this.order).Price.ToString(priceDisplay) + " (Pending)" : ((object) ((NewOrderSingle) this.order).Side).ToString() + " Limit at " + ((FIXNewOrderSingle) this.order).Price.ToString(priceDisplay) + " (New)";
        }
        Font font = new Font("Arial", 8f);
        double num3 = ((NewOrderSingle) this.order).Side == Side.Buy ? (double) num2 + 2.0 : (double) num2 - 2.0 - (double) (int) pad.Graphics.MeasureString(str, font).Height;
        double num4 = (double) x2 - (double) (int) pad.Graphics.MeasureString(str, font).Width - 2.0;
        pad.Graphics.DrawString(str, font, Brushes.Black, (float) num4, (float) num3);
      }
      if (this.order.get_OrdStatus() != OrdStatus.Filled)
        return;
      double avgPx = this.order.get_AvgPx();
      int y = pad.ClientY(avgPx);
      int x = pad.ClientX((double) dateTime5.Ticks);
      if (!this.drawArrow)
        return;
      switch (((NewOrderSingle) this.order).Side)
      {
        case Side.Buy:
          Color color2 = this.buyColor;
          Point point1 = new Point(x, y);
          Point point2 = new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y + (double) num1 / 2.0));
          Point point3 = new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y + (double) num1 / 2.0));
          Point point4 = new Point((int) ((double) x - (double) num1 / 4.0), (int) ((double) y + (double) num1 / 2.0));
          Point point5 = new Point((int) ((double) x + (double) num1 / 4.0), (int) ((double) y + (double) num1 / 2.0));
          Point point6 = new Point((int) ((double) x - (double) num1 / 4.0), (int) ((double) y + (double) num1));
          Point point7 = new Point((int) ((double) x + (double) num1 / 4.0), (int) ((double) y + (double) num1));
          pad.Graphics.DrawPolygon(new Pen(color2), new Point[7]
          {
            point1,
            point3,
            point5,
            point7,
            point6,
            point4,
            point2
          });
          break;
        case Side.Sell:
          Color color3 = this.sellColor;
          Point point8 = new Point(x, y);
          Point point9 = new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0));
          Point point10 = new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0));
          Point point11 = new Point((int) ((double) x - (double) num1 / 4.0), (int) ((double) y - (double) num1 / 2.0));
          Point point12 = new Point((int) ((double) x + (double) num1 / 4.0), (int) ((double) y - (double) num1 / 2.0));
          Point point13 = new Point((int) ((double) x - (double) num1 / 4.0), (int) ((double) y - (double) num1));
          Point point14 = new Point((int) ((double) x + (double) num1 / 4.0), (int) ((double) y - (double) num1));
          pad.Graphics.DrawPolygon(new Pen(color3), new Point[7]
          {
            point8,
            point10,
            point12,
            point14,
            point13,
            point11,
            point9
          });
          break;
        case Side.SellShort:
          Color color4 = this.sellShortColor;
          Point point15 = new Point(x, y);
          Point point16 = new Point((int) ((double) x - (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0));
          Point point17 = new Point((int) ((double) x + (double) num1 / 2.0), (int) ((double) y - (double) num1 / 2.0));
          Point point18 = new Point((int) ((double) x - (double) num1 / 4.0), (int) ((double) y - (double) num1 / 2.0));
          Point point19 = new Point((int) ((double) x + (double) num1 / 4.0), (int) ((double) y - (double) num1 / 2.0));
          Point point20 = new Point((int) ((double) x - (double) num1 / 4.0), (int) ((double) y - (double) num1));
          Point point21 = new Point((int) ((double) x + (double) num1 / 4.0), (int) ((double) y - (double) num1));
          pad.Graphics.DrawPolygon(new Pen(color4), new Point[7]
          {
            point15,
            point17,
            point19,
            point21,
            point20,
            point18,
            point16
          });
          break;
      }
    }

    public TDistance Distance(double X, double Y)
    {
      DateTime now = Clock.Now;
      TDistance tdistance = new TDistance();
      double num1 = Math.Abs(((FIXNewOrderSingle) this.order).Price);
      tdistance.X = X;
      tdistance.Y = num1;
      FIXExecutionReport fixExecutionReport = (FIXExecutionReport) null;
      if (this.order.get_Reports().Count != 0)
        fixExecutionReport = (FIXExecutionReport) this.order.get_Reports()[this.order.get_Reports().Count - 1];
      if (fixExecutionReport == null)
        return (TDistance) null;
      if (((NewOrderSingle) this.order).OrdType == OrdType.Market && this.order.get_OrdStatus() != OrdStatus.Filled)
        return (TDistance) null;
      StringBuilder stringBuilder = (StringBuilder) null;
      if (((NewOrderSingle) this.order).OrdType == OrdType.Market)
      {
        tdistance.X = (double) fixExecutionReport.TransactTime.Ticks;
        tdistance.Y = fixExecutionReport.Price;
        tdistance.dX = Math.Abs(X - tdistance.X);
        tdistance.dY = Math.Abs(Y - tdistance.Y);
        stringBuilder = new StringBuilder();
        if (fixExecutionReport.TransactTime.Second != 0 || fixExecutionReport.TransactTime.Minute != 0 || fixExecutionReport.TransactTime.Hour != 0)
          stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.order.get_OrdStatus()).ToString(), (object) ((object) ((NewOrderSingle) this.order).Side).ToString(), (object) this.order.get_Instrument().Symbol, (object) ((FIXNewOrderSingle) this.order).OrderQty, (object) "Market ", (object) this.order.get_AvgPx(), (object) fixExecutionReport.TransactTime);
        else
          stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.order.get_OrdStatus()).ToString(), (object) ((object) ((NewOrderSingle) this.order).Side).ToString(), (object) this.order.get_Instrument().Symbol, (object) ((FIXNewOrderSingle) this.order).OrderQty, (object) "Market ", (object) this.order.get_AvgPx(), (object) fixExecutionReport.TransactTime.ToShortDateString());
      }
      if (((NewOrderSingle) this.order).OrdType == OrdType.Stop || ((NewOrderSingle) this.order).OrdType == OrdType.StopLimit)
      {
        double num2 = Math.Abs(((FIXNewOrderSingle) this.order).StopPx);
        tdistance.X = X;
        tdistance.Y = num2;
        DateTime transactTime = this.order.get_Reports()[0].TransactTime;
        tdistance.dX = X < (double) transactTime.Ticks || (this.order.get_OrdStatus() == OrdStatus.Filled || this.order.get_OrdStatus() == OrdStatus.Cancelled || (this.order.get_OrdStatus() == OrdStatus.Rejected || X > (double) now.Ticks)) && X > (double) fixExecutionReport.TransactTime.Ticks ? double.MaxValue : 0.0;
        tdistance.dY = Math.Abs(Y - tdistance.Y);
        stringBuilder = new StringBuilder();
        if (transactTime.Second != 0 || transactTime.Minute != 0 || transactTime.Hour != 0)
          stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.order.get_OrdStatus()).ToString(), (object) ((object) ((NewOrderSingle) this.order).Side).ToString(), (object) this.order.get_Instrument().Symbol, (object) ((FIXNewOrderSingle) this.order).OrderQty, (object) "Stop At ", (object) num2, (object) fixExecutionReport.TransactTime);
        else
          stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.order.get_OrdStatus()).ToString(), (object) ((object) ((NewOrderSingle) this.order).Side).ToString(), (object) this.order.get_Instrument().Symbol, (object) ((FIXNewOrderSingle) this.order).OrderQty, (object) "Stop At ", (object) num2, (object) fixExecutionReport.TransactTime.ToShortDateString());
      }
      if (((NewOrderSingle) this.order).OrdType == OrdType.Limit || ((NewOrderSingle) this.order).OrdType == OrdType.StopLimit)
      {
        double num2 = Math.Abs(((FIXNewOrderSingle) this.order).Price);
        tdistance.X = X;
        tdistance.Y = num2;
        DateTime transactTime = this.order.get_Reports()[0].TransactTime;
        tdistance.dX = X < (double) transactTime.Ticks || (this.order.get_OrdStatus() == OrdStatus.Filled || this.order.get_OrdStatus() == OrdStatus.Cancelled || (this.order.get_OrdStatus() == OrdStatus.Rejected || X > (double) now.Ticks)) && X > (double) fixExecutionReport.TransactTime.Ticks ? double.MaxValue : 0.0;
        if (tdistance.dY > Math.Abs(Y - tdistance.Y))
        {
          tdistance.dY = Math.Abs(Y - tdistance.Y);
          stringBuilder = new StringBuilder();
          if (transactTime.Second != 0 || transactTime.Minute != 0 || transactTime.Hour != 0)
            stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.order.get_OrdStatus()).ToString(), (object) ((object) ((NewOrderSingle) this.order).Side).ToString(), (object) this.order.get_Instrument().Symbol, (object) ((FIXNewOrderSingle) this.order).OrderQty, (object) "Limit At ", (object) num2, (object) fixExecutionReport.TransactTime);
          else
            stringBuilder.AppendFormat(this.toolTipFormat, (object) ((object) this.order.get_OrdStatus()).ToString(), (object) ((object) ((NewOrderSingle) this.order).Side).ToString(), (object) this.order.get_Instrument().Symbol, (object) ((FIXNewOrderSingle) this.order).OrderQty, (object) "Limit At ", (object) num2, (object) fixExecutionReport.TransactTime.ToShortDateString());
        }
      }
      if (stringBuilder != null)
        tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    public void Draw()
    {
      SmartQuant.Charting.Chart.Pad.Add((IDrawable) this);
    }

    public bool IsPadRangeY()
    {
      return ((NewOrderSingle) this.order).OrdType != OrdType.TrailingStop && ((NewOrderSingle) this.order).OrdType != OrdType.TrailingStopLimit;
    }

    public PadRange GetPadRangeY(Pad pad)
    {
      DateTime now = Clock.Now;
      FIXExecutionReport fixExecutionReport1 = (FIXExecutionReport) null;
      if (this.order.get_Reports().Count != 0)
        fixExecutionReport1 = (FIXExecutionReport) this.order.get_Reports()[this.order.get_Reports().Count - 1];
      if (fixExecutionReport1 == null)
        return new PadRange(0.0, 0.0);
      if (((NewOrderSingle) this.order).OrdType == OrdType.Market && this.order.get_OrdStatus() != OrdStatus.Filled)
        return new PadRange(0.0, 0.0);
      FIXExecutionReport fixExecutionReport2 = (FIXExecutionReport) this.order.get_Reports()[0];
      DateTime dateTime1 = new DateTime((long) pad.XMin);
      DateTime dateTime2 = new DateTime((long) pad.XMax);
      DateTime transactTime = fixExecutionReport2.TransactTime;
      DateTime dateTime3 = this.order.get_OrdStatus() == OrdStatus.Filled || this.order.get_OrdStatus() == OrdStatus.Cancelled || this.order.get_OrdStatus() == OrdStatus.Rejected ? fixExecutionReport1.TransactTime : now;
      if (!(dateTime1 <= dateTime3) || !(dateTime2 >= transactTime) || (this.order.get_OrdStatus() == OrdStatus.Cancelled || this.order.get_OrdStatus() == OrdStatus.Rejected))
        return new PadRange(0.0, 0.0);
      double val1 = this.order.get_AvgPx() - 0.0 / 1.0;
      double val2 = this.order.get_AvgPx() + 0.0 / 1.0;
      if (((NewOrderSingle) this.order).OrdType == OrdType.Limit)
      {
        int ClientY = pad.ClientY(((FIXNewOrderSingle) this.order).Price);
        if (((NewOrderSingle) this.order).Side == Side.Buy)
        {
          val2 = pad.WorldY(ClientY);
          val1 = ((FIXNewOrderSingle) this.order).Price;
        }
        else
        {
          val1 = pad.WorldY(ClientY);
          val2 = ((FIXNewOrderSingle) this.order).Price;
        }
      }
      if (((NewOrderSingle) this.order).OrdType == OrdType.Stop)
      {
        int ClientY = pad.ClientY(((FIXNewOrderSingle) this.order).StopPx);
        if (((NewOrderSingle) this.order).Side != Side.Buy)
        {
          val2 = pad.WorldY(ClientY);
          val1 = ((FIXNewOrderSingle) this.order).StopPx;
        }
        else
        {
          val1 = pad.WorldY(ClientY);
          val2 = ((FIXNewOrderSingle) this.order).StopPx;
        }
      }
      if (((NewOrderSingle) this.order).OrdType == OrdType.StopLimit)
      {
        int ClientY1 = pad.ClientY(((FIXNewOrderSingle) this.order).Price);
        int ClientY2 = pad.ClientY(((FIXNewOrderSingle) this.order).StopPx);
        if (((NewOrderSingle) this.order).Side == Side.Buy)
        {
          val2 = pad.WorldY(ClientY1);
          val1 = pad.WorldY(ClientY2);
        }
        else
        {
          val1 = pad.WorldY(ClientY1);
          val2 = pad.WorldY(ClientY2);
        }
      }
      return new PadRange(Math.Min(val1, val2), Math.Max(val1, val2));
    }

    public bool IsPadRangeX()
    {
      return false;
    }

    public PadRange GetPadRangeX(Pad pad)
    {
      return (PadRange) null;
    }
  }
}
