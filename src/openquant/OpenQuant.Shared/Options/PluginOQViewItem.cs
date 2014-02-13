using OpenQuant.Shared.Plugins;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
	class PluginOQViewItem : ListViewItem
	{
		private PluginInfo plugin;

		public PluginInfo Plugin
		{
			get
			{
				return this.plugin;
			}
		}

		public PluginOQViewItem(PluginInfo plugin)      : base(new string[2])
		{
			this.plugin = plugin;
			this.SubItems[0].Text = plugin.TypeName;
			this.SubItems[1].Text = plugin.AssemblyName;
			this.Checked = plugin.Enabled;
			this.UpdateIcon();
		}

		public void UpdateIcon()
		{
			if (this.plugin.Loaded)
				this.ImageIndex = 1;
			else
				this.ImageIndex = this.Checked ? 2 : 0;
		}
	}
}
