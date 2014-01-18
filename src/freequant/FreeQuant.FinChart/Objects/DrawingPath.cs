using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart.Objects
{
  public class DrawingPath : IUpdatable
  {
    private List<DrawingPoint> ClmJzNuC37;
    public bool rangeY;
    private Color MxJyt9xxYT;
    private int mQKywhWq1Y;

    public bool RangeY
    {
       get
      {
        return this.rangeY;
      }
       set
      {
        this.rangeY = value;
        this.U0XJWirHHb();
      }
    }

    public Color Color
    {
       get
      {
        return this.MxJyt9xxYT;
      }
       set
      {
        this.MxJyt9xxYT = value;
        this.U0XJWirHHb();
      }
    }

    public int Width
    {
       get
      {
        return this.mQKywhWq1Y;
      }
       set
      {
        this.mQKywhWq1Y = value;
        this.U0XJWirHHb();
      }
    }

    public string Name {  get;  private set; }

    public List<DrawingPoint> Points
    {
       get
      {
        return this.ClmJzNuC37;
      }
    }

    public event EventHandler Updated;

    
    public DrawingPath(string name)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.mQKywhWq1Y = 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.ClmJzNuC37 = new List<DrawingPoint>();
    }

    
    public void Add(DateTime x, double y)
    {
      this.ClmJzNuC37.Add(new DrawingPoint(x, y));
      this.U0XJWirHHb();
    }

    
    public void RemoveAt(int index)
    {
      this.ClmJzNuC37.RemoveAt(index);
      this.U0XJWirHHb();
    }

    
    public void Insert(int index, DateTime x, double y)
    {
      this.ClmJzNuC37.Insert(index, new DrawingPoint(x, y));
      this.U0XJWirHHb();
    }

    
    private void U0XJWirHHb()
    {
      if (this.SApJIWaiSB == null)
        return;
      this.SApJIWaiSB((object) this, EventArgs.Empty);
    }
  }
}
