// Type: OpenQuant.ReleaseNotesForm
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Updates;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class ReleaseNotesForm : Form
  {
    private IContainer components;
    private ReleaseNotesControl ctrReleases;
    private Panel panel1;
    private Button btnClose;

    public ReleaseNotesForm()
    {
      this.InitializeComponent();
      this.ctrReleases.add_DownloadRequested(new EventHandler<UriEventArgs>(this.ctrReleases_DownloadRequested));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.ctrReleases = new ReleaseNotesControl();
      this.panel1 = new Panel();
      this.btnClose = new Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      ((Control) this.ctrReleases).Dock = DockStyle.Fill;
      ((Control) this.ctrReleases).Location = new Point(4, 4);
      ((Control) this.ctrReleases).Name = "ctrReleases";
      ((Control) this.ctrReleases).Size = new Size(356, 279);
      ((Control) this.ctrReleases).TabIndex = 0;
      this.panel1.Controls.Add((Control) this.btnClose);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(4, 283);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(356, 40);
      this.panel1.TabIndex = 1;
      this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(271, 8);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(61, 24);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(364, 323);
      this.Controls.Add((Control) this.ctrReleases);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.Name = "ReleaseNotesForm";
      this.Padding = new Padding(4, 4, 4, 0);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "OpenQuant Updates";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void Init(ReleaseInfo[] releases)
    {
      this.ctrReleases.Init(Global.Setup.get_Product().get_Version(), releases);
    }

    private void ctrReleases_DownloadRequested(object sender, UriEventArgs args)
    {
      this.Close();
      Process.Start(args.get_Uri().AbsoluteUri);
    }
  }
}
