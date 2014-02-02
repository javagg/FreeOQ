using System;

namespace FreeQuant
{
	public class ReferenceEventArgs : EventArgs
	{
		public Reference Reference { get; private set; }

		public ReferenceEventArgs(Reference reference)
		{
			this.Reference = reference;
		}
	}
}
