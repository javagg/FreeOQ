// Type: SmartQuant.Shared.Data.Import.CSV.ImportPage
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class ImportPage : WizardPage
  {
    private Engine mffR0pTFbp;
    private ToolBar lUNRpNni6Y;
    private ImageList WcMRNfr2vQ;
    private ToolBarButton fvqRt7yS76;
    private ToolBarButton YC9RE7fOsa;
    private ToolBarButton gYZRQJ5efI;
    private ImageList H7fRvwKQ02;
    private ListView ReeRok5rPP;
    private ColumnHeader hHfRP2lx2R;
    private ColumnHeader pkCRAhIcyE;
    private ColumnHeader q1qRBUehtO;
    private GroupBox hRERcX8NvI;
    private Panel xANRz8Z8ug;
    private ProgressBar TONHeFCpxk;
    private Label fqZHhE2IWI;
    private Panel ggWHsyDJBL;
    private ProgressBar GYvHYf2fVV;
    private Label arRHx7YDDK;
    private ToolBarButton YtxHDJTZwW;
    private ToolBarButton V9tH1RyckD;
    private IContainer unLHdFZDkc;

    public override bool CanBack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.mffR0pTFbp.State != EngineState.Stopped)
          return this.mffR0pTFbp.State == EngineState.Finished;
        else
          return true;
      }
    }

    public override bool CanNext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return false;
      }
    }

    public override bool CanClose
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.mffR0pTFbp.State != EngineState.Stopped)
          return this.mffR0pTFbp.State == EngineState.Finished;
        else
          return true;
      }
    }

    public override string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return RNaihRhYEl0wUmAftnB.aYu7exFQKN(18554);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImportPage()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.lMERju2uCa();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.unLHdFZDkc != null)
        this.unLHdFZDkc.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lMERju2uCa()
    {
      this.unLHdFZDkc = (IContainer) new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (ImportPage));
      this.lUNRpNni6Y = new ToolBar();
      this.fvqRt7yS76 = new ToolBarButton();
      this.YC9RE7fOsa = new ToolBarButton();
      this.gYZRQJ5efI = new ToolBarButton();
      this.YtxHDJTZwW = new ToolBarButton();
      this.V9tH1RyckD = new ToolBarButton();
      this.WcMRNfr2vQ = new ImageList(this.unLHdFZDkc);
      this.H7fRvwKQ02 = new ImageList(this.unLHdFZDkc);
      this.ReeRok5rPP = new ListView();
      this.hHfRP2lx2R = new ColumnHeader();
      this.pkCRAhIcyE = new ColumnHeader();
      this.q1qRBUehtO = new ColumnHeader();
      this.hRERcX8NvI = new GroupBox();
      this.xANRz8Z8ug = new Panel();
      this.TONHeFCpxk = new ProgressBar();
      this.fqZHhE2IWI = new Label();
      this.ggWHsyDJBL = new Panel();
      this.GYvHYf2fVV = new ProgressBar();
      this.arRHx7YDDK = new Label();
      this.hRERcX8NvI.SuspendLayout();
      this.xANRz8Z8ug.SuspendLayout();
      this.ggWHsyDJBL.SuspendLayout();
      this.SuspendLayout();
      this.lUNRpNni6Y.Appearance = ToolBarAppearance.Flat;
      this.lUNRpNni6Y.Buttons.AddRange(new ToolBarButton[5]
      {
        this.fvqRt7yS76,
        this.YC9RE7fOsa,
        this.gYZRQJ5efI,
        this.YtxHDJTZwW,
        this.V9tH1RyckD
      });
      this.lUNRpNni6Y.DropDownArrows = true;
      this.lUNRpNni6Y.ImageList = this.WcMRNfr2vQ;
      this.lUNRpNni6Y.Location = new Point(0, 0);
      this.lUNRpNni6Y.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18068);
      this.lUNRpNni6Y.ShowToolTips = true;
      this.lUNRpNni6Y.Size = new Size(488, 28);
      this.lUNRpNni6Y.TabIndex = 3;
      this.lUNRpNni6Y.ButtonClick += new ToolBarButtonClickEventHandler(this.va6R69T5uI);
      this.fvqRt7yS76.ImageIndex = 0;
      this.fvqRt7yS76.ToolTipText = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18086);
      this.YC9RE7fOsa.ImageIndex = 1;
      this.YC9RE7fOsa.ToolTipText = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18100);
      this.gYZRQJ5efI.ImageIndex = 2;
      this.gYZRQJ5efI.ToolTipText = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18114);
      this.YtxHDJTZwW.Style = ToolBarButtonStyle.Separator;
      this.V9tH1RyckD.ImageIndex = 3;
      this.V9tH1RyckD.ToolTipText = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18126);
      this.WcMRNfr2vQ.ImageSize = new Size(16, 16);
      this.WcMRNfr2vQ.ImageStream = (ImageListStreamer) resourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(18160));
      this.WcMRNfr2vQ.TransparentColor = Color.Transparent;
      this.H7fRvwKQ02.ImageSize = new Size(16, 16);
      this.H7fRvwKQ02.ImageStream = (ImageListStreamer) resourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(18200));
      this.H7fRvwKQ02.TransparentColor = Color.Transparent;
      this.ReeRok5rPP.BorderStyle = BorderStyle.None;
      this.ReeRok5rPP.Columns.AddRange(new ColumnHeader[3]
      {
        this.hHfRP2lx2R,
        this.pkCRAhIcyE,
        this.q1qRBUehtO
      });
      this.ReeRok5rPP.Dock = DockStyle.Fill;
      this.ReeRok5rPP.FullRowSelect = true;
      this.ReeRok5rPP.GridLines = true;
      this.ReeRok5rPP.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ReeRok5rPP.Location = new Point(0, 92);
      this.ReeRok5rPP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18242);
      this.ReeRok5rPP.Size = new Size(488, 348);
      this.ReeRok5rPP.SmallImageList = this.H7fRvwKQ02;
      this.ReeRok5rPP.Sorting = SortOrder.Ascending;
      this.ReeRok5rPP.TabIndex = 1;
      this.ReeRok5rPP.View = View.Details;
      this.hHfRP2lx2R.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18262);
      this.hHfRP2lx2R.Width = 108;
      this.pkCRAhIcyE.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18274);
      this.pkCRAhIcyE.TextAlign = HorizontalAlignment.Right;
      this.pkCRAhIcyE.Width = 91;
      this.q1qRBUehtO.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18290);
      this.q1qRBUehtO.TextAlign = HorizontalAlignment.Right;
      this.q1qRBUehtO.Width = 92;
      this.hRERcX8NvI.Controls.Add((Control) this.xANRz8Z8ug);
      this.hRERcX8NvI.Controls.Add((Control) this.ggWHsyDJBL);
      this.hRERcX8NvI.Dock = DockStyle.Top;
      this.hRERcX8NvI.Location = new Point(0, 28);
      this.hRERcX8NvI.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18318);
      this.hRERcX8NvI.Size = new Size(488, 64);
      this.hRERcX8NvI.TabIndex = 2;
      this.hRERcX8NvI.TabStop = false;
      this.hRERcX8NvI.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18340);
      this.xANRz8Z8ug.Controls.Add((Control) this.TONHeFCpxk);
      this.xANRz8Z8ug.Controls.Add((Control) this.fqZHhE2IWI);
      this.xANRz8Z8ug.Dock = DockStyle.Top;
      this.xANRz8Z8ug.Location = new Point(3, 36);
      this.xANRz8Z8ug.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18360);
      this.xANRz8Z8ug.Size = new Size(482, 20);
      this.xANRz8Z8ug.TabIndex = 1;
      this.TONHeFCpxk.Dock = DockStyle.Fill;
      this.TONHeFCpxk.Location = new Point(80, 0);
      this.TONHeFCpxk.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18376);
      this.TONHeFCpxk.Size = new Size(402, 20);
      this.TONHeFCpxk.TabIndex = 1;
      this.fqZHhE2IWI.Dock = DockStyle.Left;
      this.fqZHhE2IWI.Location = new Point(0, 0);
      this.fqZHhE2IWI.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18406);
      this.fqZHhE2IWI.Size = new Size(80, 20);
      this.fqZHhE2IWI.TabIndex = 0;
      this.fqZHhE2IWI.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18422);
      this.fqZHhE2IWI.TextAlign = ContentAlignment.MiddleCenter;
      this.ggWHsyDJBL.Controls.Add((Control) this.GYvHYf2fVV);
      this.ggWHsyDJBL.Controls.Add((Control) this.arRHx7YDDK);
      this.ggWHsyDJBL.Dock = DockStyle.Top;
      this.ggWHsyDJBL.Location = new Point(3, 16);
      this.ggWHsyDJBL.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18436);
      this.ggWHsyDJBL.Size = new Size(482, 20);
      this.ggWHsyDJBL.TabIndex = 0;
      this.GYvHYf2fVV.Dock = DockStyle.Fill;
      this.GYvHYf2fVV.Location = new Point(80, 0);
      this.GYvHYf2fVV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18452);
      this.GYvHYf2fVV.Size = new Size(402, 20);
      this.GYvHYf2fVV.TabIndex = 1;
      this.arRHx7YDDK.Dock = DockStyle.Left;
      this.arRHx7YDDK.Location = new Point(0, 0);
      this.arRHx7YDDK.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18486);
      this.arRHx7YDDK.Size = new Size(80, 20);
      this.arRHx7YDDK.TabIndex = 0;
      this.arRHx7YDDK.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18502);
      this.arRHx7YDDK.TextAlign = ContentAlignment.MiddleCenter;
      this.Controls.Add((Control) this.ReeRok5rPP);
      this.Controls.Add((Control) this.hRERcX8NvI);
      this.Controls.Add((Control) this.lUNRpNni6Y);
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18530);
      this.Size = new Size(488, 440);
      this.hRERcX8NvI.ResumeLayout(false);
      this.xANRz8Z8ug.ResumeLayout(false);
      this.ggWHsyDJBL.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BeforeLoad()
    {
      this.ReeRok5rPP.BeginUpdate();
      this.ReeRok5rPP.Items.Clear();
      foreach (FileInfo file in this.settings.Files)
        this.ReeRok5rPP.Items.Add((ListViewItem) new FileViewItem(file));
      this.ReeRok5rPP.EndUpdate();
      this.GYvHYf2fVV.Value = 0;
      this.TONHeFCpxk.Maximum = this.settings.Files.Length;
      this.TONHeFCpxk.Value = 0;
      this.mffR0pTFbp = Engine.GetEngine(this.settings.Template.DataOptions.DataType);
      this.mffR0pTFbp.StateChanged += new EventHandler(this.GQfRqlcOiv);
      this.mffR0pTFbp.Error += new ErrorEventHandler(this.GVCRXcB5Io);
      this.mffR0pTFbp.TotalProgress += new ProgressEventHandler(this.a2uRKsHpag);
      this.mffR0pTFbp.CurrentFileProgress += new ProgressEventHandler(this.Kp5RmVK6TB);
      this.mffR0pTFbp.FileStatusChanged += new FileEventHandler(this.MT0RwTSIlV);
      this.P8qRCKQ70B();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BeforeBack()
    {
      this.mffR0pTFbp.Finish();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BeforeClose()
    {
      this.mffR0pTFbp.Finish();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void va6R69T5uI([In] object obj0, [In] ToolBarButtonClickEventArgs obj1)
    {
      if (obj1.Button == this.fvqRt7yS76)
        this.zQbRr66Oeh(true);
      else if (obj1.Button == this.YC9RE7fOsa)
        this.wcqR5WAFdu();
      else if (obj1.Button == this.gYZRQJ5efI)
      {
        this.c0xR8aKNxP();
      }
      else
      {
        if (obj1.Button != this.V9tH1RyckD)
          throw new NotSupportedException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(18588));
        this.zQbRr66Oeh(false);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zQbRr66Oeh([In] bool obj0)
    {
      if (this.mffR0pTFbp.State == EngineState.Paused)
      {
        this.mffR0pTFbp.Continue();
      }
      else
      {
        this.ReeRok5rPP.BeginUpdate();
        foreach (FileViewItem fileViewItem in this.ReeRok5rPP.Items)
        {
          fileViewItem.SetFileStatus(FileStatus.Waiting);
          fileViewItem.SetObjectCount(-1);
        }
        this.ReeRok5rPP.EndUpdate();
        this.mffR0pTFbp.Start(this.settings.Files, this.settings.Template, obj0);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void c0xR8aKNxP()
    {
      this.mffR0pTFbp.Stop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wcqR5WAFdu()
    {
      this.mffR0pTFbp.Pause();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GQfRqlcOiv([In] object obj0, [In] EventArgs obj1)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EventHandler(this.GQfRqlcOiv), obj0, (object) obj1);
      else
        this.P8qRCKQ70B();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void P8qRCKQ70B()
    {
      switch (this.mffR0pTFbp.State)
      {
        case EngineState.Running:
          this.fvqRt7yS76.Enabled = false;
          this.YC9RE7fOsa.Enabled = true;
          this.gYZRQJ5efI.Enabled = true;
          this.V9tH1RyckD.Enabled = false;
          break;
        case EngineState.Paused:
          this.fvqRt7yS76.Enabled = true;
          this.YC9RE7fOsa.Enabled = false;
          this.gYZRQJ5efI.Enabled = true;
          this.V9tH1RyckD.Enabled = false;
          break;
        case EngineState.Stopped:
          this.fvqRt7yS76.Enabled = true;
          this.YC9RE7fOsa.Enabled = false;
          this.gYZRQJ5efI.Enabled = false;
          this.V9tH1RyckD.Enabled = true;
          break;
        default:
          throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(18638) + ((object) this.mffR0pTFbp.State).ToString());
      }
      this.EmitButtonEnabledChanged();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private FileViewItem IvQR26P3Xa([In] FileInfo obj0)
    {
      foreach (FileViewItem fileViewItem in this.ReeRok5rPP.Items)
      {
        if (fileViewItem.File == obj0)
          return fileViewItem;
      }
      return (FileViewItem) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GVCRXcB5Io([In] object obj0, [In] ErrorEventArgs obj1)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new ErrorEventHandler(this.GVCRXcB5Io), obj0, (object) obj1);
      }
      else
      {
        ErrorDialog errorDialog = new ErrorDialog();
        errorDialog.SetError(this.settings.Template, obj1);
        int num = (int) errorDialog.ShowDialog((IWin32Window) this);
        switch (errorDialog.DialogResult)
        {
          case ErrorDialog.Result.Stop:
            this.mffR0pTFbp.Stop();
            break;
          case ErrorDialog.Result.SkipFile:
            this.mffR0pTFbp.SkipCurrentFile();
            break;
        }
        errorDialog.Dispose();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void a2uRKsHpag([In] object obj0, [In] ProgressEventArgs obj1)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new ProgressEventHandler(this.a2uRKsHpag), obj0, (object) obj1);
      else
        this.TONHeFCpxk.Value = obj1.Progress;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Kp5RmVK6TB([In] object obj0, [In] ProgressEventArgs obj1)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new ProgressEventHandler(this.Kp5RmVK6TB), obj0, (object) obj1);
      else
        this.GYvHYf2fVV.Value = obj1.Progress;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MT0RwTSIlV([In] object obj0, [In] FileEventArgs obj1)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new FileEventHandler(this.MT0RwTSIlV), obj0, (object) obj1);
      }
      else
      {
        FileViewItem fileViewItem = this.IvQR26P3Xa(obj1.File);
        fileViewItem.SetFileStatus(obj1.Status);
        switch (obj1.Status)
        {
          case FileStatus.Importing:
          case FileStatus.Testing:
            fileViewItem.EnsureVisible();
            break;
          case FileStatus.DoneOk:
          case FileStatus.DoneError:
          case FileStatus.Aborted:
            fileViewItem.SetObjectCount(obj1.ObjectCount);
            break;
          default:
            throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(18688) + ((object) obj1.Status).ToString());
        }
      }
    }
  }
}
