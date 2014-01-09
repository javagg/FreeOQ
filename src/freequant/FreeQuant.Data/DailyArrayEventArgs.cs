using System;

namespace FreeQuant.Data
{
	public class DailyArrayEventArgs : EventArgs
	{
		private DailyArray dailyArray;

		public DailyArray DailyArray
		{
			get
			{
				return this.dailyArray;
			}
		}

		public DailyArrayEventArgs(DailyArray dailyArray)
		{
			this.dailyArray = dailyArray; 
		}
	}
}
