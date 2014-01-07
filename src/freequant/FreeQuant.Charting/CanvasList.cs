// Type: SmartQuant.Charting.CanvasList
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Charting
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasList()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Canvas canvas)
    {
      base.Add((object) canvas.Name, (object) canvas);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
