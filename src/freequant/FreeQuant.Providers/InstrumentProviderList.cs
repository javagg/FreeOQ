namespace FreeQuant.Providers
{
	public class InstrumentProviderList : ProviderList
	{
		new public IInstrumentProvider this [string name]
		{
			get
			{
				return base[name] as IInstrumentProvider;
			}
		}

		new public IInstrumentProvider this [byte id]
		{
			get
			{
				return base[id] as IInstrumentProvider;
			}
		}
	}
}
