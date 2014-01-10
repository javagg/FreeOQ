using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantBaseLib
{
	[Serializable]
	public class ReaderParameters
	{
		public string SeriesName { get; set; }

		public DateTime? From { get; set; }

		public DateTime? To { get; set; }

		public ReaderParameters()
		{
			this.SeriesName = string.Empty;
			this.From = new DateTime?();
			this.To = new DateTime?();
		}
	}
}
