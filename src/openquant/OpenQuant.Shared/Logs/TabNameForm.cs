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
            this.tbxTabName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTabName
            // 
            this.tbxTabName.Location = new System.Drawing.Point(20, 16);
            this.tbxTabName.Name = "tbxTabName";
            this.tbxTabName.Size = new System.Drawing.Size(216, 20);
            this.tbxTabName.TabIndex = 0;
            this.tbxTabName.TextChanged += new System.EventHandler(this.tbxTabName_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(68, 52);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 24);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(134, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TabNameForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(261, 84);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxTabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TabNameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
