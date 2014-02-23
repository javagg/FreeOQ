using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
  class SaveTemplateDialog : Form
  {
    private string[] names;
    private Label label1;
    private ComboBox cbxNames;
    private Button btnOk;
    private Button btnCancel;
        private IContainer components = null;

    public string TemplateName
    {
      get
      {
        return this.cbxNames.Text.Trim();
      }
    }

    public SaveTemplateDialog()
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
      this.cbxNames = new ComboBox();
      this.btnOk = new Button();
      this.btnCancel = new Button();
      this.SuspendLayout();
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(152, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Select or type template name";
      this.cbxNames.Location = new Point(32, 32);
      this.cbxNames.Name = "cbxNames";
      this.cbxNames.Size = new Size(160, 21);
      this.cbxNames.TabIndex = 1;
      this.cbxNames.Text = "comboBox1";
      this.cbxNames.TextChanged += new EventHandler(this.cbxNames_TextChanged);
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(40, 64);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(72, 24);
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "OK";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(120, 64);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(64, 24);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(226, 103);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.cbxNames);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.HelpButton = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SaveTemplateDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Save Template As...";
      this.ResumeLayout(false);
    }

    public void SetNames(string[] names)
    {
      this.names = names;
      this.cbxNames.BeginUpdate();
      this.cbxNames.Items.Clear();
      foreach (object obj in names)
        this.cbxNames.Items.Add(obj);
      this.cbxNames.Text = "";
      this.cbxNames.EndUpdate();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      string templateName = this.TemplateName;
      bool flag = false;
      foreach (string str in this.names)
      {
        if (str == templateName)
        {
          flag = true;
          break;
        }
      }
      if (flag)
      {
        if (MessageBox.Show("Template with name '" + templateName + "' already exists." + Environment.NewLine + "Do you want to override it?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
          e.Cancel = true;
      }
      base.OnClosing(e);
    }

    private void cbxNames_TextChanged(object sender, EventArgs e)
    {
      this.btnOk.Enabled = this.TemplateName != "";
    }
  }
}
