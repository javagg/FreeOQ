using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class ProviderEventArgs : EventArgs
	{
		private IProvider provider;

		public IProvider Provider
		{
			get
			{
				return this.provider; 
			}
		}

		public ProviderEventArgs(IProvider provider) : base()
		{
			this.provider = provider;
		}
	}
}
