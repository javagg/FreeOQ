using System;

namespace FreeQuant.Simulation
{
	public class Interval
	{
		public DateTime Begin { get; set; }
		public DateTime End { get; set; }

		public Interval(DateTime begin, DateTime end)
		{
			if (end < begin)
				throw new ArgumentException("end < begin");
			this.Begin = begin;
			this.End = end;
		}

		public Interval() : this(new DateTime(1900, 1, 1), new DateTime(2100, 1, 1))
		{
		}

		public override string ToString()
		{
			return "Interval";
		}
	}
}
