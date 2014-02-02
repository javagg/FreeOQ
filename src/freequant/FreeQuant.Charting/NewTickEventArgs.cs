using System;

namespace FreeQuant.Charting
{
	public class NewTickEventArgs : EventArgs
	{
		public DateTime DateTime { get; set; }
		public NewTickEventArgs(DateTime datetime)
		{
			this.DateTime = datetime;
		}
	}
}
