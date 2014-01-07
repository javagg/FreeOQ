// Type: OpenQuant.Options.ConfigurationModeOptionsPanel
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.Shared.Options;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Options
{
  internal class ConfigurationModeOptionsPanel : OptionsPanel
  {
    private IContainer components;
    private GroupBox groupBox1;
    private Label label2;
    private Label label1;
    private ComboBox cbxExecution_Simulation;
    private ComboBox cbxMarketData_Simulation;
    private GroupBox groupBox2;
    private ComboBox cbxExecution_Paper;
    private ComboBox cbxMarketData_Paper;
    private Label label3;
    private Label label4;
    private GroupBox groupBox3;
    private ComboBox cbxExecution_Live;
    private ComboBox cbxMarketData_Live;
    private Label label5;
    private Label label6;
    private ComboBox cbxPortfolio_Simulation;
    private Label label7;
    private ComboBox cbxPortfolio_Paper;
    private Label label8;
    private ComboBox cbxPortfolio_Live;
    private Label label9;
    private CheckBox chbPersistent_Simulation;
    private Label label10;
    private Label label11;
    private Label label12;
    private CheckBox chbPersistent_Paper;
    private CheckBox chbPersistent_Live;

    public ConfigurationModeOptionsPanel()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void OnInit()
    {
      this.InitMode((ConfigurationMode) 0, this.cbxMarketData_Simulation, this.cbxExecution_Simulation, this.cbxPortfolio_Simulation, this.chbPersistent_Simulation);
      this.InitMode((ConfigurationMode) 1, this.cbxMarketData_Paper, this.cbxExecution_Paper, this.cbxPortfolio_Paper, this.chbPersistent_Paper);
      this.InitMode((ConfigurationMode) 2, this.cbxMarketData_Live, this.cbxExecution_Live, this.cbxPortfolio_Live, this.chbPersistent_Live);
    }

    protected virtual void OnCommitChanges()
    {
      this.CommitMode((ConfigurationMode) 0, this.cbxMarketData_Simulation, this.cbxExecution_Simulation, this.cbxPortfolio_Simulation, this.chbPersistent_Simulation);
      this.CommitMode((ConfigurationMode) 1, this.cbxMarketData_Paper, this.cbxExecution_Paper, this.cbxPortfolio_Paper, this.chbPersistent_Paper);
      this.CommitMode((ConfigurationMode) 2, this.cbxMarketData_Live, this.cbxExecution_Live, this.cbxPortfolio_Live, this.chbPersistent_Live);
      ((OptionsBase) Global.Options.Configuration).Save();
    }

    private void InitMode(ConfigurationMode mode, ComboBox cbxMarketData, ComboBox cbxExecution, ComboBox cbxPortfolio, CheckBox chbPersistent)
    {
      cbxMarketData.BeginUpdate();
      cbxMarketData.Items.Clear();
      foreach (IMarketDataProvider marketDataProvider in (ProviderList) ProviderManager.MarketDataProviders)
      {
        if (mode != 1 && mode != 2 || (int) marketDataProvider.Id != 1)
          cbxMarketData.Items.Add((object) new ProviderItem((IProvider) marketDataProvider));
      }
      cbxMarketData.EndUpdate();
      cbxExecution.BeginUpdate();
      cbxExecution.Items.Clear();
      foreach (IExecutionProvider executionProvider in (ProviderList) ProviderManager.ExecutionProviders)
        cbxExecution.Items.Add((object) new ProviderItem((IProvider) executionProvider));
      cbxExecution.EndUpdate();
      cbxPortfolio.BeginUpdate();
      cbxPortfolio.Items.Clear();
      foreach (Portfolio portfolio in PortfolioManager.Portfolios)
        cbxPortfolio.Items.Add((object) new PortfolioItem(portfolio));
      cbxPortfolio.EndUpdate();
      ConfigurationInfo configuration = Configuration.GetConfiguration(mode);
      cbxMarketData.SelectedItem = (object) configuration.get_MarketDataProvider();
      cbxExecution.SelectedItem = (object) configuration.get_ExecutionProvider();
      cbxPortfolio.SelectedItem = (object) configuration.get_Portfolio();
      chbPersistent.Checked = configuration.get_Persistent();
    }

    private void CommitMode(ConfigurationMode mode, ComboBox cbxMarketData, ComboBox cbxExecution, ComboBox cbxPortfolio, CheckBox chbPersistent)
    {
      ConfigurationInfo configuration = Configuration.GetConfiguration(mode);
      if (cbxMarketData.SelectedItem != null)
        configuration.set_MarketDataProvider((cbxMarketData.SelectedItem as ProviderItem).MarketDataProvider);
      if (cbxExecution.SelectedItem != null)
        configuration.set_ExecutionProvider((cbxExecution.SelectedItem as ProviderItem).ExecutionProvider);
      configuration.set_Portfolio((cbxPortfolio.SelectedItem as PortfolioItem).Portfolio);
      configuration.set_Persistent(chbPersistent.Checked);
    }

    private void cbxMarketData_Simulation_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void cbxExecution_Simulation_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void cbxPortfolio_Simulation_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void cbxMarketData_Paper_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void cbxExecution_Paper_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void cbxPortfolio_Paper_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void cbxMarketData_Live_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void cbxExecution_Live_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void cbxPortfolio_Live_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void chbPersistent_Simulation_CheckedChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void chbPersistent_Paper_CheckedChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    private void chbPersistent_Live_CheckedChanged(object sender, EventArgs e)
    {
      this.set_OptionsChanged(true);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.chbPersistent_Simulation = new CheckBox();
      this.label10 = new Label();
      this.cbxPortfolio_Simulation = new ComboBox();
      this.label7 = new Label();
      this.cbxExecution_Simulation = new ComboBox();
      this.cbxMarketData_Simulation = new ComboBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.groupBox2 = new GroupBox();
      this.chbPersistent_Paper = new CheckBox();
      this.label11 = new Label();
      this.cbxPortfolio_Paper = new ComboBox();
      this.label8 = new Label();
      this.cbxExecution_Paper = new ComboBox();
      this.cbxMarketData_Paper = new ComboBox();
      this.label3 = new Label();
      this.label4 = new Label();
      this.groupBox3 = new GroupBox();
      this.chbPersistent_Live = new CheckBox();
      this.label12 = new Label();
      this.cbxPortfolio_Live = new ComboBox();
      this.label9 = new Label();
      this.cbxExecution_Live = new ComboBox();
      this.cbxMarketData_Live = new ComboBox();
      this.label5 = new Label();
      this.label6 = new Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.chbPersistent_Simulation);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.cbxPortfolio_Simulation);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.cbxExecution_Simulation);
      this.groupBox1.Controls.Add((Control) this.cbxMarketData_Simulation);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(16, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(368, 112);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Simulation";
      this.chbPersistent_Simulation.Enabled = false;
      this.chbPersistent_Simulation.Location = new Point(144, 88);
      this.chbPersistent_Simulation.Name = "chbPersistent_Simulation";
      this.chbPersistent_Simulation.Size = new Size(35, 20);
      this.chbPersistent_Simulation.TabIndex = 7;
      this.chbPersistent_Simulation.UseVisualStyleBackColor = true;
      this.chbPersistent_Simulation.CheckedChanged += new EventHandler(this.chbPersistent_Simulation_CheckedChanged);
      this.label10.Location = new Point(16, 88);
      this.label10.Name = "label10";
      this.label10.Size = new Size(120, 20);
      this.label10.TabIndex = 6;
      this.label10.Text = "Persistent";
      this.label10.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxPortfolio_Simulation.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxPortfolio_Simulation.Enabled = false;
      this.cbxPortfolio_Simulation.FormattingEnabled = true;
      this.cbxPortfolio_Simulation.Location = new Point(144, 64);
      this.cbxPortfolio_Simulation.Name = "cbxPortfolio_Simulation";
      this.cbxPortfolio_Simulation.Size = new Size(173, 21);
      this.cbxPortfolio_Simulation.TabIndex = 5;
      this.cbxPortfolio_Simulation.SelectedIndexChanged += new EventHandler(this.cbxPortfolio_Simulation_SelectedIndexChanged);
      this.label7.Location = new Point(16, 64);
      this.label7.Name = "label7";
      this.label7.Size = new Size(120, 20);
      this.label7.TabIndex = 4;
      this.label7.Text = "Portfolio";
      this.label7.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxExecution_Simulation.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxExecution_Simulation.Enabled = false;
      this.cbxExecution_Simulation.FormattingEnabled = true;
      this.cbxExecution_Simulation.Location = new Point(144, 40);
      this.cbxExecution_Simulation.Name = "cbxExecution_Simulation";
      this.cbxExecution_Simulation.Size = new Size(173, 21);
      this.cbxExecution_Simulation.TabIndex = 3;
      this.cbxExecution_Simulation.SelectedIndexChanged += new EventHandler(this.cbxExecution_Simulation_SelectedIndexChanged);
      this.cbxMarketData_Simulation.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxMarketData_Simulation.Enabled = false;
      this.cbxMarketData_Simulation.FormattingEnabled = true;
      this.cbxMarketData_Simulation.Location = new Point(144, 16);
      this.cbxMarketData_Simulation.Name = "cbxMarketData_Simulation";
      this.cbxMarketData_Simulation.Size = new Size(173, 21);
      this.cbxMarketData_Simulation.TabIndex = 2;
      this.cbxMarketData_Simulation.SelectedIndexChanged += new EventHandler(this.cbxMarketData_Simulation_SelectedIndexChanged);
      this.label2.Location = new Point(16, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(120, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Execution Provider";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label1.Location = new Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(120, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Market Data Provider";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.groupBox2.Controls.Add((Control) this.chbPersistent_Paper);
      this.groupBox2.Controls.Add((Control) this.label11);
      this.groupBox2.Controls.Add((Control) this.cbxPortfolio_Paper);
      this.groupBox2.Controls.Add((Control) this.label8);
      this.groupBox2.Controls.Add((Control) this.cbxExecution_Paper);
      this.groupBox2.Controls.Add((Control) this.cbxMarketData_Paper);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Location = new Point(16, 112);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(368, 112);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Paper";
      this.chbPersistent_Paper.Location = new Point(144, 88);
      this.chbPersistent_Paper.Name = "chbPersistent_Paper";
      this.chbPersistent_Paper.Size = new Size(35, 20);
      this.chbPersistent_Paper.TabIndex = 8;
      this.chbPersistent_Paper.UseVisualStyleBackColor = true;
      this.chbPersistent_Paper.CheckedChanged += new EventHandler(this.chbPersistent_Paper_CheckedChanged);
      this.label11.Location = new Point(16, 88);
      this.label11.Name = "label11";
      this.label11.Size = new Size(120, 20);
      this.label11.TabIndex = 7;
      this.label11.Text = "Persistent";
      this.label11.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxPortfolio_Paper.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxPortfolio_Paper.Enabled = false;
      this.cbxPortfolio_Paper.FormattingEnabled = true;
      this.cbxPortfolio_Paper.Location = new Point(144, 64);
      this.cbxPortfolio_Paper.Name = "cbxPortfolio_Paper";
      this.cbxPortfolio_Paper.Size = new Size(173, 21);
      this.cbxPortfolio_Paper.TabIndex = 5;
      this.cbxPortfolio_Paper.SelectedIndexChanged += new EventHandler(this.cbxPortfolio_Paper_SelectedIndexChanged);
      this.label8.Location = new Point(16, 64);
      this.label8.Name = "label8";
      this.label8.Size = new Size(120, 20);
      this.label8.TabIndex = 4;
      this.label8.Text = "Portfolio";
      this.label8.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxExecution_Paper.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxExecution_Paper.Enabled = false;
      this.cbxExecution_Paper.FormattingEnabled = true;
      this.cbxExecution_Paper.Location = new Point(144, 40);
      this.cbxExecution_Paper.Name = "cbxExecution_Paper";
      this.cbxExecution_Paper.Size = new Size(173, 21);
      this.cbxExecution_Paper.TabIndex = 3;
      this.cbxExecution_Paper.SelectedIndexChanged += new EventHandler(this.cbxExecution_Paper_SelectedIndexChanged);
      this.cbxMarketData_Paper.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxMarketData_Paper.FormattingEnabled = true;
      this.cbxMarketData_Paper.Location = new Point(144, 16);
      this.cbxMarketData_Paper.Name = "cbxMarketData_Paper";
      this.cbxMarketData_Paper.Size = new Size(173, 21);
      this.cbxMarketData_Paper.TabIndex = 2;
      this.cbxMarketData_Paper.SelectedIndexChanged += new EventHandler(this.cbxMarketData_Paper_SelectedIndexChanged);
      this.label3.Location = new Point(16, 40);
      this.label3.Name = "label3";
      this.label3.Size = new Size(120, 20);
      this.label3.TabIndex = 1;
      this.label3.Text = "Execution Provider";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.label4.Location = new Point(16, 16);
      this.label4.Name = "label4";
      this.label4.Size = new Size(120, 20);
      this.label4.TabIndex = 0;
      this.label4.Text = "Market Data Provider";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.groupBox3.Controls.Add((Control) this.chbPersistent_Live);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Controls.Add((Control) this.cbxPortfolio_Live);
      this.groupBox3.Controls.Add((Control) this.label9);
      this.groupBox3.Controls.Add((Control) this.cbxExecution_Live);
      this.groupBox3.Controls.Add((Control) this.cbxMarketData_Live);
      this.groupBox3.Controls.Add((Control) this.label5);
      this.groupBox3.Controls.Add((Control) this.label6);
      this.groupBox3.Location = new Point(16, 224);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(368, 112);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Live";
      this.chbPersistent_Live.Location = new Point(144, 88);
      this.chbPersistent_Live.Name = "chbPersistent_Live";
      this.chbPersistent_Live.Size = new Size(35, 20);
      this.chbPersistent_Live.TabIndex = 8;
      this.chbPersistent_Live.UseVisualStyleBackColor = true;
      this.chbPersistent_Live.CheckedChanged += new EventHandler(this.chbPersistent_Live_CheckedChanged);
      this.label12.Location = new Point(16, 88);
      this.label12.Name = "label12";
      this.label12.Size = new Size(120, 20);
      this.label12.TabIndex = 7;
      this.label12.Text = "Persistent";
      this.label12.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxPortfolio_Live.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxPortfolio_Live.Enabled = false;
      this.cbxPortfolio_Live.FormattingEnabled = true;
      this.cbxPortfolio_Live.Location = new Point(144, 64);
      this.cbxPortfolio_Live.Name = "cbxPortfolio_Live";
      this.cbxPortfolio_Live.Size = new Size(173, 21);
      this.cbxPortfolio_Live.TabIndex = 5;
      this.cbxPortfolio_Live.SelectedIndexChanged += new EventHandler(this.cbxPortfolio_Live_SelectedIndexChanged);
      this.label9.Location = new Point(16, 64);
      this.label9.Name = "label9";
      this.label9.Size = new Size(120, 20);
      this.label9.TabIndex = 4;
      this.label9.Text = "Portfolio";
      this.label9.TextAlign = ContentAlignment.MiddleLeft;
      this.cbxExecution_Live.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxExecution_Live.FormattingEnabled = true;
      this.cbxExecution_Live.Location = new Point(144, 40);
      this.cbxExecution_Live.Name = "cbxExecution_Live";
      this.cbxExecution_Live.Size = new Size(173, 21);
      this.cbxExecution_Live.TabIndex = 3;
      this.cbxExecution_Live.SelectedIndexChanged += new EventHandler(this.cbxExecution_Live_SelectedIndexChanged);
      this.cbxMarketData_Live.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxMarketData_Live.FormattingEnabled = true;
      this.cbxMarketData_Live.Location = new Point(144, 16);
      this.cbxMarketData_Live.Name = "cbxMarketData_Live";
      this.cbxMarketData_Live.Size = new Size(173, 21);
      this.cbxMarketData_Live.TabIndex = 2;
      this.cbxMarketData_Live.SelectedIndexChanged += new EventHandler(this.cbxMarketData_Live_SelectedIndexChanged);
      this.label5.Location = new Point(16, 40);
      this.label5.Name = "label5";
      this.label5.Size = new Size(120, 20);
      this.label5.TabIndex = 1;
      this.label5.Text = "Execution Provider";
      this.label5.TextAlign = ContentAlignment.MiddleLeft;
      this.label6.Location = new Point(16, 16);
      this.label6.Name = "label6";
      this.label6.Size = new Size(120, 20);
      this.label6.TabIndex = 0;
      this.label6.Text = "Market Data Provider";
      this.label6.TextAlign = ContentAlignment.MiddleLeft;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((Control) this).Controls.Add((Control) this.groupBox3);
      ((Control) this).Controls.Add((Control) this.groupBox2);
      ((Control) this).Controls.Add((Control) this.groupBox1);
      ((Control) this).Name = "ConfigurationModeOptionsPanel";
      ((Control) this).Size = new Size(400, 360);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
    }
  }
}
