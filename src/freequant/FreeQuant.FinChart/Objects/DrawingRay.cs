// Type: SmartQuant.FinChart.Objects.DrawingRay
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart.Objects
{
  public class DrawingRay : IUpdatable
  {
    private DateTime Kn1cVWc3xb;
    private double PWrc2Yc2ux;
    public bool rangeY;
    private Color tCDcgHkw96;
    private int aYvcHmNWdj;

    public bool RangeY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rangeY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rangeY = value;
        this.jh0csqQXMr();
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tCDcgHkw96;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.tCDcgHkw96 = value;
        this.jh0csqQXMr();
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aYvcHmNWdj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aYvcHmNWdj = value;
        this.jh0csqQXMr();
      }
    }

    public string Name { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public DateTime X
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Kn1cVWc3xb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Kn1cVWc3xb = value;
        this.jh0csqQXMr();
      }
    }

    public double Y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PWrc2Yc2ux;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.PWrc2Yc2ux = value;
        this.jh0csqQXMr();
      }
    }

    public event EventHandler Updated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrawingRay(DateTime x, double y, string name)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.aYvcHmNWdj = 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.Kn1cVWc3xb = x;
      this.PWrc2Yc2ux = y;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jh0csqQXMr()
    {
      if (this.aLlcqjt4gV == null)
        return;
      this.aLlcqjt4gV((object) this, EventArgs.Empty);
    }
  }
}
