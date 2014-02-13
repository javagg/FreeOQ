namespace OpenQuant.Shared.Logs
{
	public struct TabLayoutInfo
	{
		public string TabName;
		public ColumnLayoutInfo[] StrategyColumns;
		public ColumnLayoutInfo[] InstrumentColumns;

		public static TabLayoutInfo Default
		{
			get
			{
				return new TabLayoutInfo()
				{
					TabName = string.Empty,
					StrategyColumns = new ColumnLayoutInfo[0],
					InstrumentColumns = new ColumnLayoutInfo[0]
				};
			}
		}
	}
}
