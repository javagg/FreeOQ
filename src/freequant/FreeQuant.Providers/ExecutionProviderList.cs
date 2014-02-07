namespace FreeQuant.Providers
{
	public class ExecutionProviderList : ProviderList
	{
		public new IExecutionProvider this[string name]
		{
			get
			{
				return base[name] as IExecutionProvider;
			}
		}

		new public IExecutionProvider this[byte id]
		{
			get
			{
				return base[id] as IExecutionProvider;
			}
		}

		internal ExecutionProviderList() : base()
		{
		}
	}
}
