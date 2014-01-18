using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart.Objects
{
  public class DrawingRectangle : IUpdatable
  {
    private DateTime nFrSen0Bbv;
    private DateTime LscSnwRM85;
    private double CoBS7yK5v5;
    private double seVSRC3nMB;
    public bool rangeY;
    private Color IAtSEgvi6q;
    private int yPASPrHxtE;

    public bool RangeY
    {
       get
      {
        return this.rangeY;
      }
       set
      {
        this.rangeY = value;
        this.wdfSDwf2c9();
      }
    }

    public Color Color
    {
       get
      {
        return this.IAtSEgvi6q;
      }
       set
      {
        this.IAtSEgvi6q = value;
        this.wdfSDwf2c9();
      }
    }

    public int Width
    {
       get
      {
        return this.yPASPrHxtE;
      }
       set
      {
        this.yPASPrHxtE = value;
        this.wdfSDwf2c9();
      }
    }

    public string Name {  get;  private set; }

    public DateTime X1
    {
       get
      {
        return this.nFrSen0Bbv;
      }
       set
      {
        this.nFrSen0Bbv = value;
        this.wdfSDwf2c9();
      }
    }

    public DateTime X2
    {
       get
      {
        return this.LscSnwRM85;
      }
       set
      {
        this.LscSnwRM85 = value;
        this.wdfSDwf2c9();
      }
    }

    public double Y1
    {
       get
      {
        return this.CoBS7yK5v5;
      }
       set
      {
        this.CoBS7yK5v5 = value;
        this.wdfSDwf2c9();
      }
    }

    public double Y2
    {
       get
      {
        return this.seVSRC3nMB;
      }
       set
      {
        this.seVSRC3nMB = value;
        this.wdfSDwf2c9();
      }
    }

    public event EventHandler Updated;

    
    public DrawingRectangle(DateTime x1, double y1, DateTime x2, double y2, string name)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.yPASPrHxtE = 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.nFrSen0Bbv = x1;
      this.CoBS7yK5v5 = y1;
      this.LscSnwRM85 = x2;
      this.seVSRC3nMB = y2;
    }

    
    private void wdfSDwf2c9()
    {
      if (this.T3XSbKaATt == null)
        return;
      this.T3XSbKaATt((object) this, EventArgs.Empty);
    }
  }
}
