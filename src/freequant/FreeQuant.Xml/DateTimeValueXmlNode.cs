using System;

namespace FreeQuant.Xml
{
	public class DateTimeValueXmlNode : ValueXmlNode
	{
		public DateTime Value
		{
			get
			{
				return this.GetDateTimeValue();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public DateTimeValueXmlNode() :  base()
		{
		}

		
		public DateTime GetValue(DateTime defaultValue)
		{
			return this.GetDateTimeValue(defaultValue);
		}
	}
}
