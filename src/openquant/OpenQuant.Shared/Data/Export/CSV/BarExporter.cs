using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Export.CSV
{
	class BarExporter : DataExporter
	{
		public override string[] GetHeader()
		{
			return new string[]
			{
				"DateTime",
				"Open",
				"High",
				"Low",
				"Close",
				"Volume",
				"OpenInt"
			};
		}

		public override string[] DataObjectToString(IDataObject obj)
		{
			Bar bar = (Bar)obj;
			return new string[]
			{
				this.DateTimeToString(bar.DateTime, false),
				this.DoubleToString(bar.Open),
				this.DoubleToString(bar.High),
				this.DoubleToString(bar.Low),
				this.DoubleToString(bar.Close),
				bar.Volume.ToString(),
				bar.OpenInt.ToString()
			};
		}
	}
}
