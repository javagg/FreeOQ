using System;
namespace FreeQuant.File
{
	public class DefragmentCancelEventArgs : EventArgs
	{
		public bool Cancel { get; set; }
	}
	public delegate void DefragmentCancelEventHandler(DefragmentCancelEventArgs args);
}
