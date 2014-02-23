using OpenQuant.API;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Instruments
{
	class NewInstrumentForm : Form
	{
        private IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlStrike = new System.Windows.Forms.Panel();
            this.nudStrike = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlPutCall = new System.Windows.Forms.Panel();
            this.cbxPutCall = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMaturity = new System.Windows.Forms.Panel();
            this.dtpMaturity = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCurrency = new System.Windows.Forms.Panel();
            this.tbxCurrency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlExchange = new System.Windows.Forms.Panel();
            this.tbxExchange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlType = new System.Windows.Forms.Panel();
            this.cbxInstrumentTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSymbol = new System.Windows.Forms.Panel();
            this.tbxSymbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlStrike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrike)).BeginInit();
            this.pnlPutCall.SuspendLayout();
            this.pnlMaturity.SuspendLayout();
            this.pnlCurrency.SuspendLayout();
            this.pnlExchange.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.pnlSymbol.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.pnlStrike);
            this.groupBox1.Controls.Add(this.pnlPutCall);
            this.groupBox1.Controls.Add(this.pnlMaturity);
            this.groupBox1.Controls.Add(this.pnlCurrency);
            this.groupBox1.Controls.Add(this.pnlExchange);
            this.groupBox1.Controls.Add(this.pnlType);
            this.groupBox1.Controls.Add(this.pnlSymbol);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pnlStrike
            // 
            this.pnlStrike.Controls.Add(this.nudStrike);
            this.pnlStrike.Controls.Add(this.label7);
            this.pnlStrike.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStrike.Location = new System.Drawing.Point(3, 196);
            this.pnlStrike.Name = "pnlStrike";
            this.pnlStrike.Size = new System.Drawing.Size(194, 30);
            this.pnlStrike.TabIndex = 6;
            // 
            // nudStrike
            // 
            this.nudStrike.DecimalPlaces = 4;
            this.nudStrike.Location = new System.Drawing.Point(64, 4);
            this.nudStrike.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudStrike.Name = "nudStrike";
            this.nudStrike.Size = new System.Drawing.Size(112, 20);
            this.nudStrike.TabIndex = 1;
            this.nudStrike.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStrike.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Strike";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPutCall
            // 
            this.pnlPutCall.Controls.Add(this.cbxPutCall);
            this.pnlPutCall.Controls.Add(this.label6);
            this.pnlPutCall.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPutCall.Location = new System.Drawing.Point(3, 166);
            this.pnlPutCall.Name = "pnlPutCall";
            this.pnlPutCall.Size = new System.Drawing.Size(194, 30);
            this.pnlPutCall.TabIndex = 5;
            // 
            // cbxPutCall
            // 
            this.cbxPutCall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPutCall.FormattingEnabled = true;
            this.cbxPutCall.Location = new System.Drawing.Point(64, 4);
            this.cbxPutCall.Name = "cbxPutCall";
            this.cbxPutCall.Size = new System.Drawing.Size(112, 21);
            this.cbxPutCall.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "PutCall";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMaturity
            // 
            this.pnlMaturity.Controls.Add(this.dtpMaturity);
            this.pnlMaturity.Controls.Add(this.label5);
            this.pnlMaturity.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMaturity.Location = new System.Drawing.Point(3, 136);
            this.pnlMaturity.Name = "pnlMaturity";
            this.pnlMaturity.Size = new System.Drawing.Size(194, 30);
            this.pnlMaturity.TabIndex = 4;
            // 
            // dtpMaturity
            // 
            this.dtpMaturity.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMaturity.Location = new System.Drawing.Point(64, 4);
            this.dtpMaturity.Name = "dtpMaturity";
            this.dtpMaturity.Size = new System.Drawing.Size(112, 20);
            this.dtpMaturity.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maturity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCurrency
            // 
            this.pnlCurrency.Controls.Add(this.tbxCurrency);
            this.pnlCurrency.Controls.Add(this.label4);
            this.pnlCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrency.Location = new System.Drawing.Point(3, 106);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(194, 30);
            this.pnlCurrency.TabIndex = 3;
            // 
            // tbxCurrency
            // 
            this.tbxCurrency.Location = new System.Drawing.Point(64, 4);
            this.tbxCurrency.Name = "tbxCurrency";
            this.tbxCurrency.Size = new System.Drawing.Size(112, 20);
            this.tbxCurrency.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Currency";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlExchange
            // 
            this.pnlExchange.Controls.Add(this.tbxExchange);
            this.pnlExchange.Controls.Add(this.label3);
            this.pnlExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExchange.Location = new System.Drawing.Point(3, 76);
            this.pnlExchange.Name = "pnlExchange";
            this.pnlExchange.Size = new System.Drawing.Size(194, 30);
            this.pnlExchange.TabIndex = 2;
            // 
            // tbxExchange
            // 
            this.tbxExchange.Location = new System.Drawing.Point(64, 4);
            this.tbxExchange.Name = "tbxExchange";
            this.tbxExchange.Size = new System.Drawing.Size(112, 20);
            this.tbxExchange.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Exchange";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlType
            // 
            this.pnlType.Controls.Add(this.cbxInstrumentTypes);
            this.pnlType.Controls.Add(this.label2);
            this.pnlType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlType.Location = new System.Drawing.Point(3, 46);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(194, 30);
            this.pnlType.TabIndex = 1;
            // 
            // cbxInstrumentTypes
            // 
            this.cbxInstrumentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInstrumentTypes.FormattingEnabled = true;
            this.cbxInstrumentTypes.Location = new System.Drawing.Point(64, 4);
            this.cbxInstrumentTypes.Name = "cbxInstrumentTypes";
            this.cbxInstrumentTypes.Size = new System.Drawing.Size(112, 21);
            this.cbxInstrumentTypes.TabIndex = 1;
            this.cbxInstrumentTypes.SelectedIndexChanged += new System.EventHandler(this.cbxInstrumentTypes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSymbol
            // 
            this.pnlSymbol.Controls.Add(this.tbxSymbol);
            this.pnlSymbol.Controls.Add(this.label1);
            this.pnlSymbol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSymbol.Location = new System.Drawing.Point(3, 16);
            this.pnlSymbol.Name = "pnlSymbol";
            this.pnlSymbol.Size = new System.Drawing.Size(194, 30);
            this.pnlSymbol.TabIndex = 0;
            // 
            // tbxSymbol
            // 
            this.tbxSymbol.Location = new System.Drawing.Point(64, 4);
            this.tbxSymbol.Name = "tbxSymbol";
            this.tbxSymbol.Size = new System.Drawing.Size(112, 20);
            this.tbxSymbol.TabIndex = 1;
            this.tbxSymbol.TextChanged += new System.EventHandler(this.tbxSymbol_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOk);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(4, 232);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(200, 40);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(107, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 22);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(36, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(62, 22);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // NewInstrumentForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(208, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(214, 38);
            this.Name = "NewInstrumentForm";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Instrument";
            this.groupBox1.ResumeLayout(false);
            this.pnlStrike.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStrike)).EndInit();
            this.pnlPutCall.ResumeLayout(false);
            this.pnlMaturity.ResumeLayout(false);
            this.pnlCurrency.ResumeLayout(false);
            this.pnlCurrency.PerformLayout();
            this.pnlExchange.ResumeLayout(false);
            this.pnlExchange.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlSymbol.ResumeLayout(false);
            this.pnlSymbol.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
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
