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
       get
      {
        return this.du5pxmVwsn;
      }
    }

    public char Side
    {
       get
      {
        return this.vFLp8YMfxh;
      }
    }

    public Bar Bar
    {
       get
      {
        return this.K4Zpcjcbkg;
      }
    }

    
		public EntryEventArgs(Instrument instrument, char side, Bar bar):base()
    {
      this.du5pxmVwsn = instrument;
      this.vFLp8YMfxh = side;
      this.K4Zpcjcbkg = bar;
    }
  }
}
