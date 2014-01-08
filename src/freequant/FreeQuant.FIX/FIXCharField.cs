using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCharField : FIXField
  {
    public const char Empty = '\0';
    public char Value;

    public override FIXType FIXType
    {
      get
      {
        return FIXType.Char;
      }
    }

	public FIXCharField(int tag) :  this(tag, ' ')
    {

    }

	public FIXCharField(int tag, char value) : base(tag)
    {

      this.Value = value;
    }

	public FIXCharField(int tag, string value) :  this(tag, value, false)
    {

    }

	public FIXCharField(int tag, string value, bool invariantCulture):this(tag, invariantCulture ? char.Parse(value) : char.Parse(value))
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
