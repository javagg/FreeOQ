using FreeQuant.Data;
using FreeQuant.Instruments;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class BarSliceManager
  {
    private int QfSpBwNGnM;
    private Dictionary<long, BarSlice> NmjpM49vOA;

    public int InstrumentsCount
    {
       get
      {
        return this.QfSpBwNGnM;
      }
       set
      {
        this.QfSpBwNGnM = value;
      }
    }

    
    public BarSliceManager()
    {
      this.pfApOyZV8C();
    }

    
    private void pfApOyZV8C()
    {
      this.NmjpM49vOA = new Dictionary<long, BarSlice>();
    }

    
    internal void QGUpQklb9a()
    {
      this.NmjpM49vOA.Clear();
    }

    
    internal void zQGp56LHjL([In] Instrument obj0, [In] Bar obj1)
    {
      BarSlice barSlice = (BarSlice) null;
      if (!this.NmjpM49vOA.TryGetValue(obj1.Size, out barSlice))
      {
        barSlice = new BarSlice(this.QfSpBwNGnM);
        this.NmjpM49vOA.Add(obj1.Size, barSlice);
      }
      barSlice.fpEiBqg2vH(obj0, obj1);
    }

    
    internal BarSlice jPpp2uI7Tx([In] long obj0)
    {
      BarSlice barSlice = (BarSlice) null;
      this.NmjpM49vOA.TryGetValue(obj0, out barSlice);
      return barSlice;
    }
  }
}
