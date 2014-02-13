using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
	[ToolboxBitmap(typeof(ContextMenuStrip))]
	internal class ColumnContextMenuStrip : ContextMenuStrip
	{
		private int column;

		public int Column { get; set; }
	}
}
