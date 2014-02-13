// Type: OpenQuant.Shared.Data.Import.CSV.TemplatePage
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using OpenQuant.API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;

namespace OpenQuant.Shared.Data.Import.CSV
{
  internal class TemplatePage : WizardPage
  {
    private const int NUMBER_OF_LINES_TO_PREVIEW = 50;
    private const string TEMPLATE_FILE_NAME = "import.templates.xml";
    private ArrayList lines;
    private bool captureEvents;
    private ColumnHeader columnHeader1;
    private ListView ltvCSV;
    private ColumnContextMenuStrip ctxColumn;
    private Panel panel5;
    private Label label7;
    private ComboBox cbxTemplates;
    private Button btnSaveAs;
    private Panel panel13;
    private Button btnApply;
    private Panel panel14;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private GroupBox groupBox1;
    private Panel panel2;
    private NumericUpDown nudHeaderLines;
    private Label label3;
    private Label label2;
    private Panel panel1;
    private ComboBox cbxSeparators;
    private Label label1;
    private GroupBox groupBox3;
    private Panel panel3;
    private Label label4;
    private ComboBox cbxCultures;
    private GroupBox groupBox2;
    private Panel panelBarSize;
    private NumericUpDown nudBarSize;
    private Label label6;
    private Panel panel4;
    private ComboBox cbxDataTypes;
    private Label label5;
    private GroupBox gbxDateOptions;
    private Panel panel7;
    private DateTimePicker dtpDateManually;
    private Panel panel8;
    private RadioButton rbnDateManually;
    private RadioButton rbnDateColumn;
    private Panel panel6;
    private GroupBox groupBox4;
    private Panel panel11;
    private TextBox tbxSymbolManually;
    private Panel panel12;
    private RadioButton rbnSymbolManually;
    private Panel panel10;
    private RadioButton rbnSymbolFile;
    private RadioButton rbnSymbolColumn;
    private Panel panel9;
    private Panel panel15;
    private ImageList images;
    private Label lblTemplateStatusImage;
    private Label lblTemplateStatus;
    private GroupBox groupBox6;
    private Panel panel19;
    private CheckBox chbClearSeries;
    private Panel panel20;
    private ComboBox cbxInstrumentTypes;
    private CheckBox chbCreateInstrument;
    private Panel panelBarDateTime;
    private ComboBox cbxBarDateTime;
    private Label label8;
    private GroupBox groupBox5;
    private CheckBox chbxRangeImport;
    private Label lblToRange;
    private DateTimePicker dtpDateTimeTo;
    private Label lblFromRange;
    private DateTimePicker dtpDateTimeFrom;
    private CheckBox chbSkipInsideExistingRange;
    private IContainer components;

    public override bool CanNext
    {
      get
      {
        return this.settings.Template.IsCompleted;
      }
    }

    public override string Title
    {
      get
      {
        return "Set Import Template";
      }
    }

