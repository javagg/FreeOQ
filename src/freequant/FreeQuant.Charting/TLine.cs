using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TLine : IDrawable
  {
    private double x1;
    private double y1;
    private double x2;
    private double y2;
    private Color color;
    private int width;
    private DashStyle dashStyle;
    private bool toolTipEnabled;
    private string toolTipFormat;

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

    public double X1
    {
       get
      {
				return this.x1; 
      }
       set
      {
        this.x1 = value;
      }
    }

    public double Y1
    {
       get
      {
				return this.y1; 
      }
       set
      {
        this.y1 = value;
      }
    }

    public double X2
    {
       get
      {
				return this.x2; 
      }
       set
      {
        this.x2 = value;
      }
    }

    public double Y2
    {
       get
      {
				return this.y2; 
      }
       set
      {
        this.y2 = value;
      }
    }

    public DashStyle DashStyle
    {
       get
      {
				return this.dashStyle; 
      }
       set
      {
        this.dashStyle = value;
      }
    }

    public Color Color
    {
       get
      {
				return this.color; 
      }
       set
      {
        this.color = value;
      }
    }

    public int Width
    {
       get
      {
				return this.width; 
      }
       set
      {
        this.width = value;
      }
    }

    
    public TLine(double X1, double Y1, double X2, double Y2)
    {
      this.x1 = X1;
      this.y1 = Y1;
      this.x2 = X2;
      this.y2 = Y2;
      this.color = Color.Black;
      this.dashStyle = DashStyle.Solid;
      this.width = 1;
    }

    
    public TLine(DateTime X1, double Y1, DateTime X2, double Y2)
    {
      this.x1 = X1.Ticks;
      this.y1 = Y1;
      this.x2 = X2.Ticks;
      this.y2 = Y2;
      this.color = Color.Black;
      this.dashStyle = DashStyle.Solid;
      this.width = 1;
    }

    
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
				Canvas canvas = new Canvas("d", "d");
      }
      Chart.Pad.Add(this);
    }

    
    public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
    {
      Pad.DrawLine(new Pen(this.color)
      {
        Width = (float) this.width,
        DashStyle = this.dashStyle
      }, this.x1, this.y1, this.x2, this.y2);
    }

    
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }
  }
}
