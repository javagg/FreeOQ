using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
	public class PluginEventArgs : EventArgs
	{
		private Plugin plugin = null;

		public Plugin Plugin
		{
			get
			{
				return plugin;
			}
		}
	}
}
