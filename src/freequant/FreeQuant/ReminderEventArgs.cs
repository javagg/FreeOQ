using System;

namespace FreeQuant
{
	public class ReminderEventArgs : EventArgs
	{
		private DateTime signalTime = DateTime.MaxValue;
		private object data = null;

		public DateTime SignalTime { get { return signalTime; } }
		public object Data  { get { return data; } }
	}
}
