using System.Windows.Forms;

namespace OpenQuant.Shared.Editor
{
	public class EditorActionItem
	{
		public EditorAction Action { get; private set; }

		public ToolStripItem[] Items { get; private set; }

		public EditorActionItem(EditorAction action, params ToolStripItem[] items)
		{
			this.Action = action;
			this.Items = items;
		}
	}
}
