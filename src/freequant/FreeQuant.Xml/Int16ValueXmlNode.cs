namespace FreeQuant.Xml
{
	public class Int16ValueXmlNode : ValueXmlNode
	{
		public short Value
		{
			get
			{
				return this.GetInt16Value();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public Int16ValueXmlNode()  :  base()
		{
		}

		
		public short GetValue(short defaultValue)
		{
			return this.GetInt16Value(defaultValue);
		}
	}
}
