using FreeQuant.Data;

namespace OpenQuant.Shared.Data
{
	public class DataSeriesInfo
	{
		public string SeriesName { get; set; }

		public string Symbol { get; set; }

		public string Suffix { get; set; }

		public DataType DataType { get; set; }

		public BarType BarType { get; set; }

		public long BarSize { get; set; }

		public DataSeriesInfo()
		{
			this.SeriesName = string.Empty;
			this.Symbol = string.Empty;
			this.Suffix = string.Empty;
			this.DataType = DataType.Unknown;
			this.BarType = BarType.Dynamic;
			this.BarSize = -1;
		}
	}
}
