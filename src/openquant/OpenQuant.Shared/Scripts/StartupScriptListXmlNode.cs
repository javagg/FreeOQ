using FreeQuant.Xml;
using System.IO;

namespace OpenQuant.Shared.Scripts
{
	class StartupScriptListXmlNode : ListXmlNode<StartupScriptXmlNode>
	{
		public override string NodeName
		{
			get
			{
				return "scripts.startup";
			}
		}

		public StartupScriptListXmlNode() : base()
		{
		}

		public void Add(FileInfo file, DirectoryInfo directory)
		{
			this.AppendChildNode<StartupScriptXmlNode>().Path.SetValue(file, directory);
//			((StartupScriptXmlNode)((XmlNodeBase)this).AppendChildNode<StartupScriptXmlNode>()).Path.SetValue(file, directory);
		}
	}
}
