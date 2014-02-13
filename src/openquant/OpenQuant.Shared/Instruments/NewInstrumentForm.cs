using OpenQuant.API;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Instruments
{
	class NewInstrumentForm : Form
	{
		private IContainer components;

		private GroupBox groupBox1;
		private Panel pnlButtons;
		private Button btnCancel;
		private Button btnOk;
		private Panel pnlType;
		private Label label2;
		private Panel pnlSymbol;
		private TextBox tbxSymbol;
		private Label label1;
		private ComboBox cbxInstrumentTypes;
		private Panel pnlMaturity;
		private DateTimePicker dtpMaturity;
		private Label label5;
		private Panel pnlCurrency;
		private TextBox tbxCurrency;
		private Label label4;
		private Panel pnlExchange;
		private TextBox tbxExchange;
		private Label label3;
		private Panel pnlStrike;
		private NumericUpDown nudStrike;
		private Label label7;
		private Panel pnlPutCall;
		private ComboBox cbxPutCall;
		private Label label6;

		public string Symbol
		{
			get
			{
				return this.tbxSymbol.Text.Trim();
			}
		}

		public InstrumentType InstrumentType
		{
			get
			{
				return (InstrumentType)this.cbxInstrumentTypes.SelectedItem;
			}
			set
			{
				this.cbxInstrumentTypes.SelectedItem = value;
			}
		}

		public string Exchange
		{
			get
			{
				return this.tbxExchange.Text.Trim();
			}
		}

		public string Currency
		{
			get
			{
				return this.tbxCurrency.Text.Trim();
			}
		}

		public DateTime Maturity
		{
			get
			{
				return this.dtpMaturity.Value.Date;
			}
		}

		public PutCall PutCall
		{
			get
			{
				return (PutCall)this.cbxPutCall.SelectedItem;
			}
		}

		public double Strike
		{
			get
			{
				return (double)this.nudStrike.Value;
			}
		}

		public NewInstrumentForm()
		{
			this.InitializeComponent();
			this.cbxInstrumentTypes.BeginUpdate();
			foreach (InstrumentType instrumentType in Enum.GetValues(typeof (InstrumentType)))
				this.cbxInstrumentTypes.Items.Add((object)instrumentType);
			this.cbxInstrumentTypes.SelectedItem = (object)InstrumentType.Stock;
			this.cbxInstrumentTypes.EndUpdate();
			this.dtpMaturity.Value = DateTime.Today;
			this.cbxPutCall.BeginUpdate();
			foreach (PutCall putCall in Enum.GetValues(typeof (PutCall)))
				this.cbxPutCall.Items.Add((object)putCall);
			this.cbxPutCall.SelectedItem = (object)PutCall.Put;
			this.cbxPutCall.EndUpdate();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.groupBox1 = new GroupBox();
			this.pnlButtons = new Panel();
			this.btnCancel = new Button();
			this.btnOk = new Button();
			this.pnlSymbol = new Panel();
			this.label1 = new Label();
			this.tbxSymbol = new TextBox();
			this.pnlType = new Panel();
			this.label2 = new Label();
			this.cbxInstrumentTypes = new ComboBox();
			this.pnlExchange = new Panel();
			this.tbxExchange = new TextBox();
			this.label3 = new Label();
			this.pnlCurrency = new Panel();
			this.tbxCurrency = new TextBox();
			this.label4 = new Label();
			this.pnlMaturity = new Panel();
			this.label5 = new Label();
			this.dtpMaturity = new DateTimePicker();
			this.pnlPutCall = new Panel();
			this.cbxPutCall = new ComboBox();
			this.label6 = new Label();
			this.pnlStrike = new Panel();
			this.label7 = new Label();
			this.nudStrike = new NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			this.pnlSymbol.SuspendLayout();
			this.pnlType.SuspendLayout();
			this.pnlExchange.SuspendLayout();
			this.pnlCurrency.SuspendLayout();
			this.pnlMaturity.SuspendLayout();
			this.pnlPutCall.SuspendLayout();
			this.pnlStrike.SuspendLayout();
			this.nudStrike.BeginInit();
			this.SuspendLayout();
			this.groupBox1.AutoSize = true;
			this.groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add((Control)this.pnlStrike);
			this.groupBox1.Controls.Add((Control)this.pnlPutCall);
			this.groupBox1.Controls.Add((Control)this.pnlMaturity);
			this.groupBox1.Controls.Add((Control)this.pnlCurrency);
			this.groupBox1.Controls.Add((Control)this.pnlExchange);
			this.groupBox1.Controls.Add((Control)this.pnlType);
			this.groupBox1.Controls.Add((Control)this.pnlSymbol);
			this.groupBox1.Dock = DockStyle.Fill;
			this.groupBox1.Location = new Point(4, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(200, 232);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.pnlButtons.Controls.Add((Control)this.btnCancel);
			this.pnlButtons.Controls.Add((Control)this.btnOk);
			this.pnlButtons.Dock = DockStyle.Bottom;
			this.pnlButtons.Location = new Point(4, 232);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new Size(200, 40);
			this.pnlButtons.TabIndex = 3;
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.Location = new Point(107, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(62, 22);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnOk.DialogResult = DialogResult.OK;
			this.btnOk.Location = new Point(36, 10);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new Size(62, 22);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.pnlSymbol.Controls.Add((Control)this.tbxSymbol);
			this.pnlSymbol.Controls.Add((Control)this.label1);
			this.pnlSymbol.Dock = DockStyle.Top;
			this.pnlSymbol.Location = new Point(3, 16);
			this.pnlSymbol.Name = "pnlSymbol";
			this.pnlSymbol.Size = new Size(194, 30);
			this.pnlSymbol.TabIndex = 0;
			this.label1.Location = new Point(8, 4);
			this.label1.Name = "label1";
			this.label1.Size = new Size(50, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Symbol";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.tbxSymbol.Location = new Point(64, 4);
			this.tbxSymbol.Name = "tbxSymbol";
			this.tbxSymbol.Size = new Size(112, 20);
			this.tbxSymbol.TabIndex = 1;
			this.tbxSymbol.TextChanged += new EventHandler(this.tbxSymbol_TextChanged);
			this.pnlType.Controls.Add((Control)this.cbxInstrumentTypes);
			this.pnlType.Controls.Add((Control)this.label2);
			this.pnlType.Dock = DockStyle.Top;
			this.pnlType.Location = new Point(3, 46);
			this.pnlType.Name = "pnlType";
			this.pnlType.Size = new Size(194, 30);
			this.pnlType.TabIndex = 1;
			this.label2.Location = new Point(8, 4);
			this.label2.Name = "label2";
			this.label2.Size = new Size(50, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Type";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.cbxInstrumentTypes.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbxInstrumentTypes.FormattingEnabled = true;
			this.cbxInstrumentTypes.Location = new Point(64, 4);
			this.cbxInstrumentTypes.Name = "cbxInstrumentTypes";
			this.cbxInstrumentTypes.Size = new Size(112, 21);
			this.cbxInstrumentTypes.TabIndex = 1;
			this.cbxInstrumentTypes.SelectedIndexChanged += new EventHandler(this.cbxInstrumentTypes_SelectedIndexChanged);
			this.pnlExchange.Controls.Add((Control)this.tbxExchange);
			this.pnlExchange.Controls.Add((Control)this.label3);
			this.pnlExchange.Dock = DockStyle.Top;
			this.pnlExchange.Location = new Point(3, 76);
			this.pnlExchange.Name = "pnlExchange";
			this.pnlExchange.Size = new Size(194, 30);
			this.pnlExchange.TabIndex = 2;
			this.tbxExchange.Location = new Point(64, 4);
			this.tbxExchange.Name = "tbxExchange";
			this.tbxExchange.Size = new Size(112, 20);
			this.tbxExchange.TabIndex = 1;
			this.label3.Location = new Point(8, 4);
			this.label3.Name = "label3";
			this.label3.Size = new Size(58, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Exchange";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			this.pnlCurrency.Controls.Add((Control)this.tbxCurrency);
			this.pnlCurrency.Controls.Add((Control)this.label4);
			this.pnlCurrency.Dock = DockStyle.Top;
			this.pnlCurrency.Location = new Point(3, 106);
			this.pnlCurrency.Name = "pnlCurrency";
			this.pnlCurrency.Size = new Size(194, 30);
			this.pnlCurrency.TabIndex = 3;
			this.tbxCurrency.Location = new Point(64, 4);
			this.tbxCurrency.Name = "tbxCurrency";
			this.tbxCurrency.Size = new Size(112, 20);
			this.tbxCurrency.TabIndex = 1;
			this.label4.Location = new Point(8, 4);
			this.label4.Name = "label4";
			this.label4.Size = new Size(58, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Currency";
			this.label4.TextAlign = ContentAlignment.MiddleLeft;
			this.pnlMaturity.Controls.Add((Control)this.dtpMaturity);
			this.pnlMaturity.Controls.Add((Control)this.label5);
			this.pnlMaturity.Dock = DockStyle.Top;
			this.pnlMaturity.Location = new Point(3, 136);
			this.pnlMaturity.Name = "pnlMaturity";
			this.pnlMaturity.Size = new Size(194, 30);
			this.pnlMaturity.TabIndex = 4;
			this.label5.Location = new Point(8, 4);
			this.label5.Name = "label5";
			this.label5.Size = new Size(50, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Maturity";
			this.label5.TextAlign = ContentAlignment.MiddleLeft;
			this.dtpMaturity.Format = DateTimePickerFormat.Short;
			this.dtpMaturity.Location = new Point(64, 4);
			this.dtpMaturity.Name = "dtpMaturity";
			this.dtpMaturity.Size = new Size(112, 20);
			this.dtpMaturity.TabIndex = 1;
			this.pnlPutCall.Controls.Add((Control)this.cbxPutCall);
			this.pnlPutCall.Controls.Add((Control)this.label6);
			this.pnlPutCall.Dock = DockStyle.Top;
			this.pnlPutCall.Location = new Point(3, 166);
			this.pnlPutCall.Name = "pnlPutCall";
			this.pnlPutCall.Size = new Size(194, 30);
			this.pnlPutCall.TabIndex = 5;
			this.cbxPutCall.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbxPutCall.FormattingEnabled = true;
			this.cbxPutCall.Location = new Point(64, 4);
			this.cbxPutCall.Name = "cbxPutCall";
			this.cbxPutCall.Size = new Size(112, 21);
			this.cbxPutCall.TabIndex = 1;
			this.label6.Location = new Point(8, 4);
			this.label6.Name = "label6";
			this.label6.Size = new Size(58, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "PutCall";
			this.label6.TextAlign = ContentAlignment.MiddleLeft;
			this.pnlStrike.Controls.Add((Control)this.nudStrike);
			this.pnlStrike.Controls.Add((Control)this.label7);
			this.pnlStrike.Dock = DockStyle.Top;
			this.pnlStrike.Location = new Point(3, 196);
			this.pnlStrike.Name = "pnlStrike";
			this.pnlStrike.Size = new Size(194, 30);
			this.pnlStrike.TabIndex = 6;
			this.label7.Location = new Point(8, 4);
			this.label7.Name = "label7";
			this.label7.Size = new Size(50, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "Strike";
			this.label7.TextAlign = ContentAlignment.MiddleLeft;
			this.nudStrike.DecimalPlaces = 4;
			this.nudStrike.Location = new Point(64, 4);
			NumericUpDown numericUpDown = this.nudStrike;
			int[] bits = new int[4];
			bits[0] = 10000000;
			Decimal num = new Decimal(bits);
			numericUpDown.Maximum = num;
			this.nudStrike.Name = "nudStrike";
			this.nudStrike.Size = new Size(112, 20);
			this.nudStrike.TabIndex = 1;
			this.nudStrike.TextAlign = HorizontalAlignment.Right;
			this.nudStrike.ThousandsSeparator = true;
			this.AcceptButton = (IButtonControl)this.btnOk;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.CancelButton = (IButtonControl)this.btnCancel;
			this.ClientSize = new Size(208, 272);
			this.Controls.Add((Control)this.groupBox1);
			this.Controls.Add((Control)this.pnlButtons);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new Size(214, 0);
			this.Name = "NewInstrumentForm";
			this.Padding = new Padding(4, 0, 4, 0);
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Add New Instrument";
			this.groupBox1.ResumeLayout(false);
			this.pnlButtons.ResumeLayout(false);
			this.pnlSymbol.ResumeLayout(false);
			this.pnlSymbol.PerformLayout();
			this.pnlType.ResumeLayout(false);
			this.pnlExchange.ResumeLayout(false);
			this.pnlExchange.PerformLayout();
			this.pnlCurrency.ResumeLayout(false);
			this.pnlCurrency.PerformLayout();
			this.pnlMaturity.ResumeLayout(false);
			this.pnlPutCall.ResumeLayout(false);
			this.pnlStrike.ResumeLayout(false);
			this.nudStrike.EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.UpdateOkButtonStatus();
			this.UpdatePanelsVisibility();
			base.OnLoad(e);
		}

		private void UpdateOkButtonStatus()
		{
			this.btnOk.Enabled = this.Symbol != string.Empty;
		}

		private void UpdatePanelsVisibility()
		{
			switch (this.InstrumentType)
			{
				case InstrumentType.Stock:
					this.pnlStrike.Visible = false;
					this.pnlPutCall.Visible = false;
					this.pnlMaturity.Visible = false;
					this.pnlCurrency.Visible = true;
					break;
				case InstrumentType.Futures:
					this.pnlStrike.Visible = false;
					this.pnlPutCall.Visible = false;
					this.pnlMaturity.Visible = true;
					this.pnlCurrency.Visible = true;
					break;
				case InstrumentType.Option:
					this.pnlStrike.Visible = true;
					this.pnlPutCall.Visible = true;
					this.pnlMaturity.Visible = true;
					this.pnlCurrency.Visible = true;
					break;
				case InstrumentType.FutOpt:
					this.pnlStrike.Visible = true;
					this.pnlPutCall.Visible = true;
					this.pnlMaturity.Visible = true;
					this.pnlCurrency.Visible = true;
					break;
				case InstrumentType.Bond:
					this.pnlStrike.Visible = false;
					this.pnlPutCall.Visible = false;
					this.pnlMaturity.Visible = false;
					this.pnlCurrency.Visible = true;
					break;
				case InstrumentType.Index:
					this.pnlStrike.Visible = false;
					this.pnlPutCall.Visible = false;
					this.pnlMaturity.Visible = false;
					this.pnlCurrency.Visible = false;
					break;
				case InstrumentType.ETF:
					this.pnlStrike.Visible = false;
					this.pnlPutCall.Visible = false;
					this.pnlMaturity.Visible = false;
					this.pnlCurrency.Visible = false;
					break;
				case InstrumentType.FX:
					this.pnlStrike.Visible = false;
					this.pnlPutCall.Visible = false;
					this.pnlMaturity.Visible = false;
					this.pnlCurrency.Visible = true;
					break;
				case InstrumentType.MultiLeg:
					this.pnlStrike.Visible = false;
					this.pnlPutCall.Visible = false;
					this.pnlMaturity.Visible = false;
					this.pnlCurrency.Visible = false;
					break;
			}
		}

		private void tbxSymbol_TextChanged(object sender, EventArgs e)
		{
			this.UpdateOkButtonStatus();
		}

		private void cbxInstrumentTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UpdatePanelsVisibility();
		}
	}
}
