using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Logs
{
	class TabNameForm : Form
	{
		private IContainer components;
		private TextBox tbxTabName;
		private Button btnOK;
		private Button btnCancel;

		public string TabName
		{
			get
			{
				return this.tbxTabName.Text.Trim();
			}
			set
			{
				this.tbxTabName.Text = value;
			}
		}

		public TabNameForm()
		{
			this.InitializeComponent();
			this.UpdateOKButtonStatus();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.tbxTabName = new TextBox();
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.SuspendLayout();
			this.tbxTabName.Location = new Point(20, 16);
			this.tbxTabName.Name = "tbxTabName";
			this.tbxTabName.Size = new Size(216, 20);
			this.tbxTabName.TabIndex = 0;
			this.tbxTabName.TextChanged += new EventHandler(this.tbxTabName_TextChanged);
			this.btnOK.DialogResult = DialogResult.OK;
			this.btnOK.Location = new Point(68, 52);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new Size(60, 24);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.Location = new Point(134, 52);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(60, 24);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.AcceptButton = (IButtonControl)this.btnOK;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = (IButtonControl)this.btnCancel;
			this.ClientSize = new Size(258, 84);
			this.Controls.Add((Control)this.btnCancel);
			this.Controls.Add((Control)this.btnOK);
			this.Controls.Add((Control)this.tbxTabName);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TabNameForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Tab Name";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void tbxTabName_TextChanged(object sender, EventArgs e)
		{
			this.UpdateOKButtonStatus();
		}

		private void UpdateOKButtonStatus()
		{
			this.btnOK.Enabled = !string.IsNullOrEmpty(this.TabName);
		}
	}
}
