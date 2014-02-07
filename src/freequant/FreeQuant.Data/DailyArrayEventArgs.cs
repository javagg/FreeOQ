using System;

namespace FreeQuant.Data
{
	public class DailyArrayEventArgs : EventArgs
	{
		public DailyArray DailyArray { get; private set; }

		public DailyArrayEventArgs(DailyArray dailyArray)
		{
			this.DailyArray = dailyArray; 
		}
	}
}
