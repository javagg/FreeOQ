using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.NxCoreLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class ImportForm : Form, IMessageReceiver
  {
    private IContainer components;
    private BackgroundWorker worker;
    private ListView ltvTasks;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ImageList imgTasks;
    private Button btnSkipCurrent;
    private Button btnStopOperation;
    private Button btnClose;
    private ColumnHeader columnHeader6;
    private ImportSettings settings;
    private List<TaskInfo> tasks;
    private Dictionary<string, Instrument> instruments;
    private Dictionary<TaskInfo, TaskInfoViewItem> taskViewItems;
    private TaskInfo currentTask;
    private TapeFile currentTape;
    private DataWriter currentWriter;
    private DateTime lastUpdateTime;
    private volatile bool currentSkipped;

    public ImportForm()
    {
      this.InitializeComponent();
      this.btnClose.Visible = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ImportForm));
      this.worker = new BackgroundWorker();
      this.ltvTasks = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.imgTasks = new ImageList(this.components);
      this.btnSkipCurrent = new Button();
      this.btnStopOperation = new Button();
      this.btnClose = new Button();
      this.columnHeader6 = new ColumnHeader();
      this.SuspendLayout();
      this.worker.WorkerSupportsCancellation = true;
      this.worker.DoWork += new DoWorkEventHandler(this.worker_DoWork);
      this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
      this.ltvTasks.Columns.AddRange(new ColumnHeader[6]
      {
        this.columnHeader1,
        this.columnHeader5,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader6
      });
      this.ltvTasks.FullRowSelect = true;
      this.ltvTasks.GridLines = true;
      this.ltvTasks.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvTasks.Location = new Point(12, 21);
      this.ltvTasks.Name = "ltvTasks";
      this.ltvTasks.ShowGroups = false;
      this.ltvTasks.ShowItemToolTips = true;
      this.ltvTasks.Size = new Size(639, 215);
      this.ltvTasks.SmallImageList = this.imgTasks;
      this.ltvTasks.TabIndex = 0;
      this.ltvTasks.UseCompatibleStateImageBehavior = false;
      this.ltvTasks.View = View.Details;
      this.columnHeader1.Text = "File";
      this.columnHeader1.Width = 120;
      this.columnHeader5.Text = "Size";
      this.columnHeader5.TextAlign = HorizontalAlignment.Right;
      this.columnHeader5.Width = 100;
      this.columnHeader2.Text = "Time Of Day";
      this.columnHeader2.TextAlign = HorizontalAlignment.Center;
      this.columnHeader2.Width = 100;
      this.columnHeader3.Text = "Trades";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 80;
      this.columnHeader4.Text = "Quotes";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 80;
      this.imgTasks.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgTasks.ImageStream");
      this.imgTasks.TransparentColor = Color.Transparent;
      this.imgTasks.Images.SetKeyName(0, "tapefile_wait.png");
      this.imgTasks.Images.SetKeyName(1, "tapefile_play.png");
      this.imgTasks.Images.SetKeyName(2, "tapefile_ok.png");
      this.imgTasks.Images.SetKeyName(3, "tapfile_error.png");
      this.imgTasks.Images.SetKeyName(4, "tapefile_skip.png");
      this.btnSkipCurrent.Location = new Point(209, 251);
      this.btnSkipCurrent.Name = "btnSkipCurrent";
      this.btnSkipCurrent.Size = new Size(114, 27);
      this.btnSkipCurrent.TabIndex = 1;
      this.btnSkipCurrent.Text = "Skip current file";
      this.btnSkipCurrent.UseVisualStyleBackColor = true;
      this.btnSkipCurrent.Click += new EventHandler(this.btnSkipCurrent_Click);
      this.btnStopOperation.Location = new Point(329, 251);
      this.btnStopOperation.Name = "btnStopOperation";
      this.btnStopOperation.Size = new Size(114, 27);
      this.btnStopOperation.TabIndex = 2;
      this.btnStopOperation.Text = "Stop operation";
      this.btnStopOperation.UseVisualStyleBackColor = true;
      this.btnStopOperation.Click += new EventHandler(this.btnStopOperation_Click);
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(548, 251);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(87, 27);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.columnHeader6.Text = "Processing Time";
      this.columnHeader6.TextAlign = HorizontalAlignment.Right;
      this.columnHeader6.Width = 110;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(663, 293);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnStopOperation);
      this.Controls.Add((Control) this.btnSkipCurrent);
      this.Controls.Add((Control) this.ltvTasks);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ImportForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import NxCore Tape File(s)";
      this.ResumeLayout(false);
    }

    public void Init(ImportSettings settings)
    {
      this.settings = settings;
      this.tasks = new List<TaskInfo>();
      foreach (string fileName in settings.TapeFiles)
        this.tasks.Add(new TaskInfo(new FileInfo(fileName)));
      this.instruments = new Dictionary<string, Instrument>();
      foreach (Instrument instrument in settings.Instruments)
        this.instruments.Add("e" + ((FIXInstrument) instrument).Symbol, instrument);
    }

    protected override void OnShown(EventArgs e)
    {
      this.taskViewItems = new Dictionary<TaskInfo, TaskInfoViewItem>();
      this.ltvTasks.BeginUpdate();
      this.ltvTasks.Items.Clear();
      foreach (TaskInfo taskInfo in this.tasks)
      {
        TaskInfoViewItem taskInfoViewItem = new TaskInfoViewItem(taskInfo);
        this.taskViewItems.Add(taskInfo, taskInfoViewItem);
        this.ltvTasks.Items.Add((ListViewItem) taskInfoViewItem);
      }
      this.ltvTasks.EndUpdate();
      this.lastUpdateTime = DateTime.Now;
      base.OnShown(e);
      this.worker.RunWorkerAsync();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.worker.IsBusy)
      {
        e.Cancel = true;
        int num = (int) MessageBox.Show((IWin32Window) this, "Operation is in progress", "Close", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      base.OnFormClosing(e);
    }

    private void btnSkipCurrent_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Do you really want to skip current file?", "Skip", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      TapeFile tapeFile = this.currentTape;
      if (tapeFile == null)
        return;
      this.currentSkipped = true;
      tapeFile.Stop();
    }

    private void btnStopOperation_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Do you really want to stop operation?", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      TapeFile tapeFile = this.currentTape;
      if (tapeFile != null)
      {
        this.currentSkipped = true;
        tapeFile.Stop();
      }
      this.worker.CancelAsync();
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      foreach (TaskInfo taskInfo in this.tasks)
      {
        TapeFile tapeFile = new TapeFile(taskInfo.File.FullName);
        this.currentTask = taskInfo;
        this.currentTape = tapeFile;
        PlaybackOptions playbackOptions = new PlaybackOptions();
				playbackOptions.Symbols = new List<string>((IEnumerable<string>) this.instruments.Keys).ToArray();
				playbackOptions.Trades = this.settings.Trades;
				playbackOptions.Quotes = this.settings.Quotes;
				playbackOptions.BeginTime = this.settings.From;
				playbackOptions.EndTime = this.settings.To;
        this.OnCurrentTaskBegin();
        if (this.worker.CancellationPending)
        {
          e.Cancel = true;
          this.OnCurrentTaskDone((Exception) null);
        }
        else
        {
          Exception error = (Exception) null;
          try
          {
            this.currentSkipped = false;
            this.currentWriter = !this.settings.Advanced.WriteDataAsync ? (DataWriter) new SyncDataWriter() : (DataWriter) new AsyncDataWriter(this.settings.Advanced.MaxBufferSize);
            this.currentWriter.BeginWrite();
            tapeFile.Play((IMessageReceiver) this, playbackOptions);
          }
          catch (Exception ex)
          {
            error = ex;
          }
          finally
          {
            try
            {
              this.currentWriter.EndWrite();
            }
            catch (Exception ex)
            {
              error = ex;
            }
            this.OnCurrentTaskDone(error);
          }
        }
      }
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.btnSkipCurrent.Visible = false;
      this.btnStopOperation.Visible = false;
      this.btnClose.Visible = true;
    }

    public void OnTrade(string symbol, DateTime datetime, double price, uint size)
    {
      this.currentWriter.Write(this.instruments[symbol], new Trade(datetime, price, (int) size));
      ++this.currentTask.TradeCount;
    }

    public void OnQuote(string symbol, DateTime datetime, double bidPrice, int bidSize, double askPrice, int askSize)
    {
      this.currentWriter.Write(this.instruments[symbol], new Quote(datetime, bidPrice, bidSize, askPrice, askSize));
      ++this.currentTask.QuoteCount;
    }

    public void OnStatus(DateTime datetime)
    {
      this.currentTask.DateTime = datetime;
      DateTime now = DateTime.Now;
      if ((now - this.lastUpdateTime).TotalSeconds < 1.0)
        return;
      this.lastUpdateTime = now;
      this.OnCurrentTaskUpdate();
    }

    private void OnCurrentTaskBegin()
    {
			this.Invoke((Action) (() => this.taskViewItems[this.currentTask].Begin()));
    }

    private void OnCurrentTaskUpdate()
    {
			this.Invoke((Action) (() => this.taskViewItems[this.currentTask].Update()));
    }

    private void OnCurrentTaskDone(Exception error)
    {
			this.Invoke((Action) (() =>
      {
        if (error != null)
        {
          this.taskViewItems[this.currentTask].Done(true, false);
          int temp_41 = (int) MessageBox.Show((IWin32Window) this, ((object) error).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          this.taskViewItems[this.currentTask].Done(false, this.currentSkipped);
      }));
    }
  }
}
