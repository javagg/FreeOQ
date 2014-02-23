using FreeQuant;
using FreeQuant.Instruments;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using CurrencyManager = FreeQuant.Instruments.CurrencyManager;

namespace OpenQuant.Shared.Options
{
  class ConfigurationOptionsPanel : OptionsPanel
  {
        private IContainer components = null;
    private GroupBox groupBox1;
    private TextBox tbxInstallFolder;
    private Label label1;
    private TextBox tbxAppDataFolder;
    private Label label2;
    private GroupBox groupBox2;
    private NumericUpDown nudQA_Length;
    private NumericUpDown nudTA_Length;
    private NumericUpDown nudBA_Length;
    private Label label5;
    private Label label4;
    private Label label3;
    private TextBox tbxDatabaseFolder;
    private Label label6;
    private GroupBox groupBox3;
    private Label label9;
    private ComboBox cbxCurrency;

    public ConfigurationOptionsPanel()
    {
      this.InitializeComponent();
    }

    protected override void OnInit()
    {
      ConfigurationOptions configurationOptions = (ConfigurationOptions) this.Options;
      this.tbxInstallFolder.Text = configurationOptions.BaseDirectory.FullName;
      this.tbxAppDataFolder.Text = configurationOptions.AppDataDirectory.FullName;
      this.tbxDatabaseFolder.Text = Framework.Installation.QUANTDAT.FullName;
      this.nudBA_Length.Value = (Decimal) DataManager.BarArrayLength;
      this.nudTA_Length.Value = (Decimal) DataManager.TradeArrayLength;
      this.nudQA_Length.Value = (Decimal) DataManager.QuoteArrayLength;
      IEnumerator enumerator = CurrencyManager.Currencies.GetEnumerator();
      try
      {
        while (enumerator.MoveNext())
          this.cbxCurrency.Items.Add((object) (Currency) enumerator.Current);
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      this.cbxCurrency.SelectedItem = (object) CurrencyManager.DefaultCurrency;
      base.OnInit();
    }

    protected override void OnCommitChanges()
    {
      int num1 = (int) this.nudBA_Length.Value;
      int num2 = (int) this.nudTA_Length.Value;
      int num3 = (int) this.nudQA_Length.Value;
      if (DataManager.BarArrayLength != num1)
				DataManager.BarArrayLength = num1;
      if (DataManager.TradeArrayLength != num2)
				DataManager.TradeArrayLength = num2;
      if (DataManager.QuoteArrayLength != num3)
				DataManager.QuoteArrayLength = num3;
      if (CurrencyManager.DefaultCurrency != this.cbxCurrency.SelectedItem as Currency)
				Framework.Configuration.DefaultCurrency = (this.cbxCurrency.SelectedItem as Currency).Code;
      base.OnCommitChanges();
    }

    private void nudBA_Length_ValueChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
    }

    private void nudTA_Length_ValueChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
    }

    private void nudQA_Length_ValueChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
    }

    private void cbxCurrency_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
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
            this.tbxDatabaseFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAppDataFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInstallFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudQA_Length = new System.Windows.Forms.NumericUpDown();
            this.nudTA_Length = new System.Windows.Forms.NumericUpDown();
            this.nudBA_Length = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxCurrency = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQA_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTA_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBA_Length)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxDatabaseFolder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxAppDataFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxInstallFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directories";
            // 
            // tbxDatabaseFolder
            // 
            this.tbxDatabaseFolder.Location = new System.Drawing.Point(16, 144);
            this.tbxDatabaseFolder.Name = "tbxDatabaseFolder";
            this.tbxDatabaseFolder.ReadOnly = true;
            this.tbxDatabaseFolder.Size = new System.Drawing.Size(350, 20);
            this.tbxDatabaseFolder.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Database folder";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxAppDataFolder
            // 
            this.tbxAppDataFolder.Location = new System.Drawing.Point(16, 96);
            this.tbxAppDataFolder.Name = "tbxAppDataFolder";
            this.tbxAppDataFolder.ReadOnly = true;
            this.tbxAppDataFolder.Size = new System.Drawing.Size(350, 20);
            this.tbxAppDataFolder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application data folder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxInstallFolder
            // 
            this.tbxInstallFolder.Location = new System.Drawing.Point(16, 48);
            this.tbxInstallFolder.Name = "tbxInstallFolder";
            this.tbxInstallFolder.ReadOnly = true;
            this.tbxInstallFolder.Size = new System.Drawing.Size(350, 20);
            this.tbxInstallFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installation folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudQA_Length);
            this.groupBox2.Controls.Add(this.nudTA_Length);
            this.groupBox2.Controls.Add(this.nudBA_Length);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Manager";
            // 
            // nudQA_Length
            // 
            this.nudQA_Length.Location = new System.Drawing.Point(116, 72);
            this.nudQA_Length.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudQA_Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudQA_Length.Name = "nudQA_Length";
            this.nudQA_Length.Size = new System.Drawing.Size(85, 20);
            this.nudQA_Length.TabIndex = 6;
            this.nudQA_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQA_Length.ThousandsSeparator = true;
            this.nudQA_Length.ValueChanged += new System.EventHandler(this.nudQA_Length_ValueChanged);
            // 
            // nudTA_Length
            // 
            this.nudTA_Length.Location = new System.Drawing.Point(116, 48);
            this.nudTA_Length.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTA_Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudTA_Length.Name = "nudTA_Length";
            this.nudTA_Length.Size = new System.Drawing.Size(85, 20);
            this.nudTA_Length.TabIndex = 5;
            this.nudTA_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTA_Length.ThousandsSeparator = true;
            this.nudTA_Length.ValueChanged += new System.EventHandler(this.nudTA_Length_ValueChanged);
            // 
            // nudBA_Length
            // 
            this.nudBA_Length.Location = new System.Drawing.Point(116, 24);
            this.nudBA_Length.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudBA_Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudBA_Length.Name = "nudBA_Length";
            this.nudBA_Length.Size = new System.Drawing.Size(85, 20);
            this.nudBA_Length.TabIndex = 4;
            this.nudBA_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBA_Length.ThousandsSeparator = true;
            this.nudBA_Length.ValueChanged += new System.EventHandler(this.nudBA_Length_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quote array length";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trade array length";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bar array length";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxCurrency);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(8, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account";
            // 
            // cbxCurrency
            // 
            this.cbxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrency.FormattingEnabled = true;
            this.cbxCurrency.Location = new System.Drawing.Point(116, 24);
            this.cbxCurrency.Name = "cbxCurrency";
            this.cbxCurrency.Size = new System.Drawing.Size(51, 21);
            this.cbxCurrency.TabIndex = 3;
            this.cbxCurrency.SelectedIndexChanged += new System.EventHandler(this.cbxCurrency_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Default currency";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfigurationOptionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigurationOptionsPanel";
            this.Size = new System.Drawing.Size(400, 416);
            this.Load += new System.EventHandler(this.ConfigurationOptionsPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQA_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTA_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBA_Length)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    private void ConfigurationOptionsPanel_Load(object sender, EventArgs e)
    {

    }
  }
}
