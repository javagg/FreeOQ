using FreeQuant.Providers;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Providers
{
	class ProviderErrorDetailsForm : Form
	{
		private int index;
		private IContainer components;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox tbxDateTime;
		private TextBox tbxProvider;
		private TextBox tbxId;
		private TextBox tbxCode;
		private Label label5;
		private TextBox tbxMessage;
		private Button btnClose;
		private Button btnPrev;
		private Button btnNext;
		private ToolTip toolTip;
		private Button btnMsgToClipboard;

		public ProviderErrorDetailsForm()
		{
			this.InitializeComponent();
			this.toolTip.SetToolTip(this.btnPrev, "Previous error");
			this.toolTip.SetToolTip(this.btnNext, "Next error");
		}

		public void SetCurrentError(ProviderError error)
		{
			this.index = new ArrayList((ICollection)ProviderManager.Errors).IndexOf(error);
			this.UpdateDetails();
		}

		private void UpdateDetails()
		{
					ProviderError providerError = ProviderManager.Errors[this.index];
			this.tbxDateTime.Text = providerError.DateTime.ToString();
			this.tbxProvider.Text = providerError.Provider.Name;
			this.tbxId.Text = providerError.Id.ToString();
			this.tbxCode.Text = providerError.Code.ToString();
			this.tbxMessage.Text = providerError.Message;
			this.btnPrev.Enabled = this.index > 0;
			this.btnNext.Enabled = this.index < ProviderManager.Errors.Count - 1;
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			--this.index;
			this.UpdateDetails();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			++this.index;
			this.UpdateDetails();
		}

		private void btnMsgToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.tbxMessage.Text.Trim());
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderErrorDetailsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDateTime = new System.Windows.Forms.TextBox();
            this.tbxProvider = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnMsgToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DateTime:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provider:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code:";
            // 
            // tbxDateTime
            // 
            this.tbxDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDateTime.Location = new System.Drawing.Point(80, 16);
            this.tbxDateTime.Name = "tbxDateTime";
            this.tbxDateTime.ReadOnly = true;
            this.tbxDateTime.Size = new System.Drawing.Size(149, 13);
            this.tbxDateTime.TabIndex = 4;
            // 
            // tbxProvider
            // 
            this.tbxProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxProvider.Location = new System.Drawing.Point(80, 32);
            this.tbxProvider.Name = "tbxProvider";
            this.tbxProvider.ReadOnly = true;
            this.tbxProvider.Size = new System.Drawing.Size(149, 13);
            this.tbxProvider.TabIndex = 5;
            // 
            // tbxId
            // 
            this.tbxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxId.Location = new System.Drawing.Point(80, 48);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(149, 13);
            this.tbxId.TabIndex = 6;
            // 
            // tbxCode
            // 
            this.tbxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCode.Location = new System.Drawing.Point(80, 64);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.ReadOnly = true;
            this.tbxCode.Size = new System.Drawing.Size(149, 13);
            this.tbxCode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Message:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(16, 107);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ReadOnly = true;
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMessage.Size = new System.Drawing.Size(399, 140);
            this.tbxMessage.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(335, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 24);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(363, 16);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 23);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(392, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMsgToClipboard
            // 
            this.btnMsgToClipboard.Location = new System.Drawing.Point(16, 263);
            this.btnMsgToClipboard.Name = "btnMsgToClipboard";
            this.btnMsgToClipboard.Size = new System.Drawing.Size(149, 24);
            this.btnMsgToClipboard.TabIndex = 13;
            this.btnMsgToClipboard.Text = "Copy message to clipboard";
            this.btnMsgToClipboard.UseVisualStyleBackColor = true;
            this.btnMsgToClipboard.Click += new System.EventHandler(this.btnMsgToClipboard_Click);
            // 
            // ProviderErrorDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(433, 298);
            this.Controls.Add(this.btnMsgToClipboard);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.tbxProvider);
            this.Controls.Add(this.tbxDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProviderErrorDetailsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Provider Error Details";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
