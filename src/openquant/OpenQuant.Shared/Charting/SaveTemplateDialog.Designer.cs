using OpenQuant.Shared;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
	partial class SaveTemplateDialog
  {

    private IContainer components;
    private Label label1;
    private Button button1;
    private Button button2;
    private TextBox textBox1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.textBox1 = new TextBox();
      this.SuspendLayout();
      this.label1.Location = new Point(9, 10);
      this.label1.Name = "label1";
      this.label1.Size = new Size(176, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Template Name";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.button1.DialogResult = DialogResult.OK;
      this.button1.Enabled = false;
      this.button1.Location = new Point(69, 52);
      this.button1.Name = "button1";
      this.button1.Size = new Size(57, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.Location = new Point(132, 52);
      this.button2.Name = "button2";
      this.button2.Size = new Size(53, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      this.textBox1.Location = new Point(12, 26);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(173, 20);
      this.textBox1.TabIndex = 0;
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.textBox1.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button2;
      this.ClientSize = new Size(197, 80);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SaveTemplateDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Save Template";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

 
  }
}
