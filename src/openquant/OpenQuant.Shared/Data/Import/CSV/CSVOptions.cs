using System.Globalization;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class CSVOptions
	{
		public Separator Separator { get; set; }

		public int HeaderLineCount { get; set; }

		public CultureInfo CultureInfo { get; set; }

		public CSVOptions()
		{
			this.Separator = Separator.Comma;
			this.HeaderLineCount = 0;
			this.CultureInfo = new CultureInfo("en-US");
		}
	}
}
