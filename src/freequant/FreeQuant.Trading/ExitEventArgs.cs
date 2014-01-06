// Type: SmartQuant.Trading.ExitEventArgs
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Data;
using SmartQuant.Instruments;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
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
