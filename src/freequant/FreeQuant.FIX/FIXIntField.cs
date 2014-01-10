using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXIntField : FIXField
  {
    public const int Empty = -1;
    public int Value;

    public override FIXType FIXType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXType.Int;
      }
    }

		public FIXIntField()  {
		}

    public FIXIntField(int tag) : this(tag, 0)
    {
    }

    public FIXIntField(int tag, int value) : base(tag)
    {
      this.Value = value;
    }

     public FIXIntField(int tag, string value): this(tag, value, false)
    {
    }

 
    public FIXIntField(int tag, string value, bool invariantCulture): this(tag, invariantCulture ? int.Parse(value, (IFormatProvider) CultureInfo.InvariantCulture) : int.Parse(value))
    {
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
