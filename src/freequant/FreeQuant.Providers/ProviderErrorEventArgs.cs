using FreeQuant;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class ProviderErrorEventArgs : EventArgs
	{
		private ProviderError error;

		public ProviderError Error
		{
			get
			{
				return this.error; 
			}
		}

		public ProviderErrorEventArgs(ProviderError error) : base()
		{
			this.error = error;
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
