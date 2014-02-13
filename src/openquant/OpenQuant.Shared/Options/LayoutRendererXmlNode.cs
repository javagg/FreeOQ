using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Options
{
	class LayoutRendererXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "renderer";
			}
		}

		public LayoutRenderer Value
		{
			get
			{
				return (LayoutRenderer)Enum.Parse(typeof(LayoutRenderer), this.GetStringValue());
			}
			set
			{
				this.SetValue((Enum)value);
			}
		}

		public LayoutRendererXmlNode() : base()
		{
		}
	}
}
