using System;

namespace FreeQuant.Xml
{
	public class PropertyXmlNode : XmlNodeBase
	{
        private const string NAME = "name";
        private const string TYPE = "type"; 

		public override string NodeName
		{
			get
			{
				return NAME;
			}
		}

		public string Name
		{
			get
			{
				return this.GetStringAttribute(NAME);
			}
			set
			{
				this.SetAttribute(NAME, value);
			}
		}

		public Type Type
		{
			get
			{
				return this.GetTypeAttribute(TYPE);
			}
			set
			{
				this.SetAttribute(TYPE, value);
			}
		}

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

		public PropertyXmlNode() : base()
		{
		}
	}
}
