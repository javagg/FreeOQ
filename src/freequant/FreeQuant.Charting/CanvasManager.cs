// Type: SmartQuant.Charting.CanvasManager
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  public class CanvasManager
  {
    private static CanvasList sPUCznywUB;

    public static CanvasList Canvases
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return CanvasManager.sPUCznywUB;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CanvasManager()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      CanvasManager.sPUCznywUB = new CanvasList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasManager()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Add(Canvas canvas)
    {
      if (CanvasManager.sPUCznywUB[canvas.Name] != null)
        ((SortedList) CanvasManager.sPUCznywUB).Remove((object) canvas.Name);
      ((SortedList) CanvasManager.sPUCznywUB).Add((object) canvas.Name, (object) canvas);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Remove(Canvas canvas)
    {
      ((SortedList) CanvasManager.sPUCznywUB).Remove((object) canvas.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Canvas GetCanvas(string name)
    {
      return CanvasManager.sPUCznywUB[name];
    }
  }
}
