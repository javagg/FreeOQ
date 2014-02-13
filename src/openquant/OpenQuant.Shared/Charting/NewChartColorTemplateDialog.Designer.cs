using OpenQuant.Shared;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
	partial class NewChartColorTemplateDialog
  {
    private IContainer components;
    private TextBox textBox1;
    private Button button2;
    private Button button1;
    private Label label1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.textBox1 = new TextBox();
      this.button2 = new Button();
      this.button1 = new Button();
      this.label1 = new Label();
      this.SuspendLayout();
      this.textBox1.Location = new Point(12, 25);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(173, 20);
      this.textBox1.TabIndex = 4;
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.Location = new Point(132, 51);
      this.button2.Name = "button2";
      this.button2.Size = new Size(53, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      this.button1.DialogResult = DialogResult.OK;
      this.button1.Enabled = false;
      this.button1.Location = new Point(69, 51);
      this.button1.Name = "button1";
      this.button1.Size = new Size(57, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label1.Location = new Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(176, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Template Name";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button2;
      this.ClientSize = new Size(195, 78);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NewChartColorTemplateDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "New Template";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
