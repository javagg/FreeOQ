using FreeQuant.Xml;
using System;
using TD.SandDock.Rendering;

namespace OpenQuant.Shared.Options
{
	class LayoutColorSchemeXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "color_scheme";
			}
		}

		public WindowsColorScheme Value
		{
			get
			{
				return (WindowsColorScheme)Enum.Parse(typeof(WindowsColorScheme), this.GetStringValue());
			}
			set
			{
				this.SetValue((Enum)value);
			}
		}

		public LayoutColorSchemeXmlNode() : base()
		{
		}
	}
}
