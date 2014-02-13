using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Export.CSV
{
	class ExportTask
	{
		public IDataSeries DataSeries { get; private set; }

		public string OutputFileName { get; private set; }

		public ExportTaskState State { get; set; }

		public string Text { get; set; }

		public ExportTask(IDataSeries dataSeries, string outputFileName)
		{
			this.DataSeries = dataSeries;
			this.OutputFileName = outputFileName;
			this.State = ExportTaskState.Waiting;
			this.Text = string.Empty;
		}
	}
}
