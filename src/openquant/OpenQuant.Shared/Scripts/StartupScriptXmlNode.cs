using FreeQuant.Xml;

namespace OpenQuant.Shared.Scripts
{
	class StartupScriptXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "script";
			}
		}

		public PathXmlNode Path
		{
			get
			{
				return this.GetChildNode<PathXmlNode>();
			}
		}

		public StartupScriptXmlNode() : base()
		{
		}
	}
}
