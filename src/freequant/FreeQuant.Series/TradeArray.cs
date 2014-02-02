using FreeQuant.Charting;
using FreeQuant.Data;
using System;
using System.Drawing;
using System.Text;

namespace FreeQuant.Series
{
  public class TradeArray : DataArray, IDrawable, IZoomable
  {
    private bool toolTipEnabled;
    private string toolTipFormat;
    private string toolTipDateTimeFormat;
    private Color color;

		new public Trade this[int index]
    {
       get
      {
        return this.list[index] as Trade;
      }
    }

    public Color Color
    {
       get
      {
				return this.color; 
      }
       set
      {
        this.color = value;
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

    public string ToolTipDateTimeFormat
    {
       get
      {
				return this.toolTipDateTimeFormat; 
      }
       set
      {
        this.toolTipDateTimeFormat = value;
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

    
		public TradeArray() : base()
    {
      this.toolTipEnabled = true;
			this.toolTipFormat = "toolTipFormat";
			this.toolTipDateTimeFormat = "toolTipDateTimeFormat";
      this.color = Color.Black;
    }

    
    public double GetMinPrice()
    {
      if (this.Count == 0)
        return 0.0;
      double num = double.MaxValue;
      foreach (Trade trade in (DataArray) this)
      {
        if (trade.Price < num)
          num = trade.Price;
      }
      return num;
    }

    
    public double GetMaxPrice()
    {
      if (this.Count == 0)
        return 0.0;
      double num = double.MinValue;
      foreach (Trade trade in (DataArray) this)
      {
        if (trade.Price > num)
          num = trade.Price;
      }
      return num;
    }

    
    public void Paint(Pad pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      Pen pen = new Pen(this.color);
      int num1 = 0;
      double num2 = 0.0;
      double num3 = 0.0;
      int x1 = 0;
      int x2 = 0;
      int y1 = 0;
      int y2 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      DateTime datetime1 = new DateTime((long) MinX);
      DateTime datetime2 = new DateTime((long) MaxX);
      int num8 = !(datetime1 < this.FirstDateTime) ? this.GetIndex(datetime1) : 0;
      int num9 = !(datetime2 > this.LastDateTime) ? this.GetIndex(datetime2) : this.Count - 1;
      if (num8 < 0 || num9 < 0)
        return;
      for (int index = num8; index <= num9; ++index)
      {
        Trade trade = this[index];
        double num10 = (double) trade.DateTime.Ticks;
        double price = trade.Price;
        if (num1 != 0 && price != 0.0 && num3 != 0.0)
        {
          x1 = pad.ClientX(num2);
          y1 = pad.ClientY(num3);
          x2 = pad.ClientX(num10);
          y2 = pad.ClientY(price);
          if ((pad.IsInRange(num10, price) || pad.IsInRange(num2, num3)) && (x1 != num4 || x2 != num5 || (y1 != num6 || y2 != num7)))
            pad.Graphics.DrawLine(pen, x1, y1, x2, y2);
        }
        num4 = x1;
        num6 = y1;
        num5 = x2;
        num7 = y2;
        num2 = num10;
        num3 = price;
        ++num1;
      }
    }

    
    public TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      foreach (Trade trade in (DataArray) this)
      {
        double num1 = Math.Abs(X - (double) trade.DateTime.Ticks);
        double num2 = Math.Abs(Y - trade.Price);
        if (num1 < tdistance.dX && num2 < tdistance.dY)
        {
          tdistance.dX = num1;
          tdistance.dY = num2;
          tdistance.X = (double) trade.DateTime.Ticks;
          tdistance.Y = trade.Price;
        }
      }
      if (tdistance.dX == double.MaxValue || tdistance.dY == double.MaxValue)
        return (TDistance) null;
      DateTime dateTime = new DateTime((long) tdistance.X);
      StringBuilder stringBuilder = new StringBuilder();
//      stringBuilder.AppendFormat(this.toolTipFormat, (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(60), (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(84), (object) dateTime.ToString(this.toolTipDateTimeFormat), (object) tdistance.Y);
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    
    public void Draw()
    {
      if (Chart.Pad == null)
      {
				Canvas canvas = new Canvas("CName", "CTitle");
      }
      Chart.Pad.Add((IDrawable) this);
      Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
			Chart.Pad.AxisBottom.LabelFormat = "lblFormat";
      double num1 = (double) this.FirstDateTime.Ticks;
      double num2 = (double) this.LastDateTime.Ticks;
      double minPrice = this.GetMinPrice();
      double maxPrice = this.GetMaxPrice();
      Chart.Pad.SetRange(num1 - (num2 - num1) / 20.0, num2 + (num2 - num1) / 20.0, minPrice - (maxPrice - minPrice) / 20.0, maxPrice + (maxPrice - minPrice) / 20.0);
    }

    
    public bool IsPadRangeY()
    {
      return true;
    }

    
    public PadRange GetPadRangeY(Pad pad)
    {
      if (this.Count == 0)
        return new PadRange(0.0, 0.0);
      double min = double.MaxValue;
      double max = double.MinValue;
      DateTime datetime1 = new DateTime((long) pad.XMin);
      DateTime datetime2 = new DateTime((long) pad.XMax);
      if (this.Count > 0)
      {
        int num1 = !(datetime1 <= this.FirstDateTime) ? this.GetIndex(datetime1) : 0;
        int num2 = !(datetime2 >= this.LastDateTime) ? this.GetIndex(datetime2) : this.Count - 1;
        if (num1 == -1)
          return new PadRange(0.0, 0.0);
        for (int index = num1; index < num2; ++index)
        {
          Trade trade = this[index];
          if (trade.Price > max && trade.Price != 0.0)
            max = trade.Price;
          if (trade.Price < min && trade.Price != 0.0)
            min = trade.Price;
        }
      }
      return new PadRange(min, max);
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
