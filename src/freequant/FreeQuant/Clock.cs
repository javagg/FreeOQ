using aPqI2kmeVjWsoIHqc3F;
using BoBSVVX0yGpEOB0Qj2;
using oZ1IlQmSDifdcZke9oZ;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;

namespace FreeQuant
{
	public enum ClockMode {	Realtime, Simulation }

  public class Clock
  {
    private static ClockMode zYbrCXBXY2;
    private static DateTime V43r8pGmVV;
    private static TimeSpan KLyrIGEWaU;
    private static SortedList PQDrlFHKP0;

		private static Timer timer;
	
    private static bool JIyr9VlLXh;
    private static EventHandler GW0rV1V0KZ;

    public static ClockMode ClockMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return \u003CPrivateImplementationDetails\u003E\u007BBC86C0EF\u002D576E\u002D453D\u002D8BFD\u002DFAB33B893C15\u007D.fieldimpl12;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
      }
    }

    public static DateTime Now
    {
    get
      {
        return \u003CPrivateImplementationDetails\u003E\u007BBC86C0EF\u002D576E\u002D453D\u002D8BFD\u002DFAB33B893C15\u007D.fieldimpl2;
      }
    }

    public static event EventHandler ClockModeChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add
      {
      }
      [MethodImpl(MethodImplOptions.NoInlining)] remove
      {
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Clock()
    {
      GItcYDqSxj5aE60JeS.GRAroVBQNR();
      U11BeMmYvqFIQ38CeV7.y89NYTfzAIJ6Q();
      Clock.zYbrCXBXY2 = ClockMode.Realtime;
      Clock.V43r8pGmVV = DateTime.Now;
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveReminder(ReminderEventHandler handler)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FireAllReminders()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void w9brTOhgdW([In] ArrayList obj0, [In] ReminderEventHandler obj1)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UoLrWKXhTR([In] DateTime obj0)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SRjrGO4qdD([In] object obj0, [In] ElapsedEventArgs obj1)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void N1ur0QBmvI()
    {
    }
  }
}
