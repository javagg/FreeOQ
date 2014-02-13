using System;
using System.Windows.Forms;

namespace OpenQuant.Shared.Editor
{
	class EditorActionProxy
	{
		private EditorAction action;

		public event EventHandler<EditorActionEventArgs> Click;

		public EditorActionProxy(EditorAction action, ToolStripItem[] items)
		{
			this.action = action;
			foreach (ToolStripItem toolStripItem in items)
				toolStripItem.Click += new EventHandler(this.item_Click);
		}

		private void item_Click(object sender, EventArgs e)
		{
			if (this.Click == null)
				return;
			this.Click(sender, new EditorActionEventArgs(this.action));
		}
	}
}
