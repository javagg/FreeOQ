using FreeQuant;
using System;

namespace FreeQuant.Providers
{
	public class ProviderErrorEventArgs : EventArgs
	{
		public ProviderError Error { get; private set; }

		public ProviderErrorEventArgs(ProviderError error) : base()
		{
			this.Error = error;
		}

		public ProviderErrorEventArgs(DateTime datetime, IProvider provider, int id, int code, string message)
			: this(new ProviderError(datetime, provider, id, code, message))
		{
		}

		public ProviderErrorEventArgs(IProvider provider, int id, int code, string message)
			: this(new ProviderError(Clock.Now, provider, id, code, message))
		{
		}
	}
}
