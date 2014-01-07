// Type: SmartQuant.Shared.Data.Import.CSV.ImportWizardForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class ImportWizardForm : Form
  {
    private WizardPage[] sTnli5yEeE;
    private int WWml9RPrxc;
    private Panel Yhil3Gc8rm;
    private Button IDGlWYLJ5U;
    private Button DhKlTkiguY;
    private Button Y7TlfiF3x8;
    private GroupBox FD7lyUYFKD;
    private Panel cZ5lOa3TSP;
    private Panel QOtlaSYM9P;
    private Panel xYXlGoJN5g;
    private Container yOylZxpifj;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImportWizardForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.JJvlgLp6AB();
      this.sTnli5yEeE = new WizardPage[3]
      {
        (WizardPage) new FilePage(),
        (WizardPage) new TemplatePage(),
        (WizardPage) new ImportPage()
      };
      this.WWml9RPrxc = -1;
      ImportSettings settings = new ImportSettings();
      foreach (WizardPage wizardPage in this.sTnli5yEeE)
      {
        wizardPage.SetSettings(settings);
        wizardPage.ButtonEnabledChanged += new EventHandler(this.X8klnxJNy1);
      }
      this.CI5lMjAEWw(1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.yOylZxpifj != null)
        this.yOylZxpifj.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JJvlgLp6AB()
    {
      this.cZ5lOa3TSP = new Panel();
      this.Yhil3Gc8rm = new Panel();
      this.IDGlWYLJ5U = new Button();
      this.DhKlTkiguY = new Button();
      this.Y7TlfiF3x8 = new Button();
      this.FD7lyUYFKD = new GroupBox();
      this.xYXlGoJN5g = new Panel();
      this.QOtlaSYM9P = new Panel();
      this.cZ5lOa3TSP.SuspendLayout();
      this.Yhil3Gc8rm.SuspendLayout();
      this.SuspendLayout();
      this.cZ5lOa3TSP.Controls.Add((Control) this.Yhil3Gc8rm);
      this.cZ5lOa3TSP.Controls.Add((Control) this.FD7lyUYFKD);
      this.cZ5lOa3TSP.Controls.Add((Control) this.xYXlGoJN5g);
      this.cZ5lOa3TSP.Dock = DockStyle.Bottom;
      this.cZ5lOa3TSP.Location = new Point(0, 103);
      this.cZ5lOa3TSP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21462);
      this.cZ5lOa3TSP.Size = new Size(370, 56);
      this.cZ5lOa3TSP.TabIndex = 0;
      this.Yhil3Gc8rm.Controls.Add((Control) this.IDGlWYLJ5U);
      this.Yhil3Gc8rm.Controls.Add((Control) this.DhKlTkiguY);
      this.Yhil3Gc8rm.Controls.Add((Control) this.Y7TlfiF3x8);
      this.Yhil3Gc8rm.Dock = DockStyle.Right;
      this.Yhil3Gc8rm.Location = new Point(58, 11);
      this.Yhil3Gc8rm.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21490);
      this.Yhil3Gc8rm.Size = new Size(312, 45);
      this.Yhil3Gc8rm.TabIndex = 0;
      this.IDGlWYLJ5U.DialogResult = DialogResult.Cancel;
      this.IDGlWYLJ5U.Location = new Point(224, 12);
      this.IDGlWYLJ5U.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21506);
      this.IDGlWYLJ5U.Size = new Size(72, 24);
      this.IDGlWYLJ5U.TabIndex = 2;
      this.IDGlWYLJ5U.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21526);
      this.DhKlTkiguY.Location = new Point(96, 12);
      this.DhKlTkiguY.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21540);
      this.DhKlTkiguY.Size = new Size(72, 24);
      this.DhKlTkiguY.TabIndex = 1;
      this.DhKlTkiguY.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21558);
      this.DhKlTkiguY.Click += new EventHandler(this.TYXlLCAJAp);
      this.Y7TlfiF3x8.Location = new Point(16, 12);
      this.Y7TlfiF3x8.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21574);
      this.Y7TlfiF3x8.Size = new Size(72, 24);
      this.Y7TlfiF3x8.TabIndex = 0;
      this.Y7TlfiF3x8.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21592);
      this.Y7TlfiF3x8.Click += new EventHandler(this.wY9l705YYP);
      this.FD7lyUYFKD.Dock = DockStyle.Top;
      this.FD7lyUYFKD.Location = new Point(0, 8);
      this.FD7lyUYFKD.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21608);
      this.FD7lyUYFKD.Size = new Size(370, 3);
      this.FD7lyUYFKD.TabIndex = 1;
      this.FD7lyUYFKD.TabStop = false;
      this.xYXlGoJN5g.Dock = DockStyle.Top;
      this.xYXlGoJN5g.Location = new Point(0, 0);
      this.xYXlGoJN5g.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21630);
      this.xYXlGoJN5g.Size = new Size(370, 8);
      this.xYXlGoJN5g.TabIndex = 2;
      this.QOtlaSYM9P.Dock = DockStyle.Fill;
      this.QOtlaSYM9P.Location = new Point(0, 0);
      this.QOtlaSYM9P.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21646);
      this.QOtlaSYM9P.Size = new Size(370, 103);
      this.QOtlaSYM9P.TabIndex = 1;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.IDGlWYLJ5U;
      this.ClientSize = new Size(370, 159);
      this.Controls.Add((Control) this.QOtlaSYM9P);
      this.Controls.Add((Control) this.cZ5lOa3TSP);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.HelpButton = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21670);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.Manual;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21706);
      this.cZ5lOa3TSP.ResumeLayout(false);
      this.Yhil3Gc8rm.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnClosing(CancelEventArgs e)
    {
      WizardPage wizardPage = this.sTnli5yEeE[this.WWml9RPrxc];
      if (wizardPage.CanClose)
        wizardPage.BeforeClose();
      else
        e.Cancel = true;
      base.OnClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CI5lMjAEWw([In] int obj0)
    {
      if (this.WWml9RPrxc != -1)
      {
        if (obj0 == 1)
          this.sTnli5yEeE[this.WWml9RPrxc].BeforeNext();
        if (obj0 == -1)
          this.sTnli5yEeE[this.WWml9RPrxc].BeforeBack();
      }
      this.WWml9RPrxc += obj0;
      WizardPage wizardPage = this.sTnli5yEeE[this.WWml9RPrxc];
      int width = wizardPage.Width + SystemInformation.FixedFrameBorderSize.Width * 2;
      int height = wizardPage.Height + this.cZ5lOa3TSP.Height + SystemInformation.CaptionHeight + SystemInformation.FixedFrameBorderSize.Height * 2;
      this.DesktopBounds = new Rectangle((Screen.PrimaryScreen.Bounds.Width - width) / 2, (Screen.PrimaryScreen.Bounds.Height - height) / 2, width, height);
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21736) + (this.WWml9RPrxc + 1).ToString() + RNaihRhYEl0wUmAftnB.aYu7exFQKN(21782) + this.sTnli5yEeE.Length.ToString() + RNaihRhYEl0wUmAftnB.aYu7exFQKN(21794) + wizardPage.Title;
      wizardPage.BeforeLoad();
      this.QOtlaSYM9P.Controls.Clear();
      this.QOtlaSYM9P.Controls.Add((Control) wizardPage);
      this.p02lJwUg3d();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void p02lJwUg3d()
    {
      WizardPage wizardPage = this.sTnli5yEeE[this.WWml9RPrxc];
      this.Y7TlfiF3x8.Enabled = wizardPage.CanBack;
      this.DhKlTkiguY.Enabled = wizardPage.CanNext;
      this.IDGlWYLJ5U.Enabled = wizardPage.CanClose;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void X8klnxJNy1([In] object obj0, [In] EventArgs obj1)
    {
      this.p02lJwUg3d();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wY9l705YYP([In] object obj0, [In] EventArgs obj1)
    {
      this.CI5lMjAEWw(-1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TYXlLCAJAp([In] object obj0, [In] EventArgs obj1)
    {
      this.CI5lMjAEWw(1);
    }
  }
}
