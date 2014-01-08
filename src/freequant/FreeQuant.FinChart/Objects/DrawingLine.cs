// Type: SmartQuant.FinChart.Objects.DrawingLine
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Drawing;
using System.Runtime.CompilerServices;

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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rangeY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rangeY = value;
        this.JY9yL8JRqO();
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XaAyCiOKRb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XaAyCiOKRb = value;
        this.JY9yL8JRqO();
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sx4ymjAWYx;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.sx4ymjAWYx = value;
        this.JY9yL8JRqO();
      }
    }

    public string Name { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public DateTime X1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.C24y2JufYc;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.C24y2JufYc = value;
        this.JY9yL8JRqO();
      }
    }

    public DateTime X2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YVLygubFYo;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.YVLygubFYo = value;
        this.JY9yL8JRqO();
      }
    }

    public double Y1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.q8GyHP7E4f;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.q8GyHP7E4f = value;
        this.JY9yL8JRqO();
      }
    }

    public double Y2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aewyYA9Duw;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aewyYA9Duw = value;
        this.JY9yL8JRqO();
      }
    }

    public event EventHandler Updated;

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JY9yL8JRqO()
    {
      if (this.yjUyVn72U1 == null)
        return;
      this.yjUyVn72U1((object) this, EventArgs.Empty);
    }
  }
}
