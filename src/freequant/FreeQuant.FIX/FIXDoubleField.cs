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

		public FIXDoubleField(int tag, double value = 0) : base(tag)
		{
			this.Value = value;
		}

		public FIXDoubleField(int tag, string value, bool invariantCulture = false) : this(tag, invariantCulture ? double.Parse(value, (IFormatProvider)CultureInfo.InvariantCulture) : double.Parse(value))
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
