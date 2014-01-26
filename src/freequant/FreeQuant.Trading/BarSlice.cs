using FreeQuant.Data;
using FreeQuant.Instruments;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class BarSlice
  {
    private int VaaibGso2d;
    private Dictionary<Instrument, Bar> n3AiyxmxLq;

    public Dictionary<Instrument, Bar> Table
    {
       get
      {
        return this.n3AiyxmxLq;
      }
    }

    public bool IsComplete
    {
       get
      {
        return this.n3AiyxmxLq.Count == this.VaaibGso2d;
      }
    }

    
    internal BarSlice(int instrumentCount)
    {
      this.VaaibGso2d = instrumentCount;
      this.iuWi2Y8Mjy();
    }

    
    private void iuWi2Y8Mjy()
    {
      this.n3AiyxmxLq = new Dictionary<Instrument, Bar>();
    }

    
    internal void fpEiBqg2vH([In] Instrument obj0, [In] Bar obj1)
    {
      this.n3AiyxmxLq[obj0] = obj1;
    }

    
    internal void kxEiMHhItO()
    {
      this.n3AiyxmxLq.Clear();
    }
  }
}
