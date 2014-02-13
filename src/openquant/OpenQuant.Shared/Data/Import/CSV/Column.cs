using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class Column
	{
		public ColumnType ColumnType { get; set; }

		public string ColumnFormat { get; set; }

		public Column()
		{
			this.ColumnType = ColumnType.Skipped;
			this.ColumnFormat = string.Empty;
		}

		public static string ToString(ColumnType columnType)
		{
			switch (columnType)
			{
				case ColumnType.AskSize:
					return "Ask Size";
				case ColumnType.Skipped:
					return "<skipped>";
				case ColumnType.BidSize:
					return "Bid Size";
				case ColumnType.Ask:
					return "Ask";
				case ColumnType.OpenInt:
					return "Open Int";
				case ColumnType.Bid:
					return "Bid";
				case ColumnType.Close:
					return "Close";
				case ColumnType.Volume:
					return "Volume";
				case ColumnType.High:
					return "High";
				case ColumnType.Low:
					return "Low";
				case ColumnType.Size:
					return "Size";
				case ColumnType.Open:
					return "Open";
				case ColumnType.Symbol:
					return "Symbol";
				case ColumnType.DateTime:
					return "DateTime";
				case ColumnType.Date:
					return "Date";
				case ColumnType.Time:
					return "Time";
				case ColumnType.Price:
					return "Price";
				default:
					throw new ArgumentException("Unknown column type - " + ((object)columnType).ToString());
			}
		}
	}
}
