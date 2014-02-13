using OpenQuant.Shared.Data;
using FreeQuant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using IDataObject = FreeQuant.Data.IDataObject;

namespace OpenQuant.Shared.Data.Export.CSV
{
  public class DataSeriesExportForm : Form
  {
    private IContainer components;
    private FolderBrowserDialog dlgOutputFolder;
    private GroupBox gbxOutputDirectory;
    private Button btnOutputDirectory;
    private TextBox tbxOutputDirectory;
    private ListView ltvExportTasks;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ImageList imgDataSeries;
    private ColumnHeader columnHeader4;
    private GroupBox gbxProgress;
    private ProgressBar pgbTotal;
    private Label label1;
    private ProgressBar pgbCurrent;
    private Label lblCurrentProgress;
    private Button btnClose;
    private Button btnExport;
    private Button btnCancel;
    private GroupBox gbxRange;
    private RadioButton rbnAll;
    private RadioButton rbnRange;
    private DateTimePicker dtpRangeBegin;
    private DateTimePicker dtpRangeEnd;
    private Label label2;
    private Dictionary<ExportTask, ExportTaskViewItem> taskItems;
    private bool pendingCancel;

    public DataSeriesExportForm()
    {
      this.InitializeComponent();
      this.taskItems = new Dictionary<ExportTask, ExportTaskViewItem>();
      this.dtpRangeBegin.CustomFormat = this.dtpRangeEnd.CustomFormat = DateTimeFormatInfo.CurrentInfo.ShortDatePattern + " " + DateTimeFormatInfo.CurrentInfo.LongTimePattern;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DataSeriesExportForm));
      this.dlgOutputFolder = new FolderBrowserDialog();
      this.gbxOutputDirectory = new GroupBox();
      this.btnOutputDirectory = new Button();
      this.tbxOutputDirectory = new TextBox();
      this.ltvExportTasks = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.imgDataSeries = new ImageList(this.components);
      this.gbxProgress = new GroupBox();
      this.pgbTotal = new ProgressBar();
      this.label1 = new Label();
      this.pgbCurrent = new ProgressBar();
      this.lblCurrentProgress = new Label();
      this.btnClose = new Button();
      this.btnExport = new Button();
      this.btnCancel = new Button();
      this.gbxRange = new GroupBox();
      this.dtpRangeEnd = new DateTimePicker();
      this.label2 = new Label();
      this.dtpRangeBegin = new DateTimePicker();
      this.rbnRange = new RadioButton();
      this.rbnAll = new RadioButton();
      this.gbxOutputDirectory.SuspendLayout();
      this.gbxProgress.SuspendLayout();
      this.gbxRange.SuspendLayout();
      this.SuspendLayout();
      this.dlgOutputFolder.Description = "Please, select output directory for CSV data files.";
      this.gbxOutputDirectory.Controls.Add((Control) this.btnOutputDirectory);
      this.gbxOutputDirectory.Controls.Add((Control) this.tbxOutputDirectory);
      this.gbxOutputDirectory.Location = new Point(8, 8);
      this.gbxOutputDirectory.Name = "gbxOutputDirectory";
      this.gbxOutputDirectory.Size = new Size(578, 56);
      this.gbxOutputDirectory.TabIndex = 0;
      this.gbxOutputDirectory.TabStop = false;
      this.gbxOutputDirectory.Text = "Output directory";
      this.btnOutputDirectory.Location = new Point(488, 24);
      this.btnOutputDirectory.Name = "btnOutputDirectory";
      this.btnOutputDirectory.Size = new Size(71, 22);
      this.btnOutputDirectory.TabIndex = 1;
      this.btnOutputDirectory.Text = "Browse...";
      this.btnOutputDirectory.UseVisualStyleBackColor = true;
      this.btnOutputDirectory.Click += new EventHandler(this.btnOutputDirectory_Click);
      this.tbxOutputDirectory.BackColor = SystemColors.Window;
      this.tbxOutputDirectory.Location = new Point(16, 24);
      this.tbxOutputDirectory.Name = "tbxOutputDirectory";
      this.tbxOutputDirectory.ReadOnly = true;
      this.tbxOutputDirectory.Size = new Size(459, 20);
      this.tbxOutputDirectory.TabIndex = 0;
      this.ltvExportTasks.BorderStyle = BorderStyle.None;
      this.ltvExportTasks.Columns.AddRange(new ColumnHeader[4]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4
      });
      this.ltvExportTasks.FullRowSelect = true;
      this.ltvExportTasks.GridLines = true;
      this.ltvExportTasks.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvExportTasks.Location = new Point(8, 152);
      this.ltvExportTasks.MultiSelect = false;
      this.ltvExportTasks.Name = "ltvExportTasks";
      this.ltvExportTasks.ShowGroups = false;
      this.ltvExportTasks.ShowItemToolTips = true;
      this.ltvExportTasks.Size = new Size(578, 210);
      this.ltvExportTasks.SmallImageList = this.imgDataSeries;
      this.ltvExportTasks.TabIndex = 1;
      this.ltvExportTasks.UseCompatibleStateImageBehavior = false;
      this.ltvExportTasks.View = View.Details;
      this.columnHeader1.Text = "Data Series";
      this.columnHeader1.Width = 117;
      this.columnHeader2.Text = "Output File";
      this.columnHeader2.Width = 130;
      this.columnHeader3.Text = "State";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 97;
      this.columnHeader4.Text = "Text";
      this.columnHeader4.Width = 202;
      this.imgDataSeries.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgDataSeries.ImageStream");
      this.imgDataSeries.TransparentColor = Color.Transparent;
      this.imgDataSeries.Images.SetKeyName(0, "pending.png");
      this.imgDataSeries.Images.SetKeyName(1, "sending.png");
      this.imgDataSeries.Images.SetKeyName(2, "ok.png");
      this.imgDataSeries.Images.SetKeyName(3, "error.png");
      this.gbxProgress.Controls.Add((Control) this.pgbTotal);
      this.gbxProgress.Controls.Add((Control) this.label1);
      this.gbxProgress.Controls.Add((Control) this.pgbCurrent);
      this.gbxProgress.Controls.Add((Control) this.lblCurrentProgress);
      this.gbxProgress.Location = new Point(8, 368);
      this.gbxProgress.Name = "gbxProgress";
      this.gbxProgress.Size = new Size(578, 118);
      this.gbxProgress.TabIndex = 2;
      this.gbxProgress.TabStop = false;
      this.gbxProgress.Text = "Progress";
      this.pgbTotal.Location = new Point(16, 90);
      this.pgbTotal.Name = "pgbTotal";
      this.pgbTotal.Size = new Size(545, 20);
      this.pgbTotal.Step = 1;
      this.pgbTotal.TabIndex = 3;
      this.label1.Location = new Point(16, 68);
      this.label1.Name = "label1";
      this.label1.Size = new Size(545, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Total";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.pgbCurrent.Location = new Point(16, 44);
      this.pgbCurrent.Name = "pgbCurrent";
      this.pgbCurrent.Size = new Size(545, 20);
      this.pgbCurrent.TabIndex = 1;
      this.lblCurrentProgress.Location = new Point(16, 20);
      this.lblCurrentProgress.Name = "lblCurrentProgress";
      this.lblCurrentProgress.Size = new Size(545, 20);
      this.lblCurrentProgress.TabIndex = 0;
      this.lblCurrentProgress.Text = "current";
      this.lblCurrentProgress.TextAlign = ContentAlignment.MiddleLeft;
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(504, 494);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(75, 24);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnExport.Location = new Point(423, 494);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new Size(75, 24);
      this.btnExport.TabIndex = 4;
      this.btnExport.Text = "Export";
      this.btnExport.UseVisualStyleBackColor = true;
      this.btnExport.Click += new EventHandler(this.btnExport_Click);
      this.btnCancel.Location = new Point(305, 494);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 24);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Visible = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.gbxRange.Controls.Add((Control) this.dtpRangeEnd);
      this.gbxRange.Controls.Add((Control) this.label2);
      this.gbxRange.Controls.Add((Control) this.dtpRangeBegin);
      this.gbxRange.Controls.Add((Control) this.rbnRange);
      this.gbxRange.Controls.Add((Control) this.rbnAll);
      this.gbxRange.Location = new Point(8, 72);
      this.gbxRange.Name = "gbxRange";
      this.gbxRange.Size = new Size(578, 68);
      this.gbxRange.TabIndex = 6;
      this.gbxRange.TabStop = false;
      this.gbxRange.Text = "Export";
      this.dtpRangeEnd.Format = DateTimePickerFormat.Custom;
      this.dtpRangeEnd.Location = new Point(297, 42);
      this.dtpRangeEnd.Name = "dtpRangeEnd";
      this.dtpRangeEnd.Size = new Size(178, 20);
      this.dtpRangeEnd.TabIndex = 4;
      this.label2.Location = new Point(274, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(24, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "to";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.dtpRangeBegin.Format = DateTimePickerFormat.Custom;
      this.dtpRangeBegin.Location = new Point(90, 42);
      this.dtpRangeBegin.Name = "dtpRangeBegin";
      this.dtpRangeBegin.Size = new Size(178, 20);
      this.dtpRangeBegin.TabIndex = 2;
      this.rbnRange.Location = new Point(16, 40);
      this.rbnRange.Name = "rbnRange";
      this.rbnRange.Size = new Size(80, 20);
      this.rbnRange.TabIndex = 1;
      this.rbnRange.Text = "from";
      this.rbnRange.UseVisualStyleBackColor = true;
      this.rbnRange.CheckedChanged += new EventHandler(this.rbnRange_CheckedChanged);
      this.rbnAll.Checked = true;
      this.rbnAll.Location = new Point(16, 16);
      this.rbnAll.Name = "rbnAll";
      this.rbnAll.Size = new Size(80, 20);
      this.rbnAll.TabIndex = 0;
      this.rbnAll.TabStop = true;
      this.rbnAll.Text = "all objects";
      this.rbnAll.UseVisualStyleBackColor = true;
      this.rbnAll.CheckedChanged += new EventHandler(this.rbnAll_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(594, 525);
      this.Controls.Add((Control) this.gbxRange);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnExport);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.gbxProgress);
      this.Controls.Add((Control) this.ltvExportTasks);
      this.Controls.Add((Control) this.gbxOutputDirectory);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DataSeriesExportForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Export Data Series";
      this.gbxOutputDirectory.ResumeLayout(false);
      this.gbxOutputDirectory.PerformLayout();
      this.gbxProgress.ResumeLayout(false);
      this.gbxRange.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void Init(IDataSeries[] seriesList)
    {
      this.ltvExportTasks.BeginUpdate();
      this.ltvExportTasks.Items.Clear();
      foreach (IDataSeries dataSeries in seriesList)
      {
        string str = DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name).Symbol;
        foreach (char oldChar in Path.GetInvalidFileNameChars())
          str = str.Replace(oldChar, '_');
        string outputFileName = string.Format("{0}.{1}.csv", (object) str, (object) DataSeriesHelper.SeriesNameToString(dataSeries.Name));
        ExportTask exportTask = new ExportTask(dataSeries, outputFileName);
        ExportTaskViewItem exportTaskViewItem = new ExportTaskViewItem(exportTask);
        this.taskItems.Add(exportTask, exportTaskViewItem);
        this.ltvExportTasks.Items.Add((ListViewItem) exportTaskViewItem);
      }
      this.ltvExportTasks.EndUpdate();
      this.lblCurrentProgress.Text = "";
      this.pgbTotal.Maximum = seriesList.Length;
      List<DateTime> list = new List<DateTime>();
      foreach (IDataSeries idataSeries in seriesList)
      {
        if (idataSeries.Count > 0)
        {
          list.Add(idataSeries.FirstDateTime);
          list.Add(idataSeries.LastDateTime);
        }
      }
      if (list.Count == 0)
      {
        this.dtpRangeBegin.Value = DateTime.Today;
        this.dtpRangeEnd.Value = DateTime.Today;
      }
      else
      {
        this.dtpRangeBegin.Value = Enumerable.Min<DateTime>((IEnumerable<DateTime>) list).Date;
        this.dtpRangeEnd.Value = Enumerable.Max<DateTime>((IEnumerable<DateTime>) list).Date;
      }
      this.OnExportRangeChanged();
    }

    protected override void OnShown(EventArgs e)
    {
      this.BrowseOutputDirectory();
      base.OnShown(e);
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      if (!this.btnClose.Enabled)
        e.Cancel = true;
      base.OnClosing(e);
    }

    private void btnOutputDirectory_Click(object sender, EventArgs e)
    {
      this.BrowseOutputDirectory();
    }

    private void rbnAll_CheckedChanged(object sender, EventArgs e)
    {
      this.OnExportRangeChanged();
    }

    private void rbnRange_CheckedChanged(object sender, EventArgs e)
    {
      this.OnExportRangeChanged();
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.tbxOutputDirectory.Text.Trim()))
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, "Please, select output directory.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else if (this.rbnRange.Checked && this.dtpRangeBegin.Value > this.dtpRangeEnd.Value)
      {
        int num2 = (int) MessageBox.Show((IWin32Window) this, "Invalid datetime range", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        DirectoryInfo directory = new DirectoryInfo(this.tbxOutputDirectory.Text.Trim());
        if (directory.GetFiles().Length > 0 && MessageBox.Show((IWin32Window) this, string.Format("Output directory is not empty.{0}Existing files will be overridden.{0}Do you want to continue?", (object) Environment.NewLine), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
          return;
        this.gbxOutputDirectory.Enabled = false;
        this.gbxRange.Enabled = false;
        this.btnExport.Visible = false;
        this.btnClose.Enabled = false;
        this.btnCancel.Location = this.btnExport.Location;
        this.btnCancel.Visible = true;
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.DoExport), !this.rbnAll.Checked ? (object) new ExportSettings(directory, this.dtpRangeBegin.Value, this.dtpRangeEnd.Value) : (object) new ExportSettings(directory, DateTime.MinValue, DateTime.MaxValue));
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Are you sure to cancel the operation?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.pendingCancel = true;
    }

    private void BrowseOutputDirectory()
    {
      this.dlgOutputFolder.SelectedPath = this.tbxOutputDirectory.Text;
      if (this.dlgOutputFolder.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      this.tbxOutputDirectory.Text = this.dlgOutputFolder.SelectedPath;
    }

    private void DoExport(object objectState)
    {
      try
      {
        ExportSettings settings = (ExportSettings) objectState;
        foreach (ExportTask task in this.taskItems.Keys)
        {
          if (this.pendingCancel)
            break;
          this.DoExport(settings, task);
					this.Invoke((Action) (() => this.pgbTotal.PerformStep()));
        }
      }
      finally
      {
        this.SetButtonVisible(this.btnCancel, false);
        this.SetButtonEnabled(this.btnClose, true);
      }
    }

    private void DoExport(ExportSettings settings, ExportTask task)
    {
      try
      {
        IDataSeries dataSeries = task.DataSeries;
        FileInfo fileInfo = new FileInfo(string.Format("{0}\\{1}", (object) settings.Directory.FullName, (object) task.OutputFileName));
        DataType dataType = DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name).DataType;
        task.State = ExportTaskState.Exporting;
        this.UpdateTaskState(task);
        this.SetLabelText(this.lblCurrentProgress, string.Format("{0} {1} -> {2}", (object) DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name).Symbol, (object) DataSeriesHelper.SeriesNameToString(dataSeries.Name), (object) fileInfo.FullName));
        this.SetProgressValue(this.pgbCurrent, 0);
        Thread.Sleep(0);
        DataExporter dataExporter;
        switch (dataType)
        {
          case DataType.Trade:
            dataExporter = (DataExporter) new TradeExporter();
            break;
          case DataType.Quote:
            dataExporter = (DataExporter) new QuoteExporter();
            break;
          case DataType.Bar:
            dataExporter = (DataExporter) new BarExporter();
            break;
          case DataType.Daily:
            dataExporter = (DataExporter) new DailyExporter();
            break;
          default:
            throw new NotSupportedException(string.Format("Insupported data type - {0}", (object) dataType));
        }
        StreamWriter streamWriter = new StreamWriter(fileInfo.FullName);
        streamWriter.WriteLine(this.ToString(dataExporter.GetHeader()));
        int num1 = 0;
        int num2 = 0;
        for (int index = 0; index < dataSeries.Count; ++index)
        {
					IDataObject idataObject = dataSeries[index] as IDataObject;
          if (!this.pendingCancel)
          {
            DateTime dateTime = idataObject.DateTime;
            if (!(dateTime < settings.RangeBegin) && !(dateTime > settings.RangeEnd))
              streamWriter.WriteLine(this.ToString(dataExporter.DataObjectToString(idataObject)));
            ++num1;
            int num3 = (int) ((long) num1 * 100L / (long) dataSeries.Count);
            if (num3 > num2)
            {
              num2 = num3;
              this.SetProgressValue(this.pgbCurrent, num2);
            }
            Thread.Sleep(0);
          }
          else
            break;
        }
        streamWriter.Close();
        if (this.pendingCancel)
        {
          task.State = ExportTaskState.Error;
          task.Text = "Aborted";
        }
        else
        {
          task.State = ExportTaskState.Done;
          task.Text = "Completed";
        }
        this.UpdateTaskState(task);
      }
      catch (Exception ex)
      {
        task.State = ExportTaskState.Error;
        task.Text = ((object) ex).ToString();
        this.UpdateTaskState(task);
      }
    }

    private string ToString(string[] items)
    {
      return string.Join(",", items);
    }

    private void OnExportRangeChanged()
    {
      bool @checked = this.rbnAll.Checked;
      this.dtpRangeBegin.Enabled = !@checked;
      this.dtpRangeEnd.Enabled = !@checked;
    }

    private void SetButtonEnabled(Button button, bool enabled)
    {
			this.Invoke((Action) (() => button.Enabled = enabled));
    }

    private void SetButtonVisible(Button button, bool visible)
    {
			this.Invoke((Action) (() => button.Visible = visible));
    }

    private void UpdateTaskState(ExportTask task)
    {
			this.Invoke((Action) (() =>
      {
        ExportTaskViewItem local_0 = this.taskItems[task];
        local_0.UpdateState();
        local_0.EnsureVisible();
      }));
    }

    private void SetProgressValue(ProgressBar progressBar, int value)
    {
			this.Invoke((Action) (() => progressBar.Value = value));
    }

    private void SetLabelText(Label label, string text)
    {
			this.Invoke((Action) (() => label.Text = text));
    }
  }
}
