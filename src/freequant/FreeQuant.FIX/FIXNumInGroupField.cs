using System;
using System.Globalization;

namespace FreeQuant.FIX
{
	public class FIXNumInGroupField : FIXField
	{
		public int Value;

		public override FIXType FIXType
		{
			get
			{
				return FIXType.NumInGroup;
			}
		}

		public FIXNumInGroupField(int tag, int value = 0) : base(tag)
		{
			this.Value = value;
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
