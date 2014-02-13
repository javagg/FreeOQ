using System;

namespace FreeQuant.NxCoreLib
{
	public class PlaybackOptions
	{
		public string[] Symbols { get; set; }

		public bool Trades { get; set; }

		public bool Quotes { get; set; }

		public TimeSpan? BeginTime { get; set; }

		public TimeSpan? EndTime { get; set; }

		public PlaybackOptions()
		{
			this.Symbols = (string[])null;
			this.Trades = true;
			this.Quotes = true;
			this.BeginTime = new TimeSpan?();
			this.EndTime = new TimeSpan?();
		}
	}
}
