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
			this.components = (IContainer)new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(InstrumentSelectorDialog));
			this.panel = new Panel();
			this.btnCancel = new Button();
			this.btnOk = new Button();
			this.groupBox = new GroupBox();
			this.panel1 = new Panel();
			this.btnRemove = new Button();
			this.btnAdd = new Button();
			this.panel3 = new Panel();
			this.label2 = new Label();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.toolTip = new ToolTip(this.components);
			this.selector1 = new InstrumentSelectorPanel();
			this.selector2 = new InstrumentSelectorPanel();
			this.panel.SuspendLayout();
			this.groupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			this.panel.Controls.Add((Control)this.btnCancel);
			this.panel.Controls.Add((Control)this.btnOk);
			this.panel.Dock = DockStyle.Bottom;
			this.panel.Location = new Point(4, 320);
			this.panel.Name = "panel";
			this.panel.Size = new Size(448, 42);
			this.panel.TabIndex = 0;
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.Location = new Point(370, 9);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(62, 24);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnOk.DialogResult = DialogResult.OK;
			this.btnOk.Location = new Point(300, 9);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new Size(62, 24);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.groupBox.Controls.Add((Control)this.panel1);
			this.groupBox.Controls.Add((Control)this.panel3);
			this.groupBox.Controls.Add((Control)this.panel2);
			this.groupBox.Dock = DockStyle.Fill;
			this.groupBox.Location = new Point(4, 0);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new Size(448, 320);
			this.groupBox.TabIndex = 1;
			this.groupBox.TabStop = false;
			this.panel1.Controls.Add((Control)this.btnRemove);
			this.panel1.Controls.Add((Control)this.btnAdd);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(203, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(42, 301);
			this.panel1.TabIndex = 2;
			this.btnRemove.Image = (Image)componentResourceManager.GetObject("btnRemove.Image");
			this.btnRemove.Location = new Point(5, 72);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new Size(32, 24);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
			this.btnAdd.Image = (Image)componentResourceManager.GetObject("btnAdd.Image");
			this.btnAdd.Location = new Point(5, 40);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new Size(32, 24);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
			this.panel3.Controls.Add((Control)this.selector1);
			this.panel3.Controls.Add((Control)this.label2);
			this.panel3.Dock = DockStyle.Left;
			this.panel3.Location = new Point(3, 16);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(200, 301);
			this.panel3.TabIndex = 4;
			this.label2.Dock = DockStyle.Top;
			this.label2.Location = new Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(200, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Available instruments";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.panel2.Controls.Add((Control)this.selector2);
			this.panel2.Controls.Add((Control)this.label1);
			this.panel2.Dock = DockStyle.Right;
			this.panel2.Location = new Point(245, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(200, 301);
			this.panel2.TabIndex = 3;
			this.label1.Dock = DockStyle.Top;
			this.label1.Location = new Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(200, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Selected instruments";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.selector1.Dock = DockStyle.Fill;
			this.selector1.Instruments = new Instrument[0];
			this.selector1.Location = new Point(0, 16);
			this.selector1.Name = "selector1";
			this.selector1.Size = new Size(200, 285);
			this.selector1.TabIndex = 1;
			this.selector2.Dock = DockStyle.Fill;
			this.selector2.Instruments = new Instrument[0];
			this.selector2.Location = new Point(0, 16);
			this.selector2.Name = "selector2";
			this.selector2.Size = new Size(200, 285);
			this.selector2.TabIndex = 2;
			this.AcceptButton = (IButtonControl)this.btnOk;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = (IButtonControl)this.btnCancel;
			this.ClientSize = new Size(456, 362);
			this.Controls.Add((Control)this.groupBox);
			this.Controls.Add((Control)this.panel);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InstrumentSelectorDialog";
			this.Padding = new Padding(4, 0, 4, 0);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
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
