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
      get
      {
        return this.QTH6x9uW18;
      }
    }

    public char Side
    {
      get
      {
        return this.qYX68VSGfR;
      }
    }

    public Bar Bar
    {
      get
      {
        return this.Bci6cEaeJs;
      }
    }

    
		public ExitEventArgs(Instrument instrument, char side, Bar bar):base()
    {
      this.QTH6x9uW18 = instrument;
      this.qYX68VSGfR = side;
      this.Bci6cEaeJs = bar;
    }
  }
}
