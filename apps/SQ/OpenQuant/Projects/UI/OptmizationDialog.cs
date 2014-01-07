// Type: OpenQuant.Projects.UI.OptmizationDialog
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects.UI.Items;
using OpenQuant.Properties;
using OpenQuant.Trading;
using SmartQuant.Optimization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  public class OptmizationDialog : Form
  {
    private StrategyOptimizer strategyOptimizer;
    private IContainer components;
    private Panel panel1;
    private Button btnOptimize;
    private Button btnCancel;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private Panel panel3;
    private Label lblLoopsCount;
    private Label label2;
    private ListView ltvParameters;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Panel panel2;
    private ComboBox cbxObjectiveType;
    private Label label5;
    private ComboBox cbxOptimizerType;
    private Button btnOptimizerProperties;
    private Label label4;
    private Label label1;
    private ColumnHeader columnHeader5;

    public StrategyOptimizer StrategyOptimizer
    {
      get
      {
        return this.strategyOptimizer;
      }
    }

    public OptmizationDialog()
    {
      this.InitializeComponent();
      Runner.InitSolutionInfo(Global.ProjectManager.ActiveSolution);
      this.strategyOptimizer = new StrategyOptimizer(Global.ProjectManager.ActiveSolution.GetSolutionRunner(Global.ProjectManager.ActiveSolution.Scenario.get_Solution()));
      this.cbxObjectiveType.Items.Add((object) new OptmizationDialog.ObjectiveItem((ObjectiveType) 0));
      this.cbxObjectiveType.Items.Add((object) new OptmizationDialog.ObjectiveItem((ObjectiveType) 1));
      this.cbxObjectiveType.Items.Add((object) new OptmizationDialog.ObjectiveItem((ObjectiveType) 2));
      this.cbxObjectiveType.SelectedIndex = 0;
      this.cbxOptimizerType.Items.Add((object) EOptimizerType.BruteForce);
      this.cbxOptimizerType.Items.Add((object) EOptimizerType.SimulatedAnnealing);
      this.cbxOptimizerType.SelectedIndex = 0;
      using (Dictionary<string, Dictionary<string, OptimizationParameter>>.ValueCollection.Enumerator enumerator1 = this.strategyOptimizer.get_Parameters().Values.GetEnumerator())
      {
        while (enumerator1.MoveNext())
        {
          using (Dictionary<string, OptimizationParameter>.ValueCollection.Enumerator enumerator2 = enumerator1.Current.Values.GetEnumerator())
          {
            while (enumerator2.MoveNext())
              this.ltvParameters.Items.Add((ListViewItem) new OptimizationParameterViewItem(enumerator2.Current));
          }
        }
      }
      this.lblLoopsCount.Text = this.strategyOptimizer.get_TotalLoops().ToString();
    }

    private void cbxObjectiveType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.strategyOptimizer.set_ObjectiveType(((OptmizationDialog.ObjectiveItem) this.cbxObjectiveType.SelectedItem).Type);
    }

    private void cbxOptimizerType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.strategyOptimizer.set_OptimizerType((EOptimizerType) this.cbxOptimizerType.SelectedItem);
    }

    private void ltvParameters_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
      OptimizationParameterViewItem parameterViewItem = e.Item as OptimizationParameterViewItem;
      parameterViewItem.Parameter.set_Enabled(parameterViewItem.Checked);
      this.lblLoopsCount.Text = this.strategyOptimizer.get_TotalLoops().ToString();
    }

    private void btnOptimize_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panel1 = new Panel();
      this.btnCancel = new Button();
      this.btnOptimize = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.ltvParameters = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.panel2 = new Panel();
      this.cbxObjectiveType = new ComboBox();
      this.label5 = new Label();
      this.cbxOptimizerType = new ComboBox();
      this.btnOptimizerProperties = new Button();
      this.label4 = new Label();
      this.label1 = new Label();
      this.panel3 = new Panel();
      this.lblLoopsCount = new Label();
      this.label2 = new Label();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.btnCancel);
      this.panel1.Controls.Add((Control) this.btnOptimize);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 300);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(535, 31);
      this.panel1.TabIndex = 6;
      this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(454, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOptimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnOptimize.DialogResult = DialogResult.OK;
      this.btnOptimize.Location = new Point(373, 3);
      this.btnOptimize.Name = "btnOptimize";
      this.btnOptimize.Size = new Size(75, 23);
      this.btnOptimize.TabIndex = 0;
      this.btnOptimize.Text = "Optimize";
      this.btnOptimize.UseVisualStyleBackColor = true;
      this.btnOptimize.Click += new EventHandler(this.btnOptimize_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(535, 300);
      this.tabControl1.TabIndex = 7;
      this.tabPage1.Controls.Add((Control) this.ltvParameters);
      this.tabPage1.Controls.Add((Control) this.panel2);
      this.tabPage1.Controls.Add((Control) this.panel3);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(527, 274);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Settings";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.ltvParameters.CheckBoxes = true;
      this.ltvParameters.Columns.AddRange(new ColumnHeader[5]
      {
        this.columnHeader1,
        this.columnHeader5,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4
      });
      this.ltvParameters.Dock = DockStyle.Fill;
      this.ltvParameters.FullRowSelect = true;
      this.ltvParameters.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvParameters.Location = new Point(3, 56);
      this.ltvParameters.Name = "ltvParameters";
      this.ltvParameters.Size = new Size(521, 191);
      this.ltvParameters.TabIndex = 8;
      this.ltvParameters.UseCompatibleStateImageBehavior = false;
      this.ltvParameters.View = View.Details;
      this.ltvParameters.ItemChecked += new ItemCheckedEventHandler(this.ltvParameters_ItemChecked);
      this.columnHeader1.Text = "Parameter";
      this.columnHeader1.Width = 142;
      this.columnHeader5.Text = "Strategy";
      this.columnHeader5.Width = 111;
      this.columnHeader2.Text = "Start";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 68;
      this.columnHeader3.Text = "Stop";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Text = "Step";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 62;
      this.panel2.Controls.Add((Control) this.cbxObjectiveType);
      this.panel2.Controls.Add((Control) this.label5);
      this.panel2.Controls.Add((Control) this.cbxOptimizerType);
      this.panel2.Controls.Add((Control) this.btnOptimizerProperties);
      this.panel2.Controls.Add((Control) this.label4);
      this.panel2.Controls.Add((Control) this.label1);
      this.panel2.Dock = DockStyle.Top;
      this.panel2.Location = new Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(521, 53);
      this.panel2.TabIndex = 9;
      this.cbxObjectiveType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxObjectiveType.Location = new Point(106, 5);
      this.cbxObjectiveType.Name = "cbxObjectiveType";
      this.cbxObjectiveType.Size = new Size(166, 21);
      this.cbxObjectiveType.TabIndex = 20;
      this.cbxObjectiveType.SelectedIndexChanged += new EventHandler(this.cbxObjectiveType_SelectedIndexChanged);
      this.label5.Location = new Point(5, 8);
      this.label5.Name = "label5";
      this.label5.Size = new Size(105, 19);
      this.label5.TabIndex = 21;
      this.label5.Text = "Objective Function";
      this.cbxOptimizerType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxOptimizerType.Location = new Point(366, 6);
      this.cbxOptimizerType.Name = "cbxOptimizerType";
      this.cbxOptimizerType.Size = new Size(121, 21);
      this.cbxOptimizerType.TabIndex = 17;
      this.cbxOptimizerType.SelectedIndexChanged += new EventHandler(this.cbxOptimizerType_SelectedIndexChanged);
      this.btnOptimizerProperties.Image = (Image) Resources.preferences;
      this.btnOptimizerProperties.Location = new Point(493, 6);
      this.btnOptimizerProperties.Name = "btnOptimizerProperties";
      this.btnOptimizerProperties.Size = new Size(21, 21);
      this.btnOptimizerProperties.TabIndex = 19;
      this.label4.Location = new Point(288, 8);
      this.label4.Name = "label4";
      this.label4.Size = new Size(120, 16);
      this.label4.TabIndex = 18;
      this.label4.Text = "Optimizer Type";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(3, 36);
      this.label1.Name = "label1";
      this.label1.Size = new Size(151, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Choose parameters to optimize";
      this.panel3.Controls.Add((Control) this.lblLoopsCount);
      this.panel3.Controls.Add((Control) this.label2);
      this.panel3.Dock = DockStyle.Bottom;
      this.panel3.Location = new Point(3, 247);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(521, 24);
      this.panel3.TabIndex = 10;
      this.lblLoopsCount.AutoSize = true;
      this.lblLoopsCount.Location = new Point(115, 8);
      this.lblLoopsCount.Name = "lblLoopsCount";
      this.lblLoopsCount.Size = new Size(25, 13);
      this.lblLoopsCount.TabIndex = 1;
      this.lblLoopsCount.Text = "256";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(3, 8);
      this.label2.Name = "label2";
      this.label2.Size = new Size(116, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Brute Force total loops:";
      this.AcceptButton = (IButtonControl) this.btnOptimize;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(535, 331);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptmizationDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Optmization Settings";
      this.panel1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);
    }

    private class ObjectiveItem
    {
      private ObjectiveType type;

      public ObjectiveType Type
      {
        get
        {
          return this.type;
        }
      }

      public ObjectiveItem(ObjectiveType type)
      {
        this.type = type;
      }

      public override string ToString()
      {
        return (typeof (ObjectiveType).GetField(((object) this.type).ToString()).GetCustomAttributes(typeof (DescriptionAttribute), false)[0] as DescriptionAttribute).Description;
      }
    }
  }
}
