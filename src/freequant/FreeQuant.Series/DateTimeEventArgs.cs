using System;

namespace FreeQuant.Series
{
	public class DateTimeEventArgs : EventArgs
	{
		public DateTime DateTime { get; set; }

		public DateTimeEventArgs(DateTime dateTime) : base()
		{
			this.DateTime = dateTime;
		}
	}
}
