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
			this.components = (IContainer)new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProviderErrorDetailsForm));
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.tbxDateTime = new TextBox();
			this.tbxProvider = new TextBox();
			this.tbxId = new TextBox();
			this.tbxCode = new TextBox();
			this.label5 = new Label();
			this.tbxMessage = new TextBox();
			this.btnClose = new Button();
			this.btnPrev = new Button();
			this.btnNext = new Button();
			this.toolTip = new ToolTip(this.components);
			this.btnMsgToClipboard = new Button();
			this.SuspendLayout();
			this.label1.Location = new Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "DateTime:";
			this.label2.Location = new Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new Size(63, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Provider:";
			this.label3.Location = new Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new Size(63, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Id:";
			this.label4.Location = new Point(16, 64);
			this.label4.Name = "label4";
			this.label4.Size = new Size(63, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Code:";
			this.tbxDateTime.BorderStyle = BorderStyle.None;
			this.tbxDateTime.Location = new Point(80, 16);
			this.tbxDateTime.Name = "tbxDateTime";
			this.tbxDateTime.ReadOnly = true;
			this.tbxDateTime.Size = new Size(149, 13);
			this.tbxDateTime.TabIndex = 4;
			this.tbxProvider.BorderStyle = BorderStyle.None;
			this.tbxProvider.Location = new Point(80, 32);
			this.tbxProvider.Name = "tbxProvider";
			this.tbxProvider.ReadOnly = true;
			this.tbxProvider.Size = new Size(149, 13);
			this.tbxProvider.TabIndex = 5;
			this.tbxId.BorderStyle = BorderStyle.None;
			this.tbxId.Location = new Point(80, 48);
			this.tbxId.Name = "tbxId";
			this.tbxId.ReadOnly = true;
			this.tbxId.Size = new Size(149, 13);
			this.tbxId.TabIndex = 6;
			this.tbxCode.BorderStyle = BorderStyle.None;
			this.tbxCode.Location = new Point(80, 64);
			this.tbxCode.Name = "tbxCode";
			this.tbxCode.ReadOnly = true;
			this.tbxCode.Size = new Size(149, 13);
			this.tbxCode.TabIndex = 7;
			this.label5.Location = new Point(16, 88);
			this.label5.Name = "label5";
			this.label5.Size = new Size(63, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Message:";
			this.tbxMessage.Location = new Point(16, 107);
			this.tbxMessage.Multiline = true;
			this.tbxMessage.Name = "tbxMessage";
			this.tbxMessage.ReadOnly = true;
			this.tbxMessage.ScrollBars = ScrollBars.Both;
			this.tbxMessage.Size = new Size(399, 140);
			this.tbxMessage.TabIndex = 9;
			this.btnClose.DialogResult = DialogResult.Cancel;
			this.btnClose.Location = new Point(335, 263);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(80, 24);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnPrev.Image = (Image)componentResourceManager.GetObject("btnPrev.Image");
			this.btnPrev.Location = new Point(363, 16);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new Size(23, 23);
			this.btnPrev.TabIndex = 11;
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new EventHandler(this.btnPrev_Click);
			this.btnNext.Image = (Image)componentResourceManager.GetObject("btnNext.Image");
			this.btnNext.Location = new Point(392, 16);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new Size(23, 23);
			this.btnNext.TabIndex = 12;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new EventHandler(this.btnNext_Click);
			this.btnMsgToClipboard.Location = new Point(16, 263);
			this.btnMsgToClipboard.Name = "btnMsgToClipboard";
			this.btnMsgToClipboard.Size = new Size(149, 24);
			this.btnMsgToClipboard.TabIndex = 13;
			this.btnMsgToClipboard.Text = "Copy message to clipboard";
			this.btnMsgToClipboard.UseVisualStyleBackColor = true;
			this.btnMsgToClipboard.Click += new EventHandler(this.btnMsgToClipboard_Click);
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = (IButtonControl)this.btnClose;
			this.ClientSize = new Size(433, 298);
			this.Controls.Add((Control)this.btnMsgToClipboard);
			this.Controls.Add((Control)this.btnNext);
			this.Controls.Add((Control)this.btnPrev);
			this.Controls.Add((Control)this.btnClose);
			this.Controls.Add((Control)this.tbxMessage);
			this.Controls.Add((Control)this.label5);
			this.Controls.Add((Control)this.tbxCode);
			this.Controls.Add((Control)this.tbxId);
			this.Controls.Add((Control)this.tbxProvider);
			this.Controls.Add((Control)this.tbxDateTime);
			this.Controls.Add((Control)this.label4);
			this.Controls.Add((Control)this.label3);
			this.Controls.Add((Control)this.label2);
			this.Controls.Add((Control)this.label1);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProviderErrorDetailsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Provider Error Details";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
