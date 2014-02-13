namespace OpenQuant.Shared.Logs
{
	class DataViewOptions
	{
		public DataViewMode Mode { get; set; }

		public string StrategyName { get; set; }

		public string Symbol { get; set; }

		public ColumnItem ColumnItem { get; set; }

		public DataViewOptions()
		{
			this.Mode = DataViewMode.Undefined;
			this.StrategyName = null;
			this.Symbol = null;
			this.ColumnItem = null;
		}
	}
}
