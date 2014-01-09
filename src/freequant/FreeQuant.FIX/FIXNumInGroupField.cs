using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNumInGroupField : FIXField
  {
    public int Value;

    public override FIXType FIXType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXType.NumInGroup;
      }
    }


    public FIXNumInGroupField(int tag) : this(tag, 0)
    {
    }

    public FIXNumInGroupField(int tag, int value): base(tag)
    {
      this.Value = value;
    }

    public override string ToString()
    {
      return this.Value.ToString();
    }

    public override string ToInvariantString()
    {
      return this.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture);
    }

    public override object GetValue()
    {
      return (object) this.Value;
    }
  }
}
