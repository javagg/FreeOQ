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
    private IContainer components;
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
      this.groupBox1 = new GroupBox();
      this.tbxDatabaseFolder = new TextBox();
      this.label6 = new Label();
      this.tbxAppDataFolder = new TextBox();
      this.label2 = new Label();
      this.tbxInstallFolder = new TextBox();
      this.label1 = new Label();
      this.groupBox2 = new GroupBox();
      this.nudQA_Length = new NumericUpDown();
      this.nudTA_Length = new NumericUpDown();
      this.nudBA_Length = new NumericUpDown();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.groupBox3 = new GroupBox();
      this.cbxCurrency = new ComboBox();
      this.label9 = new Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.nudQA_Length.BeginInit();
      this.nudTA_Length.BeginInit();
      this.nudBA_Length.BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.tbxDatabaseFolder);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.tbxAppDataFolder);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.tbxInstallFolder);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(8, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(384, 175);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Directories";
      this.tbxDatabaseFolder.Location = new Point(16, 144);
      this.tbxDatabaseFolder.Name = "tbxDatabaseFolder";
      this.tbxDatabaseFolder.ReadOnly = true;
      this.tbxDatabaseFolder.Size = new Size(350, 20);
      this.tbxDatabaseFolder.TabIndex = 5;
      this.label6.Location = new Point(16, 120);
      this.label6.Name = "label6";
      this.label6.Size = new Size(134, 22);
      this.label6.TabIndex = 4;
      this.label6.Text = "Database folder";
      this.label6.TextAlign = ContentAlignment.MiddleLeft;
      this.tbxAppDataFolder.Location = new Point(16, 96);
      this.tbxAppDataFolder.Name = "tbxAppDataFolder";
      this.tbxAppDataFolder.ReadOnly = true;
      this.tbxAppDataFolder.Size = new Size(350, 20);
      this.tbxAppDataFolder.TabIndex = 3;
      this.label2.Location = new Point(16, 72);
      this.label2.Name = "label2";
      this.label2.Size = new Size(134, 22);
      this.label2.TabIndex = 2;
      this.label2.Text = "Application data folder";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.tbxInstallFolder.Location = new Point(16, 48);
      this.tbxInstallFolder.Name = "tbxInstallFolder";
      this.tbxInstallFolder.ReadOnly = true;
      this.tbxInstallFolder.Size = new Size(350, 20);
      this.tbxInstallFolder.TabIndex = 1;
      this.label1.Location = new Point(16, 24);
      this.label1.Name = "label1";
      this.label1.Size = new Size(111, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Installation folder";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.groupBox2.Controls.Add((Control) this.nudQA_Length);
      this.groupBox2.Controls.Add((Control) this.nudTA_Length);
      this.groupBox2.Controls.Add((Control) this.nudBA_Length);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Location = new Point(8, 184);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(384, 108);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Data Manager";
      this.nudQA_Length.Location = new Point(116, 72);
      NumericUpDown numericUpDown1 = this.nudQA_Length;
      int[] bits1 = new int[4];
      bits1[0] = 10000000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.nudQA_Length.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        int.MinValue
      });
      this.nudQA_Length.Name = "nudQA_Length";
      this.nudQA_Length.Size = new Size(85, 20);
      this.nudQA_Length.TabIndex = 6;
      this.nudQA_Length.TextAlign = HorizontalAlignment.Right;
      this.nudQA_Length.ThousandsSeparator = true;
      this.nudQA_Length.ValueChanged += new EventHandler(this.nudQA_Length_ValueChanged);
      this.nudTA_Length.Location = new Point(116, 48);
      NumericUpDown numericUpDown2 = this.nudTA_Length;
      int[] bits2 = new int[4];
      bits2[0] = 10000000;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Maximum = num2;
      this.nudTA_Length.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        int.MinValue
      });
      this.nudTA_Length.Name = "nudTA_Length";
      this.nudTA_Length.Size = new Size(85, 20);
      this.nudTA_Length.TabIndex = 5;
      this.nudTA_Length.TextAlign = HorizontalAlignment.Right;
      this.nudTA_Length.ThousandsSeparator = true;
      this.nudTA_Length.ValueChanged += new EventHandler(this.nudTA_Length_ValueChanged);
      this.nudBA_Length.Location = new Point(116, 24);
      NumericUpDown numericUpDown3 = this.nudBA_Length;
      int[] bits3 = new int[4];
      bits3[0] = 10000000;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Maximum = num3;
      this.nudBA_Length.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        int.MinValue
      });
      this.nudBA_Length.Name = "nudBA_Length";
      this.nudBA_Length.Size = new Size(85, 20);
      this.nudBA_Length.TabIndex = 4;
      this.nudBA_Length.TextAlign = HorizontalAlignment.Right;
      this.nudBA_Length.ThousandsSeparator = true;
      this.nudBA_Length.ValueChanged += new EventHandler(this.nudBA_Length_ValueChanged);
      this.label5.Location = new Point(16, 72);
      this.label5.Name = "label5";
      this.label5.Size = new Size(111, 22);
      this.label5.TabIndex = 3;
      this.label5.Text = "Quote array length";
      this.label5.TextAlign = ContentAlignment.MiddleLeft;
      this.label4.Location = new Point(16, 48);
      this.label4.Name = "label4";
      this.label4.Size = new Size(111, 22);
      this.label4.TabIndex = 2;
      this.label4.Text = "Trade array length";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(16, 24);
      this.label3.Name = "label3";
      this.label3.Size = new Size(111, 22);
      this.label3.TabIndex = 1;
      this.label3.Text = "Bar array length";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.groupBox3.Controls.Add((Control) this.cbxCurrency);
      this.groupBox3.Controls.Add((Control) this.label9);
      this.groupBox3.Location = new Point(8, 298);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(384, 59);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Account";
      this.cbxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxCurrency.FormattingEnabled = true;
      this.cbxCurrency.Location = new Point(116, 24);
      this.cbxCurrency.Name = "cbxCurrency";
      this.cbxCurrency.Size = new Size(51, 21);
      this.cbxCurrency.TabIndex = 3;
      this.cbxCurrency.SelectedIndexChanged += new EventHandler(this.cbxCurrency_SelectedIndexChanged);
      this.label9.Location = new Point(16, 24);
      this.label9.Name = "label9";
      this.label9.Size = new Size(111, 22);
      this.label9.TabIndex = 1;
      this.label9.Text = "Default currency";
      this.label9.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = "ConfigurationOptionsPanel";
      this.Size = new Size(400, 416);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.nudQA_Length.EndInit();
      this.nudTA_Length.EndInit();
      this.nudBA_Length.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
