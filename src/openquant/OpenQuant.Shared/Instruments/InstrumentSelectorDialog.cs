using FreeQuant.Instruments;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Instruments
{
	public class InstrumentSelectorDialog : Form
	{
		private IContainer components;
		private Panel panel;
		private GroupBox groupBox;
		private Panel panel1;
		private Button btnCancel;
		private Button btnOk;
		private Button btnRemove;
		private Button btnAdd;
		private Panel panel2;
		private InstrumentSelectorPanel selector2;
		private Label label1;
		private Panel panel3;
		private Label label2;
		private InstrumentSelectorPanel selector1;
		private ToolTip toolTip;

		public Instrument[] Instruments
		{
			set
			{
				this.selector1.Instruments = value;
			}
		}

		public Instrument[] SelectedInstruments
		{
			get
			{
				return this.selector2.Instruments;
			}
			set
			{
				this.selector2.Instruments = value;
			}
		}

		public InstrumentSelectorDialog()
		{
			this.InitializeComponent();
			this.toolTip.SetToolTip((Control)this.btnAdd, "Add to selected");
			this.toolTip.SetToolTip((Control)this.btnRemove, "Remove from selected");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentSelectorDialog));
            this.panel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selector1 = new OpenQuant.Shared.Instruments.InstrumentSelectorPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selector2 = new OpenQuant.Shared.Instruments.InstrumentSelectorPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnCancel);
            this.panel.Controls.Add(this.btnOk);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(4, 320);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(448, 42);
            this.panel.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(370, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(300, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(62, 24);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panel1);
            this.groupBox.Controls.Add(this.panel3);
            this.groupBox.Controls.Add(this.panel2);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(4, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(448, 320);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 301);
            this.panel1.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(5, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 24);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(5, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 24);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.selector1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 301);
            this.panel3.TabIndex = 4;
            // 
            // selector1
            // 
            this.selector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selector1.Instruments = new FreeQuant.Instruments.Instrument[0];
            this.selector1.Location = new System.Drawing.Point(0, 16);
            this.selector1.Name = "selector1";
            this.selector1.Size = new System.Drawing.Size(200, 285);
            this.selector1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available instruments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selector2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(245, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 301);
            this.panel2.TabIndex = 3;
            // 
            // selector2
            // 
            this.selector2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selector2.Instruments = new FreeQuant.Instruments.Instrument[0];
            this.selector2.Location = new System.Drawing.Point(0, 16);
            this.selector2.Name = "selector2";
            this.selector2.Size = new System.Drawing.Size(200, 285);
            this.selector2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected instruments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InstrumentSelectorDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(456, 362);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstrumentSelectorDialog";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Or Remove Instruments";
            this.panel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		protected override void OnLoad(EventArgs e)
		{
			this.selector1.RemoveInstruments(this.selector2.Instruments);
			base.OnLoad(e);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Instrument[] selectedInstruments = this.selector1.SelectedInstruments;
			this.selector2.AddInstruments(selectedInstruments);
			this.selector1.RemoveInstruments(selectedInstruments);
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			Instrument[] selectedInstruments = this.selector2.SelectedInstruments;
			this.selector1.AddInstruments(selectedInstruments);
			this.selector2.RemoveInstruments(selectedInstruments);
		}
	}
}
