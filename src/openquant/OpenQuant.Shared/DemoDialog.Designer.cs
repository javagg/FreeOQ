using System.Windows.Forms;
using System.ComponentModel;

namespace OpenQuant.Shared
{
	partial class DemoDialog
	{
		private IContainer components;
		private Panel panel1;
		private Label label1;
		private Label lblDemoMessage;
		private Label lblProductInfo;
		private PictureBox pictureBox1;
		private Button btnOk;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDemoMessage = new System.Windows.Forms.Label();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(126, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(64, 22);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright (c) 1997-2013 SmartQuant Ltd. All rights reserved.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDemoMessage
            // 
            this.lblDemoMessage.BackColor = System.Drawing.Color.White;
            this.lblDemoMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDemoMessage.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblDemoMessage.Location = new System.Drawing.Point(0, 127);
            this.lblDemoMessage.Name = "lblDemoMessage";
            this.lblDemoMessage.Size = new System.Drawing.Size(314, 24);
            this.lblDemoMessage.TabIndex = 2;
            this.lblDemoMessage.Text = "DemoMessage here...";
            this.lblDemoMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.BackColor = System.Drawing.Color.White;
            this.lblProductInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProductInfo.Location = new System.Drawing.Point(0, 103);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(314, 24);
            this.lblProductInfo.TabIndex = 3;
            this.lblProductInfo.Text = "You are using an unlicensed copy of \'Product\'.";
            this.lblProductInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DemoDialog
            // 
            this.ClientSize = new System.Drawing.Size(314, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProductInfo);
            this.Controls.Add(this.lblDemoMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DemoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product (unlicensed copy)";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
