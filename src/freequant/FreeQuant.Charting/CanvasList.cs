using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class CanvasList : SortedList
  {
    public Canvas this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[(object) name] as Canvas;
      }
    }


    public void Add(Canvas canvas)
    {
      base.Add((object) canvas.Name, (object) canvas);
    }

    public void Remove(Canvas canvas)
    {
      base.Remove((object) canvas.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Print()
    {
      foreach (Canvas canvas in (SortedList) this)
        canvas.Print();
    }
  }
}
