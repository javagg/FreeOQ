using OpenQuant.Shared.Data;
using OpenQuant.Shared.Instruments;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.TAQ
{
  public class TAQImportForm : Form
  {
    private string[] symbols;
    private Label label1;
    private TextBox tbxDataFile;
    private Button btnBrowseDataFile;
    private RadioButton rbnVersion2;
    private RadioButton rbnVersion1;
    private TextBox tbxIndexFile;
    private Label label2;
    private GroupBox groupBox3;
    private ProgressBar progressBar;
    private RadioButton rbnQuotes;
    private RadioButton rbnTrades;
    private Button btnImport;
    private Button btnStop;
    private Button btnClose;
    private GroupBox gbxDataFormat;
    private GroupBox gbxDataType;
    private GroupBox gbxImport;
    private RadioButton rbnAll;
    private RadioButton rbnExistents;
    private RadioButton rbnCustom;
    private Button btnSelect;
        private IContainer components = null;

    public TAQImportForm()
    {
      this.InitializeComponent();
      this.symbols = new string[0];
      Importer.Stopped += new EventHandler(this.OnStopped);
      Importer.Progress += new EventHandler(this.OnProgress);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      if (this.btnClose.Enabled)
      {
        Importer.Stopped -= new EventHandler(this.OnStopped);
        Importer.Progress -= new EventHandler(this.OnProgress);
        Importer.Dispose();
      }
      else
        e.Cancel = true;
      base.OnClosing(e);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.tbxDataFile = new TextBox();
      this.btnBrowseDataFile = new Button();
      this.gbxDataFormat = new GroupBox();
      this.rbnVersion2 = new RadioButton();
      this.rbnVersion1 = new RadioButton();
      this.tbxIndexFile = new TextBox();
      this.label2 = new Label();
      this.groupBox3 = new GroupBox();
      this.progressBar = new ProgressBar();
      this.gbxDataType = new GroupBox();
      this.rbnQuotes = new RadioButton();
      this.rbnTrades = new RadioButton();
      this.btnImport = new Button();
      this.btnStop = new Button();
      this.btnClose = new Button();
      this.gbxImport = new GroupBox();
      this.btnSelect = new Button();
      this.rbnCustom = new RadioButton();
      this.rbnExistents = new RadioButton();
      this.rbnAll = new RadioButton();
      this.gbxDataFormat.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.gbxDataType.SuspendLayout();
      this.gbxImport.SuspendLayout();
      this.SuspendLayout();
      this.label1.Location = new Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(80, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "TAQ data file";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.tbxDataFile.Location = new Point(104, 16);
      this.tbxDataFile.Name = "tbxDataFile";
      this.tbxDataFile.ReadOnly = true;
      this.tbxDataFile.Size = new Size(272, 20);
      this.tbxDataFile.TabIndex = 2;
      this.btnBrowseDataFile.Location = new Point(392, 16);
      this.btnBrowseDataFile.Name = "btnBrowseDataFile";
      this.btnBrowseDataFile.Size = new Size(64, 22);
      this.btnBrowseDataFile.TabIndex = 4;
      this.btnBrowseDataFile.Text = "Browse ...";
      this.btnBrowseDataFile.Click += new EventHandler(this.btnBrowseDataFile_Click);
      this.gbxDataFormat.Controls.Add((Control) this.rbnVersion2);
      this.gbxDataFormat.Controls.Add((Control) this.rbnVersion1);
      this.gbxDataFormat.Location = new Point(240, 72);
      this.gbxDataFormat.Name = "gbxDataFormat";
      this.gbxDataFormat.Size = new Size(216, 80);
      this.gbxDataFormat.TabIndex = 7;
      this.gbxDataFormat.TabStop = false;
      this.gbxDataFormat.Text = "Data format";
      this.rbnVersion2.Location = new Point(16, 48);
      this.rbnVersion2.Name = "rbnVersion2";
      this.rbnVersion2.Size = new Size(56, 16);
      this.rbnVersion2.TabIndex = 1;
      this.rbnVersion2.Text = "TAQ2";
      this.rbnVersion1.Checked = true;
      this.rbnVersion1.Location = new Point(16, 24);
      this.rbnVersion1.Name = "rbnVersion1";
      this.rbnVersion1.Size = new Size(48, 16);
      this.rbnVersion1.TabIndex = 0;
      this.rbnVersion1.TabStop = true;
      this.rbnVersion1.Text = "TAQ";
      this.tbxIndexFile.Location = new Point(104, 40);
      this.tbxIndexFile.Name = "tbxIndexFile";
      this.tbxIndexFile.ReadOnly = true;
      this.tbxIndexFile.Size = new Size(272, 20);
      this.tbxIndexFile.TabIndex = 10;
      this.label2.Location = new Point(16, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(80, 16);
      this.label2.TabIndex = 11;
      this.label2.Text = "TAQ index file";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.groupBox3.Controls.Add((Control) this.progressBar);
      this.groupBox3.Location = new Point(8, 280);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(456, 48);
      this.groupBox3.TabIndex = 14;
      this.groupBox3.TabStop = false;
      this.progressBar.Location = new Point(8, 16);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new Size(440, 20);
      this.progressBar.TabIndex = 0;
      this.gbxDataType.Controls.Add((Control) this.rbnQuotes);
      this.gbxDataType.Controls.Add((Control) this.rbnTrades);
      this.gbxDataType.Location = new Point(16, 72);
      this.gbxDataType.Name = "gbxDataType";
      this.gbxDataType.Size = new Size(208, 80);
      this.gbxDataType.TabIndex = 15;
      this.gbxDataType.TabStop = false;
      this.gbxDataType.Text = "Data type";
      this.rbnQuotes.Checked = true;
      this.rbnQuotes.Location = new Point(16, 24);
      this.rbnQuotes.Name = "rbnQuotes";
      this.rbnQuotes.Size = new Size(64, 16);
      this.rbnQuotes.TabIndex = 1;
      this.rbnQuotes.TabStop = true;
      this.rbnQuotes.Text = "quotes";
      this.rbnTrades.Location = new Point(16, 48);
      this.rbnTrades.Name = "rbnTrades";
      this.rbnTrades.Size = new Size(64, 16);
      this.rbnTrades.TabIndex = 0;
      this.rbnTrades.Text = "trades";
      this.btnImport.Enabled = false;
      this.btnImport.Location = new Point(160, 340);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new Size(72, 22);
      this.btnImport.TabIndex = 16;
      this.btnImport.Text = "Import";
      this.btnImport.Click += new EventHandler(this.btnImport_Click);
      this.btnStop.Enabled = false;
      this.btnStop.Location = new Point(240, 340);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new Size(72, 22);
      this.btnStop.TabIndex = 17;
      this.btnStop.Text = "Stop";
      this.btnStop.Click += new EventHandler(this.btnStop_Click);
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(384, 340);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(72, 22);
      this.btnClose.TabIndex = 18;
      this.btnClose.Text = "Close";
      this.gbxImport.Controls.Add((Control) this.btnSelect);
      this.gbxImport.Controls.Add((Control) this.rbnCustom);
      this.gbxImport.Controls.Add((Control) this.rbnExistents);
      this.gbxImport.Controls.Add((Control) this.rbnAll);
      this.gbxImport.Location = new Point(16, 160);
      this.gbxImport.Name = "gbxImport";
      this.gbxImport.Size = new Size(440, 104);
      this.gbxImport.TabIndex = 20;
      this.gbxImport.TabStop = false;
      this.gbxImport.Text = "Import";
      this.btnSelect.AutoSize = true;
      this.btnSelect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btnSelect.Enabled = false;
      this.btnSelect.Location = new Point(160, 68);
      this.btnSelect.Name = "btnSelect";
      this.btnSelect.Size = new Size(56, 23);
      this.btnSelect.TabIndex = 3;
      this.btnSelect.Text = "Select...";
      this.btnSelect.Click += new EventHandler(this.btnSelect_Click);
      this.rbnCustom.Location = new Point(16, 72);
      this.rbnCustom.Name = "rbnCustom";
      this.rbnCustom.Size = new Size(136, 16);
      this.rbnCustom.TabIndex = 2;
      this.rbnCustom.Text = "custom";
      this.rbnCustom.CheckedChanged += new EventHandler(this.rbnCustom_CheckedChanged);
      this.rbnExistents.Checked = true;
      this.rbnExistents.Location = new Point(16, 48);
      this.rbnExistents.Name = "rbnExistents";
      this.rbnExistents.Size = new Size(136, 16);
      this.rbnExistents.TabIndex = 1;
      this.rbnExistents.TabStop = true;
      this.rbnExistents.Text = "existent symbols only";
      this.rbnExistents.CheckedChanged += new EventHandler(this.rbnExistents_CheckedChanged);
      this.rbnAll.Location = new Point(16, 24);
      this.rbnAll.Name = "rbnAll";
      this.rbnAll.Size = new Size(136, 16);
      this.rbnAll.TabIndex = 0;
      this.rbnAll.Text = "all symbols";
      this.rbnAll.CheckedChanged += new EventHandler(this.rbnAll_CheckedChanged);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(474, 375);
      this.Controls.Add((Control) this.gbxImport);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnStop);
      this.Controls.Add((Control) this.btnImport);
      this.Controls.Add((Control) this.gbxDataType);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.tbxIndexFile);
      this.Controls.Add((Control) this.tbxDataFile);
      this.Controls.Add((Control) this.gbxDataFormat);
      this.Controls.Add((Control) this.btnBrowseDataFile);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TAQImportForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import Data From The TAQ CDs";
      this.gbxDataFormat.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.gbxDataType.ResumeLayout(false);
      this.gbxImport.ResumeLayout(false);
      this.gbxImport.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void btnBrowseDataFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Multiselect = false;
      openFileDialog.Filter = "TAQ data files(*.bin)|*.bin";
      if (this.tbxDataFile.Text != "")
        openFileDialog.FileName = this.tbxDataFile.Text;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        string fileName = openFileDialog.FileName;
        this.tbxDataFile.Text = fileName;
        this.tbxIndexFile.Text = fileName.Substring(0, fileName.LastIndexOf(".")) + ".IDX";
      }
      this.UpdateImportButtonStatus();
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      this.Import();
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      Importer.Stop();
    }

    private void rbnAll_CheckedChanged(object sender, EventArgs e)
    {
      this.UpdateSelectButtonStatus();
    }

    private void rbnExistents_CheckedChanged(object sender, EventArgs e)
    {
      this.UpdateSelectButtonStatus();
    }

    private void rbnCustom_CheckedChanged(object sender, EventArgs e)
    {
      this.UpdateSelectButtonStatus();
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
      InstrumentSelectorDialog instrumentSelectorDialog = new InstrumentSelectorDialog();
      List<Instrument> list1 = new List<Instrument>();
      foreach (string str in this.symbols)
				list1.Add(InstrumentManager.Instruments[str]);
	  instrumentSelectorDialog.Instruments = InstrumentManager.Instruments;
      instrumentSelectorDialog.SelectedInstruments = list1.ToArray();
      if (instrumentSelectorDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        List<string> list2 = new List<string>();
        foreach (Instrument instrument in instrumentSelectorDialog.SelectedInstruments)
          list2.Add(((FIXInstrument) instrument).Symbol);
        this.symbols = list2.ToArray();
      }
      instrumentSelectorDialog.Dispose();
      this.btnSelect.Text = string.Format("{0} symbol(s) selected...", (object) this.symbols.Length);
    }

    private void OnStopped(object sender, EventArgs e)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EventHandler(this.OnStopped), sender, (object) e);
      else
        this.SetEnabled(true);
    }

    private void OnProgress(object sender, EventArgs e)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EventHandler(this.OnProgress), sender, (object) e);
      else
        this.progressBar.Value = Importer.PercentDone;
    }

    private void UpdateImportButtonStatus()
    {
      this.btnImport.Enabled = this.tbxDataFile.Text != "";
    }

    private void UpdateSelectButtonStatus()
    {
      this.btnSelect.Enabled = this.rbnCustom.Checked;
    }

    private void SetEnabled(bool enabled)
    {
      this.btnBrowseDataFile.Enabled = enabled;
      this.gbxDataType.Enabled = enabled;
      this.gbxDataFormat.Enabled = enabled;
      this.gbxImport.Enabled = enabled;
      this.btnImport.Enabled = enabled;
      this.btnStop.Enabled = !enabled;
      this.btnClose.Enabled = enabled;
    }

    private void Import()
    {
      this.progressBar.Value = 0;
      this.SetEnabled(false);
      Importer.SetSettings(this.PrepareSettings());
      Importer.Start();
    }

    private ImportSettings PrepareSettings()
    {
      ImportSettings importSettings = new ImportSettings();
      importSettings.TAQDataFile = new FileInfo(this.tbxDataFile.Text);
      importSettings.TAQIndexFile = new FileInfo(this.tbxIndexFile.Text);
      if (this.rbnVersion1.Checked)
        importSettings.DataFormatVersion = DataFormatVersion.Version1;
      if (this.rbnVersion2.Checked)
        importSettings.DataFormatVersion = DataFormatVersion.Version2;
      if (this.rbnQuotes.Checked)
        importSettings.DataType = DataType.Quote;
      if (this.rbnTrades.Checked)
        importSettings.DataType = DataType.Trade;
      if (this.rbnAll.Checked)
        importSettings.SymbolOption = SymbolOption.All;
      if (this.rbnExistents.Checked)
        importSettings.SymbolOption = SymbolOption.Existents;
      if (this.rbnCustom.Checked)
        importSettings.SymbolOption = SymbolOption.Custom;
      importSettings.Symbols = this.symbols;
      return importSettings;
    }
  }
}
