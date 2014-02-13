using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
  public class ImportWizardForm : Form
  {
    private WizardPage[] pages;
    private int currentPageIndex;
    private Panel panel2;
    private Button btnClose;
    private Button btnNext;
    private Button btnBack;
    private GroupBox groupBox1;
    private Panel panelButtons;
    private Panel panelPages;
    private Panel panel1;
    private Container components;

    public ImportWizardForm(DirectoryInfo templateDirectory)
    {
      this.InitializeComponent();
      this.pages = new WizardPage[3]
      {
        (WizardPage) new FilePage(),
        (WizardPage) new TemplatePage(),
        (WizardPage) new ImportPage()
      };
      this.currentPageIndex = -1;
      ImportSettings settings = new ImportSettings();
      foreach (WizardPage wizardPage in this.pages)
      {
        wizardPage.SetSettings(settings);
        wizardPage.SetTemplateDirectory(templateDirectory);
        wizardPage.ButtonEnabledChanged += new EventHandler(this.OnButtonEnabledChanged);
      }
      this.Goto(1);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelButtons = new Panel();
      this.panel2 = new Panel();
      this.btnClose = new Button();
      this.btnNext = new Button();
      this.btnBack = new Button();
      this.groupBox1 = new GroupBox();
      this.panel1 = new Panel();
      this.panelPages = new Panel();
      this.panelButtons.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      this.panelButtons.Controls.Add((Control) this.panel2);
      this.panelButtons.Controls.Add((Control) this.groupBox1);
      this.panelButtons.Controls.Add((Control) this.panel1);
      this.panelButtons.Dock = DockStyle.Bottom;
      this.panelButtons.Location = new Point(0, 103);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new Size(370, 56);
      this.panelButtons.TabIndex = 0;
      this.panel2.Controls.Add((Control) this.btnClose);
      this.panel2.Controls.Add((Control) this.btnNext);
      this.panel2.Controls.Add((Control) this.btnBack);
      this.panel2.Dock = DockStyle.Right;
      this.panel2.Location = new Point(58, 11);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(312, 45);
      this.panel2.TabIndex = 0;
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(224, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(72, 24);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "Close";
      this.btnNext.Location = new Point(96, 12);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new Size(72, 24);
      this.btnNext.TabIndex = 1;
      this.btnNext.Text = "Next >";
      this.btnNext.Click += new EventHandler(this.btnNext_Click);
      this.btnBack.Location = new Point(16, 12);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new Size(72, 24);
      this.btnBack.TabIndex = 0;
      this.btnBack.Text = "< Back";
      this.btnBack.Click += new EventHandler(this.btnBack_Click);
      this.groupBox1.Dock = DockStyle.Top;
      this.groupBox1.Location = new Point(0, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(370, 3);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(370, 8);
      this.panel1.TabIndex = 2;
      this.panelPages.Dock = DockStyle.Fill;
      this.panelPages.Location = new Point(0, 0);
      this.panelPages.Name = "panelPages";
      this.panelPages.Size = new Size(370, 103);
      this.panelPages.TabIndex = 1;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(370, 159);
      this.Controls.Add((Control) this.panelPages);
      this.Controls.Add((Control) this.panelButtons);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.HelpButton = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ImportWizardForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import Wizard";
      this.panelButtons.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      WizardPage wizardPage = this.pages[this.currentPageIndex];
      if (wizardPage.CanClose)
        wizardPage.BeforeClose();
      else
        e.Cancel = true;
      base.OnClosing(e);
    }

    private void Goto(int shift)
    {
      if (this.currentPageIndex != -1)
      {
        if (shift == 1)
          this.pages[this.currentPageIndex].BeforeNext();
        if (shift == -1)
          this.pages[this.currentPageIndex].BeforeBack();
      }
      this.currentPageIndex += shift;
      WizardPage wizardPage = this.pages[this.currentPageIndex];
      int num1 = wizardPage.Width + SystemInformation.FixedFrameBorderSize.Width * 2;
      int num2 = wizardPage.Height + this.panelButtons.Height + SystemInformation.CaptionHeight + SystemInformation.FixedFrameBorderSize.Height * 2;
      ImportWizardForm importWizardForm1 = this;
      int num3 = importWizardForm1.Left + (this.Width - num1) / 2;
      importWizardForm1.Left = num3;
      ImportWizardForm importWizardForm2 = this;
      int num4 = importWizardForm2.Top + (this.Height - num2) / 2;
      importWizardForm2.Top = num4;
      if (this.Left < 0)
        this.Left = 0;
      if (this.Top < 0)
        this.Top = 0;
      this.Width = num1;
      this.Height = num2;
      this.Text = "Import Wizard - Step " + (this.currentPageIndex + 1).ToString() + " of " + this.pages.Length.ToString() + " - " + wizardPage.Title;
      wizardPage.BeforeLoad();
      this.panelPages.Controls.Clear();
      this.panelPages.Controls.Add((Control) wizardPage);
      this.UpdateButtonStatus();
    }

    private void UpdateButtonStatus()
    {
      WizardPage wizardPage = this.pages[this.currentPageIndex];
      this.btnBack.Enabled = wizardPage.CanBack;
      this.btnNext.Enabled = wizardPage.CanNext;
      this.btnClose.Enabled = wizardPage.CanClose;
    }

    private void OnButtonEnabledChanged(object sender, EventArgs e)
    {
      this.UpdateButtonStatus();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
      this.Goto(-1);
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      this.Goto(1);
    }
  }
}
