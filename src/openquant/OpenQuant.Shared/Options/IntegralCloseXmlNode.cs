using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class IntegralCloseXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "integral_close";
			}
		}

		public bool Value
		{
			get
			{
				bool result;
				if (!bool.TryParse(this.GetStringValue(), out result))
					result = false;
				return result;
			}
			set
			{
				this.SetValue(value);
			}
		}

		public IntegralCloseXmlNode() : base()
		{
		}
	}
}
