using OpenQuant.API.Plugins;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared.Plugins
{
	public class PluginManager
	{
		private FileInfo configFile;
		private PluginInfoList plugins;

		public PluginInfoList Plugins
		{
			get
			{
				return this.plugins;
			}
		}

		public PluginManager(FileInfo configFile)
		{
			this.configFile = configFile;
			this.plugins = new PluginInfoList();
		}

		public void LoadConfig()
		{
//			if (!this.configFile.Exists)
//				return;
//			PluginsXmlDocument pluginsXmlDocument = new PluginsXmlDocument();
//			((XmlDocument) pluginsXmlDocument).Load(this.configFile.FullName);
//			IEnumerator enumerator = pluginsXmlDocument.Plugins.GetEnumerator();
//			try
//			{
//				while (enumerator.MoveNext())
//				{
//					PluginXmlNode pluginXmlNode = (PluginXmlNode) enumerator.Current;
//					PluginInfo plugin = new PluginInfo(pluginXmlNode.PluginType, pluginXmlNode.TypeName.get_Value(), pluginXmlNode.AssemblyName.get_Value());
//					plugin.Enabled = pluginXmlNode.Enabled;
//					if (pluginXmlNode.X86.HasValue)
//						plugin.x86 = pluginXmlNode.X86.Value;
//					if (pluginXmlNode.X64.HasValue)
//						plugin.x64 = pluginXmlNode.X64.Value;
//					this.plugins.Add(plugin);
//				}
//			}
//			finally
//			{
//				IDisposable disposable = enumerator as IDisposable;
//				if (disposable != null)
//					disposable.Dispose();
//			}
		}

		public void SaveConfig()
		{
//			PluginsXmlDocument pluginsXmlDocument = new PluginsXmlDocument();
//			foreach (PluginInfo plugin in this.plugins)
//				pluginsXmlDocument.Plugins.Add(plugin);
//			((XmlDocument) pluginsXmlDocument).Save(this.configFile.FullName);
		}

		public void LoadPlugins()
		{
			foreach (PluginInfo plugin in this.plugins)
			{
				if (plugin.Enabled && (Environment.Is64BitProcess || plugin.x86) && (!Environment.Is64BitProcess || plugin.x64))
					this.LoadPlugin(plugin);
			}
		}

		public void LoadPlugin(PluginInfo plugin)
		{
			try
			{
				object obj = plugin.Load();
				if (plugin.PluginType != PluginType.UserProvider)
					return;
				FieldInfo field = typeof (UserProvider).GetField("provider", BindingFlags.Instance | BindingFlags.NonPublic);
				if (!(field != (FieldInfo) null))
					return;
				ProviderManager.Add((IProvider)field.GetValue(obj));
			}
			catch (Exception ex)
			{
				int num = (int) MessageBox.Show(((object) ex).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		public System.Type GetPluginBaseType(PluginType pluginType)
		{
			if (pluginType == PluginType.UserProvider)
				return typeof (UserProvider);
			else
				throw new ArgumentException(string.Format("Unknown plugin type - {0}", (object) pluginType));
		}
	}
}
