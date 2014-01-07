// Type: SmartQuant.FinChart.SimpleBSView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class SimpleBSView : SeriesView
  {
    private BarSeries Ex2yZhZNKM;
    private SimpleBSStyle qPty45mcMb;
    private Color AeEyfmW3gV;
    private Color gj0yGh3mZ7;

    [Category("Drawing Style")]
    public Color UpColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.AeEyfmW3gV;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AeEyfmW3gV = value;
      }
    }

    [Category("Drawing Style")]
    public Color DownColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gj0yGh3mZ7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gj0yGh3mZ7 = value;
      }
    }

    public SimpleBSStyle Style
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qPty45mcMb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qPty45mcMb = value;
      }
    }

    public override TimeSeries MainSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (TimeSeries) this.Ex2yZhZNKM;
      }
    }

    [Browsable(false)]
    public override Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gj0yGh3mZ7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    public override double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Ex2yZhZNKM[this.lastDate, EIndexOption.Prev].Close;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleBSView(Pad pad, BarSeries series)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.AeEyfmW3gV = Color.Black;
      this.gj0yGh3mZ7 = Color.Lime;
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.Ex2yZhZNKM = series;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PadRange GetPadRangeY(Pad Pad)
    {
      double min = this.Ex2yZhZNKM.LowestLow(this.firstDate, this.lastDate);
      double max = this.Ex2yZhZNKM.HighestHigh(this.firstDate, this.lastDate);
      if (min >= max)
      {
        double num = min / 10.0;
        min -= num;
        max += num;
      }
      return new PadRange(min, max);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint()
    {
      Color color = this.gj0yGh3mZ7;
      Pen pen1 = new Pen(color);
      Pen pen2 = new Pen(color);
      Pen pen3 = new Pen(color);
      Brush brush1 = (Brush) new SolidBrush(this.gj0yGh3mZ7);
      Brush brush2 = (Brush) new SolidBrush(this.AeEyfmW3gV);
      long num1 = -1L;
      long num2 = -1L;
      int index1 = this.Ex2yZhZNKM.GetIndex(this.firstDate);
      int index2 = this.Ex2yZhZNKM.GetIndex(this.lastDate);
      if (index1 == -1 || index2 == -1)
        return;
      int width = (int) Math.Max(2.0, (double) (int) this.pad.IntervalWidth / 1.4);
      int num3 = 0;
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num4 = this.pad.ClientX(this.Ex2yZhZNKM.GetDateTime(index3));
        Bar bar = this.Ex2yZhZNKM[index3];
        double high = bar.High;
        double low = bar.Low;
        double open = bar.Open;
        double close = bar.Close;
        if (this.qPty45mcMb == SimpleBSStyle.Candle)
        {
          this.pad.Graphics.DrawLine(pen1, num4, this.pad.ClientY(low), num4, this.pad.ClientY(high));
          if (open != 0.0 && close != 0.0)
          {
            if (open > close)
            {
              int height = this.pad.ClientY(close) - this.pad.ClientY(open);
              if (height == 0)
                height = 1;
              this.pad.Graphics.FillRectangle(brush1, num4 - width / 2, this.pad.ClientY(open), width, height);
            }
            else
            {
              int height = this.pad.ClientY(open) - this.pad.ClientY(close);
              if (height == 0)
                height = 1;
              this.pad.Graphics.DrawRectangle(pen1, num4 - width / 2, this.pad.ClientY(close), width, height);
              this.pad.Graphics.FillRectangle(brush2, num4 - width / 2 + 1, this.pad.ClientY(close) + 1, width - 1, height - 1);
            }
          }
        }
        if (this.qPty45mcMb == SimpleBSStyle.Bar)
        {
          this.pad.Graphics.DrawLine(pen1, num4, this.pad.ClientY(low), num4, this.pad.ClientY(high));
          this.pad.Graphics.DrawLine(pen1, num4 - width / 2, this.pad.ClientY(open), num4, this.pad.ClientY(open));
          this.pad.Graphics.DrawLine(pen1, num4 + width / 2, this.pad.ClientY(close), num4, this.pad.ClientY(close));
        }
        if (this.qPty45mcMb == SimpleBSStyle.Line)
        {
          long num5 = (long) num4;
          int num6 = this.pad.ClientY(bar.Close);
          if (num1 != -1L && num2 != -1L)
            this.pad.Graphics.DrawLine(pen1, (float) num5, (float) num6, (float) num1, (float) num2);
          num1 = num5;
          num2 = (long) num6;
          ++num3;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      Bar bar = this.Ex2yZhZNKM[this.pad.GetDateTime(x)];
      distance.DX = 0.0;
      if (y >= bar.Low && y <= bar.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2834);
      this.toolTipFormat = this.toolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2958), this.pad.Chart.LabelDigitsCount.ToString());
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.Ex2yZhZNKM.Name, (object) this.Ex2yZhZNKM.Title, (object) bar.DateTime, (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
