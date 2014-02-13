namespace OpenQuant.Shared.Data.Bars
{
	class CompressorTaskItem
	{
		public CompressorTask Task { get; private set; }

		public string Title
		{
			get
			{
				return string.Format("{0} ({1} -> {2})", this.Task.Instrument, this.Task.DataSource, this.Task.BarTypeSize);
			}
		}

		public CompressorTaskStatus Status  { get; set; }

		public CompressorTaskResult Result  { get; set; }

		public string Message { get; set; }

		public CompressorTaskItem(CompressorTask task)
		{
			this.Task = task;
			this.Status = CompressorTaskStatus.Pending;
			this.Result = CompressorTaskResult.None;
			this.Message = string.Empty;
		}
	}
}
