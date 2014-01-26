using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class BarSliceEventArgs : EventArgs
	{
		public IMarketDataProvider Provider { get; private set; }
		public long BarSize{ get; private set; }

		public BarSliceEventArgs(long barSize, IMarketDataProvider provider) : base()
		{
			this.BarSize = barSize;
			this.Provider = provider;
		}
	}
}
