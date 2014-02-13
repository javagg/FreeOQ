using System;

namespace OpenQuant.Shared.Editor
{
	public class EditorActionEventArgs : EventArgs
	{
		public EditorAction Action { get; private set; }

		public EditorActionEventArgs(EditorAction action)
		{
			this.Action = action;
		}
	}
}
