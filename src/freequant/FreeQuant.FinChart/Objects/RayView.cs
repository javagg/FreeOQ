using FreeQuant.FinChart;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace FreeQuant.FinChart.Objects
{
  public class RayView : IChartDrawable, IZoomable
  {
    private DrawingRay mYYSbcj8S;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;
    protected DateTime chartFirstDate;
    protected DateTime chartLastDate;

    public Pad Pad {  get;  set; }

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

    [Category("ToolTip")]
    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
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

    
    public RayView(DrawingRay ray, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mYYSbcj8S = ray;
      this.Pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(68);
      int index = pad.Series.GetIndex(ray.X, EIndexOption.Prev);
      if (index == -1)
        return;
      this.chartFirstDate = pad.Series.GetDateTime(index);
      this.chartLastDate = DateTime.MaxValue;
    }

    
    public void Paint()
    {
      this.YL5JMg9FL();
    }

    
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    
    public Distance Distance(int x, double y)
    {
      return this.QVTy2A1Hg(x, y);
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }

    
    private void YL5JMg9FL()
    {
      double y = this.mYYSbcj8S.Y;
      int num1 = this.Pad.ClientX(this.chartFirstDate);
      int num2 = this.Pad.ClientY(y);
      if (num2 > this.Pad.Y2)
        return;
      Math.Max(2.0, (double) (int) this.Pad.IntervalWidth / 1.2);
      Pen pen = new Pen(this.mYYSbcj8S.Color, (float) this.mYYSbcj8S.Width);
      double val1_1 = (double) this.Pad.ClientX(this.firstDate);
      double val1_2 = (double) this.Pad.ClientX(this.lastDate);
      double val2 = val1_2;
      float x1 = (float) Math.Max(val1_1, (double) num1);
      float x2 = (float) Math.Min(val1_2, val2);
      if ((double) x1 > (double) x2)
        return;
      this.Pad.Graphics.DrawLine(pen, x1, (float) num2, x2, (float) num2);
    }

    
    private Distance QVTy2A1Hg([In] int obj0, [In] double obj1)
    {
      Distance distance = new Distance();
      DateTime dateTime = this.Pad.GetDateTime(obj0);
      double y = this.mYYSbcj8S.Y;
      distance.X = (double) obj0;
      distance.Y = y;
      int num = this.Pad.ClientX(this.chartFirstDate);
      int x2 = this.Pad.X2;
      distance.DX = num > obj0 || x2 < obj0 ? double.MaxValue : 0.0;
      distance.DY = Math.Abs(obj1 - this.mYYSbcj8S.Y);
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) FJDHryrxb1WIq5jBAt.mT707pbkgT(112), (object) this.mYYSbcj8S.Name, (object) dateTime.ToString(), (object) y);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }

    
    public PadRange GetPadRangeY(Pad pad)
    {
      double y1 = this.mYYSbcj8S.Y;
      double y2 = this.mYYSbcj8S.Y;
      if (y2 >= y1)
      {
        double num = y2 / 1000.0;
        y2 -= num;
        y1 += num;
      }
      return new PadRange(y2, y1);
    }
  }
}
