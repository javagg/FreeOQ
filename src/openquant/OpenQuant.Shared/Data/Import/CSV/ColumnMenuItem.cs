using System;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class ColumnMenuItem : ToolStripMenuItem
	{
		public ColumnType ColumnType { get; private set; }

		public string ColumnFormat { get; private set; }

		public ColumnMenuItem(ColumnType columnType, string columnFormat, ToolStripItem[] subItems, EventHandler handler)
		{
			this.ColumnType = columnType;
			this.ColumnFormat = columnFormat;
			if (subItems != null)
				this.DropDownItems.AddRange(subItems);
			this.Text = columnFormat == "" ? Column.ToString(columnType) : columnFormat;
			if (handler == null)
				return;
			this.Click += handler;
		}

		public ColumnMenuItem(ColumnType columnType, ToolStripItem[] subItems)
      : this(columnType, "", subItems, (EventHandler)null)
		{
		}

		public ColumnMenuItem(ColumnType columnType, EventHandler handler)
      : this(columnType, "", (ToolStripItem[])null, handler)
		{
		}

		public ColumnMenuItem(ColumnType columnType, string format, EventHandler handler)
      : this(columnType, format, (ToolStripItem[])null, handler)
		{
		}
	}
}
