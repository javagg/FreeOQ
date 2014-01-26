using System;
using System.Globalization;

namespace FreeQuant.FIX
{
	public class FIXIntField : FIXField
	{
		public const int Empty = -1;
		public int Value;

		public override FIXType FIXType
		{
			get
			{
				return FIXType.Int;
			}
		}

		public FIXIntField() : base()
		{
		}

		public FIXIntField(int tag, int value = 0) : base(tag)
		{
			this.Value = value;
		}

		public FIXIntField(int tag, string value, bool invariantCulture = false) : this(tag, invariantCulture ? int.Parse(value, (IFormatProvider)CultureInfo.InvariantCulture) : int.Parse(value))
		{
		}

		public override string ToString()
		{
			return this.Value.ToString();
		}

		public override string ToInvariantString()
		{
			return this.Value.ToString((IFormatProvider)CultureInfo.InvariantCulture);
		}

		public override object GetValue()
		{
			return this.Value;
		}
	}
}
