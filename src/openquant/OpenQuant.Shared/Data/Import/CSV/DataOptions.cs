using OpenQuant.Shared.Data;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class DataOptions
	{
		public DataType DataType { get; set; }
		public long BarSize { get; set; }
		public BarDateTime BarDateTime { get; set; }

		public DataOptions()
		{
			this.DataType = DataType.Daily;
			this.BarSize = 60;
			this.BarDateTime = BarDateTime.BeginTime;
		}
	}
}
