// Type: SmartQuant.Series.QuoteArray
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
  public class QuoteArray : DataArray, IDrawable, IZoomable
  {
    private bool h6TXjpCYi;
    private string Xf6BjdM2C;
    private string Em2ljk11n;
    private Color RfPeZVU0q;
    private Color rc4Ks7Qtq;

    public Quote this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as Quote;
      }
    }

    public Color BidColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RfPeZVU0q;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.RfPeZVU0q = value;
      }
    }

    public Color AskColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rc4Ks7Qtq;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rc4Ks7Qtq = value;
      }
    }

    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Xf6BjdM2C;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Xf6BjdM2C = value;
      }
    }

    public string ToolTipDateTimeFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Em2ljk11n;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Em2ljk11n = value;
      }
    }

    public bool ToolTipEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.h6TXjpCYi;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.h6TXjpCYi = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuoteArray()
    {
      rMD0QtDvnkaitCE3eL.SGVusT6zsNsKR();
      this.h6TXjpCYi = true;
      this.Xf6BjdM2C = oK6F3TB73XXXGhdieP.wF6SgrNUO(170);
      this.RfPeZVU0q = Color.Red;
      this.rc4Ks7Qtq = Color.Blue;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Paint(Pad pad, double MinX, double MaxX, double MinY, double MaxY)
    {
      Pen pen1 = new Pen(this.rc4Ks7Qtq);
      Pen pen2 = new Pen(this.RfPeZVU0q);
      int num1 = 0;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = 0.0;
      int x1_1 = 0;
      int x2_1 = 0;
      int y1_1 = 0;
      int y2_1 = 0;
      int y1_2 = 0;
      int y2_2 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      int num8 = 0;
      int num9 = 0;
      int num10 = 0;
      DateTime datetime1 = new DateTime((long) MinX);
      DateTime datetime2 = new DateTime((long) MaxX);
      int num11 = !(datetime1 < this.FirstDateTime) ? this.GetIndex(datetime1) : 0;
      int num12 = !(datetime2 > this.LastDateTime) ? this.GetIndex(datetime2) : this.Count - 1;
      if (num11 < 0 || num12 < 0)
        return;
      for (int index = num11; index <= num12; ++index)
      {
        Quote quote = this[index];
        double num13 = (double) quote.DateTime.Ticks;
        double ask = quote.Ask;
        double bid = quote.Bid;
        if (num1 != 0)
        {
          int x1_2 = pad.ClientX(num2);
          y1_1 = pad.ClientY(num3);
          int x2_2 = pad.ClientX(num13);
          y2_1 = pad.ClientY(ask);
          if (ask != 0.0 && num3 != 0.0 && (pad.IsInRange(num13, ask) || pad.IsInRange(num2, num3)) && (x1_2 != num5 || x2_2 != num6 || (y1_1 != num7 || y2_1 != num8)))
            pad.Graphics.DrawLine(pen1, x1_2, y1_1, x2_2, y2_1);
          x1_1 = pad.ClientX(num2);
          y1_2 = pad.ClientY(num4);
          x2_1 = pad.ClientX(num13);
          y2_2 = pad.ClientY(bid);
          if (bid != 0.0 && num4 != 0.0 && (pad.IsInRange(num13, bid) || pad.IsInRange(num2, num4)) && (x1_1 != num5 || x2_1 != num6 || (y1_2 != num9 || y2_2 != num10)))
            pad.Graphics.DrawLine(pen2, x1_1, y1_2, x2_1, y2_2);
        }
        num7 = y1_1;
        num8 = y2_1;
        num3 = ask;
        num5 = x1_1;
        num9 = y1_2;
        num6 = x2_1;
        num10 = y2_2;
        num2 = num13;
        num4 = bid;
        ++num1;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      int index = this.GetIndex(new DateTime((long) X));
      if (index == -1)
        return (TDistance) null;
      Quote quote = this[index];
      double num = Math.Abs(X - (double) quote.DateTime.Ticks);
      double val1 = Math.Abs(Y - quote.Ask);
      double val2 = Math.Abs(Y - quote.Bid);
      tdistance.dX = num;
      tdistance.dY = Math.Min(val1, val2);
      tdistance.X = (double) quote.DateTime.Ticks;
      tdistance.Y = Y;
      if (quote == null)
        return (TDistance) null;
      DateTime dateTime = new DateTime((long) tdistance.X);
      StringBuilder stringBuilder = new StringBuilder();
      this.Xf6BjdM2C = oK6F3TB73XXXGhdieP.wF6SgrNUO(194);
      stringBuilder.AppendFormat(this.Xf6BjdM2C, (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(254), (object) dateTime.ToString(this.Em2ljk11n), (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(278), (object) quote.Bid, (object) oK6F3TB73XXXGhdieP.wF6SgrNUO(288), (object) quote.Ask);
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw()
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(oK6F3TB73XXXGhdieP.wF6SgrNUO(298), oK6F3TB73XXXGhdieP.wF6SgrNUO(322));
      }
      Chart.Pad.Add((IDrawable) this);
      Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
      Chart.Pad.AxisBottom.LabelFormat = oK6F3TB73XXXGhdieP.wF6SgrNUO(346);
      double num1 = (double) this.FirstDateTime.Ticks;
      double num2 = (double) this.LastDateTime.Ticks;
      double num3 = double.MaxValue;
      double num4 = double.MinValue;
      for (int index = 0; index < this.Count; ++index)
      {
        Quote quote = this[index];
        if (Math.Max(quote.Bid, quote.Ask) > num4)
          num4 = Math.Max(quote.Bid, quote.Ask);
        if (Math.Min(quote.Bid, quote.Ask) < num3)
          num3 = Math.Min(quote.Bid, quote.Ask);
      }
      double num5 = num3;
      double num6 = num4;
      Chart.Pad.SetRange(num1 - (num2 - num1) / 20.0, num2 + (num2 - num1) / 20.0, num5 - (num6 - num5) / 20.0, num6 + (num6 - num5) / 20.0);
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
      int num1 = !(datetime1 <= this.FirstDateTime) ? this.GetIndex(datetime1) : 0;
      if (num1 == -1)
        return new PadRange(0.0, 0.0);
      int num2 = !(datetime2 >= this.LastDateTime) ? this.GetIndex(datetime2) : this.Count - 1;
      for (int index = num1; index <= num2; ++index)
      {
        Quote quote = this[index];
        if (Math.Max(quote.Bid, quote.Ask) > max)
          max = Math.Max(quote.Bid, quote.Ask);
        if (Math.Min(quote.Bid, quote.Ask) < min && quote.Bid != 0.0 && quote.Ask != 0.0)
          min = Math.Min(quote.Bid, quote.Ask);
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
