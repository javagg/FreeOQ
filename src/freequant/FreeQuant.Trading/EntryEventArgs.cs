using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class EntryEventArgs : EventArgs
  {
    private Instrument du5pxmVwsn;
    private char vFLp8YMfxh;
    private Bar K4Zpcjcbkg;

    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.du5pxmVwsn;
      }
    }

    public char Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vFLp8YMfxh;
      }
    }

    public Bar Bar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.K4Zpcjcbkg;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EntryEventArgs(Instrument instrument, char side, Bar bar)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.du5pxmVwsn = instrument;
      this.vFLp8YMfxh = side;
      this.K4Zpcjcbkg = bar;
    }
  }
}
