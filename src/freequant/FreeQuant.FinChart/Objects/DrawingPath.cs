// Type: SmartQuant.FinChart.Objects.DrawingPath
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rangeY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rangeY = value;
        this.U0XJWirHHb();
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.MxJyt9xxYT;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.MxJyt9xxYT = value;
        this.U0XJWirHHb();
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mQKywhWq1Y;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.mQKywhWq1Y = value;
        this.U0XJWirHHb();
      }
    }

    public string Name { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    public List<DrawingPoint> Points
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ClmJzNuC37;
      }
    }

    public event EventHandler Updated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrawingPath(string name)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      this.mQKywhWq1Y = 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = name;
      this.ClmJzNuC37 = new List<DrawingPoint>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(DateTime x, double y)
    {
      this.ClmJzNuC37.Add(new DrawingPoint(x, y));
      this.U0XJWirHHb();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index)
    {
      this.ClmJzNuC37.RemoveAt(index);
      this.U0XJWirHHb();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, DateTime x, double y)
    {
      this.ClmJzNuC37.Insert(index, new DrawingPoint(x, y));
      this.U0XJWirHHb();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void U0XJWirHHb()
    {
      if (this.SApJIWaiSB == null)
        return;
      this.SApJIWaiSB((object) this, EventArgs.Empty);
    }
  }
}
