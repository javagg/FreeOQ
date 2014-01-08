using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class ExitEventArgs : EventArgs
  {
    private Instrument QTH6x9uW18;
    private char qYX68VSGfR;
    private Bar Bci6cEaeJs;

    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QTH6x9uW18;
      }
    }

    public char Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qYX68VSGfR;
      }
    }

    public Bar Bar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Bci6cEaeJs;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExitEventArgs(Instrument instrument, char side, Bar bar)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.QTH6x9uW18 = instrument;
      this.qYX68VSGfR = side;
      this.Bci6cEaeJs = bar;
    }
  }
}
