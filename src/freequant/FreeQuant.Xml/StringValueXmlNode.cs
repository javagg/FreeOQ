namespace FreeQuant.Xml
{
	public class StringValueXmlNode : ValueXmlNode
	{
		public string Value
		{
			get
			{
				return this.GetStringValue();
			}
			set
			{
				this.SetValue(value);
			}
		}
	}
}
