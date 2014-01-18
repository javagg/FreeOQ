using SmartQuant.FinChart;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.FinChart.Objects
{
  public class EllipseView : IChartDrawable, IZoomable
  {
    private DrawingEllipse yVLScw9Zgj;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;
    protected DateTime chartFirstDate;
    protected DateTime chartLastDate;

    public Pad Pad {  get;  set; }

    [Category("ToolTip")]
    [Description("Enable or disable tooltip appearance for this marker.")]
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

    
    public EllipseView(DrawingEllipse rect, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.yVLScw9Zgj = rect;
      this.Pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3292);
    }

    
    public void Paint()
    {
      this.nxXStT7oM2();
    }

    
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    
    public Distance Distance(int x, double y)
    {
      return this.GiuSwaHmrU(x, y);
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }

    
    private void nxXStT7oM2()
    {
      int val1_1 = this.Pad.ClientX(this.yVLScw9Zgj.X1);
      int val2_1 = this.Pad.ClientX(this.yVLScw9Zgj.X2);
      int val1_2 = this.Pad.ClientY(this.yVLScw9Zgj.Y1);
      int val2_2 = this.Pad.ClientY(this.yVLScw9Zgj.Y2);
      this.Pad.Graphics.DrawEllipse(new Pen(this.yVLScw9Zgj.Color, (float) this.yVLScw9Zgj.Width), Math.Min(val1_1, val2_1), Math.Min(val1_2, val2_2), Math.Abs(val2_1 - val1_1), Math.Abs(val2_2 - val1_2));
    }

    
    private Distance GiuSwaHmrU([In] int obj0, [In] double obj1)
    {
      return (Distance) null;
    }

    
    public PadRange GetPadRangeY(Pad pad)
    {
      return new PadRange(0.0, 0.0);
    }
  }
}
