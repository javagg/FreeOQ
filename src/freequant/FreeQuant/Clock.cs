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
	public enum ClockMode { Realtime, Simulation }

	public class Clock
	{
		private static DateTime now;
		private static TimeSpan KLyrIGEWaU;
		private static SortedList PQDrlFHKP0;
		private static Timer timer;
		private static bool JIyr9VlLXh;
		private static EventHandler GW0rV1V0KZ;

		public static ClockMode ClockMode {	get; set; }
		public static DateTime Now
		{
			get
			{
				return now;
			}
		}

		public static event EventHandler ClockModeChanged
		{
			 add
			{
			}
			 remove
			{
			}
		}

		static Clock()
		{
			Clock.ClockMode = ClockMode.Realtime;
			Clock.now = DateTime.Now;
			Clock.KLyrIGEWaU = TimeSpan.Zero;
			Clock.PQDrlFHKP0 = new SortedList();
			Clock.JIyr9VlLXh = false;
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
		}

		public static void RemoveReminder(ReminderEventHandler handler, DateTime datetime)
		{
		}

		
		public static void RemoveReminder(ReminderEventHandler handler)
		{
		}

		
		public static void FireAllReminders()
		{
		}
	}
}
