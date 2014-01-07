// Type: OpenQuant.QuantBase.ConnectionPromptWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.QuantBase
{
  internal class ConnectionPromptWindow : Form
  {
    private IContainer components;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox tbxURL;
    private TextBox tbxUsername;
    private TextBox tbxPassword;
    private Button btnConnect;
    private Button btnCancel;
    private ConnectionSettings settings;

    public ConnectionPromptWindow()
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
      this.tbxURL = new TextBox();
      this.tbxUsername = new TextBox();
      this.tbxPassword = new TextBox();
      this.btnConnect = new Button();
      this.btnCancel = new Button();
      this.SuspendLayout();
      this.label1.Location = new Point(16, 20);
      this.label1.Name = "label1";
      this.label1.Size = new Size(71, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "URL";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(16, 48);
      this.label2.Name = "label2";
      this.label2.Size = new Size(71, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Username";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(16, 76);
      this.label3.Name = "label3";
      this.label3.Size = new Size(71, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Password";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.tbxURL.Location = new Point(92, 20);
      this.tbxURL.Name = "tbxURL";
      this.tbxURL.Size = new Size(237, 20);
      this.tbxURL.TabIndex = 3;
      this.tbxUsername.Location = new Point(92, 48);
      this.tbxUsername.Name = "tbxUsername";
      this.tbxUsername.Size = new Size(152, 20);
      this.tbxUsername.TabIndex = 4;
      this.tbxPassword.Location = new Point(92, 76);
      this.tbxPassword.Name = "tbxPassword";
      this.tbxPassword.Size = new Size(152, 20);
      this.tbxPassword.TabIndex = 5;
      this.tbxPassword.UseSystemPasswordChar = true;
      this.btnConnect.DialogResult = DialogResult.OK;
      this.btnConnect.Location = new Point(85, 118);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new Size(85, 24);
      this.btnConnect.TabIndex = 6;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(182, 118);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(85, 24);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.btnConnect;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(350, 157);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnConnect);
      this.Controls.Add((Control) this.tbxPassword);
      this.Controls.Add((Control) this.tbxUsername);
      this.Controls.Add((Control) this.tbxURL);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ConnectionPromptWindow";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Connect To QuantBase";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void Init(ConnectionSettings settings)
    {
      this.settings = settings;
    }

    protected override void OnShown(EventArgs e)
    {
      this.tbxURL.Text = this.settings.URL;
      this.tbxUsername.Text = this.settings.Username;
      this.tbxPassword.Text = this.settings.Password;
      base.OnShown(e);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK)
      {
        this.settings.URL = this.tbxURL.Text.Trim();
        this.settings.Username = this.tbxUsername.Text.Trim();
      }
      base.OnFormClosed(e);
    }
  }
}
