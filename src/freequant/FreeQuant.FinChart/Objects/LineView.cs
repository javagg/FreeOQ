using FreeQuant.FinChart;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace FreeQuant.FinChart.Objects
{
  public class LineView : IChartDrawable, IZoomable
  {
    private DrawingLine VLoy6nwXZ8;
    protected Pad pad;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;
    protected DateTime chartFirstDate;
    protected DateTime chartLastDate;

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

    
    public LineView(DrawingLine line, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.VLoy6nwXZ8 = line;
      this.pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(2964);
      this.chartFirstDate = new DateTime(Math.Min(line.X1.Ticks, line.X2.Ticks));
      this.chartLastDate = new DateTime(Math.Max(line.X1.Ticks, line.X2.Ticks));
    }

    
    public void Paint()
    {
      this.RQXykfUBlu();
    }

    
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    
    public Distance Distance(int x, double y)
    {
      if (this.chartFirstDate > this.lastDate || this.chartLastDate < this.firstDate)
        return (Distance) null;
      else
        return this.WWpyQW3r7I(x, y);
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }

    
    private void RQXykfUBlu()
    {
      DateTime dateTime1 = new DateTime(Math.Min(this.VLoy6nwXZ8.X1.Ticks, this.VLoy6nwXZ8.X2.Ticks));
      Math.Min(this.VLoy6nwXZ8.Y1, this.VLoy6nwXZ8.Y2);
      DateTime dateTime2 = new DateTime(Math.Max(this.VLoy6nwXZ8.X1.Ticks, this.VLoy6nwXZ8.X2.Ticks));
      Math.Max(this.VLoy6nwXZ8.Y1, this.VLoy6nwXZ8.Y2);
      int index1 = this.pad.MainSeries.GetIndex(this.VLoy6nwXZ8.X1);
      int index2 = this.pad.MainSeries.GetIndex(this.VLoy6nwXZ8.X2);
      int val1_1 = Math.Max(index1, this.pad.FirstIndex);
      int val1_2 = Math.Max(index2, this.pad.FirstIndex);
      int index3 = Math.Min(val1_1, this.pad.LastIndex);
      int index4 = Math.Min(val1_2, this.pad.LastIndex);
      double num1 = this.mXvyM23twN(index3);
      double num2 = this.mXvyM23twN(index4);
      if (Math.Max(num1, num2) <= this.pad.MinValue || Math.Min(num1, num2) >= this.pad.MaxValue)
        return;
      int y1 = this.pad.ClientY(num1);
      int y2 = this.pad.ClientY(num2);
      int x1 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index3));
      int x2 = this.pad.ClientX(this.pad.MainSeries.GetDateTime(index4));
      this.pad.Graphics.DrawLine(new Pen(this.VLoy6nwXZ8.Color, (float) this.VLoy6nwXZ8.Width), x1, y1, x2, y2);
    }

    
    private double mXvyM23twN([In] int obj0)
    {
      double num1 = (double) this.pad.MainSeries.GetIndex(this.VLoy6nwXZ8.X1);
      double num2 = (double) this.pad.MainSeries.GetIndex(this.VLoy6nwXZ8.X2);
      return this.VLoy6nwXZ8.Y1 + ((double) obj0 - num1) / (num2 - num1) * (this.VLoy6nwXZ8.Y2 - this.VLoy6nwXZ8.Y1);
    }

    
    private Distance WWpyQW3r7I([In] int obj0, [In] double obj1)
    {
      Distance distance = new Distance();
      DateTime dateTime = this.pad.GetDateTime(obj0);
      double num;
      if (dateTime == this.chartFirstDate)
        num = this.VLoy6nwXZ8.Y1;
      else if (dateTime == this.chartLastDate)
      {
        num = this.VLoy6nwXZ8.Y2;
      }
      else
      {
        if (dateTime.Ticks > Math.Max(this.VLoy6nwXZ8.X1.Ticks, this.VLoy6nwXZ8.X2.Ticks) || dateTime.Ticks < Math.Min(this.VLoy6nwXZ8.X1.Ticks, this.VLoy6nwXZ8.X2.Ticks))
          return (Distance) null;
        num = this.mXvyM23twN(this.pad.MainSeries.GetIndex(dateTime));
      }
      distance.X = (double) obj0;
      distance.Y = num;
      distance.DX = 0.0;
      distance.DY = Math.Abs(obj1 - num);
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) FJDHryrxb1WIq5jBAt.mT707pbkgT(3008), (object) this.VLoy6nwXZ8.Name, (object) dateTime.ToString(), (object) num);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }

    
    public PadRange GetPadRangeY(Pad pad)
    {
      return new PadRange(0.0, 0.0);
    }
  }
}
