using System;

namespace OpenQuant.API
{
	public class Clock
	{
		public static DateTime Now {
			get {
				return FreeQuant.Clock.Now;
			}
		}
	}
}
