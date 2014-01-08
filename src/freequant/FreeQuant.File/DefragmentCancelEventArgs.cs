using System;

namespace FreeQuant.File
{
	public class DefragmentCancelEventArgs : EventArgs
	{
		private bool cancel;

		public bool Cancel
		{
			get
			{
				return this.cancel; 
			}
			set
			{
				this.cancel = value;
			}
		}

		public DefragmentCancelEventArgs()
		{
			this.cancel = false;
		}
	}
}
