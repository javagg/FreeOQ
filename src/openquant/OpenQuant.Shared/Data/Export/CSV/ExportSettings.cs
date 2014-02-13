using System;
using System.IO;

namespace OpenQuant.Shared.Data.Export.CSV
{
	internal class ExportSettings
	{
		public DirectoryInfo Directory { get; private set; }

		public DateTime RangeBegin { get; private set; }

		public DateTime RangeEnd { get; private set; }

		public ExportSettings(DirectoryInfo directory, DateTime rangeBegin, DateTime rangeEnd)
		{
			this.Directory = directory;
			this.RangeBegin = rangeBegin;
			this.RangeEnd = rangeEnd;
		}
	}
}
