namespace FreeQuant.Xml
{
	public class ByteValueXmlNode : ValueXmlNode
	{
		public byte Value
		{
			get
			{
				return this.GetByteValue();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public ByteValueXmlNode() : base()
		{
		}

		public byte GetValue(byte defaultValue)
		{
			return this.GetByteValue(defaultValue);
		}
	}
}
