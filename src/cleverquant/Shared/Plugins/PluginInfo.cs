using System;

namespace OpenQuant.Shared.Plugins
{
	public enum PluginType
	{
		UserProvider,
	}

	public class PluginInfo
	{
		public PluginType PluginType { get; private set; }

		public bool Enabled { get; set; }

		public string TypeName { get; private set; }

		public string AssemblyName { get; private set; }

		public bool x86 { get; set; }

		public bool x64 { get; set; }

		public bool Loaded { get; private set; }

		public PluginInfo(PluginType pluginType, string typeName, string assemblyName)
		{
			this.PluginType = pluginType;
			this.TypeName = typeName;
			this.AssemblyName = assemblyName;
			this.Enabled = true;
			this.x86 = true;
			this.x64 = true;
			this.Loaded = false;
		}

		public object Load()
		{
			if (this.Loaded)
				return (object) null;
			Type type = Type.GetType(string.Format("{0}, {1}", (object) this.TypeName, (object) this.AssemblyName));
			if (type == (Type) null)
				throw new Exception(string.Format("Plugin could not be found, type={0}, assembly={1}", (object) this.TypeName, (object) this.AssemblyName));
			object instance = Activator.CreateInstance(type);
			this.Loaded = true;
			return instance;
		}
	}
}
