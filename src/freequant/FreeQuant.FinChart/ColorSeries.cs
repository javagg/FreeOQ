using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart
{
  public class ColorSeries : ICollection, IEnumerable
  {
    private SortedList sKbSyigFMG;

    public bool IsSynchronized
    {
       get
      {
        return this.sKbSyigFMG.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.sKbSyigFMG.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.sKbSyigFMG.SyncRoot;
      }
    }

    
    public ColorSeries()
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sKbSyigFMG = new SortedList();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.sKbSyigFMG.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.sKbSyigFMG.Values.GetEnumerator();
    }

    
    public void AddColor(DateTime date, Color color)
    {
      this.sKbSyigFMG.Add((object) date, (object) color);
    }
  }
}
