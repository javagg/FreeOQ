using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Instruments
{
  internal class ProcessRequestForm : Form
  {
    private IContainer components;
    private Label lblProgress;
    private ProgressBar progressBar;
    private Button btnCancel;
    private IInstrumentProvider provider;
    private FIXSecurityDefinitionRequest request;
    private bool doWork;
    private List<FIXSecurityDefinition> securityDefinitions;

    public ProcessRequestForm()
    {
      this.InitializeComponent();
      this.securityDefinitions = new List<FIXSecurityDefinition>();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblProgress = new Label();
      this.progressBar = new ProgressBar();
      this.btnCancel = new Button();
      this.SuspendLayout();
      this.lblProgress.Location = new Point(16, 16);
      this.lblProgress.Name = "lblProgress";
      this.lblProgress.Size = new Size(350, 20);
      this.lblProgress.TabIndex = 0;
      this.lblProgress.Text = "Please wait...";
      this.lblProgress.TextAlign = ContentAlignment.MiddleLeft;
      this.progressBar.Location = new Point(16, 40);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new Size(350, 24);
      this.progressBar.TabIndex = 1;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(156, 77);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(84, 24);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(385, 111);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.progressBar);
      this.Controls.Add((Control) this.lblProgress);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ProcessRequestForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Requesting";
      this.ResumeLayout(false);
    }

    public FIXSecurityDefinition[] GetSecurityDefinitions()
    {
      return this.securityDefinitions.ToArray();
    }

    public void Init(IInstrumentProvider provider, FIXSecurityDefinitionRequest request)
    {
      this.provider = provider;
      this.request = request;
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);
      Thread thread = new Thread(new ThreadStart(this.Run));
      this.doWork = true;
      thread.Start();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (this.doWork)
      {
        if (MessageBox.Show((IWin32Window) this, "Are you sure to cancel request?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          this.doWork = false;
        e.Cancel = true;
      }
      base.OnFormClosing(e);
    }

    private void Run()
    {
      try
      {
        // ISSUE: method pointer
				this.provider.SecurityDefinition += new SecurityDefinitionEventHandler(this.provider_SecurityDefinition);
        this.provider.SendSecurityDefinitionRequest(this.request);
        while (this.doWork)
          Thread.Sleep(1);
      }
      catch (Exception ex)
      {
        this.ShowError(ex);
      }
      finally
      {
        // ISSUE: method pointer
				this.provider.SecurityDefinition -= new SecurityDefinitionEventHandler(this.provider_SecurityDefinition);
        this.DialogResult = DialogResult.OK;
      }
    }

    private void provider_SecurityDefinition(object sender, SecurityDefinitionEventArgs args)
    {
      if (!this.doWork)
        return;
      FIXSecurityDefinition securityDefinition = args.SecurityDefinition;
      if (!(securityDefinition.SecurityReqID == this.request.SecurityReqID))
        return;
      this.securityDefinitions.Add(securityDefinition);
      this.UpdateProgress(this.securityDefinitions.Count, securityDefinition.TotNoRelatedSym);
      Thread.Sleep(0);
      if (this.securityDefinitions.Count != securityDefinition.TotNoRelatedSym)
        return;
      this.doWork = false;
    }

    private void UpdateProgress(int currentValue, int totalValue)
    {
			this.Invoke((Action) (() =>
      {
        this.lblProgress.Text = string.Format("Downloaded {0:n0} of {1:n0}", (object) currentValue, (object) totalValue);
        this.progressBar.Value = currentValue * 100 / totalValue;
      }));
    }

    private void ShowError(Exception e)
    {
      int num;
			this.Invoke((Action) (() => num = (int) MessageBox.Show((IWin32Window) this, ((object) e).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
    }
  }
}
