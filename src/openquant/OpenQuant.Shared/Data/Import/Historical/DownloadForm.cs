using OpenQuant.Shared.Instruments;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Historical
{
  public class DownloadForm : Form
  {
    private IHistoricalDataProvider provider;
    private Dictionary<string, HistoricalDataRequest> requests;
    private HistoricalDataRequestDictionary activeRequests;
    private Dictionary<string, DownloadViewItem> items;
    private bool exitUpdateThread;
    private IContainer components;

    private ListView ltvDownload;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Button btnDownload;
    private ImageList images;
    private ContextMenuStrip ctxDownload;
    private ToolStripMenuItem ctxDownload_AddRemoveInstruments;
    private Button btnClose;
    private ProgressBar progressBar;
    private Button btnStop;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private GroupBox gbxSettings;
    private DateTimePicker dtpEnd;
    private DateTimePicker dtpBegin;
    private Label label3;
    private TabPage tabPage2;
    private Label label1;
    private Label label2;
    private ComboBox cbxDataTypes;
    private GroupBox gbxAdvanced;
    private Label label4;
    private TrackBar trbMaxRequests;
    private TextBox tbxMaxRequests;
    private ColumnHeader columnHeader5;
    private ComboBox cbxBarSize;
    private Label lblBarSize;

    public DownloadForm()
    {
      this.InitializeComponent();
      this.requests = new Dictionary<string, HistoricalDataRequest>();
      this.activeRequests = new HistoricalDataRequestDictionary();
      this.items = new Dictionary<string, DownloadViewItem>();
      this.dtpBegin.Value = DateTime.Today.AddDays(-1.0);
      this.dtpEnd.Value = DateTime.Today;
    }

    protected override void OnLoad(EventArgs e)
    {
      // ISSUE: method pointer
			this.provider.NewHistoricalTrade += new HistoricalTradeEventHandler(this.provider_NewHistoricalTrade);
      // ISSUE: method pointer
			this.provider.NewHistoricalQuote += new HistoricalQuoteEventHandler(this.provider_NewHistoricalQuote);
      // ISSUE: method pointer
			this.provider.NewHistoricalBar += new HistoricalBarEventHandler(this.provider_NewHistoricalBar);
      // ISSUE: method pointer
			this.provider.HistoricalDataRequestCompleted += new HistoricalDataEventHandler(this.provider_HistoricalDataRequestCompleted);
      // ISSUE: method pointer
			this.provider.HistoricalDataRequestCancelled += new HistoricalDataEventHandler(this.provider_HistoricalDataRequestCancelled);
      // ISSUE: method pointer
			this.provider.HistoricalDataRequestError += new HistoricalDataErrorEventHandler(this.provider_HistoricalDataRequestError);
      base.OnLoad(e);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (!this.btnClose.Enabled)
      {
        e.Cancel = true;
      }
      else
      {
        // ISSUE: method pointer
				this.provider.NewHistoricalTrade -= new HistoricalTradeEventHandler(this.provider_NewHistoricalTrade);
        // ISSUE: method pointer
				this.provider.NewHistoricalQuote -= new HistoricalQuoteEventHandler(this.provider_NewHistoricalQuote);
        // ISSUE: method pointer
				this.provider.NewHistoricalBar -= new HistoricalBarEventHandler(this.provider_NewHistoricalBar);
        // ISSUE: method pointer
				this.provider.HistoricalDataRequestCompleted -= new HistoricalDataEventHandler(this.provider_HistoricalDataRequestCompleted);
				// ISSUE: method pointere
				this.provider.HistoricalDataRequestCancelled -= new HistoricalDataEventHandler(this.provider_HistoricalDataRequestCancelled);
        // ISSUE: method pointer
				this.provider.HistoricalDataRequestError -=  new HistoricalDataErrorEventHandler(this.provider_HistoricalDataRequestError);
        base.OnFormClosing(e);
      }
    }

    protected override void OnShown(EventArgs e)
    {
      this.AddRemoveInstruments();
      base.OnShown(e);
    }

    public void SetProvider(IHistoricalDataProvider provider)
    {
      this.provider = provider;
      foreach (HistoricalDataType historicalDataType in Enum.GetValues(typeof (HistoricalDataType)))
      {
				if ((int) (byte) (provider.DataType & historicalDataType) == (byte)historicalDataType)
          this.cbxDataTypes.Items.Add(historicalDataType);
      }
      List<long> list = new List<long>();
      if (provider.BarSizes.Length == 0)
      {
        list.Add(1L);
        list.Add(2L);
        list.Add(3L);
        list.Add(5L);
        list.Add(10L);
        list.Add(15L);
        list.Add(20L);
        list.Add(30L);
        list.Add(60L);
        list.Add(120L);
        list.Add(180L);
        list.Add(300L);
        list.Add(600L);
        list.Add(900L);
        list.Add(1200L);
        list.Add(1800L);
        list.Add(3600L);
        list.Add(7200L);
        list.Add(10800L);
        list.Add(21600L);
      }
      else
      {
        foreach (long num in provider.BarSizes)
          list.Add(num);
      }
      list.Sort();
      foreach (long barSize in list)
        this.cbxBarSize.Items.Add(new BarSizeItem(barSize));
      this.trbMaxRequests.Minimum = 1;
      this.trbMaxRequests.Value = 1;
      this.trbMaxRequests.Maximum = provider.MaxConcurrentRequests != -1 ? provider.MaxConcurrentRequests : 5;
      this.tbxMaxRequests.Text = this.trbMaxRequests.Value.ToString();
      this.Text = string.Format("Download Historical Data - {0}",  provider.Name);
      if (this.cbxDataTypes.Items.Count <= 0)
        return;
      this.cbxDataTypes.SelectedIndex = 0;
    }

    private void btnDownload_Click(object sender, EventArgs e)
    {
      if (!this.ValidateDownloadSettings())
        return;
      this.requests.Clear();
      this.items.Clear();
      this.activeRequests.Clear();
      foreach (DownloadViewItem downloadViewItem in this.ltvDownload.Items)
      {
        downloadViewItem.Reset();
        HistoricalDataRequest historicalDataRequest = new HistoricalDataRequest();
				historicalDataRequest.Instrument = (IFIXInstrument) downloadViewItem.Instrument;
				historicalDataRequest.DataType = (HistoricalDataType)this.cbxDataTypes.SelectedItem;
				historicalDataRequest.BeginDate = this.dtpBegin.Value.Date;
				historicalDataRequest.EndDate = this.dtpEnd.Value.Date;
				if (historicalDataRequest.DataType == HistoricalDataType.Bar)
					historicalDataRequest.BarSize = (this.cbxBarSize.SelectedItem as BarSizeItem).BarSize;
        this.requests.Add(historicalDataRequest.RequestId, historicalDataRequest);
        this.items.Add(historicalDataRequest.RequestId, downloadViewItem);
      }
      this.gbxSettings.Enabled = false;
      this.gbxAdvanced.Enabled = false;
      this.btnDownload.Enabled = false;
      this.btnStop.Enabled = true;
      this.btnClose.Enabled = false;
      this.progressBar.Value = 0;
      this.progressBar.Minimum = 0;
      this.progressBar.Maximum = this.requests.Count;
      this.progressBar.Step = 1;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.DownloadThread), this.trbMaxRequests.Value);
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      this.requests.Clear();
      using (List<HistoricalDataRequest>.Enumerator enumerator = new List<HistoricalDataRequest>(this.activeRequests.Values).GetEnumerator())
      {
        while (enumerator.MoveNext())
          this.provider.CancelHistoricalDataRequest(enumerator.Current.RequestId);
      }
    }

    private bool ValidateDownloadSettings()
    {
      string text = null;
      if (this.ltvDownload.Items.Count == 0)
        text = "Please, select instruments.";
      else if (this.cbxDataTypes.SelectedIndex == -1)
        text = "Please, select data type.";
      else if (this.dtpEnd.Value.Date < this.dtpBegin.Value.Date)
        text = "Begin date cannot be greater than end date.";
			if (text == null && (HistoricalDataType)this.cbxDataTypes.SelectedItem == HistoricalDataType.Bar && this.cbxBarSize.SelectedIndex == -1)
        text = "Please, select bar size.";
      if (text != null)
      {
       MessageBox.Show((IWin32Window) this, text, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      return text == null;
    }

    private void DownloadThread(object obj)
    {
      this.exitUpdateThread = false;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.UpdateThread));
      List<HistoricalDataRequest> list = new List<HistoricalDataRequest>((IEnumerable<HistoricalDataRequest>) this.requests.Values);
      int num = (int) obj;
      int index = 0;
      while (true)
      {
        while (this.activeRequests.Count == num)
          Thread.Sleep(1);
        if (index < this.requests.Count)
        {
          HistoricalDataRequest request = list[index];
          ++index;
          this.activeRequests.Add(request.RequestId, request);
          WaitCallback callBack = (WaitCallback) (object_ => this.provider.SendHistoricalDataRequest((HistoricalDataRequest) object_));
          this.SetItemStatus(this.items[request.RequestId], DownloadItemStatus.Downloading);
          ThreadPool.QueueUserWorkItem(callBack, request);
        }
        else
          break;
      }
      while (this.activeRequests.Count > 0)
        Thread.Sleep(1);
      this.exitUpdateThread = true;
      DataManager.Server.Flush();
      this.DownloadCompleted();
    }

    private void UpdateThread(object obj)
    {
      while (!this.exitUpdateThread)
      {
        using (Dictionary<string, DownloadViewItem>.ValueCollection.Enumerator enumerator = this.items.Values.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            DownloadViewItem item = enumerator.Current;
						this.Invoke((Action) (() => item.UpdateProgress()));
          }
        }
        Thread.Sleep(1000);
      }
    }

    private void provider_NewHistoricalTrade(object sender, HistoricalTradeEventArgs args)
    {
      DownloadViewItem downloadViewItem = (DownloadViewItem) null;
      if (!this.items.TryGetValue(((HistoricalDataEventArgs) args).RequestId, out downloadViewItem))
        return;
      downloadViewItem.Instrument.Add(args.Trade);
      this.UpdateDownloadItem(downloadViewItem, (HistoricalDataEventArgs) args);
    }

    private void provider_NewHistoricalQuote(object sender, HistoricalQuoteEventArgs args)
    {
      DownloadViewItem downloadViewItem = (DownloadViewItem) null;
      if (!this.items.TryGetValue(((HistoricalDataEventArgs) args).RequestId, out downloadViewItem))
        return;
      downloadViewItem.Instrument.Add(args.Quote);
      this.UpdateDownloadItem(downloadViewItem, (HistoricalDataEventArgs) args);
    }

    private void provider_NewHistoricalBar(object sender, HistoricalBarEventArgs args)
    {
      DownloadViewItem downloadViewItem = (DownloadViewItem) null;
      if (!this.items.TryGetValue(((HistoricalDataEventArgs) args).RequestId, out downloadViewItem))
        return;
      if (args.Bar is Daily)
        downloadViewItem.Instrument.Add(args.Bar as Daily);
      else
        downloadViewItem.Instrument.Add(args.Bar);
      this.UpdateDownloadItem(downloadViewItem, (HistoricalDataEventArgs) args);
    }

    private void provider_HistoricalDataRequestCompleted(object sender, HistoricalDataEventArgs args)
    {
      DownloadViewItem downloadViewItem = (DownloadViewItem) null;
      if (!this.items.TryGetValue(args.RequestId, out downloadViewItem))
        return;
      this.SetItemStatus(downloadViewItem, DownloadItemStatus.Done);
      this.UpdateProgressBar();
      this.activeRequests.Remove(args.RequestId);
    }

    private void provider_HistoricalDataRequestCancelled(object sender, HistoricalDataEventArgs args)
    {
      DownloadViewItem downloadViewItem = (DownloadViewItem) null;
      if (!this.items.TryGetValue(args.RequestId, out downloadViewItem))
        return;
      this.SetItemStatus(downloadViewItem, DownloadItemStatus.Cancelled);
      this.activeRequests.Remove(args.RequestId);
    }

    private void provider_HistoricalDataRequestError(object sender, HistoricalDataErrorEventArgs args)
    {
      DownloadViewItem downloadViewItem = (DownloadViewItem) null;
      if (!this.items.TryGetValue(((HistoricalDataEventArgs) args).RequestId, out downloadViewItem))
        return;
      this.SetItemStatus(downloadViewItem, DownloadItemStatus.Error);
      this.SetItemMessage(downloadViewItem, args.Message);
      this.UpdateProgressBar();
      this.activeRequests.Remove(((HistoricalDataEventArgs) args).RequestId);
    }

    private void UpdateDownloadItem(DownloadViewItem item, HistoricalDataEventArgs args)
    {
      ++item.Count;
      item.Total = args.DataLength <= 0 ? item.Count : args.DataLength;
      Thread.Sleep(0);
    }

    private void SetItemStatus(DownloadViewItem item, DownloadItemStatus status)
    {
      item.Status = status;
			this.Invoke((Action) (() => item.UpdateStatus()));
      Thread.Sleep(0);
    }

    private void SetItemMessage(DownloadViewItem item, string message)
    {
      item.Message = message;
			this.Invoke((Action) (() => item.UpdateMessage()));
      Thread.Sleep(0);
    }

    private void UpdateProgressBar()
    {
			this.Invoke((Action) (() => this.progressBar.PerformStep()));
    }

    private void DownloadCompleted()
    {
			this.Invoke((Action) (() =>
      {
        foreach (DownloadViewItem item_0 in this.items.Values)
          item_0.UpdateProgress();
        this.gbxSettings.Enabled = true;
        this.gbxAdvanced.Enabled = true;
        this.btnDownload.Enabled = true;
        this.btnStop.Enabled = false;
        this.btnClose.Enabled = true;
      }));
    }

    private void ctxDownload_Opening(object sender, CancelEventArgs e)
    {
      this.ctxDownload_AddRemoveInstruments.Enabled = this.btnClose.Enabled;
    }

    private void ctxDownload_AddRemoveInstruments_Click(object sender, EventArgs e)
    {
      this.AddRemoveInstruments();
    }

    private void AddRemoveInstruments()
    {
      List<Instrument> list = new List<Instrument>();
      foreach (DownloadViewItem downloadViewItem in this.ltvDownload.Items)
        list.Add(downloadViewItem.Instrument);
      InstrumentSelectorDialog instrumentSelectorDialog = new InstrumentSelectorDialog();
      instrumentSelectorDialog.Instruments = InstrumentManager.Instruments;
      instrumentSelectorDialog.SelectedInstruments = list.ToArray();
      if (instrumentSelectorDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        this.ltvDownload.BeginUpdate();
        this.ltvDownload.Items.Clear();
        foreach (Instrument instrument in instrumentSelectorDialog.SelectedInstruments)
          this.ltvDownload.Items.Add((ListViewItem) new DownloadViewItem(instrument));
        this.ltvDownload.EndUpdate();
      }
      instrumentSelectorDialog.Dispose();
    }

    private void trbMaxRequests_ValueChanged(object sender, EventArgs e)
    {
      this.tbxMaxRequests.Text = this.trbMaxRequests.Value.ToString();
    }

    private void cbxDataTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
			if ((HistoricalDataType) this.cbxDataTypes.SelectedItem == HistoricalDataType.Bar)
      {
        this.lblBarSize.Enabled = true;
        this.cbxBarSize.Enabled = true;
        if (this.cbxBarSize.Items.Count <= 0 || this.cbxBarSize.SelectedIndex != -1)
          return;
        this.cbxBarSize.SelectedIndex = 0;
      }
      else
      {
        this.lblBarSize.Enabled = false;
        this.cbxBarSize.Enabled = false;
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


      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DownloadForm));
      this.ltvDownload = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.ctxDownload = new ContextMenuStrip(this.components);
      this.ctxDownload_AddRemoveInstruments = new ToolStripMenuItem();
      this.images = new ImageList(this.components);
      this.btnDownload = new Button();
      this.btnClose = new Button();
      this.progressBar = new ProgressBar();
      this.btnStop = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.gbxSettings = new GroupBox();
      this.cbxBarSize = new ComboBox();
      this.lblBarSize = new Label();
      this.cbxDataTypes = new ComboBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.dtpEnd = new DateTimePicker();
      this.dtpBegin = new DateTimePicker();
      this.label3 = new Label();
      this.tabPage2 = new TabPage();
      this.gbxAdvanced = new GroupBox();
      this.trbMaxRequests = new TrackBar();
      this.tbxMaxRequests = new TextBox();
      this.label4 = new Label();
      this.ctxDownload.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.gbxSettings.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.gbxAdvanced.SuspendLayout();
      this.trbMaxRequests.BeginInit();
      this.SuspendLayout();
      this.ltvDownload.Columns.AddRange(new ColumnHeader[5]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5
      });
      this.ltvDownload.ContextMenuStrip = this.ctxDownload;
      this.ltvDownload.FullRowSelect = true;
      this.ltvDownload.GridLines = true;
      this.ltvDownload.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvDownload.HideSelection = false;
      this.ltvDownload.Location = new Point(8, 104);
      this.ltvDownload.MultiSelect = false;
      this.ltvDownload.Name = "ltvDownload";
      this.ltvDownload.ShowGroups = false;
      this.ltvDownload.ShowItemToolTips = true;
      this.ltvDownload.Size = new Size(510, 217);
      this.ltvDownload.SmallImageList = this.images;
      this.ltvDownload.TabIndex = 0;
      this.ltvDownload.UseCompatibleStateImageBehavior = false;
      this.ltvDownload.View = View.Details;
      this.columnHeader1.Text = "Symbol";
      this.columnHeader1.Width = 96;
      this.columnHeader2.Text = "Status";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 92;
      this.columnHeader3.Text = "Count";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 101;
      this.columnHeader4.Text = "Total";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 103;
      this.columnHeader5.Text = "Message";
      this.columnHeader5.Width = 91;
      this.ctxDownload.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ctxDownload_AddRemoveInstruments
      });
      this.ctxDownload.Name = "ctxDownload";
      this.ctxDownload.Size = new Size(235, 48);
      this.ctxDownload.Opening += new CancelEventHandler(this.ctxDownload_Opening);
      this.ctxDownload_AddRemoveInstruments.Image = (Image) componentResourceManager.GetObject("ctxDownload_AddRemoveInstruments.Image");
      this.ctxDownload_AddRemoveInstruments.Name = "ctxDownload_AddRemoveInstruments";
      this.ctxDownload_AddRemoveInstruments.Size = new Size(234, 22);
      this.ctxDownload_AddRemoveInstruments.Text = "Add Or Remove Instruments...";
      this.ctxDownload_AddRemoveInstruments.Click += new EventHandler(this.ctxDownload_AddRemoveInstruments_Click);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "gear_time.png");
      this.images.Images.SetKeyName(1, "gear_run.png");
      this.images.Images.SetKeyName(2, "gear_ok.png");
      this.images.Images.SetKeyName(3, "gear_error.png");
      this.images.Images.SetKeyName(4, "gear_warning.png");
      this.btnDownload.Location = new Point(536, 104);
      this.btnDownload.Name = "btnDownload";
      this.btnDownload.Size = new Size(80, 22);
      this.btnDownload.TabIndex = 1;
      this.btnDownload.Text = "Download";
      this.btnDownload.UseVisualStyleBackColor = true;
      this.btnDownload.Click += new EventHandler(this.btnDownload_Click);
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(536, 302);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(80, 22);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.progressBar.Location = new Point(8, 335);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new Size(510, 17);
      this.progressBar.TabIndex = 4;
      this.btnStop.Enabled = false;
      this.btnStop.Location = new Point(536, 136);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new Size(80, 22);
      this.btnStop.TabIndex = 5;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new EventHandler(this.btnStop_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(8, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(624, 90);
      this.tabControl1.TabIndex = 6;
      this.tabPage1.Controls.Add((Control) this.gbxSettings);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Size = new Size(616, 64);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Settings";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.gbxSettings.Controls.Add((Control) this.cbxBarSize);
      this.gbxSettings.Controls.Add((Control) this.lblBarSize);
      this.gbxSettings.Controls.Add((Control) this.cbxDataTypes);
      this.gbxSettings.Controls.Add((Control) this.label1);
      this.gbxSettings.Controls.Add((Control) this.label2);
      this.gbxSettings.Controls.Add((Control) this.dtpEnd);
      this.gbxSettings.Controls.Add((Control) this.dtpBegin);
      this.gbxSettings.Controls.Add((Control) this.label3);
      this.gbxSettings.Dock = DockStyle.Fill;
      this.gbxSettings.Location = new Point(0, 0);
      this.gbxSettings.Name = "gbxSettings";
      this.gbxSettings.Size = new Size(616, 64);
      this.gbxSettings.TabIndex = 3;
      this.gbxSettings.TabStop = false;
      this.cbxBarSize.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxBarSize.Enabled = false;
      this.cbxBarSize.FormattingEnabled = true;
      this.cbxBarSize.Location = new Point(72, 36);
      this.cbxBarSize.MaxLength = 10;
      this.cbxBarSize.Name = "cbxBarSize";
      this.cbxBarSize.Size = new Size(100, 21);
      this.cbxBarSize.TabIndex = 12;
      this.lblBarSize.Enabled = false;
      this.lblBarSize.Location = new Point(8, 36);
      this.lblBarSize.Name = "lblBarSize";
      this.lblBarSize.Size = new Size(63, 20);
      this.lblBarSize.TabIndex = 11;
      this.lblBarSize.Text = "Bar Size";
      this.lblBarSize.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxDataTypes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxDataTypes.FormattingEnabled = true;
      this.cbxDataTypes.Location = new Point(72, 12);
      this.cbxDataTypes.Name = "cbxDataTypes";
      this.cbxDataTypes.Size = new Size(100, 21);
      this.cbxDataTypes.Sorted = true;
      this.cbxDataTypes.TabIndex = 10;
      this.cbxDataTypes.SelectedIndexChanged += new EventHandler(this.cbxDataTypes_SelectedIndexChanged);
      this.label1.Location = new Point(8, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(63, 20);
      this.label1.TabIndex = 9;
      this.label1.Text = "Data type";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(192, 12);
      this.label2.Name = "label2";
      this.label2.Size = new Size(63, 20);
      this.label2.TabIndex = 7;
      this.label2.Text = "Begin date";
      this.label2.TextAlign = ContentAlignment.MiddleRight;
      this.dtpEnd.Format = DateTimePickerFormat.Short;
      this.dtpEnd.Location = new Point(268, 36);
      this.dtpEnd.Name = "dtpEnd";
      this.dtpEnd.Size = new Size(107, 20);
      this.dtpEnd.TabIndex = 5;
      this.dtpBegin.Format = DateTimePickerFormat.Short;
      this.dtpBegin.Location = new Point(268, 12);
      this.dtpBegin.Name = "dtpBegin";
      this.dtpBegin.Size = new Size(107, 20);
      this.dtpBegin.TabIndex = 4;
      this.dtpBegin.Value = new DateTime(1980, 1, 1, 0, 0, 0, 0);
      this.label3.Location = new Point(192, 36);
      this.label3.Name = "label3";
      this.label3.Size = new Size(63, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "End date";
      this.label3.TextAlign = ContentAlignment.MiddleRight;
      this.tabPage2.Controls.Add((Control) this.gbxAdvanced);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Size = new Size(616, 64);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Advanced";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.gbxAdvanced.Controls.Add((Control) this.trbMaxRequests);
      this.gbxAdvanced.Controls.Add((Control) this.tbxMaxRequests);
      this.gbxAdvanced.Controls.Add((Control) this.label4);
      this.gbxAdvanced.Dock = DockStyle.Fill;
      this.gbxAdvanced.Location = new Point(0, 0);
      this.gbxAdvanced.Name = "gbxAdvanced";
      this.gbxAdvanced.Size = new Size(616, 64);
      this.gbxAdvanced.TabIndex = 0;
      this.gbxAdvanced.TabStop = false;
      this.trbMaxRequests.AutoSize = false;
      this.trbMaxRequests.Location = new Point(8, 36);
      this.trbMaxRequests.Name = "trbMaxRequests";
      this.trbMaxRequests.Size = new Size(168, 20);
      this.trbMaxRequests.TabIndex = 12;
      this.trbMaxRequests.ValueChanged += new EventHandler(this.trbMaxRequests_ValueChanged);
      this.tbxMaxRequests.Location = new Point(144, 12);
      this.tbxMaxRequests.Name = "tbxMaxRequests";
      this.tbxMaxRequests.ReadOnly = true;
      this.tbxMaxRequests.Size = new Size(32, 20);
      this.tbxMaxRequests.TabIndex = 11;
      this.tbxMaxRequests.TextAlign = HorizontalAlignment.Center;
      this.label4.Location = new Point(8, 12);
      this.label4.Name = "label4";
      this.label4.Size = new Size(140, 20);
      this.label4.TabIndex = 10;
      this.label4.Text = "Max. concurrent requests";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(634, 360);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.btnStop);
      this.Controls.Add((Control) this.progressBar);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnDownload);
      this.Controls.Add((Control) this.ltvDownload);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DownloadForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Download Historical Data";
      this.ctxDownload.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.gbxSettings.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.gbxAdvanced.ResumeLayout(false);
      this.gbxAdvanced.PerformLayout();
      this.trbMaxRequests.EndInit();
      this.ResumeLayout(false);
    }
  }
}
