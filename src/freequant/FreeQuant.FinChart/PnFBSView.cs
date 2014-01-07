// Type: SmartQuant.FinChart.PnFBSView
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using SmartQuant.Data;
using SmartQuant.Indicators;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class PnFBSView : SeriesView
  {
    private BarSeries lv0J05VbR1;
    private Color m7vJrqqdI4;
    private Color UUfJKgNeH7;
    private Color gKtJiYQi50;
    private PointAndFigure pGlJXklPGE;

    [Category("Color scheme")]
    public Color UpColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.m7vJrqqdI4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.m7vJrqqdI4 = value;
      }
    }

    [Category("Color scheme")]
    public Color DownColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UUfJKgNeH7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.UUfJKgNeH7 = value;
      }
    }

    [Category("Color scheme")]
    public override Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.pGlJXklPGE[this.lastDate].Open > this.pGlJXklPGE[this.lastDate].Close)
          return this.m7vJrqqdI4;
        else
          return this.UUfJKgNeH7;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gKtJiYQi50 = value;
      }
    }

    public override double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.lastDate == this.pGlJXklPGE.LastDateTime)
          return this.lv0J05VbR1.Last.Close;
        else
          return this.lv0J05VbR1[this.lastDate, EIndexOption.Prev].Close;
      }
    }

    public override TimeSeries MainSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (TimeSeries) this.pGlJXklPGE;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PnFBSView(Pad pad, BarSeries series, double boxSize, int reversalAmount)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.m7vJrqqdI4 = Color.OrangeRed;
      this.UUfJKgNeH7 = Color.LawnGreen;
      this.gKtJiYQi50 = Color.FromArgb(0, (int) byte.MaxValue, 0);
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.lv0J05VbR1 = series;
      this.pad = pad;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2322);
      this.pGlJXklPGE = new PointAndFigure(series, boxSize, reversalAmount);
      this.pGlJXklPGE.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PadRange GetPadRangeY(Pad Pad)
    {
      return new PadRange(this.pGlJXklPGE.LowestLow(this.firstDate, this.lastDate), this.pGlJXklPGE.HighestHigh(this.firstDate, this.lastDate));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate()
    {
      this.pGlJXklPGE.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint()
    {
      Pen pen1 = new Pen(this.m7vJrqqdI4);
      Pen pen2 = new Pen(this.UUfJKgNeH7);
      int index1 = this.pGlJXklPGE.GetIndex(this.firstDate);
      int index2 = this.pGlJXklPGE.GetIndex(this.lastDate);
      if (index2 == -1 || index2 == -1)
        return;
      int width = Math.Max(2, (int) this.pad.IntervalWidth);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num = this.pad.ClientX(this.pGlJXklPGE.GetDateTime(index3));
        PnF pnF = this.pGlJXklPGE[index3];
        double low = pnF.Low;
        while (low < pnF.High)
        {
          if (pnF.Kind == PnFKind.Down)
          {
            this.pad.Graphics.DrawEllipse(pen1, num - width / 2, this.pad.ClientY(low), width, this.pad.ClientY(low + pnF.BoxSize) - this.pad.ClientY(low));
          }
          else
          {
            this.pad.Graphics.DrawLine(pen2, num - width / 2, this.pad.ClientY(low), num + width / 2, this.pad.ClientY(low + pnF.BoxSize));
            this.pad.Graphics.DrawLine(pen2, num + width / 2, this.pad.ClientY(low), num - width / 2, this.pad.ClientY(low + pnF.BoxSize));
          }
          low += pnF.BoxSize;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      PnF pnF = this.pGlJXklPGE[this.pad.GetDateTime(x)];
      distance.DX = 0.0;
      if (y >= pnF.Low && y <= pnF.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.lv0J05VbR1.Name, (object) this.lv0J05VbR1.Title, (object) pnF.DateTime.ToString(this.lv0J05VbR1.ToolTipDateTimeFormat), (object) pnF.High, (object) pnF.Low, (object) pnF.Open, (object) pnF.Close, (object) pnF.Volume);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
