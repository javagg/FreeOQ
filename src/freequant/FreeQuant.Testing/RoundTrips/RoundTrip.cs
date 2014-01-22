using FreeQuant;
using FreeQuant.Charting;
using FreeQuant.Instruments;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing.RoundTrips
{
  public class RoundTrip : IDrawable
  {
    protected DateTime entryDateTime;
    protected DateTime exitDateTime;
    protected PositionSide tradePosition;
    protected Instrument instrument;
    protected Position position;
    protected double amount;
    protected double entryPrice;
    protected double exitPrice;
    protected double entryCost;
    protected double exitCost;
    protected double roundTripHighPrice;
    protected double roundTripLowPrice;
    protected double entryValue;
    protected double exitValue;
    protected RoundTripStatus status;
    protected DoubleSeries series;
    public EventHandler Updated;

    public RoundTripStatus Status
    {
       get
      {
        return this.status;
      }
    }

    public DateTime EntryDateTime
    {
       get
      {
        return this.entryDateTime;
      }
       set
      {
        this.entryDateTime = value;
      }
    }

    public DateTime ExitDateTime
    {
       get
      {
        return this.exitDateTime;
      }
       set
      {
        this.exitDateTime = value;
      }
    }

    public PositionSide TradePosition
    {
       get
      {
        return this.tradePosition;
      }
       set
      {
        this.tradePosition = value;
      }
    }

    public Instrument Instrument
    {
       get
      {
        return this.instrument;
      }
       set
      {
        this.instrument = value;
      }
    }

    public double EntryPrice
    {
       get
      {
        return this.entryPrice;
      }
    }

    public double ExitPrice
    {
       get
      {
        return this.exitPrice;
      }
    }

    public double EntryValue
    {
       get
      {
        return this.entryValue;
      }
    }

    public double ExitValue
    {
       get
      {
        return this.exitValue;
      }
    }

    public double Amount
    {
       get
      {
        return this.amount;
      }
    }

    public double EntryCost
    {
       get
      {
        return this.entryCost;
      }
    }

    public double ExitCost
    {
       get
      {
        return this.exitCost;
      }
    }

    public string DurationToString
    {
       get
      {
        long ticks = this.exitDateTime.Ticks - this.entryDateTime.Ticks;
        if (ticks <= 0L)
          return "";
        if ((ticks + 1L) % 864000000000L == 0L)
          ++ticks;
        string str = "";
        TimeSpan timeSpan = new TimeSpan(ticks);
        if (timeSpan.Days != 0)
          str = str + timeSpan.Days.ToString();
        if (timeSpan.Hours != 0)
          str = str + timeSpan.Hours.ToString() ;
        if (timeSpan.Minutes != 0)
          str = str + timeSpan.Minutes.ToString();
        return str;
      }
    }

    public double RoundTripHighPrice
    {
       get
      {
        return this.roundTripHighPrice;
      }
    }

    public double RoundTripLowPrice
    {
       get
      {
        return this.roundTripLowPrice;
      }
    }

    public double RoundTripResultWithCost
    {
       get
      {
        return this.RoundTripResultWithoutCost - (this.entryCost + this.exitCost);
      }
    }

    public double RoundTripResultWithoutCost
    {
       get
      {
        if (this.tradePosition == PositionSide.Long)
          return FreeQuant.Instruments.Currency.Convert(this.exitPrice - this.entryPrice, this.position.Currency, this.position.Portfolio.Account.Currency);
        else
          return FreeQuant.Instruments.Currency.Convert(this.entryPrice - this.exitPrice, this.position.Currency, this.position.Portfolio.Account.Currency);
      }
    }

    public double EntryEfficiency
    {
       get
      {
        if (Math.Abs(this.roundTripHighPrice - this.roundTripLowPrice) < 4.94065645841247E-324)
          return double.NaN;
        if (this.tradePosition == PositionSide.Long)
          return (this.roundTripHighPrice - this.entryPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
        else
          return (this.entryPrice - this.roundTripLowPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
      }
    }

    public double ExitEfficiency
    {
       get
      {
        if (Math.Abs(this.roundTripHighPrice - this.roundTripLowPrice) < 4.94065645841247E-324)
          return double.NaN;
        if (this.tradePosition == PositionSide.Long)
          return (this.exitPrice - this.roundTripLowPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
        else
          return (this.roundTripHighPrice - this.exitPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
      }
    }

    public double TotalEfficiency
    {
       get
      {
        if (Math.Abs(this.roundTripHighPrice - this.roundTripLowPrice) < 4.94065645841247E-324)
          return double.NaN;
        if (this.tradePosition == PositionSide.Long)
          return (this.exitPrice - this.entryPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
        else
          return (this.entryPrice - this.exitPrice) / (this.roundTripHighPrice - this.roundTripLowPrice);
      }
    }

    public string ToolTipFormat
    {
       get
      {
        return (string) null;
      }
       set
      {
      }
    }

    public bool ToolTipEnabled
    {
       get
      {
        return false;
      }
       set
      {
      }
    }

    
    public RoundTrip(Position Position, Instrument Instrument, PositionSide TradePosition, double Amount, double EntryPrice, double ExitPrice, DateTime EntryDateTime, DateTime ExitDateTime, RoundTripStatus Status)
			: base() {
      this.position = Position;
      this.instrument = Instrument;
      this.tradePosition = TradePosition;
      this.amount = Amount;
      this.entryPrice = EntryPrice;
      this.exitPrice = ExitPrice;
      this.entryDateTime = EntryDateTime;
      this.exitDateTime = ExitDateTime;
      this.entryCost = 0.0;
      this.exitCost = 0.0;
      this.entryValue = EntryPrice * Amount;
      this.exitValue = ExitPrice * Amount;
      this.roundTripLowPrice = EntryPrice;
      this.roundTripHighPrice = EntryPrice;
      this.status = Status;
      if (this.status != RoundTripStatus.Opened)
        return;
      this.series = new DoubleSeries();
      this.series.Add(EntryDateTime, this.entryPrice);
      this.Connect();
    }

    
    public RoundTrip(Position Position, Instrument Instrument, PositionSide TradePosition, double Amount, double EntryPrice, double ExitPrice, DateTime EntryDateTime, DateTime ExitDateTime)
			:base() 
		{
 
      this.position = Position;
      this.instrument = Instrument;
      this.tradePosition = TradePosition;
      this.amount = Amount;
      this.entryPrice = EntryPrice;
      this.exitPrice = ExitPrice;
      this.entryDateTime = EntryDateTime;
      this.exitDateTime = ExitDateTime;
      this.entryCost = 0.0;
      this.exitCost = 0.0;
      this.entryValue = EntryPrice * Amount;
      this.exitValue = ExitPrice * Amount;
      this.roundTripLowPrice = EntryPrice;
      this.roundTripHighPrice = EntryPrice;
      this.status = RoundTripStatus.Closed;
    }

    
    public void Close(DateTime exitDate)
    {
      this.status = RoundTripStatus.Closed;
      this.exitDateTime = exitDate;
      this.exitPrice = this.position.Transactions[1].Price;
      this.roundTripHighPrice = Math.Max(this.roundTripHighPrice, this.exitPrice);
      this.roundTripLowPrice = Math.Min(this.roundTripLowPrice, this.exitPrice);
      this.series.Add(this.exitDateTime, this.exitPrice);
      this.Disconnect();
      this.ddEzhORsd();
    }

    
    public void Cancel()
    {
      this.status = RoundTripStatus.Canceled;
      this.Disconnect();
      this.ddEzhORsd();
    }

    
    protected void Connect()
    {
      this.position.ValueChanged += new EventHandler(this.sejlK1ALD);
    }

    
    protected void Disconnect()
    {
      this.position.ValueChanged -= new EventHandler(this.sejlK1ALD);
    }

    
    public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      Graphics graphics = Pad.Graphics;
      Pen pen1 = new Pen(Color.Black);
      Pen pen2 = new Pen(Color.Purple, 2f);
      Pen pen3 = new Pen(Color.Blue, 2f);
      Color baseColor1;
      Color baseColor2;
      if (this.RoundTripResultWithoutCost > 0.0)
      {
        baseColor1 = Color.Green;
        baseColor2 = Color.LightGreen;
      }
      else
      {
        baseColor1 = Color.Red;
        baseColor2 = Color.Pink;
      }
      float num1 = (float) Pad.ClientX(MinX);
      float num2 = (float) Pad.ClientX(MaxX);
      float num3 = (float) Pad.ClientY(MinY);
      float num4 = (float) Pad.ClientY(MaxY);
      DateTime dateTime1 = this.EntryDateTime.AddTicks(-(this.ExitDateTime - this.EntryDateTime).Ticks / 4L);
      DateTime dateTime2 = this.ExitDateTime.AddTicks((this.ExitDateTime - this.EntryDateTime).Ticks / 4L);
      float num5 = (float) this.series.GetMax(dateTime1, dateTime2);
      float num6 = (float) this.series.GetMin(dateTime1, dateTime2);
      float width = (float) (((double) num2 - (double) num1) / 3.0);
      float height1 = (float) (((double) num3 - (double) num4) * 2.0 / 3.0 * Math.Abs(this.exitPrice - this.entryPrice) / ((double) num5 - (double) num6));
      float height2 = (float) (((double) num3 - (double) num4) / 10.0);
      float num7 = num1 + (float) (((double) num2 - (double) num1) / 2.0);
      float num8 = this.entryPrice <= this.exitPrice ? (float) ((double) num4 + ((double) num3 - (double) num4) / 6.0 + ((double) num3 - (double) num4) * 2.0 / 3.0 * ((double) num5 - this.entryPrice) / ((double) num5 - (double) num6)) - height1 / 2f : (float) ((double) num4 + ((double) num3 - (double) num4) / 6.0 + ((double) num3 - (double) num4) * 2.0 / 3.0 * ((double) num5 - this.entryPrice) / ((double) num5 - (double) num6)) + height1 / 2f;
      graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb(170, baseColor2)), num7 - width / 2f, num8 - height1 / 2f, width, height1);
      graphics.FillEllipse((Brush) new SolidBrush(Color.White), num7 - width / 2f, (float) ((double) num8 + (double) height1 / 2.0 - (double) height2 / 2.0), width, height2);
      graphics.FillEllipse((Brush) new SolidBrush(Color.White), num7 - width / 2f, (float) ((double) num8 - (double) height1 / 2.0 - (double) height2 / 2.0), width, height2);
      graphics.FillEllipse((Brush) new SolidBrush(Color.FromArgb(170, baseColor1)), num7 - width / 2f, (float) ((double) num8 + (double) height1 / 2.0 - (double) height2 / 2.0), width, height2);
      graphics.FillEllipse((Brush) new SolidBrush(Color.FromArgb(170, baseColor1)), num7 - width / 2f, (float) ((double) num8 - (double) height1 / 2.0 - (double) height2 / 2.0), width, height2);
      float num9 = 0.0f;
      float num10 = 0.0f;
      for (int index = 0; index < this.series.Count; ++index)
      {
        float num11 = (float) ((double) (this.series.GetDateTime(index) - this.EntryDateTime).Ticks / (double) (this.ExitDateTime - this.EntryDateTime).Ticks * (double) width + (double) num7 - (double) width / 2.0);
        float num12 = (float) (((double) num5 - this.series[index]) / ((double) num5 - (double) num6) * ((double) num3 - (double) num4) * 2.0 / 3.0 + ((double) num3 - (double) num4) / 6.0) + num4;
        if ((double) num9 != 0.0 && (double) num10 != 0.0)
        {
          if (this.series.GetDateTime(index) <= this.EntryDateTime || this.series.GetDateTime(index) > this.ExitDateTime)
          {
            graphics.DrawLine(pen3, num11, num12, num9, num10);
            num9 = num11;
            num10 = num12;
            continue;
          }
          else if ((double) num10 > (double) num8 - (double) height1 / 2.0 && (double) num12 < (double) num8 - (double) height1 / 2.0)
          {
            float num13 = num9 + (float) (((double) num11 - (double) num9) * ((double) num10 - (double) num8 + (double) height1 / 2.0) / ((double) num10 - (double) num12));
            graphics.DrawLine(pen2, num9, num10, num13, num8 - height1 / 2f);
            graphics.DrawLine(pen3, num13, num8 - height1 / 2f, num11, num12);
          }
          else if ((double) num10 < (double) num8 + (double) height1 / 2.0 && (double) num12 > (double) num8 + (double) height1 / 2.0)
          {
            float num13 = num9 + (float) (((double) num11 - (double) num9) * ((double) num8 + (double) height1 / 2.0 - (double) num10) / ((double) num12 - (double) num10));
            graphics.DrawLine(pen2, num9, num10, num13, num8 + height1 / 2f);
            graphics.DrawLine(pen3, num13, num8 + height1 / 2f, num11, num12);
          }
          else if ((double) num10 < (double) num8 - (double) height1 / 2.0 && (double) num12 > (double) num8 - (double) height1 / 2.0)
          {
            float num13 = num9 + (float) (((double) num11 - (double) num9) * ((double) num8 - (double) height1 / 2.0 - (double) num10) / ((double) num12 - (double) num10));
            graphics.DrawLine(pen3, num9, num10, num13, num8 - height1 / 2f);
            graphics.DrawLine(pen2, num13, num8 - height1 / 2f, num11, num12);
          }
          else if ((double) num10 > (double) num8 + (double) height1 / 2.0 && (double) num12 < (double) num8 + (double) height1 / 2.0)
          {
            float num13 = num9 + (float) (((double) num11 - (double) num9) * ((double) num10 - (double) num8 - (double) height1 / 2.0) / ((double) num10 - (double) num12));
            graphics.DrawLine(pen3, num9, num10, num13, num8 + height1 / 2f);
            graphics.DrawLine(pen2, num13, num8 + height1 / 2f, num11, num12);
          }
          else if ((double) num10 < (double) num8 - (double) height1 / 2.0 && (double) num12 < (double) num8 - (double) height1 / 2.0 || (double) num10 > (double) num8 + (double) height1 / 2.0 && (double) num12 > (double) num8 + (double) height1 / 2.0)
            graphics.DrawLine(pen3, num11, num12, num9, num10);
          else if ((double) num10 >= (double) num8 - (double) height1 / 2.0 && (double) num12 >= (double) num8 - (double) height1 / 2.0 && ((double) num10 <= (double) num8 + (double) height1 / 2.0 && (double) num12 <= (double) num8 + (double) height1 / 2.0))
            graphics.DrawLine(pen2, num11, num12, num9, num10);
          else
            graphics.DrawLine(pen3, num11, num12, num9, num10);
        }
        num9 = num11;
        num10 = num12;
      }
      graphics.DrawEllipse(pen1, num7 - width / 2f, (float) ((double) num8 + (double) height1 / 2.0 - (double) height2 / 2.0), width, height2);
      graphics.DrawLine(pen1, num7 - width / 2f, num8 - height1 / 2f, num7 - width / 2f, num8 + height1 / 2f);
      graphics.DrawLine(pen1, num7 + width / 2f, num8 - height1 / 2f, num7 + width / 2f, num8 + height1 / 2f);
      graphics.DrawEllipse(pen1, num7 - width / 2f, (float) ((double) num8 - (double) height1 / 2.0 - (double) height2 / 2.0), width, height2);
    }

    
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }

    
    public void Draw()
    {
      Chart.Pad.Add((IDrawable) this);
      Chart.Pad.SetRange(0.0, 100.0, 0.0, 100.0);
    }

    
    private void sejlK1ALD([In] object obj0, [In] EventArgs obj1)
    {
      this.Update(true);
    }

    
    public void Update()
    {
      this.Update(false);
    }

    
    public void Update(bool force)
    {
      if (!(this.exitDateTime != Clock.Now) && !force)
        return;
      this.exitDateTime = Clock.Now;
      this.exitPrice = this.instrument.Price();
      this.roundTripHighPrice = Math.Max(this.roundTripHighPrice, this.exitPrice);
      this.roundTripLowPrice = Math.Min(this.roundTripLowPrice, this.exitPrice);
      this.ddEzhORsd();
    }

    
    private void ddEzhORsd()
    {
      if (this.Updated == null)
        return;
      this.Updated((object) this, EventArgs.Empty);
    }
  }
}
