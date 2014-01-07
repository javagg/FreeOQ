// Type: OpenQuant.RepairConfigurationsForm
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Config;
using OpenQuant.Properties;
using OpenQuant.Shared.Options;
using SmartQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class RepairConfigurationsForm : Form
  {
    private IContainer components;
    private Label label1;
    private GroupBox gbxPaper;
    private Label label2;
    private ComboBox cbxPaper_MarketData;
    private PictureBox pbxPaper_MarketData;
    private GroupBox gbxLive;
    private PictureBox pbxLive_Execution;
    private ComboBox cbxLive_Execution;
    private Label label4;
    private PictureBox pbxLive_MarketData;
    private ComboBox cbxLive_MarketData;
    private Label label3;
    private Button btnContinue;
    private Button btnAbort;

    public RepairConfigurationsForm()
    {
      this.InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      this.FillComboBox(this.cbxPaper_MarketData, (ProviderList) ProviderManager.MarketDataProviders);
      this.FillComboBox(this.cbxLive_MarketData, (ProviderList) ProviderManager.MarketDataProviders);
      this.FillComboBox(this.cbxLive_Execution, (ProviderList) ProviderManager.ExecutionProviders);
      this.cbxPaper_MarketData.SelectedItem = (object) Configuration.GetConfiguration((ConfigurationMode) 1).get_MarketDataProvider();
      ConfigurationInfo configuration = Configuration.GetConfiguration((ConfigurationMode) 2);
      this.cbxLive_MarketData.SelectedItem = (object) configuration.get_MarketDataProvider();
      this.cbxLive_Execution.SelectedItem = (object) configuration.get_ExecutionProvider();
      this.UpdatePicture(this.pbxPaper_MarketData, this.cbxPaper_MarketData);
      this.UpdatePicture(this.pbxLive_MarketData, this.cbxLive_MarketData);
      this.UpdatePicture(this.pbxLive_Execution, this.cbxLive_Execution);
      this.UpdateContinueButtonStatus();
    }

    private void cbxPaper_MarketData_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdatePicture(this.pbxPaper_MarketData, this.cbxPaper_MarketData);
      this.UpdateContinueButtonStatus();
    }

    private void cbxLive_MarketData_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdatePicture(this.pbxLive_MarketData, this.cbxLive_MarketData);
      this.UpdateContinueButtonStatus();
    }

    private void cbxLive_Execution_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdatePicture(this.pbxLive_Execution, this.cbxLive_Execution);
      this.UpdateContinueButtonStatus();
    }

    private void btnContinue_Click(object sender, EventArgs e)
    {
      Configuration.GetConfiguration((ConfigurationMode) 1).set_MarketDataProvider((this.cbxPaper_MarketData.SelectedItem as RepairConfigurationsForm.ProviderItem).Provider as IMarketDataProvider);
      ConfigurationInfo configuration = Configuration.GetConfiguration((ConfigurationMode) 2);
      configuration.set_MarketDataProvider((this.cbxLive_MarketData.SelectedItem as RepairConfigurationsForm.ProviderItem).Provider as IMarketDataProvider);
      configuration.set_ExecutionProvider((this.cbxLive_Execution.SelectedItem as RepairConfigurationsForm.ProviderItem).Provider as IExecutionProvider);
      ((OptionsBase) Global.Options.Configuration).Save();
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnAbort_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Abort;
      this.Close();
    }

    private void UpdatePicture(PictureBox pictureBox, ComboBox comboBox)
    {
      if (comboBox.SelectedIndex == -1)
        pictureBox.Image = (Image) Resources.common_error;
      else
        pictureBox.Image = (Image) Resources.common_ok;
    }

    private void UpdateContinueButtonStatus()
    {
      Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
      dictionary[this.cbxPaper_MarketData.SelectedIndex] = true;
      dictionary[this.cbxLive_MarketData.SelectedIndex] = true;
      dictionary[this.cbxLive_Execution.SelectedIndex] = true;
      this.btnContinue.Enabled = !dictionary.ContainsKey(-1);
    }

    private void FillComboBox(ComboBox comboBox, ProviderList providers)
    {
      comboBox.BeginUpdate();
      comboBox.Items.Clear();
      foreach (IProvider provider in providers)
      {
        if ((int) provider.Id != 1 && (int) provider.Id != 2)
          comboBox.Items.Add((object) new RepairConfigurationsForm.ProviderItem(provider));
      }
      comboBox.EndUpdate();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (RepairConfigurationsForm));
      this.label1 = new Label();
      this.gbxPaper = new GroupBox();
      this.pbxPaper_MarketData = new PictureBox();
      this.cbxPaper_MarketData = new ComboBox();
      this.label2 = new Label();
      this.gbxLive = new GroupBox();
      this.pbxLive_Execution = new PictureBox();
      this.cbxLive_Execution = new ComboBox();
      this.label4 = new Label();
      this.pbxLive_MarketData = new PictureBox();
      this.cbxLive_MarketData = new ComboBox();
      this.label3 = new Label();
      this.btnContinue = new Button();
      this.btnAbort = new Button();
      this.gbxPaper.SuspendLayout();
      this.pbxPaper_MarketData.BeginInit();
      this.gbxLive.SuspendLayout();
      this.pbxLive_Execution.BeginInit();
      this.pbxLive_MarketData.BeginInit();
      this.SuspendLayout();
      this.label1.ForeColor = SystemColors.ControlText;
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(328, 52);
      this.label1.TabIndex = 0;
      this.label1.Text = "One or more configuration modes cannot be initialized\r\nbecause selected providers are not loaded.\r\nTo continue OpenQuant please correct the settings.\r\n";
      this.gbxPaper.Controls.Add((Control) this.pbxPaper_MarketData);
      this.gbxPaper.Controls.Add((Control) this.cbxPaper_MarketData);
      this.gbxPaper.Controls.Add((Control) this.label2);
      this.gbxPaper.Location = new Point(16, 72);
      this.gbxPaper.Name = "gbxPaper";
      this.gbxPaper.Size = new Size(312, 59);
      this.gbxPaper.TabIndex = 1;
      this.gbxPaper.TabStop = false;
      this.gbxPaper.Text = "Paper mode";
      this.pbxPaper_MarketData.Location = new Point(276, 24);
      this.pbxPaper_MarketData.Name = "pbxPaper_MarketData";
      this.pbxPaper_MarketData.Size = new Size(20, 20);
      this.pbxPaper_MarketData.SizeMode = PictureBoxSizeMode.CenterImage;
      this.pbxPaper_MarketData.TabIndex = 2;
      this.pbxPaper_MarketData.TabStop = false;
      this.cbxPaper_MarketData.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxPaper_MarketData.FormattingEnabled = true;
      this.cbxPaper_MarketData.Location = new Point(140, 24);
      this.cbxPaper_MarketData.Name = "cbxPaper_MarketData";
      this.cbxPaper_MarketData.Size = new Size(129, 21);
      this.cbxPaper_MarketData.Sorted = true;
      this.cbxPaper_MarketData.TabIndex = 1;
      this.cbxPaper_MarketData.SelectedIndexChanged += new EventHandler(this.cbxPaper_MarketData_SelectedIndexChanged);
      this.label2.Location = new Point(16, 24);
      this.label2.Name = "label2";
      this.label2.Size = new Size(114, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Market data provider";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.gbxLive.Controls.Add((Control) this.pbxLive_Execution);
      this.gbxLive.Controls.Add((Control) this.cbxLive_Execution);
      this.gbxLive.Controls.Add((Control) this.label4);
      this.gbxLive.Controls.Add((Control) this.pbxLive_MarketData);
      this.gbxLive.Controls.Add((Control) this.cbxLive_MarketData);
      this.gbxLive.Controls.Add((Control) this.label3);
      this.gbxLive.Location = new Point(16, 144);
      this.gbxLive.Name = "gbxLive";
      this.gbxLive.Size = new Size(312, 92);
      this.gbxLive.TabIndex = 2;
      this.gbxLive.TabStop = false;
      this.gbxLive.Text = "Live mode";
      this.pbxLive_Execution.Location = new Point(276, 56);
      this.pbxLive_Execution.Name = "pbxLive_Execution";
      this.pbxLive_Execution.Size = new Size(20, 20);
      this.pbxLive_Execution.SizeMode = PictureBoxSizeMode.CenterImage;
      this.pbxLive_Execution.TabIndex = 5;
      this.pbxLive_Execution.TabStop = false;
      this.cbxLive_Execution.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxLive_Execution.FormattingEnabled = true;
      this.cbxLive_Execution.Location = new Point(140, 56);
      this.cbxLive_Execution.Name = "cbxLive_Execution";
      this.cbxLive_Execution.Size = new Size(129, 21);
      this.cbxLive_Execution.Sorted = true;
      this.cbxLive_Execution.TabIndex = 4;
      this.cbxLive_Execution.SelectedIndexChanged += new EventHandler(this.cbxLive_Execution_SelectedIndexChanged);
      this.label4.Location = new Point(16, 56);
      this.label4.Name = "label4";
      this.label4.Size = new Size(114, 20);
      this.label4.TabIndex = 3;
      this.label4.Text = "Execution provider";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.pbxLive_MarketData.Location = new Point(276, 24);
      this.pbxLive_MarketData.Name = "pbxLive_MarketData";
      this.pbxLive_MarketData.Size = new Size(20, 20);
      this.pbxLive_MarketData.SizeMode = PictureBoxSizeMode.CenterImage;
      this.pbxLive_MarketData.TabIndex = 2;
      this.pbxLive_MarketData.TabStop = false;
      this.cbxLive_MarketData.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxLive_MarketData.FormattingEnabled = true;
      this.cbxLive_MarketData.Location = new Point(140, 24);
      this.cbxLive_MarketData.Name = "cbxLive_MarketData";
      this.cbxLive_MarketData.Size = new Size(129, 21);
      this.cbxLive_MarketData.Sorted = true;
      this.cbxLive_MarketData.TabIndex = 1;
      this.cbxLive_MarketData.SelectedIndexChanged += new EventHandler(this.cbxLive_MarketData_SelectedIndexChanged);
      this.label3.Location = new Point(16, 24);
      this.label3.Name = "label3";
      this.label3.Size = new Size(114, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "Market data provider";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.btnContinue.Location = new Point(154, 256);
      this.btnContinue.Name = "btnContinue";
      this.btnContinue.Size = new Size(75, 22);
      this.btnContinue.TabIndex = 3;
      this.btnContinue.Text = "Continue";
      this.btnContinue.UseVisualStyleBackColor = true;
      this.btnContinue.Click += new EventHandler(this.btnContinue_Click);
      this.btnAbort.Location = new Point(239, 256);
      this.btnAbort.Name = "btnAbort";
      this.btnAbort.Size = new Size(75, 22);
      this.btnAbort.TabIndex = 4;
      this.btnAbort.Text = "Abort";
      this.btnAbort.UseVisualStyleBackColor = true;
      this.btnAbort.Click += new EventHandler(this.btnAbort_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(344, 290);
      this.ControlBox = false;
      this.Controls.Add((Control) this.btnAbort);
      this.Controls.Add((Control) this.btnContinue);
      this.Controls.Add((Control) this.gbxLive);
      this.Controls.Add((Control) this.gbxPaper);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RepairConfigurationsForm";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "OpenQuant - Repair Configuration Modes";
      this.gbxPaper.ResumeLayout(false);
      this.pbxPaper_MarketData.EndInit();
      this.gbxLive.ResumeLayout(false);
      this.pbxLive_Execution.EndInit();
      this.pbxLive_MarketData.EndInit();
      this.ResumeLayout(false);
    }

    private class ProviderItem
    {
      public IProvider Provider { get; private set; }

      public ProviderItem(IProvider provider)
      {
        this.Provider = provider;
      }

      public override string ToString()
      {
        return this.Provider.Name;
      }

      public override int GetHashCode()
      {
        return this.Provider.GetHashCode();
      }

      public override bool Equals(object obj)
      {
        if (obj is IProvider)
          return (IProvider) obj == this.Provider;
        else
          return base.Equals(obj);
      }
    }
  }
}
