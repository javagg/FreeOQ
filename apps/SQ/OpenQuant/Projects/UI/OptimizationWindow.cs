// Type: OpenQuant.Projects.UI.OptimizationWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects.UI.Items;
using OpenQuant.Trading;
using SmartQuant.Docking.WinForms;
using SmartQuant.ExcelLib;
using SmartQuant.Optimization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Projects.UI
{
  public class OptimizationWindow : DockControl
  {
    private StrategyOptimizer strategyOptimizer;
    private Optimizer optimizer;
    private double bestObjectiveValue;
    private int totalLoops;
    private int loops;
    private IContainer components;
    private TabControl tabControl1;
    private TabPage tabPage2;
    private Panel panel1;
    private Button btnTerminate;
    private Button btnStop;
    private TabPage tabPage3;
    private ToolTip toolTip1;
    private GroupBox groupBox3;
    private Label label9;
    private GroupBox groupBox2;
    private GroupBox groupBox1;
    private Label lblObjective;
    private Label lblOptimizerType;
    private Label label4;
    private Label label5;
    private Panel panel2;
    private Label lblBestObjective;
    private Label label7;
    private Label lblLoopsCompleted;
    private Label label6;
    private ListView ltvHistory;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private Panel panel3;
    private ListView ltvBestParameters;
    private ListView ltvParameters;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader7;
    private LinkLabel lblExport;

    public OptimizationWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void OnInit()
    {
      Runner.OptimizationStarted += new EventHandler(this.Runner_OptimizationStarted);
      Runner.OptimizationStopped += new EventHandler(this.Runner_OptimizationStopped);
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      if (Runner.IsOptimizing)
      {
        e.set_Cancel(true);
      }
      else
      {
        Runner.OptimizationStarted -= new EventHandler(this.Runner_OptimizationStarted);
        Runner.OptimizationStopped -= new EventHandler(this.Runner_OptimizationStopped);
      }
    }

    private void Runner_OptimizationStarted(object sender, EventArgs e)
    {
      this.strategyOptimizer = Runner.StrategyOptimizer;
      this.totalLoops = this.strategyOptimizer.get_TotalLoops();
      this.loops = 0;
      if (this.strategyOptimizer.get_OptimizerType() == EOptimizerType.BruteForce)
        this.lblLoopsCompleted.Text = (string) (object) this.loops + (object) " of " + (string) (object) this.totalLoops;
      if (this.strategyOptimizer.get_OptimizerType() == EOptimizerType.SimulatedAnnealing)
        this.lblLoopsCompleted.Text = this.loops.ToString();
      this.lblBestObjective.Text = "";
      this.btnStop.Enabled = true;
      this.optimizer = this.strategyOptimizer.get_Optimizer();
      this.optimizer.Inited += new EventHandler(this.optimizer_Inited);
      this.optimizer.ObjectiveCalled += new EventHandler(this.optimizer_ObjectiveCalled);
      this.optimizer.BestObjectiveReceived += new EventHandler(this.optimizer_BestObjectiveReceived);
      this.optimizer.OptimizationCompleted += new EventHandler(this.optimizer_OptimizationCompleted);
    }

    private void optimizer_OptimizationCompleted(object sender, EventArgs e)
    {
    }

    private void optimizer_BestObjectiveReceived(object sender, EventArgs e)
    {
    }

    private void optimizer_ObjectiveCalled(object sender, EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).Invoke((Delegate) new EventHandler(this.optimizer_ObjectiveCalled), sender, (object) e));
      }
      else
      {
        ++this.loops;
        if (this.strategyOptimizer.get_OptimizerType() == EOptimizerType.BruteForce)
          this.lblLoopsCompleted.Text = (string) (object) this.loops + (object) " of " + (string) (object) this.totalLoops;
        if (this.strategyOptimizer.get_OptimizerType() == EOptimizerType.SimulatedAnnealing)
          this.lblLoopsCompleted.Text = this.loops.ToString();
        ListViewItem listViewItem1 = new ListViewItem(this.loops.ToString());
        listViewItem1.SubItems.Add((-this.optimizer.LastObjective).ToString());
        for (int index = 0; index < this.optimizer.Count; ++index)
          listViewItem1.SubItems.Add("");
        for (int NParam = 0; NParam < this.optimizer.Count; ++NParam)
          listViewItem1.SubItems[NParam + 2].Text = this.optimizer.GetParamType(NParam) != EParamType.Int ? this.optimizer.GetParam(NParam).ToString() : ((int) this.optimizer.GetParam(NParam)).ToString();
        this.ltvHistory.Items.Add(listViewItem1);
        if (this.bestObjectiveValue >= -this.optimizer.LastObjective)
          return;
        this.ltvBestParameters.BeginUpdate();
        this.ltvBestParameters.Items.Clear();
        ListViewItem listViewItem2 = new ListViewItem();
        for (int index = 1; index < this.optimizer.Count; ++index)
          listViewItem2.SubItems.Add("");
        for (int NParam = 0; NParam < this.optimizer.Count; ++NParam)
          listViewItem2.SubItems[NParam].Text = this.optimizer.GetParamType(NParam) != EParamType.Int ? this.optimizer.GetParam(NParam).ToString() : ((int) this.optimizer.GetParam(NParam)).ToString();
        this.ltvBestParameters.Items.Add(listViewItem2);
        this.ltvBestParameters.EndUpdate();
        this.bestObjectiveValue = -this.optimizer.LastObjective;
        this.lblBestObjective.Text = this.bestObjectiveValue.ToString();
      }
    }

    private void optimizer_Inited(object sender, EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).Invoke((Delegate) new EventHandler(this.optimizer_Inited), sender, (object) e));
      }
      else
      {
        this.lblObjective.Text = ((object) this.strategyOptimizer.get_ObjectiveType()).ToString();
        this.lblOptimizerType.Text = ((object) this.strategyOptimizer.get_OptimizerType()).ToString();
        this.ltvParameters.BeginUpdate();
        this.ltvParameters.Items.Clear();
        using (List<OptimizationParameter>.Enumerator enumerator = this.strategyOptimizer.get_ParameterList().GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            OptimizationParameter current = enumerator.Current;
            if (current.get_Enabled())
              this.ltvParameters.Items.Add((ListViewItem) new OptimizationParameterViewItem(current));
          }
        }
        this.ltvParameters.EndUpdate();
        this.ltvBestParameters.BeginUpdate();
        this.ltvBestParameters.Clear();
        Graphics graphics1 = ((Control) this).CreateGraphics();
        for (int NParam = 0; NParam < this.optimizer.Count; ++NParam)
        {
          ColumnHeader columnHeader = new ColumnHeader();
          columnHeader.TextAlign = HorizontalAlignment.Right;
          columnHeader.Text = this.optimizer.GetParamName(NParam);
          columnHeader.Width = Math.Max(50, (int) graphics1.MeasureString(columnHeader.Text, this.ltvBestParameters.Font).Width + 10);
          this.ltvBestParameters.Columns.Add(columnHeader);
        }
        this.ltvBestParameters.EndUpdate();
        this.ltvHistory.BeginUpdate();
        this.ltvHistory.Clear();
        this.ltvHistory.Columns.Add(new ColumnHeader()
        {
          TextAlign = HorizontalAlignment.Right,
          Text = "Loop #",
          Width = 50
        });
        this.ltvHistory.Columns.Add(new ColumnHeader()
        {
          TextAlign = HorizontalAlignment.Right,
          Text = "Objective",
          Width = 70
        });
        Graphics graphics2 = ((Control) this).CreateGraphics();
        for (int NParam = 0; NParam < this.optimizer.Count; ++NParam)
        {
          ColumnHeader columnHeader = new ColumnHeader();
          columnHeader.TextAlign = HorizontalAlignment.Right;
          columnHeader.Text = this.optimizer.GetParamName(NParam);
          columnHeader.Width = Math.Max(50, (int) graphics2.MeasureString(columnHeader.Text, this.ltvBestParameters.Font).Width + 10);
          this.ltvHistory.Columns.Add(columnHeader);
        }
        this.ltvHistory.EndUpdate();
        this.bestObjectiveValue = double.MinValue;
      }
    }

    private void Runner_OptimizationStopped(object sender, EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).Invoke((Delegate) new EventHandler(this.Runner_OptimizationStopped), sender, (object) e));
      }
      else
      {
        this.btnStop.Enabled = false;
        this.optimizer.Inited -= new EventHandler(this.optimizer_Inited);
        this.optimizer.ObjectiveCalled -= new EventHandler(this.optimizer_ObjectiveCalled);
        this.optimizer.BestObjectiveReceived -= new EventHandler(this.optimizer_BestObjectiveReceived);
        this.optimizer.OptimizationCompleted -= new EventHandler(this.optimizer_OptimizationCompleted);
      }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      Runner.StopOptimization();
    }

    private void btnTerminate_Click(object sender, EventArgs e)
    {
      Runner.TerminateOptimization();
    }

    private void lblExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.Export();
    }

    private void Export()
    {
      Application.DoEvents();
      CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
      try
      {
        ((Control) this).Cursor = Cursors.WaitCursor;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Excel excel = new Excel();
        excel.get_Workbooks().Add();
        Workbook workbook = excel.get_Workbooks().get_Item(1);
        WorksheetList worksheets = workbook.get_Worksheets();
        worksheets.AddLast();
        Worksheet sheet1 = worksheets.get_Item(1);
        sheet1.set_Name("Results");
        this.CopyDataToWorksheet(sheet1, new ListView[1]
        {
          this.ltvBestParameters
        });
        worksheets.AddLast();
        Worksheet sheet2 = worksheets.get_Item(2);
        sheet2.set_Name("Optimization_History");
        this.CopyDataToWorksheet(sheet2, new ListView[1]
        {
          this.ltvHistory
        });
        workbook.get_Worksheets().get_Item(1).Activate();
        excel.set_Visible(true);
      }
      finally
      {
        Thread.CurrentThread.CurrentCulture = currentCulture;
      }
      ((Control) this).Cursor = Cursors.Default;
    }

    private void CopyDataToWorksheet(Worksheet sheet, ListView[] listViewList)
    {
      int num = 2;
      for (int index = 0; index < listViewList[0].Columns.Count; ++index)
      {
        ColumnHeader columnHeader = listViewList[0].Columns[index];
        Range range = sheet.GetRange(1, index + 1);
        range.set_Bold(true);
        range.set_Value((object) columnHeader.Text);
      }
      foreach (ListView listView in listViewList)
      {
        for (int index1 = 0; index1 < listView.Items.Count; ++index1)
        {
          ListViewItem listViewItem = listView.Items[index1];
          for (int index2 = 0; index2 < listViewItem.SubItems.Count; ++index2)
          {
            Range range = sheet.GetRange(index1 + num, index2 + 1);
            if (listViewItem.SubItems[index2].Font.Italic)
              range.set_Italic(true);
            if (listViewItem.SubItems[index2].Font.Bold)
              range.set_Bold(true);
            if (listViewItem.SubItems[index2].Font.Underline)
              range.set_Underline(true);
            range.set_Value((object) listViewItem.SubItems[index2].Text);
          }
        }
        num += listView.Items.Count;
      }
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      ((DockControl) this).Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.tabControl1 = new TabControl();
      this.tabPage2 = new TabPage();
      this.groupBox3 = new GroupBox();
      this.panel3 = new Panel();
      this.ltvBestParameters = new ListView();
      this.label9 = new Label();
      this.panel2 = new Panel();
      this.lblBestObjective = new Label();
      this.label7 = new Label();
      this.lblLoopsCompleted = new Label();
      this.label6 = new Label();
      this.groupBox2 = new GroupBox();
      this.ltvParameters = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.groupBox1 = new GroupBox();
      this.lblObjective = new Label();
      this.lblOptimizerType = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.tabPage3 = new TabPage();
      this.ltvHistory = new ListView();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.panel1 = new Panel();
      this.btnTerminate = new Button();
      this.btnStop = new Button();
      this.toolTip1 = new ToolTip(this.components);
      this.lblExport = new LinkLabel();
      this.tabControl1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.panel1.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(652, 388);
      this.tabControl1.TabIndex = 1;
      this.tabPage2.Controls.Add((Control) this.groupBox3);
      this.tabPage2.Controls.Add((Control) this.groupBox2);
      this.tabPage2.Controls.Add((Control) this.groupBox1);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(644, 362);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Results";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.groupBox3.Controls.Add((Control) this.panel3);
      this.groupBox3.Controls.Add((Control) this.panel2);
      this.groupBox3.Dock = DockStyle.Fill;
      this.groupBox3.Location = new Point(3, 206);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(638, 153);
      this.groupBox3.TabIndex = 28;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Results";
      this.panel3.Controls.Add((Control) this.ltvBestParameters);
      this.panel3.Controls.Add((Control) this.label9);
      this.panel3.Dock = DockStyle.Bottom;
      this.panel3.Location = new Point(3, 95);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(632, 55);
      this.panel3.TabIndex = 30;
      this.ltvBestParameters.Dock = DockStyle.Bottom;
      this.ltvBestParameters.FullRowSelect = true;
      this.ltvBestParameters.GridLines = true;
      this.ltvBestParameters.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvBestParameters.Location = new Point(0, 17);
      this.ltvBestParameters.Name = "ltvBestParameters";
      this.ltvBestParameters.Size = new Size(632, 38);
      this.ltvBestParameters.TabIndex = 29;
      this.ltvBestParameters.UseCompatibleStateImageBehavior = false;
      this.ltvBestParameters.View = View.Details;
      this.label9.Location = new Point(0, 0);
      this.label9.Name = "label9";
      this.label9.Size = new Size(108, 19);
      this.label9.TabIndex = 27;
      this.label9.Text = "Best Parameters";
      this.panel2.Controls.Add((Control) this.lblBestObjective);
      this.panel2.Controls.Add((Control) this.label7);
      this.panel2.Controls.Add((Control) this.lblLoopsCompleted);
      this.panel2.Controls.Add((Control) this.label6);
      this.panel2.Dock = DockStyle.Top;
      this.panel2.Location = new Point(3, 16);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(632, 43);
      this.panel2.TabIndex = 29;
      this.lblBestObjective.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lblBestObjective.Location = new Point(101, 24);
      this.lblBestObjective.Name = "lblBestObjective";
      this.lblBestObjective.Size = new Size(361, 19);
      this.lblBestObjective.TabIndex = 30;
      this.label7.Location = new Point(4, 24);
      this.label7.Name = "label7";
      this.label7.Size = new Size(108, 19);
      this.label7.TabIndex = 29;
      this.label7.Text = "Best Objective :";
      this.lblLoopsCompleted.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.lblLoopsCompleted.Location = new Point(101, 5);
      this.lblLoopsCompleted.Name = "lblLoopsCompleted";
      this.lblLoopsCompleted.Size = new Size(231, 19);
      this.lblLoopsCompleted.TabIndex = 28;
      this.lblLoopsCompleted.Text = "12 of 100";
      this.label6.Location = new Point(4, 5);
      this.label6.Name = "label6";
      this.label6.Size = new Size(108, 19);
      this.label6.TabIndex = 27;
      this.label6.Text = "Loops Completed :";
      this.groupBox2.Controls.Add((Control) this.ltvParameters);
      this.groupBox2.Dock = DockStyle.Top;
      this.groupBox2.Location = new Point(3, 57);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(638, 149);
      this.groupBox2.TabIndex = 27;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Parameters";
      this.ltvParameters.Columns.AddRange(new ColumnHeader[5]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader7
      });
      this.ltvParameters.Dock = DockStyle.Fill;
      this.ltvParameters.FullRowSelect = true;
      this.ltvParameters.GridLines = true;
      this.ltvParameters.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvParameters.Location = new Point(3, 16);
      this.ltvParameters.Name = "ltvParameters";
      this.ltvParameters.Size = new Size(632, 130);
      this.ltvParameters.TabIndex = 9;
      this.ltvParameters.UseCompatibleStateImageBehavior = false;
      this.ltvParameters.View = View.Details;
      this.columnHeader1.Text = "Parameter";
      this.columnHeader1.Width = 142;
      this.columnHeader2.Text = "Strategy";
      this.columnHeader2.Width = 111;
      this.columnHeader3.Text = "Start";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 68;
      this.columnHeader4.Text = "Stop";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader7.Text = "Step";
      this.columnHeader7.TextAlign = HorizontalAlignment.Right;
      this.columnHeader7.Width = 62;
      this.groupBox1.Controls.Add((Control) this.lblObjective);
      this.groupBox1.Controls.Add((Control) this.lblOptimizerType);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Dock = DockStyle.Top;
      this.groupBox1.Location = new Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(638, 54);
      this.groupBox1.TabIndex = 26;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Settings";
      this.lblObjective.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblObjective.Location = new Point(103, 26);
      this.lblObjective.Name = "lblObjective";
      this.lblObjective.Size = new Size(89, 19);
      this.lblObjective.TabIndex = 22;
      this.lblObjective.Text = "FinalWealth";
      this.lblOptimizerType.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lblOptimizerType.Location = new Point(276, 26);
      this.lblOptimizerType.Name = "lblOptimizerType";
      this.lblOptimizerType.Size = new Size(100, 19);
      this.lblOptimizerType.TabIndex = 23;
      this.lblOptimizerType.Text = "BruteForce";
      this.label4.Location = new Point(198, 26);
      this.label4.Name = "label4";
      this.label4.Size = new Size(120, 16);
      this.label4.TabIndex = 18;
      this.label4.Text = "Optimizer Type :";
      this.label5.Location = new Point(6, 26);
      this.label5.Name = "label5";
      this.label5.Size = new Size(108, 19);
      this.label5.TabIndex = 21;
      this.label5.Text = "Objective Function :";
      this.tabPage3.Controls.Add((Control) this.ltvHistory);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new Size(644, 362);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "History";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.ltvHistory.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader5,
        this.columnHeader6
      });
      this.ltvHistory.Dock = DockStyle.Fill;
      this.ltvHistory.FullRowSelect = true;
      this.ltvHistory.GridLines = true;
      this.ltvHistory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvHistory.Location = new Point(0, 0);
      this.ltvHistory.Name = "ltvHistory";
      this.ltvHistory.Size = new Size(644, 362);
      this.ltvHistory.TabIndex = 29;
      this.ltvHistory.UseCompatibleStateImageBehavior = false;
      this.ltvHistory.View = View.Details;
      this.columnHeader5.Text = "Loop #";
      this.columnHeader6.Text = "Objective";
      this.columnHeader6.TextAlign = HorizontalAlignment.Right;
      this.columnHeader6.Width = 66;
      this.panel1.Controls.Add((Control) this.btnTerminate);
      this.panel1.Controls.Add((Control) this.btnStop);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 388);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(652, 31);
      this.panel1.TabIndex = 2;
      this.btnTerminate.Location = new Point(4, 5);
      this.btnTerminate.Name = "btnTerminate";
      this.btnTerminate.Size = new Size(75, 23);
      this.btnTerminate.TabIndex = 3;
      this.btnTerminate.Text = "Terminate";
      this.toolTip1.SetToolTip((Control) this.btnTerminate, "Terminate the optmization process");
      this.btnTerminate.UseVisualStyleBackColor = true;
      this.btnTerminate.Visible = false;
      this.btnTerminate.Click += new EventHandler(this.btnTerminate_Click);
      this.btnStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnStop.Enabled = false;
      this.btnStop.Location = new Point(573, 5);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new Size(75, 23);
      this.btnStop.TabIndex = 2;
      this.btnStop.Text = "Stop";
      this.toolTip1.SetToolTip((Control) this.btnStop, "Stop the optmization");
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new EventHandler(this.btnStop_Click);
      this.lblExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lblExport.AutoSize = true;
      this.lblExport.Location = new Point(601, 3);
      this.lblExport.Name = "lblExport";
      this.lblExport.Size = new Size(37, 13);
      this.lblExport.TabIndex = 15;
      this.lblExport.TabStop = true;
      this.lblExport.Text = "Export";
      this.lblExport.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lblExport_LinkClicked);
      ((DockControl) this).set_AllowDockCenter(true);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.lblExport);
      ((Control) this).Controls.Add((Control) this.tabControl1);
      ((Control) this).Controls.Add((Control) this.panel1);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "OptimizationWindow";
      ((DockControl) this).set_PersistState(false);
      ((Control) this).Size = new Size(652, 419);
      ((DockControl) this).set_TabText("Optimization");
      ((Control) this).Text = "OptimizationWindow";
      this.tabControl1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }
  }
}
