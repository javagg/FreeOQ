// Type: SmartQuant.Instruments.MarginManager
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.FIX;
using System;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class MarginManager
  {
    private bool nYhBSPW2IQ;

    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nYhBSPW2IQ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nYhBSPW2IQ = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarginManager()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.nYhBSPW2IQ = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetInitialMargin(double Value, Instrument instrument, Side side, DateTime dateTime)
    {
      if (!this.nYhBSPW2IQ || !(instrument.SecurityType == gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2470)))
        return 0.0;
      switch (side)
      {
        case Side.Buy:
        case Side.SellShort:
          return Value * 0.5;
        default:
          return 0.0;
      }
    }
  }
}
