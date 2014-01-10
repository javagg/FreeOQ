using System;
using System.Collections;

namespace FreeQuant.Charting
{
  [Serializable]
  public class CanvasList : SortedList
  {
    public Canvas this[string name]
    {
       get
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

    
    public void Print()
    {
      foreach (Canvas canvas in (SortedList) this)
        canvas.Print();
    }
  }
}
