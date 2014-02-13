namespace FreeQuant.Xml
{
	public class BooleanValueXmlNode : ValueXmlNode
	{
		public bool Value
		{
			get
			{
				return this.GetBooleanValue();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public BooleanValueXmlNode() : base()
		{ 
		}

		public bool GetValue(bool defaultValue)
		{
			return this.GetBooleanValue(defaultValue);
		}
	}
}
