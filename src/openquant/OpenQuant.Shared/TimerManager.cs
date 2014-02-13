using System.Collections.Generic;
using System.Timers;

namespace OpenQuant.Shared
{
	public class TimerManager
	{
		private Dictionary<Timer, ITimerItem> items;

		public TimerManager()
		{
			this.items = new Dictionary<Timer, ITimerItem>();
		}

		public void Start(ITimerItem item)
		{
			Timer key = new Timer();
			key.AutoReset = false;
			key.Interval = item.Interval;
			key.SynchronizingObject = item.SynchronizingObject;
			key.Elapsed += new ElapsedEventHandler(this.OnElapsed);
			lock (this.items)
				this.items.Add(key, item);
			key.Start();
		}

		public void Stop(ITimerItem item)
		{
			lock (this.items)
			{
				foreach (KeyValuePair<Timer, ITimerItem> item_0 in this.items)
				{
					if (item_0.Value == item)
					{
						this.items.Remove(item_0.Key);
						break;
					}
				}
			}
		}

		private void OnElapsed(object sender, ElapsedEventArgs e)
		{
			Timer key = (Timer)sender;
			ITimerItem timerItem;
			bool flag;
			lock (this.items)
				flag = this.items.TryGetValue(key, out timerItem);
			if (!flag)
				return;
			timerItem.OnElapsed();
			key.Interval = timerItem.Interval;
			key.Start();
		}
	}
}
