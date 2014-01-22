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
  public class ExportSingleSeriesForm : Form
  {
    private IContainer vxEdGgadgV;
    private GroupBox wMPdZASEx3;
    private Label mwQd4d6vDt;
    private Button AZGdIjuO6i;
    private TextBox vyIdSSQWEW;
    private ComboBox PI6dU6Axph;
    private Label U30dj76P1y;
    private GroupBox Jyrd61SKN7;
    private ProgressBar ftCdrwStiD;
    private Button XWnd8U625V;
    private Button sFKd5GZPrX;
    private Button fYRdqFuEvF;
    private IDataSeries WF0dC3KCxx;
    private string OmBd2L0KIX;
    private qct4K92XRXgWAtpVGR FF1dXhZrIu;
    private bool S3wdKqqOTC;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExportSingleSeriesForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.nildLVcxdX();
      this.PI6dU6Axph.Items.Add((object) (qct4K92XRXgWAtpVGR) 1);
      this.PI6dU6Axph.Items.Add((object) (qct4K92XRXgWAtpVGR) 2);
      this.PI6dU6Axph.Items.Add((object) (qct4K92XRXgWAtpVGR) 3);
      this.PI6dU6Axph.Items.Add((object) (qct4K92XRXgWAtpVGR) 4);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.vxEdGgadgV != null)
        this.vxEdGgadgV.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void nildLVcxdX()
    {
      this.wMPdZASEx3 = new GroupBox();
      this.AZGdIjuO6i = new Button();
      this.vyIdSSQWEW = new TextBox();
      this.mwQd4d6vDt = new Label();
      this.U30dj76P1y = new Label();
      this.PI6dU6Axph = new ComboBox();
      this.Jyrd61SKN7 = new GroupBox();
      this.ftCdrwStiD = new ProgressBar();
      this.XWnd8U625V = new Button();
      this.sFKd5GZPrX = new Button();
      this.fYRdqFuEvF = new Button();
      this.wMPdZASEx3.SuspendLayout();
      this.Jyrd61SKN7.SuspendLayout();
      this.SuspendLayout();
      this.wMPdZASEx3.Controls.Add((Control) this.PI6dU6Axph);
      this.wMPdZASEx3.Controls.Add((Control) this.U30dj76P1y);
      this.wMPdZASEx3.Controls.Add((Control) this.AZGdIjuO6i);
      this.wMPdZASEx3.Controls.Add((Control) this.vyIdSSQWEW);
      this.wMPdZASEx3.Controls.Add((Control) this.mwQd4d6vDt);
      this.wMPdZASEx3.Location = new Point(8, 8);
      this.wMPdZASEx3.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(9932);
      this.wMPdZASEx3.Size = new Size(424, 132);
      this.wMPdZASEx3.TabIndex = 0;
      this.wMPdZASEx3.TabStop = false;
      this.wMPdZASEx3.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(9956);
      this.AZGdIjuO6i.Location = new Point(358, 43);
      this.AZGdIjuO6i.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(9974);
      this.AZGdIjuO6i.Size = new Size(61, 20);
      this.AZGdIjuO6i.TabIndex = 2;
      this.AZGdIjuO6i.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(9996);
      this.AZGdIjuO6i.UseVisualStyleBackColor = true;
      this.AZGdIjuO6i.Click += new EventHandler(this.dwCdiqmmiJ);
      this.vyIdSSQWEW.Location = new Point(16, 43);
      this.vyIdSSQWEW.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10018);
      this.vyIdSSQWEW.ReadOnly = true;
      this.vyIdSSQWEW.Size = new Size(337, 20);
      this.vyIdSSQWEW.TabIndex = 1;
      this.vyIdSSQWEW.TextChanged += new EventHandler(this.FuWdWTs1bI);
      this.mwQd4d6vDt.Location = new Point(16, 20);
      this.mwQd4d6vDt.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10048);
      this.mwQd4d6vDt.Size = new Size(62, 16);
      this.mwQd4d6vDt.TabIndex = 0;
      this.mwQd4d6vDt.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10064);
      this.mwQd4d6vDt.TextAlign = ContentAlignment.MiddleLeft;
      this.U30dj76P1y.Location = new Point(16, 72);
      this.U30dj76P1y.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10090);
      this.U30dj76P1y.Size = new Size(62, 16);
      this.U30dj76P1y.TabIndex = 3;
      this.U30dj76P1y.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10106);
      this.U30dj76P1y.TextAlign = ContentAlignment.MiddleLeft;
      this.PI6dU6Axph.DropDownStyle = ComboBoxStyle.DropDownList;
      this.PI6dU6Axph.FormattingEnabled = true;
      this.PI6dU6Axph.Location = new Point(16, 97);
      this.PI6dU6Axph.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10128);
      this.PI6dU6Axph.Size = new Size(113, 21);
      this.PI6dU6Axph.TabIndex = 4;
      this.PI6dU6Axph.SelectedIndexChanged += new EventHandler(this.avhdTJmR3A);
      this.Jyrd61SKN7.Controls.Add((Control) this.ftCdrwStiD);
      this.Jyrd61SKN7.Location = new Point(8, 152);
      this.Jyrd61SKN7.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10156);
      this.Jyrd61SKN7.Size = new Size(424, 52);
      this.Jyrd61SKN7.TabIndex = 1;
      this.Jyrd61SKN7.TabStop = false;
      this.ftCdrwStiD.Location = new Point(8, 19);
      this.ftCdrwStiD.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10178);
      this.ftCdrwStiD.Size = new Size(408, 22);
      this.ftCdrwStiD.TabIndex = 0;
      this.XWnd8U625V.Location = new Point(260, 210);
      this.XWnd8U625V.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10204);
      this.XWnd8U625V.Size = new Size(74, 24);
      this.XWnd8U625V.TabIndex = 2;
      this.XWnd8U625V.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10226);
      this.XWnd8U625V.UseVisualStyleBackColor = true;
      this.XWnd8U625V.Click += new EventHandler(this.VPSd9pdPFL);
      this.sFKd5GZPrX.DialogResult = DialogResult.Cancel;
      this.sFKd5GZPrX.Location = new Point(340, 210);
      this.sFKd5GZPrX.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10242);
      this.sFKd5GZPrX.Size = new Size(74, 24);
      this.sFKd5GZPrX.TabIndex = 3;
      this.sFKd5GZPrX.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10262);
      this.sFKd5GZPrX.UseVisualStyleBackColor = true;
      this.fYRdqFuEvF.Location = new Point(137, 210);
      this.fYRdqFuEvF.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10276);
      this.fYRdqFuEvF.Size = new Size(74, 24);
      this.fYRdqFuEvF.TabIndex = 4;
      this.fYRdqFuEvF.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10294);
      this.fYRdqFuEvF.UseVisualStyleBackColor = true;
      this.fYRdqFuEvF.Visible = false;
      this.fYRdqFuEvF.Click += new EventHandler(this.OS3d3g3H36);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.sFKd5GZPrX;
      this.ClientSize = new Size(440, 244);
      this.Controls.Add((Control) this.fYRdqFuEvF);
      this.Controls.Add((Control) this.sFKd5GZPrX);
      this.Controls.Add((Control) this.XWnd8U625V);
      this.Controls.Add((Control) this.Jyrd61SKN7);
      this.Controls.Add((Control) this.wMPdZASEx3);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10306);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10354);
      this.wMPdZASEx3.ResumeLayout(false);
      this.wMPdZASEx3.PerformLayout();
      this.Jyrd61SKN7.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDataSeries(IDataSeries series)
    {
      this.WF0dC3KCxx = series;
      this.PI6dU6Axph.SelectedItem = (object) Dhgssiwum3QkgMqvJP.kqFukiu92g(series);
      this.Text = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(10402), (object) series.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      e.Cancel = !this.sFKd5GZPrX.Enabled;
      base.OnFormClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dwCdiqmmiJ([In] object obj0, [In] EventArgs obj1)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Title = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10452);
      saveFileDialog.Filter = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10494);
      saveFileDialog.DefaultExt = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10556);
      saveFileDialog.CreatePrompt = true;
      if (this.vyIdSSQWEW.Text == "")
        saveFileDialog.FileName = this.WF0dC3KCxx.Name + RNaihRhYEl0wUmAftnB.aYu7exFQKN(10566);
      else
        saveFileDialog.FileName = this.vyIdSSQWEW.Text;
      if (saveFileDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
        this.vyIdSSQWEW.Text = saveFileDialog.FileName.Trim();
      saveFileDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VPSd9pdPFL([In] object obj0, [In] EventArgs obj1)
    {
      this.wMPdZASEx3.Enabled = false;
      this.XWnd8U625V.Visible = false;
      this.sFKd5GZPrX.Enabled = false;
      this.fYRdqFuEvF.Location = this.XWnd8U625V.Location;
      this.fYRdqFuEvF.Visible = true;
      this.OmBd2L0KIX = this.vyIdSSQWEW.Text;
      this.FF1dXhZrIu = (qct4K92XRXgWAtpVGR) this.PI6dU6Axph.SelectedItem;
      this.S3wdKqqOTC = true;
      new Thread(new ThreadStart(this.aKtda5a4rp))
      {
        Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(10578)
      }.Start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OS3d3g3H36([In] object obj0, [In] EventArgs obj1)
    {
      this.S3wdKqqOTC = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FuWdWTs1bI([In] object obj0, [In] EventArgs obj1)
    {
      this.rm6dfyl0q6();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void avhdTJmR3A([In] object obj0, [In] EventArgs obj1)
    {
      this.rm6dfyl0q6();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rm6dfyl0q6()
    {
      this.XWnd8U625V.Enabled = this.vyIdSSQWEW.Text != "" && this.PI6dU6Axph.SelectedIndex != -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void n0ndyRA15v(params object[] args)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new EFCVIIKIvIUnrdkUut(this.n0ndyRA15v), new object[1]
        {
          (object) args
        });
      }
      else
      {
        int num = (int) MessageBox.Show((IWin32Window) this, (string) args[0], "", MessageBoxButtons.OK, (MessageBoxIcon) args[1]);
        this.sFKd5GZPrX.Enabled = true;
        this.Close();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aOSdOr0cLL(params object[] args)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EFCVIIKIvIUnrdkUut(this.aOSdOr0cLL), new object[1]
        {
          (object) args
        });
      else
        this.ftCdrwStiD.Value = (int) args[0];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aKtda5a4rp()
    {
      bool flag = false;
      try
      {
        StreamWriter streamWriter = new StreamWriter(this.OmBd2L0KIX);
        switch (this.FF1dXhZrIu)
        {
          case (qct4K92XRXgWAtpVGR) 1:
            streamWriter.WriteLine(RNaihRhYEl0wUmAftnB.aYu7exFQKN(10614));
            break;
          case (qct4K92XRXgWAtpVGR) 2:
            streamWriter.WriteLine(RNaihRhYEl0wUmAftnB.aYu7exFQKN(10656));
            break;
          case (qct4K92XRXgWAtpVGR) 3:
            streamWriter.WriteLine(RNaihRhYEl0wUmAftnB.aYu7exFQKN(10724));
            break;
          case (qct4K92XRXgWAtpVGR) 4:
            streamWriter.WriteLine(RNaihRhYEl0wUmAftnB.aYu7exFQKN(10830));
            break;
        }
        int num1 = 0;
        for (int index = 0; index < this.WF0dC3KCxx.Count && this.S3wdKqqOTC; ++index)
        {
          switch (this.FF1dXhZrIu)
          {
            case (qct4K92XRXgWAtpVGR) 1:
              Trade trade = (Trade) this.WF0dC3KCxx[index];
              streamWriter.WriteLine(Dhgssiwum3QkgMqvJP.rKougwdICJ(3), (object) Dhgssiwum3QkgMqvJP.dOfult8pci(trade.DateTime, true, true), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(trade.Price), (object) trade.Size);
              break;
            case (qct4K92XRXgWAtpVGR) 2:
              Quote quote = (Quote) this.WF0dC3KCxx[index];
              streamWriter.WriteLine(Dhgssiwum3QkgMqvJP.rKougwdICJ(5), (object) Dhgssiwum3QkgMqvJP.dOfult8pci(quote.DateTime, true, true), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(quote.Bid), (object) quote.BidSize, (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(quote.Ask), (object) quote.AskSize);
              break;
            case (qct4K92XRXgWAtpVGR) 3:
              Bar bar = (Bar) this.WF0dC3KCxx[index];
              if (bar.BarType != BarType.Time)
                throw new Exception(RNaihRhYEl0wUmAftnB.aYu7exFQKN(10912));
              streamWriter.WriteLine(Dhgssiwum3QkgMqvJP.rKougwdICJ(8), (object) Dhgssiwum3QkgMqvJP.dOfult8pci(bar.DateTime, true, false), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(bar.Open), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(bar.High), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(bar.Low), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(bar.Close), (object) bar.Volume, (object) bar.OpenInt, (object) bar.Size);
              break;
            case (qct4K92XRXgWAtpVGR) 4:
              Daily daily = (Daily) this.WF0dC3KCxx[index];
              streamWriter.WriteLine(Dhgssiwum3QkgMqvJP.rKougwdICJ(7), (object) Dhgssiwum3QkgMqvJP.dOfult8pci(daily.DateTime, false, false), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(daily.Open), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(daily.High), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(daily.Low), (object) Dhgssiwum3QkgMqvJP.UecuugvaPO(daily.Close), (object) daily.Volume, (object) daily.OpenInt);
              break;
          }
          int num2 = (int) ((double) index / (double) this.WF0dC3KCxx.Count * 100.0);
          if (num2 > num1)
          {
            num1 = num2;
            this.aOSdOr0cLL(new object[1]
            {
              (object) num2
            });
          }
        }
        streamWriter.Close();
      }
      catch (Exception ex)
      {
        flag = true;
        this.n0ndyRA15v((object) (RNaihRhYEl0wUmAftnB.aYu7exFQKN(10980) + Environment.NewLine + ex.Message), (object) MessageBoxIcon.Hand);
      }
      finally
      {
        if (!flag)
        {
          if (this.S3wdKqqOTC)
            this.n0ndyRA15v((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(11070), (object) MessageBoxIcon.Asterisk);
          else
            this.n0ndyRA15v((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(11138), (object) MessageBoxIcon.Exclamation);
        }
      }
    }
  }
}
