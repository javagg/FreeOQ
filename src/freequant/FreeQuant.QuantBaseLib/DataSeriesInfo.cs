using System;

namespace FreeQuant.QuantBaseLib
{
	[Serializable]
	public class DataSeriesInfo
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public int Count { get; set; }

		public DateTime? Begin { get; set; }

		public DateTime? End { get; set; }

		public DataSeriesInfo()
		{
			this.Name = string.Empty;
			this.Description = string.Empty;
			this.Count = 0;
			this.Begin = new DateTime?();
			this.End = new DateTime?();
		}
	}
}
