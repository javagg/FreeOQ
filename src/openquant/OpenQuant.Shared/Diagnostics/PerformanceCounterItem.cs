namespace OpenQuant.Shared.Diagnostics
{
	class PerformanceCounterItem
	{
		public long Count { get; set; }

		public long Average { get; set; }

		public long Peak { get; set; }

		public PerformanceCounterItem()
		{
			this.Reset();
		}

		public void Reset()
		{
			this.Count = 0;
			this.Average = 0;
			this.Peak = 0;
		}
	}
}
