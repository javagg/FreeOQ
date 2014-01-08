using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXBoolField : FIXField
  {
    public const bool Empty = false;
    public bool Value;

    public override FIXType FIXType
    {
       get
      {
        return FIXType.Bool;
      }
    }

	public FIXBoolField(int tag) : this(tag, false)
    {

    }

	public FIXBoolField(int tag, bool value) : base(tag)
    {

      this.Value = value;
    }

	public FIXBoolField(int tag, string value) : this(tag, value, false)
    {

    }

	public FIXBoolField(int tag, string value, bool invariantCulture) :  this(tag, invariantCulture ? bool.Parse(value) : bool.Parse(value))
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
      return (object) (bool) (this.Value ? 1 : 0);
    }
  }
}
