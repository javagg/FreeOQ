// Type: SmartQuant.Trading.BarSlice
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Data;
using SmartQuant.Instruments;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Trading
{
  public class BarSlice
  {
    private int VaaibGso2d;
    private Dictionary<Instrument, Bar> n3AiyxmxLq;

    public Dictionary<Instrument, Bar> Table
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.n3AiyxmxLq;
      }
    }

    public bool IsComplete
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.n3AiyxmxLq.Count == this.VaaibGso2d;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BarSlice(int instrumentCount)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.VaaibGso2d = instrumentCount;
      this.iuWi2Y8Mjy();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iuWi2Y8Mjy()
    {
      this.n3AiyxmxLq = new Dictionary<Instrument, Bar>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void fpEiBqg2vH([In] Instrument obj0, [In] Bar obj1)
    {
      this.n3AiyxmxLq[obj0] = obj1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void kxEiMHhItO()
    {
      this.n3AiyxmxLq.Clear();
    }
  }
}
