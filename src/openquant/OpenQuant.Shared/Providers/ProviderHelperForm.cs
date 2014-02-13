using FreeQuant.Providers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant.Shared.Providers
{
  internal class ProviderHelperForm : Form
  {
    private IContainer components;
    private Label label1;
    private ProgressBar progressBar;
    private IProvider provider;
    private int timeout;

    public ProviderHelperForm()
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
      this.label1 = new Label();
      this.progressBar = new ProgressBar();
      this.SuspendLayout();
      this.label1.Location = new Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(105, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Connecting...";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.progressBar.Location = new Point(16, 40);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new Size(236, 16);
      this.progressBar.Style = ProgressBarStyle.Marquee;
      this.progressBar.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(271, 69);
      this.ControlBox = false;
      this.Controls.Add((Control) this.progressBar);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ProviderHelperForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "ProviderHelperForm";
      this.ResumeLayout(false);
    }

    public void Init(IProvider provider, int timeout)
    {
      this.provider = provider;
      this.timeout = timeout;
    }

    protected override void OnShown(EventArgs e)
    {
      this.Text = this.provider.Name;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.WaitMethod));
      base.OnShown(e);
    }

    private void WaitMethod(object state)
    {
      while (!this.provider.IsConnected && this.timeout-- > 0)
        Thread.Sleep(1000);
			this.Invoke((Action) (() => this.Close()));
    }
  }
}
