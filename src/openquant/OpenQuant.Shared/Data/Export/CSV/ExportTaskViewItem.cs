using OpenQuant.Shared.Data;
using System;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Export.CSV
{
	internal class ExportTaskViewItem : ListViewItem
	{
		public ExportTask Task { get; private set; }

		public ExportTaskViewItem(ExportTask task) : base(new string[4])
		{
			this.Task = task;
			this.SubItems[0].Text = string.Format("{0} {1}", (object)DataSeriesHelper.GetDataSeriesInfo(task.DataSeries.Name).Symbol, (object)DataSeriesHelper.SeriesNameToString(task.DataSeries.Name));
			this.SubItems[1].Text = task.OutputFileName;
			this.UpdateState();
		}

		public void UpdateState()
		{
			this.SubItems[2].Text = ((object)this.Task.State).ToString();
			this.SubItems[3].Text = this.Task.Text;
			int num;
			switch (this.Task.State)
			{
				case ExportTaskState.Waiting:
					num = 0;
					break;
				case ExportTaskState.Exporting:
					num = 1;
					break;
				case ExportTaskState.Done:
					num = 2;
					break;
				case ExportTaskState.Error:
					num = 3;
					break;
				default:
					throw new ArgumentException(string.Format("Unknown task state - {0}", (object)this.Task.State));
			}
			this.ImageIndex = num;
		}
	}
}
