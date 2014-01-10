using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class BarSliceEventArgs : EventArgs
	{
		private IMarketDataProvider provider;
		private long barSize;

		public IMarketDataProvider Provider
		{
			get
			{
				return this.provider; 
			}
		}

		public long BarSize
		{
			get
			{
				return this.barSize; 
			}
		}

		public BarSliceEventArgs(long barSize, IMarketDataProvider provider) : base()
		{
			this.barSize = barSize;
			this.provider = provider;
		}
	}
}
