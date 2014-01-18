using FreeQuant.FinChart;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.FinChart.Objects
{
  public class PathView : IChartDrawable, IZoomable
  {
    private DrawingPath QLSyIOYXoI;
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

    
    public PathView(DrawingPath path, Pad pad)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.toolTipEnabled = true;
      this.toolTipFormat = "";
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.QLSyIOYXoI = path;
      this.Pad = pad;
      this.toolTipEnabled = true;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3248);
    }

    
    public void Paint()
    {
      this.ciMyW8o1Tg();
    }

    
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    
    public Distance Distance(int x, double y)
    {
      return this.TBRyFWEHO3(x, y);
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }

    
    private void ciMyW8o1Tg()
    {
      GraphicsPath path = new GraphicsPath();
      int x1 = int.MaxValue;
      int y1 = 0;
      foreach (DrawingPoint drawingPoint in this.QLSyIOYXoI.Points)
      {
        int x2 = this.Pad.ClientX(drawingPoint.X);
        int y2 = this.Pad.ClientY(drawingPoint.Y);
        if (x1 != int.MaxValue)
          path.AddLine(new Point(x1, y1), new Point(x2, y2));
        x1 = x2;
        y1 = y2;
      }
      this.Pad.Graphics.DrawPath(new Pen(this.QLSyIOYXoI.Color, (float) this.QLSyIOYXoI.Width), path);
    }

    
    private Distance TBRyFWEHO3([In] int obj0, [In] double obj1)
    {
      return (Distance) null;
    }

    
    public PadRange GetPadRangeY(Pad pad)
    {
      return new PadRange(0.0, 0.0);
    }
  }
}
