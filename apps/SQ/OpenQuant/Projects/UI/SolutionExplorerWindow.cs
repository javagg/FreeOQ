// Type: OpenQuant.Projects.UI.SolutionExplorerWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.API;
using OpenQuant.Config;
using OpenQuant.Portfolios;
using OpenQuant.Projects;
using OpenQuant.Projects.UI.Items;
using OpenQuant.Properties;
using OpenQuant.QuantTrader;
using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Instruments;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.ToolWindows;
using OpenQuant.Trading;
using SmartQuant.Data;
using SmartQuant.Docking.WinForms;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Projects.UI
{
  public class SolutionExplorerWindow : DockControl, IPropertyEditable
  {
    private IContainer components;
    private TreeView trvStrategy;
    private ImageList images;
    private ContextMenuStrip ctxStrategy;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem ctxStrategy_Properties;
    private ContextMenuStrip ctxInstrument;
    private ToolStripMenuItem ctxInstrument_Remove;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ctxInstrument_Properties;
    private ToolStripSeparator toolStripMenuItem2;
    private ToolStripMenuItem ctxStrategy_EditCode;
    private ToolStripMenuItem ctxStrategy_ViewResults;
    private ToolStripMenuItem ctxStrategy_ViewPerformance;
    private ContextMenuStrip ctxRequestList;
    private ToolStripMenuItem ctxRequestList_Add;
    private ToolStripMenuItem ctxRequestList_Add_Bar;
    private ToolStripMenuItem ctxRequestList_Add_Trade;
    private ToolStripMenuItem ctxRequestList_Daily;
    private ToolStripMenuItem ctxRequestList_Add_Quote;
    private ToolStripMenuItem ctxRequestList_Add_MarketDepth;
    private ContextMenuStrip ctxRequest;
    private ToolStripMenuItem ctxRequest_Remove;
    private ToolStripMenuItem ctxRequest_Enabled;
    private ToolStripMenuItem ctxRequest_IsBarFactoryRequest;
    private ToolStripSeparator toolStripMenuItem4;
    private ToolStripMenuItem ctxRequestList_Add_Bar_1Minute;
    private ToolStripMenuItem ctxRequestList_Add_Bar_5Minute;
    private ToolStripMenuItem ctxRequestList_Add_Bar_10Minute;
    private ToolStripMenuItem ctxRequestList_Add_Bar_15Minute;
    private ToolStripMenuItem ctxRequestList_Add_Bar_30Minute;
    private ToolStripSeparator toolStripMenuItem6;
    private ToolStripMenuItem ctxRequestList_Add_Bar_1Hour;
    private ToolStripMenuItem ctxRequestList_Add_Bar_2Hour;
    private ToolStripMenuItem ctxRequestList_Add_Bar_6Hour;
    private ToolStripMenuItem ctxRequestList_Add_Bar_12Hour;
    private ToolStripSeparator toolStripMenuItem5;
    private ToolStripMenuItem ctxRequestList_Add_Bar_Custom;
    private ContextMenuStrip ctxCode;
    private ToolStripMenuItem ctxCode_Edit;
    private ToolStripSeparator toolStripMenuItem7;
    private ToolStripMenuItem ctxRequestList_Clear;
    private ContextMenuStrip ctxInstrumentList;
    private ToolStripMenuItem ctxInstrumentList_Clear;
    private ContextMenuStrip ctxMethod;
    private ToolStripMenuItem ctxMethod_Goto;
    private ToolStripMenuItem ctxStrategy_ViewBarChart;
    private ToolStripMenuItem ctxInstrumentList_AddRemove;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem ctxInstrument_ViewChart;
    private ToolStripSeparator toolStripMenuItem8;
    private ToolStripMenuItem ctxStrategy_ViewMarketScanner;
    private ContextMenuStrip ctxSolution;
    private ToolStripMenuItem ctxSolution_Build;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ctxSolution_Run;
    private ToolStripMenuItem ctxSolution_Stop;
    private ToolStripSeparator toolStripMenuItem9;
    private ToolStripMenuItem ctxSolution_Optimize;
    private ToolStripSeparator toolStripMenuItem3;
    private ToolStripMenuItem ctxSolution_Add;
    private ToolStripMenuItem ctxSolution_Add_NewProject;
    private ToolStripSeparator toolStripMenuItem10;
    private ToolStripMenuItem ctxSolution_Add_ExistingProject;
    private ToolStripMenuItem ctxStrategy_ViewPortfolio;
    private ToolStripMenuItem ctxSolution_ViewBarChart;
    private ToolStripMenuItem ctxSolution_ViewPortfolio;
    private ToolStripMenuItem ctxSolution_ViewPerformance;
    private ToolStripMenuItem ctxSolution_ViewResults;
    private ToolStripMenuItem ctxSolution_ViewMarketScanner;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem ctxStrategy_Enabled;
    private ToolStripSeparator toolStripMenuItem11;
    private ToolStripMenuItem ctxStrategy_Remove;
    private ToolStripSeparator toolStripMenuItem12;
    private ToolStripMenuItem ctxSolution_ManageReferences;
    private ToolStripSeparator toolStripMenuItem13;
    private ToolStripMenuItem ctxSolution_Properties;
    private ToolStripMenuItem ctxRequestList_Add_Bar_20Second;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem ctxRequestList_Add_Bar_10Second;
    private ToolStripMenuItem ctxRequestList_Add_Bar_30Second;
    private ToolStripMenuItem ctxStrategy_Active;
    private ToolStripSeparator toolStripMenuItem14;
    private ToolStripMenuItem ctxSolution_EditScenario;
    private ContextMenuStrip ctxScenario;
    private ToolStripMenuItem ctxScenario_Edit;
    private ToolStripSeparator toolStripMenuItem15;
    private ToolStripMenuItem ctxStrategy_SaveSettings;
    private ToolStripMenuItem ctxStrategy_LoadSettings;
    private SaveFileDialog sfdProjectSettings;
    private OpenFileDialog ofdProjectSettings;
    private ToolStripMenuItem ctxSolution_ViewUserCommands;
    private ToolStripMenuItem ctxStrategy_ViewUserCommands;
    private ToolStripMenuItem ctxSolution_ExportToQT;
    private ToolStripSeparator toolStripSeparator6;
    private Solution solution;
    private OpenQuant.Projects.UI.Items.SolutionNode solutionNode;
    private Rectangle dragBoxFromMouseDown;
    private Point screenOffset;
    private Cursor myNoDropCursor;
    private Cursor myNormalCursor;
    private TreeNode nodeToDrag;

    public object PropertyObject
    {
      get
      {
        ObjectNode objectNode = this.trvStrategy.SelectedNode as ObjectNode;
        if (objectNode != null)
          return objectNode.Object;
        else
          return (object) null;
      }
    }

    public SolutionExplorerWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SolutionExplorerWindow));
      this.trvStrategy = new TreeView();
      this.images = new ImageList(this.components);
      this.ctxStrategy = new ContextMenuStrip(this.components);
      this.ctxStrategy_Active = new ToolStripMenuItem();
      this.ctxStrategy_Enabled = new ToolStripMenuItem();
      this.toolStripMenuItem11 = new ToolStripSeparator();
      this.ctxStrategy_EditCode = new ToolStripMenuItem();
      this.toolStripMenuItem2 = new ToolStripSeparator();
      this.ctxStrategy_ViewBarChart = new ToolStripMenuItem();
      this.ctxStrategy_ViewPortfolio = new ToolStripMenuItem();
      this.ctxStrategy_ViewPerformance = new ToolStripMenuItem();
      this.ctxStrategy_ViewResults = new ToolStripMenuItem();
      this.ctxStrategy_ViewMarketScanner = new ToolStripMenuItem();
      this.ctxStrategy_ViewUserCommands = new ToolStripMenuItem();
      this.toolStripMenuItem15 = new ToolStripSeparator();
      this.ctxStrategy_SaveSettings = new ToolStripMenuItem();
      this.ctxStrategy_LoadSettings = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripSeparator();
      this.ctxStrategy_Remove = new ToolStripMenuItem();
      this.toolStripMenuItem12 = new ToolStripSeparator();
      this.ctxStrategy_Properties = new ToolStripMenuItem();
      this.ctxInstrument = new ContextMenuStrip(this.components);
      this.ctxInstrument_ViewChart = new ToolStripMenuItem();
      this.toolStripMenuItem8 = new ToolStripSeparator();
      this.ctxInstrument_Remove = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxInstrument_Properties = new ToolStripMenuItem();
      this.ctxRequestList = new ContextMenuStrip(this.components);
      this.ctxRequestList_Add = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_10Second = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_20Second = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_30Second = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.ctxRequestList_Add_Bar_1Minute = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_5Minute = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_10Minute = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_15Minute = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_30Minute = new ToolStripMenuItem();
      this.toolStripMenuItem6 = new ToolStripSeparator();
      this.ctxRequestList_Add_Bar_1Hour = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_2Hour = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_6Hour = new ToolStripMenuItem();
      this.ctxRequestList_Add_Bar_12Hour = new ToolStripMenuItem();
      this.toolStripMenuItem5 = new ToolStripSeparator();
      this.ctxRequestList_Add_Bar_Custom = new ToolStripMenuItem();
      this.ctxRequestList_Daily = new ToolStripMenuItem();
      this.ctxRequestList_Add_Trade = new ToolStripMenuItem();
      this.ctxRequestList_Add_Quote = new ToolStripMenuItem();
      this.ctxRequestList_Add_MarketDepth = new ToolStripMenuItem();
      this.toolStripMenuItem7 = new ToolStripSeparator();
      this.ctxRequestList_Clear = new ToolStripMenuItem();
      this.ctxRequest = new ContextMenuStrip(this.components);
      this.ctxRequest_Enabled = new ToolStripMenuItem();
      this.ctxRequest_IsBarFactoryRequest = new ToolStripMenuItem();
      this.toolStripMenuItem4 = new ToolStripSeparator();
      this.ctxRequest_Remove = new ToolStripMenuItem();
      this.ctxCode = new ContextMenuStrip(this.components);
      this.ctxCode_Edit = new ToolStripMenuItem();
      this.ctxInstrumentList = new ContextMenuStrip(this.components);
      this.ctxInstrumentList_AddRemove = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.ctxInstrumentList_Clear = new ToolStripMenuItem();
      this.ctxMethod = new ContextMenuStrip(this.components);
      this.ctxMethod_Goto = new ToolStripMenuItem();
      this.ctxSolution = new ContextMenuStrip(this.components);
      this.ctxSolution_ViewBarChart = new ToolStripMenuItem();
      this.ctxSolution_ViewPortfolio = new ToolStripMenuItem();
      this.ctxSolution_ViewPerformance = new ToolStripMenuItem();
      this.ctxSolution_ViewResults = new ToolStripMenuItem();
      this.ctxSolution_ViewMarketScanner = new ToolStripMenuItem();
      this.ctxSolution_ViewUserCommands = new ToolStripMenuItem();
      this.toolStripMenuItem14 = new ToolStripSeparator();
      this.ctxSolution_EditScenario = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.ctxSolution_Add = new ToolStripMenuItem();
      this.ctxSolution_Add_NewProject = new ToolStripMenuItem();
      this.toolStripMenuItem10 = new ToolStripSeparator();
      this.ctxSolution_Add_ExistingProject = new ToolStripMenuItem();
      this.toolStripMenuItem3 = new ToolStripSeparator();
      this.ctxSolution_ManageReferences = new ToolStripMenuItem();
      this.ctxSolution_Build = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.ctxSolution_Run = new ToolStripMenuItem();
      this.ctxSolution_Stop = new ToolStripMenuItem();
      this.toolStripMenuItem9 = new ToolStripSeparator();
      this.ctxSolution_Optimize = new ToolStripMenuItem();
      this.toolStripMenuItem13 = new ToolStripSeparator();
      this.ctxSolution_Properties = new ToolStripMenuItem();
      this.ctxScenario = new ContextMenuStrip(this.components);
      this.ctxScenario_Edit = new ToolStripMenuItem();
      this.sfdProjectSettings = new SaveFileDialog();
      this.ofdProjectSettings = new OpenFileDialog();
      this.ctxSolution_ExportToQT = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.ctxStrategy.SuspendLayout();
      this.ctxInstrument.SuspendLayout();
      this.ctxRequestList.SuspendLayout();
      this.ctxRequest.SuspendLayout();
      this.ctxCode.SuspendLayout();
      this.ctxInstrumentList.SuspendLayout();
      this.ctxMethod.SuspendLayout();
      this.ctxSolution.SuspendLayout();
      this.ctxScenario.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.trvStrategy.AllowDrop = true;
      this.trvStrategy.Dock = DockStyle.Fill;
      this.trvStrategy.HideSelection = false;
      this.trvStrategy.ImageIndex = 0;
      this.trvStrategy.ImageList = this.images;
      this.trvStrategy.Location = new Point(0, 0);
      this.trvStrategy.Name = "trvStrategy";
      this.trvStrategy.SelectedImageIndex = 0;
      this.trvStrategy.ShowRootLines = false;
      this.trvStrategy.Size = new Size(250, 400);
      this.trvStrategy.TabIndex = 0;
      this.trvStrategy.BeforeCollapse += new TreeViewCancelEventHandler(this.trvStrategy_BeforeCollapse);
      this.trvStrategy.AfterCollapse += new TreeViewEventHandler(this.trvStrategy_AfterCollapse);
      this.trvStrategy.AfterExpand += new TreeViewEventHandler(this.trvStrategy_AfterExpand);
      this.trvStrategy.AfterSelect += new TreeViewEventHandler(this.trvStrategy_AfterSelect);
      this.trvStrategy.DragDrop += new DragEventHandler(this.trvStrategy_DragDrop);
      this.trvStrategy.DragOver += new DragEventHandler(this.trvStrategy_DragOver);
      this.trvStrategy.DoubleClick += new EventHandler(this.trvStrategy_DoubleClick);
      this.trvStrategy.KeyDown += new KeyEventHandler(this.trvStrategy_KeyDown);
      this.trvStrategy.MouseDown += new MouseEventHandler(this.trvStrategy_MouseDown);
      this.trvStrategy.MouseMove += new MouseEventHandler(this.trvStrategy_MouseMove);
      this.trvStrategy.MouseUp += new MouseEventHandler(this.trvStrategy_MouseUp);
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "die.png");
      this.images.Images.SetKeyName(1, "VSFolder_open.png");
      this.images.Images.SetKeyName(2, "VSFolder_closed.png");
      this.images.Images.SetKeyName(3, "");
      this.images.Images.SetKeyName(4, "");
      this.images.Images.SetKeyName(5, "");
      this.images.Images.SetKeyName(6, "note_delete.png");
      this.images.Images.SetKeyName(7, "note.png");
      this.images.Images.SetKeyName(8, "VSObject_Event.png");
      this.images.Images.SetKeyName(9, "code_cs.png");
      this.images.Images.SetKeyName(10, "code_vb.png");
      this.images.Images.SetKeyName(11, "die_gold.png");
      this.images.Images.SetKeyName(12, "openquant_disabled.png");
      this.ctxStrategy.Items.AddRange(new ToolStripItem[18]
      {
        (ToolStripItem) this.ctxStrategy_Active,
        (ToolStripItem) this.ctxStrategy_Enabled,
        (ToolStripItem) this.toolStripMenuItem11,
        (ToolStripItem) this.ctxStrategy_EditCode,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.ctxStrategy_ViewBarChart,
        (ToolStripItem) this.ctxStrategy_ViewPortfolio,
        (ToolStripItem) this.ctxStrategy_ViewPerformance,
        (ToolStripItem) this.ctxStrategy_ViewResults,
        (ToolStripItem) this.ctxStrategy_ViewMarketScanner,
        (ToolStripItem) this.ctxStrategy_ViewUserCommands,
        (ToolStripItem) this.toolStripMenuItem15,
        (ToolStripItem) this.ctxStrategy_SaveSettings,
        (ToolStripItem) this.ctxStrategy_LoadSettings,
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.ctxStrategy_Remove,
        (ToolStripItem) this.toolStripMenuItem12,
        (ToolStripItem) this.ctxStrategy_Properties
      });
      this.ctxStrategy.Name = "ctxStrategy";
      this.ctxStrategy.Size = new Size(191, 342);
      this.ctxStrategy.Opening += new CancelEventHandler(this.ctxStrategy_Opening);
      this.ctxStrategy_Active.Checked = true;
      this.ctxStrategy_Active.CheckOnClick = true;
      this.ctxStrategy_Active.CheckState = CheckState.Checked;
      this.ctxStrategy_Active.Name = "ctxStrategy_Active";
      this.ctxStrategy_Active.Size = new Size(190, 22);
      this.ctxStrategy_Active.Text = "Active";
      this.ctxStrategy_Active.Click += new EventHandler(this.ctxStrategy_Active_Click);
      this.ctxStrategy_Enabled.Checked = true;
      this.ctxStrategy_Enabled.CheckOnClick = true;
      this.ctxStrategy_Enabled.CheckState = CheckState.Checked;
      this.ctxStrategy_Enabled.Name = "ctxStrategy_Enabled";
      this.ctxStrategy_Enabled.Size = new Size(190, 22);
      this.ctxStrategy_Enabled.Text = "Enabled";
      this.ctxStrategy_Enabled.Click += new EventHandler(this.ctxStrategy_Enabled_Click);
      this.toolStripMenuItem11.Name = "toolStripMenuItem11";
      this.toolStripMenuItem11.Size = new Size(187, 6);
      this.ctxStrategy_EditCode.Image = (Image) Resources.code_edit;
      this.ctxStrategy_EditCode.Name = "ctxStrategy_EditCode";
      this.ctxStrategy_EditCode.Size = new Size(190, 22);
      this.ctxStrategy_EditCode.Text = "Edit Code";
      this.ctxStrategy_EditCode.Click += new EventHandler(this.ctxStrategy_EditCode_Click);
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new Size(187, 6);
      this.ctxStrategy_ViewBarChart.Image = (Image) Resources.chart;
      this.ctxStrategy_ViewBarChart.Name = "ctxStrategy_ViewBarChart";
      this.ctxStrategy_ViewBarChart.Size = new Size(190, 22);
      this.ctxStrategy_ViewBarChart.Text = "View Bar Chart";
      this.ctxStrategy_ViewBarChart.Click += new EventHandler(this.ctxStrategy_ViewBarChart_Click);
      this.ctxStrategy_ViewPortfolio.Image = (Image) Resources.portfolio;
      this.ctxStrategy_ViewPortfolio.Name = "ctxStrategy_ViewPortfolio";
      this.ctxStrategy_ViewPortfolio.Size = new Size(190, 22);
      this.ctxStrategy_ViewPortfolio.Text = "View Portfolio";
      this.ctxStrategy_ViewPortfolio.Click += new EventHandler(this.ctxStrategy_ViewPortfolio_Click);
      this.ctxStrategy_ViewPerformance.Image = (Image) Resources.performance;
      this.ctxStrategy_ViewPerformance.Name = "ctxStrategy_ViewPerformance";
      this.ctxStrategy_ViewPerformance.Size = new Size(190, 22);
      this.ctxStrategy_ViewPerformance.Text = "View Performance";
      this.ctxStrategy_ViewPerformance.Click += new EventHandler(this.ctxStrategy_ViewPerformance_Click);
      this.ctxStrategy_ViewResults.Image = (Image) Resources.results;
      this.ctxStrategy_ViewResults.Name = "ctxStrategy_ViewResults";
      this.ctxStrategy_ViewResults.Size = new Size(190, 22);
      this.ctxStrategy_ViewResults.Text = "View Results";
      this.ctxStrategy_ViewResults.Click += new EventHandler(this.ctxStrategy_ViewResults_Click);
      this.ctxStrategy_ViewMarketScanner.Image = (Image) Resources.market_scanner;
      this.ctxStrategy_ViewMarketScanner.Name = "ctxStrategy_ViewMarketScanner";
      this.ctxStrategy_ViewMarketScanner.Size = new Size(190, 22);
      this.ctxStrategy_ViewMarketScanner.Text = "View Market Scanner";
      this.ctxStrategy_ViewMarketScanner.Click += new EventHandler(this.ctxStrategy_ViewMarketScanner_Click);
      this.ctxStrategy_ViewUserCommands.Image = (Image) Resources.user_command;
      this.ctxStrategy_ViewUserCommands.Name = "ctxStrategy_ViewUserCommands";
      this.ctxStrategy_ViewUserCommands.Size = new Size(190, 22);
      this.ctxStrategy_ViewUserCommands.Text = "View User Commands";
      this.ctxStrategy_ViewUserCommands.Click += new EventHandler(this.ctxStrategy_ViewUserCommands_Click);
      this.toolStripMenuItem15.Name = "toolStripMenuItem15";
      this.toolStripMenuItem15.Size = new Size(187, 6);
      this.ctxStrategy_SaveSettings.Name = "ctxStrategy_SaveSettings";
      this.ctxStrategy_SaveSettings.Size = new Size(190, 22);
      this.ctxStrategy_SaveSettings.Text = "Save Settings...";
      this.ctxStrategy_SaveSettings.Click += new EventHandler(this.ctxStrategy_SaveSettings_Click);
      this.ctxStrategy_LoadSettings.Name = "ctxStrategy_LoadSettings";
      this.ctxStrategy_LoadSettings.Size = new Size(190, 22);
      this.ctxStrategy_LoadSettings.Text = "Load Settings...";
      this.ctxStrategy_LoadSettings.Click += new EventHandler(this.ctxStrategy_LoadSettings_Click);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(187, 6);
      this.ctxStrategy_Remove.Image = (Image) Resources.remove;
      this.ctxStrategy_Remove.Name = "ctxStrategy_Remove";
      this.ctxStrategy_Remove.Size = new Size(190, 22);
      this.ctxStrategy_Remove.Text = "Remove";
      this.ctxStrategy_Remove.Click += new EventHandler(this.ctxStrategy_Remove_Click);
      this.toolStripMenuItem12.Name = "toolStripMenuItem12";
      this.toolStripMenuItem12.Size = new Size(187, 6);
      this.ctxStrategy_Properties.Image = (Image) Resources.preferences;
      this.ctxStrategy_Properties.Name = "ctxStrategy_Properties";
      this.ctxStrategy_Properties.Size = new Size(190, 22);
      this.ctxStrategy_Properties.Text = "Properties";
      this.ctxStrategy_Properties.Click += new EventHandler(this.ctxStrategy_Properties_Click);
      this.ctxInstrument.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ctxInstrument_ViewChart,
        (ToolStripItem) this.toolStripMenuItem8,
        (ToolStripItem) this.ctxInstrument_Remove,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxInstrument_Properties
      });
      this.ctxInstrument.Name = "ctxStrategy";
      this.ctxInstrument.Size = new Size(132, 82);
      this.ctxInstrument.Opening += new CancelEventHandler(this.ctxInstrument_Opening);
      this.ctxInstrument_ViewChart.Image = (Image) Resources.chart;
      this.ctxInstrument_ViewChart.Name = "ctxInstrument_ViewChart";
      this.ctxInstrument_ViewChart.Size = new Size(131, 22);
      this.ctxInstrument_ViewChart.Text = "View Chart";
      this.ctxInstrument_ViewChart.Click += new EventHandler(this.ctxInstrument_ViewChart_Click);
      this.toolStripMenuItem8.Name = "toolStripMenuItem8";
      this.toolStripMenuItem8.Size = new Size(128, 6);
      this.ctxInstrument_Remove.Image = (Image) Resources.remove;
      this.ctxInstrument_Remove.Name = "ctxInstrument_Remove";
      this.ctxInstrument_Remove.Size = new Size(131, 22);
      this.ctxInstrument_Remove.Text = "Remove";
      this.ctxInstrument_Remove.Click += new EventHandler(this.ctxInstrument_Remove_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(128, 6);
      this.ctxInstrument_Properties.Image = (Image) Resources.preferences;
      this.ctxInstrument_Properties.Name = "ctxInstrument_Properties";
      this.ctxInstrument_Properties.Size = new Size(131, 22);
      this.ctxInstrument_Properties.Text = "Properties";
      this.ctxInstrument_Properties.Click += new EventHandler(this.ctxInstrument_Properties_Click);
      this.ctxRequestList.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ctxRequestList_Add,
        (ToolStripItem) this.toolStripMenuItem7,
        (ToolStripItem) this.ctxRequestList_Clear
      });
      this.ctxRequestList.Name = "ctxRequestList";
      this.ctxRequestList.Size = new Size(102, 54);
      this.ctxRequestList.Opening += new CancelEventHandler(this.ctxRequestList_Opening);
      this.ctxRequestList_Add.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ctxRequestList_Add_Bar,
        (ToolStripItem) this.ctxRequestList_Daily,
        (ToolStripItem) this.ctxRequestList_Add_Trade,
        (ToolStripItem) this.ctxRequestList_Add_Quote,
        (ToolStripItem) this.ctxRequestList_Add_MarketDepth
      });
      this.ctxRequestList_Add.Name = "ctxRequestList_Add";
      this.ctxRequestList_Add.Size = new Size(101, 22);
      this.ctxRequestList_Add.Text = "Add";
      this.ctxRequestList_Add_Bar.DropDownItems.AddRange(new ToolStripItem[16]
      {
        (ToolStripItem) this.ctxRequestList_Add_Bar_10Second,
        (ToolStripItem) this.ctxRequestList_Add_Bar_20Second,
        (ToolStripItem) this.ctxRequestList_Add_Bar_30Second,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.ctxRequestList_Add_Bar_1Minute,
        (ToolStripItem) this.ctxRequestList_Add_Bar_5Minute,
        (ToolStripItem) this.ctxRequestList_Add_Bar_10Minute,
        (ToolStripItem) this.ctxRequestList_Add_Bar_15Minute,
        (ToolStripItem) this.ctxRequestList_Add_Bar_30Minute,
        (ToolStripItem) this.toolStripMenuItem6,
        (ToolStripItem) this.ctxRequestList_Add_Bar_1Hour,
        (ToolStripItem) this.ctxRequestList_Add_Bar_2Hour,
        (ToolStripItem) this.ctxRequestList_Add_Bar_6Hour,
        (ToolStripItem) this.ctxRequestList_Add_Bar_12Hour,
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.ctxRequestList_Add_Bar_Custom
      });
      this.ctxRequestList_Add_Bar.Name = "ctxRequestList_Add_Bar";
      this.ctxRequestList_Add_Bar.Size = new Size(143, 22);
      this.ctxRequestList_Add_Bar.Text = "Bar";
      this.ctxRequestList_Add_Bar_10Second.Name = "ctxRequestList_Add_Bar_10Second";
      this.ctxRequestList_Add_Bar_10Second.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_10Second.Text = "10 Seconds";
      this.ctxRequestList_Add_Bar_10Second.Click += new EventHandler(this.ctxRequestList_Add_Bar_10Second_Click);
      this.ctxRequestList_Add_Bar_20Second.Name = "ctxRequestList_Add_Bar_20Second";
      this.ctxRequestList_Add_Bar_20Second.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_20Second.Text = "20 Seconds";
      this.ctxRequestList_Add_Bar_20Second.Click += new EventHandler(this.ctxRequestList_Add_Bar_20Second_Click);
      this.ctxRequestList_Add_Bar_30Second.Name = "ctxRequestList_Add_Bar_30Second";
      this.ctxRequestList_Add_Bar_30Second.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_30Second.Text = "30 Seconds";
      this.ctxRequestList_Add_Bar_30Second.Click += new EventHandler(this.ctxRequestList_Add_Bar_30Second_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(130, 6);
      this.ctxRequestList_Add_Bar_1Minute.Name = "ctxRequestList_Add_Bar_1Minute";
      this.ctxRequestList_Add_Bar_1Minute.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_1Minute.Text = "1 Minute";
      this.ctxRequestList_Add_Bar_1Minute.Click += new EventHandler(this.ctxRequestList_Add_Bar_1Minute_Click);
      this.ctxRequestList_Add_Bar_5Minute.Name = "ctxRequestList_Add_Bar_5Minute";
      this.ctxRequestList_Add_Bar_5Minute.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_5Minute.Text = "5 Minutes";
      this.ctxRequestList_Add_Bar_5Minute.Click += new EventHandler(this.ctxRequestList_Add_Bar_5Minute_Click);
      this.ctxRequestList_Add_Bar_10Minute.Name = "ctxRequestList_Add_Bar_10Minute";
      this.ctxRequestList_Add_Bar_10Minute.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_10Minute.Text = "10 Minutes";
      this.ctxRequestList_Add_Bar_10Minute.Click += new EventHandler(this.ctxRequestList_Add_Bar_10Minute_Click);
      this.ctxRequestList_Add_Bar_15Minute.Name = "ctxRequestList_Add_Bar_15Minute";
      this.ctxRequestList_Add_Bar_15Minute.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_15Minute.Text = "15 Minutes";
      this.ctxRequestList_Add_Bar_15Minute.Click += new EventHandler(this.ctxRequestList_Add_Bar_15Minute_Click);
      this.ctxRequestList_Add_Bar_30Minute.Name = "ctxRequestList_Add_Bar_30Minute";
      this.ctxRequestList_Add_Bar_30Minute.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_30Minute.Text = "30 Minutes";
      this.ctxRequestList_Add_Bar_30Minute.Click += new EventHandler(this.ctxRequestList_Add_Bar_30Minute_Click);
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new Size(130, 6);
      this.ctxRequestList_Add_Bar_1Hour.Name = "ctxRequestList_Add_Bar_1Hour";
      this.ctxRequestList_Add_Bar_1Hour.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_1Hour.Text = "1 Hour";
      this.ctxRequestList_Add_Bar_1Hour.Click += new EventHandler(this.ctxRequestList_Add_Bar_1Hour_Click);
      this.ctxRequestList_Add_Bar_2Hour.Name = "ctxRequestList_Add_Bar_2Hour";
      this.ctxRequestList_Add_Bar_2Hour.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_2Hour.Text = "2 Hours";
      this.ctxRequestList_Add_Bar_2Hour.Click += new EventHandler(this.ctxRequestList_Add_Bar_2Hour_Click);
      this.ctxRequestList_Add_Bar_6Hour.Name = "ctxRequestList_Add_Bar_6Hour";
      this.ctxRequestList_Add_Bar_6Hour.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_6Hour.Text = "6 Hours";
      this.ctxRequestList_Add_Bar_6Hour.Click += new EventHandler(this.ctxRequestList_Add_Bar_6Hour_Click);
      this.ctxRequestList_Add_Bar_12Hour.Name = "ctxRequestList_Add_Bar_12Hour";
      this.ctxRequestList_Add_Bar_12Hour.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_12Hour.Text = "12 Hours";
      this.ctxRequestList_Add_Bar_12Hour.Click += new EventHandler(this.ctxRequestList_Add_Bar_12Hour_Click);
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new Size(130, 6);
      this.ctxRequestList_Add_Bar_Custom.Name = "ctxRequestList_Add_Bar_Custom";
      this.ctxRequestList_Add_Bar_Custom.Size = new Size(133, 22);
      this.ctxRequestList_Add_Bar_Custom.Text = "Custom...";
      this.ctxRequestList_Add_Bar_Custom.Click += new EventHandler(this.ctxRequestList_Add_Bar_Custom_Click);
      this.ctxRequestList_Daily.Name = "ctxRequestList_Daily";
      this.ctxRequestList_Daily.Size = new Size(143, 22);
      this.ctxRequestList_Daily.Text = "Daily";
      this.ctxRequestList_Daily.Click += new EventHandler(this.ctxRequestList_Daily_Click);
      this.ctxRequestList_Add_Trade.Name = "ctxRequestList_Add_Trade";
      this.ctxRequestList_Add_Trade.Size = new Size(143, 22);
      this.ctxRequestList_Add_Trade.Text = "Trade";
      this.ctxRequestList_Add_Trade.Click += new EventHandler(this.ctxRequestList_Add_Trade_Click);
      this.ctxRequestList_Add_Quote.Name = "ctxRequestList_Add_Quote";
      this.ctxRequestList_Add_Quote.Size = new Size(143, 22);
      this.ctxRequestList_Add_Quote.Text = "Quote";
      this.ctxRequestList_Add_Quote.Click += new EventHandler(this.ctxRequestList_Add_Quote_Click);
      this.ctxRequestList_Add_MarketDepth.Name = "ctxRequestList_Add_MarketDepth";
      this.ctxRequestList_Add_MarketDepth.Size = new Size(143, 22);
      this.ctxRequestList_Add_MarketDepth.Text = "MarketDepth";
      this.ctxRequestList_Add_MarketDepth.Click += new EventHandler(this.ctxRequestList_Add_MarketDepth_Click);
      this.toolStripMenuItem7.Name = "toolStripMenuItem7";
      this.toolStripMenuItem7.Size = new Size(98, 6);
      this.ctxRequestList_Clear.Image = (Image) Resources.clear;
      this.ctxRequestList_Clear.Name = "ctxRequestList_Clear";
      this.ctxRequestList_Clear.Size = new Size(101, 22);
      this.ctxRequestList_Clear.Text = "Clear";
      this.ctxRequestList_Clear.Click += new EventHandler(this.ctxRequestList_Clear_Click);
      this.ctxRequest.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.ctxRequest_Enabled,
        (ToolStripItem) this.ctxRequest_IsBarFactoryRequest,
        (ToolStripItem) this.toolStripMenuItem4,
        (ToolStripItem) this.ctxRequest_Remove
      });
      this.ctxRequest.Name = "ctxStrategy";
      this.ctxRequest.Size = new Size(194, 76);
      this.ctxRequest.Opening += new CancelEventHandler(this.ctxRequest_Opening);
      this.ctxRequest_Enabled.Checked = true;
      this.ctxRequest_Enabled.CheckOnClick = true;
      this.ctxRequest_Enabled.CheckState = CheckState.Checked;
      this.ctxRequest_Enabled.Name = "ctxRequest_Enabled";
      this.ctxRequest_Enabled.Size = new Size(193, 22);
      this.ctxRequest_Enabled.Text = "Enabled";
      this.ctxRequest_Enabled.CheckedChanged += new EventHandler(this.ctxRequest_Enabled_CheckedChanged);
      this.ctxRequest_IsBarFactoryRequest.CheckOnClick = true;
      this.ctxRequest_IsBarFactoryRequest.Name = "ctxRequest_IsBarFactoryRequest";
      this.ctxRequest_IsBarFactoryRequest.Size = new Size(193, 22);
      this.ctxRequest_IsBarFactoryRequest.Text = "Build Bars from Trades";
      this.ctxRequest_IsBarFactoryRequest.Click += new EventHandler(this.ctxRequest_IsBarFactoryRequest_Click);
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new Size(190, 6);
      this.ctxRequest_Remove.Image = (Image) Resources.remove;
      this.ctxRequest_Remove.Name = "ctxRequest_Remove";
      this.ctxRequest_Remove.Size = new Size(193, 22);
      this.ctxRequest_Remove.Text = "Remove";
      this.ctxRequest_Remove.Click += new EventHandler(this.ctxRequest_Remove_Click);
      this.ctxCode.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ctxCode_Edit
      });
      this.ctxCode.Name = "ctxCode";
      this.ctxCode.Size = new Size(95, 26);
      this.ctxCode_Edit.Name = "ctxCode_Edit";
      this.ctxCode_Edit.Size = new Size(94, 22);
      this.ctxCode_Edit.Text = "Edit";
      this.ctxCode_Edit.Click += new EventHandler(this.ctxCode_Edit_Click);
      this.ctxInstrumentList.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ctxInstrumentList_AddRemove,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.ctxInstrumentList_Clear
      });
      this.ctxInstrumentList.Name = "ctxStrategy";
      this.ctxInstrumentList.Size = new Size(232, 54);
      this.ctxInstrumentList.Opening += new CancelEventHandler(this.ctxInstrumentList_Opening);
      this.ctxInstrumentList_AddRemove.Image = (Image) Resources.instrument;
      this.ctxInstrumentList_AddRemove.Name = "ctxInstrumentList_AddRemove";
      this.ctxInstrumentList_AddRemove.Size = new Size(231, 22);
      this.ctxInstrumentList_AddRemove.Text = "Add or Remove Instruments...";
      this.ctxInstrumentList_AddRemove.Click += new EventHandler(this.ctxInstrumentList_AddRemove_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(228, 6);
      this.ctxInstrumentList_Clear.Image = (Image) Resources.clear;
      this.ctxInstrumentList_Clear.Name = "ctxInstrumentList_Clear";
      this.ctxInstrumentList_Clear.Size = new Size(231, 22);
      this.ctxInstrumentList_Clear.Text = "Clear";
      this.ctxInstrumentList_Clear.Click += new EventHandler(this.ctxInstrumentList_Clear_Click);
      this.ctxMethod.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ctxMethod_Goto
      });
      this.ctxMethod.Name = "ctxMethod";
      this.ctxMethod.Size = new Size(162, 26);
      this.ctxMethod_Goto.Name = "ctxMethod_Goto";
      this.ctxMethod_Goto.Size = new Size(161, 22);
      this.ctxMethod_Goto.Text = "Go To Definition";
      this.ctxMethod_Goto.Click += new EventHandler(this.ctxMethod_Goto_Click);
      this.ctxSolution.Items.AddRange(new ToolStripItem[22]
      {
        (ToolStripItem) this.ctxSolution_ViewBarChart,
        (ToolStripItem) this.ctxSolution_ViewPortfolio,
        (ToolStripItem) this.ctxSolution_ViewPerformance,
        (ToolStripItem) this.ctxSolution_ViewResults,
        (ToolStripItem) this.ctxSolution_ViewMarketScanner,
        (ToolStripItem) this.ctxSolution_ViewUserCommands,
        (ToolStripItem) this.toolStripMenuItem14,
        (ToolStripItem) this.ctxSolution_EditScenario,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.ctxSolution_Add,
        (ToolStripItem) this.toolStripMenuItem3,
        (ToolStripItem) this.ctxSolution_ManageReferences,
        (ToolStripItem) this.ctxSolution_Build,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.ctxSolution_Run,
        (ToolStripItem) this.ctxSolution_Stop,
        (ToolStripItem) this.toolStripMenuItem9,
        (ToolStripItem) this.ctxSolution_Optimize,
        (ToolStripItem) this.toolStripMenuItem13,
        (ToolStripItem) this.ctxSolution_ExportToQT,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.ctxSolution_Properties
      });
      this.ctxSolution.Name = "ctxSolution";
      this.ctxSolution.Size = new Size(201, 398);
      this.ctxSolution.Opening += new CancelEventHandler(this.ctxSolution_Opening);
      this.ctxSolution_ViewBarChart.Image = (Image) Resources.chart;
      this.ctxSolution_ViewBarChart.Name = "ctxSolution_ViewBarChart";
      this.ctxSolution_ViewBarChart.Size = new Size(200, 22);
      this.ctxSolution_ViewBarChart.Text = "View Bar Chart";
      this.ctxSolution_ViewBarChart.Click += new EventHandler(this.ctxSolution_ViewBarChart_Click);
      this.ctxSolution_ViewPortfolio.Image = (Image) Resources.portfolio;
      this.ctxSolution_ViewPortfolio.Name = "ctxSolution_ViewPortfolio";
      this.ctxSolution_ViewPortfolio.Size = new Size(200, 22);
      this.ctxSolution_ViewPortfolio.Text = "View Portfolio";
      this.ctxSolution_ViewPortfolio.Click += new EventHandler(this.ctxSolution_ViewPortfolio_Click);
      this.ctxSolution_ViewPerformance.Image = (Image) Resources.performance;
      this.ctxSolution_ViewPerformance.Name = "ctxSolution_ViewPerformance";
      this.ctxSolution_ViewPerformance.Size = new Size(200, 22);
      this.ctxSolution_ViewPerformance.Text = "View Performance";
      this.ctxSolution_ViewPerformance.Click += new EventHandler(this.ctxSolution_ViewPerformance_Click);
      this.ctxSolution_ViewResults.Image = (Image) Resources.results;
      this.ctxSolution_ViewResults.Name = "ctxSolution_ViewResults";
      this.ctxSolution_ViewResults.Size = new Size(200, 22);
      this.ctxSolution_ViewResults.Text = "View Results";
      this.ctxSolution_ViewResults.Click += new EventHandler(this.ctxSolution_ViewResults_Click);
      this.ctxSolution_ViewMarketScanner.Image = (Image) Resources.market_scanner;
      this.ctxSolution_ViewMarketScanner.Name = "ctxSolution_ViewMarketScanner";
      this.ctxSolution_ViewMarketScanner.Size = new Size(200, 22);
      this.ctxSolution_ViewMarketScanner.Text = "View Market Scanner";
      this.ctxSolution_ViewMarketScanner.Click += new EventHandler(this.ctxSolution_ViewMarketScanner_Click);
      this.ctxSolution_ViewUserCommands.Image = (Image) Resources.user_command;
      this.ctxSolution_ViewUserCommands.Name = "ctxSolution_ViewUserCommands";
      this.ctxSolution_ViewUserCommands.Size = new Size(200, 22);
      this.ctxSolution_ViewUserCommands.Text = "View User Commands";
      this.ctxSolution_ViewUserCommands.Click += new EventHandler(this.ctxSolution_ViewUserCommands_Click);
      this.toolStripMenuItem14.Name = "toolStripMenuItem14";
      this.toolStripMenuItem14.Size = new Size(197, 6);
      this.ctxSolution_EditScenario.Image = (Image) Resources.code_edit;
      this.ctxSolution_EditScenario.Name = "ctxSolution_EditScenario";
      this.ctxSolution_EditScenario.Size = new Size(200, 22);
      this.ctxSolution_EditScenario.Text = "Edit Scenario";
      this.ctxSolution_EditScenario.Click += new EventHandler(this.ctxSolution_EditScenario_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(197, 6);
      this.ctxSolution_Add.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ctxSolution_Add_NewProject,
        (ToolStripItem) this.toolStripMenuItem10,
        (ToolStripItem) this.ctxSolution_Add_ExistingProject
      });
      this.ctxSolution_Add.Name = "ctxSolution_Add";
      this.ctxSolution_Add.Size = new Size(200, 22);
      this.ctxSolution_Add.Text = "Add";
      this.ctxSolution_Add_NewProject.Image = (Image) Resources.openquant;
      this.ctxSolution_Add_NewProject.Name = "ctxSolution_Add_NewProject";
      this.ctxSolution_Add_NewProject.Size = new Size(163, 22);
      this.ctxSolution_Add_NewProject.Text = "New Project...";
      this.ctxSolution_Add_NewProject.Click += new EventHandler(this.ctxSolution_Add_NewProject_Click);
      this.toolStripMenuItem10.Name = "toolStripMenuItem10";
      this.toolStripMenuItem10.Size = new Size(160, 6);
      this.ctxSolution_Add_ExistingProject.Image = (Image) Resources.openquant;
      this.ctxSolution_Add_ExistingProject.Name = "ctxSolution_Add_ExistingProject";
      this.ctxSolution_Add_ExistingProject.Size = new Size(163, 22);
      this.ctxSolution_Add_ExistingProject.Text = "Existing Project...";
      this.ctxSolution_Add_ExistingProject.Click += new EventHandler(this.ctxSolution_Add_ExistingProject_Click);
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new Size(197, 6);
      this.ctxSolution_ManageReferences.Image = (Image) Resources.reference;
      this.ctxSolution_ManageReferences.Name = "ctxSolution_ManageReferences";
      this.ctxSolution_ManageReferences.Size = new Size(200, 22);
      this.ctxSolution_ManageReferences.Text = "Manage References...";
      this.ctxSolution_ManageReferences.Click += new EventHandler(this.ctxSolution_ManageReferences_Click);
      this.ctxSolution_Build.Image = (Image) Resources.project_build;
      this.ctxSolution_Build.Name = "ctxSolution_Build";
      this.ctxSolution_Build.Size = new Size(200, 22);
      this.ctxSolution_Build.Text = "Build";
      this.ctxSolution_Build.Click += new EventHandler(this.ctxSolution_Build_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(197, 6);
      this.ctxSolution_Run.Image = (Image) Resources.project_run;
      this.ctxSolution_Run.Name = "ctxSolution_Run";
      this.ctxSolution_Run.Size = new Size(200, 22);
      this.ctxSolution_Run.Text = "Run";
      this.ctxSolution_Run.Click += new EventHandler(this.ctxSolution_Run_Click);
      this.ctxSolution_Stop.Image = (Image) Resources.project_stop;
      this.ctxSolution_Stop.Name = "ctxSolution_Stop";
      this.ctxSolution_Stop.Size = new Size(200, 22);
      this.ctxSolution_Stop.Text = "Stop";
      this.ctxSolution_Stop.Click += new EventHandler(this.ctxSolution_Stop_Click);
      this.toolStripMenuItem9.Name = "toolStripMenuItem9";
      this.toolStripMenuItem9.Size = new Size(197, 6);
      this.ctxSolution_Optimize.Name = "ctxSolution_Optimize";
      this.ctxSolution_Optimize.Size = new Size(200, 22);
      this.ctxSolution_Optimize.Text = "Optimize...";
      this.ctxSolution_Optimize.Click += new EventHandler(this.ctxSolution_Optimize_Click);
      this.toolStripMenuItem13.Name = "toolStripMenuItem13";
      this.toolStripMenuItem13.Size = new Size(197, 6);
      this.ctxSolution_Properties.Image = (Image) Resources.preferences;
      this.ctxSolution_Properties.Name = "ctxSolution_Properties";
      this.ctxSolution_Properties.Size = new Size(200, 22);
      this.ctxSolution_Properties.Text = "Properties";
      this.ctxSolution_Properties.Click += new EventHandler(this.ctxSolution_Properties_Click);
      this.ctxScenario.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ctxScenario_Edit
      });
      this.ctxScenario.Name = "ctxCode";
      this.ctxScenario.Size = new Size(95, 26);
      this.ctxScenario_Edit.Name = "ctxScenario_Edit";
      this.ctxScenario_Edit.Size = new Size(94, 22);
      this.ctxScenario_Edit.Text = "Edit";
      this.ctxScenario_Edit.Click += new EventHandler(this.ctxScenario_Edit_Click);
      this.sfdProjectSettings.Filter = "OpenQuant Project Settings|*.oqp|All files|*.*";
      this.sfdProjectSettings.SupportMultiDottedExtensions = true;
      this.ofdProjectSettings.DefaultExt = "*.oqp";
      this.ofdProjectSettings.Filter = "OpenQuant Project Settings|*.oqp";
      this.ofdProjectSettings.SupportMultiDottedExtensions = true;
      this.ctxSolution_ExportToQT.Name = "ctxSolution_ExportToQT";
      this.ctxSolution_ExportToQT.Size = new Size(200, 22);
      this.ctxSolution_ExportToQT.Text = "Export to QuantTrader...";
      this.ctxSolution_ExportToQT.Click += new EventHandler(this.ctxSolution_ExportToQT_Click);
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(197, 6);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.trvStrategy);
      this.set_DefaultDockLocation((ContainerDockLocation) 2);
      ((Control) this).Name = "SolutionExplorerWindow";
      ((DockControl) this).set_TabImage((Image) Resources.solution);
      ((Control) this).Text = "Solution Explorer";
      this.ctxStrategy.ResumeLayout(false);
      this.ctxInstrument.ResumeLayout(false);
      this.ctxRequestList.ResumeLayout(false);
      this.ctxRequest.ResumeLayout(false);
      this.ctxCode.ResumeLayout(false);
      this.ctxInstrumentList.ResumeLayout(false);
      this.ctxMethod.ResumeLayout(false);
      this.ctxSolution.ResumeLayout(false);
      this.ctxScenario.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
    }

    protected virtual void OnInit()
    {
      this.solution = Global.ProjectManager.ActiveSolution;
      if (this.solution != null)
        this.InitGUI();
      Global.ProjectManager.SolutionOpened += new EventHandler(this.Global_SolutionOpened);
      Global.ProjectManager.SolutionClosed += new EventHandler(this.Global_SolutionClosed);
      Global.ProjectManager.ProjectAdded += new EventHandler(this.ProjectManager_ProjectAdded);
      Global.ProjectManager.ProjectRemoved += new EventHandler(this.ProjectManager_ProjectRemoved);
    }

    private void Global_SolutionOpened(object sender, EventArgs args)
    {
      this.solution = Global.ProjectManager.ActiveSolution;
      this.InitGUI();
    }

    private void Global_SolutionClosed(object sender, EventArgs args)
    {
      this.solution = (Solution) null;
      this.Disconnect();
      this.Reset();
    }

    private void ProjectManager_ProjectAdded(object sender, EventArgs e)
    {
      this.AddProject(sender as StrategyProject);
      if (this.solutionNode.Nodes.Count != 1)
        return;
      this.solutionNode.Expand();
    }

    private void ProjectManager_ProjectRemoved(object sender, EventArgs e)
    {
      foreach (TreeNode treeNode in this.trvStrategy.Nodes[0].Nodes)
      {
        if (treeNode is StrategyNode)
        {
          StrategyNode strategyNode = treeNode as StrategyNode;
          if (strategyNode.StrategyProject == sender as StrategyProject)
          {
            strategyNode.Disconnect();
            strategyNode.Remove();
          }
        }
      }
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      this.Disconnect();
      Global.ProjectManager.SolutionOpened -= new EventHandler(this.Global_SolutionOpened);
      Global.ProjectManager.SolutionClosed -= new EventHandler(this.Global_SolutionClosed);
      Global.ProjectManager.ProjectRemoved -= new EventHandler(this.ProjectManager_ProjectRemoved);
      Global.ProjectManager.ProjectAdded -= new EventHandler(this.ProjectManager_ProjectAdded);
    }

    private void Reset()
    {
      this.trvStrategy.Nodes.Clear();
    }

    private void Disconnect()
    {
      if (this.solutionNode == null)
        return;
      this.solutionNode.Disconnect();
      foreach (TreeNode treeNode in this.solutionNode.Nodes)
      {
        if (treeNode is StrategyNode)
          (treeNode as StrategyNode).Disconnect();
      }
    }

    private void InitGUI()
    {
      this.trvStrategy.BeginUpdate();
      this.trvStrategy.Nodes.Clear();
      this.solutionNode = new OpenQuant.Projects.UI.Items.SolutionNode(this.solution.Name, this.solution.SolutionSettings, this.ctxRequest, this.ctxRequestList, this.ctxScenario, this.solution.ScenarioLang);
      this.solutionNode.ContextMenuStrip = this.ctxSolution;
      this.trvStrategy.Nodes.Add((TreeNode) this.solutionNode);
      foreach (StrategyProject project in this.solution.Projects.Values)
        this.AddProject(project);
      this.solutionNode.Expand();
      if (this.solutionNode.Nodes.Count == 1)
        this.solutionNode.Nodes[0].Expand();
      this.trvStrategy.EndUpdate();
    }

    private void AddProject(StrategyProject project)
    {
      StrategyNode strategyNode = new StrategyNode(project, this.ctxInstrumentList, this.ctxCode, this.ctxInstrument);
      strategyNode.ContextMenuStrip = this.ctxStrategy;
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnStrategyStart"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnStrategyStop"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnActiveChanged"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnBarOpen"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnBar"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnBarSlice"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnTrade"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnQuote"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderBookChanged"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnPositionOpened"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnPositionChanged"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnPositionClosed"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnPositionValueChanged"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnStopExecuted"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnNewOrder"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderStatusChanged"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderReplaced"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderRejected"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderCancelled"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderExpired"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderFilled"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderPartiallyFilled"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderReplaceReject"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderCancelReject"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnOrderDone"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnConnected"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnDisconnected"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnError"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnTimer"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnUserCommand"));
      strategyNode.Nodes.Add((TreeNode) this.CreateMethodNode("OnCustomCommand"));
      this.solutionNode.Nodes.Add((TreeNode) strategyNode);
    }

    private void trvStrategy_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left || !(this.nodeToDrag is OpenQuant.Projects.UI.Items.InstrumentNode) && !(this.nodeToDrag is InstrumentListNode) || !(this.dragBoxFromMouseDown != Rectangle.Empty))
        return;
      if (this.dragBoxFromMouseDown.Contains(e.X, e.Y))
        return;
      try
      {
        this.myNormalCursor = Cursors.Arrow;
        this.myNoDropCursor = Cursors.Hand;
      }
      catch
      {
      }
      finally
      {
        this.screenOffset = SystemInformation.WorkingArea.Location;
        SmartQuant.Instruments.InstrumentList instrumentList = new SmartQuant.Instruments.InstrumentList();
        if (this.nodeToDrag is OpenQuant.Projects.UI.Items.InstrumentNode)
          instrumentList.Add((this.nodeToDrag as OpenQuant.Projects.UI.Items.InstrumentNode).Instrument);
        if (this.nodeToDrag is InstrumentListNode)
        {
          foreach (OpenQuant.Projects.UI.Items.InstrumentNode instrumentNode in this.nodeToDrag.Nodes)
            instrumentList.Add(instrumentNode.Instrument);
        }
        int num = (int) this.trvStrategy.DoDragDrop((object) instrumentList, DragDropEffects.Move);
      }
    }

    private void trvStrategy_MouseUp(object sender, MouseEventArgs e)
    {
      this.dragBoxFromMouseDown = Rectangle.Empty;
    }

    private void trvStrategy_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
    {
      if (!(e.Node is OpenQuant.Projects.UI.Items.SolutionNode))
        return;
      e.Cancel = true;
    }

    private void trvStrategy_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      if (!(e.Node is InstrumentListNode) && !(e.Node is RequestListNode))
        return;
      e.Node.ImageIndex = e.Node.SelectedImageIndex = 2;
    }

    private void trvStrategy_AfterExpand(object sender, TreeViewEventArgs e)
    {
      if (!(e.Node is InstrumentListNode) && !(e.Node is RequestListNode))
        return;
      e.Node.ImageIndex = e.Node.SelectedImageIndex = 1;
    }

    private void trvStrategy_DragOver(object sender, DragEventArgs e)
    {
      if (Runner.IsRunning)
        e.Effect = DragDropEffects.None;
      else if (this.GetStrategyNode(this.trvStrategy.GetNodeAt(this.trvStrategy.PointToClient(new Point(e.X, e.Y)))) != null && e.Data.GetDataPresent(typeof (SmartQuant.Instruments.InstrumentList)))
        e.Effect = DragDropEffects.Move;
      else
        e.Effect = DragDropEffects.None;
    }

    private void AddInstrument(StrategySettings strategySettings, Instrument instrument)
    {
      strategySettings.Instruments.Add(instrument);
    }

    private void RemoveInstrument(StrategySettings strategySettings, Instrument instrument)
    {
      strategySettings.Instruments.Remove(instrument);
    }

    private void RemoveRequest(MarketDataRequest request)
    {
      this.solution.SolutionSettings.Requests.Remove(request);
    }

    private void EditCode(StrategyProject project)
    {
      Global.EditorManager.OpenProjectCode(project.CodeFile, this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject);
    }

    private void EditScenario()
    {
      Global.EditorManager.OpenScenarioCode(this.solution.ScenarioFile, this.solution);
    }

    private void RunStrategy()
    {
      if (!this.BuildProject())
        return;
      Global.get_ToolWindowManager().ClearOutput();
      if (!Global.ProjectManager.ActiveSolution.Validate() || !IDEHelper.DoRunStrategy())
        return;
      Runner.Start(Global.ProjectManager.ActiveSolution);
    }

    private void StopStrategy()
    {
      Runner.Stop(true);
    }

    private void OptimizeStrategy()
    {
      if (!this.BuildProject())
        return;
      OptmizationDialog optmizationDialog = new OptmizationDialog();
      if (optmizationDialog.ShowDialog() != DialogResult.OK)
        return;
      Global.get_DockManager().Open(typeof (OptimizationWindow));
      Runner.Start(this.solution, optmizationDialog.StrategyOptimizer);
    }

    private bool BuildProject()
    {
      Global.get_ToolWindowManager().ShowOutput();
      Global.get_ToolWindowManager().ClearOutput();
      Global.get_ToolWindowManager().ClearErrorList();
      Console.WriteLine(string.Format("Building solution {0}...", (object) Global.ProjectManager.ActiveSolution.Name));
      Global.EditorManager.SaveAll();
      BuildErrorCollection buildErrorCollection = Global.ProjectManager.ActiveSolution.Build();
      Global.get_ToolWindowManager().UpdateProperties();
      if (buildErrorCollection.HasErrors)
      {
        Console.WriteLine("Built with errors.");
        Global.get_ToolWindowManager().SetErrors<ErrorListWindow>((Error[]) buildErrorCollection.ToArray());
        Global.get_ToolWindowManager().ShowErrorList<ErrorListWindow>();
        return false;
      }
      else if (buildErrorCollection.HasWarnings)
      {
        Console.WriteLine("Built with warnings.");
        Global.get_ToolWindowManager().SetErrors<ErrorListWindow>((Error[]) buildErrorCollection.ToArray());
        return true;
      }
      else
      {
        Console.WriteLine("Build succeeded.");
        return true;
      }
    }

    private void trvStrategy_DragDrop(object sender, DragEventArgs e)
    {
      StrategyNode strategyNode = this.GetStrategyNode(this.trvStrategy.GetNodeAt(this.trvStrategy.PointToClient(new Point(e.X, e.Y))));
      if (strategyNode == null)
        return;
      StrategyProject strategyProject = strategyNode.StrategyProject;
      if (!e.Data.GetDataPresent(typeof (SmartQuant.Instruments.InstrumentList)))
        return;
      SmartQuant.Instruments.InstrumentList instrumentList = (SmartQuant.Instruments.InstrumentList) e.Data.GetData(typeof (SmartQuant.Instruments.InstrumentList));
      this.trvStrategy.BeginUpdate();
      foreach (Instrument instrument in (FIXGroupList) instrumentList)
      {
        if (!strategyNode.StrategySettings.Instruments.Contains(instrument))
          this.AddInstrument(strategyNode.StrategySettings, instrument);
      }
      strategyNode.InstrumentListNode.EnsureVisible();
      strategyNode.InstrumentListNode.Expand();
      this.trvStrategy.EndUpdate();
      strategyProject.Save();
    }

    private void ctxStrategy_Properties_Click(object sender, EventArgs e)
    {
      Global.get_ToolWindowManager().ShowProperties((IPropertyEditable) this, true);
    }

    private void ctxInstrument_Properties_Click(object sender, EventArgs e)
    {
      Global.get_ToolWindowManager().ShowProperties((IPropertyEditable) this, true);
    }

    private void ctxInstrument_ViewChart_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (BarChart), (object) new KeyValuePair<StrategyProject, Instrument>(this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject, (this.trvStrategy.SelectedNode as OpenQuant.Projects.UI.Items.InstrumentNode).Instrument));
    }

    private void ctxInstrument_Remove_Click(object sender, EventArgs e)
    {
      this.RemoveInstrument(this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategySettings, (this.trvStrategy.SelectedNode as OpenQuant.Projects.UI.Items.InstrumentNode).Instrument);
      this.solution.Save();
    }

    private void trvStrategy_AfterSelect(object sender, TreeViewEventArgs e)
    {
      Global.get_ToolWindowManager().ShowProperties((IPropertyEditable) this, false);
    }

    private void trvStrategy_MouseDown(object sender, MouseEventArgs e)
    {
      TreeNode nodeAt = this.trvStrategy.GetNodeAt(e.X, e.Y);
      if (nodeAt != null)
      {
        if (e.Button == MouseButtons.Right)
          this.trvStrategy.SelectedNode = nodeAt;
        this.nodeToDrag = nodeAt;
        Size dragSize = SystemInformation.DragSize;
        this.dragBoxFromMouseDown = new Rectangle(new Point(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2), dragSize);
      }
      else
        this.dragBoxFromMouseDown = Rectangle.Empty;
    }

    private void ctxStrategy_Opening(object sender, CancelEventArgs e)
    {
      if (this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject.CodeLang == 1)
        this.ctxStrategy_EditCode.Image = (Image) Resources.code_cs;
      else
        this.ctxStrategy_EditCode.Image = (Image) Resources.code_vb;
      this.ctxStrategy_Enabled.Checked = this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject.Enabled;
      if (Runner.IsRunning)
      {
        this.ctxStrategy_Active.Visible = true;
        this.ctxStrategy_Enabled.Visible = false;
        this.ctxStrategy_LoadSettings.Enabled = false;
        this.ctxStrategy_SaveSettings.Enabled = false;
        this.ctxStrategy_Remove.Enabled = false;
      }
      else
      {
        this.ctxStrategy_Active.Visible = false;
        this.ctxStrategy_Enabled.Visible = true;
        this.ctxStrategy_LoadSettings.Enabled = true;
        this.ctxStrategy_SaveSettings.Enabled = true;
        this.ctxStrategy_Remove.Enabled = true;
      }
    }

    private void ctxSolution_Opening(object sender, CancelEventArgs e)
    {
      bool isRunning = Runner.IsRunning;
      this.ctxSolution_Build.Enabled = !isRunning;
      this.ctxSolution_Run.Enabled = !isRunning;
      this.ctxSolution_Stop.Enabled = isRunning;
      this.ctxSolution_Add.Enabled = !isRunning;
      this.ctxSolution_Optimize.Enabled = !isRunning && Configuration.get_ActiveMode() == 0;
      this.ctxSolution_ExportToQT.Enabled = !isRunning;
    }

    private void ctxSolution_Build_Click(object sender, EventArgs e)
    {
      this.BuildProject();
    }

    private void ctxSolution_Run_Click(object sender, EventArgs e)
    {
      this.RunStrategy();
    }

    private void ctxSolution_Stop_Click(object sender, EventArgs e)
    {
      this.StopStrategy();
    }

    private void ctxSolution_Optimize_Click(object sender, EventArgs e)
    {
      this.OptimizeStrategy();
    }

    private void ctxStrategy_EditCode_Click(object sender, EventArgs e)
    {
      this.EditCode(this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject);
    }

    private void trvStrategy_DoubleClick(object sender, EventArgs e)
    {
      StrategyNode strategyNode = this.GetStrategyNode(this.trvStrategy.SelectedNode);
      if (strategyNode != null)
      {
        StrategyProject strategyProject = strategyNode.StrategyProject;
        if (this.trvStrategy.SelectedNode is CodeNode)
          this.EditCode(strategyProject);
        if (!(this.trvStrategy.SelectedNode is MethodNode))
          return;
        this.GotoMethod();
      }
      else
      {
        if (!(this.trvStrategy.SelectedNode is ScenarioNode))
          return;
        this.EditScenario();
      }
    }

    private void ctxStrategy_ViewBarChart_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (BarChart), (object) new KeyValuePair<StrategyProject, Instrument>(this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject, (Instrument) null));
    }

    private void ctxStrategy_ViewPortfolio_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PortfolioWindow), (object) this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject.StrategyRunner.get_Portfolio());
    }

    private void ctxStrategy_ViewMarketScanner_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (MarketScanerWindow), (object) this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject);
    }

    private void ctxStrategy_ViewUserCommands_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (UserCommandsWindow), (object) this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject);
    }

    private void ctxStrategy_ViewResults_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (ResultsWindow), (object) this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject);
    }

    private void ctxStrategy_ViewPerformance_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PerformanceWindow), (object) this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject.StrategyRunner.get_Portfolio());
    }

    private void ctxCode_Edit_Click(object sender, EventArgs e)
    {
      this.EditCode(this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject);
    }

    private void ctxScenario_Edit_Click(object sender, EventArgs e)
    {
      this.EditScenario();
    }

    private void ctxRequestList_Daily_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add(new MarketDataRequest((RequestType) 6));
    }

    private void ctxRequestList_Add_Trade_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add(new MarketDataRequest((RequestType) 0));
    }

    private void ctxRequestList_Add_Quote_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add(new MarketDataRequest((RequestType) 1));
    }

    private void ctxRequestList_Add_MarketDepth_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add(new MarketDataRequest((RequestType) 2));
    }

    private void ctxRequest_Opening(object sender, CancelEventArgs e)
    {
      this.ctxRequest_Enabled.Enabled = this.ctxRequest_IsBarFactoryRequest.Enabled = this.ctxRequest_Remove.Enabled = !Runner.IsRunning;
      MarketDataRequest request = (this.trvStrategy.SelectedNode as RequestNode).Request;
      if (request is BarRequest)
      {
        this.ctxRequest_IsBarFactoryRequest.Visible = true;
        this.ctxRequest_IsBarFactoryRequest.Checked = (request as BarRequest).get_IsBarFactoryRequest();
      }
      else
        this.ctxRequest_IsBarFactoryRequest.Visible = false;
      this.ctxRequest_Enabled.Checked = request.get_Enabled();
      this.ctxRequest_IsBarFactoryRequest.Text = "Build Bars from " + (object) this.solution.SolutionSettings.BarFactoryInput + "s";
    }

    private void ctxRequest_IsBarFactoryRequest_Click(object sender, EventArgs e)
    {
      ((this.trvStrategy.SelectedNode as RequestNode).Request as BarRequest).set_IsBarFactoryRequest(this.ctxRequest_IsBarFactoryRequest.Checked);
    }

    private void ctxRequest_Enabled_CheckedChanged(object sender, EventArgs e)
    {
      (this.trvStrategy.SelectedNode as RequestNode).Request.set_Enabled(this.ctxRequest_Enabled.Checked);
    }

    private void ctxRequest_Remove_Click(object sender, EventArgs e)
    {
      this.RemoveRequest((this.trvStrategy.SelectedNode as RequestNode).Request);
    }

    private void ctxRequestList_Add_Bar_10Second_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 10L));
    }

    private void ctxRequestList_Add_Bar_20Second_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 20L));
    }

    private void ctxRequestList_Add_Bar_30Second_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 30L));
    }

    private void ctxRequestList_Add_Bar_1Minute_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 60L));
    }

    private void ctxRequestList_Add_Bar_5Minute_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 300L));
    }

    private void ctxRequestList_Add_Bar_10Minute_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 600L));
    }

    private void ctxRequestList_Add_Bar_15Minute_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 900L));
    }

    private void ctxRequestList_Add_Bar_30Minute_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 1800L));
    }

    private void ctxRequestList_Add_Bar_1Hour_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 3600L));
    }

    private void ctxRequestList_Add_Bar_2Hour_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 7200L));
    }

    private void ctxRequestList_Add_Bar_6Hour_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 21600L));
    }

    private void ctxRequestList_Add_Bar_12Hour_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) new BarRequest(BarType.Time, 43200L));
    }

    private void ctxRequestList_Add_Bar_Custom_Click(object sender, EventArgs e)
    {
      BarRequstPropertiesDialog propertiesDialog = new BarRequstPropertiesDialog();
      if (propertiesDialog.ShowDialog() != DialogResult.OK)
        return;
      BarRequest barRequest = new BarRequest(propertiesDialog.BarType, propertiesDialog.BarSize);
      barRequest.set_IsBarFactoryRequest(propertiesDialog.IsBarFactoryRequest);
      this.solution.SolutionSettings.Requests.Add((MarketDataRequest) barRequest);
    }

    private void trvStrategy_KeyDown(object sender, KeyEventArgs e)
    {
      StrategyNode strategyNode = this.GetStrategyNode(this.trvStrategy.SelectedNode);
      if (strategyNode == null)
        return;
      StrategySettings strategySettings = strategyNode.StrategySettings;
      if (e.KeyData != Keys.Delete)
        return;
      if (this.trvStrategy.SelectedNode is OpenQuant.Projects.UI.Items.InstrumentNode)
        this.RemoveInstrument(strategySettings, (this.trvStrategy.SelectedNode as OpenQuant.Projects.UI.Items.InstrumentNode).Instrument);
      if (!(this.trvStrategy.SelectedNode is RequestNode))
        return;
      this.RemoveRequest((this.trvStrategy.SelectedNode as RequestNode).Request);
    }

    private void ctxRequestList_Clear_Click(object sender, EventArgs e)
    {
      this.solution.SolutionSettings.Requests.Clear();
    }

    private void ctxInstrumentList_AddRemove_Click(object sender, EventArgs e)
    {
      StrategySettings strategySettings = this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategySettings;
      InstrumentSelectorDialog instrumentSelectorDialog = new InstrumentSelectorDialog();
      instrumentSelectorDialog.set_Instruments((Instrument[]) InstrumentManager.Instruments);
      instrumentSelectorDialog.set_SelectedInstruments(strategySettings.Instruments.ToArray());
      if (((Form) instrumentSelectorDialog).ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        this.trvStrategy.BeginUpdate();
        strategySettings.Instruments.Clear();
        foreach (Instrument instrument in instrumentSelectorDialog.get_SelectedInstruments())
          strategySettings.Instruments.Add(instrument);
        this.trvStrategy.EndUpdate();
      }
      ((Component) instrumentSelectorDialog).Dispose();
    }

    private void ctxInstrumentList_Clear_Click(object sender, EventArgs e)
    {
      this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategySettings.Instruments.Clear();
    }

    private void ctxMethod_Goto_Click(object sender, EventArgs e)
    {
      this.GotoMethod();
    }

    private MethodNode CreateMethodNode(string methodName)
    {
      MethodNode methodNode = new MethodNode(methodName);
      methodNode.ContextMenuStrip = this.ctxMethod;
      return methodNode;
    }

    private void GotoMethod()
    {
      string methodName = (this.trvStrategy.SelectedNode as MethodNode).MethodName;
      StrategyProject strategyProject = this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject;
      Global.EditorManager.MoveTo(strategyProject, strategyProject.CodeFile.FullName, methodName, this.CreateMethodDefinition(methodName, strategyProject.CodeLang));
    }

    private string[] CreateMethodDefinition(string methodName, CodeLang codeLang)
    {
      MethodInfo method = typeof (Strategy).GetMethod(methodName);
      List<string> list1 = new List<string>();
      foreach (ParameterInfo parameterInfo in method.GetParameters())
      {
        string str = this.ConverParameterType(parameterInfo.ParameterType.Name);
        switch (codeLang - 1)
        {
          case 0:
            list1.Add(string.Format("{0} {1}", (object) str, (object) parameterInfo.Name));
            break;
          case 1:
            list1.Add(string.Format("ByVal {1} as {0}", (object) str, (object) parameterInfo.Name));
            break;
          default:
            throw new ArgumentException(string.Format("Unknown code language - {0}", (object) codeLang));
        }
      }
      List<string> list2 = new List<string>();
      switch (codeLang - 1)
      {
        case 0:
          list2.Add(string.Format("public override void {0}({1})", (object) method.Name, (object) string.Join(", ", list1.ToArray())));
          list2.Add("{");
          list2.Add("\t");
          list2.Add("}");
          break;
        case 1:
          list2.Add(string.Format("Public Overrides Sub {0}({1})", (object) method.Name, (object) string.Join(",", list1.ToArray())));
          list2.Add("\t");
          list2.Add("End Sub");
          break;
        default:
          throw new ArgumentException(string.Format("Unknown code language - {0}", (object) codeLang));
      }
      return list2.ToArray();
    }

    private string ConverParameterType(string parameterType)
    {
      switch (parameterType)
      {
        case "Int64":
          return "long";
        default:
          return parameterType;
      }
    }

    private void ctxInstrument_Opening(object sender, CancelEventArgs e)
    {
      this.ctxInstrument_Remove.Enabled = !Runner.IsRunning;
    }

    private void ctxRequestList_Opening(object sender, CancelEventArgs e)
    {
      this.ctxRequestList_Add.Enabled = this.ctxRequestList_Clear.Enabled = !Runner.IsRunning;
    }

    private void ctxInstrumentList_Opening(object sender, CancelEventArgs e)
    {
      this.ctxInstrumentList_AddRemove.Enabled = this.ctxInstrumentList_Clear.Enabled = !Runner.IsRunning;
    }

    private StrategyNode GetStrategyNode(TreeNode node)
    {
      for (; !(node is StrategyNode); node = node.Parent)
      {
        if (node == null)
          return (StrategyNode) null;
      }
      return node as StrategyNode;
    }

    private void ctxSolution_EditScenario_Click(object sender, EventArgs e)
    {
      this.EditScenario();
    }

    private void ctxSolution_Add_NewProject_Click(object sender, EventArgs e)
    {
      NewProjectDialog newProjectDialog = new NewProjectDialog(this.solution.Name);
      if (newProjectDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
        Global.ProjectManager.AddNewProject(newProjectDialog.ProjectFile, newProjectDialog.CodeLang, newProjectDialog.ProjectName, newProjectDialog.ProjectDescription);
      newProjectDialog.Dispose();
    }

    private void ctxSolution_Add_ExistingProject_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Multiselect = false;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = "OpenQuant projects|*.oqp";
      openFileDialog.InitialDirectory = Global.Setup.Folders.Projects.FullName;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
        Global.ProjectManager.AddExistingProject(new FileInfo(openFileDialog.FileName));
      openFileDialog.Dispose();
    }

    private void ctxSolution_ViewBarChart_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (BarChart), (object) new KeyValuePair<StrategyProject, Instrument>((StrategyProject) null, (Instrument) null));
    }

    private void ctxSolution_ViewPortfolio_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PortfolioWindow), (object) this.solution.SolutionRunner.get_Portfolio());
    }

    private void ctxSolution_ViewPerformance_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PerformanceWindow), (object) this.solution.SolutionRunner.get_Portfolio());
    }

    private void ctxSolution_ViewResults_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (ResultsWindow), (object) Global.ProjectManager.ActiveSolution);
    }

    private void ctxSolution_ViewMarketScanner_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (MarketScanerWindow), (object) this.solution);
    }

    private void ctxSolution_ViewUserCommands_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (UserCommandsWindow));
    }

    private void ctxSolution_ManageReferences_Click(object sender, EventArgs e)
    {
      OptionsForm optionsForm = new OptionsForm();
      optionsForm.SetSelectedOptionsType(typeof (BuildOptions));
      int num = (int) ((Form) optionsForm).ShowDialog((IWin32Window) this);
      ((Component) optionsForm).Dispose();
    }

    private void ctxSolution_ExportToQT_Click(object sender, EventArgs e)
    {
      ExportToQuantTraderForm toQuantTraderForm = new ExportToQuantTraderForm();
      toQuantTraderForm.Init(Global.ProjectManager.ActiveSolution);
      int num = (int) toQuantTraderForm.ShowDialog((IWin32Window) this);
      toQuantTraderForm.Dispose();
    }

    private void ctxSolution_Properties_Click(object sender, EventArgs e)
    {
      Global.get_ToolWindowManager().ShowProperties((IPropertyEditable) this, true);
    }

    private void ctxStrategy_Enabled_Click(object sender, EventArgs e)
    {
      StrategyNode strategyNode = this.GetStrategyNode(this.trvStrategy.SelectedNode);
      strategyNode.StrategyProject.Enabled = this.ctxStrategy_Enabled.Checked;
      strategyNode.UpdateImage();
      this.solution.Save();
    }

    private void ctxStrategy_Active_Click(object sender, EventArgs e)
    {
      this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject.StrategyRunner.set_Active(this.ctxStrategy_Active.Checked);
    }

    private void ctxStrategy_Remove_Click(object sender, EventArgs e)
    {
      Global.ProjectManager.Remove(this.GetStrategyNode(this.trvStrategy.SelectedNode).StrategyProject);
    }

    private void ctxStrategy_SaveSettings_Click(object sender, EventArgs e)
    {
      StrategyNode strategyNode = this.GetStrategyNode(this.trvStrategy.SelectedNode);
      string path = (string) (object) strategyNode.StrategyProject.ProjectFile.Directory + (object) "\\data";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      this.sfdProjectSettings.InitialDirectory = path;
      if (this.sfdProjectSettings.ShowDialog() != DialogResult.OK)
        return;
      strategyNode.StrategyProject.Save();
      File.Copy(strategyNode.StrategyProject.ProjectFile.FullName, this.sfdProjectSettings.FileName);
    }

    private void ctxStrategy_LoadSettings_Click(object sender, EventArgs e)
    {
      StrategyNode strategyNode = this.GetStrategyNode(this.trvStrategy.SelectedNode);
      string path = (string) (object) strategyNode.StrategyProject.ProjectFile.Directory + (object) "\\data";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      this.ofdProjectSettings.InitialDirectory = path;
      if (this.ofdProjectSettings.ShowDialog() != DialogResult.OK)
        return;
      strategyNode.StrategyProject.Save();
      try
      {
        strategyNode.StrategyProject.LoadSettingsFrom(new FileInfo(this.ofdProjectSettings.FileName));
        strategyNode.StrategyProject.Save();
        Global.get_ToolWindowManager().ShowProperties((IPropertyEditable) this, false);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "An Error Occured While Loading Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        strategyNode.StrategyProject.LoadSettingsFrom(strategyNode.StrategyProject.ProjectFile);
      }
    }
  }
}
