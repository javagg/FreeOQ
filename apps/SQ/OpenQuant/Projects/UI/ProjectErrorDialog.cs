// Type: OpenQuant.Projects.UI.ProjectErrorDialog
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Trading;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  public class ProjectErrorDialog : Form
  {
    private IContainer components;
    private Button btnAbort;
    private Button btnIgnore;
    private TextBox tbxDescription;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label lblDateTime;
    private Label lblMethod;
    private CheckBox chbShowDetails;
    private StrategyError error;

    public bool AllowIgnore
    {
      get
      {
        return this.btnIgnore.Enabled;
      }
      set
      {
        this.btnIgnore.Enabled = value;
      }
    }

    public ProjectErrorDialog()
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
      this.tbxDescription = new TextBox();
      this.btnIgnore = new Button();
      this.btnAbort = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.lblDateTime = new Label();
      this.lblMethod = new Label();
      this.chbShowDetails = new CheckBox();
      this.SuspendLayout();
      this.tbxDescription.Location = new Point(16, 88);
      this.tbxDescription.Multiline = true;
      this.tbxDescription.Name = "tbxDescription";
      this.tbxDescription.ReadOnly = true;
      this.tbxDescription.ScrollBars = ScrollBars.Vertical;
      this.tbxDescription.Size = new Size(368, 80);
      this.tbxDescription.TabIndex = 1;
      this.btnIgnore.DialogResult = DialogResult.Ignore;
      this.btnIgnore.Location = new Point(297, 181);
      this.btnIgnore.Name = "btnIgnore";
      this.btnIgnore.Size = new Size(69, 22);
      this.btnIgnore.TabIndex = 0;
      this.btnIgnore.Text = "Ignore";
      this.btnIgnore.UseVisualStyleBackColor = true;
      this.btnAbort.DialogResult = DialogResult.Abort;
      this.btnAbort.Location = new Point(222, 181);
      this.btnAbort.Name = "btnAbort";
      this.btnAbort.Size = new Size(69, 22);
      this.btnAbort.TabIndex = 1;
      this.btnAbort.Text = "Abort";
      this.btnAbort.UseVisualStyleBackColor = true;
      this.label1.Location = new Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(60, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "DateTime";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(16, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(60, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Method";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(16, 64);
      this.label3.Name = "label3";
      this.label3.Size = new Size(64, 20);
      this.label3.TabIndex = 4;
      this.label3.Text = "Description";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.lblDateTime.Location = new Point(88, 16);
      this.lblDateTime.Name = "lblDateTime";
      this.lblDateTime.Size = new Size(270, 20);
      this.lblDateTime.TabIndex = 5;
      this.lblDateTime.Text = "DateTime";
      this.lblDateTime.TextAlign = ContentAlignment.MiddleLeft;
      this.lblMethod.Location = new Point(88, 40);
      this.lblMethod.Name = "lblMethod";
      this.lblMethod.Size = new Size(270, 20);
      this.lblMethod.TabIndex = 6;
      this.lblMethod.Text = "Method";
      this.lblMethod.TextAlign = ContentAlignment.MiddleLeft;
      this.chbShowDetails.Location = new Point(296, 64);
      this.chbShowDetails.Name = "chbShowDetails";
      this.chbShowDetails.Size = new Size(89, 24);
      this.chbShowDetails.TabIndex = 7;
      this.chbShowDetails.Text = "show details";
      this.chbShowDetails.UseVisualStyleBackColor = true;
      this.chbShowDetails.CheckedChanged += new EventHandler(this.chbShowDetails_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(394, 216);
      this.Controls.Add((Control) this.chbShowDetails);
      this.Controls.Add((Control) this.lblMethod);
      this.Controls.Add((Control) this.lblDateTime);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.btnAbort);
      this.Controls.Add((Control) this.tbxDescription);
      this.Controls.Add((Control) this.btnIgnore);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ProjectErrorDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Strategy Error";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void SetError(StrategyError error)
    {
      this.error = error;
      this.lblDateTime.Text = error.get_DateTime().ToString();
      this.lblMethod.Text = error.get_Exception().TargetSite.Name;
      this.ShowDescription();
    }

    private void ShowDescription()
    {
      if (this.chbShowDetails.Checked)
        this.tbxDescription.Text = ((object) this.error.get_Exception()).ToString();
      else
        this.tbxDescription.Text = this.error.get_Exception().Message;
    }

    private void chbShowDetails_CheckedChanged(object sender, EventArgs e)
    {
      this.ShowDescription();
    }
  }
}
