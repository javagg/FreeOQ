using FreeQuant;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
	class PluginSQViewItem : ListViewItem
	{
		private Plugin plugin;

		public Plugin Plugin
		{
			get
			{
				return this.plugin;
			}
		}

		public PluginSQViewItem(Plugin plugin)  : base(new string[3])
		{
			this.plugin = plugin;
			this.SubItems[0].Text = plugin.TypeName;
			this.SubItems[1].Text = plugin.AssemblyName;
			this.SubItems[2].Text = plugin.X64Supported ? "+" : "";
			this.Checked = plugin.Enabled;
			this.UpdateIcon(plugin.Enabled);
		}

		public void UpdateIcon(bool checked_)
		{
			if (this.plugin.Loaded)
				this.ImageIndex = 1;
			else
				this.ImageIndex = checked_ ? 2 : 0;
		}
	}
}
