using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDoubleField : FIXField
  {
    public const double Empty = 0.0;
    public double Value;

    public override FIXType FIXType
    {
        get
      {
        return FIXType.Double;
      }
    }

		public FIXDoubleField() : base()
		{
		}

//    public FIXDoubleField(int tag) : this(tag, 0.0)
//    {
//    }

	public FIXDoubleField(int tag, double value = 0) : base(tag)
    {

      this.Value = value;
    }

    public FIXDoubleField(int tag, string value): this(tag, value, false)
    {
    }

    public FIXDoubleField(int tag, string value, bool invariantCulture):  this(tag, invariantCulture ? double.Parse(value, (IFormatProvider) CultureInfo.InvariantCulture) : double.Parse(value))
    {
    }

    public override string ToString()
    {
      return this.Value.ToString();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToInvariantString()
    {
      return this.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetValue()
    {
      return (object) this.Value;
    }
  }
}
