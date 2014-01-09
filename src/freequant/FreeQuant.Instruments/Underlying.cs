using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class Underlying : FIXGroup
  {
    private Instrument G3bs3Y1cfV;

    [Editor(typeof (K87hpw9XvbU6vpD5hK), typeof (UITypeEditor))]
    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.G3bs3Y1cfV;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.G3bs3Y1cfV = value;
      }
    }

    [FIXField("318", EFieldOption.Optional)]
    public string UnderlyingCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(318);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(318, value);
      }
    }

    [FIXField("879", EFieldOption.Optional)]
    public double UnderlyingQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(879);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(879, value);
      }
    }

    [FIXField("810", EFieldOption.Optional)]
    public double UnderlyingPx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(810);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(810, value);
      }
    }

    [FIXField("882", EFieldOption.Optional)]
    public double UnderlyingDirtyPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(882);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(882, value);
      }
    }

    [FIXField("883", EFieldOption.Optional)]
    public double UnderlyingEndPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(883);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(883, value);
      }
    }

    [FIXField("884", EFieldOption.Optional)]
    public double UnderlyingStartValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(884);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(884, value);
      }
    }

    [FIXField("885", EFieldOption.Optional)]
    public double UnderlyingCurrentValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(885);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(885, value);
      }
    }

    [FIXField("886", EFieldOption.Optional)]
    public double UnderlyingEndValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(886);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(886, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Underlying()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Underlying(Instrument instrument)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.G3bs3Y1cfV = instrument;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Underlying(string symbol)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.G3bs3Y1cfV = InstrumentManager.Instruments[symbol];
      if (this.G3bs3Y1cfV == null)
        throw new ArgumentException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10600) + symbol);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      if (this.G3bs3Y1cfV != null)
        return this.G3bs3Y1cfV.Symbol;
      else
        return gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10714);
    }
  }
}
