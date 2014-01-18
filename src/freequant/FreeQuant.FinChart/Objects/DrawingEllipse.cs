using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart.Objects
{
  public class DrawingEllipse : IUpdatable
  {
    private DateTime QbJy0TUwFX;
    private DateTime kA4yrTb50K;
    private double GjOyKRGd06;
    private double l36yibjrFV;
    public bool rangeY;
    private Color Un1yXhicQO;
    private int eJXyDMSI7d;

    public bool RangeY
    {
       get
      {
        return this.rangeY;
      }
       set
      {
        this.rangeY = value;
        this.uvbyJ2XdPh();
      }
    }

    public Color Color
    {
       get
      {
        return this.Un1yXhicQO;
      }
       set
      {
        this.Un1yXhicQO = value;
        this.uvbyJ2XdPh();
      }
    }

    public int Width
    {
       get
      {
        return this.eJXyDMSI7d;
      }
       set
      {
        this.eJXyDMSI7d = value;
        this.uvbyJ2XdPh();
      }
    }

    public string Name {  get;  private set; }

    public DateTime X1
    {
       get
      {
        return this.QbJy0TUwFX;
      }
       set
      {
        this.QbJy0TUwFX = value;
        this.uvbyJ2XdPh();
      }
    }

    public DateTime X2
    {
       get
      {
        return this.kA4yrTb50K;
      }
       set
      {
        this.kA4yrTb50K = value;
        this.uvbyJ2XdPh();
      }
    }

    public double Y1
    {
       get
      {
        return this.GjOyKRGd06;
      }
       set
      {
        this.GjOyKRGd06 = value;
        this.uvbyJ2XdPh();
      }
    }

    public double Y2
    {
       get
      {
        return this.l36yibjrFV;
      }
       set
      {
        this.l36yibjrFV = value;
        this.uvbyJ2XdPh();
      }
    }

    public event EventHandler Updated;

    
    public DrawingEllipse(DateTime x1, double y1, DateTime x2, double y2, string name)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.eJXyDMSI7d = 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.QbJy0TUwFX = x1;
      this.GjOyKRGd06 = y1;
      this.kA4yrTb50K = x2;
      this.l36yibjrFV = y2;
    }

    
    private void uvbyJ2XdPh()
    {
      if (this.raxySEVyyA == null)
        return;
      this.raxySEVyyA((object) this, EventArgs.Empty);
    }
  }
}
