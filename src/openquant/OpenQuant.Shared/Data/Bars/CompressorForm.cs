using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using IDataObject = FreeQuant.Data.IDataObject;

namespace OpenQuant.Shared.Data.Bars
{
  internal class CompressorForm : Form
  {
    private IContainer components;
    private ListView ltvTasks;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private Label lblCurrent;
    private ProgressBar pbrCurrent;
    private Label label2;
    private ProgressBar pbrTotal;
    private Button btnClose;
    private ImageList imgTasks;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Button btnStop;
    private List<CompressorTaskItem> taskItems;
    private bool doStop;
    private Dictionary<CompressorTaskItem, CompressorTaskViewItem> taskViewItems;

    public CompressorForm()
    {
      this.InitializeComponent();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CompressorForm));
      this.ltvTasks = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.imgTasks = new ImageList(this.components);
      this.lblCurrent = new Label();
      this.pbrCurrent = new ProgressBar();
      this.label2 = new Label();
      this.pbrTotal = new ProgressBar();
      this.btnClose = new Button();
      this.btnStop = new Button();
      this.SuspendLayout();
      this.ltvTasks.Columns.AddRange(new ColumnHeader[4]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4
      });
      this.ltvTasks.FullRowSelect = true;
      this.ltvTasks.GridLines = true;
      this.ltvTasks.Location = new Point(16, 16);
      this.ltvTasks.MultiSelect = false;
      this.ltvTasks.Name = "ltvTasks";
      this.ltvTasks.ShowGroups = false;
      this.ltvTasks.ShowItemToolTips = true;
      this.ltvTasks.Size = new Size(600, 200);
      this.ltvTasks.SmallImageList = this.imgTasks;
      this.ltvTasks.TabIndex = 0;
      this.ltvTasks.UseCompatibleStateImageBehavior = false;
      this.ltvTasks.View = View.Details;
      this.columnHeader1.Text = "Task";
      this.columnHeader1.Width = 164;
      this.columnHeader2.Text = "Status";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 93;
      this.columnHeader3.Text = "Result";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 90;
      this.columnHeader4.Text = "Message";
      this.columnHeader4.Width = 206;
      this.imgTasks.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imgTasks.ImageStream");
      this.imgTasks.TransparentColor = Color.Transparent;
      this.imgTasks.Images.SetKeyName(0, "wait.png");
      this.imgTasks.Images.SetKeyName(1, "run.png");
      this.imgTasks.Images.SetKeyName(2, "ok.png");
      this.imgTasks.Images.SetKeyName(3, "error.png");
      this.imgTasks.Images.SetKeyName(4, "stop.png");
      this.lblCurrent.Location = new Point(16, 224);
      this.lblCurrent.Name = "lblCurrent";
      this.lblCurrent.Size = new Size(385, 20);
      this.lblCurrent.TabIndex = 1;
      this.lblCurrent.Text = "Current";
      this.lblCurrent.TextAlign = ContentAlignment.MiddleLeft;
      this.pbrCurrent.Location = new Point(16, 248);
      this.pbrCurrent.Name = "pbrCurrent";
      this.pbrCurrent.Size = new Size(600, 20);
      this.pbrCurrent.TabIndex = 2;
      this.label2.Location = new Point(16, 272);
      this.label2.Name = "label2";
      this.label2.Size = new Size(73, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Total";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.pbrTotal.Location = new Point(16, 296);
      this.pbrTotal.Name = "pbrTotal";
      this.pbrTotal.Size = new Size(600, 20);
      this.pbrTotal.TabIndex = 4;
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(393, 329);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(75, 22);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Visible = false;
      this.btnStop.Location = new Point(531, 329);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new Size(75, 22);
      this.btnStop.TabIndex = 6;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new EventHandler(this.btnStop_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(637, 363);
      this.Controls.Add((Control) this.btnStop);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.pbrTotal);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.pbrCurrent);
      this.Controls.Add((Control) this.lblCurrent);
      this.Controls.Add((Control) this.ltvTasks);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CompressorForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Compressor";
      this.ResumeLayout(false);
    }

    public void Init(CompressorTask[] tasks)
    {
      this.taskItems = new List<CompressorTaskItem>();
      foreach (CompressorTask task in tasks)
        this.taskItems.Add(new CompressorTaskItem(task));
    }

    protected override void OnShown(EventArgs e)
    {
      this.taskViewItems = new Dictionary<CompressorTaskItem, CompressorTaskViewItem>();
      this.ltvTasks.BeginUpdate();
      this.ltvTasks.Items.Clear();
      foreach (CompressorTaskItem key in this.taskItems)
      {
        CompressorTaskViewItem compressorTaskViewItem = new CompressorTaskViewItem(key);
        this.taskViewItems.Add(key, compressorTaskViewItem);
        this.ltvTasks.Items.Add((ListViewItem) compressorTaskViewItem);
      }
      this.ltvTasks.EndUpdate();
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.Do));
      base.OnShown(e);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (!this.btnClose.Visible)
        e.Cancel = true;
      base.OnFormClosing(e);
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show((IWin32Window) this, "Do you want to stop operation?", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.doStop = true;
    }

    private void Do(object state)
    {
      try
      {
        this.doStop = false;
        for (int index = 0; index < this.taskItems.Count; ++index)
        {
          this.PerformTask(this.taskItems[index]);
          this.SetTotalProgress((index + 1) * 100 / this.taskItems.Count);
          if (this.doStop)
            break;
        }
        if (this.doStop)
          this.ShowMessageBox("Operation aborted.", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        else
          this.ShowMessageBox("Operation finished.", "Done.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      catch (Exception ex)
      {
        this.ShowMessageBox(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      finally
      {
        this.Finish();
      }
    }

    private void PerformTask(CompressorTaskItem item)
    {
      this.SetCurrentTaskTitle(item.Title);
      this.SetCurrentProgress(0);
      item.Status = CompressorTaskStatus.Processing;
      this.UpdateTaskViewItem(item);
      try
      {
        string str;
				if (item.Task.BarTypeSize.BarType == BarType.Time && item.Task.BarTypeSize.BarSize == 86400)
          str = string.Format("{0}{1}{2}", (object) ((FIXInstrument) item.Task.Instrument).Symbol, '.', "Daily");
        else
          str = string.Format("{0}{1}{2}{1}{3}{1}{4}", (object) ((FIXInstrument) item.Task.Instrument).Symbol, '.', "Bar", item.Task.BarTypeSize.BarType, item.Task.BarTypeSize.BarSize);
        IDataSeries barSeries = DataManager.Server.GetDataSeries(str);
        if (barSeries == null)
        {
          barSeries = DataManager.Server.AddDataSeries(str);
        }
        else
        {
          switch (item.Task.ExistentDataSeries)
          {
            case ExistentDataSeries.Overwrite:
              barSeries.Clear();
              break;
            case ExistentDataSeries.Skip:
              item.Status = CompressorTaskStatus.Done;
              item.Message = "Bar series already exists - task aborted.";
              return;
          }
        }
        int compressedBars = 0;
        BarCompressor compressor = BarCompressor.GetCompressor(item.Task.BarTypeSize, item.Task.DataSource);
        compressor.NewCompressedBar += (EventHandler<CompressedBarEventArgs>) ((sender, args) =>
        {
          barSeries.Update(args.Bar.DateTime, args.Bar);
          ++compressedBars;
        });
        int count = item.Task.InputSeries.Count;
        int num1 = 0;
        for (int index = 0; index < count; ++index)
        {
					IDataObject idataObject = (IDataObject) item.Task.InputSeries[index];
          BarDataItemList items = new BarDataItemList();
          switch (item.Task.DataSource.Input)
          {
            case DataSourceInput.Trade:
              Trade trade = (Trade) idataObject;
              items.Add(new BarDataItem(trade.Price, (long) trade.Size));
              break;
            case DataSourceInput.Bid:
              Quote quote1 = (Quote) idataObject;
              items.Add(new BarDataItem(quote1.Bid, (long) quote1.BidSize));
              break;
            case DataSourceInput.Ask:
              Quote quote2 = (Quote) idataObject;
              items.Add(new BarDataItem(quote2.Ask, (long) quote2.AskSize));
              break;
            case DataSourceInput.BidAsk:
              Quote quote3 = (Quote) idataObject;
              items.Add(new BarDataItem(quote3.Bid, (long) quote3.BidSize));
              items.Add(new BarDataItem(quote3.Ask, (long) quote3.AskSize));
              break;
            case DataSourceInput.Middle:
              Quote quote4 = (Quote) idataObject;
              items.Add(new BarDataItem((quote4.Bid + quote4.Ask) / 2.0, (long) ((quote4.BidSize + quote4.AskSize) / 2)));
              break;
            case DataSourceInput.Spread:
              Quote quote5 = (Quote) idataObject;
              items.Add(new BarDataItem(quote5.Ask - quote5.Bid));
              break;
            case DataSourceInput.Bar:
              Bar bar = (Bar) idataObject;
              items.Add(new BarDataItem(bar.Open, bar.Volume, bar.OpenInt));
              items.Add(new BarDataItem(bar.High));
              items.Add(new BarDataItem(bar.Low));
              items.Add(new BarDataItem(bar.Close));
              break;
          }
          compressor.Add(new CompressorDataItem(idataObject.DateTime, items));
          int num2 = (index + 1) * 100 / count;
          if (num2 > num1)
          {
            num1 = num2;
            this.SetCurrentProgress(num2);
          }
          if (this.doStop)
            break;
        }
        compressor.Flush();
        barSeries.Flush();
        if (this.doStop)
        {
          item.Status = CompressorTaskStatus.Done;
          item.Result = CompressorTaskResult.Error;
          item.Message = "Aborted by user.";
        }
        else
        {
          item.Status = CompressorTaskStatus.Done;
          item.Result = CompressorTaskResult.Success;
          item.Message = string.Format("Compressed: {0} - > {1}", (object) count.ToString("n0"), (object) compressedBars.ToString("n0"));
        }
      }
      catch (Exception ex)
      {
        item.Status = CompressorTaskStatus.Done;
        item.Result = CompressorTaskResult.Error;
        item.Message = ex.Message;
      }
      finally
      {
        this.UpdateTaskViewItem(item);
      }
    }

    private void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
      int num;
			this.Invoke((Action) (() => num = (int) MessageBox.Show((IWin32Window) this, text, caption, buttons, icon)));
    }

    private void Finish()
    {
			this.Invoke((Action) (() =>
      {
        this.btnClose.Location = this.btnStop.Location;
        this.btnStop.Visible = false;
        this.btnClose.Visible = true;
      }));
    }

    private void SetCurrentProgress(int value)
    {
      this.SetProgress(this.pbrCurrent, value);
    }

    private void SetTotalProgress(int value)
    {
      this.SetProgress(this.pbrTotal, value);
    }

    private void SetProgress(ProgressBar progressBar, int value)
    {
			this.Invoke((Action) (() => progressBar.Value = value));
      Thread.Sleep(0);
    }

    private void SetCurrentTaskTitle(string title)
    {
			this.Invoke((Action) (() => this.lblCurrent.Text = title));
    }

    private void UpdateTaskViewItem(CompressorTaskItem item)
    {
			this.Invoke((Action) (() => this.taskViewItems[item].UpdateValues()));
    }
  }
}
