using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
  internal class ImportPage : WizardPage
  {
    private Engine engine;
    private ToolBar toolBar;
    private ImageList images;
    private ToolBarButton tbbStart;
    private ToolBarButton tbbPause;
    private ToolBarButton tbbStop;
    private ImageList images2;
    private ListView ltvFiles;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private GroupBox groupBox1;
    private Panel panel2;
    private ProgressBar progressTotal;
    private Label label2;
    private Panel panel1;
    private ProgressBar progressCurrent;
    private Label label1;
    private ToolBarButton toolBarButton1;
    private ToolBarButton tbbTest;
    private IContainer components;

    public override bool CanBack
    {
      get
      {
        if (this.engine.State != EngineState.Stopped)
          return this.engine.State == EngineState.Finished;
        else
          return true;
      }
    }

    public override bool CanNext
    {
      get
      {
        return false;
      }
    }

    public override bool CanClose
    {
      get
      {
        if (this.engine.State != EngineState.Stopped)
          return this.engine.State == EngineState.Finished;
        else
          return true;
      }
    }

    public override string Title
    {
      get
      {
        return "Process File(s)";
      }
    }

    public ImportPage()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ImportPage));
      this.toolBar = new ToolBar();
      this.tbbStart = new ToolBarButton();
      this.tbbPause = new ToolBarButton();
      this.tbbStop = new ToolBarButton();
      this.toolBarButton1 = new ToolBarButton();
      this.tbbTest = new ToolBarButton();
      this.images = new ImageList(this.components);
      this.images2 = new ImageList(this.components);
      this.ltvFiles = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.groupBox1 = new GroupBox();
      this.panel2 = new Panel();
      this.progressTotal = new ProgressBar();
      this.label2 = new Label();
      this.panel1 = new Panel();
      this.progressCurrent = new ProgressBar();
      this.label1 = new Label();
      this.groupBox1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.toolBar.Appearance = ToolBarAppearance.Flat;
      this.toolBar.Buttons.AddRange(new ToolBarButton[5]
      {
        this.tbbStart,
        this.tbbPause,
        this.tbbStop,
        this.toolBarButton1,
        this.tbbTest
      });
      this.toolBar.DropDownArrows = true;
      this.toolBar.ImageList = this.images;
      this.toolBar.Location = new Point(0, 0);
      this.toolBar.Name = "toolBar";
      this.toolBar.ShowToolTips = true;
      this.toolBar.Size = new Size(488, 28);
      this.toolBar.TabIndex = 3;
      this.toolBar.ButtonClick += new ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
      this.tbbStart.ImageIndex = 0;
      this.tbbStart.Name = "tbbStart";
      this.tbbStart.ToolTipText = "Start";
      this.tbbPause.ImageIndex = 1;
      this.tbbPause.Name = "tbbPause";
      this.tbbPause.ToolTipText = "Pause";
      this.tbbStop.ImageIndex = 2;
      this.tbbStop.Name = "tbbStop";
      this.tbbStop.ToolTipText = "Stop";
      this.toolBarButton1.Name = "toolBarButton1";
      this.toolBarButton1.Style = ToolBarButtonStyle.Separator;
      this.tbbTest.ImageIndex = 3;
      this.tbbTest.Name = "tbbTest";
      this.tbbTest.ToolTipText = "Test files only";
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "");
      this.images.Images.SetKeyName(1, "");
      this.images.Images.SetKeyName(2, "");
      this.images.Images.SetKeyName(3, "");
      this.images2.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images2.ImageStream");
      this.images2.TransparentColor = Color.Transparent;
      this.images2.Images.SetKeyName(0, "");
      this.images2.Images.SetKeyName(1, "");
      this.images2.Images.SetKeyName(2, "");
      this.images2.Images.SetKeyName(3, "");
      this.images2.Images.SetKeyName(4, "");
      this.images2.Images.SetKeyName(5, "");
      this.ltvFiles.BorderStyle = BorderStyle.None;
      this.ltvFiles.Columns.AddRange(new ColumnHeader[3]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3
      });
      this.ltvFiles.Dock = DockStyle.Fill;
      this.ltvFiles.FullRowSelect = true;
      this.ltvFiles.GridLines = true;
      this.ltvFiles.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvFiles.Location = new Point(0, 92);
      this.ltvFiles.Name = "ltvFiles";
      this.ltvFiles.Size = new Size(488, 348);
      this.ltvFiles.SmallImageList = this.images2;
      this.ltvFiles.Sorting = SortOrder.Ascending;
      this.ltvFiles.TabIndex = 1;
      this.ltvFiles.UseCompatibleStateImageBehavior = false;
      this.ltvFiles.View = View.Details;
      this.columnHeader1.Text = "File";
      this.columnHeader1.Width = 169;
      this.columnHeader2.Text = "Status";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 103;
      this.columnHeader3.Text = "Object Count";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 145;
      this.groupBox1.Controls.Add((Control) this.panel2);
      this.groupBox1.Controls.Add((Control) this.panel1);
      this.groupBox1.Dock = DockStyle.Top;
      this.groupBox1.Location = new Point(0, 28);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(488, 64);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Progress";
      this.panel2.Controls.Add((Control) this.progressTotal);
      this.panel2.Controls.Add((Control) this.label2);
      this.panel2.Dock = DockStyle.Top;
      this.panel2.Location = new Point(3, 36);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(482, 20);
      this.panel2.TabIndex = 1;
      this.progressTotal.Dock = DockStyle.Fill;
      this.progressTotal.Location = new Point(80, 0);
      this.progressTotal.Name = "progressTotal";
      this.progressTotal.Size = new Size(402, 20);
      this.progressTotal.TabIndex = 1;
      this.label2.Dock = DockStyle.Left;
      this.label2.Location = new Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(80, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Total";
      this.label2.TextAlign = ContentAlignment.MiddleCenter;
      this.panel1.Controls.Add((Control) this.progressCurrent);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(3, 16);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(482, 20);
      this.panel1.TabIndex = 0;
      this.progressCurrent.Dock = DockStyle.Fill;
      this.progressCurrent.Location = new Point(80, 0);
      this.progressCurrent.Name = "progressCurrent";
      this.progressCurrent.Size = new Size(402, 20);
      this.progressCurrent.TabIndex = 1;
      this.label1.Dock = DockStyle.Left;
      this.label1.Location = new Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(80, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Current file";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.Controls.Add((Control) this.ltvFiles);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.toolBar);
      this.Name = "ImportPage";
      this.Size = new Size(488, 440);
      this.groupBox1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public override void BeforeLoad()
    {
      this.ltvFiles.BeginUpdate();
      this.ltvFiles.Items.Clear();
      foreach (FileInfo file in this.settings.Files)
        this.ltvFiles.Items.Add((ListViewItem) new FileViewItem(file));
      this.ltvFiles.EndUpdate();
      this.progressCurrent.Value = 0;
      this.progressTotal.Maximum = this.settings.Files.Length;
      this.progressTotal.Value = 0;
      this.engine = Engine.GetEngine(this.settings.Template.DataOptions.DataType);
      this.engine.StateChanged += new EventHandler(this.OnEngineStateChanged);
      this.engine.Error += new EventHandler<ErrorEventArgs>(this.OnEngineError);
      this.engine.TotalProgress += new EventHandler<ProgressEventArgs>(this.OnTotalProgress);
      this.engine.CurrentFileProgress += new EventHandler<ProgressEventArgs>(this.OnCurrentFileProgress);
      this.engine.FileStatusChanged += new EventHandler<FileEventArgs>(this.OnFileStatusChanged);
      this.UpdateControlStatus();
    }

    public override void BeforeBack()
    {
      this.engine.Finish();
    }

    public override void BeforeClose()
    {
      this.engine.Finish();
    }

    private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
      if (e.Button == this.tbbStart)
        this.Start(true);
      else if (e.Button == this.tbbPause)
        this.Pause();
      else if (e.Button == this.tbbStop)
      {
        this.Stop();
      }
      else
      {
        if (e.Button != this.tbbTest)
          throw new NotSupportedException("Unknown button clicked!");
        this.Start(false);
      }
    }

    private void Start(bool storeObjects)
    {
      if (this.engine.State == EngineState.Paused)
      {
        this.engine.Continue();
      }
      else
      {
        this.ltvFiles.BeginUpdate();
        foreach (FileViewItem fileViewItem in this.ltvFiles.Items)
        {
          fileViewItem.SetFileStatus(FileStatus.Waiting);
          fileViewItem.SetObjectCount(-1);
        }
        this.ltvFiles.EndUpdate();
        this.engine.Start(this.settings.Files, this.settings.Template, storeObjects);
      }
    }

    private void Stop()
    {
      this.engine.Stop();
    }

    private void Pause()
    {
      this.engine.Pause();
    }

    private void OnEngineStateChanged(object sender, EventArgs e)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EventHandler(this.OnEngineStateChanged), sender, (object) e);
      else
        this.UpdateControlStatus();
    }

    private void UpdateControlStatus()
    {
      switch (this.engine.State)
      {
        case EngineState.Running:
          this.tbbStart.Enabled = false;
          this.tbbPause.Enabled = true;
          this.tbbStop.Enabled = true;
          this.tbbTest.Enabled = false;
          break;
        case EngineState.Paused:
          this.tbbStart.Enabled = true;
          this.tbbPause.Enabled = false;
          this.tbbStop.Enabled = true;
          this.tbbTest.Enabled = false;
          break;
        case EngineState.Stopped:
          this.tbbStart.Enabled = true;
          this.tbbPause.Enabled = false;
          this.tbbStop.Enabled = false;
          this.tbbTest.Enabled = true;
          break;
        default:
          throw new ArgumentException("Unknown engine state - " + ((object) this.engine.State).ToString());
      }
      this.EmitButtonEnabledChanged();
    }

    private FileViewItem GetFileViewItem(FileInfo file)
    {
      foreach (FileViewItem fileViewItem in this.ltvFiles.Items)
      {
        if (fileViewItem.File == file)
          return fileViewItem;
      }
      return (FileViewItem) null;
    }

    private void OnEngineError(object sender, ErrorEventArgs args)
    {
      Action action = (Action) (() =>
      {
        ErrorDialog local_0 = new ErrorDialog();
        local_0.SetError(this.settings.Template, args);
        int temp_25 = (int) local_0.ShowDialog((IWin32Window) this);
        switch (local_0.DialogResult)
        {
          case ErrorDialog.Result.Stop:
            this.engine.Stop();
            break;
          case ErrorDialog.Result.SkipFile:
            this.engine.SkipCurrentFile();
            break;
        }
        local_0.Dispose();
      });
      if (this.InvokeRequired)
        this.Invoke((Delegate) action);
      else
        action();
    }

    private void OnTotalProgress(object sender, ProgressEventArgs args)
    {
      Action action = (Action) (() => this.progressTotal.Value = args.Progress);
      if (this.InvokeRequired)
        this.Invoke((Delegate) action);
      else
        action();
    }

    private void OnCurrentFileProgress(object sender, ProgressEventArgs args)
    {
      Action action = (Action) (() => this.progressCurrent.Value = args.Progress);
      if (this.InvokeRequired)
        this.Invoke((Delegate) action);
      else
        action();
    }

    private void OnFileStatusChanged(object sender, FileEventArgs args)
    {
      Action action = (Action) (() =>
      {
        FileViewItem local_0 = this.GetFileViewItem(args.File);
        local_0.SetFileStatus(args.Status);
        switch (args.Status)
        {
          case FileStatus.Importing:
          case FileStatus.Testing:
            local_0.EnsureVisible();
            break;
          case FileStatus.DoneOk:
          case FileStatus.DoneError:
          case FileStatus.Aborted:
            local_0.SetObjectCount(args.ObjectCount);
            break;
          default:
            throw new ArgumentException("Unknown file status - " + ((object) args.Status).ToString());
        }
      });
      if (this.InvokeRequired)
        this.Invoke((Delegate) action);
      else
        action();
    }
  }
}
