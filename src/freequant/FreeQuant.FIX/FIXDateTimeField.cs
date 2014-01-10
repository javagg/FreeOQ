using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXDateTimeField : FIXField
  {
    public DateTime Value;

    public override FIXType FIXType
    {
      get
      {
        return FIXType.DateTime;
      }
    }

		public FIXDateTimeField(int tag) : this(tag, DateTime.MinValue)
    {
    }

    public FIXDateTimeField(int tag, DateTime value) : base(tag)
    {
      this.Value = value;
    }

		public FIXDateTimeField(int tag, string value)  :  this(tag, value, false)
  {
    }

		public FIXDateTimeField(int tag, string value, bool invariantCulture) : this(tag, invariantCulture ? DateTime.Parse(value, (IFormatProvider) CultureInfo.InvariantCulture) : DateTime.Parse(value))
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetValue()
    {
      return (object) this.Value;
    }
  }
}
