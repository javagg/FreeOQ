using OpenQuant.API.Plugins;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

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
            if (!this.configFile.Exists)
                return;
            PluginsXmlDocument doc = new PluginsXmlDocument();
            doc.Load(this.configFile.FullName);
            foreach (PluginXmlNode node in doc.Plugins)
            {
                PluginInfo plugin = new PluginInfo(node.PluginType, node.TypeName.Value, node.AssemblyName.Value);
                plugin.Enabled = node.Enabled;
                if (node.X86.HasValue)
                    plugin.x86 = node.X86.Value;
                if (node.X64.HasValue)
                    plugin.x64 = node.X64.Value;
                this.plugins.Add(plugin);
            }
        }

        public void SaveConfig()
        {
            PluginsXmlDocument doc = new PluginsXmlDocument();
            foreach (PluginInfo plugin in this.plugins)
                doc.Plugins.Add(plugin);
            doc.Save(this.configFile.FullName);
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
                FieldInfo field = typeof(UserProvider).GetField("provider", BindingFlags.Instance | BindingFlags.NonPublic);
                if (field == null)
                    return;
                ProviderManager.Add((IProvider)field.GetValue(obj));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public System.Type GetPluginBaseType(PluginType pluginType)
        {
            if (pluginType == PluginType.UserProvider)
                return typeof(UserProvider);
            else
                throw new ArgumentException(string.Format("Unknown plugin type - {0}", (object)pluginType));
        }
    }
}
