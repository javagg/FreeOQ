using System;
using System.Drawing;

namespace FreeQuant.FinChart.Objects
{
  public class DrawingLine : IUpdatable
  {
    private DateTime C24y2JufYc;
    private DateTime YVLygubFYo;
    private double q8GyHP7E4f;
    private double aewyYA9Duw;
    public bool rangeY;
    private Color XaAyCiOKRb;
    private int sx4ymjAWYx;

    public bool RangeY
    {
       get
      {
        return this.rangeY;
      }
       set
      {
        this.rangeY = value;
        this.JY9yL8JRqO();
      }
    }

    public Color Color
    {
       get
      {
        return this.XaAyCiOKRb;
      }
       set
      {
        this.XaAyCiOKRb = value;
        this.JY9yL8JRqO();
      }
    }

    public int Width
    {
       get
      {
        return this.sx4ymjAWYx;
      }
       set
      {
        this.sx4ymjAWYx = value;
        this.JY9yL8JRqO();
      }
    }

    public string Name {  get;  private set; }

    public DateTime X1
    {
       get
      {
        return this.C24y2JufYc;
      }
       set
      {
        this.C24y2JufYc = value;
        this.JY9yL8JRqO();
      }
    }

    public DateTime X2
    {
       get
      {
        return this.YVLygubFYo;
      }
       set
      {
        this.YVLygubFYo = value;
        this.JY9yL8JRqO();
      }
    }

    public double Y1
    {
       get
      {
        return this.q8GyHP7E4f;
      }
       set
      {
        this.q8GyHP7E4f = value;
        this.JY9yL8JRqO();
      }
    }

    public double Y2
    {
       get
      {
        return this.aewyYA9Duw;
      }
       set
      {
        this.aewyYA9Duw = value;
        this.JY9yL8JRqO();
      }
    }

    public event EventHandler Updated;

    
    public DrawingLine(DateTime x1, double y1, DateTime x2, double y2, string name)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.sx4ymjAWYx = 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.C24y2JufYc = x1;
      this.q8GyHP7E4f = y1;
      this.YVLygubFYo = x2;
      this.aewyYA9Duw = y2;
    }

    
    private void JY9yL8JRqO()
    {
      if (this.yjUyVn72U1 == null)
        return;
      this.yjUyVn72U1((object) this, EventArgs.Empty);
    }
  }
}
