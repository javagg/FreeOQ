namespace FreeQuant.Services
{
	public class ExecutionServiceEventArgs : MarketServiceEventArgs
	{
		public IExecutionService Service
		{
			get
			{
				return base.Service as IExecutionService;
			}
		}

		public ExecutionServiceEventArgs(IExecutionService service) : base((IMarketService)service)
		{
		}
	}
}
