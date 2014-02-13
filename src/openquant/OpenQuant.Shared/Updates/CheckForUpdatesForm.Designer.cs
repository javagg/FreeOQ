namespace OpenQuant.Shared.Updates
{
	public partial  class CheckForUpdatesForm
  {
    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.ProgressBar progressBar;
		private  OpenQuant.Shared.Updates.ReleaseNotesControl ctrReleases;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof (CheckForUpdatesForm));
      this.lblStatus = new System.Windows.Forms.Label();
      this.panel = new System.Windows.Forms.Panel();
      this.btnClose = new System.Windows.Forms.Button();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.ctrReleases = new OpenQuant.Shared.Updates.ReleaseNotesControl();
      this.panel.SuspendLayout();
      this.SuspendLayout();
      this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblStatus.Location = new System.Drawing.Point(8, 0);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(352, 32);
      this.lblStatus.TabIndex = 0;
      this.lblStatus.Text = "Status";
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.panel.Controls.Add(this.btnClose);
      this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel.Location = new System.Drawing.Point(8, 282);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(352, 40);
      this.panel.TabIndex = 1;
      this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(272, 8);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(67, 24);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.progressBar.Location = new System.Drawing.Point(8, 32);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(352, 21);
      this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progressBar.TabIndex = 2;
      this.ctrReleases.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrReleases.Location = new System.Drawing.Point(8, 53);
      this.ctrReleases.Name = "ctrReleases";
      this.ctrReleases.Size = new System.Drawing.Size(352, 229);
      this.ctrReleases.TabIndex = 3;
      this.ctrReleases.DownloadRequested += new System.EventHandler<UriEventArgs>(this.ctrReleases_DownloadRequested);
      this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton =  this.btnClose;
      this.ClientSize = new System.Drawing.Size(368, 322);
      this.Controls.Add( this.ctrReleases);
      this.Controls.Add(this.progressBar);
      this.Controls.Add( this.panel);
      this.Controls.Add( this.lblStatus);
			//   this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(384, 144);
      this.Name = "CheckForUpdatesForm";
      this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Updates";
      this.panel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

 
  }
}
