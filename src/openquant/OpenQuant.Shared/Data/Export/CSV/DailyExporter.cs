using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Export.CSV
{
	class DailyExporter : BarExporter
	{
		public override string[] GetHeader()
		{
			string[] header = base.GetHeader();
			header[0] = "Date";
			return header;
		}

		public override string[] DataObjectToString(IDataObject obj)
		{
			Daily daily = (Daily)obj;
			string[] strArray = base.DataObjectToString((IDataObject)daily);
			strArray[0] = this.DateTimeToString(daily.Date, true);
			return strArray;
		}
	}
}
