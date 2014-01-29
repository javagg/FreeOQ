using FreeQuant.FinChart;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.FinChart.Objects
{
  public class RectangleView : IChartDrawable, IZoomable
  {
    private DrawingRectangle nQNSrDsxti;
    protected DateTime firstDate;
    protected DateTime lastDate;
    protected bool toolTipEnabled;
    protected string toolTipFormat;
    protected bool selected;
    protected DateTime chartFirstDate;
    protected DateTime chartLastDate;

    public Pad Pad { get; set; }

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

    
		public RectangleView(DrawingRectangle rect, Pad pad) : base()
    {
      this.nQNSrDsxti = rect;
      this.Pad = pad;
			this.ToolTipEnabled = true;
			this.ToolTipFormat = "";
    }

    
    public void Paint()
    {
      this.dCxSSqbBBj();
    }

    
    public void SetInterval(DateTime minDate, DateTime maxDate)
    {
      this.firstDate = minDate;
      this.lastDate = maxDate;
    }

    
    public Distance Distance(int x, double y)
    {
      return this.hoRS0fZTTW(x, y);
    }

    
    public void Select()
    {
    }

    
    public void UnSelect()
    {
    }

    
    private void dCxSSqbBBj()
    {
      int val1_1 = this.Pad.ClientX(this.nQNSrDsxti.X1);
      int val2_1 = this.Pad.ClientX(this.nQNSrDsxti.X2);
      int val1_2 = this.Pad.ClientY(this.nQNSrDsxti.Y1);
      int val2_2 = this.Pad.ClientY(this.nQNSrDsxti.Y2);
      this.Pad.Graphics.DrawRectangle(new Pen(this.nQNSrDsxti.Color, (float) this.nQNSrDsxti.Width), Math.Min(val1_1, val2_1), Math.Min(val1_2, val2_2), Math.Abs(val2_1 - val1_1), Math.Abs(val2_2 - val1_2));
    }

    
    private Distance hoRS0fZTTW([In] int obj0, [In] double obj1)
    {
      return null;
    }

    
    public PadRange GetPadRangeY(Pad pad)
    {
      return new PadRange(0.0, 0.0);
    }
  }
}
