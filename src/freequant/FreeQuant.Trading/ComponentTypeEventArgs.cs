using System;

namespace FreeQuant.Trading
{
	public class ComponentTypeEventArgs : EventArgs
	{
		public ComponentType ComponentType { get; private set; }

		public ComponentTypeEventArgs(ComponentType componentType)
		{
			this.ComponentType = componentType;
		}
	}
}
