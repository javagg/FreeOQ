using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart.Objects
{
  public class DrawingPoint : IUpdatable
  {
    private DateTime JR7lupXYK;
    private double nFZvlSOb4;

    public DateTime X
    {
       get
      {
        return this.JR7lupXYK;
      }
       set
      {
        this.JR7lupXYK = value;
        this.pyg1tbWWC();
      }
    }

    public double Y
    {
       get
      {
        return this.nFZvlSOb4;
      }
       set
      {
        this.nFZvlSOb4 = value;
        this.pyg1tbWWC();
      }
    }

    public event EventHandler Updated;

    
    public DrawingPoint(DateTime x, double y)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.JR7lupXYK = x;
      this.nFZvlSOb4 = y;
    }

    
    private void pyg1tbWWC()
    {
      if (this.zNnUwXbKs == null)
        return;
      this.zNnUwXbKs((object) this, EventArgs.Empty);
    }
  }
}
