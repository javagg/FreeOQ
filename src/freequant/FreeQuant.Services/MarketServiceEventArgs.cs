namespace FreeQuant.Services
{
	public class MarketServiceEventArgs : ServiceEventArgs
	{
		new public IMarketService Service
		{
			get
			{
				return base.Service as IMarketService;
			}
		}

		public MarketServiceEventArgs(IMarketService service) : base(service)
		{
		}
	}
}
