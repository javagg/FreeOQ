// Type: SmartQuant.FinChart.Objects.DrawingRectangle
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart.Objects
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rangeY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rangeY = value;
        this.wdfSDwf2c9();
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.IAtSEgvi6q;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.IAtSEgvi6q = value;
        this.wdfSDwf2c9();
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yPASPrHxtE;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.yPASPrHxtE = value;
        this.wdfSDwf2c9();
      }
    }

    public string Name { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public DateTime X1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nFrSen0Bbv;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nFrSen0Bbv = value;
        this.wdfSDwf2c9();
      }
    }

    public DateTime X2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LscSnwRM85;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.LscSnwRM85 = value;
        this.wdfSDwf2c9();
      }
    }

    public double Y1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.CoBS7yK5v5;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.CoBS7yK5v5 = value;
        this.wdfSDwf2c9();
      }
    }

    public double Y2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.seVSRC3nMB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.seVSRC3nMB = value;
        this.wdfSDwf2c9();
      }
    }

    public event EventHandler Updated;

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wdfSDwf2c9()
    {
      if (this.T3XSbKaATt == null)
        return;
      this.T3XSbKaATt((object) this, EventArgs.Empty);
    }
  }
}
