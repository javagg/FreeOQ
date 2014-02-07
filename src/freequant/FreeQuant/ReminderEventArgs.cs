using System;

namespace FreeQuant
{
	public class ReminderEventArgs : EventArgs
	{
		public DateTime SignalTime { get; private set; }
		public object Data  { get; private set; }
	}
}
