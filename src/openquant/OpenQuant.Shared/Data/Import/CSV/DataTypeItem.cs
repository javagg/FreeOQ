using OpenQuant.Shared.Data;
using System.Collections;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class DataTypeItem
	{
		private ArrayList allowedColumns;

		public DataType DataType { get; private set; }

		public DataTypeItem(DataType dataType, ColumnType[] allowedColumns)
		{
			this.DataType = dataType;
			this.allowedColumns = new ArrayList((ICollection)allowedColumns);
		}

		public override string ToString()
		{
			return ((object)this.DataType).ToString();
		}

		public bool IsColumnAllowed(ColumnType columnType)
		{
			return this.allowedColumns.Contains(columnType);
		}
	}
}
