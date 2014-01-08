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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QfSpBwNGnM;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.QfSpBwNGnM = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarSliceManager()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.pfApOyZV8C();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pfApOyZV8C()
    {
      this.NmjpM49vOA = new Dictionary<long, BarSlice>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void QGUpQklb9a()
    {
      this.NmjpM49vOA.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BarSlice jPpp2uI7Tx([In] long obj0)
    {
      BarSlice barSlice = (BarSlice) null;
      this.NmjpM49vOA.TryGetValue(obj0, out barSlice);
      return barSlice;
    }
  }
}
