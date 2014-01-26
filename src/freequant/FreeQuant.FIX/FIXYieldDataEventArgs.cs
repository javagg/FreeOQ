using System;

namespace FreeQuant.FIX
{
	public class FIXYieldDataEventArgs : EventArgs
	{
		public FIXYieldData YieldData { get; set; }

		public FIXYieldDataEventArgs(FIXYieldData yieldData)
		{
			this.YieldData = yieldData;
		}
	}
}
