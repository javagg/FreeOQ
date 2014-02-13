using System;

namespace FreeQuant.Xml
{
	public class PropertyXmlNode : XmlNodeBase
	{
		private const string YISEWI7PD = "name";
		private const string f5FJf7ixS = "type";

		public override string NodeName
		{
			get
			{
				return YISEWI7PD;
			}
		}

		public string Name
		{
			get
			{
				return this.GetStringAttribute(YISEWI7PD);
			}
			set
			{
				this.SetAttribute(YISEWI7PD, value);
			}
		}

		public Type Type
		{
			get
			{
				return this.GetTypeAttribute(f5FJf7ixS);
			}
			set
			{
				this.SetAttribute(f5FJf7ixS, value);
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
