using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
  public class Interval
  {
    private DateTime a9ymD86i6;
    private DateTime uwkfK3F1e;

    public DateTime Begin
    {
      get
      {
        return this.a9ymD86i6;
      }
      set
      {
        this.a9ymD86i6 = value;
      }
    }

    public DateTime End
    {
      get
      {
        return this.uwkfK3F1e;
      }
      set
      {
        this.uwkfK3F1e = value;
      }
    }

   
    public Interval(DateTime begin, DateTime end)
    {
      if (end < begin)
				throw new ArgumentException("end < begin");
      this.a9ymD86i6 = begin;
      this.uwkfK3F1e = end;
    }

   
		public Interval(): this(new DateTime(1900, 1, 1), new DateTime(2100, 1, 1))
    {
    }

   
    public override string ToString()
    {
		return "Interval";
    }
  }
}
