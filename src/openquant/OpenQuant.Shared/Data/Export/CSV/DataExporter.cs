using FreeQuant.Data;
using System;
using System.Globalization;

namespace OpenQuant.Shared.Data.Export.CSV
{
	internal abstract class DataExporter
	{
		public abstract string[] GetHeader();

		public abstract string[] DataObjectToString(IDataObject obj);

		protected string DateTimeToString(DateTime datetime, bool dateOnly)
		{
			if (dateOnly)
				return datetime.ToString("yyyy-MM-dd");
			else
				return datetime.ToString("yyyy-MM-dd HH:mm:ss.fff");
		}

		protected string DoubleToString(double value)
		{
			return value.ToString((IFormatProvider)CultureInfo.InvariantCulture);
		}
	}
}
