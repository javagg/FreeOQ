using System;

namespace OpenQuant.Shared.ToolWindows
{
	public class PropertyObjectEventArgs : EventArgs
	{
		public object PropertyObject { get; private set; }

		public PropertyObjectEventArgs(object propertyObject)
		{
			this.PropertyObject = propertyObject;
		}
	}
}
