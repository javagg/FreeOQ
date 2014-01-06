// Type: SmartQuant.Trading.EntryEventArgs
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
