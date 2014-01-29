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
    private DoubleSeries mainSeries;
    private Color KNRy1kSrcC;
    private SimpleDSStyle style;
    private EIndexOption options;
    private SmoothingMode IXfyvDxxVL;

    public EIndexOption Option
    {
       get
      {
				return this.options; 
      }
    }

		public SimpleDSStyle Style 
    {
       get
      {
				return this.style; 
      }
       set
      {
        this.style = value;
      }
    }

    public override TimeSeries MainSeries
    {
       get
      {
				return this.mainSeries; 
      }
    }

    public override Color Color
    {
       get
      {
        return this.mainSeries.Color;
      }
       set
      {
        this.mainSeries.Color = value;
      }
    }

    public override double LastValue
    {
       get
      {
        if (this.mainSeries.Count == 0 || this.lastDate < this.mainSeries.FirstDateTime)
          return double.NaN;
        if (this.options == EIndexOption.Null)
          return this.mainSeries[this.lastDate, EIndexOption.Prev];
        if (this.options == EIndexOption.Next)
          return this.mainSeries[this.lastDate.AddTicks(1L), EIndexOption.Next];
        else
          return -1.0;
      }
    }

    
		public DSView(Pad pad, DoubleSeries series) : this(pad, series, EIndexOption.Null)
    {
      this.mainSeries = series;
			this.ToolTipFormat = "toool";
//			this.ToolTipFormat = this.ToolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2702), pad.Chart.LabelDigitsCount.ToString());
    }

    
		public DSView(Pad pad, DoubleSeries series, Color color) :  this(pad, series, color, EIndexOption.Null, SmoothingMode.AntiAlias)
    {
      this.mainSeries = series;
      this.KNRy1kSrcC = color;
			this.ToolTipFormat = "toool";
//			this.ToolTipFormat = this.ToolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2744), pad.Chart.LabelDigitsCount.ToString());
    }

    
		public DSView(Pad pad, DoubleSeries series, EIndexOption option): base(pad)
    {
      this.KNRy1kSrcC = Color.White;
      this.IXfyvDxxVL = SmoothingMode.AntiAlias;
      this.mainSeries = series;
      this.options = option;
			this.ToolTipFormat = "toool";
//			this.ToolTipFormat = this.ToolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2786), pad.Chart.LabelDigitsCount.ToString());
    }

    
    public DSView(Pad pad, DoubleSeries series, Color color, EIndexOption option, SmoothingMode smoothing)
			: base(pad) 
		{
      this.KNRy1kSrcC = Color.White;
      this.IXfyvDxxVL = SmoothingMode.AntiAlias;
      this.mainSeries = series;
      this.options = option;
      this.KNRy1kSrcC = color;
      this.IXfyvDxxVL = smoothing;
			this.ToolTipFormat = "toool";
//			this.ToolTipFormat = this.toolTipFormat.Replace(FJDHryrxb1WIq5jBAt.mT707pbkgT(2828), pad.Chart.LabelDigitsCount.ToString());
    }

    
    public override PadRange GetPadRangeY(Pad Pad)
    {
      DateTime dateTime1;
      DateTime dateTime2;
      if (this.options == EIndexOption.Null)
      {
        dateTime1 = this.firstDate;
        dateTime2 = this.lastDate;
      }
      else
      {
        int index1 = this.mainSeries.GetIndex(this.firstDate.AddTicks(1L), EIndexOption.Next);
        int index2 = this.mainSeries.GetIndex(this.lastDate.AddTicks(1L), EIndexOption.Next);
        if (index1 == -1 || index2 == -1)
          return new PadRange(0.0, 0.0);
        dateTime1 = this.mainSeries.GetDateTime(index1);
        dateTime2 = this.mainSeries.GetDateTime(index2);
      }
      if (this.mainSeries.Count == 0 || !(this.mainSeries.LastDateTime >= dateTime1) || !(this.mainSeries.FirstDateTime <= dateTime2))
        return new PadRange(0.0, 0.0);
      int index3 = this.mainSeries.GetIndex(dateTime1, EIndexOption.Next);
      int index4 = this.mainSeries.GetIndex(dateTime2, EIndexOption.Prev);
      double min = this.mainSeries.GetMin(Math.Min(index3, index4), Math.Max(index3, index4));
      double max = this.mainSeries.GetMax(Math.Min(index3, index4), Math.Max(index3, index4));
      if (min >= max)
      {
        double num = Math.Abs(min) / 1000.0;
        min -= num;
        max += num;
      }
      return new PadRange(min, max);
    }

    
    public override void Paint()
    {
      Pen pen = new Pen(this.mainSeries.Color, (float) this.mainSeries.DrawWidth);
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
        if (this.options == EIndexOption.Null)
        {
          if (this.mainSeries.Contains(dateTime))
            worldY1 = this.mainSeries[dateTime, EIndexOption.Next];
          else
            continue;
        }
        if (this.options == EIndexOption.Next)
        {
          if (this.mainSeries.Contains(dateTime.AddTicks(1L)))
            worldY1 = this.mainSeries[dateTime.AddTicks(1L), EIndexOption.Null];
          else if (dateTime.AddTicks(1L) >= this.mainSeries.FirstDateTime)
            worldY1 = this.mainSeries[dateTime.AddTicks(1L), EIndexOption.Next];
          else
            continue;
        }
        if (this.style == SimpleDSStyle.Line)
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
        if (this.style == SimpleDSStyle.Bar)
        {
          x1 = this.pad.ClientX(new DateTime(ticks2));
          num2 = this.pad.ClientY(worldY1);
          float y = (float) Math.Max(Math.Min(num2, val2_1), val2_2);
          float num8 = (float) Math.Min(Math.Max(num2, val2_1), val2_3);
          this.pad.Graphics.FillRectangle((Brush) new SolidBrush(this.mainSeries.Color), (float) (x1 - num7 / 2), y, (float) num7, Math.Abs(y - num8));
        }
        if (this.style == SimpleDSStyle.Circle)
        {
          x1 = this.pad.ClientX(new DateTime(ticks2));
          num2 = this.pad.ClientY(worldY1);
          Math.Max(Math.Min(num2, val2_1), val2_2);
          Math.Min(Math.Max(num2, val2_1), val2_3);
          this.pad.Graphics.FillEllipse((Brush) new SolidBrush(this.mainSeries.Color), x1 - this.mainSeries.DrawWidth, num2 - this.mainSeries.DrawWidth, this.mainSeries.DrawWidth * 2, this.mainSeries.DrawWidth * 2);
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
          if (this.mainSeries.Contains((DateTime) arrayList[index3]))
          {
            int num10 = this.pad.ClientY(this.mainSeries[(DateTime) arrayList[index3], EIndexOption.Null]);
            Color midnightBlue = Color.MidnightBlue;
            this.pad.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb((int) midnightBlue.R ^ (int) byte.MaxValue, (int) midnightBlue.G ^ (int) byte.MaxValue, (int) midnightBlue.B ^ (int) byte.MaxValue)), num9 - 2, num10 - 2, 4, 4);
          }
          index3 += num8;
        }
      }
      if (this.style != SimpleDSStyle.Line)
        return;
      SmoothingMode smoothingMode = this.pad.Graphics.SmoothingMode;
      this.pad.Graphics.SmoothingMode = this.IXfyvDxxVL;
      this.pad.Graphics.DrawPath(pen, path);
      this.pad.Graphics.SmoothingMode = smoothingMode;
    }

    
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      DateTime dateTime = this.pad.GetDateTime(x);
      double num = 0.0;
      if (this.options == EIndexOption.Null)
      {
        if (!this.mainSeries.Contains(dateTime))
          return (Distance) null;
        num = this.mainSeries[dateTime];
      }
      if (this.options == EIndexOption.Next)
      {
        if (this.mainSeries.LastDateTime < dateTime.AddTicks(1L))
          return (Distance) null;
        num = this.mainSeries[dateTime.AddTicks(1L), EIndexOption.Next];
      }
      distance.X = (double) x;
      distance.Y = num;
      distance.DX = 0.0;
      distance.DY = Math.Abs(y - num);
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return null;
      StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(this.ToolTipFormat, (object) this.mainSeries.Name, (object) this.mainSeries.Title, (object) dateTime.ToString(), (object) distance.Y);
      distance.ToolTipText = stringBuilder.ToString();
      return distance;
    }
  }
}
