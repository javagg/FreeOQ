using System;

namespace FreeQuant.Trading
{
	public class ComponentEventArgs : EventArgs
	{
		public ComponentRecord Record { get; private set; }

		public ComponentEventArgs(ComponentRecord record)
		{
			this.Record = record;
		}
	}
}
