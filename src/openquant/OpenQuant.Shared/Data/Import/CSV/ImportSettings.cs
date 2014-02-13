using System.IO;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class ImportSettings
	{
		public FileInfo[] Files { get; set; }

		public Template Template { get; set; }

		public ImportSettings()
		{
			this.Files = new FileInfo[0];
			this.Template = new Template();
		}
	}
}
