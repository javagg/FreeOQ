namespace FreeQuant.Xml
{
	public class DoubleValueXmlNode : ValueXmlNode
	{
		public double Value
		{
			get
			{
				return this.GetDoubleValue();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public DoubleValueXmlNode() : base()
		{
		}

		public double GetValue(double defaultValue)
		{
			return this.GetDoubleValue(defaultValue);
		}
	}
}
