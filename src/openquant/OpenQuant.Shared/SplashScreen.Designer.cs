using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace OpenQuant.Shared
{
	partial class SplashScreen
	{
        private System.ComponentModel.IContainer components = null;
		private PictureBox pictureBox;
		private Label lblProgress;
		private Label label1;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
		    this.pictureBox = new System.Windows.Forms.PictureBox();
		    this.lblProgress = new System.Windows.Forms.Label();
		    this.label1 = new System.Windows.Forms.Label();
		    ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
		    this.SuspendLayout();
		    // 
		    // pictureBox
		    // 
		    this.pictureBox.BackColor = System.Drawing.Color.White;
		    this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.pictureBox.Image = global::OpenQuant.Shared.Properties.Resources.logo;
		    this.pictureBox.Location = new System.Drawing.Point(1, 28);
		    this.pictureBox.Name = "pictureBox";
		    this.pictureBox.Size = new System.Drawing.Size(401, 156);
		    this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		    this.pictureBox.TabIndex = 0;
		    this.pictureBox.TabStop = false;
		    // 
		    // lblProgress
		    // 
		    this.lblProgress.BackColor = System.Drawing.SystemColors.Control;
		    this.lblProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
		    this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.lblProgress.Location = new System.Drawing.Point(1, 184);
		    this.lblProgress.Name = "lblProgress";
		    this.lblProgress.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
		    this.lblProgress.Size = new System.Drawing.Size(401, 30);
		    this.lblProgress.TabIndex = 1;
		    this.lblProgress.Text = "Loading...";
		    // 
		    // label1
		    // 
		    this.label1.BackColor = System.Drawing.Color.White;
		    this.label1.Dock = System.Windows.Forms.DockStyle.Top;
		    this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.label1.ForeColor = System.Drawing.Color.SteelBlue;
		    this.label1.Location = new System.Drawing.Point(1, 1);
		    this.label1.Name = "label1";
		    this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
		    this.label1.Size = new System.Drawing.Size(401, 27);
		    this.label1.TabIndex = 2;
		    this.label1.Text = "Copyright (c) 2013-2014 SmartQuant Ltd. All rights reserved.";
		    this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		    // 
		    // SplashScreen
		    // 
		    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		    this.BackColor = System.Drawing.SystemColors.Control;
		    this.ClientSize = new System.Drawing.Size(403, 214);
		    this.ControlBox = false;
		    this.Controls.Add(this.pictureBox);
		    this.Controls.Add(this.label1);
		    this.Controls.Add(this.lblProgress);
		    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		    this.Name = "SplashScreen";
		    this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
		    this.ShowIcon = false;
		    this.ShowInTaskbar = false;
		    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		    this.Text = "SplashScreen";
		    ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
		    this.ResumeLayout(false);
		}
	}
}
