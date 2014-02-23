using OpenQuant.Shared.Data;
using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Bars
{
  public class CompressBarsForm : Form
  {
    private IContainer components;
    private GroupBox gbxInput;
    private Label label1;
    private ComboBox cbxDataSources;
    private ListView ltvDataSeries;
    private Label label2;
    private Button btnUncheckAll;
    private Button btnCheckAll;
    private GroupBox gbxOutput;
    private Button btnCompress;
    private Button btnClose;
    private ImageList imgDataSeries;
    private ComboBox cbxOutputBars;
    private Label label3;
    private Label label4;
    private ComboBox cbxExistentDataSeries;
    private IDataSeries[] seriesList;
    private bool autoCheck;

    public CompressBarsForm()
    {
      this.InitializeComponent();
      this.cbxExistentDataSeries.BeginUpdate();
      this.cbxExistentDataSeries.Items.Clear();
      foreach (ExistentDataSeries existentDataSeries in Enum.GetValues(typeof (ExistentDataSeries)))
        this.cbxExistentDataSeries.Items.Add((object) existentDataSeries);
      if (this.cbxExistentDataSeries.Items.Count > 0)
        this.cbxExistentDataSeries.SelectedIndex = 0;
      this.cbxExistentDataSeries.EndUpdate();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CompressBarsForm));
      this.gbxInput = new GroupBox();
      this.btnUncheckAll = new Button();
      this.btnCheckAll = new Button();
      this.ltvDataSeries = new ListView();
      this.imgDataSeries = new ImageList(this.components);
      this.label2 = new Label();
      this.cbxDataSources = new ComboBox();
      this.label1 = new Label();
      this.gbxOutput = new GroupBox();
      this.label4 = new Label();
      this.cbxExistentDataSeries = new ComboBox();
      this.cbxOutputBars = new ComboBox();
      this.label3 = new Label();
      this.btnCompress = new Button();
      this.btnClose = new Button();
      this.gbxInput.SuspendLayout();
      this.gbxOutput.SuspendLayout();
      this.SuspendLayout();
      this.gbxInput.Controls.Add((Control) this.btnUncheckAll);
      this.gbxInput.Controls.Add((Control) this.btnCheckAll);
      this.gbxInput.Controls.Add((Control) this.ltvDataSeries);
      this.gbxInput.Controls.Add((Control) this.label2);
      this.gbxInput.Controls.Add((Control) this.cbxDataSources);
      this.gbxInput.Controls.Add((Control) this.label1);
      this.gbxInput.Location = new Point(8, 8);
      this.gbxInput.Name = "gbxInput";
      this.gbxInput.Size = new Size(478, 242);
      this.gbxInput.TabIndex = 0;
      this.gbxInput.TabStop = false;
      this.gbxInput.Text = "Input";
      this.btnUncheckAll.Location = new Point(384, 100);
      this.btnUncheckAll.Name = "btnUncheckAll";
      this.btnUncheckAll.Size = new Size(80, 22);
      this.btnUncheckAll.TabIndex = 5;
      this.btnUncheckAll.Text = "Uncheck All";
      this.btnUncheckAll.UseVisualStyleBackColor = true;
      this.btnUncheckAll.Click += new EventHandler(this.btnUncheckAll_Click);
      this.btnCheckAll.Location = new Point(384, 72);
      this.btnCheckAll.Name = "btnCheckAll";
      this.btnCheckAll.Size = new Size(80, 22);
      this.btnCheckAll.TabIndex = 4;
      this.btnCheckAll.Text = "Check All";
      this.btnCheckAll.UseVisualStyleBackColor = true;
      this.btnCheckAll.Click += new EventHandler(this.btnCheckAll_Click);
      this.ltvDataSeries.CheckBoxes = true;
      this.ltvDataSeries.Location = new Point(16, 72);
      this.ltvDataSeries.Name = "ltvDataSeries";
      this.ltvDataSeries.ShowGroups = false;
      this.ltvDataSeries.Size = new Size(354, 156);
      this.ltvDataSeries.SmallImageList = this.imgDataSeries;
      this.ltvDataSeries.Sorting = SortOrder.Ascending;
      this.ltvDataSeries.TabIndex = 3;
      this.ltvDataSeries.UseCompatibleStateImageBehavior = false;
      this.ltvDataSeries.View = View.List;
      this.imgDataSeries.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgDataSeries.ImageStream");
      this.imgDataSeries.TransparentColor = Color.Transparent;
      this.imgDataSeries.Images.SetKeyName(0, "instrument.png");
      this.label2.Location = new Point(16, 48);
      this.label2.Name = "label2";
      this.label2.Size = new Size(83, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Instruments";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxDataSources.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxDataSources.FormattingEnabled = true;
      this.cbxDataSources.Location = new Point(120, 24);
      this.cbxDataSources.Name = "cbxDataSources";
      this.cbxDataSources.Size = new Size(123, 21);
      this.cbxDataSources.TabIndex = 1;
      this.cbxDataSources.SelectedIndexChanged += new EventHandler(this.cbxDataSources_SelectedIndexChanged);
      this.label1.Location = new Point(16, 24);
      this.label1.Name = "label1";
      this.label1.Size = new Size(109, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Compress bars from";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.gbxOutput.Controls.Add((Control) this.label4);
      this.gbxOutput.Controls.Add((Control) this.cbxExistentDataSeries);
      this.gbxOutput.Controls.Add((Control) this.cbxOutputBars);
      this.gbxOutput.Controls.Add((Control) this.label3);
      this.gbxOutput.Location = new Point(8, 258);
      this.gbxOutput.Name = "gbxOutput";
      this.gbxOutput.Size = new Size(478, 93);
      this.gbxOutput.TabIndex = 1;
      this.gbxOutput.TabStop = false;
      this.gbxOutput.Text = "Output";
      this.label4.Location = new Point(117, 56);
      this.label4.Name = "label4";
      this.label4.Size = new Size(113, 20);
      this.label4.TabIndex = 7;
      this.label4.Text = "existent data series";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxExistentDataSeries.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxExistentDataSeries.FormattingEnabled = true;
      this.cbxExistentDataSeries.Location = new Point(16, 56);
      this.cbxExistentDataSeries.Name = "cbxExistentDataSeries";
      this.cbxExistentDataSeries.Size = new Size(95, 21);
      this.cbxExistentDataSeries.TabIndex = 6;
      this.cbxOutputBars.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxOutputBars.FormattingEnabled = true;
      this.cbxOutputBars.Location = new Point(62, 24);
      this.cbxOutputBars.Name = "cbxOutputBars";
      this.cbxOutputBars.Size = new Size(118, 21);
      this.cbxOutputBars.TabIndex = 4;
      this.label3.Location = new Point(16, 24);
      this.label3.Name = "label3";
      this.label3.Size = new Size(40, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Bars";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.btnCompress.Location = new Point(280, 368);
      this.btnCompress.Name = "btnCompress";
      this.btnCompress.Size = new Size(88, 22);
      this.btnCompress.TabIndex = 5;
      this.btnCompress.Text = "Compress";
      this.btnCompress.UseVisualStyleBackColor = true;
      this.btnCompress.Click += new EventHandler(this.btnCompress_Click);
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new Point(376, 368);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(88, 22);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(498, 406);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnCompress);
      this.Controls.Add((Control) this.gbxOutput);
      this.Controls.Add((Control) this.gbxInput);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CompressBarsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Compress Bars";
      this.gbxInput.ResumeLayout(false);
      this.gbxOutput.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void Init(IDataSeries[] seriesList, bool autoCheck)
    {
      this.seriesList = seriesList;
      this.autoCheck = autoCheck;
    }

    protected override void OnShown(EventArgs e)
    {
      this.InitDataSources();
      this.UpdateDataSeries();
      this.UpdateOutputBars();
      base.OnShown(e);
    }

    private void cbxDataSources_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateDataSeries();
      this.UpdateOutputBars();
    }

    private void btnCheckAll_Click(object sender, EventArgs e)
    {
      this.SetAllDataSeriesChecked(true);
    }

    private void btnUncheckAll_Click(object sender, EventArgs e)
    {
      this.SetAllDataSeriesChecked(false);
    }

    private void btnCompress_Click(object sender, EventArgs e)
    {
      this.Compress();
    }

    private void InitDataSources()
    {
      SortedList<BarDataSource, bool> sortedList = new SortedList<BarDataSource, bool>((IComparer<BarDataSource>) new BarDataSourceComparer());
      bool flag1 = false;
      bool flag2 = false;
      foreach (IDataSeries idataSeries in this.seriesList)
      {
        switch (DataSeriesHelper.GetDataSeriesInfo(idataSeries.Name).DataType)
        {
          case DataType.Trade:
            flag1 = true;
            break;
          case DataType.Quote:
            flag2 = true;
            break;
          case DataType.Bar:
            BarType barType;
            long barSize;
						if (DataSeriesHelper.TryGetBarTypeSize(idataSeries.Name, out barType, out barSize) && (barType != BarType.Time || barSize != 86400L))
            {
              sortedList[new BarDataSource(barType, barSize)] = true;
              break;
            }
            else
              break;
        }
      }
      this.cbxDataSources.BeginUpdate();
      this.cbxDataSources.Items.Clear();
      if (flag1)
        this.cbxDataSources.Items.Add((object) new DataSource(DataSourceInput.Trade));
      if (flag2)
      {
        this.cbxDataSources.Items.Add((object) new DataSource(DataSourceInput.Bid));
        this.cbxDataSources.Items.Add((object) new DataSource(DataSourceInput.Ask));
        this.cbxDataSources.Items.Add((object) new DataSource(DataSourceInput.BidAsk));
        this.cbxDataSources.Items.Add((object) new DataSource(DataSourceInput.Middle));
        this.cbxDataSources.Items.Add((object) new DataSource(DataSourceInput.Spread));
      }
      foreach (object obj in (IEnumerable<BarDataSource>) sortedList.Keys)
        this.cbxDataSources.Items.Add(obj);
      if (this.cbxDataSources.Items.Count > 0)
        this.cbxDataSources.SelectedIndex = 0;
      this.cbxDataSources.EndUpdate();
    }

    private void UpdateDataSeries()
    {
      this.ltvDataSeries.BeginUpdate();
      this.ltvDataSeries.Items.Clear();
      if (this.cbxDataSources.SelectedItem != null)
      {
        DataSource dataSource = (DataSource) this.cbxDataSources.SelectedItem;
        foreach (IDataSeries dataSeries in this.seriesList)
        {
          DataType dataType = DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name).DataType;
          bool flag = false;
          switch (dataSource.Input)
          {
            case DataSourceInput.Trade:
              flag = dataType == DataType.Trade;
              break;
            case DataSourceInput.Bid:
            case DataSourceInput.Ask:
            case DataSourceInput.BidAsk:
            case DataSourceInput.Middle:
            case DataSourceInput.Spread:
              flag = dataType == DataType.Quote;
              break;
            case DataSourceInput.Bar:
              BarType barType;
              long barSize;
              if (dataType == DataType.Bar && DataSeriesHelper.TryGetBarTypeSize(dataSeries.Name, out barType, out barSize))
              {
                BarDataSource barDataSource = (BarDataSource) dataSource;
                flag = barDataSource.BarType == barType && barDataSource.BarSize == barSize;
                break;
              }
              else
                break;
          }
          if (flag)
            this.ltvDataSeries.Items.Add((ListViewItem) new DataSeriesViewItem(dataSeries));
        }
      }
      this.ltvDataSeries.EndUpdate();
      if (!this.autoCheck)
        return;
      this.SetAllDataSeriesChecked(true);
    }

    private void UpdateOutputBars()
    {
      this.cbxOutputBars.BeginUpdate();
      this.cbxOutputBars.Items.Clear();
      foreach (object obj in this.GetAllowedBarTypeSizeList())
        this.cbxOutputBars.Items.Add(obj);
      if (this.cbxOutputBars.Items.Count > 0)
        this.cbxOutputBars.SelectedIndex = 0;
      this.cbxOutputBars.EndUpdate();
    }

    private void SetAllDataSeriesChecked(bool checked_)
    {
      this.ltvDataSeries.BeginUpdate();
      foreach (ListViewItem listViewItem in this.ltvDataSeries.Items)
        listViewItem.Checked = checked_;
      this.ltvDataSeries.EndUpdate();
    }

    private BarTypeSize[] GetAllowedBarTypeSizeList()
    {
      List<BarTypeSize> list = new List<BarTypeSize>();
      list.Add(new BarTypeSize((BarType) 1, 1L));
      list.Add(new BarTypeSize((BarType) 1, 2L));
      list.Add(new BarTypeSize((BarType) 1, 5L));
      list.Add(new BarTypeSize((BarType) 1, 10L));
      list.Add(new BarTypeSize((BarType) 1, 15L));
      list.Add(new BarTypeSize((BarType) 1, 20L));
      list.Add(new BarTypeSize((BarType) 1, 30L));
      list.Add(new BarTypeSize((BarType) 1, 60L));
      list.Add(new BarTypeSize((BarType) 1, 120L));
      list.Add(new BarTypeSize((BarType) 1, 180L));
      list.Add(new BarTypeSize((BarType) 1, 300L));
      list.Add(new BarTypeSize((BarType) 1, 600L));
      list.Add(new BarTypeSize((BarType) 1, 900L));
      list.Add(new BarTypeSize((BarType) 1, 1200L));
      list.Add(new BarTypeSize((BarType) 1, 1800L));
      list.Add(new BarTypeSize((BarType) 1, 3600L));
      list.Add(new BarTypeSize((BarType) 1, 7200L));
      list.Add(new BarTypeSize((BarType) 1, 10800L));
      list.Add(new BarTypeSize((BarType) 1, 21600L));
      list.Add(new BarTypeSize((BarType) 1, 43200L));
      list.Add(new BarTypeSize((BarType) 1, 86400L));
      list.Add(new BarTypeSize((BarType) 2, 1L));
      list.Add(new BarTypeSize((BarType) 2, 5L));
      list.Add(new BarTypeSize((BarType) 2, 10L));
      list.Add(new BarTypeSize((BarType) 2, 50L));
      list.Add(new BarTypeSize((BarType) 2, 100L));
      list.Add(new BarTypeSize((BarType) 2, 500L));
      list.Add(new BarTypeSize((BarType) 2, 1000L));
      list.Add(new BarTypeSize((BarType) 3, 10L));
      list.Add(new BarTypeSize((BarType) 3, 50L));
      list.Add(new BarTypeSize((BarType) 3, 100L));
      list.Add(new BarTypeSize((BarType) 3, 500L));
      list.Add(new BarTypeSize((BarType) 3, 1000L));
      list.Add(new BarTypeSize((BarType) 3, 5000L));
      list.Add(new BarTypeSize((BarType) 3, 10000L));
      list.Add(new BarTypeSize((BarType) 3, 50000L));
      list.Add(new BarTypeSize((BarType) 3, 100000L));
      list.Add(new BarTypeSize((BarType) 4, 10L));
      list.Add(new BarTypeSize((BarType) 4, 100L));
      list.Add(new BarTypeSize((BarType) 4, 500L));
      list.Add(new BarTypeSize((BarType) 4, 1000L));
      list.Add(new BarTypeSize((BarType) 4, 5000L));
      list.Add(new BarTypeSize((BarType) 4, 10000L));
      if (this.cbxDataSources.SelectedItem != null)
      {
        DataSource dataSource = (DataSource) this.cbxDataSources.SelectedItem;
        if (dataSource.Input == DataSourceInput.Bar)
        {
          BarDataSource barDataSource = (BarDataSource) dataSource;
          int index = 0;
          while (index < list.Count)
          {
            BarTypeSize barTypeSize = list[index];
            if (barTypeSize.BarType == barDataSource.BarType && barTypeSize.BarSize != barDataSource.BarSize && barTypeSize.BarSize % barDataSource.BarSize == 0L)
              ++index;
            else
              list.RemoveAt(index);
          }
        }
      }
      return list.ToArray();
    }

    private void Compress()
    {
      if (this.ltvDataSeries.CheckedItems.Count == 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, "No instruments selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        List<CompressorTask> list = new List<CompressorTask>();
        foreach (DataSeriesViewItem dataSeriesViewItem in this.ltvDataSeries.CheckedItems)
          list.Add(new CompressorTask()
          {
            InputSeries = dataSeriesViewItem.DataSeries,
							Instrument = InstrumentManager.Instruments[DataSeriesHelper.GetDataSeriesInfo(dataSeriesViewItem.DataSeries.Name).Symbol],
            DataSource = (DataSource) this.cbxDataSources.SelectedItem,
            BarTypeSize = (BarTypeSize) this.cbxOutputBars.SelectedItem,
            ExistentDataSeries = (ExistentDataSeries) this.cbxExistentDataSeries.SelectedItem
          });
        CompressorForm compressorForm = new CompressorForm();
        compressorForm.Init(list.ToArray());
        int num2 = (int) compressorForm.ShowDialog((IWin32Window) this);
        compressorForm.Dispose();
      }
    }
  }
}
