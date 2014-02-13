using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Instruments
{
  internal class ProcessImportForm : Form
  {
    private IContainer components;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label lblTotal;
    private Label lblSuccessfully;
    private Label lblSkipped;
    private ProgressBar progressBar;
    private Button btnCancel;
    private Button btnClose;
    private IInstrumentProvider provider;
    private FIXSecurityDefinition[] securityDefinitions;
    private int numSuccessfully;
    private int numSkipped;
    private bool doWork;

    public ProcessImportForm()
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
      this.label2 = new Label();
      this.label3 = new Label();
      this.lblTotal = new Label();
      this.lblSuccessfully = new Label();
      this.lblSkipped = new Label();
      this.progressBar = new ProgressBar();
      this.btnCancel = new Button();
      this.btnClose = new Button();
      this.SuspendLayout();
      this.label1.Location = new Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(112, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Total:";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(16, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(112, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Successfully:";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(16, 64);
      this.label3.Name = "label3";
      this.label3.Size = new Size(112, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Skipped (duplicated):";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.lblTotal.Location = new Point(128, 16);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new Size(196, 20);
      this.lblTotal.TabIndex = 3;
      this.lblTotal.Text = "count";
      this.lblTotal.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSuccessfully.Location = new Point(128, 40);
      this.lblSuccessfully.Name = "lblSuccessfully";
      this.lblSuccessfully.Size = new Size(196, 20);
      this.lblSuccessfully.TabIndex = 4;
      this.lblSuccessfully.Text = "count";
      this.lblSuccessfully.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSkipped.Location = new Point(128, 64);
      this.lblSkipped.Name = "lblSkipped";
      this.lblSkipped.Size = new Size(196, 20);
      this.lblSkipped.TabIndex = 5;
      this.lblSkipped.Text = "count";
      this.lblSkipped.TextAlign = ContentAlignment.MiddleLeft;
      this.progressBar.Location = new Point(16, 92);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new Size(337, 20);
      this.progressBar.TabIndex = 6;
      this.btnCancel.Location = new Point(143, 128);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(72, 22);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(273, 128);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(72, 22);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(369, 159);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.progressBar);
      this.Controls.Add((Control) this.lblSkipped);
      this.Controls.Add((Control) this.lblSuccessfully);
      this.Controls.Add((Control) this.lblTotal);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ProcessImportForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import";
      this.ResumeLayout(false);
    }

    public void Init(IInstrumentProvider provider, FIXSecurityDefinition[] securityDefinitions)
    {
      this.provider = provider;
      this.securityDefinitions = securityDefinitions;
      this.numSuccessfully = 0;
      this.numSkipped = 0;
      this.UpdateProgress();
      this.btnClose.Visible = false;
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
      if (!this.btnClose.Visible)
        e.Cancel = true;
      base.OnFormClosing(e);
    }

    private void Run()
    {
      try
      {
        for (int index = 0; index < this.securityDefinitions.Length && this.doWork; ++index)
        {
          if (this.AddInstrument(this.securityDefinitions[index]))
            ++this.numSuccessfully;
          else
            ++this.numSkipped;
          this.OnProgressChanged();
          Thread.Sleep(0);
        }
      }
      catch (Exception ex)
      {
        this.OnError(ex);
      }
      finally
      {
        this.OnFinished();
      }
    }

    private bool AddInstrument(FIXSecurityDefinition securityDefinition)
    {
      string symbol = SecurityDefinitionHelper.GetSymbol(securityDefinition, ((IProvider) this.provider).Id);
      if (InstrumentManager.Instruments.Contains(symbol))
        return false;
      Instrument instrument = new Instrument(symbol, securityDefinition.SecurityType);
      foreach (FIXField fixField in ((FIXGroup) securityDefinition).Fields)
      {
        switch ((int) fixField.Tag)
        {
          case 320:
          case 322:
          case 323:
          case 393:
          case 55:
          case 167:
            goto case 320;
          default:
            ((FIXGroup) instrument).AddField(fixField);
            goto case 320;
        }
      }
      for (int index = 0; index < securityDefinition.NoSecurityAltID; ++index)
        ((FIXInstrument) instrument).AddGroup(securityDefinition.GetSecurityAltIDGroup(index));
      switch (((IProvider) this.provider).Id)
      {
        case (byte) 4:
          if (((FIXInstrument) instrument).Symbol != securityDefinition.Symbol)
            instrument.AddSymbol(securityDefinition.Symbol, securityDefinition.SecurityExchange, ((IProvider) this.provider).Name);
          ((FIXGroup) instrument).RemoveField(48);
          break;
        case (byte) 10:
          instrument.AddSymbol(string.Format("{0}|{1}|1.0", (object) securityDefinition.Symbol, securityDefinition.SecurityID), securityDefinition.SecurityExchange, ((IProvider) this.provider).Name);
          ((FIXGroup) instrument).RemoveField(48);
          instrument.AddSymbol(securityDefinition.Symbol, securityDefinition.SecurityExchange, "TT API");
          break;
        case (byte) 21:
          instrument.AddSymbol(securityDefinition.SecurityID, securityDefinition.SecurityExchange, ((IProvider) this.provider).Name);
          break;
        case (byte) 22:
          if (((FIXInstrument) instrument).Symbol != securityDefinition.Symbol)
          {
            instrument.AddSymbol(securityDefinition.SecurityID, securityDefinition.SecurityExchange, ((IProvider) this.provider).Name);
            ((FIXGroup) instrument).RemoveField(48);
            break;
          }
          else
            break;
      }
      if ((((FIXInstrument) instrument).SecurityType == "FUT" || ((FIXInstrument) instrument).SecurityType == "OPT" || ((FIXInstrument) instrument).SecurityType == "MLEG") && (!((FIXGroup) instrument).ContainsField(541) && ((FIXGroup) instrument).ContainsField(200)))
      {
        int year = int.Parse(securityDefinition.MaturityMonthYear.Substring(0, 4), (IFormatProvider) CultureInfo.InvariantCulture);
        int month = int.Parse(securityDefinition.MaturityMonthYear.Substring(4, 2), (IFormatProvider) CultureInfo.InvariantCulture);
				((FIXInstrument) instrument).MaturityDate = new DateTime(year, month, 1);
      }
      instrument.Save();
      return true;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      if (!this.doWork || MessageBox.Show((IWin32Window) this, "Are you sure to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.doWork = false;
    }

    private void UpdateProgress()
    {
      int num = this.numSuccessfully + this.numSkipped;
      this.lblTotal.Text = string.Format("{0:n0} of {1:n0}", (object) num, (object) this.securityDefinitions.Length);
      this.lblSuccessfully.Text = this.numSuccessfully.ToString("n0");
      this.lblSkipped.Text = this.numSkipped.ToString("n0");
      this.progressBar.Value = num * 100 / this.securityDefinitions.Length;
    }

    private void OnProgressChanged()
    {
			this.Invoke((Action) (() => this.UpdateProgress()));
    }

    private void OnError(Exception e)
    {
      int num;
			this.Invoke((Action) (() => num = (int) MessageBox.Show((IWin32Window) this, ((object) e).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
    }

    private void OnFinished()
    {
			this.Invoke((Action) (() =>
      {
        this.btnCancel.Visible = false;
        this.btnClose.Visible = true;
      }));
    }
  }
}
