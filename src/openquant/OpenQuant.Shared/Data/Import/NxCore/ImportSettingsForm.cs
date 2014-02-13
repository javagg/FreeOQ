using OpenQuant.Shared.Instruments;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class ImportSettingsForm : Form
  {
    private ImportSettings settings;
    private IContainer components;
    private GroupBox groupBox1;
    private Button btnTapeFile_Remove;
    private Button btnTapeFile_Add;
    private ListBox lbxTapeFiles;
    private OpenFileDialog dlgOpenTapeFile;
    private GroupBox groupBox2;
    private Button btnInstruments_Select;
    private ListView ltvInstruments;
    private ImageList imgInstruments;
    private Button btnImport;
    private Button btnCancel;
    private GroupBox groupBox5;
    private Button btnAdvanced;
    private DateTimePicker dtpTo;
    private DateTimePicker dtpFrom;
    private Label label2;
    private Label label1;
    private Label label4;
    private Label label3;
    private CheckBox chbQuotes;
    private CheckBox chbTrades;

    private string[] TapeFiles
    {
      get
      {
        List<string> list = new List<string>();
        foreach (object obj in this.lbxTapeFiles.Items)
          list.Add((string) obj);
        return list.ToArray();
      }
      set
      {
        this.lbxTapeFiles.BeginUpdate();
        this.lbxTapeFiles.Items.Clear();
        this.lbxTapeFiles.Items.AddRange((object[]) value);
        this.lbxTapeFiles.EndUpdate();
      }
    }

    private Instrument[] Instruments
    {
      get
      {
        List<Instrument> list = new List<Instrument>();
        foreach (ListViewItem listViewItem in this.ltvInstruments.Items)
          list.Add((Instrument) listViewItem.Tag);
        return list.ToArray();
      }
      set
      {
        this.ltvInstruments.BeginUpdate();
        this.ltvInstruments.Items.Clear();
        foreach (Instrument instrument in value)
          this.ltvInstruments.Items.Add(new ListViewItem()
          {
            Text = ((FIXInstrument) instrument).Symbol,
            Tag = (object) instrument,
            ImageIndex = 0
          });
        this.ltvInstruments.EndUpdate();
      }
    }

    private bool Trades
    {
      get
      {
        return this.chbTrades.Checked;
      }
      set
      {
        this.chbTrades.Checked = value;
      }
    }

    private bool Quotes
    {
      get
      {
        return this.chbQuotes.Checked;
      }
      set
      {
        this.chbQuotes.Checked = value;
      }
    }

    private TimeSpan? From
    {
      get
      {
        if (!this.dtpFrom.Checked)
          return new TimeSpan?();
        else
          return new TimeSpan?(this.dtpFrom.Value.TimeOfDay);
      }
      set
      {
        if (!value.HasValue)
        {
          this.dtpFrom.Checked = false;
        }
        else
        {
          this.dtpFrom.Checked = true;
          this.dtpFrom.Value = DateTime.Today.Add(value.Value);
        }
      }
    }

    private TimeSpan? To
    {
      get
      {
        if (!this.dtpTo.Checked)
          return new TimeSpan?();
        else
          return new TimeSpan?(this.dtpTo.Value.TimeOfDay);
      }
      set
      {
        if (!value.HasValue)
        {
          this.dtpTo.Checked = false;
        }
        else
        {
          this.dtpTo.Checked = true;
          this.dtpTo.Value = DateTime.Today.Add(value.Value);
        }
      }
    }

    public ImportSettingsForm()
    {
      this.InitializeComponent();
    }

    public void Init(ImportSettings settings)
    {
      this.settings = settings;
    }

    protected override void OnShown(EventArgs e)
    {
      this.TapeFiles = this.settings.TapeFiles;
      this.Instruments = this.settings.Instruments;
      this.Trades = this.settings.Trades;
      this.Quotes = this.settings.Quotes;
      this.From = this.settings.From;
      this.To = this.settings.To;
      base.OnShown(e);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK)
      {
        this.settings.TapeFiles = this.TapeFiles;
        this.settings.Instruments = this.Instruments;
        this.settings.Trades = this.Trades;
        this.settings.Quotes = this.Quotes;
        this.settings.From = this.From;
        this.settings.To = this.To;
      }
      base.OnFormClosing(e);
    }

    private void btnTapeFile_Add_Click(object sender, EventArgs e)
    {
      if (this.dlgOpenTapeFile.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      List<string> list = new List<string>((IEnumerable<string>) this.TapeFiles);
      foreach (string str in this.dlgOpenTapeFile.FileNames)
      {
        if (!list.Contains(str))
          list.Add(str);
      }
      this.TapeFiles = list.ToArray();
    }

    private void btnTapeFile_Remove_Click(object sender, EventArgs e)
    {
      if (this.lbxTapeFiles.SelectedItems.Count <= 0)
        return;
      List<string> list = new List<string>((IEnumerable<string>) this.TapeFiles);
      foreach (string str in this.lbxTapeFiles.SelectedItems)
        list.Remove(str);
      this.TapeFiles = list.ToArray();
    }

    private void btnInstruments_Select_Click(object sender, EventArgs e)
    {
      InstrumentSelectorDialog instrumentSelectorDialog = new InstrumentSelectorDialog();
      instrumentSelectorDialog.Instruments = InstrumentManager.Instruments;
      instrumentSelectorDialog.SelectedInstruments = this.Instruments;
      if (instrumentSelectorDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
        this.Instruments = instrumentSelectorDialog.SelectedInstruments;
      instrumentSelectorDialog.Dispose();
    }

    private void btnAdvanced_Click(object sender, EventArgs e)
    {
      AdvancedImportSettingsForm importSettingsForm = new AdvancedImportSettingsForm();
      importSettingsForm.Init(this.settings.Advanced);
      int num = (int) importSettingsForm.ShowDialog((IWin32Window) this);
      importSettingsForm.Dispose();
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      List<string> list = new List<string>();
      if (this.TapeFiles.Length == 0)
        list.Add("Please, add tape file(s).");
      if (this.Instruments.Length == 0)
        list.Add("Please, select instrument(s).");
      if (!this.Trades && !this.Quotes)
        list.Add("Please, select 'trade' and/or 'quote' data type.");
      if (this.From.HasValue && this.To.HasValue)
      {
        TimeSpan? from = this.From;
        TimeSpan? to = this.To;
        if ((from.HasValue & to.HasValue ? (from.GetValueOrDefault() >= to.GetValueOrDefault() ? 1 : 0) : 0) != 0)
          list.Add("Invalid time interval - 'from' should be less than 'to'.");
      }
      if (list.Count == 0)
      {
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        int num = (int) MessageBox.Show((IWin32Window) this, string.Join(Environment.NewLine, (IEnumerable<string>) list), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ImportSettingsForm));
      this.groupBox1 = new GroupBox();
      this.btnTapeFile_Remove = new Button();
      this.btnTapeFile_Add = new Button();
      this.lbxTapeFiles = new ListBox();
      this.dlgOpenTapeFile = new OpenFileDialog();
      this.groupBox2 = new GroupBox();
      this.btnInstruments_Select = new Button();
      this.ltvInstruments = new ListView();
      this.imgInstruments = new ImageList(this.components);
      this.btnImport = new Button();
      this.btnCancel = new Button();
      this.groupBox5 = new GroupBox();
      this.chbTrades = new CheckBox();
      this.chbQuotes = new CheckBox();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label1 = new Label();
      this.label2 = new Label();
      this.dtpFrom = new DateTimePicker();
      this.dtpTo = new DateTimePicker();
      this.btnAdvanced = new Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.btnTapeFile_Remove);
      this.groupBox1.Controls.Add((Control) this.btnTapeFile_Add);
      this.groupBox1.Controls.Add((Control) this.lbxTapeFiles);
      this.groupBox1.Location = new Point(8, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(460, 156);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tape Files";
      this.btnTapeFile_Remove.Location = new Point(384, 50);
      this.btnTapeFile_Remove.Name = "btnTapeFile_Remove";
      this.btnTapeFile_Remove.Size = new Size(64, 24);
      this.btnTapeFile_Remove.TabIndex = 2;
      this.btnTapeFile_Remove.Text = "Remove";
      this.btnTapeFile_Remove.UseVisualStyleBackColor = true;
      this.btnTapeFile_Remove.Click += new EventHandler(this.btnTapeFile_Remove_Click);
      this.btnTapeFile_Add.Location = new Point(384, 20);
      this.btnTapeFile_Add.Name = "btnTapeFile_Add";
      this.btnTapeFile_Add.Size = new Size(64, 24);
      this.btnTapeFile_Add.TabIndex = 1;
      this.btnTapeFile_Add.Text = "Add...";
      this.btnTapeFile_Add.UseVisualStyleBackColor = true;
      this.btnTapeFile_Add.Click += new EventHandler(this.btnTapeFile_Add_Click);
      this.lbxTapeFiles.FormattingEnabled = true;
      this.lbxTapeFiles.Location = new Point(16, 20);
      this.lbxTapeFiles.Name = "lbxTapeFiles";
      this.lbxTapeFiles.SelectionMode = SelectionMode.MultiExtended;
      this.lbxTapeFiles.Size = new Size(360, 121);
      this.lbxTapeFiles.Sorted = true;
      this.lbxTapeFiles.TabIndex = 0;
      this.dlgOpenTapeFile.Filter = "NxCore Tape Files|*.nxc|All Files|*.*";
      this.dlgOpenTapeFile.Multiselect = true;
      this.dlgOpenTapeFile.Title = "Select NxCore Tape File(s)";
      this.groupBox2.Controls.Add((Control) this.btnInstruments_Select);
      this.groupBox2.Controls.Add((Control) this.ltvInstruments);
      this.groupBox2.Location = new Point(8, 176);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(460, 168);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Instruments";
      this.btnInstruments_Select.Location = new Point(384, 20);
      this.btnInstruments_Select.Name = "btnInstruments_Select";
      this.btnInstruments_Select.Size = new Size(64, 24);
      this.btnInstruments_Select.TabIndex = 2;
      this.btnInstruments_Select.Text = "Select...";
      this.btnInstruments_Select.UseVisualStyleBackColor = true;
      this.btnInstruments_Select.Click += new EventHandler(this.btnInstruments_Select_Click);
      this.ltvInstruments.LabelWrap = false;
      this.ltvInstruments.Location = new Point(16, 20);
      this.ltvInstruments.MultiSelect = false;
      this.ltvInstruments.Name = "ltvInstruments";
      this.ltvInstruments.ShowGroups = false;
      this.ltvInstruments.ShowItemToolTips = true;
      this.ltvInstruments.Size = new Size(360, 133);
      this.ltvInstruments.SmallImageList = this.imgInstruments;
      this.ltvInstruments.Sorting = SortOrder.Ascending;
      this.ltvInstruments.TabIndex = 0;
      this.ltvInstruments.UseCompatibleStateImageBehavior = false;
      this.ltvInstruments.View = View.List;
      this.imgInstruments.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgInstruments.ImageStream");
      this.imgInstruments.TransparentColor = Color.Transparent;
      this.imgInstruments.Images.SetKeyName(0, "instrument.png");
      this.btnImport.Location = new Point(281, 492);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new Size(80, 24);
      this.btnImport.TabIndex = 4;
      this.btnImport.Text = "Import";
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new EventHandler(this.btnImport_Click);
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(367, 492);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(80, 24);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.groupBox5.Controls.Add((Control) this.btnAdvanced);
      this.groupBox5.Controls.Add((Control) this.dtpTo);
      this.groupBox5.Controls.Add((Control) this.dtpFrom);
      this.groupBox5.Controls.Add((Control) this.label2);
      this.groupBox5.Controls.Add((Control) this.label1);
      this.groupBox5.Controls.Add((Control) this.label4);
      this.groupBox5.Controls.Add((Control) this.label3);
      this.groupBox5.Controls.Add((Control) this.chbQuotes);
      this.groupBox5.Controls.Add((Control) this.chbTrades);
      this.groupBox5.Location = new Point(8, 356);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(460, 115);
      this.groupBox5.TabIndex = 6;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Settings";
      this.chbTrades.Checked = true;
      this.chbTrades.CheckState = CheckState.Checked;
      this.chbTrades.Location = new Point(20, 48);
      this.chbTrades.Name = "chbTrades";
      this.chbTrades.Size = new Size(88, 21);
      this.chbTrades.TabIndex = 1;
      this.chbTrades.Text = "Trades";
      this.chbTrades.UseVisualStyleBackColor = true;
      this.chbQuotes.Checked = true;
      this.chbQuotes.CheckState = CheckState.Checked;
      this.chbQuotes.Location = new Point(20, 72);
      this.chbQuotes.Name = "chbQuotes";
      this.chbQuotes.Size = new Size(88, 21);
      this.chbQuotes.TabIndex = 2;
      this.chbQuotes.Text = "Quotes";
      this.chbQuotes.UseVisualStyleBackColor = true;
      this.label3.Location = new Point(12, 24);
      this.label3.Name = "label3";
      this.label3.Size = new Size(75, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Data Type";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.label4.Location = new Point(150, 24);
      this.label4.Name = "label4";
      this.label4.Size = new Size(75, 20);
      this.label4.TabIndex = 4;
      this.label4.Text = "Time Interval";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.label1.Location = new Point(164, 44);
      this.label1.Name = "label1";
      this.label1.Size = new Size(52, 22);
      this.label1.TabIndex = 5;
      this.label1.Text = "From";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(164, 70);
      this.label2.Name = "label2";
      this.label2.Size = new Size(52, 22);
      this.label2.TabIndex = 6;
      this.label2.Text = "To";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.dtpFrom.Format = DateTimePickerFormat.Time;
      this.dtpFrom.Location = new Point(209, 44);
      this.dtpFrom.Name = "dtpFrom";
      this.dtpFrom.ShowCheckBox = true;
      this.dtpFrom.ShowUpDown = true;
      this.dtpFrom.Size = new Size(106, 20);
      this.dtpFrom.TabIndex = 7;
      this.dtpFrom.Value = new DateTime(2012, 7, 17, 9, 30, 0, 0);
      this.dtpTo.Format = DateTimePickerFormat.Time;
      this.dtpTo.Location = new Point(209, 72);
      this.dtpTo.Name = "dtpTo";
      this.dtpTo.ShowCheckBox = true;
      this.dtpTo.ShowUpDown = true;
      this.dtpTo.Size = new Size(106, 20);
      this.dtpTo.TabIndex = 8;
      this.dtpTo.Value = new DateTime(2012, 7, 17, 16, 0, 0, 0);
      this.btnAdvanced.Location = new Point(361, 22);
      this.btnAdvanced.Name = "btnAdvanced";
      this.btnAdvanced.Size = new Size(87, 24);
      this.btnAdvanced.TabIndex = 3;
      this.btnAdvanced.Text = "Advanced...";
      this.btnAdvanced.UseVisualStyleBackColor = true;
      this.btnAdvanced.Click += new EventHandler(this.btnAdvanced_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(478, 535);
      this.Controls.Add((Control) this.groupBox5);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnImport);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ImportSettingsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import NxCore Tape File(s)";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
