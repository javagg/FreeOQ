// Type: SmartQuant.FinChart.Objects.DrawingPoint
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JR7lupXYK;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.JR7lupXYK = value;
        this.pyg1tbWWC();
      }
    }

    public double Y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nFZvlSOb4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nFZvlSOb4 = value;
        this.pyg1tbWWC();
      }
    }

    public event EventHandler Updated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrawingPoint(DateTime x, double y)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.JR7lupXYK = x;
      this.nFZvlSOb4 = y;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pyg1tbWWC()
    {
      if (this.zNnUwXbKs == null)
        return;
      this.zNnUwXbKs((object) this, EventArgs.Empty);
    }
  }
}
