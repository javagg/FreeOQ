namespace FreeQuant.Providers
{
	public class HistoricalDataProviderList : ProviderList
	{
		public new IHistoricalDataProvider this[string name]
		{
			get
			{
				return base[name] as IHistoricalDataProvider;
			}
		}

		public new IHistoricalDataProvider this[byte id]
		{
			get
			{
				return base[id] as IHistoricalDataProvider;
			}
		}

		internal HistoricalDataProviderList() : base()
		{
		}
	}
}
