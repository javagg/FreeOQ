// Type: OpenQuant.QuantBase.ImportWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared;
using SmartQuant.Data;
using SmartQuant.Instruments;
using SmartQuant.QuantBaseLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.QuantBase
{
  internal class ImportWindow : Form
  {
    private IQuantBaseConnection connection;
    private ImportSettings settings;
    private IContainer components;
    private Label lblInfo;
    private ProgressBar progressBar;
    private Button btnCancel;
    private BackgroundWorker worker;

    public ImportWindow()
    {
      this.InitializeComponent();
    }

    public void Init(IQuantBaseConnection connection, ImportSettings settings)
    {
      this.connection = connection;
      this.settings = settings;
    }

    protected override void OnShown(EventArgs e)
    {
      this.worker.RunWorkerAsync();
      base.OnShown(e);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.worker.IsBusy)
      {
        if (MessageBox.Show((IWin32Window) this, "Do you really want to cancel operation?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          this.worker.CancelAsync();
        e.Cancel = true;
      }
      base.OnFormClosing(e);
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      for (int index = 0; index < this.settings.Items.Count; ++index)
      {
        DataSeriesItem dataSeriesItem = this.settings.Items[index];
        this.worker.ReportProgress((index + 1) * 100 / this.settings.Items.Count, (object) string.Format("Importing {0} {1} ...", (object) dataSeriesItem.SH_Info.get_Symbol(), (object) dataSeriesItem.SH_Info.get_DataType()));
        if (InstrumentManager.Instruments[dataSeriesItem.SH_Info.get_Symbol()] == null)
        {
          if (this.settings.CreateNewInstruments)
            new SmartQuant.Instruments.Instrument(dataSeriesItem.SH_Info.get_Symbol(), APITypeConverter.InstrumentType.Convert(this.settings.InstrumentType)).Save();
          else
            continue;
        }
        IDataSeries dataSeries = DataManager.Server.GetDataSeries(dataSeriesItem.QB_Info.Name);
        if (dataSeries == null)
        {
          dataSeries = DataManager.Server.AddDataSeries(dataSeriesItem.QB_Info.Name);
        }
        else
        {
          switch (this.settings.ImportMode)
          {
            case ImportMode.Overwrite:
              dataSeries.Clear();
              break;
            case ImportMode.Skip:
              dataSeries = (IDataSeries) null;
              break;
          }
        }
        if (dataSeries != null)
        {
          IDataSeriesReader reader = this.connection.GetReader(new ReaderParameters()
          {
            SeriesName = dataSeriesItem.QB_Info.Name,
            From = this.settings.From,
            To = this.settings.To
          });
label_11:
          SmartQuant.Data.IDataObject[] dataObjectArray = reader.ReadNext(this.settings.BufferSize);
          if (dataObjectArray.Length > 0)
          {
            foreach (SmartQuant.Data.IDataObject dataObject in dataObjectArray)
              dataSeries.Add(dataObject.DateTime, (object) dataObject);
            goto label_11;
          }
          else
          {
            DataManager.Server.Flush();
            if (this.worker.CancellationPending)
            {
              e.Cancel = true;
              break;
            }
          }
        }
      }
    }

    private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.progressBar.Value = e.ProgressPercentage;
      this.lblInfo.Text = (string) e.UserState;
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.progressBar.Visible = false;
      this.btnCancel.Text = "Close";
      if (e.Cancelled)
        this.lblInfo.Text = "Cancelled.";
      else if (e.Error != null)
      {
        this.lblInfo.Text = "Error.";
        int num = (int) MessageBox.Show((IWin32Window) this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
        this.lblInfo.Text = "Completed.";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ImportWindow));
      this.lblInfo = new Label();
      this.progressBar = new ProgressBar();
      this.btnCancel = new Button();
      this.worker = new BackgroundWorker();
      this.SuspendLayout();
      this.lblInfo.Location = new Point(32, 32);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new Size(420, 22);
      this.lblInfo.TabIndex = 0;
      this.lblInfo.TextAlign = ContentAlignment.MiddleLeft;
      this.progressBar.Location = new Point(32, 64);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new Size(421, 26);
      this.progressBar.TabIndex = 1;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(189, 109);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(109, 24);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.worker.WorkerReportsProgress = true;
      this.worker.WorkerSupportsCancellation = true;
      this.worker.DoWork += new DoWorkEventHandler(this.worker_DoWork);
      this.worker.ProgressChanged += new ProgressChangedEventHandler(this.worker_ProgressChanged);
      this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(487, 153);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.progressBar);
      this.Controls.Add((Control) this.lblInfo);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ImportWindow";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import Series";
      this.ResumeLayout(false);
    }
  }
}
