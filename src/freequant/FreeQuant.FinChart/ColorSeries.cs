// Type: SmartQuant.FinChart.ColorSeries
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class ColorSeries : ICollection, IEnumerable
  {
    private SortedList sKbSyigFMG;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sKbSyigFMG.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sKbSyigFMG.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sKbSyigFMG.SyncRoot;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorSeries()
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sKbSyigFMG = new SortedList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.sKbSyigFMG.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.sKbSyigFMG.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddColor(DateTime date, Color color)
    {
      this.sKbSyigFMG.Add((object) date, (object) color);
    }
  }
}
