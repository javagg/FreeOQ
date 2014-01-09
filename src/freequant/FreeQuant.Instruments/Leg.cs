using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;


namespace FreeQuant.Instruments
{
  public class Leg : FIXGroup
  {
    private Instrument dA6EnCiplS;

    [Editor(typeof (K87hpw9XvbU6vpD5hK), typeof (UITypeEditor))]
    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.dA6EnCiplS;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.dA6EnCiplS = value;
      }
    }

    [FIXField("623", EFieldOption.Optional)]
    public double LegRatioQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(623);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(623, value);
      }
    }

    [FIXField("624", EFieldOption.Optional)]
    public char LegSide
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharValue(624);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetCharValue(624, value);
      }
    }

    [FIXField("556", EFieldOption.Optional)]
    public string LegCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(556);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(556, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Leg()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Leg(Instrument instrument)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dA6EnCiplS = instrument;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Leg(Instrument instrument, char side, double ratioQty)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dA6EnCiplS = instrument;
      this.LegSide = side;
      this.LegRatioQty = ratioQty;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Leg(string symbol)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dA6EnCiplS = InstrumentManager.Instruments[symbol];
      if (this.dA6EnCiplS == null)
        throw new ArgumentException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9456) + symbol);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Leg(string symbol, char side, double ratioQty)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dA6EnCiplS = InstrumentManager.Instruments[symbol];
      if (this.dA6EnCiplS == null)
        throw new ArgumentException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9556) + symbol);
      this.LegSide = side;
      this.LegRatioQty = ratioQty;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      if (this.dA6EnCiplS != null)
        return this.dA6EnCiplS.Symbol;
      else
        return gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(9656);
    }
  }
}
