namespace FreeQuant.Services
{
	public class ExecutionServiceList : ServiceList
	{
		public IExecutionService this[string name]
		{
			get
			{
				return base[name] as IExecutionService;
			}
		}

		public IExecutionService this[byte id]
		{
			get
			{
				return base[id] as IExecutionService;
			}
		}

		public ExecutionServiceList() : base()
		{

		}
	}
}