    public TemplatePage()
    {
      this.InitializeComponent();
      this.lines = new ArrayList();
      this.cbxSeparators.Items.Add((object) new SeparatorItem(Separator.Tab));
      this.cbxSeparators.Items.Add((object) new SeparatorItem(Separator.Comma));
      this.cbxSeparators.Items.Add((object) new SeparatorItem(Separator.Semicolon));
      this.cbxSeparators.Items.Add((object) new SeparatorItem(Separator.Space));
      this.cbxCultures.BeginUpdate();
      foreach (CultureInfo cultureInfo in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
        this.cbxCultures.Items.Add((object) new CultureInfoItem(cultureInfo));
      this.cbxCultures.Sorted = true;
      this.cbxCultures.EndUpdate();
      this.cbxDataTypes.Items.AddRange((object[]) new DataTypeItem[4]
      {
        new DataTypeItem(OpenQuant.Shared.Data.DataType.Daily, new ColumnType[9]
        {
          ColumnType.Symbol,
          ColumnType.Date,
          ColumnType.Open,
          ColumnType.High,
          ColumnType.Low,
          ColumnType.Close,
          ColumnType.Volume,
          ColumnType.OpenInt,
          ColumnType.Skipped
        }),
        new DataTypeItem(OpenQuant.Shared.Data.DataType.Bar, new ColumnType[11]
        {
          ColumnType.Symbol,
          ColumnType.DateTime,
          ColumnType.Date,
          ColumnType.Time,
          ColumnType.Open,
          ColumnType.High,
          ColumnType.Low,
          ColumnType.Close,
          ColumnType.Volume,
          ColumnType.OpenInt,
          ColumnType.Skipped
        }),
        new DataTypeItem(OpenQuant.Shared.Data.DataType.Trade, new ColumnType[7]
        {
          ColumnType.Symbol,
          ColumnType.DateTime,
          ColumnType.Date,
          ColumnType.Time,
          ColumnType.Price,
          ColumnType.Size,
          ColumnType.Skipped
        }),
        new DataTypeItem(OpenQuant.Shared.Data.DataType.Quote, new ColumnType[9]
        {
          ColumnType.Symbol,
          ColumnType.DateTime,
          ColumnType.Date,
          ColumnType.Time,
          ColumnType.Bid,
          ColumnType.BidSize,
          ColumnType.Ask,
          ColumnType.AskSize,
          ColumnType.Skipped
        })
      });
      foreach (BarDateTime barDateTime in Enum.GetValues(typeof (BarDateTime)))
        this.cbxBarDateTime.Items.Add((object) barDateTime);
      this.cbxBarDateTime.SelectedItem = (object) BarDateTime.BeginTime;
      this.ctxColumn.Items.AddRange(new ToolStripItem[20]
      {
        (ToolStripItem) new ColumnMenuItem(ColumnType.Symbol, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ToolStripSeparator(),
        (ToolStripItem) new ColumnMenuItem(ColumnType.DateTime, new ToolStripItem[3]
        {
          (ToolStripItem) new ColumnMenuItem(ColumnType.DateTime, "yyyy-MM-dd HH:mm:ss.fff", new EventHandler(this.ctxColumn_Clicked)),
          (ToolStripItem) new ToolStripSeparator(),
          (ToolStripItem) new ToolStripMenuItem("Custom...", (Image) null, new EventHandler(this.CustomMenuItem_Clicked))
        }),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Date, new ToolStripItem[7]
        {
          (ToolStripItem) new ColumnMenuItem(ColumnType.Date, "M/d/yyyy", new EventHandler(this.ctxColumn_Clicked)),
          (ToolStripItem) new ColumnMenuItem(ColumnType.Date, "d.M.yyyy", new EventHandler(this.ctxColumn_Clicked)),
          (ToolStripItem) new ColumnMenuItem(ColumnType.Date, "yyyy-M-d", new EventHandler(this.ctxColumn_Clicked)),
          (ToolStripItem) new ColumnMenuItem(ColumnType.Date, "yyyy/M/d", new EventHandler(this.ctxColumn_Clicked)),
          (ToolStripItem) new ColumnMenuItem(ColumnType.Date, "yyyyMMdd", new EventHandler(this.ctxColumn_Clicked)),
          (ToolStripItem) new ToolStripSeparator(),
          (ToolStripItem) new ToolStripMenuItem("Custom...", (Image) null, new EventHandler(this.CustomMenuItem_Clicked))
        }),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Time, new ToolStripItem[3]
        {
          (ToolStripItem) new ColumnMenuItem(ColumnType.Time, "HH:mm:ss", new EventHandler(this.ctxColumn_Clicked)),
          (ToolStripItem) new ToolStripSeparator(),
          (ToolStripItem) new ToolStripMenuItem("Custom...", (Image) null, new EventHandler(this.CustomMenuItem_Clicked))
        }),
        (ToolStripItem) new ToolStripSeparator(),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Price, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Size, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Bid, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.BidSize, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Ask, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.AskSize, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Open, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.High, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Low, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Close, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Volume, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ColumnMenuItem(ColumnType.OpenInt, new EventHandler(this.ctxColumn_Clicked)),
        (ToolStripItem) new ToolStripSeparator(),
        (ToolStripItem) new ColumnMenuItem(ColumnType.Skipped, new EventHandler(this.ctxColumn_Clicked))
      });
      this.cbxInstrumentTypes.BeginUpdate();
      foreach (InstrumentType instrumentType in Enum.GetValues(typeof (InstrumentType)))
        this.cbxInstrumentTypes.Items.Add((object) instrumentType);
      this.cbxInstrumentTypes.EndUpdate();
      this.dtpDateTimeFrom.Value = new DateTime(1990, 1, 1);
      this.dtpDateTimeTo.Value = new DateTime(2020, 1, 1);
      this.dtpDateTimeFrom.CustomFormat = this.dtpDateTimeTo.CustomFormat = DateTimeFormatInfo.CurrentInfo.ShortDatePattern + " " + DateTimeFormatInfo.CurrentInfo.LongTimePattern;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TemplatePage));
      this.ltvCSV = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.ctxColumn = new ColumnContextMenuStrip();
      this.panel5 = new Panel();
      this.lblTemplateStatus = new Label();
      this.lblTemplateStatusImage = new Label();
      this.images = new ImageList(this.components);
      this.btnSaveAs = new Button();
      this.panel14 = new Panel();
      this.btnApply = new Button();
      this.panel13 = new Panel();
      this.cbxTemplates = new ComboBox();
      this.label7 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.groupBox4 = new GroupBox();
      this.panel11 = new Panel();
      this.tbxSymbolManually = new TextBox();
      this.panel12 = new Panel();
      this.rbnSymbolManually = new RadioButton();
      this.panel10 = new Panel();
      this.rbnSymbolFile = new RadioButton();
      this.rbnSymbolColumn = new RadioButton();
      this.panel9 = new Panel();
      this.gbxDateOptions = new GroupBox();
      this.panel7 = new Panel();
      this.dtpDateManually = new DateTimePicker();
      this.panel8 = new Panel();
      this.rbnDateManually = new RadioButton();
      this.rbnDateColumn = new RadioButton();
      this.panel6 = new Panel();
      this.groupBox2 = new GroupBox();
      this.panelBarDateTime = new Panel();
      this.cbxBarDateTime = new ComboBox();
      this.label8 = new Label();
      this.panelBarSize = new Panel();
      this.nudBarSize = new NumericUpDown();
      this.label6 = new Label();
      this.panel4 = new Panel();
      this.cbxDataTypes = new ComboBox();
      this.label5 = new Label();
      this.groupBox1 = new GroupBox();
      this.panel2 = new Panel();
      this.nudHeaderLines = new NumericUpDown();
      this.label3 = new Label();
      this.label2 = new Label();
      this.panel1 = new Panel();
      this.cbxSeparators = new ComboBox();
      this.label1 = new Label();
      this.tabPage2 = new TabPage();
      this.groupBox5 = new GroupBox();
      this.chbxRangeImport = new CheckBox();
      this.lblToRange = new Label();
      this.dtpDateTimeTo = new DateTimePicker();
      this.lblFromRange = new Label();
      this.dtpDateTimeFrom = new DateTimePicker();
      this.groupBox6 = new GroupBox();
      this.chbSkipInsideExistingRange = new CheckBox();
      this.chbClearSeries = new CheckBox();
      this.panel20 = new Panel();
      this.chbCreateInstrument = new CheckBox();
      this.cbxInstrumentTypes = new ComboBox();
      this.panel19 = new Panel();
      this.groupBox3 = new GroupBox();
      this.panel3 = new Panel();
      this.label4 = new Label();
      this.cbxCultures = new ComboBox();
      this.panel15 = new Panel();
      this.panel5.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.panel11.SuspendLayout();
      this.panel10.SuspendLayout();
      this.gbxDateOptions.SuspendLayout();
      this.panel7.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panelBarDateTime.SuspendLayout();
      this.panelBarSize.SuspendLayout();
      this.nudBarSize.BeginInit();
      this.panel4.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.nudHeaderLines.BeginInit();
      this.panel1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.panel20.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      this.ltvCSV.BorderStyle = BorderStyle.None;
      this.ltvCSV.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader1
      });
      this.ltvCSV.Dock = DockStyle.Fill;
      this.ltvCSV.Location = new Point(0, 136);
      this.ltvCSV.Name = "ltvCSV";
      this.ltvCSV.Size = new Size(680, 144);
      this.ltvCSV.TabIndex = 4;
      this.ltvCSV.UseCompatibleStateImageBehavior = false;
      this.ltvCSV.View = View.Details;
      this.ltvCSV.ColumnClick += new ColumnClickEventHandler(this.ltvCSV_ColumnClick);
      this.columnHeader1.Width = 0;
      this.ctxColumn.Column = 0;
      this.ctxColumn.Name = "ctxColumn";
      this.ctxColumn.Size = new Size(61, 4);
      this.ctxColumn.Opening += new CancelEventHandler(this.ctxColumn_Opening);
      this.panel5.Controls.Add((Control) this.lblTemplateStatus);
      this.panel5.Controls.Add((Control) this.lblTemplateStatusImage);
      this.panel5.Controls.Add((Control) this.btnSaveAs);
      this.panel5.Controls.Add((Control) this.panel14);
      this.panel5.Controls.Add((Control) this.btnApply);
      this.panel5.Controls.Add((Control) this.panel13);
      this.panel5.Controls.Add((Control) this.cbxTemplates);
      this.panel5.Controls.Add((Control) this.label7);
      this.panel5.Dock = DockStyle.Bottom;
      this.panel5.Location = new Point(0, 288);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(680, 24);
      this.panel5.TabIndex = 5;
      this.lblTemplateStatus.Dock = DockStyle.Right;
      this.lblTemplateStatus.Location = new Point(416, 0);
      this.lblTemplateStatus.Name = "lblTemplateStatus";
      this.lblTemplateStatus.Size = new Size(240, 24);
      this.lblTemplateStatus.TabIndex = 7;
      this.lblTemplateStatus.Text = "Status";
      this.lblTemplateStatus.TextAlign = ContentAlignment.MiddleRight;
      this.lblTemplateStatus.Click += new EventHandler(this.lblTemplateStatus_Click);
      this.lblTemplateStatusImage.Dock = DockStyle.Right;
      this.lblTemplateStatusImage.ImageList = this.images;
      this.lblTemplateStatusImage.Location = new Point(656, 0);
      this.lblTemplateStatusImage.Name = "lblTemplateStatusImage";
      this.lblTemplateStatusImage.Size = new Size(24, 24);
      this.lblTemplateStatusImage.TabIndex = 6;
      this.lblTemplateStatusImage.Click += new EventHandler(this.lblTemplateStatusImage_Click);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "");
      this.images.Images.SetKeyName(1, "");
      this.btnSaveAs.Dock = DockStyle.Left;
      this.btnSaveAs.Location = new Point(264, 0);
      this.btnSaveAs.Name = "btnSaveAs";
      this.btnSaveAs.Size = new Size(64, 24);
      this.btnSaveAs.TabIndex = 2;
      this.btnSaveAs.Text = "Save As...";
      this.btnSaveAs.Click += new EventHandler(this.btnSaveAs_Click);
      this.panel14.Dock = DockStyle.Left;
      this.panel14.Location = new Point(256, 0);
      this.panel14.Name = "panel14";
      this.panel14.Size = new Size(8, 24);
      this.panel14.TabIndex = 5;
      this.btnApply.Dock = DockStyle.Left;
      this.btnApply.Location = new Point(192, 0);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new Size(64, 24);
      this.btnApply.TabIndex = 4;
      this.btnApply.Text = "Apply";
      this.btnApply.Click += new EventHandler(this.btnApply_Click);
      this.panel13.Dock = DockStyle.Left;
      this.panel13.Location = new Point(184, 0);
      this.panel13.Name = "panel13";
      this.panel13.Size = new Size(8, 24);
      this.panel13.TabIndex = 3;
      this.cbxTemplates.Dock = DockStyle.Left;
      this.cbxTemplates.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxTemplates.Location = new Point(56, 0);
      this.cbxTemplates.Name = "cbxTemplates";
      this.cbxTemplates.Size = new Size(128, 21);
      this.cbxTemplates.TabIndex = 1;
      this.label7.Dock = DockStyle.Left;
      this.label7.Location = new Point(0, 0);
      this.label7.Name = "label7";
      this.label7.Size = new Size(56, 24);
      this.label7.TabIndex = 0;
      this.label7.Text = "Template";
      this.label7.TextAlign = ContentAlignment.MiddleLeft;
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Dock = DockStyle.Top;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Multiline = true;
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(680, 136);
      this.tabControl1.TabIndex = 6;
      this.tabPage1.Controls.Add((Control) this.groupBox4);
      this.tabPage1.Controls.Add((Control) this.gbxDateOptions);
      this.tabPage1.Controls.Add((Control) this.groupBox2);
      this.tabPage1.Controls.Add((Control) this.groupBox1);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Size = new Size(672, 110);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Options";
      this.groupBox4.Controls.Add((Control) this.panel11);
      this.groupBox4.Controls.Add((Control) this.panel10);
      this.groupBox4.Controls.Add((Control) this.rbnSymbolColumn);
      this.groupBox4.Controls.Add((Control) this.panel9);
      this.groupBox4.Location = new Point(504, 8);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(160, 96);
      this.groupBox4.TabIndex = 4;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Symbol";
      this.panel11.Controls.Add((Control) this.tbxSymbolManually);
      this.panel11.Controls.Add((Control) this.panel12);
      this.panel11.Controls.Add((Control) this.rbnSymbolManually);
      this.panel11.Dock = DockStyle.Top;
      this.panel11.Location = new Point(8, 64);
      this.panel11.Name = "panel11";
      this.panel11.Size = new Size(149, 24);
      this.panel11.TabIndex = 3;
      this.tbxSymbolManually.Dock = DockStyle.Fill;
      this.tbxSymbolManually.Location = new Point(72, 0);
      this.tbxSymbolManually.Name = "tbxSymbolManually";
      this.tbxSymbolManually.Size = new Size(69, 20);
      this.tbxSymbolManually.TabIndex = 2;
      this.tbxSymbolManually.TextChanged += new EventHandler(this.tbxSymbolManually_TextChanged);
      this.panel12.Dock = DockStyle.Right;
      this.panel12.Location = new Point(141, 0);
      this.panel12.Name = "panel12";
      this.panel12.Size = new Size(8, 24);
      this.panel12.TabIndex = 1;
      this.rbnSymbolManually.AutoCheck = false;
      this.rbnSymbolManually.Dock = DockStyle.Left;
      this.rbnSymbolManually.Location = new Point(0, 0);
      this.rbnSymbolManually.Name = "rbnSymbolManually";
      this.rbnSymbolManually.Size = new Size(72, 24);
      this.rbnSymbolManually.TabIndex = 0;
      this.rbnSymbolManually.Text = "manually";
      this.rbnSymbolManually.Click += new EventHandler(this.SymbolRadioButton_Click);
      this.panel10.Controls.Add((Control) this.rbnSymbolFile);
      this.panel10.Dock = DockStyle.Top;
      this.panel10.Location = new Point(8, 40);
      this.panel10.Name = "panel10";
      this.panel10.Size = new Size(149, 24);
      this.panel10.TabIndex = 1;
      this.rbnSymbolFile.AutoCheck = false;
      this.rbnSymbolFile.Dock = DockStyle.Left;
      this.rbnSymbolFile.Location = new Point(0, 0);
      this.rbnSymbolFile.Name = "rbnSymbolFile";
      this.rbnSymbolFile.Size = new Size(72, 24);
      this.rbnSymbolFile.TabIndex = 0;
      this.rbnSymbolFile.Text = "file name";
      this.rbnSymbolFile.Click += new EventHandler(this.SymbolRadioButton_Click);
      this.rbnSymbolColumn.AutoCheck = false;
      this.rbnSymbolColumn.Dock = DockStyle.Top;
      this.rbnSymbolColumn.Location = new Point(8, 16);
      this.rbnSymbolColumn.Name = "rbnSymbolColumn";
      this.rbnSymbolColumn.Size = new Size(149, 24);
      this.rbnSymbolColumn.TabIndex = 2;
      this.rbnSymbolColumn.Text = "column";
      this.rbnSymbolColumn.Click += new EventHandler(this.SymbolRadioButton_Click);
      this.panel9.Dock = DockStyle.Left;
      this.panel9.Location = new Point(3, 16);
      this.panel9.Name = "panel9";
      this.panel9.Size = new Size(5, 77);
      this.panel9.TabIndex = 0;
      this.gbxDateOptions.Controls.Add((Control) this.panel7);
      this.gbxDateOptions.Controls.Add((Control) this.rbnDateManually);
      this.gbxDateOptions.Controls.Add((Control) this.rbnDateColumn);
      this.gbxDateOptions.Controls.Add((Control) this.panel6);
      this.gbxDateOptions.Location = new Point(352, 8);
      this.gbxDateOptions.Name = "gbxDateOptions";
      this.gbxDateOptions.Size = new Size(144, 96);
      this.gbxDateOptions.TabIndex = 3;
      this.gbxDateOptions.TabStop = false;
      this.gbxDateOptions.Text = "Date";
      this.panel7.Controls.Add((Control) this.dtpDateManually);
      this.panel7.Controls.Add((Control) this.panel8);
      this.panel7.Dock = DockStyle.Fill;
      this.panel7.Location = new Point(8, 64);
      this.panel7.Name = "panel7";
      this.panel7.Size = new Size(133, 29);
      this.panel7.TabIndex = 3;
      this.dtpDateManually.Dock = DockStyle.Right;
      this.dtpDateManually.Format = DateTimePickerFormat.Short;
      this.dtpDateManually.Location = new Point(21, 0);
      this.dtpDateManually.Name = "dtpDateManually";
      this.dtpDateManually.Size = new Size(104, 20);
      this.dtpDateManually.TabIndex = 1;
      this.dtpDateManually.ValueChanged += new EventHandler(this.dtpDateManually_ValueChanged);
      this.panel8.Dock = DockStyle.Right;
      this.panel8.Location = new Point(125, 0);
      this.panel8.Name = "panel8";
      this.panel8.Size = new Size(8, 29);
      this.panel8.TabIndex = 0;
      this.rbnDateManually.Dock = DockStyle.Top;
      this.rbnDateManually.Location = new Point(8, 40);
      this.rbnDateManually.Name = "rbnDateManually";
      this.rbnDateManually.Size = new Size(133, 24);
      this.rbnDateManually.TabIndex = 2;
      this.rbnDateManually.Text = "manually";
      this.rbnDateManually.CheckedChanged += new EventHandler(this.rbnDateManually_CheckedChanged);
      this.rbnDateColumn.Dock = DockStyle.Top;
      this.rbnDateColumn.Location = new Point(8, 16);
      this.rbnDateColumn.Name = "rbnDateColumn";
      this.rbnDateColumn.Size = new Size(133, 24);
      this.rbnDateColumn.TabIndex = 1;
      this.rbnDateColumn.Text = "column";
      this.rbnDateColumn.CheckedChanged += new EventHandler(this.rbnDateColumn_CheckedChanged);
      this.panel6.Dock = DockStyle.Left;
      this.panel6.Location = new Point(3, 16);
      this.panel6.Name = "panel6";
      this.panel6.Size = new Size(5, 77);
      this.panel6.TabIndex = 0;
      this.groupBox2.Controls.Add((Control) this.panelBarDateTime);
      this.groupBox2.Controls.Add((Control) this.panelBarSize);
      this.groupBox2.Controls.Add((Control) this.panel4);
      this.groupBox2.Location = new Point(184, 8);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(160, 96);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Data";
      this.panelBarDateTime.Controls.Add((Control) this.cbxBarDateTime);
      this.panelBarDateTime.Controls.Add((Control) this.label8);
      this.panelBarDateTime.Location = new Point(8, 72);
      this.panelBarDateTime.Name = "panelBarDateTime";
      this.panelBarDateTime.Size = new Size(144, 21);
      this.panelBarDateTime.TabIndex = 2;
      this.cbxBarDateTime.Dock = DockStyle.Fill;
      this.cbxBarDateTime.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxBarDateTime.Location = new Point(68, 0);
      this.cbxBarDateTime.Name = "cbxBarDateTime";
      this.cbxBarDateTime.Size = new Size(76, 21);
      this.cbxBarDateTime.TabIndex = 2;
      this.cbxBarDateTime.SelectedIndexChanged += new EventHandler(this.cbxBarDateTime_SelectedIndexChanged);
      this.label8.Dock = DockStyle.Left;
      this.label8.Location = new Point(0, 0);
      this.label8.Name = "label8";
      this.label8.Size = new Size(68, 21);
      this.label8.TabIndex = 0;
      this.label8.Text = "Bar datetime";
      this.label8.TextAlign = ContentAlignment.MiddleLeft;
      this.panelBarSize.Controls.Add((Control) this.nudBarSize);
      this.panelBarSize.Controls.Add((Control) this.label6);
      this.panelBarSize.Location = new Point(8, 48);
      this.panelBarSize.Name = "panelBarSize";
      this.panelBarSize.Size = new Size(144, 20);
      this.panelBarSize.TabIndex = 1;
      this.nudBarSize.Dock = DockStyle.Fill;
      this.nudBarSize.Location = new Point(68, 0);
      NumericUpDown numericUpDown1 = this.nudBarSize;
      int[] bits1 = new int[4];
      bits1[0] = 86400;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      NumericUpDown numericUpDown2 = this.nudBarSize;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Minimum = num2;
      this.nudBarSize.Name = "nudBarSize";
      this.nudBarSize.Size = new Size(76, 20);
      this.nudBarSize.TabIndex = 1;
      this.nudBarSize.TextAlign = HorizontalAlignment.Right;
      NumericUpDown numericUpDown3 = this.nudBarSize;
      int[] bits3 = new int[4];
      bits3[0] = 60;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Value = num3;
      this.nudBarSize.ValueChanged += new EventHandler(this.nudBarSize_ValueChanged);
      this.label6.Dock = DockStyle.Left;
      this.label6.Location = new Point(0, 0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(68, 20);
      this.label6.TabIndex = 0;
      this.label6.Text = "Bar size(sec)";
      this.label6.TextAlign = ContentAlignment.MiddleLeft;
      this.panel4.Controls.Add((Control) this.cbxDataTypes);
      this.panel4.Controls.Add((Control) this.label5);
      this.panel4.Location = new Point(8, 16);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(144, 21);
      this.panel4.TabIndex = 0;
      this.cbxDataTypes.Dock = DockStyle.Fill;
      this.cbxDataTypes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxDataTypes.Location = new Point(48, 0);
      this.cbxDataTypes.Name = "cbxDataTypes";
      this.cbxDataTypes.Size = new Size(96, 21);
      this.cbxDataTypes.TabIndex = 1;
      this.cbxDataTypes.SelectedIndexChanged += new EventHandler(this.cbxDataTypes_SelectedIndexChanged);
      this.label5.Dock = DockStyle.Left;
      this.label5.Location = new Point(0, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(48, 21);
      this.label5.TabIndex = 0;
      this.label5.Text = "Type";
      this.label5.TextAlign = ContentAlignment.MiddleLeft;
      this.groupBox1.Controls.Add((Control) this.panel2);
      this.groupBox1.Controls.Add((Control) this.panel1);
      this.groupBox1.Location = new Point(8, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(168, 96);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "CSV";
      this.panel2.Controls.Add((Control) this.nudHeaderLines);
      this.panel2.Controls.Add((Control) this.label3);
      this.panel2.Controls.Add((Control) this.label2);
      this.panel2.Location = new Point(8, 48);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(152, 20);
      this.panel2.TabIndex = 6;
      this.nudHeaderLines.BackColor = SystemColors.Window;
      this.nudHeaderLines.Dock = DockStyle.Fill;
      this.nudHeaderLines.Location = new Point(72, 0);
      this.nudHeaderLines.Name = "nudHeaderLines";
      this.nudHeaderLines.ReadOnly = true;
      this.nudHeaderLines.Size = new Size(48, 20);
      this.nudHeaderLines.TabIndex = 6;
      this.nudHeaderLines.TextAlign = HorizontalAlignment.Center;
      this.nudHeaderLines.ValueChanged += new EventHandler(this.nudHeaderLines_ValueChanged);
      this.label3.Dock = DockStyle.Right;
      this.label3.Location = new Point(120, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(32, 20);
      this.label3.TabIndex = 5;
      this.label3.Text = "lines";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Dock = DockStyle.Left;
      this.label2.Location = new Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(72, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Header with";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.panel1.Controls.Add((Control) this.cbxSeparators);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(8, 16);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(152, 21);
      this.panel1.TabIndex = 5;
      this.cbxSeparators.Dock = DockStyle.Fill;
      this.cbxSeparators.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxSeparators.Location = new Point(66, 0);
      this.cbxSeparators.Name = "cbxSeparators";
      this.cbxSeparators.Size = new Size(86, 21);
      this.cbxSeparators.TabIndex = 2;
      this.cbxSeparators.SelectedIndexChanged += new EventHandler(this.cbxSeparators_SelectedIndexChanged);
      this.label1.Dock = DockStyle.Left;
      this.label1.Location = new Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(66, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "Separator";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.tabPage2.Controls.Add((Control) this.groupBox5);
      this.tabPage2.Controls.Add((Control) this.groupBox6);
      this.tabPage2.Controls.Add((Control) this.groupBox3);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Size = new Size(672, 110);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Advanced";
      this.groupBox5.Controls.Add((Control) this.chbxRangeImport);
      this.groupBox5.Controls.Add((Control) this.lblToRange);
      this.groupBox5.Controls.Add((Control) this.dtpDateTimeTo);
      this.groupBox5.Controls.Add((Control) this.lblFromRange);
      this.groupBox5.Controls.Add((Control) this.dtpDateTimeFrom);
      this.groupBox5.Location = new Point(430, 8);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(239, 96);
      this.groupBox5.TabIndex = 3;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Date Time Interval";
      this.chbxRangeImport.AutoSize = true;
      this.chbxRangeImport.Location = new Point(10, 20);
      this.chbxRangeImport.Name = "chbxRangeImport";
      this.chbxRangeImport.Size = new Size(182, 17);
      this.chbxRangeImport.TabIndex = 17;
      this.chbxRangeImport.Text = "Import only data with in the range";
      this.chbxRangeImport.UseVisualStyleBackColor = true;
      this.chbxRangeImport.CheckedChanged += new EventHandler(this.chbxRangeImport_CheckedChanged);
      this.lblToRange.AutoSize = true;
      this.lblToRange.Enabled = false;
      this.lblToRange.Location = new Point(7, 70);
      this.lblToRange.Name = "lblToRange";
      this.lblToRange.Size = new Size(20, 13);
      this.lblToRange.TabIndex = 16;
      this.lblToRange.Text = "To";
      this.dtpDateTimeTo.Enabled = false;
      this.dtpDateTimeTo.Format = DateTimePickerFormat.Custom;
      this.dtpDateTimeTo.Location = new Point(43, 70);
      this.dtpDateTimeTo.Name = "dtpDateTimeTo";
      this.dtpDateTimeTo.Size = new Size(190, 20);
      this.dtpDateTimeTo.TabIndex = 15;
      this.dtpDateTimeTo.ValueChanged += new EventHandler(this.dtpDateTimeTo_ValueChanged);
      this.lblFromRange.AutoSize = true;
      this.lblFromRange.Enabled = false;
      this.lblFromRange.Location = new Point(7, 44);
      this.lblFromRange.Name = "lblFromRange";
      this.lblFromRange.Size = new Size(30, 13);
      this.lblFromRange.TabIndex = 14;
      this.lblFromRange.Text = "From";
      this.dtpDateTimeFrom.Enabled = false;
      this.dtpDateTimeFrom.Format = DateTimePickerFormat.Custom;
      this.dtpDateTimeFrom.Location = new Point(43, 44);
      this.dtpDateTimeFrom.Name = "dtpDateTimeFrom";
      this.dtpDateTimeFrom.Size = new Size(190, 20);
      this.dtpDateTimeFrom.TabIndex = 13;
      this.dtpDateTimeFrom.ValueChanged += new EventHandler(this.dtpDateTimeFrom_ValueChanged);
      this.groupBox6.Controls.Add((Control) this.chbSkipInsideExistingRange);
      this.groupBox6.Controls.Add((Control) this.chbClearSeries);
      this.groupBox6.Controls.Add((Control) this.panel20);
      this.groupBox6.Controls.Add((Control) this.panel19);
      this.groupBox6.Location = new Point(180, 8);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(246, 96);
      this.groupBox6.TabIndex = 2;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Other";
      this.chbSkipInsideExistingRange.Dock = DockStyle.Top;
      this.chbSkipInsideExistingRange.Location = new Point(8, 63);
      this.chbSkipInsideExistingRange.Name = "chbSkipInsideExistingRange";
      this.chbSkipInsideExistingRange.Size = new Size(235, 23);
      this.chbSkipInsideExistingRange.TabIndex = 6;
      this.chbSkipInsideExistingRange.Text = "Skip data inside the existing data time range";
      this.chbSkipInsideExistingRange.CheckedChanged += new EventHandler(this.chbSkipInsideExistingRange_CheckedChanged);
      this.chbClearSeries.Dock = DockStyle.Top;
      this.chbClearSeries.Location = new Point(8, 40);
      this.chbClearSeries.Name = "chbClearSeries";
      this.chbClearSeries.Size = new Size(235, 23);
      this.chbClearSeries.TabIndex = 4;
      this.chbClearSeries.Text = "Clear series";
      this.chbClearSeries.CheckedChanged += new EventHandler(this.chbClearSeries_CheckedChanged);
      this.panel20.Controls.Add((Control) this.chbCreateInstrument);
      this.panel20.Controls.Add((Control) this.cbxInstrumentTypes);
      this.panel20.Dock = DockStyle.Top;
      this.panel20.Location = new Point(8, 16);
      this.panel20.Name = "panel20";
      this.panel20.Size = new Size(235, 24);
      this.panel20.TabIndex = 5;
      this.chbCreateInstrument.Dock = DockStyle.Fill;
      this.chbCreateInstrument.Location = new Point(0, 0);
      this.chbCreateInstrument.Name = "chbCreateInstrument";
      this.chbCreateInstrument.Size = new Size(131, 24);
      this.chbCreateInstrument.TabIndex = 4;
      this.chbCreateInstrument.Text = "Create instrument";
      this.chbCreateInstrument.CheckedChanged += new EventHandler(this.chbCreateInstrument_CheckedChanged);
      this.cbxInstrumentTypes.Dock = DockStyle.Right;
      this.cbxInstrumentTypes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxInstrumentTypes.FormattingEnabled = true;
      this.cbxInstrumentTypes.Location = new Point(131, 0);
      this.cbxInstrumentTypes.Name = "cbxInstrumentTypes";
      this.cbxInstrumentTypes.Size = new Size(104, 21);
      this.cbxInstrumentTypes.Sorted = true;
      this.cbxInstrumentTypes.TabIndex = 0;
      this.cbxInstrumentTypes.SelectedIndexChanged += new EventHandler(this.cbxInstrumentTypes_SelectedIndexChanged);
      this.panel19.Dock = DockStyle.Left;
      this.panel19.Location = new Point(3, 16);
      this.panel19.Name = "panel19";
      this.panel19.Size = new Size(5, 77);
      this.panel19.TabIndex = 2;
      this.groupBox3.Controls.Add((Control) this.panel3);
      this.groupBox3.Location = new Point(8, 8);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(168, 96);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "CSV";
      this.panel3.Controls.Add((Control) this.label4);
      this.panel3.Controls.Add((Control) this.cbxCultures);
      this.panel3.Location = new Point(8, 16);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(152, 40);
      this.panel3.TabIndex = 8;
      this.label4.Dock = DockStyle.Fill;
      this.label4.Location = new Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(152, 19);
      this.label4.TabIndex = 1;
      this.label4.Text = "Localization";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxCultures.Dock = DockStyle.Bottom;
      this.cbxCultures.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxCultures.Location = new Point(0, 19);
      this.cbxCultures.Name = "cbxCultures";
      this.cbxCultures.Size = new Size(152, 21);
      this.cbxCultures.TabIndex = 0;
      this.cbxCultures.SelectedIndexChanged += new EventHandler(this.cbxCultures_SelectedIndexChanged);
      this.panel15.Dock = DockStyle.Bottom;
      this.panel15.Location = new Point(0, 280);
      this.panel15.Name = "panel15";
      this.panel15.Size = new Size(680, 8);
      this.panel15.TabIndex = 7;
      this.Controls.Add((Control) this.ltvCSV);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.panel15);
      this.Controls.Add((Control) this.panel5);
      this.Name = "TemplatePage";
      this.Size = new Size(680, 312);
      this.panel5.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.panel11.ResumeLayout(false);
      this.panel11.PerformLayout();
      this.panel10.ResumeLayout(false);
      this.gbxDateOptions.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.panelBarDateTime.ResumeLayout(false);
      this.panelBarSize.ResumeLayout(false);
      this.nudBarSize.EndInit();
      this.panel4.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.nudHeaderLines.EndInit();
      this.panel1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.panel20.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public override void BeforeLoad()
    {
      this.lines.Clear();
      StreamReader streamReader = new StreamReader(this.settings.Files[0].FullName);
      for (int index = 0; index < 50; ++index)
      {
        string str = streamReader.ReadLine();
        if (str != null)
          this.lines.Add((object) str);
        else
          break;
      }
      streamReader.Close();
      this.PrepareTemplateColumns();
      this.ApplyTemplate();
      this.UpdateTemplateList();
    }

    private void PrepareTemplateColumns()
    {
      Template template = this.settings.Template;
      int num = 0;
      foreach (string str in this.lines)
      {
        string[] strArray = str.Split((char[]) template.CSVOptions.Separator);
        if (strArray.Length > num)
          num = strArray.Length;
      }
      while (template.Columns.Count > num)
        template.Columns.RemoveAt(template.Columns.Count - 1);
      while (template.Columns.Count < num)
        template.Columns.Add(new Column());
    }

    private void ApplyTemplate()
    {
      Template template = this.settings.Template;
      this.captureEvents = false;
      foreach (SeparatorItem separatorItem in this.cbxSeparators.Items)
      {
        if (separatorItem.Separator == template.CSVOptions.Separator)
        {
          this.cbxSeparators.SelectedItem = (object) separatorItem;
          break;
        }
      }
      this.nudHeaderLines.Value = (Decimal) template.CSVOptions.HeaderLineCount;
      foreach (CultureInfoItem cultureInfoItem in this.cbxCultures.Items)
      {
        if (cultureInfoItem.CultureInfo.Equals((object) template.CSVOptions.CultureInfo))
        {
          this.cbxCultures.SelectedItem = (object) cultureInfoItem;
          break;
        }
      }
      foreach (DataTypeItem dataTypeItem in this.cbxDataTypes.Items)
      {
        if (dataTypeItem.DataType == template.DataOptions.DataType)
        {
          this.cbxDataTypes.SelectedItem = (object) dataTypeItem;
          using (List<Column>.Enumerator enumerator = template.Columns.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Column current = enumerator.Current;
              if (!dataTypeItem.IsColumnAllowed(current.ColumnType))
              {
                current.ColumnType = ColumnType.Skipped;
                current.ColumnFormat = "";
              }
            }
            break;
          }
        }
      }
      this.nudBarSize.Value = (Decimal) template.DataOptions.BarSize;
      this.cbxBarDateTime.SelectedItem = (object) template.DataOptions.BarDateTime;
      if (template.DataOptions.DataType == OpenQuant.Shared.Data.DataType.Bar)
      {
        this.panelBarSize.Enabled = true;
        this.panelBarDateTime.Enabled = true;
      }
      else
      {
        this.panelBarSize.Enabled = false;
        this.panelBarDateTime.Enabled = false;
      }
      switch (template.DateOptions.DateType)
      {
        case DateType.Column:
          this.rbnDateColumn.Checked = true;
          this.dtpDateManually.Enabled = false;
          break;
        case DateType.Manually:
          this.rbnDateManually.Checked = true;
          this.dtpDateManually.Enabled = true;
          this.SkipColumns((ColumnType) 6);
          break;
      }
      this.dtpDateManually.Value = template.DateOptions.Date;
      this.gbxDateOptions.Enabled = template.DataOptions.DataType != OpenQuant.Shared.Data.DataType.Daily;
      this.rbnSymbolColumn.Checked = this.rbnSymbolFile.Checked = this.rbnSymbolManually.Checked = false;
      switch (template.SymbolOptions.Option)
      {
        case SymbolOption.FileName:
          this.rbnSymbolFile.Checked = true;
          this.tbxSymbolManually.Enabled = false;
          this.SkipColumns(ColumnType.Symbol);
          break;
        case SymbolOption.Column:
          this.rbnSymbolColumn.Checked = true;
          this.tbxSymbolManually.Enabled = false;
          break;
        case SymbolOption.Manually:
          this.rbnSymbolManually.Checked = true;
          this.tbxSymbolManually.Enabled = true;
          this.SkipColumns(ColumnType.Symbol);
          break;
      }
      this.tbxSymbolManually.Text = template.SymbolOptions.Name;
      this.chbCreateInstrument.Checked = template.OtherOptions.CreateInstrument;
      this.chbClearSeries.Checked = template.OtherOptions.ClearSeries;
      this.chbSkipInsideExistingRange.Checked = template.OtherOptions.SkipDataInsideExistingRange;
      this.cbxInstrumentTypes.SelectedItem = (object) template.OtherOptions.InstrumentType;
      this.cbxInstrumentTypes.Enabled = template.OtherOptions.CreateInstrument;
      this.ltvCSV.BeginUpdate();
      this.ltvCSV.Items.Clear();
      while (this.ltvCSV.Columns.Count > template.Columns.Count + 1)
        this.ltvCSV.Columns.RemoveAt(this.ltvCSV.Columns.Count - 1);
      for (int index = 0; index < template.Columns.Count; ++index)
      {
        string str = Column.ToString(template.Columns[index].ColumnType);
        if (template.Columns[index].ColumnFormat != "")
          str = str + " (" + template.Columns[index].ColumnFormat + ")";
        if (this.ltvCSV.Columns.Count <= index + 1)
          this.ltvCSV.Columns.Add("", 100, HorizontalAlignment.Center);
        this.ltvCSV.Columns[index + 1].Text = str;
      }
      foreach (string str in this.lines)
      {
        string[] strArray = str.Split((char[]) template.CSVOptions.Separator);
        ListViewItem listViewItem = new ListViewItem("");
        listViewItem.UseItemStyleForSubItems = true;
        if (this.ltvCSV.Items.Count < template.CSVOptions.HeaderLineCount)
          listViewItem.BackColor = Color.Red;
        foreach (string text in strArray)
          listViewItem.SubItems.Add(text);
        this.ltvCSV.Items.Add(listViewItem);
      }
      this.ltvCSV.EndUpdate();
      template.Validate();
      if (template.IsCompleted)
      {
        this.lblTemplateStatus.Text = "Template is completed";
        this.lblTemplateStatusImage.ImageIndex = 1;
      }
      else
      {
        this.lblTemplateStatus.Text = "Template is not completed. Click here...";
        this.lblTemplateStatusImage.ImageIndex = 0;
      }
      this.EmitButtonEnabledChanged();
      this.captureEvents = true;
      this.chbxRangeImport.Checked = false;
    }

    private void SkipColumns(ColumnType columnType)
    {
      foreach (Column column in (List<Column>) this.settings.Template.Columns)
      {
        if ((column.ColumnType & columnType) > (ColumnType) 0)
        {
          column.ColumnType = ColumnType.Skipped;
          column.ColumnFormat = "";
        }
      }
    }

    private void ViewTemplateErrors()
    {
      if (this.settings.Template.IsCompleted)
        return;
      TemplateErrorForm templateErrorForm = new TemplateErrorForm();
      templateErrorForm.SetErrors(this.settings.Template.Validate());
      int num = (int) templateErrorForm.ShowDialog();
      templateErrorForm.Dispose();
    }

    private void UpdateTemplateList()
    {
      this.cbxTemplates.BeginUpdate();
      this.cbxTemplates.Items.Clear();
      foreach (Template template in this.ReadTemplates())
        this.cbxTemplates.Items.Add((object) template);
      this.cbxTemplates.EndUpdate();
    }

    private TemplateCollection ReadTemplates()
    {
      string str = string.Format("{0}\\{1}", (object) this.templateDirectory.FullName, (object) "import.templates.xml");
      if (!File.Exists(str))
        return new TemplateCollection();
      try
      {
        TemplateCollection templateCollection = new TemplateCollection();
        TemplateXmlDocument templateXmlDocument = new TemplateXmlDocument();
        ((XmlDocument) templateXmlDocument).Load(str);
        foreach (TemplateXmlNode templateXmlNode in templateXmlDocument.Templates)
        {
          Template template = new Template();
          template.Name = templateXmlNode.TemplateName;
          template.CSVOptions.Separator = Separator.GetSeparator(templateXmlNode.CSV.Separator);
          template.CSVOptions.HeaderLineCount = templateXmlNode.CSV.HeaderLineCount;
          template.CSVOptions.CultureInfo = CultureInfo.CreateSpecificCulture(templateXmlNode.CSV.Culture);
          template.DataOptions.DataType = templateXmlNode.Data.DataType;
          template.DataOptions.BarSize = templateXmlNode.Data.BarSize;
          template.DataOptions.BarDateTime = templateXmlNode.Data.BarDateTime;
          template.DateOptions.DateType = templateXmlNode.Date.DateType;
          template.DateOptions.Date = templateXmlNode.Date.Date;
          template.SymbolOptions.Option = templateXmlNode.Symbol.SymbolOption;
          template.SymbolOptions.Name = templateXmlNode.Symbol.Name_;
          template.OtherOptions.CreateInstrument = templateXmlNode.Other.CreateInstrument;
          template.OtherOptions.InstrumentType = templateXmlNode.Other.InstrumentType;
          template.OtherOptions.ClearSeries = templateXmlNode.Other.ClearSeries;
          template.OtherOptions.SkipDataInsideExistingRange = templateXmlNode.Other.SkipDataInsideExistingRange;
          foreach (ColumnXmlNode columnXmlNode in templateXmlNode.Columns)
            template.Columns.Add(new Column()
            {
              ColumnType = columnXmlNode.ColumnType,
              ColumnFormat = columnXmlNode.Format
            });
          templateCollection.Add(template);
        }
        return templateCollection;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ((object) ex).ToString(), "Error reading templates!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return new TemplateCollection();
      }
    }

    private void ltvCSV_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      this.ctxColumn.Column = e.Column;
      this.ctxColumn.Show((Control) this, this.PointToClient(Cursor.Position));
    }

    private void ctxColumn_Opening(object sender, CancelEventArgs e)
    {
      DataTypeItem dataTypeItem = this.cbxDataTypes.SelectedItem as DataTypeItem;
      foreach (ToolStripItem toolStripItem in (ArrangedElementCollection) this.ctxColumn.Items)
      {
        ColumnMenuItem columnMenuItem = toolStripItem as ColumnMenuItem;
        if (columnMenuItem != null)
        {
          columnMenuItem.Visible = dataTypeItem.IsColumnAllowed(columnMenuItem.ColumnType);
          if (this.rbnDateManually.Checked && (columnMenuItem.ColumnType == ColumnType.Date || columnMenuItem.ColumnType == ColumnType.DateTime))
            columnMenuItem.Visible = false;
          if (!this.rbnSymbolColumn.Checked && columnMenuItem.ColumnType == ColumnType.Symbol)
            columnMenuItem.Visible = false;
        }
      }
    }

    private void ctxColumn_Clicked(object sender, EventArgs args)
    {
      ColumnMenuItem columnMenuItem = sender as ColumnMenuItem;
      Column column = this.settings.Template.Columns[this.ctxColumn.Column - 1];
      if (columnMenuItem.ColumnType != ColumnType.Skipped)
        this.SkipColumns(columnMenuItem.ColumnType);
      column.ColumnType = columnMenuItem.ColumnType;
      column.ColumnFormat = columnMenuItem.ColumnFormat;
      switch (columnMenuItem.ColumnType)
      {
        case ColumnType.DateTime:
          this.SkipColumns((ColumnType) 12);
          break;
        case ColumnType.Date:
        case ColumnType.Time:
          this.SkipColumns(ColumnType.DateTime);
          break;
      }
      this.ApplyTemplate();
    }

    private void CustomMenuItem_Clicked(object sender, EventArgs args)
    {
      Column column = this.settings.Template.Columns[this.ctxColumn.Column - 1];
      CustomFormatDialog customFormatDialog = new CustomFormatDialog();
      customFormatDialog.Format = column.ColumnFormat;
      if (customFormatDialog.ShowDialog() == DialogResult.OK)
      {
        ColumnMenuItem columnMenuItem = (sender as ToolStripItem).OwnerItem as ColumnMenuItem;
        if (columnMenuItem.ColumnType != ColumnType.Skipped)
          this.SkipColumns(columnMenuItem.ColumnType);
        column.ColumnType = columnMenuItem.ColumnType;
        column.ColumnFormat = customFormatDialog.Format;
        switch (columnMenuItem.ColumnType)
        {
          case ColumnType.DateTime:
            this.SkipColumns((ColumnType) 12);
            break;
          case ColumnType.Date:
          case ColumnType.Time:
            this.SkipColumns(ColumnType.DateTime);
            break;
        }
        this.ApplyTemplate();
      }
      customFormatDialog.Dispose();
    }

    private void cbxSeparators_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.CSVOptions.Separator = (this.cbxSeparators.SelectedItem as SeparatorItem).Separator;
      this.PrepareTemplateColumns();
      this.ApplyTemplate();
    }

    private void nudHeaderLines_ValueChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.CSVOptions.HeaderLineCount = (int) this.nudHeaderLines.Value;
      this.ApplyTemplate();
    }

    private void cbxCultures_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.CSVOptions.CultureInfo = (this.cbxCultures.SelectedItem as CultureInfoItem).CultureInfo;
    }

    private void cbxDataTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      Template template = this.settings.Template;
      DataTypeItem dataTypeItem = this.cbxDataTypes.SelectedItem as DataTypeItem;
      template.DataOptions.DataType = dataTypeItem.DataType;
      if (dataTypeItem.DataType == OpenQuant.Shared.Data.DataType.Daily)
        template.DateOptions.DateType = DateType.Column;
      this.ApplyTemplate();
    }

    private void nudBarSize_ValueChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.DataOptions.BarSize = (long) (int) this.nudBarSize.Value;
      this.ApplyTemplate();
    }

    private void cbxBarDateTime_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.DataOptions.BarDateTime = (BarDateTime) this.cbxBarDateTime.SelectedItem;
      this.ApplyTemplate();
    }

    private void rbnDateColumn_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents || !this.rbnDateColumn.Checked)
        return;
      this.settings.Template.DateOptions.DateType = DateType.Column;
      this.ApplyTemplate();
    }

    private void rbnDateManually_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents || !this.rbnDateManually.Checked)
        return;
      this.settings.Template.DateOptions.DateType = DateType.Manually;
      this.ApplyTemplate();
    }

    private void dtpDateManually_ValueChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.DateOptions.Date = this.dtpDateManually.Value.Date;
    }

    private void SymbolRadioButton_Click(object sender, EventArgs e)
    {
      if ((sender as RadioButton).Checked)
        return;
      SymbolOption symbolOption = SymbolOption.Column;
      if (sender == this.rbnSymbolColumn)
        symbolOption = SymbolOption.Column;
      if (sender == this.rbnSymbolFile)
        symbolOption = SymbolOption.FileName;
      if (sender == this.rbnSymbolManually)
        symbolOption = SymbolOption.Manually;
      this.settings.Template.SymbolOptions.Option = symbolOption;
      this.ApplyTemplate();
    }

    private void tbxSymbolManually_TextChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.SymbolOptions.Name = this.tbxSymbolManually.Text.Trim();
      this.ApplyTemplate();
    }

    private void chbCreateInstrument_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.OtherOptions.CreateInstrument = this.chbCreateInstrument.Checked;
      this.ApplyTemplate();
    }

    private void chbxRangeImport_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.lblFromRange.Enabled = this.lblToRange.Enabled = this.dtpDateTimeFrom.Enabled = this.dtpDateTimeTo.Enabled = this.chbxRangeImport.Checked;
      this.settings.Template.OtherOptions.ImportOnlyRange = this.chbxRangeImport.Checked;
    }

    private void dtpDateTimeFrom_ValueChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.OtherOptions.ImportRangeBegin = this.dtpDateTimeFrom.Value;
    }

    private void dtpDateTimeTo_ValueChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.OtherOptions.ImportRangeEnd = this.dtpDateTimeTo.Value;
    }

    private void cbxInstrumentTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.OtherOptions.InstrumentType = (InstrumentType) this.cbxInstrumentTypes.SelectedItem;
    }

    private void chbClearSeries_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.OtherOptions.ClearSeries = this.chbClearSeries.Checked;
    }

    private void chbSkipInsideExistingRange_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.captureEvents)
        return;
      this.settings.Template.OtherOptions.SkipDataInsideExistingRange = this.chbSkipInsideExistingRange.Checked;
    }

    private void lblTemplateStatus_Click(object sender, EventArgs e)
    {
      this.ViewTemplateErrors();
    }

    private void lblTemplateStatusImage_Click(object sender, EventArgs e)
    {
      this.ViewTemplateErrors();
    }

    private void btnSaveAs_Click(object sender, EventArgs e)
    {
      TemplateCollection templateCollection = this.ReadTemplates();
      SaveTemplateDialog saveTemplateDialog = new SaveTemplateDialog();
      saveTemplateDialog.SetNames(templateCollection.Names);
      if (saveTemplateDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        Template template1 = this.settings.Template;
        template1.Name = saveTemplateDialog.TemplateName;
        templateCollection[template1.Name] = template1;
        TemplateXmlDocument templateXmlDocument = new TemplateXmlDocument();
        foreach (Template template2 in templateCollection)
          templateXmlDocument.Templates.Add(template2);
        ((XmlDocument) templateXmlDocument).Save(string.Format("{0}\\{1}", (object) this.templateDirectory.FullName, (object) "import.templates.xml"));
        this.UpdateTemplateList();
      }
      saveTemplateDialog.Dispose();
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      Template template = this.cbxTemplates.SelectedItem as Template;
      if (template == null)
        return;
      this.settings.Template = template;
      this.PrepareTemplateColumns();
      this.ApplyTemplate();
      this.UpdateTemplateList();
    }
  }
}
