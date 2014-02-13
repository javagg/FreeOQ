using OpenQuant.Shared.Data;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class Template
	{
		public string Name { get; set; }

		public CSVOptions CSVOptions { get; set; }

		public DataOptions DataOptions { get; set; }

		public DateOptions DateOptions { get; set; }

		public SymbolOptions SymbolOptions { get; set; }

		public OtherOptions OtherOptions { get; set; }

		public ColumnCollection Columns { get; set; }

		public bool IsCompleted { get; private set; }

		public Template()
		{
			this.CSVOptions = new CSVOptions();
			this.DataOptions = new DataOptions();
			this.DateOptions = new DateOptions();
			this.Columns = new ColumnCollection();
			this.SymbolOptions = new SymbolOptions();
			this.OtherOptions = new OtherOptions();
			this.IsCompleted = false;
			this.Name = string.Empty;
		}

		public string[] Validate()
		{
			ArrayList list = new ArrayList();
			switch (this.DataOptions.DataType)
			{
				case DataType.Trade:
					this.CheckDateOptions(list);
					break;
				case DataType.Quote:
					this.CheckDateOptions(list);
					break;
				case DataType.Bar:
					this.CheckDateOptions(list);
					break;
				case DataType.Daily:
					this.CheckColumn(ColumnType.Date, list);
					break;
			}
			switch (this.SymbolOptions.Option)
			{
				case SymbolOption.Column:
					this.CheckColumn(ColumnType.Symbol, list);
					break;
				case SymbolOption.Manually:
					if (this.SymbolOptions.Name == "")
					{
						list.Add((object)"Symbol name is not provided.");
						break;
					}
					else
						break;
			}
			this.IsCompleted = list.Count == 0;
			return list.ToArray(typeof(string)) as string[];
		}

		public override string ToString()
		{
			return this.Name;
		}

		private Column GetColumn(ColumnType type)
		{
			foreach (Column column in (List<Column>) this.Columns)
			{
				if (type == column.ColumnType)
					return column;
			}
			return (Column)null;
		}

		private void CheckColumn(ColumnType columnType, ArrayList list)
		{
			if (this.GetColumn(columnType) != null)
				return;
			list.Add(("Column '" + ((object)columnType).ToString() + "' not found."));
		}

		private void CheckDateOptions(ArrayList list)
		{
			switch (this.DateOptions.DateType)
			{
				case DateType.Column:
					if (this.GetColumn(ColumnType.DateTime) != null)
						break;
					Column column1 = this.GetColumn(ColumnType.Date);
					Column column2 = this.GetColumn(ColumnType.Time);
					if (column1 == null && column2 == null)
					{
						list.Add("Column 'DateTime' or column pair('Date' and 'Time') not found.");
						break;
					}
					else if (column1 == null)
					{
						list.Add("Column 'Date' not found.");
						break;
					}
					else
					{
						if (column2 != null)
							break;
						list.Add("Column 'Time' not found.");
						break;
					}
				case DateType.Manually:
					this.CheckColumn(ColumnType.Time, list);
					break;
			}
		}
	}
}
