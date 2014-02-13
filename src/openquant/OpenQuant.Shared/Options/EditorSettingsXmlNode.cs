using FreeQuant.Xml;

namespace OpenQuant.Shared.Options
{
	class EditorSettingsXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "settings";
			}
		}

		public BooleanValueXmlNode DisplayLineNumbers
		{
			get
			{
				return this.GetBooleanValueNode("DisplayLineNumbers");
			}
		}

		public BooleanValueXmlNode AllowOutlining
		{
			get
			{
				return this.GetBooleanValueNode("AllowOutlining");
			}
		}

		public AutoSaveXmlNode AutoSave
		{
			get
			{
				return (AutoSaveXmlNode)this.GetChildNode<AutoSaveXmlNode>();
			}
		}

		public EditorSettingsXmlNode() : base()
		{
		}
	}
}
