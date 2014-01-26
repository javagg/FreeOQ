using System;

namespace FreeQuant.FIX
{
	public class FIXStringField : FIXField
	{
		public const string Empty = "";
		public string Value;

		public override FIXType FIXType
		{
			get
			{
				return FIXType.String;
			}
		}

		public FIXStringField() : base()
		{
		}

		public FIXStringField(int tag) : this(tag, String.Empty)
		{
		}

		public FIXStringField(int tag, string value, bool invariantCulture = false) : base(tag)
		{
			this.Value = invariantCulture ? value : value;
		}

		public override string ToString()
		{
			return this.Value.ToString();
		}

		public override string ToInvariantString()
		{
			return this.ToString();
		}

		public override object GetValue()
		{
			return this.Value;
		}
	}
}
