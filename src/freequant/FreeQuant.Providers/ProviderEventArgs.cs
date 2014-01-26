using System;

namespace FreeQuant.Providers
{
	public class ProviderEventArgs : EventArgs
	{
		public IProvider Provider { get; private set; }
		public ProviderEventArgs(IProvider provider) : base()
		{
			this.Provider = provider;
		}
	}
}
