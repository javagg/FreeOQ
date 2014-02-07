using System;
using System.ComponentModel;

namespace FreeQuant
{
	public class PluginEventArgs : EventArgs
	{
		public Plugin Plugin { get; private set; }

		public PluginEventArgs(Plugin plugin) : base()
		{
			this.Plugin = plugin;
		}
	}
}
