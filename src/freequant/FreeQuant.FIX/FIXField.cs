using System;

namespace FreeQuant.FIX
{
	public class FIXField
	{
		public int Tag;
		public virtual FIXType FIXType
		{
			get
			{
				return FIXType.Unknown;
			}
		}

		public FIXField()
		{
		}

		protected FIXField(int tag)
		{
			this.Tag = tag;
		}

		public override string ToString()
		{
			return "";
		}

		public virtual string ToInvariantString()
		{
			return "";
		}

		public virtual object GetValue()
		{
			return null;
		}

		public static FIXField Field(FIXType type, int tag)
		{
			switch (type)
			{
				case FIXType.Bool:
					return new FIXBoolField(tag);
				case FIXType.Int:
					return new FIXIntField(tag);
				case FIXType.Double:
					return new FIXDoubleField(tag);
				case FIXType.Char:
					return new FIXCharField(tag);
				case FIXType.String:
					return new FIXStringField(tag);
				case FIXType.DateTime:
					return new FIXDateTimeField(tag);
				case FIXType.NumInGroup:
					return new FIXNumInGroupField(tag);
				default:
					throw new ArgumentException("Error: Unknown FIXType " + type);
			}
		}

		public static FIXField Field(FIXType type, int tag, string value, bool invariantCulture = false)
		{
			switch (type)
			{
				case FIXType.Bool:
					return new FIXBoolField(tag, value, invariantCulture);
				case FIXType.Int:
					return new FIXIntField(tag, value, invariantCulture);
				case FIXType.Double:
					return new FIXDoubleField(tag, value, invariantCulture);
				case FIXType.Char:
					return new FIXCharField(tag, value, invariantCulture);
				case FIXType.String:
					return new FIXStringField(tag, value, invariantCulture);
				case FIXType.DateTime:
					return new FIXDateTimeField(tag, value, invariantCulture);
				default:
					throw new ArgumentException("Error: Unknown FIXType " + type);
			}
		}
	}
}
