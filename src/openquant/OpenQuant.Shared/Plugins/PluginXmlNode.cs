using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Plugins
{
	class PluginXmlNode : XmlNodeBase
	{
		private const string ATTR_PLUGIN_TYPE = "pluginType";
		private const string ATTR_ENABLED = "enabled";
		private const string ATTR_X86 = "x86";
		private const string ATTR_X64 = "x64";
		private const string NODE_TYPE = "type";
		private const string NODE_ASSEMBLY = "assembly";

		public override string NodeName
		{
			get
			{
				return "plugin";
			}
		}

		public PluginType PluginType
		{
			get
			{
				return  (PluginType)this.GetEnumAttribute("pluginType", typeof(PluginType));
			}
			set
			{
				this.SetAttribute("pluginType", (Enum)value);
			}
		}

		public bool Enabled
		{
			get
			{
				return this.GetBooleanAttribute("enabled");
			}
			set
			{
				this.SetAttribute("enabled", value);
			}
		}

		public StringValueXmlNode TypeName
		{
			get
			{
				return (StringValueXmlNode)this.GetChildNode<StringValueXmlNode>("type");
			}
		}

		public StringValueXmlNode AssemblyName
		{
			get
			{
				return  this.GetChildNode<StringValueXmlNode>("assembly");
			}
		}

		public bool? X86
		{
			get
			{
				if (!this.ContainsAttribute("x86"))
					return new bool?();
				else
					return new bool?(this.GetBooleanAttribute("x86"));
			}
			set
			{
				this.SetAttribute("x86", value.Value);
			}
		}

		public bool? X64
		{
			get
			{
				if (!this.ContainsAttribute("x64"))
					return new bool?();
				else
					return new bool?(this.GetBooleanAttribute("x64"));
			}
			set
			{
				this.SetAttribute("x64", value.Value);
			}
		}

		public PluginXmlNode() : base()
		{
		}
	}
}
