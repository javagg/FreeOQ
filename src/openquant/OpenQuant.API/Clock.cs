using System;

namespace OpenQuant.API
{
	/// <summary>
	/// A system clock. The Clock.Now property shows simulation time 
	/// in the simulation mode and real time in the paper trading 
	/// or live trading modes. Thus it can be used in the same 
	/// way in all modes.
	/// </summary>
	public class Clock
	{
		/// <summary>
		/// Gets current system clock 
		/// </summary>
		public static DateTime Now
		{
			get
			{
				return FreeQuant.Clock.Now;
			}
		}

		/// <summary>
		/// Initializes a new instance of this class
		/// </summary>
		public Clock()
		{
		}
	}
}
