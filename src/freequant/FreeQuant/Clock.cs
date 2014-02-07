#region License
// Copyright (c) 2007 James Newton-King
#endregion

using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Timers;

namespace FreeQuant
{
	public class Clock
	{
//		private static DateTime now;
//		private static TimeSpan KLyrIGEWaU;
		private static SortedList reminders; 
		private static Timer timer;
//		private static bool JIyr9VlLXh;
//		private static EventHandler GW0rV1V0KZ;
//
		public static ClockMode ClockMode { get; set; }

		public static DateTime Now
		{
			get
			{
				return DateTime.Now;
			}
		}

		public static event EventHandler ClockModeChanged;

		static Clock()
		{
			Clock.ClockMode = ClockMode.Realtime;
////			Clock.now = DateTime.Now;
//			Clock.KLyrIGEWaU = TimeSpan.Zero;
			Clock.reminders = new SortedList();
//			Clock.JIyr9VlLXh = false;
			Clock.timer = new Timer();
			Clock.timer.Interval = 1.0;
			Clock.timer.AutoReset = false;
			Clock.timer.Elapsed += new ElapsedEventHandler(Clock.SRjrGO4qdD);
			Clock.timer.Start();
		}

		public static void SetDateTime(DateTime datetime)
		{
		}

		public static void AddReminder(ReminderEventHandler handler, DateTime datetime, object data)
		{
			Clock.reminders.Add(datetime, handler);
		}

		public static void RemoveReminder(ReminderEventHandler handler, DateTime datetime)
		{
			Clock.reminders.Remove(datetime);
		}
		
		public static void RemoveReminder(ReminderEventHandler handler)
		{
			Clock.reminders.RemoveAt(Clock.reminders.IndexOfValue(handler));
		}

		public static void FireAllReminders()
		{
//			foreach (var handler in Clock.reminders.Values)
//			{
//				handler(new ReminderEventArgs());
//			}
		}

		private static void SRjrGO4qdD(object sender, ElapsedEventArgs e)
		{
		}
	}
}
