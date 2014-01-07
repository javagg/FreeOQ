// Type: SmartQuant.FinChart.Objects.DrawingEllipse
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart.Objects
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rangeY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rangeY = value;
        this.uvbyJ2XdPh();
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Un1yXhicQO;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Un1yXhicQO = value;
        this.uvbyJ2XdPh();
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.eJXyDMSI7d;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.eJXyDMSI7d = value;
        this.uvbyJ2XdPh();
      }
    }

    public string Name { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public DateTime X1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QbJy0TUwFX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.QbJy0TUwFX = value;
        this.uvbyJ2XdPh();
      }
    }

    public DateTime X2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kA4yrTb50K;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.kA4yrTb50K = value;
        this.uvbyJ2XdPh();
      }
    }

    public double Y1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GjOyKRGd06;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GjOyKRGd06 = value;
        this.uvbyJ2XdPh();
      }
    }

    public double Y2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.l36yibjrFV;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.l36yibjrFV = value;
        this.uvbyJ2XdPh();
      }
    }

    public event EventHandler Updated;

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void uvbyJ2XdPh()
    {
      if (this.raxySEVyyA == null)
        return;
      this.raxySEVyyA((object) this, EventArgs.Empty);
    }
  }
}
