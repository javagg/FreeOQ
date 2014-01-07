// Type: SmartQuant.Business.Calendar
// Assembly: SmartQuant.Business, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 8728B172-6D66-401A-ACE9-1E591C9804EB
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Business.dll

using System;
using System.Runtime.CompilerServices;
using VQ9v10m5lBQXWUX1qW;

namespace SmartQuant.Business
{
  public class Calendar
  {
    private string TWSHHoPxu;
    private string fB6EhmAIl;
    private HolidayList Dapp2duWh;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TWSHHoPxu;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.TWSHHoPxu = value;
      }
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fB6EhmAIl;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fB6EhmAIl = value;
      }
    }

    public HolidayList Holidays
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Dapp2duWh;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Calendar()
    {
      daSFLBUgUxHG6jMMC5.S0BNF3rzWBODw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Calendar(string name, string description)
    {
      daSFLBUgUxHG6jMMC5.S0BNF3rzWBODw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.TWSHHoPxu = name;
      this.fB6EhmAIl = description;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Calendar(string name)
    {
      daSFLBUgUxHG6jMMC5.S0BNF3rzWBODw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.TWSHHoPxu = name;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init()
    {
      this.Dapp2duWh = new HolidayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddHoliday(Holiday holiday)
    {
      this.Dapp2duWh.Add(holiday);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddHoliday(DateTime date, string name, string description)
    {
      this.Dapp2duWh.Add(new Holiday(date, name, description));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddHoliday(DateTime date, string name)
    {
      this.Dapp2duWh.Add(new Holiday(date, name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Holiday GetHoliday(DateTime date)
    {
      return this.Dapp2duWh[date];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsWeekend(DateTime date)
    {
      return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsHoliday(DateTime date)
    {
      return !this.IsBusinessDay(date);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsBusinessDay(DateTime date)
    {
      return !Calendar.IsWeekend(date) && this.GetHoliday(date) == null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNBusinessDays(DateTime date1, DateTime date2)
    {
      int num = 0;
      for (DateTime date = date1; date <= date2; date = date.AddDays(1.0))
      {
        if (this.IsBusinessDay(date))
          ++num;
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetNWeekends(DateTime date1, DateTime date2)
    {
      int num = 0;
      for (DateTime date = date1; date <= date2; date = date.AddDays(1.0))
      {
        if (Calendar.IsWeekend(date))
          ++num;
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNHolidays(DateTime date1, DateTime date2)
    {
      int num = 0;
      for (DateTime date = date1; date <= date2; date = date.AddDays(1.0))
      {
        if (this.IsHoliday(date))
          ++num;
      }
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetNextBusinessDay(DateTime date)
    {
      do
      {
        date = date.AddDays(1.0);
      }
      while (!this.IsBusinessDay(date));
      return date;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DateTime GetNextWeekend(DateTime date)
    {
      do
      {
        date = date.AddDays(1.0);
      }
      while (!Calendar.IsWeekend(date));
      return date;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DateTime GetNextNonWeekend(DateTime date)
    {
      while (Calendar.IsWeekend(date))
        date = date.AddDays(1.0);
      return date;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DateTime GetPrevNonWeekend(DateTime date)
    {
      while (Calendar.IsWeekend(date))
        date = date.AddDays(-1.0);
      return date;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetNextHoliday(DateTime date)
    {
      do
      {
        date = date.AddDays(1.0);
      }
      while (!this.IsHoliday(date));
      return date;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetPrevBusinessDay(DateTime date)
    {
      do
      {
        date = date.AddDays(-1.0);
      }
      while (!this.IsBusinessDay(date));
      return date;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DateTime GetPrevWeekend(DateTime date)
    {
      do
      {
        date = date.AddDays(-1.0);
      }
      while (!Calendar.IsWeekend(date));
      return date;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetPrevHoliday(DateTime date)
    {
      do
      {
        date = date.AddDays(-1.0);
      }
      while (!this.IsHoliday(date));
      return date;
    }
  }
}
