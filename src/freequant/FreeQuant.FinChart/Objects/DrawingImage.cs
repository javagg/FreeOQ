using System;
using System.Drawing;

namespace FreeQuant.FinChart.Objects
{
  public class DrawingImage : IUpdatable
  {
    private DateTime kK7y702WDY;
    private double JPXyR8VTA9;
    private Image aipyEffZDd;

    public string Name { get; private set; }

    public DateTime X
    {
       get
      {
        return this.kK7y702WDY;
      }
       set
      {
        this.kK7y702WDY = value;
        this.hw2ybdMqpF();
      }
    }

    public double Y
    {
       get
      {
        return this.JPXyR8VTA9;
      }
       set
      {
        this.JPXyR8VTA9 = value;
        this.hw2ybdMqpF();
      }
    }

    public Image Image
    {
       get
      {
        return this.aipyEffZDd;
      }
       set
      {
        this.aipyEffZDd = value;
        this.hw2ybdMqpF();
      }
    }

    public event EventHandler Updated;

    public DrawingImage(DateTime x, double y, Image image, string name)
    {
      this.Name = name;
      this.kK7y702WDY = x;
      this.JPXyR8VTA9 = y;
      this.aipyEffZDd = image;
    }

    
    private void hw2ybdMqpF()
    {
			if (this.Updated == null)
        return;
			this.Updated(this, EventArgs.Empty);
    }
  }
}
