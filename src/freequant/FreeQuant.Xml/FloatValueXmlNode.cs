namespace FreeQuant.Xml
{
	public class FloatValueXmlNode : ValueXmlNode
	{
		public float Value
		{
			get
			{
				return this.GetFloatValue();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public FloatValueXmlNode() : base()
		{
		}

		public float GetValue(float defaultValue)
		{
			return this.GetFloatValue(defaultValue);
		}
	}
}
