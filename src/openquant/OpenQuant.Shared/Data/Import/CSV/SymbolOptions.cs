namespace OpenQuant.Shared.Data.Import.CSV
{
	class SymbolOptions
	{
		public SymbolOption Option { get; set; }

		public string Name { get; set; }

		public SymbolOptions()
		{
			this.Option = SymbolOption.FileName;
			this.Name = string.Empty;
		}
	}
}
