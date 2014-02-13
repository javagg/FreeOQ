//using OpenQuant.API;
using FreeQuant.Indicators;
using FreeQuant.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

using Indicator = FreeQuant.Indicators.Indicator;
using TimeSeries = FreeQuant.Series.TimeSeries;

namespace OpenQuant.Shared.Charting
{
	partial class AddIndicatorForm
  {
    private IContainer components;
    private Button btnCancel;
    private Button btnOk;
    private TextBox txtName;
    private Label label1;
    private GroupBox groupBox1;
    private GroupBox groupBox3;
    private ComboBox cbxSeries;
    private Label label4;
    private PropertyGrid propertyGrid1;
    private CheckBox cbxNewPad;
    private ComboBox cbxPads;

  
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnCancel = new Button();
      this.btnOk = new Button();
      this.txtName = new TextBox();
      this.label1 = new Label();
      this.groupBox1 = new GroupBox();
      this.cbxNewPad = new CheckBox();
      this.cbxPads = new ComboBox();
      this.cbxSeries = new ComboBox();
      this.label4 = new Label();
      this.groupBox3 = new GroupBox();
      this.propertyGrid1 = new PropertyGrid();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(205, 248);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(57, 21);
      this.btnCancel.TabIndex = 0;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(142, 248);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(57, 21);
      this.btnOk.TabIndex = 1;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new EventHandler(this.btnOk_Click);
      this.txtName.Location = new Point(49, 19);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(192, 20);
      this.txtName.TabIndex = 2;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(7, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(35, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Name";
      this.groupBox1.Controls.Add((Control) this.cbxNewPad);
      this.groupBox1.Controls.Add((Control) this.cbxPads);
      this.groupBox1.Controls.Add((Control) this.cbxSeries);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.txtName);
      this.groupBox1.Location = new Point(12, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(253, 102);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Settings";
      this.cbxNewPad.AutoSize = true;
      this.cbxNewPad.Location = new Point(97, 77);
      this.cbxNewPad.Name = "cbxNewPad";
      this.cbxNewPad.Size = new Size(101, 17);
      this.cbxNewPad.TabIndex = 16;
      this.cbxNewPad.Text = "Create new pad";
      this.cbxNewPad.UseVisualStyleBackColor = true;
      this.cbxNewPad.CheckedChanged += new EventHandler(this.cbxNewPad_CheckedChanged);
      this.cbxPads.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxPads.FormattingEnabled = true;
      this.cbxPads.Location = new Point(49, 73);
      this.cbxPads.Name = "cbxPads";
      this.cbxPads.Size = new Size(42, 21);
      this.cbxPads.TabIndex = 15;
      this.cbxSeries.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxSeries.FormattingEnabled = true;
      this.cbxSeries.Location = new Point(49, 45);
      this.cbxSeries.Name = "cbxSeries";
      this.cbxSeries.Size = new Size(192, 21);
      this.cbxSeries.TabIndex = 13;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(7, 45);
      this.label4.Name = "label4";
      this.label4.Size = new Size(36, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "Series";
      this.groupBox3.Controls.Add((Control) this.propertyGrid1);
      this.groupBox3.Location = new Point(12, 111);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(253, 130);
      this.groupBox3.TabIndex = 10;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Parmeters";
      this.propertyGrid1.Dock = DockStyle.Fill;
      this.propertyGrid1.HelpVisible = false;
      this.propertyGrid1.Location = new Point(3, 16);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new Size(247, 111);
      this.propertyGrid1.TabIndex = 0;
      this.propertyGrid1.ToolbarVisible = false;
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(274, 274);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnOk);
      this.Controls.Add((Control) this.btnCancel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AddIndicatorForm";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Add Indicator";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);
    }

  }
}
