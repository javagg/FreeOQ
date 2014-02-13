using System;

namespace FreeQuant.Xml
{
	public class DecimalValueXmlNode : ValueXmlNode
	{
		public Decimal Value
		{
			get
			{
				return this.GetDecimalValue();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public DecimalValueXmlNode() : base()
		{
		}

		public Decimal GetValue(Decimal defaultValue)
		{
			return this.GetDecimalValue(defaultValue);
		}
	}
}
