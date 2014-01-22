using System;

namespace FreeQuant.Series
{
	public class DateTimeEventArgs : EventArgs
	{
		public DateTime DateTime;

		public DateTimeEventArgs(DateTime dateTime) : base()
		{
			this.DateTime = dateTime;
		}
	}
}
