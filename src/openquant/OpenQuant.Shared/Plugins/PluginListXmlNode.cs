using FreeQuant.Xml;

namespace OpenQuant.Shared.Plugins
{
	class PluginListXmlNode : ListXmlNode<PluginXmlNode>
	{
		public override string NodeName
		{
			get
			{
				return "plugins";
			}
		}

		public PluginListXmlNode() : base()
		{
		}

		public void Add(PluginInfo plugin)
		{
			PluginXmlNode pluginXmlNode = this.AppendChildNode();
			pluginXmlNode.PluginType = plugin.PluginType;
			pluginXmlNode.Enabled = plugin.Enabled;
			pluginXmlNode.TypeName.Value = plugin.TypeName;
			pluginXmlNode.AssemblyName.Value = plugin.AssemblyName;
			pluginXmlNode.X86 = new bool?(plugin.x86);
			pluginXmlNode.X64 = new bool?(plugin.x64);
		}
	}
}
