using FreeQuant.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FreeQuant.Shared.Data.Export.CSV
{
  public class ExportSeriesForm : Form
  {
    private DataSeriesList Ks6sx4V4bb;
    private bool YTQsDMD8sE;
    private GroupBox Pb5s1HSPt5;
    private Label BNWsdtVWfr;
    private TextBox aAjsF4KSNL;
    private Button RFvsb0qw0E;
    private GroupBox RAksVEc6rV;
    private CheckBox jVNsRJ7WbP;
    private CheckBox MVbsHnQbm7;
    private CheckBox RNaskihREl;
    private CheckBox PwUslmAftn;
    private GroupBox YGOsuf5tcC;
    private Button XEIsgPRknF;
    private Button BKrsMFjq6n;
    private Button xrlsJ5llhA;
    private Label a5tsnCV0A7;
    private Label wNqs7AHmEd;
    private ProgressBar AfUsLC4KqF;
    private Label Hu3si1CEo2;
    private Label B6Qs9YOR4t;
    private ProgressBar WE7s3qRvNO;
    private Container xgfsWfQeXj;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExportSeriesForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.N9khQ5308p();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDataSeriesList(DataSeriesList series)
    {
      this.Ks6sx4V4bb = series;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnLoad(EventArgs e)
    {
      this.WE7s3qRvNO.Maximum = this.Ks6sx4V4bb.Count;
      this.iI9hB28ERu(new object[1]
      {
        (object) 0
      });
      base.OnLoad(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnClosing(CancelEventArgs e)
    {
      if (!this.BKrsMFjq6n.Enabled)
        e.Cancel = true;
      else
        base.OnClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.xgfsWfQeXj != null)
        this.xgfsWfQeXj.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void N9khQ5308p()
    {
      this.Pb5s1HSPt5 = new GroupBox();
      this.BNWsdtVWfr = new Label();
      this.aAjsF4KSNL = new TextBox();
      this.RFvsb0qw0E = new Button();
      this.RAksVEc6rV = new GroupBox();
      this.jVNsRJ7WbP = new CheckBox();
      this.MVbsHnQbm7 = new CheckBox();
      this.RNaskihREl = new CheckBox();
      this.PwUslmAftn = new CheckBox();
      this.YGOsuf5tcC = new GroupBox();
      this.XEIsgPRknF = new Button();
      this.BKrsMFjq6n = new Button();
      this.xrlsJ5llhA = new Button();
      this.a5tsnCV0A7 = new Label();
      this.wNqs7AHmEd = new Label();
      this.AfUsLC4KqF = new ProgressBar();
      this.Hu3si1CEo2 = new Label();
      this.B6Qs9YOR4t = new Label();
      this.WE7s3qRvNO = new ProgressBar();
      this.Pb5s1HSPt5.SuspendLayout();
      this.RAksVEc6rV.SuspendLayout();
      this.YGOsuf5tcC.SuspendLayout();
      this.SuspendLayout();
      this.Pb5s1HSPt5.Controls.Add((Control) this.RAksVEc6rV);
      this.Pb5s1HSPt5.Controls.Add((Control) this.RFvsb0qw0E);
      this.Pb5s1HSPt5.Controls.Add((Control) this.aAjsF4KSNL);
      this.Pb5s1HSPt5.Controls.Add((Control) this.BNWsdtVWfr);
      this.Pb5s1HSPt5.Location = new Point(8, 8);
      this.Pb5s1HSPt5.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2860);
      this.Pb5s1HSPt5.Size = new Size(488, 112);
      this.Pb5s1HSPt5.TabIndex = 0;
      this.Pb5s1HSPt5.TabStop = false;
      this.Pb5s1HSPt5.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2882);
      this.BNWsdtVWfr.Location = new Point(16, 24);
      this.BNWsdtVWfr.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2898);
      this.BNWsdtVWfr.Size = new Size(88, 16);
      this.BNWsdtVWfr.TabIndex = 0;
      this.BNWsdtVWfr.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2914);
      this.BNWsdtVWfr.TextAlign = ContentAlignment.MiddleLeft;
      this.aAjsF4KSNL.Location = new Point(104, 24);
      this.aAjsF4KSNL.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2950);
      this.aAjsF4KSNL.ReadOnly = true;
      this.aAjsF4KSNL.Size = new Size(296, 20);
      this.aAjsF4KSNL.TabIndex = 1;
      this.aAjsF4KSNL.Text = "";
      this.aAjsF4KSNL.TextChanged += new EventHandler(this.k06hAda0xb);
      this.RFvsb0qw0E.Location = new Point(408, 24);
      this.RFvsb0qw0E.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2990);
      this.RFvsb0qw0E.Size = new Size(64, 20);
      this.RFvsb0qw0E.TabIndex = 2;
      this.RFvsb0qw0E.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3012);
      this.RFvsb0qw0E.Click += new EventHandler(this.VnwhvpwTKn);
      this.RAksVEc6rV.Controls.Add((Control) this.PwUslmAftn);
      this.RAksVEc6rV.Controls.Add((Control) this.RNaskihREl);
      this.RAksVEc6rV.Controls.Add((Control) this.MVbsHnQbm7);
      this.RAksVEc6rV.Controls.Add((Control) this.jVNsRJ7WbP);
      this.RAksVEc6rV.Location = new Point(8, 56);
      this.RAksVEc6rV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3034);
      this.RAksVEc6rV.Size = new Size(472, 48);
      this.RAksVEc6rV.TabIndex = 3;
      this.RAksVEc6rV.TabStop = false;
      this.RAksVEc6rV.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3056);
      this.jVNsRJ7WbP.Checked = true;
      this.jVNsRJ7WbP.CheckState = CheckState.Checked;
      this.jVNsRJ7WbP.Location = new Point(16, 24);
      this.jVNsRJ7WbP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3072);
      this.jVNsRJ7WbP.Size = new Size(64, 16);
      this.jVNsRJ7WbP.TabIndex = 0;
      this.jVNsRJ7WbP.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3094);
      this.MVbsHnQbm7.Checked = true;
      this.MVbsHnQbm7.CheckState = CheckState.Checked;
      this.MVbsHnQbm7.Location = new Point(88, 24);
      this.MVbsHnQbm7.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3110);
      this.MVbsHnQbm7.Size = new Size(64, 16);
      this.MVbsHnQbm7.TabIndex = 1;
      this.MVbsHnQbm7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3132);
      this.RNaskihREl.Checked = true;
      this.RNaskihREl.CheckState = CheckState.Checked;
      this.RNaskihREl.Location = new Point(160, 24);
      this.RNaskihREl.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3148);
      this.RNaskihREl.Size = new Size(64, 16);
      this.RNaskihREl.TabIndex = 2;
      this.RNaskihREl.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3166);
      this.PwUslmAftn.Checked = true;
      this.PwUslmAftn.CheckState = CheckState.Checked;
      this.PwUslmAftn.Location = new Point(232, 24);
      this.PwUslmAftn.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3178);
      this.PwUslmAftn.Size = new Size(64, 16);
      this.PwUslmAftn.TabIndex = 3;
      this.PwUslmAftn.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3198);
      this.YGOsuf5tcC.Controls.Add((Control) this.WE7s3qRvNO);
      this.YGOsuf5tcC.Controls.Add((Control) this.B6Qs9YOR4t);
      this.YGOsuf5tcC.Controls.Add((Control) this.Hu3si1CEo2);
      this.YGOsuf5tcC.Controls.Add((Control) this.AfUsLC4KqF);
      this.YGOsuf5tcC.Controls.Add((Control) this.wNqs7AHmEd);
      this.YGOsuf5tcC.Controls.Add((Control) this.a5tsnCV0A7);
      this.YGOsuf5tcC.Location = new Point(8, 136);
      this.YGOsuf5tcC.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3212);
      this.YGOsuf5tcC.Size = new Size(488, 104);
      this.YGOsuf5tcC.TabIndex = 1;
      this.YGOsuf5tcC.TabStop = false;
      this.YGOsuf5tcC.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3234);
      this.XEIsgPRknF.Enabled = false;
      this.XEIsgPRknF.Location = new Point(328, 256);
      this.XEIsgPRknF.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3254);
      this.XEIsgPRknF.Size = new Size(72, 24);
      this.XEIsgPRknF.TabIndex = 2;
      this.XEIsgPRknF.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3276);
      this.XEIsgPRknF.Click += new EventHandler(this.t5ShodfId5);
      this.BKrsMFjq6n.DialogResult = DialogResult.Cancel;
      this.BKrsMFjq6n.Location = new Point(416, 256);
      this.BKrsMFjq6n.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3292);
      this.BKrsMFjq6n.Size = new Size(72, 24);
      this.BKrsMFjq6n.TabIndex = 3;
      this.BKrsMFjq6n.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3312);
      this.xrlsJ5llhA.Location = new Point(217, 256);
      this.xrlsJ5llhA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3326);
      this.xrlsJ5llhA.Size = new Size(72, 24);
      this.xrlsJ5llhA.TabIndex = 4;
      this.xrlsJ5llhA.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3344);
      this.xrlsJ5llhA.Visible = false;
      this.xrlsJ5llhA.Click += new EventHandler(this.J96hPSg6A0);
      this.a5tsnCV0A7.Location = new Point(16, 24);
      this.a5tsnCV0A7.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3356);
      this.a5tsnCV0A7.Size = new Size(56, 16);
      this.a5tsnCV0A7.TabIndex = 0;
      this.a5tsnCV0A7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3372);
      this.a5tsnCV0A7.TextAlign = ContentAlignment.MiddleLeft;
      this.wNqs7AHmEd.Location = new Point(80, 24);
      this.wNqs7AHmEd.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3390);
      this.wNqs7AHmEd.Size = new Size(304, 16);
      this.wNqs7AHmEd.TabIndex = 1;
      this.wNqs7AHmEd.TextAlign = ContentAlignment.MiddleLeft;
      this.AfUsLC4KqF.Location = new Point(16, 40);
      this.AfUsLC4KqF.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3420);
      this.AfUsLC4KqF.Size = new Size(456, 16);
      this.AfUsLC4KqF.TabIndex = 2;
      this.Hu3si1CEo2.Location = new Point(16, 56);
      this.Hu3si1CEo2.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3460);
      this.Hu3si1CEo2.Size = new Size(40, 16);
      this.Hu3si1CEo2.TabIndex = 3;
      this.Hu3si1CEo2.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3476);
      this.Hu3si1CEo2.TextAlign = ContentAlignment.MiddleLeft;
      this.B6Qs9YOR4t.Location = new Point(64, 56);
      this.B6Qs9YOR4t.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3490);
      this.B6Qs9YOR4t.Size = new Size(176, 16);
      this.B6Qs9YOR4t.TabIndex = 4;
      this.B6Qs9YOR4t.TextAlign = ContentAlignment.MiddleLeft;
      this.WE7s3qRvNO.Location = new Point(16, 72);
      this.WE7s3qRvNO.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3510);
      this.WE7s3qRvNO.Size = new Size(456, 16);
      this.WE7s3qRvNO.TabIndex = 5;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.BKrsMFjq6n;
      this.ClientSize = new Size(506, 295);
      this.Controls.Add((Control) this.xrlsJ5llhA);
      this.Controls.Add((Control) this.BKrsMFjq6n);
      this.Controls.Add((Control) this.XEIsgPRknF);
      this.Controls.Add((Control) this.YGOsuf5tcC);
      this.Controls.Add((Control) this.Pb5s1HSPt5);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3546);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3570);
      this.Pb5s1HSPt5.ResumeLayout(false);
      this.RAksVEc6rV.ResumeLayout(false);
      this.YGOsuf5tcC.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VnwhvpwTKn([In] object obj0, [In] EventArgs obj1)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.SelectedPath = this.aAjsF4KSNL.Text;
      folderBrowserDialog.ShowNewFolderButton = true;
      folderBrowserDialog.Description = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3600);
      if (folderBrowserDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
        this.aAjsF4KSNL.Text = folderBrowserDialog.SelectedPath;
      folderBrowserDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void t5ShodfId5([In] object obj0, [In] EventArgs obj1)
    {
      this.xrlsJ5llhA.Location = this.XEIsgPRknF.Location;
      this.xrlsJ5llhA.Visible = true;
      this.XEIsgPRknF.Visible = false;
      this.BKrsMFjq6n.Enabled = false;
      this.Pb5s1HSPt5.Enabled = false;
      this.YTQsDMD8sE = true;
      new Thread(new ThreadStart(this.BVbsYsoyuY))
      {
        Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(3676)
      }.Start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void J96hPSg6A0([In] object obj0, [In] EventArgs obj1)
    {
      this.YTQsDMD8sE = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void k06hAda0xb([In] object obj0, [In] EventArgs obj1)
    {
      this.XEIsgPRknF.Enabled = this.aAjsF4KSNL.Text != "";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iI9hB28ERu(params object[] args)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new EFCVIIKIvIUnrdkUut(this.iI9hB28ERu), new object[1]
        {
          (object) args
        });
      }
      else
      {
        int num = (int) args[0];
        this.B6Qs9YOR4t.Text = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(3712), (object) num, (object) this.Ks6sx4V4bb.Count);
        this.WE7s3qRvNO.Value = num;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DCVhcEKZSP(params object[] args)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EFCVIIKIvIUnrdkUut(this.DCVhcEKZSP), new object[1]
        {
          (object) args
        });
      else
        this.AfUsLC4KqF.Value = (int) args[0];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jAhhzpBLWi(params object[] args)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EFCVIIKIvIUnrdkUut(this.jAhhzpBLWi), new object[1]
        {
          (object) args
        });
      else
        this.wNqs7AHmEd.Text = (string) args[0];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DvvseCyttA(params object[] args)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new EFCVIIKIvIUnrdkUut(this.DvvseCyttA), new object[1]
        {
          (object) args
        });
      }
      else
      {
        int num = (int) MessageBox.Show((IWin32Window) this, (string) args[0], RNaihRhYEl0wUmAftnB.aYu7exFQKN(3736), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UG4shoj9bO()
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MethodInvoker(this.UG4shoj9bO));
      else
        this.BKrsMFjq6n.Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IjJssXV9df()
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MethodInvoker(this.IjJssXV9df));
      else
        this.xrlsJ5llhA.Visible = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BVbsYsoyuY()
    {
      try
      {
        for (int index1 = 0; index1 < this.Ks6sx4V4bb.Count && this.YTQsDMD8sE; ++index1)
        {
          IDataSeries dataSeries = this.Ks6sx4V4bb[index1];
          this.jAhhzpBLWi(new object[1]
          {
            (object) dataSeries.Name
          });
          this.DCVhcEKZSP(new object[1]
          {
            (object) 0
          });
          qct4K92XRXgWAtpVGR qct4K92XrXgWatpVgr = Dhgssiwum3QkgMqvJP.kqFukiu92g(dataSeries);
          if (qct4K92XrXgWatpVgr == (qct4K92XRXgWAtpVGR) 1 && !this.jVNsRJ7WbP.Checked)
            qct4K92XrXgWatpVgr = (qct4K92XRXgWAtpVGR) 0;
          if (qct4K92XrXgWatpVgr == (qct4K92XRXgWAtpVGR) 2 && !this.MVbsHnQbm7.Checked)
            qct4K92XrXgWatpVgr = (qct4K92XRXgWAtpVGR) 0;
          if (qct4K92XrXgWatpVgr == (qct4K92XRXgWAtpVGR) 3 && !this.RNaskihREl.Checked)
            qct4K92XrXgWatpVgr = (qct4K92XRXgWAtpVGR) 0;
          if (qct4K92XrXgWatpVgr == (qct4K92XRXgWAtpVGR) 4 && !this.PwUslmAftn.Checked)
            qct4K92XrXgWatpVgr = (qct4K92XRXgWAtpVGR) 0;
          if (qct4K92XrXgWatpVgr != (qct4K92XRXgWAtpVGR) 0)
          {
            DirectoryInfo directoryInfo = new DirectoryInfo(string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(3750), (object) this.aAjsF4KSNL.Text, (object) qct4K92XrXgWatpVgr));
            if (!directoryInfo.Exists)
              directoryInfo.Create();
            StreamWriter streamWriter = new StreamWriter(string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(3768), (object) directoryInfo.FullName, (object) dataSeries.Name));
            switch (qct4K92XrXgWatpVgr)
            {
              case (qct4K92XRXgWAtpVGR) 1:
                streamWriter.WriteLine(RNaihRhYEl0wUmAftnB.aYu7exFQKN(3794));
                break;
              case (qct4K92XRXgWAtpVGR) 2:
                streamWriter.WriteLine(RNaihRhYEl0wUmAftnB.aYu7exFQKN(3836));
                break;
              case (qct4K92XRXgWAtpVGR) 3:
                streamWriter.WriteLine(RNaihRhYEl0wUmAftnB.aYu7exFQKN(3904));
                break;
              case (qct4K92XRXgWAtpVGR) 4:
                streamWriter.WriteLine(RNaihRhYEl0wUmAftnB.aYu7exFQKN(4010));
                break;
            }
            int num1 = 0;
            for (int index2 = 0; index2 < dataSeries.Count && this.YTQsDMD8sE; ++index2)
            {
              switch (qct4K92XrXgWatpVgr)
              {
                case (qct4K92XRXgWAtpVGR) 1:
                  Trade trade = (Trade) dataSeries[index2];
                  streamWriter.WriteLine(Dhgssiwum3QkgMqvJP.rKougwdICJ(3), (object) Dhgssiwum3QkgMqvJP.dOfult8pci(trade.DateTime, true, true), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(trade.Price), (object) trade.Size);
                  break;
                case (qct4K92XRXgWAtpVGR) 2:
                  Quote quote = (Quote) dataSeries[index2];
                  streamWriter.WriteLine(Dhgssiwum3QkgMqvJP.rKougwdICJ(5), (object) Dhgssiwum3QkgMqvJP.dOfult8pci(quote.DateTime, true, true), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(quote.Bid), (object) quote.BidSize, (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(quote.Ask), (object) quote.AskSize);
                  break;
                case (qct4K92XRXgWAtpVGR) 3:
                  Bar bar = (Bar) dataSeries[index2];
                  streamWriter.WriteLine(Dhgssiwum3QkgMqvJP.rKougwdICJ(8), (object) Dhgssiwum3QkgMqvJP.dOfult8pci(bar.DateTime, true, false), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(bar.Open), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(bar.High), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(bar.Low), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(bar.Close), (object) bar.Volume, (object) bar.OpenInt, (object) bar.Size);
                  break;
                case (qct4K92XRXgWAtpVGR) 4:
                  Daily daily = (Daily) dataSeries[index2];
                  streamWriter.WriteLine(Dhgssiwum3QkgMqvJP.rKougwdICJ(7), (object) Dhgssiwum3QkgMqvJP.dOfult8pci(daily.DateTime, false, false), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(daily.Open), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(daily.High), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(daily.Low), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(daily.Close), (object) daily.Volume, (object) daily.OpenInt);
                  break;
              }
              int num2 = (int) ((double) index2 / (double) dataSeries.Count * 100.0);
              if (num2 > num1)
              {
                num1 = num2;
                this.DCVhcEKZSP(new object[1]
                {
                  (object) num2
                });
              }
            }
            streamWriter.Close();
          }
          this.iI9hB28ERu(new object[1]
          {
            (object) (index1 + 1)
          });
        }
      }
      catch (Exception ex)
      {
        this.DvvseCyttA(new object[1]
        {
          (object) ((object) ex).ToString()
        });
      }
      finally
      {
        this.UG4shoj9bO();
        this.IjJssXV9df();
      }
    }
  }
}
