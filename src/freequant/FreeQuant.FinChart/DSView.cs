using FreeQuant.Series;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.FinChart
{
  public class DSView : SeriesView
  {
    private DoubleSeries J3CyTcOdfO;
    private Color KNRy1kSrcC;
    private SimpleDSStyle FfryUetNii;
    private EIndexOption KQFylhRfSj;
    private SmoothingMode IXfyvDxxVL;

    public EIndexOption Option
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KQFylhRfSj;
      }
    }

    public SimpleDSStyle Style
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FfryUetNii;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.FfryUetNii = value;
      }
    }

    public override TimeSeries MainSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (TimeSeries) this.J3CyTcOdfO;
      }
    }

    public override Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.J3CyTcOdfO.Color;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.J3CyTcOdfO.Color = value;
      }
    }

    public override double LastValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.J3CyTcOdfO.Count == 0 || this.lastDate < this.J3CyTcOdfO.FirstDateTime)
          return double.NaN;
        if (this.KQFylhRfSj == EIndexOption.Null)
          return this.J3CyTcOdfO[this.lastDate, EIndexOption.Prev];
        if (this.KQFylhRfSj == EIndexOption.Next)
          return this.J3CyTcOdfO[this.lastDate.AddTicks(1L), EIndexOption.Next];
        else
          return -1.0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DSView(Pad pad, DoubleSeries series)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      this.\u002Ector(pad, series, EIndexOption.Null);
      this.J3CyTcOdfO = series;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2666);
      this.toolTipFormat = this.toolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2702), pad.Chart.LabelDigitsCount.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DSView(Pad pad, DoubleSeries series, Color color)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      this.\u002Ector(pad, series, color, EIndexOption.Null, SmoothingMode.AntiAlias);
      this.J3CyTcOdfO = series;
      this.KNRy1kSrcC = color;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2708);
      this.toolTipFormat = this.toolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2744), pad.Chart.LabelDigitsCount.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DSView(Pad pad, DoubleSeries series, EIndexOption option)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.KNRy1kSrcC = Color.White;
      this.IXfyvDxxVL = SmoothingMode.AntiAlias;
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.J3CyTcOdfO = series;
      this.KQFylhRfSj = option;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2750);
      this.toolTipFormat = this.toolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2786), pad.Chart.LabelDigitsCount.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DSView(Pad pad, DoubleSeries series, Color color, EIndexOption option, SmoothingMode smoothing)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.KNRy1kSrcC = Color.White;
      this.IXfyvDxxVL = SmoothingMode.AntiAlias;
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.J3CyTcOdfO = series;
      this.KQFylhRfSj = option;
      this.KNRy1kSrcC = color;
      this.IXfyvDxxVL = smoothing;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2792);
      this.toolTipFormat = this.toolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2828), pad.Chart.LabelDigitsCount.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PadRange GetPadRangeY(Pad Pad)
    {
      DateTime dateTime1;
      DateTime dateTime2;
      if (this.KQFylhRfSj == EIndexOption.Null)
      {
        dateTime1 = this.firstDate;
        dateTime2 = this.lastDate;
      }
      else
      {
        int index1 = this.J3CyTcOdfO.GetIndex(this.firstDate.AddTicks(1L), EIndexOption.Next);
        int index2 = this.J3CyTcOdfO.GetIndex(this.lastDate.AddTicks(1L), EIndexOption.Next);
        if (index1 == -1 || index2 == -1)
          return new PadRange(0.0, 0.0);
        dateTime1 = this.J3CyTcOdfO.GetDateTime(index1);
        dateTime2 = this.J3CyTcOdfO.GetDateTime(index2);
      }
      if (this.J3CyTcOdfO.Count == 0 || !(this.J3CyTcOdfO.LastDateTime >= dateTime1) || !(this.J3CyTcOdfO.FirstDateTime <= dateTime2))
        return new PadRange(0.0, 0.0);
      int index3 = this.J3CyTcOdfO.GetIndex(dateTime1, EIndexOption.Next);
      int index4 = this.J3CyTcOdfO.GetIndex(dateTime2, EIndexOption.Prev);
      double min = this.J3CyTcOdfO.GetMin(Math.Min(index3, index4), Math.Max(index3, index4));
      double max = this.J3CyTcOdfO.GetMax(Math.Min(index3, index4), Math.Max(index3, index4));
      if (min >= max)
      {
        double num = Math.Abs(min) / 1000.0;
        min -= num;
        max += num;
      }
      return new PadRange(min, max);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint()
    {
      Pen pen = new Pen(this.J3CyTcOdfO.Color, (float) this.J3CyTcOdfO.DrawWidth);
      int num1 = 0;
      GraphicsPath path = new GraphicsPath();
      List<Point> list = new List<Point>();
      double worldY1 = 0.0;
      long ticks1 = 0L;
      double worldY2 = 0.0;
      int x1 = 0;
      int x2 = 0;
      int num2 = 0;
      int y2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int index1 = this.pad.MainSeries.GetIndex(this.firstDate);
      int index2 = this.pad.MainSeries.GetIndex(this.lastDate);
      ArrayList arrayList = (ArrayList) null;
      int val2_1 = this.pad.ClientY(0.0);
      int val2_2 = this.pad.ClientY(this.pad.MaxValue);
      int val2_3 = this.pad.ClientY(this.pad.MinValue);
      if (this.selected)
        arrayList = new ArrayList();
      int num7 = (int) Math.Max(2.0, (double) (int) this.pad.IntervalWidth / 1.2);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        DateTime dateTime = this.pad.MainSeries.GetDateTime(index3);
        if (this.selected)
          arrayList.Add((object) dateTime);
        long ticks2 = dateTime.Ticks;
        if (this.KQFylhRfSj == EIndexOption.Null)
        {
          if (this.J3CyTcOdfO.Contains(dateTime))
            worldY1 = this.J3CyTcOdfO[dateTime, EIndexOption.Next];
          else
            continue;
        }
        if (this.KQFylhRfSj == EIndexOption.Next)
        {
          if (this.J3CyTcOdfO.Contains(dateTime.AddTicks(1L)))
            worldY1 = this.J3CyTcOdfO[dateTime.AddTicks(1L), EIndexOption.Null];
          else if (dateTime.AddTicks(1L) >= this.J3CyTcOdfO.FirstDateTime)
            worldY1 = this.J3CyTcOdfO[dateTime.AddTicks(1L), EIndexOption.Next];
          else
            continue;
        }
        if (this.FfryUetNii == SimpleDSStyle.Line)
        {
          if (num1 != 0)
          {
            x1 = this.pad.ClientX(new DateTime(ticks1));
            num2 = this.pad.ClientY(worldY2);
            x2 = this.pad.ClientX(new DateTime(ticks2));
            y2 = this.pad.ClientY(worldY1);
            if (x1 != num3 || x2 != num4 || (num2 != num5 || y2 != num6))
              path.AddLine(x1, num2, x2, y2);
          }
          num3 = x1;
          num5 = num2;
          num4 = x2;
          num6 = y2;
          ticks1 = ticks2;
          worldY2 = worldY1;
          list.Add(new Point(this.pad.ClientX(new DateTime(ticks1)), this.pad.ClientY(worldY2)));
        }
        if (this.FfryUetNii == SimpleDSStyle.Bar)
        {
          x1 = this.pad.ClientX(new DateTime(ticks2));
          num2 = this.pad.ClientY(worldY1);
          float y = (float) Math.Max(Math.Min(num2, val2_1), val2_2);
          float num8 = (float) Math.Min(Math.Max(num2, val2_1), val2_3);
          this.pad.Graphics.FillRectangle((Brush) new SolidBrush(this.J3CyTcOdfO.Color), (float) (x1 - num7 / 2), y, (float) num7, Math.Abs(y - num8));
        }
        if (this.FfryUetNii == SimpleDSStyle.Circle)
        {
          x1 = this.pad.ClientX(new DateTime(ticks2));
          num2 = this.pad.ClientY(worldY1);
          Math.Max(Math.Min(num2, val2_1), val2_2);
          Math.Min(Math.Max(num2, val2_1), val2_3);
          this.pad.Graphics.FillEllipse((Brush) new SolidBrush(this.J3CyTcOdfO.Color), x1 - this.J3CyTcOdfO.DrawWidth, num2 - this.J3CyTcOdfO.DrawWidth, this.J3CyTcOdfO.DrawWidth * 2, this.J3CyTcOdfO.DrawWidth * 2);
        }
        ++num1;
      }
      if (this.selected)
      {
        int num8 = Math.Max(1, (int) Math.Round((double) arrayList.Count / 8.0));
        int index3 = 1;
        while (index3 < arrayList.Count)
        {
          int num9 = this.pad.ClientX(new DateTime(((DateTime) arrayList[index3]).Ticks));
          if (this.J3CyTcOdfO.Contains((DateTime) arrayList[index3]))
          {
            int num10 = this.pad.ClientY(this.J3CyTcOdfO[(DateTime) arrayList[index3], EIndexOption.Null]);
            Color midnightBlue = Color.MidnightBlue;
            this.pad.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb((int) midnightBlue.R ^ (int) byte.MaxValue, (int) midnightBlue.G ^ (int) byte.MaxValue, (int) midnightBlue.B ^ (int) byte.MaxValue)), num9 - 2, num10 - 2, 4, 4);
          }
          index3 += num8;
        }
      }
      if (this.FfryUetNii != SimpleDSStyle.Line)
        return;
      SmoothingMode smoothingMode = this.pad.Graphics.SmoothingMode;
      this.pad.Graphics.SmoothingMode = this.IXfyvDxxVL;
      this.pad.Graphics.DrawPath(pen, path);
      this.pad.Graphics.SmoothingMode = smoothingMode;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      DateTime dateTime = this.pad.GetDateTime(x);
      double num = 0.0;
      if (this.KQFylhRfSj == EIndexOption.Null)
      {
        if (!this.J3CyTcOdfO.Contains(dateTime))
          return (Distance) null;
        num = this.J3CyTcOdfO[dateTime];
      }
      if (this.KQFylhRfSj == EIndexOption.Next)
      {
        if (this.J3CyTcOdfO.LastDateTime < dateTime.AddTicks(1L))
          return (Distance) null;
        num = this.J3CyTcOdfO[dateTime.AddTicks(1L), EIndexOption.Next];
      }
      distance.X = (double) x;
      distance.Y = num;
      distance.DX = 0.0;
      distance.DY = Math.Abs(y - num);
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.J3CyTcOdfO.Name, (object) this.J3CyTcOdfO.Title, (object) dateTime.ToString(), (object) distance.Y);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
