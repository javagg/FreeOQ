// Type: SmartQuant.Series.TradeArray
// Assembly: SmartQuant.Series, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: E9488B3A-52DD-4064-9514-4FAD9D0B10AA
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Series.dll

using mXqpVnllGuXP6crdfN;
using NEVPmg8vBnJoRISXwf;
using SmartQuant.Charting;
using SmartQuant.Data;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace SmartQuant.Series
{
  public class TradeArray : DataArray, IDrawable, IZoomable
  {
    private bool dCFo8eqJB;
    private string C093NgyJ4;
    private string XLRCXedfC;
    private Color wkT7OjPPk;

    public Trade this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as Trade;
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wkT7OjPPk;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.wkT7OjPPk = value;
      }
    }

    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.C093NgyJ4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.C093NgyJ4 = value;
      }
    }

    public string ToolTipDateTimeFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XLRCXedfC;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XLRCXedfC = value;
      }
    }

    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.dCFo8eqJB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.dCFo8eqJB = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TradeArray()
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dCFo8eqJB = true;
      this.C093NgyJ4 = oK6F3TB73XXXGhdieP.wF6SgrNUO(0);
      this.XLRCXedfC = oK6F3TB73XXXGhdieP.wF6SgrNUO(36);
      this.wkT7OjPPk = Color.Black;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint(Pad pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      Pen pen = new Pen(this.wkT7OjPPk);
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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
      stringBuilder.AppendFormat(this.C093NgyJ4, (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(60), (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(84), (object) dateTime.ToString(this.XLRCXedfC), (object) tdistance.Y);
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw()
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(oK6F3TB73XXXGhdieP.wF6SgrNUO(108), oK6F3TB73XXXGhdieP.wF6SgrNUO(132));
      }
      Chart.Pad.Add((IDrawable) this);
      Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
      Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(156);
      double num1 = (double) this.FirstDateTime.Ticks;
      double num2 = (double) this.LastDateTime.Ticks;
      double minPrice = this.GetMinPrice();
      double maxPrice = this.GetMaxPrice();
      Chart.Pad.SetRange(num1 - (num2 - num1) / 20.0, num2 + (num2 - num1) / 20.0, minPrice - (maxPrice - minPrice) / 20.0, maxPrice + (maxPrice - minPrice) / 20.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPadRangeY()
    {
      return true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
