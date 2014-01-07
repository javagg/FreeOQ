// Type: OpenQuant.IDE
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.API;
using OpenQuant.BrokerInfo;
using OpenQuant.Config;
using OpenQuant.Flags;
using OpenQuant.Indicators;
using OpenQuant.Instruments;
using OpenQuant.Options;
using OpenQuant.Orders;
using OpenQuant.Portfolios;
using OpenQuant.Projects;
using OpenQuant.Projects.UI;
using OpenQuant.Properties;
using OpenQuant.QuantBase;
using OpenQuant.QuantTrader;
using OpenQuant.Scripts;
using OpenQuant.Shared;
using OpenQuant.Shared.Charting;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Data.Bars;
using OpenQuant.Shared.Data.Import.CSV;
using OpenQuant.Shared.Data.Import.Historical;
using OpenQuant.Shared.Data.Import.Instruments;
using OpenQuant.Shared.Data.Import.NxCore;
using OpenQuant.Shared.Data.Import.Realtime;
using OpenQuant.Shared.Data.Import.TAQ;
using OpenQuant.Shared.Data.Management;
using OpenQuant.Shared.Diagnostics;
using OpenQuant.Shared.Editor;
using OpenQuant.Shared.Instruments;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.Plugins;
using OpenQuant.Shared.Providers;
using OpenQuant.Shared.Scripts;
using OpenQuant.Shared.ToolWindows;
using OpenQuant.Shared.Updates;
using OpenQuant.Startup;
using OpenQuant.TradingTools;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.Docking.WinForms;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using SmartQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using TD.SandDock;

namespace OpenQuant
{
  internal class IDE : Form, ITimerItem
  {
    private IContainer components;
    private MenuStrip menuStrip;
    private ToolStripMenuItem menuFile;
    private ToolStripMenuItem menuHelp;
    private ToolStrip tstSolution;
    private StatusStrip statusStrip;
    private Panel panel;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripStatusLabel toolStripStatusLabel2;
    private ToolStripStatusLabel toolStripStatusLabel3;
    private ToolStripMenuItem menuHelp_About;
    private ToolStripMenuItem menuFile_Exit;
    private ToolStripMenuItem menuView;
    private ToolStripMenuItem menuView_Instruments;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem menuView_Properties;
    private ToolStripMenuItem menuTools;
    private ToolStripMenuItem menuView_Output;
    private ToolStripMenuItem menuView_Indicators;
    private ToolStripMenuItem menuView_SolutionExplorer;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem menuView_QuoteMonitor;
    private ToolStripMenuItem menuTools_Options;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem menuView_Providers;
    private ToolStripMenuItem menuView_ProviderErrors;
    private ToolStripMenuItem menuView_Portfolio;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem menuView_OrderManager;
    private ToolStripMenuItem menuFile_New;
    private ToolStripSeparator toolStripMenuItem2;
    private ToolStripMenuItem menuFile_Open;
    private ToolStripMenuItem menuHelp_GettingStarted;
    private ToolStripMenuItem menuHelp_API;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripProgressBar toolStripProgressBar1;
    private ToolStripPanel tspTop;
    private ToolStripPanel tspRight;
    private ToolStripPanel tspLeft;
    private ToolStripPanel tspBottom;
    private ToolStripButton tsbSolution_Build;
    private ToolStripButton tsbSolution_Run;
    private ToolStripButton tsbSolution_Stop;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripButton tsbSolution_Pause;
    private ToolStrip tstFile;
    private ToolStrip tstEdit;
    private ToolStripButton tsbEdit_Save;
    private ToolStripSeparator toolStripSeparator9;
    private ToolStripButton tsbEdit_Cut;
    private ToolStripButton tsbEdit_Copy;
    private ToolStripButton tsbEdit_Paste;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripButton tsbEdit_Undo;
    private ToolStripButton tsbEdit_Redo;
    private ToolStripMenuItem menuEdit;
    private ToolStripMenuItem menuEdit_Undo;
    private ToolStripMenuItem menuEdit_Redo;
    private ToolStripSeparator toolStripSeparator11;
    private ToolStripMenuItem menuEdit_Cut;
    private ToolStripMenuItem menuEdit_Copy;
    private ToolStripMenuItem menuEdit_Paste;
    private ToolStripMenuItem menuSolution;
    private ToolStripMenuItem menuSolution_Build;
    private ToolStripSeparator toolStripSeparator12;
    private ToolStripMenuItem menuSolution_Run;
    private ToolStripMenuItem menuSolution_Pause;
    private ToolStripMenuItem menuSolution_Stop;
    private ToolStrip tstView;
    private ToolStripButton tsbView_Instruments;
    private ToolStripButton tsbView_Indicators;
    private ToolStripSeparator toolStripSeparator13;
    private ToolStripButton tsbView_OrderManager;
    private ToolStripButton tsbView_Portfolio;
    private ToolStripSeparator toolStripSeparator14;
    private ToolStripButton tsbView_Providers;
    private ToolStripButton tsbView_ProviderErrors;
    private ToolStripSeparator toolStripSeparator15;
    private ToolStripButton tsbView_SolutionExplorer;
    private ToolStripSeparator toolStripSeparator16;
    private ToolStripButton tsbView_QuoteMonitor;
    private ToolStripSeparator toolStripSeparator17;
    private ToolStripButton tsbView_Output;
    private ToolStripButton tsbView_Properties;
    private ChartToolStrip tstChart;
    private ToolStripMenuItem menuFile_CloseProject;
    private ToolStripMenuItem menuFile_RecentProjects;
    private ToolStripSeparator toolStripSeparator18;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem menuView_Toolbars;
    private ToolStripMenuItem toolStripMenuItem4;
    private ToolStripSeparator toolStripSeparator19;
    private ToolStripMenuItem menuFile_Save;
    private ToolStripSeparator toolStripSeparator20;
    private ToolStripSeparator toolStripSeparator21;
    private ToolStripSeparator toolStripSeparator22;
    private ToolStripButton tsbSolution_UpdateUI;
    private ToolStripSeparator toolStripSeparator23;
    private ToolStripMenuItem menuSolution_UpdateUI;
    private ToolStrip tstMode;
    private ToolStripDropDownButton tsbMode;
    private ToolStripMenuItem tsbMode_Simulation;
    private ToolStripMenuItem tsbMode_Paper;
    private ToolStripMenuItem tsbMode_Live;
    private ToolStripMenuItem menuSolution_ViewResults;
    private ToolStripMenuItem menuSolution_ViewPerformance;
    private ToolStripSeparator toolStripSeparator26;
    private ToolStripMenuItem menuData;
    private ToolStripMenuItem menuData_Import;
    private ToolStripMenuItem menuData_Import_CSV;
    private ToolStripMenuItem menuData_Import_TAQ;
    private ToolStripMenuItem menuSolution_ViewBarChart;
    private ToolStripMenuItem menuWindow;
    private ToolStripMenuItem menuWindow_CloseAllDocuments;
    private ToolStripSeparator toolStripSeparator27;
    private InstrumentListToolStrip tstInstrumentList;
    private ToolStripMenuItem menuView_Other;
    private ToolStripMenuItem menuView_Other_StartPage;
    private ToolStripSeparator toolStripSeparator28;
    private ToolStrip tstSolutionView;
    private ToolStripButton tsbSolutionView_BarChart;
    private ToolStripButton tsbSolutionView_Results;
    private ToolStripButton tsbSolutionView_Performance;
    private ToolStripMenuItem menuHelp_StrategyDevelopment;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem menuData_Import_Instruments;
    private ToolStripMenuItem menuTools_ChartColorManager;
    private ToolStripSeparator toolStripMenuItem5;
    private ToolStripMenuItem menuData_Import_Realtime;
    private ToolStripMenuItem emptyToolStripMenuItem;
    private ToolStripMenuItem emptyToolStripMenuItem1;
    private ToolStripMenuItem menuData_Import_Historical;
    private ToolStripMenuItem toolStripMenuItem6;
    private ToolStripMenuItem menuSolution_ViewMarketScanner;
    private ToolStripButton tsbSolutionView_MarketScanner;
    private ToolStripStatusLabel tsiMode;
    private ToolStripSeparator toolStripSeparator30;
    private ToolStripMenuItem menuData_CompressBars;
    private ToolStripMenuItem menuView_ScriptExplorer;
    private ToolStripButton tsbView_ScriptExplorer;
    private ToolStripMenuItem menuFile_NewSolution;
    private ToolStripSeparator toolStripMenuItem7;
    private ToolStripMenuItem menuFile_NewProject;
    private ToolStripMenuItem menuFile_OpenSolution;
    private ToolStripSeparator toolStripMenuItem8;
    private ToolStripMenuItem menuFile_OpenProject;
    private ToolStripDropDownButton tsbFile_New;
    private ToolStripMenuItem tsbFile_New_Solution;
    private ToolStripSeparator toolStripMenuItem9;
    private ToolStripMenuItem tsbFile_New_Project;
    private ToolStripDropDownButton tsbFile_Open;
    private ToolStripMenuItem tsbFile_Open_Solution;
    private ToolStripSeparator toolStripMenuItem10;
    private ToolStripMenuItem tsbFile_Open_Project;
    private ToolStripMenuItem menuData_Manager;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem menuView_BrokerInfo;
    private ToolStripButton tsbView_BrokerInfo;
    private ToolStripMenuItem menuSolution_Optimize;
    private ToolStripSeparator toolStripMenuItem11;
    private ToolStripMenuItem menuSolution_ManageReferences;
    private ToolStripSeparator toolStripSeparator24;
    private ToolStripMenuItem menuEdit_Find;
    private ToolStripMenuItem menuEdit_Replace;
    private ToolStripMenuItem menuEdit_Goto;
    private ToolStripMenuItem menuTools_PerformanceMonitor;
    private ToolStripSeparator toolStripSeparator25;
    private NotifyIcon ntiUpdates;
    private ToolStripMenuItem menuHelp_FAQ;
    private ToolStripMenuItem menuData_QuantBaseExplorer;
    private ToolStripSeparator toolStripSeparator29;
    private ToolStripMenuItem menuSolution_ViewStrategyLogs;
    private ToolStripButton tsbSolutionView_StrategyLogs;
    private ToolStripMenuItem menuData_Import_NxCore;
    private ToolStripMenuItem menuSolution_ExportToQT;
    private ToolStripSeparator toolStripSeparator31;
    private ToolStripMenuItem menuHelp_CheckForUpdates;
    private ToolStripSeparator toolStripSeparator32;

    public double Interval
    {
      get
      {
        return 1000.0;
      }
    }

    public ISynchronizeInvoke SynchronizingObject
    {
      get
      {
        return (ISynchronizeInvoke) this;
      }
    }

    public IDE()
    {
      this.InitializeComponent();
      this.menuView_Toolbars.DropDown.Closing += new ToolStripDropDownClosingEventHandler(this.menuView_Toolbars_DropDown_Closing);
      Global.MainForm = (Form) this;
      Global.set_DockManager(new DockManager((Control) this.panel, (Form) this));
      Global.Options = new OpenQuantOptions();
      Global.ProjectManager = new ProjectManager();
      Global.EditorManager = new EditorManager();
      Global.set_ToolWindowManager(new ToolWindowManager(Global.get_DockManager()));
      Global.Toolbar = new ToolbarManager();
      Global.Flags = new IDEFlags();
      Global.set_PluginManager(new PluginManager(new FileInfo(string.Format("{0}\\plugins.xml", (object) Global.Setup.Folders.Ini.FullName))));
      Global.ScriptManager = new ScriptManager();
      Global.set_ProviderHelper(new ProviderHelper((Form) this, true));
      Global.set_TimerManager(new TimerManager());
      Global.set_ChartManager(new ChartManager(Global.Setup.Folders.ChartColorTemplates));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (IDE));
      this.menuStrip = new MenuStrip();
      this.menuFile = new ToolStripMenuItem();
      this.menuFile_New = new ToolStripMenuItem();
      this.menuFile_NewSolution = new ToolStripMenuItem();
      this.toolStripMenuItem7 = new ToolStripSeparator();
      this.menuFile_NewProject = new ToolStripMenuItem();
      this.menuFile_Open = new ToolStripMenuItem();
      this.menuFile_OpenSolution = new ToolStripMenuItem();
      this.toolStripMenuItem8 = new ToolStripSeparator();
      this.menuFile_OpenProject = new ToolStripMenuItem();
      this.toolStripSeparator21 = new ToolStripSeparator();
      this.menuFile_CloseProject = new ToolStripMenuItem();
      this.toolStripMenuItem2 = new ToolStripSeparator();
      this.menuFile_Save = new ToolStripMenuItem();
      this.toolStripSeparator20 = new ToolStripSeparator();
      this.menuFile_RecentProjects = new ToolStripMenuItem();
      this.toolStripMenuItem3 = new ToolStripMenuItem();
      this.toolStripSeparator18 = new ToolStripSeparator();
      this.menuFile_Exit = new ToolStripMenuItem();
      this.menuEdit = new ToolStripMenuItem();
      this.menuEdit_Undo = new ToolStripMenuItem();
      this.menuEdit_Redo = new ToolStripMenuItem();
      this.toolStripSeparator11 = new ToolStripSeparator();
      this.menuEdit_Cut = new ToolStripMenuItem();
      this.menuEdit_Copy = new ToolStripMenuItem();
      this.menuEdit_Paste = new ToolStripMenuItem();
      this.toolStripSeparator24 = new ToolStripSeparator();
      this.menuEdit_Find = new ToolStripMenuItem();
      this.menuEdit_Replace = new ToolStripMenuItem();
      this.menuEdit_Goto = new ToolStripMenuItem();
      this.menuView = new ToolStripMenuItem();
      this.menuView_Instruments = new ToolStripMenuItem();
      this.menuView_Indicators = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.menuView_OrderManager = new ToolStripMenuItem();
      this.menuView_Portfolio = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.menuView_Providers = new ToolStripMenuItem();
      this.menuView_ProviderErrors = new ToolStripMenuItem();
      this.menuView_BrokerInfo = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.menuView_SolutionExplorer = new ToolStripMenuItem();
      this.menuView_ScriptExplorer = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripSeparator();
      this.menuView_QuoteMonitor = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.menuView_Other = new ToolStripMenuItem();
      this.menuView_Other_StartPage = new ToolStripMenuItem();
      this.toolStripSeparator28 = new ToolStripSeparator();
      this.menuView_Toolbars = new ToolStripMenuItem();
      this.toolStripMenuItem4 = new ToolStripMenuItem();
      this.toolStripSeparator19 = new ToolStripSeparator();
      this.menuView_Output = new ToolStripMenuItem();
      this.menuView_Properties = new ToolStripMenuItem();
      this.menuSolution = new ToolStripMenuItem();
      this.menuSolution_ManageReferences = new ToolStripMenuItem();
      this.menuSolution_Build = new ToolStripMenuItem();
      this.toolStripSeparator12 = new ToolStripSeparator();
      this.menuSolution_Run = new ToolStripMenuItem();
      this.menuSolution_Pause = new ToolStripMenuItem();
      this.menuSolution_Stop = new ToolStripMenuItem();
      this.toolStripSeparator23 = new ToolStripSeparator();
      this.menuSolution_Optimize = new ToolStripMenuItem();
      this.toolStripMenuItem11 = new ToolStripSeparator();
      this.menuSolution_ExportToQT = new ToolStripMenuItem();
      this.toolStripSeparator31 = new ToolStripSeparator();
      this.menuSolution_UpdateUI = new ToolStripMenuItem();
      this.toolStripSeparator26 = new ToolStripSeparator();
      this.menuSolution_ViewBarChart = new ToolStripMenuItem();
      this.menuSolution_ViewResults = new ToolStripMenuItem();
      this.menuSolution_ViewPerformance = new ToolStripMenuItem();
      this.menuSolution_ViewMarketScanner = new ToolStripMenuItem();
      this.menuSolution_ViewStrategyLogs = new ToolStripMenuItem();
      this.menuData = new ToolStripMenuItem();
      this.menuData_Manager = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.menuData_QuantBaseExplorer = new ToolStripMenuItem();
      this.toolStripSeparator29 = new ToolStripSeparator();
      this.menuData_Import = new ToolStripMenuItem();
      this.menuData_Import_CSV = new ToolStripMenuItem();
      this.menuData_Import_TAQ = new ToolStripMenuItem();
      this.menuData_Import_NxCore = new ToolStripMenuItem();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.menuData_Import_Instruments = new ToolStripMenuItem();
      this.emptyToolStripMenuItem = new ToolStripMenuItem();
      this.menuData_Import_Realtime = new ToolStripMenuItem();
      this.emptyToolStripMenuItem1 = new ToolStripMenuItem();
      this.menuData_Import_Historical = new ToolStripMenuItem();
      this.toolStripMenuItem6 = new ToolStripMenuItem();
      this.toolStripSeparator30 = new ToolStripSeparator();
      this.menuData_CompressBars = new ToolStripMenuItem();
      this.menuTools = new ToolStripMenuItem();
      this.menuTools_ChartColorManager = new ToolStripMenuItem();
      this.toolStripMenuItem5 = new ToolStripSeparator();
      this.menuTools_PerformanceMonitor = new ToolStripMenuItem();
      this.toolStripSeparator25 = new ToolStripSeparator();
      this.menuTools_Options = new ToolStripMenuItem();
      this.menuWindow = new ToolStripMenuItem();
      this.menuWindow_CloseAllDocuments = new ToolStripMenuItem();
      this.toolStripSeparator27 = new ToolStripSeparator();
      this.menuHelp = new ToolStripMenuItem();
      this.menuHelp_GettingStarted = new ToolStripMenuItem();
      this.menuHelp_StrategyDevelopment = new ToolStripMenuItem();
      this.menuHelp_API = new ToolStripMenuItem();
      this.menuHelp_FAQ = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.menuHelp_About = new ToolStripMenuItem();
      this.tstSolution = new ToolStrip();
      this.tsbSolution_Build = new ToolStripButton();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.tsbSolution_Run = new ToolStripButton();
      this.tsbSolution_Pause = new ToolStripButton();
      this.tsbSolution_Stop = new ToolStripButton();
      this.toolStripSeparator22 = new ToolStripSeparator();
      this.tsbSolution_UpdateUI = new ToolStripButton();
      this.statusStrip = new StatusStrip();
      this.toolStripStatusLabel1 = new ToolStripStatusLabel();
      this.tsiMode = new ToolStripStatusLabel();
      this.toolStripProgressBar1 = new ToolStripProgressBar();
      this.toolStripStatusLabel2 = new ToolStripStatusLabel();
      this.toolStripStatusLabel3 = new ToolStripStatusLabel();
      this.panel = new Panel();
      this.tspTop = new ToolStripPanel();
      this.tstFile = new ToolStrip();
      this.tsbFile_New = new ToolStripDropDownButton();
      this.tsbFile_New_Solution = new ToolStripMenuItem();
      this.toolStripMenuItem9 = new ToolStripSeparator();
      this.tsbFile_New_Project = new ToolStripMenuItem();
      this.tsbFile_Open = new ToolStripDropDownButton();
      this.tsbFile_Open_Solution = new ToolStripMenuItem();
      this.toolStripMenuItem10 = new ToolStripSeparator();
      this.tsbFile_Open_Project = new ToolStripMenuItem();
      this.tstEdit = new ToolStrip();
      this.tsbEdit_Save = new ToolStripButton();
      this.toolStripSeparator9 = new ToolStripSeparator();
      this.tsbEdit_Cut = new ToolStripButton();
      this.tsbEdit_Copy = new ToolStripButton();
      this.tsbEdit_Paste = new ToolStripButton();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.tsbEdit_Undo = new ToolStripButton();
      this.tsbEdit_Redo = new ToolStripButton();
      this.tstView = new ToolStrip();
      this.tsbView_Instruments = new ToolStripButton();
      this.tsbView_Indicators = new ToolStripButton();
      this.toolStripSeparator13 = new ToolStripSeparator();
      this.tsbView_OrderManager = new ToolStripButton();
      this.tsbView_Portfolio = new ToolStripButton();
      this.tsbView_BrokerInfo = new ToolStripButton();
      this.toolStripSeparator14 = new ToolStripSeparator();
      this.tsbView_Providers = new ToolStripButton();
      this.tsbView_ProviderErrors = new ToolStripButton();
      this.toolStripSeparator15 = new ToolStripSeparator();
      this.tsbView_SolutionExplorer = new ToolStripButton();
      this.tsbView_ScriptExplorer = new ToolStripButton();
      this.toolStripSeparator16 = new ToolStripSeparator();
      this.tsbView_QuoteMonitor = new ToolStripButton();
      this.toolStripSeparator17 = new ToolStripSeparator();
      this.tsbView_Output = new ToolStripButton();
      this.tsbView_Properties = new ToolStripButton();
      this.tspRight = new ToolStripPanel();
      this.tspLeft = new ToolStripPanel();
      this.tspBottom = new ToolStripPanel();
      this.tstMode = new ToolStrip();
      this.tsbMode = new ToolStripDropDownButton();
      this.tsbMode_Simulation = new ToolStripMenuItem();
      this.tsbMode_Paper = new ToolStripMenuItem();
      this.tsbMode_Live = new ToolStripMenuItem();
      this.tstSolutionView = new ToolStrip();
      this.tsbSolutionView_BarChart = new ToolStripButton();
      this.tsbSolutionView_Results = new ToolStripButton();
      this.tsbSolutionView_Performance = new ToolStripButton();
      this.tsbSolutionView_MarketScanner = new ToolStripButton();
      this.tsbSolutionView_StrategyLogs = new ToolStripButton();
      this.ntiUpdates = new NotifyIcon(this.components);
      this.tstInstrumentList = new InstrumentListToolStrip();
      this.tstChart = new ChartToolStrip();
      this.menuHelp_CheckForUpdates = new ToolStripMenuItem();
      this.toolStripSeparator32 = new ToolStripSeparator();
      this.menuStrip.SuspendLayout();
      this.tstSolution.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.tstFile.SuspendLayout();
      this.tstEdit.SuspendLayout();
      this.tstView.SuspendLayout();
      this.tstMode.SuspendLayout();
      this.tstSolutionView.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.menuFile,
        (ToolStripItem) this.menuEdit,
        (ToolStripItem) this.menuView,
        (ToolStripItem) this.menuSolution,
        (ToolStripItem) this.menuData,
        (ToolStripItem) this.menuTools,
        (ToolStripItem) this.menuWindow,
        (ToolStripItem) this.menuHelp
      });
      this.menuStrip.Location = new Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new Size(595, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      this.menuFile.DropDownItems.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.menuFile_New,
        (ToolStripItem) this.menuFile_Open,
        (ToolStripItem) this.toolStripSeparator21,
        (ToolStripItem) this.menuFile_CloseProject,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.menuFile_Save,
        (ToolStripItem) this.toolStripSeparator20,
        (ToolStripItem) this.menuFile_RecentProjects,
        (ToolStripItem) this.toolStripSeparator18,
        (ToolStripItem) this.menuFile_Exit
      });
      this.menuFile.Name = "menuFile";
      this.menuFile.Size = new Size(37, 20);
      this.menuFile.Text = "&File";
      this.menuFile_New.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.menuFile_NewSolution,
        (ToolStripItem) this.toolStripMenuItem7,
        (ToolStripItem) this.menuFile_NewProject
      });
      this.menuFile_New.Name = "menuFile_New";
      this.menuFile_New.ShortcutKeys = Keys.N | Keys.Control;
      this.menuFile_New.Size = new Size(150, 22);
      this.menuFile_New.Text = "New";
      this.menuFile_NewSolution.Image = (Image) Resources.solution;
      this.menuFile_NewSolution.Name = "menuFile_NewSolution";
      this.menuFile_NewSolution.Size = new Size((int) sbyte.MaxValue, 22);
      this.menuFile_NewSolution.Text = "Solution...";
      this.menuFile_NewSolution.Click += new EventHandler(this.menuFile_NewSolution_Click);
      this.toolStripMenuItem7.Name = "toolStripMenuItem7";
      this.toolStripMenuItem7.Size = new Size(124, 6);
      this.menuFile_NewProject.Image = (Image) Resources.openquant;
      this.menuFile_NewProject.Name = "menuFile_NewProject";
      this.menuFile_NewProject.Size = new Size((int) sbyte.MaxValue, 22);
      this.menuFile_NewProject.Text = "Project...";
      this.menuFile_NewProject.Click += new EventHandler(this.menuFile_NewProject_Click_1);
      this.menuFile_Open.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.menuFile_OpenSolution,
        (ToolStripItem) this.toolStripMenuItem8,
        (ToolStripItem) this.menuFile_OpenProject
      });
      this.menuFile_Open.Name = "menuFile_Open";
      this.menuFile_Open.ShortcutKeys = Keys.O | Keys.Control;
      this.menuFile_Open.Size = new Size(150, 22);
      this.menuFile_Open.Text = "Open";
      this.menuFile_OpenSolution.Image = (Image) Resources.solution;
      this.menuFile_OpenSolution.Name = "menuFile_OpenSolution";
      this.menuFile_OpenSolution.Size = new Size((int) sbyte.MaxValue, 22);
      this.menuFile_OpenSolution.Text = "Solution...";
      this.menuFile_OpenSolution.Click += new EventHandler(this.menuFile_OpenSolution_Click);
      this.toolStripMenuItem8.Name = "toolStripMenuItem8";
      this.toolStripMenuItem8.Size = new Size(124, 6);
      this.menuFile_OpenProject.Image = (Image) Resources.openquant;
      this.menuFile_OpenProject.Name = "menuFile_OpenProject";
      this.menuFile_OpenProject.Size = new Size((int) sbyte.MaxValue, 22);
      this.menuFile_OpenProject.Text = "Project...";
      this.menuFile_OpenProject.Click += new EventHandler(this.menuFile_OpenProject_Click_1);
      this.toolStripSeparator21.Name = "toolStripSeparator21";
      this.toolStripSeparator21.Size = new Size(147, 6);
      this.menuFile_CloseProject.Name = "menuFile_CloseProject";
      this.menuFile_CloseProject.Size = new Size(150, 22);
      this.menuFile_CloseProject.Text = "Close Solution";
      this.menuFile_CloseProject.Click += new EventHandler(this.menuFile_CloseProject_Click);
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new Size(147, 6);
      this.menuFile_Save.Image = (Image) Resources.editor_save;
      this.menuFile_Save.Name = "menuFile_Save";
      this.menuFile_Save.ShortcutKeys = Keys.S | Keys.Control;
      this.menuFile_Save.Size = new Size(150, 22);
      this.menuFile_Save.Text = "Save";
      this.toolStripSeparator20.Name = "toolStripSeparator20";
      this.toolStripSeparator20.Size = new Size(147, 6);
      this.menuFile_RecentProjects.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripMenuItem3
      });
      this.menuFile_RecentProjects.Name = "menuFile_RecentProjects";
      this.menuFile_RecentProjects.Size = new Size(150, 22);
      this.menuFile_RecentProjects.Text = "Recent";
      this.menuFile_RecentProjects.DropDownOpening += new EventHandler(this.menuFile_RecentProjects_DropDownOpening);
      this.menuFile_RecentProjects.DropDownItemClicked += new ToolStripItemClickedEventHandler(this.menuFile_RecentProjects_DropDownItemClicked);
      this.toolStripMenuItem3.Enabled = false;
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new Size(116, 22);
      this.toolStripMenuItem3.Text = "(Empty)";
      this.toolStripSeparator18.Name = "toolStripSeparator18";
      this.toolStripSeparator18.Size = new Size(147, 6);
      this.menuFile_Exit.Name = "menuFile_Exit";
      this.menuFile_Exit.Size = new Size(150, 22);
      this.menuFile_Exit.Text = "Exit";
      this.menuFile_Exit.Click += new EventHandler(this.menuFile_Exit_Click);
      this.menuEdit.DropDownItems.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.menuEdit_Undo,
        (ToolStripItem) this.menuEdit_Redo,
        (ToolStripItem) this.toolStripSeparator11,
        (ToolStripItem) this.menuEdit_Cut,
        (ToolStripItem) this.menuEdit_Copy,
        (ToolStripItem) this.menuEdit_Paste,
        (ToolStripItem) this.toolStripSeparator24,
        (ToolStripItem) this.menuEdit_Find,
        (ToolStripItem) this.menuEdit_Replace,
        (ToolStripItem) this.menuEdit_Goto
      });
      this.menuEdit.Name = "menuEdit";
      this.menuEdit.Size = new Size(39, 20);
      this.menuEdit.Text = "&Edit";
      this.menuEdit_Undo.Image = (Image) Resources.editor_undo;
      this.menuEdit_Undo.Name = "menuEdit_Undo";
      this.menuEdit_Undo.Size = new Size(216, 22);
      this.menuEdit_Undo.Text = "Undo";
      this.menuEdit_Redo.Image = (Image) Resources.editor_redo;
      this.menuEdit_Redo.Name = "menuEdit_Redo";
      this.menuEdit_Redo.Size = new Size(216, 22);
      this.menuEdit_Redo.Text = "Redo";
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      this.toolStripSeparator11.Size = new Size(213, 6);
      this.menuEdit_Cut.Image = (Image) Resources.editor_cut;
      this.menuEdit_Cut.Name = "menuEdit_Cut";
      this.menuEdit_Cut.ShortcutKeys = Keys.X | Keys.Control;
      this.menuEdit_Cut.Size = new Size(216, 22);
      this.menuEdit_Cut.Text = "Cut";
      this.menuEdit_Copy.Image = (Image) Resources.editor_copy;
      this.menuEdit_Copy.Name = "menuEdit_Copy";
      this.menuEdit_Copy.ShortcutKeys = Keys.C | Keys.Control;
      this.menuEdit_Copy.Size = new Size(216, 22);
      this.menuEdit_Copy.Text = "Copy";
      this.menuEdit_Paste.Image = (Image) Resources.editor_paste;
      this.menuEdit_Paste.Name = "menuEdit_Paste";
      this.menuEdit_Paste.ShortcutKeys = Keys.V | Keys.Control;
      this.menuEdit_Paste.Size = new Size(216, 22);
      this.menuEdit_Paste.Text = "Paste";
      this.toolStripSeparator24.Name = "toolStripSeparator24";
      this.toolStripSeparator24.Size = new Size(213, 6);
      this.menuEdit_Find.Image = (Image) Resources.find;
      this.menuEdit_Find.Name = "menuEdit_Find";
      this.menuEdit_Find.ShortcutKeys = Keys.F | Keys.Control;
      this.menuEdit_Find.Size = new Size(216, 22);
      this.menuEdit_Find.Text = "Find...";
      this.menuEdit_Replace.Name = "menuEdit_Replace";
      this.menuEdit_Replace.ShortcutKeys = Keys.H | Keys.Control;
      this.menuEdit_Replace.Size = new Size(216, 22);
      this.menuEdit_Replace.Text = "Find and Replace...";
      this.menuEdit_Goto.Name = "menuEdit_Goto";
      this.menuEdit_Goto.ShortcutKeys = Keys.G | Keys.Control;
      this.menuEdit_Goto.Size = new Size(216, 22);
      this.menuEdit_Goto.Text = "Go To...";
      this.menuView.DropDownItems.AddRange(new ToolStripItem[21]
      {
        (ToolStripItem) this.menuView_Instruments,
        (ToolStripItem) this.menuView_Indicators,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.menuView_OrderManager,
        (ToolStripItem) this.menuView_Portfolio,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.menuView_Providers,
        (ToolStripItem) this.menuView_ProviderErrors,
        (ToolStripItem) this.menuView_BrokerInfo,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.menuView_SolutionExplorer,
        (ToolStripItem) this.menuView_ScriptExplorer,
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.menuView_QuoteMonitor,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.menuView_Other,
        (ToolStripItem) this.toolStripSeparator28,
        (ToolStripItem) this.menuView_Toolbars,
        (ToolStripItem) this.toolStripSeparator19,
        (ToolStripItem) this.menuView_Output,
        (ToolStripItem) this.menuView_Properties
      });
      this.menuView.Name = "menuView";
      this.menuView.Size = new Size(44, 20);
      this.menuView.Text = "&View";
      this.menuView_Instruments.Image = (Image) Resources.instrument;
      this.menuView_Instruments.Name = "menuView_Instruments";
      this.menuView_Instruments.Size = new Size(174, 22);
      this.menuView_Instruments.Text = "Instruments";
      this.menuView_Instruments.Click += new EventHandler(this.menuView_Instruments_Click);
      this.menuView_Indicators.Image = (Image) Resources.indicator;
      this.menuView_Indicators.Name = "menuView_Indicators";
      this.menuView_Indicators.Size = new Size(174, 22);
      this.menuView_Indicators.Text = "Indicators";
      this.menuView_Indicators.Click += new EventHandler(this.menuView_Indicators_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(171, 6);
      this.menuView_OrderManager.Image = (Image) Resources.order_manager;
      this.menuView_OrderManager.Name = "menuView_OrderManager";
      this.menuView_OrderManager.Size = new Size(174, 22);
      this.menuView_OrderManager.Text = "Order Manager";
      this.menuView_OrderManager.Click += new EventHandler(this.menuView_OrderManager_Click);
      this.menuView_Portfolio.Image = (Image) Resources.portfolio;
      this.menuView_Portfolio.Name = "menuView_Portfolio";
      this.menuView_Portfolio.Size = new Size(174, 22);
      this.menuView_Portfolio.Text = "Portfolio";
      this.menuView_Portfolio.Click += new EventHandler(this.menuView_Portfolio_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(171, 6);
      this.menuView_Providers.Image = (Image) Resources.providers;
      this.menuView_Providers.Name = "menuView_Providers";
      this.menuView_Providers.Size = new Size(174, 22);
      this.menuView_Providers.Text = "Providers";
      this.menuView_Providers.Click += new EventHandler(this.menuView_Providers_Click);
      this.menuView_ProviderErrors.Image = (Image) Resources.provider_errors;
      this.menuView_ProviderErrors.Name = "menuView_ProviderErrors";
      this.menuView_ProviderErrors.Size = new Size(174, 22);
      this.menuView_ProviderErrors.Text = "Provider Errors";
      this.menuView_ProviderErrors.Click += new EventHandler(this.menuView_ProviderErrors_Click);
      this.menuView_BrokerInfo.Image = (Image) Resources.broker_info;
      this.menuView_BrokerInfo.Name = "menuView_BrokerInfo";
      this.menuView_BrokerInfo.Size = new Size(174, 22);
      this.menuView_BrokerInfo.Text = "Broker Info";
      this.menuView_BrokerInfo.Click += new EventHandler(this.menuView_BrokerInfo_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(171, 6);
      this.menuView_SolutionExplorer.Image = (Image) Resources.solution;
      this.menuView_SolutionExplorer.Name = "menuView_SolutionExplorer";
      this.menuView_SolutionExplorer.Size = new Size(174, 22);
      this.menuView_SolutionExplorer.Text = "Solution Explorer";
      this.menuView_SolutionExplorer.Click += new EventHandler(this.menuView_SolutionExplorer_Click);
      this.menuView_ScriptExplorer.Image = (Image) Resources.script_explorer;
      this.menuView_ScriptExplorer.Name = "menuView_ScriptExplorer";
      this.menuView_ScriptExplorer.Size = new Size(174, 22);
      this.menuView_ScriptExplorer.Text = "Script Explorer";
      this.menuView_ScriptExplorer.Click += new EventHandler(this.menuView_ScriptExplorer_Click);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(171, 6);
      this.menuView_QuoteMonitor.Image = (Image) Resources.quote_monitor;
      this.menuView_QuoteMonitor.Name = "menuView_QuoteMonitor";
      this.menuView_QuoteMonitor.Size = new Size(174, 22);
      this.menuView_QuoteMonitor.Text = "Quote Monitor";
      this.menuView_QuoteMonitor.Click += new EventHandler(this.menuView_QuoteMonitor_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(171, 6);
      this.menuView_Other.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.menuView_Other_StartPage
      });
      this.menuView_Other.Name = "menuView_Other";
      this.menuView_Other.Size = new Size(174, 22);
      this.menuView_Other.Text = "Other Windows";
      this.menuView_Other_StartPage.Name = "menuView_Other_StartPage";
      this.menuView_Other_StartPage.Size = new Size((int) sbyte.MaxValue, 22);
      this.menuView_Other_StartPage.Text = "Start Page";
      this.menuView_Other_StartPage.Click += new EventHandler(this.menuView_Other_StartPage_Click);
      this.toolStripSeparator28.Name = "toolStripSeparator28";
      this.toolStripSeparator28.Size = new Size(171, 6);
      this.menuView_Toolbars.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripMenuItem4
      });
      this.menuView_Toolbars.Name = "menuView_Toolbars";
      this.menuView_Toolbars.Size = new Size(174, 22);
      this.menuView_Toolbars.Text = "Toolbars";
      this.menuView_Toolbars.DropDownOpening += new EventHandler(this.menuView_Toolbars_DropDownOpening);
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new Size(116, 22);
      this.toolStripMenuItem4.Text = "(Empty)";
      this.toolStripSeparator19.Name = "toolStripSeparator19";
      this.toolStripSeparator19.Size = new Size(171, 6);
      this.menuView_Output.Image = (Image) Resources.output;
      this.menuView_Output.Name = "menuView_Output";
      this.menuView_Output.Size = new Size(174, 22);
      this.menuView_Output.Text = "Output";
      this.menuView_Output.Click += new EventHandler(this.menuView_Output_Click);
      this.menuView_Properties.Image = (Image) Resources.preferences;
      this.menuView_Properties.Name = "menuView_Properties";
      this.menuView_Properties.Size = new Size(174, 22);
      this.menuView_Properties.Text = "Properties Window";
      this.menuView_Properties.Click += new EventHandler(this.menuView_Properties_Click);
      this.menuSolution.DropDownItems.AddRange(new ToolStripItem[18]
      {
        (ToolStripItem) this.menuSolution_ManageReferences,
        (ToolStripItem) this.menuSolution_Build,
        (ToolStripItem) this.toolStripSeparator12,
        (ToolStripItem) this.menuSolution_Run,
        (ToolStripItem) this.menuSolution_Pause,
        (ToolStripItem) this.menuSolution_Stop,
        (ToolStripItem) this.toolStripSeparator23,
        (ToolStripItem) this.menuSolution_Optimize,
        (ToolStripItem) this.toolStripMenuItem11,
        (ToolStripItem) this.menuSolution_ExportToQT,
        (ToolStripItem) this.toolStripSeparator31,
        (ToolStripItem) this.menuSolution_UpdateUI,
        (ToolStripItem) this.toolStripSeparator26,
        (ToolStripItem) this.menuSolution_ViewBarChart,
        (ToolStripItem) this.menuSolution_ViewResults,
        (ToolStripItem) this.menuSolution_ViewPerformance,
        (ToolStripItem) this.menuSolution_ViewMarketScanner,
        (ToolStripItem) this.menuSolution_ViewStrategyLogs
      });
      this.menuSolution.Name = "menuSolution";
      this.menuSolution.Size = new Size(63, 20);
      this.menuSolution.Text = "&Solution";
      this.menuSolution_ManageReferences.Image = (Image) Resources.reference;
      this.menuSolution_ManageReferences.Name = "menuSolution_ManageReferences";
      this.menuSolution_ManageReferences.Size = new Size(223, 22);
      this.menuSolution_ManageReferences.Text = "Manage References";
      this.menuSolution_ManageReferences.Click += new EventHandler(this.menuSolution_ManageReferences_Click);
      this.menuSolution_Build.Image = (Image) Resources.project_build;
      this.menuSolution_Build.Name = "menuSolution_Build";
      this.menuSolution_Build.ShortcutKeys = Keys.F7;
      this.menuSolution_Build.Size = new Size(223, 22);
      this.menuSolution_Build.Text = "Build";
      this.menuSolution_Build.Click += new EventHandler(this.menuSolution_Build_Click);
      this.toolStripSeparator12.Name = "toolStripSeparator12";
      this.toolStripSeparator12.Size = new Size(220, 6);
      this.menuSolution_Run.Image = (Image) Resources.project_run;
      this.menuSolution_Run.Name = "menuSolution_Run";
      this.menuSolution_Run.ShortcutKeys = Keys.F5;
      this.menuSolution_Run.Size = new Size(223, 22);
      this.menuSolution_Run.Text = "Run";
      this.menuSolution_Run.Click += new EventHandler(this.menuSolution_Run_Click);
      this.menuSolution_Pause.Image = (Image) Resources.project_pause;
      this.menuSolution_Pause.Name = "menuSolution_Pause";
      this.menuSolution_Pause.Size = new Size(223, 22);
      this.menuSolution_Pause.Text = "Pause";
      this.menuSolution_Pause.Click += new EventHandler(this.menuSolution_Pause_Click);
      this.menuSolution_Stop.Image = (Image) Resources.project_stop;
      this.menuSolution_Stop.Name = "menuSolution_Stop";
      this.menuSolution_Stop.ShortcutKeys = Keys.F5 | Keys.Shift;
      this.menuSolution_Stop.Size = new Size(223, 22);
      this.menuSolution_Stop.Text = "Stop";
      this.menuSolution_Stop.Click += new EventHandler(this.menuSolution_Stop_Click);
      this.toolStripSeparator23.Name = "toolStripSeparator23";
      this.toolStripSeparator23.Size = new Size(220, 6);
      this.menuSolution_Optimize.Name = "menuSolution_Optimize";
      this.menuSolution_Optimize.Size = new Size(223, 22);
      this.menuSolution_Optimize.Text = "Optimize";
      this.menuSolution_Optimize.Click += new EventHandler(this.menuSolution_Optimize_Click);
      this.toolStripMenuItem11.Name = "toolStripMenuItem11";
      this.toolStripMenuItem11.Size = new Size(220, 6);
      this.menuSolution_ExportToQT.Name = "menuSolution_ExportToQT";
      this.menuSolution_ExportToQT.Size = new Size(223, 22);
      this.menuSolution_ExportToQT.Text = "Export to QuantTrader...";
      this.menuSolution_ExportToQT.Click += new EventHandler(this.menuSolution_ExportToQT_Click);
      this.toolStripSeparator31.Name = "toolStripSeparator31";
      this.toolStripSeparator31.Size = new Size(220, 6);
      this.menuSolution_UpdateUI.CheckOnClick = true;
      this.menuSolution_UpdateUI.Name = "menuSolution_UpdateUI";
      this.menuSolution_UpdateUI.Size = new Size(223, 22);
      this.menuSolution_UpdateUI.Text = "Update UI during simulation";
      this.menuSolution_UpdateUI.Click += new EventHandler(this.menuSolution_UpdateUI_Click);
      this.toolStripSeparator26.Name = "toolStripSeparator26";
      this.toolStripSeparator26.Size = new Size(220, 6);
      this.menuSolution_ViewBarChart.Image = (Image) Resources.chart;
      this.menuSolution_ViewBarChart.Name = "menuSolution_ViewBarChart";
      this.menuSolution_ViewBarChart.Size = new Size(223, 22);
      this.menuSolution_ViewBarChart.Text = "View Bar Chart";
      this.menuSolution_ViewBarChart.Click += new EventHandler(this.menuSolution_ViewBarChart_Click);
      this.menuSolution_ViewResults.Image = (Image) Resources.results;
      this.menuSolution_ViewResults.Name = "menuSolution_ViewResults";
      this.menuSolution_ViewResults.Size = new Size(223, 22);
      this.menuSolution_ViewResults.Text = "View Results";
      this.menuSolution_ViewResults.Click += new EventHandler(this.menuSolution_ViewResults_Click);
      this.menuSolution_ViewPerformance.Image = (Image) Resources.performance;
      this.menuSolution_ViewPerformance.Name = "menuSolution_ViewPerformance";
      this.menuSolution_ViewPerformance.Size = new Size(223, 22);
      this.menuSolution_ViewPerformance.Text = "View Performance";
      this.menuSolution_ViewPerformance.Click += new EventHandler(this.menuSolution_ViewPerformance_Click);
      this.menuSolution_ViewMarketScanner.Image = (Image) Resources.market_scanner;
      this.menuSolution_ViewMarketScanner.Name = "menuSolution_ViewMarketScanner";
      this.menuSolution_ViewMarketScanner.Size = new Size(223, 22);
      this.menuSolution_ViewMarketScanner.Text = "View Market Scanner";
      this.menuSolution_ViewMarketScanner.Click += new EventHandler(this.menuSolution_ViewMarketScanner_Click);
      this.menuSolution_ViewStrategyLogs.Image = (Image) componentResourceManager.GetObject("menuSolution_ViewStrategyLogs.Image");
      this.menuSolution_ViewStrategyLogs.Name = "menuSolution_ViewStrategyLogs";
      this.menuSolution_ViewStrategyLogs.Size = new Size(223, 22);
      this.menuSolution_ViewStrategyLogs.Text = "View Strategy Monitor";
      this.menuSolution_ViewStrategyLogs.Click += new EventHandler(this.menuSolution_ViewStrategyLogs_Click);
      this.menuData.DropDownItems.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.menuData_Manager,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.menuData_QuantBaseExplorer,
        (ToolStripItem) this.toolStripSeparator29,
        (ToolStripItem) this.menuData_Import,
        (ToolStripItem) this.toolStripSeparator30,
        (ToolStripItem) this.menuData_CompressBars
      });
      this.menuData.Name = "menuData";
      this.menuData.Size = new Size(43, 20);
      this.menuData.Text = "&Data";
      this.menuData_Manager.Image = (Image) Resources.data;
      this.menuData_Manager.Name = "menuData_Manager";
      this.menuData_Manager.Size = new Size(185, 22);
      this.menuData_Manager.Text = "Data Manager...";
      this.menuData_Manager.Click += new EventHandler(this.menuData_Manager_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(182, 6);
      this.menuData_QuantBaseExplorer.Image = (Image) Resources.quantbase;
      this.menuData_QuantBaseExplorer.Name = "menuData_QuantBaseExplorer";
      this.menuData_QuantBaseExplorer.Size = new Size(185, 22);
      this.menuData_QuantBaseExplorer.Text = "QuantBase Explorer...";
      this.menuData_QuantBaseExplorer.Click += new EventHandler(this.menuData_QuantBaseExplorer_Click);
      this.toolStripSeparator29.Name = "toolStripSeparator29";
      this.toolStripSeparator29.Size = new Size(182, 6);
      this.menuData_Import.DropDownItems.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.menuData_Import_CSV,
        (ToolStripItem) this.menuData_Import_TAQ,
        (ToolStripItem) this.menuData_Import_NxCore,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.menuData_Import_Instruments,
        (ToolStripItem) this.menuData_Import_Realtime,
        (ToolStripItem) this.menuData_Import_Historical
      });
      this.menuData_Import.Name = "menuData_Import";
      this.menuData_Import.Size = new Size(185, 22);
      this.menuData_Import.Text = "Import";
      this.menuData_Import_CSV.Image = (Image) Resources.csv;
      this.menuData_Import_CSV.Name = "menuData_Import_CSV";
      this.menuData_Import_CSV.Size = new Size(185, 22);
      this.menuData_Import_CSV.Text = "CSV or Text Files...";
      this.menuData_Import_CSV.Click += new EventHandler(this.menuData_Import_CSV_Click);
      this.menuData_Import_TAQ.Image = (Image) Resources.taq;
      this.menuData_Import_TAQ.Name = "menuData_Import_TAQ";
      this.menuData_Import_TAQ.Size = new Size(185, 22);
      this.menuData_Import_TAQ.Text = "TAQ CD...";
      this.menuData_Import_TAQ.Click += new EventHandler(this.menuData_Import_TAQ_Click);
      this.menuData_Import_NxCore.Image = (Image) componentResourceManager.GetObject("menuData_Import_NxCore.Image");
      this.menuData_Import_NxCore.Name = "menuData_Import_NxCore";
      this.menuData_Import_NxCore.Size = new Size(185, 22);
      this.menuData_Import_NxCore.Text = "NxCore Tape File(s)...";
      this.menuData_Import_NxCore.Click += new EventHandler(this.menuData_Import_NxCore_Click);
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new Size(182, 6);
      this.menuData_Import_Instruments.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.emptyToolStripMenuItem
      });
      this.menuData_Import_Instruments.Image = (Image) Resources.instrument;
      this.menuData_Import_Instruments.Name = "menuData_Import_Instruments";
      this.menuData_Import_Instruments.Size = new Size(185, 22);
      this.menuData_Import_Instruments.Text = "Instruments";
      this.menuData_Import_Instruments.DropDownOpening += new EventHandler(this.menuData_Import_Instruments_DropDownOpening);
      this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
      this.emptyToolStripMenuItem.Size = new Size(108, 22);
      this.emptyToolStripMenuItem.Text = "Empty";
      this.menuData_Import_Realtime.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.emptyToolStripMenuItem1
      });
      this.menuData_Import_Realtime.Image = (Image) componentResourceManager.GetObject("menuData_Import_Realtime.Image");
      this.menuData_Import_Realtime.Name = "menuData_Import_Realtime";
      this.menuData_Import_Realtime.Size = new Size(185, 22);
      this.menuData_Import_Realtime.Text = "Realtime";
      this.menuData_Import_Realtime.DropDownOpening += new EventHandler(this.menuData_Import_Realtime_DropDownOpening);
      this.emptyToolStripMenuItem1.Name = "emptyToolStripMenuItem1";
      this.emptyToolStripMenuItem1.Size = new Size(108, 22);
      this.emptyToolStripMenuItem1.Text = "Empty";
      this.menuData_Import_Historical.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripMenuItem6
      });
      this.menuData_Import_Historical.Name = "menuData_Import_Historical";
      this.menuData_Import_Historical.Size = new Size(185, 22);
      this.menuData_Import_Historical.Text = "Historical Data";
      this.menuData_Import_Historical.DropDownOpening += new EventHandler(this.menuData_Import_Historical_DropDownOpening);
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new Size(108, 22);
      this.toolStripMenuItem6.Text = "Empty";
      this.toolStripSeparator30.Name = "toolStripSeparator30";
      this.toolStripSeparator30.Size = new Size(182, 6);
      this.menuData_CompressBars.Name = "menuData_CompressBars";
      this.menuData_CompressBars.Size = new Size(185, 22);
      this.menuData_CompressBars.Text = "Compress Bars...";
      this.menuData_CompressBars.Click += new EventHandler(this.menuData_CompressBars_Click);
      this.menuTools.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.menuTools_ChartColorManager,
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.menuTools_PerformanceMonitor,
        (ToolStripItem) this.toolStripSeparator25,
        (ToolStripItem) this.menuTools_Options
      });
      this.menuTools.Name = "menuTools";
      this.menuTools.Size = new Size(48, 20);
      this.menuTools.Text = "&Tools";
      this.menuTools_ChartColorManager.Name = "menuTools_ChartColorManager";
      this.menuTools_ChartColorManager.Size = new Size(194, 22);
      this.menuTools_ChartColorManager.Text = "Chart Color Manager...";
      this.menuTools_ChartColorManager.Click += new EventHandler(this.menuTools_ChartColorManager_Click);
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new Size(191, 6);
      this.menuTools_PerformanceMonitor.Image = (Image) Resources.perfmon;
      this.menuTools_PerformanceMonitor.Name = "menuTools_PerformanceMonitor";
      this.menuTools_PerformanceMonitor.Size = new Size(194, 22);
      this.menuTools_PerformanceMonitor.Text = "Performance Monitor";
      this.menuTools_PerformanceMonitor.Click += new EventHandler(this.menuTools_PerformanceMonitor_Click);
      this.toolStripSeparator25.Name = "toolStripSeparator25";
      this.toolStripSeparator25.Size = new Size(191, 6);
      this.menuTools_Options.Image = (Image) Resources.options;
      this.menuTools_Options.Name = "menuTools_Options";
      this.menuTools_Options.Size = new Size(194, 22);
      this.menuTools_Options.Text = "Options...";
      this.menuTools_Options.Click += new EventHandler(this.menuTools_Options_Click);
      this.menuWindow.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.menuWindow_CloseAllDocuments,
        (ToolStripItem) this.toolStripSeparator27
      });
      this.menuWindow.Name = "menuWindow";
      this.menuWindow.Size = new Size(63, 20);
      this.menuWindow.Text = "&Window";
      this.menuWindow.DropDownOpening += new EventHandler(this.menuWindow_DropDownOpening);
      this.menuWindow_CloseAllDocuments.Image = (Image) Resources.window_closeall;
      this.menuWindow_CloseAllDocuments.Name = "menuWindow_CloseAllDocuments";
      this.menuWindow_CloseAllDocuments.Size = new Size(184, 22);
      this.menuWindow_CloseAllDocuments.Text = "Close All Documents";
      this.menuWindow_CloseAllDocuments.Click += new EventHandler(this.menuWindow_CloseAllDocuments_Click);
      this.toolStripSeparator27.Name = "toolStripSeparator27";
      this.toolStripSeparator27.Size = new Size(181, 6);
      this.menuHelp.DropDownItems.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.menuHelp_GettingStarted,
        (ToolStripItem) this.menuHelp_StrategyDevelopment,
        (ToolStripItem) this.menuHelp_API,
        (ToolStripItem) this.menuHelp_FAQ,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.menuHelp_CheckForUpdates,
        (ToolStripItem) this.toolStripSeparator32,
        (ToolStripItem) this.menuHelp_About
      });
      this.menuHelp.Name = "menuHelp";
      this.menuHelp.Size = new Size(44, 20);
      this.menuHelp.Text = "&Help";
      this.menuHelp_GettingStarted.Name = "menuHelp_GettingStarted";
      this.menuHelp_GettingStarted.Size = new Size(234, 22);
      this.menuHelp_GettingStarted.Text = "Getting Started Guide...";
      this.menuHelp_GettingStarted.Click += new EventHandler(this.menuHelp_GettingStarted_Click);
      this.menuHelp_StrategyDevelopment.Name = "menuHelp_StrategyDevelopment";
      this.menuHelp_StrategyDevelopment.Size = new Size(234, 22);
      this.menuHelp_StrategyDevelopment.Text = "Strategy Development Guide...";
      this.menuHelp_StrategyDevelopment.Click += new EventHandler(this.menuHelp_StrategyDevelopment_Click);
      this.menuHelp_API.Name = "menuHelp_API";
      this.menuHelp_API.Size = new Size(234, 22);
      this.menuHelp_API.Text = "API References...";
      this.menuHelp_API.Click += new EventHandler(this.menuHelp_API_Click);
      this.menuHelp_FAQ.Name = "menuHelp_FAQ";
      this.menuHelp_FAQ.Size = new Size(234, 22);
      this.menuHelp_FAQ.Text = "Frequently Asked Questions...";
      this.menuHelp_FAQ.Click += new EventHandler(this.menuHelp_FAQ_Click);
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(231, 6);
      this.menuHelp_About.Image = (Image) Resources.about;
      this.menuHelp_About.Name = "menuHelp_About";
      this.menuHelp_About.Size = new Size(234, 22);
      this.menuHelp_About.Text = "About";
      this.menuHelp_About.Click += new EventHandler(this.menuHelp_About_Click);
      this.tstSolution.Items.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.tsbSolution_Build,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.tsbSolution_Run,
        (ToolStripItem) this.tsbSolution_Pause,
        (ToolStripItem) this.tsbSolution_Stop,
        (ToolStripItem) this.toolStripSeparator22,
        (ToolStripItem) this.tsbSolution_UpdateUI
      });
      this.tstSolution.Location = new Point(0, 124);
      this.tstSolution.Name = "tstSolution";
      this.tstSolution.Size = new Size(595, 25);
      this.tstSolution.TabIndex = 1;
      this.tstSolution.Text = "Solution";
      this.tsbSolution_Build.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolution_Build.Image = (Image) Resources.project_build;
      this.tsbSolution_Build.ImageTransparentColor = Color.Magenta;
      this.tsbSolution_Build.Name = "tsbSolution_Build";
      this.tsbSolution_Build.Size = new Size(23, 22);
      this.tsbSolution_Build.Text = "toolStripButton1";
      this.tsbSolution_Build.ToolTipText = "Build";
      this.tsbSolution_Build.Click += new EventHandler(this.tsbSolution_Build_Click);
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new Size(6, 25);
      this.tsbSolution_Run.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolution_Run.Image = (Image) Resources.project_run;
      this.tsbSolution_Run.ImageTransparentColor = Color.Magenta;
      this.tsbSolution_Run.Name = "tsbSolution_Run";
      this.tsbSolution_Run.Size = new Size(23, 22);
      this.tsbSolution_Run.Text = "toolStripButton1";
      this.tsbSolution_Run.ToolTipText = "Run";
      this.tsbSolution_Run.Click += new EventHandler(this.tsbSolution_Run_Click);
      this.tsbSolution_Pause.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolution_Pause.Image = (Image) Resources.project_pause;
      this.tsbSolution_Pause.ImageTransparentColor = Color.Magenta;
      this.tsbSolution_Pause.Name = "tsbSolution_Pause";
      this.tsbSolution_Pause.Size = new Size(23, 22);
      this.tsbSolution_Pause.Text = "toolStripButton1";
      this.tsbSolution_Pause.ToolTipText = "Pause";
      this.tsbSolution_Pause.Click += new EventHandler(this.tsbSolution_Pause_Click);
      this.tsbSolution_Stop.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolution_Stop.Image = (Image) Resources.project_stop;
      this.tsbSolution_Stop.ImageTransparentColor = Color.Magenta;
      this.tsbSolution_Stop.Name = "tsbSolution_Stop";
      this.tsbSolution_Stop.Size = new Size(23, 22);
      this.tsbSolution_Stop.Text = "toolStripButton1";
      this.tsbSolution_Stop.ToolTipText = "Stop";
      this.tsbSolution_Stop.Click += new EventHandler(this.tsbSolution_Stop_Click);
      this.toolStripSeparator22.Name = "toolStripSeparator22";
      this.toolStripSeparator22.Size = new Size(6, 25);
      this.tsbSolution_UpdateUI.CheckOnClick = true;
      this.tsbSolution_UpdateUI.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolution_UpdateUI.Image = (Image) Resources.project_update_ui;
      this.tsbSolution_UpdateUI.ImageTransparentColor = Color.Magenta;
      this.tsbSolution_UpdateUI.Name = "tsbSolution_UpdateUI";
      this.tsbSolution_UpdateUI.Size = new Size(23, 22);
      this.tsbSolution_UpdateUI.Text = "toolStripButton1";
      this.tsbSolution_UpdateUI.ToolTipText = "Update UI during simulation";
      this.tsbSolution_UpdateUI.Click += new EventHandler(this.tsbSolution_UpdateUI_Click);
      this.statusStrip.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.toolStripStatusLabel1,
        (ToolStripItem) this.tsiMode,
        (ToolStripItem) this.toolStripProgressBar1,
        (ToolStripItem) this.toolStripStatusLabel2,
        (ToolStripItem) this.toolStripStatusLabel3
      });
      this.statusStrip.Location = new Point(0, 349);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.ShowItemToolTips = true;
      this.statusStrip.Size = new Size(595, 22);
      this.statusStrip.TabIndex = 2;
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new Size(189, 17);
      this.toolStripStatusLabel1.Spring = true;
      this.toolStripStatusLabel1.Text = "Ready.";
      this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
      this.tsiMode.Image = (Image) Resources.mode_live;
      this.tsiMode.ImageAlign = ContentAlignment.MiddleRight;
      this.tsiMode.Name = "tsiMode";
      this.tsiMode.Size = new Size(54, 17);
      this.tsiMode.Text = "Mode";
      this.tsiMode.TextAlign = ContentAlignment.MiddleRight;
      this.tsiMode.ToolTipText = "Click here to change mode settings";
      this.tsiMode.Click += new EventHandler(this.tsiMode_Click);
      this.toolStripProgressBar1.AutoSize = false;
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new Size(150, 16);
      this.toolStripStatusLabel2.AutoSize = false;
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      this.toolStripStatusLabel2.Size = new Size(65, 17);
      this.toolStripStatusLabel2.Text = "ClockMode";
      this.toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
      this.toolStripStatusLabel3.AutoSize = false;
      this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
      this.toolStripStatusLabel3.Size = new Size(120, 17);
      this.toolStripStatusLabel3.Text = "DateTime";
      this.panel.Dock = DockStyle.Fill;
      this.panel.Location = new Point(0, 224);
      this.panel.Name = "panel";
      this.panel.Size = new Size(595, 125);
      this.panel.TabIndex = 3;
      this.tspTop.Dock = DockStyle.Top;
      this.tspTop.Location = new Point(0, 24);
      this.tspTop.Name = "tspTop";
      this.tspTop.Orientation = Orientation.Horizontal;
      this.tspTop.RowMargin = new Padding(3, 0, 0, 0);
      this.tspTop.Size = new Size(595, 0);
      this.tstFile.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.tsbFile_New,
        (ToolStripItem) this.tsbFile_Open
      });
      this.tstFile.Location = new Point(0, 49);
      this.tstFile.Name = "tstFile";
      this.tstFile.Size = new Size(595, 25);
      this.tstFile.TabIndex = 2;
      this.tstFile.Text = "File";
      this.tsbFile_New.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbFile_New.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.tsbFile_New_Solution,
        (ToolStripItem) this.toolStripMenuItem9,
        (ToolStripItem) this.tsbFile_New_Project
      });
      this.tsbFile_New.Image = (Image) Resources.project_new;
      this.tsbFile_New.ImageTransparentColor = Color.Magenta;
      this.tsbFile_New.Name = "tsbFile_New";
      this.tsbFile_New.Size = new Size(29, 22);
      this.tsbFile_New.Text = "New";
      this.tsbFile_New_Solution.Image = (Image) Resources.solution;
      this.tsbFile_New_Solution.Name = "tsbFile_New_Solution";
      this.tsbFile_New_Solution.Size = new Size(154, 22);
      this.tsbFile_New_Solution.Text = "New Solution...";
      this.tsbFile_New_Solution.Click += new EventHandler(this.tsbFile_New_Solution_Click);
      this.toolStripMenuItem9.Name = "toolStripMenuItem9";
      this.toolStripMenuItem9.Size = new Size(151, 6);
      this.tsbFile_New_Project.Image = (Image) Resources.openquant;
      this.tsbFile_New_Project.Name = "tsbFile_New_Project";
      this.tsbFile_New_Project.Size = new Size(154, 22);
      this.tsbFile_New_Project.Text = "New Project...";
      this.tsbFile_New_Project.Click += new EventHandler(this.tsbFile_New_Project_Click);
      this.tsbFile_Open.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbFile_Open.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.tsbFile_Open_Solution,
        (ToolStripItem) this.toolStripMenuItem10,
        (ToolStripItem) this.tsbFile_Open_Project
      });
      this.tsbFile_Open.Image = (Image) Resources.project_open;
      this.tsbFile_Open.ImageTransparentColor = Color.Magenta;
      this.tsbFile_Open.Name = "tsbFile_Open";
      this.tsbFile_Open.Size = new Size(29, 22);
      this.tsbFile_Open.Text = "Open";
      this.tsbFile_Open_Solution.Image = (Image) Resources.solution;
      this.tsbFile_Open_Solution.Name = "tsbFile_Open_Solution";
      this.tsbFile_Open_Solution.Size = new Size(159, 22);
      this.tsbFile_Open_Solution.Text = "Open Solution...";
      this.tsbFile_Open_Solution.Click += new EventHandler(this.tsbFile_Open_Solution_Click);
      this.toolStripMenuItem10.Name = "toolStripMenuItem10";
      this.toolStripMenuItem10.Size = new Size(156, 6);
      this.tsbFile_Open_Project.Image = (Image) Resources.openquant;
      this.tsbFile_Open_Project.Name = "tsbFile_Open_Project";
      this.tsbFile_Open_Project.Size = new Size(159, 22);
      this.tsbFile_Open_Project.Text = "Open Project...";
      this.tsbFile_Open_Project.Click += new EventHandler(this.tsbFile_Open_Project_Click);
      this.tstEdit.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.tsbEdit_Save,
        (ToolStripItem) this.toolStripSeparator9,
        (ToolStripItem) this.tsbEdit_Cut,
        (ToolStripItem) this.tsbEdit_Copy,
        (ToolStripItem) this.tsbEdit_Paste,
        (ToolStripItem) this.toolStripSeparator10,
        (ToolStripItem) this.tsbEdit_Undo,
        (ToolStripItem) this.tsbEdit_Redo
      });
      this.tstEdit.Location = new Point(0, 74);
      this.tstEdit.Name = "tstEdit";
      this.tstEdit.Size = new Size(595, 25);
      this.tstEdit.TabIndex = 3;
      this.tstEdit.Text = "Edit";
      this.tsbEdit_Save.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbEdit_Save.Image = (Image) Resources.editor_save;
      this.tsbEdit_Save.ImageTransparentColor = Color.Magenta;
      this.tsbEdit_Save.Name = "tsbEdit_Save";
      this.tsbEdit_Save.Size = new Size(23, 22);
      this.tsbEdit_Save.Text = "toolStripButton1";
      this.tsbEdit_Save.ToolTipText = "Save";
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      this.toolStripSeparator9.Size = new Size(6, 25);
      this.tsbEdit_Cut.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbEdit_Cut.Image = (Image) Resources.editor_cut;
      this.tsbEdit_Cut.ImageTransparentColor = Color.Magenta;
      this.tsbEdit_Cut.Name = "tsbEdit_Cut";
      this.tsbEdit_Cut.Size = new Size(23, 22);
      this.tsbEdit_Cut.Text = "toolStripButton1";
      this.tsbEdit_Cut.ToolTipText = "Cut";
      this.tsbEdit_Copy.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbEdit_Copy.Image = (Image) Resources.editor_copy;
      this.tsbEdit_Copy.ImageTransparentColor = Color.Magenta;
      this.tsbEdit_Copy.Name = "tsbEdit_Copy";
      this.tsbEdit_Copy.Size = new Size(23, 22);
      this.tsbEdit_Copy.Text = "toolStripButton1";
      this.tsbEdit_Copy.ToolTipText = "Copy";
      this.tsbEdit_Paste.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbEdit_Paste.Image = (Image) Resources.editor_paste;
      this.tsbEdit_Paste.ImageTransparentColor = Color.Magenta;
      this.tsbEdit_Paste.Name = "tsbEdit_Paste";
      this.tsbEdit_Paste.Size = new Size(23, 22);
      this.tsbEdit_Paste.Text = "toolStripButton1";
      this.tsbEdit_Paste.ToolTipText = "Paste";
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new Size(6, 25);
      this.tsbEdit_Undo.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbEdit_Undo.Image = (Image) Resources.editor_undo;
      this.tsbEdit_Undo.ImageTransparentColor = Color.Magenta;
      this.tsbEdit_Undo.Name = "tsbEdit_Undo";
      this.tsbEdit_Undo.Size = new Size(23, 22);
      this.tsbEdit_Undo.Text = "toolStripButton1";
      this.tsbEdit_Undo.ToolTipText = "Undo";
      this.tsbEdit_Redo.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbEdit_Redo.Image = (Image) Resources.editor_redo;
      this.tsbEdit_Redo.ImageTransparentColor = Color.Magenta;
      this.tsbEdit_Redo.Name = "tsbEdit_Redo";
      this.tsbEdit_Redo.Size = new Size(23, 22);
      this.tsbEdit_Redo.Text = "toolStripButton1";
      this.tsbEdit_Redo.ToolTipText = "Redo";
      this.tstView.Items.AddRange(new ToolStripItem[17]
      {
        (ToolStripItem) this.tsbView_Instruments,
        (ToolStripItem) this.tsbView_Indicators,
        (ToolStripItem) this.toolStripSeparator13,
        (ToolStripItem) this.tsbView_OrderManager,
        (ToolStripItem) this.tsbView_Portfolio,
        (ToolStripItem) this.tsbView_BrokerInfo,
        (ToolStripItem) this.toolStripSeparator14,
        (ToolStripItem) this.tsbView_Providers,
        (ToolStripItem) this.tsbView_ProviderErrors,
        (ToolStripItem) this.toolStripSeparator15,
        (ToolStripItem) this.tsbView_SolutionExplorer,
        (ToolStripItem) this.tsbView_ScriptExplorer,
        (ToolStripItem) this.toolStripSeparator16,
        (ToolStripItem) this.tsbView_QuoteMonitor,
        (ToolStripItem) this.toolStripSeparator17,
        (ToolStripItem) this.tsbView_Output,
        (ToolStripItem) this.tsbView_Properties
      });
      this.tstView.Location = new Point(0, 24);
      this.tstView.Name = "tstView";
      this.tstView.Size = new Size(595, 25);
      this.tstView.TabIndex = 4;
      this.tstView.Text = "View";
      this.tsbView_Instruments.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_Instruments.Image = (Image) Resources.instrument;
      this.tsbView_Instruments.ImageTransparentColor = Color.Magenta;
      this.tsbView_Instruments.Name = "tsbView_Instruments";
      this.tsbView_Instruments.Size = new Size(23, 22);
      this.tsbView_Instruments.Text = "toolStripButton1";
      this.tsbView_Instruments.ToolTipText = "Instruments";
      this.tsbView_Instruments.Click += new EventHandler(this.tsbView_Instruments_Click);
      this.tsbView_Indicators.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_Indicators.Image = (Image) Resources.indicator;
      this.tsbView_Indicators.ImageTransparentColor = Color.Magenta;
      this.tsbView_Indicators.Name = "tsbView_Indicators";
      this.tsbView_Indicators.Size = new Size(23, 22);
      this.tsbView_Indicators.Text = "toolStripButton1";
      this.tsbView_Indicators.ToolTipText = "Indicators";
      this.tsbView_Indicators.Click += new EventHandler(this.tsbView_Indicators_Click);
      this.toolStripSeparator13.Name = "toolStripSeparator13";
      this.toolStripSeparator13.Size = new Size(6, 25);
      this.tsbView_OrderManager.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_OrderManager.Image = (Image) Resources.order_manager;
      this.tsbView_OrderManager.ImageTransparentColor = Color.Magenta;
      this.tsbView_OrderManager.Name = "tsbView_OrderManager";
      this.tsbView_OrderManager.Size = new Size(23, 22);
      this.tsbView_OrderManager.Text = "toolStripButton1";
      this.tsbView_OrderManager.ToolTipText = "Order Manager";
      this.tsbView_OrderManager.Click += new EventHandler(this.tsbView_OrderManager_Click);
      this.tsbView_Portfolio.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_Portfolio.Image = (Image) Resources.portfolio;
      this.tsbView_Portfolio.ImageTransparentColor = Color.Magenta;
      this.tsbView_Portfolio.Name = "tsbView_Portfolio";
      this.tsbView_Portfolio.Size = new Size(23, 22);
      this.tsbView_Portfolio.Text = "toolStripButton1";
      this.tsbView_Portfolio.ToolTipText = "Portfolio";
      this.tsbView_Portfolio.Click += new EventHandler(this.tsbView_Portfolio_Click);
      this.tsbView_BrokerInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_BrokerInfo.Image = (Image) Resources.broker_info;
      this.tsbView_BrokerInfo.ImageTransparentColor = Color.Magenta;
      this.tsbView_BrokerInfo.Name = "tsbView_BrokerInfo";
      this.tsbView_BrokerInfo.Size = new Size(23, 22);
      this.tsbView_BrokerInfo.Text = "toolStripButton1";
      this.tsbView_BrokerInfo.ToolTipText = "Broker Info";
      this.tsbView_BrokerInfo.Click += new EventHandler(this.tsbView_BrokerInfo_Click);
      this.toolStripSeparator14.Name = "toolStripSeparator14";
      this.toolStripSeparator14.Size = new Size(6, 25);
      this.tsbView_Providers.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_Providers.Image = (Image) Resources.providers;
      this.tsbView_Providers.ImageTransparentColor = Color.Magenta;
      this.tsbView_Providers.Name = "tsbView_Providers";
      this.tsbView_Providers.Size = new Size(23, 22);
      this.tsbView_Providers.Text = "toolStripButton1";
      this.tsbView_Providers.ToolTipText = "Providers";
      this.tsbView_Providers.Click += new EventHandler(this.tsbView_Providers_Click);
      this.tsbView_ProviderErrors.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_ProviderErrors.Image = (Image) Resources.provider_errors;
      this.tsbView_ProviderErrors.ImageTransparentColor = Color.Magenta;
      this.tsbView_ProviderErrors.Name = "tsbView_ProviderErrors";
      this.tsbView_ProviderErrors.Size = new Size(23, 22);
      this.tsbView_ProviderErrors.Text = "toolStripButton1";
      this.tsbView_ProviderErrors.ToolTipText = "Provider Errors";
      this.tsbView_ProviderErrors.Click += new EventHandler(this.tsbView_ProviderErrors_Click);
      this.toolStripSeparator15.Name = "toolStripSeparator15";
      this.toolStripSeparator15.Size = new Size(6, 25);
      this.tsbView_SolutionExplorer.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_SolutionExplorer.Image = (Image) Resources.solution;
      this.tsbView_SolutionExplorer.ImageTransparentColor = Color.Magenta;
      this.tsbView_SolutionExplorer.Name = "tsbView_SolutionExplorer";
      this.tsbView_SolutionExplorer.Size = new Size(23, 22);
      this.tsbView_SolutionExplorer.Text = "toolStripButton1";
      this.tsbView_SolutionExplorer.ToolTipText = "Solution Explorer";
      this.tsbView_SolutionExplorer.Click += new EventHandler(this.tsbView_SolutionExplorer_Click);
      this.tsbView_ScriptExplorer.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_ScriptExplorer.Image = (Image) Resources.script_explorer;
      this.tsbView_ScriptExplorer.ImageTransparentColor = Color.Magenta;
      this.tsbView_ScriptExplorer.Name = "tsbView_ScriptExplorer";
      this.tsbView_ScriptExplorer.Size = new Size(23, 22);
      this.tsbView_ScriptExplorer.Text = "toolStripButton1";
      this.tsbView_ScriptExplorer.ToolTipText = "Script Explorer";
      this.tsbView_ScriptExplorer.Click += new EventHandler(this.tsbView_ScriptExplorer_Click);
      this.toolStripSeparator16.Name = "toolStripSeparator16";
      this.toolStripSeparator16.Size = new Size(6, 25);
      this.tsbView_QuoteMonitor.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_QuoteMonitor.Image = (Image) Resources.quote_monitor;
      this.tsbView_QuoteMonitor.ImageTransparentColor = Color.Magenta;
      this.tsbView_QuoteMonitor.Name = "tsbView_QuoteMonitor";
      this.tsbView_QuoteMonitor.Size = new Size(23, 22);
      this.tsbView_QuoteMonitor.Text = "toolStripButton1";
      this.tsbView_QuoteMonitor.ToolTipText = "Quote Monitor";
      this.tsbView_QuoteMonitor.Click += new EventHandler(this.tsbView_QuoteMonitor_Click);
      this.toolStripSeparator17.Name = "toolStripSeparator17";
      this.toolStripSeparator17.Size = new Size(6, 25);
      this.tsbView_Output.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_Output.Image = (Image) Resources.output;
      this.tsbView_Output.ImageTransparentColor = Color.Magenta;
      this.tsbView_Output.Name = "tsbView_Output";
      this.tsbView_Output.Size = new Size(23, 22);
      this.tsbView_Output.Text = "toolStripButton1";
      this.tsbView_Output.ToolTipText = "Output";
      this.tsbView_Output.Click += new EventHandler(this.tsbView_Output_Click);
      this.tsbView_Properties.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbView_Properties.Image = (Image) Resources.preferences;
      this.tsbView_Properties.ImageTransparentColor = Color.Magenta;
      this.tsbView_Properties.Name = "tsbView_Properties";
      this.tsbView_Properties.Size = new Size(23, 22);
      this.tsbView_Properties.Text = "toolStripButton1";
      this.tsbView_Properties.ToolTipText = "Properties";
      this.tsbView_Properties.Click += new EventHandler(this.tsbView_Properties_Click);
      this.tspRight.Dock = DockStyle.Right;
      this.tspRight.Location = new Point(595, 24);
      this.tspRight.Name = "tspRight";
      this.tspRight.Orientation = Orientation.Vertical;
      this.tspRight.RowMargin = new Padding(0, 3, 0, 0);
      this.tspRight.Size = new Size(0, 325);
      this.tspLeft.Dock = DockStyle.Left;
      this.tspLeft.Location = new Point(0, 24);
      this.tspLeft.Name = "tspLeft";
      this.tspLeft.Orientation = Orientation.Vertical;
      this.tspLeft.RowMargin = new Padding(0, 3, 0, 0);
      this.tspLeft.Size = new Size(0, 325);
      this.tspBottom.Dock = DockStyle.Bottom;
      this.tspBottom.Location = new Point(0, 349);
      this.tspBottom.Name = "tspBottom";
      this.tspBottom.Orientation = Orientation.Horizontal;
      this.tspBottom.RowMargin = new Padding(3, 0, 0, 0);
      this.tspBottom.Size = new Size(595, 0);
      this.tstMode.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.tsbMode
      });
      this.tstMode.Location = new Point(0, 174);
      this.tstMode.Name = "tstMode";
      this.tstMode.Size = new Size(595, 25);
      this.tstMode.TabIndex = 0;
      this.tstMode.Text = "Mode";
      this.tsbMode.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.tsbMode_Simulation,
        (ToolStripItem) this.tsbMode_Paper,
        (ToolStripItem) this.tsbMode_Live
      });
      this.tsbMode.Image = (Image) componentResourceManager.GetObject("tsbMode.Image");
      this.tsbMode.ImageTransparentColor = Color.Magenta;
      this.tsbMode.Name = "tsbMode";
      this.tsbMode.Size = new Size(67, 22);
      this.tsbMode.Text = "Mode";
      this.tsbMode.TextAlign = ContentAlignment.MiddleLeft;
      this.tsbMode_Simulation.Image = (Image) Resources.mode_simulation;
      this.tsbMode_Simulation.Name = "tsbMode_Simulation";
      this.tsbMode_Simulation.Size = new Size(131, 22);
      this.tsbMode_Simulation.Text = "Simulation";
      this.tsbMode_Simulation.Click += new EventHandler(this.tsbMode_Simulation_Click);
      this.tsbMode_Paper.Image = (Image) Resources.mode_paper;
      this.tsbMode_Paper.Name = "tsbMode_Paper";
      this.tsbMode_Paper.Size = new Size(131, 22);
      this.tsbMode_Paper.Text = "Paper";
      this.tsbMode_Paper.Click += new EventHandler(this.tsbMode_Paper_Click);
      this.tsbMode_Live.Image = (Image) Resources.mode_live;
      this.tsbMode_Live.Name = "tsbMode_Live";
      this.tsbMode_Live.Size = new Size(131, 22);
      this.tsbMode_Live.Text = "Live";
      this.tsbMode_Live.Click += new EventHandler(this.tsbMode_Live_Click);
      this.tstSolutionView.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.tsbSolutionView_BarChart,
        (ToolStripItem) this.tsbSolutionView_Results,
        (ToolStripItem) this.tsbSolutionView_Performance,
        (ToolStripItem) this.tsbSolutionView_MarketScanner,
        (ToolStripItem) this.tsbSolutionView_StrategyLogs
      });
      this.tstSolutionView.Location = new Point(0, 149);
      this.tstSolutionView.Name = "tstSolutionView";
      this.tstSolutionView.Size = new Size(595, 25);
      this.tstSolutionView.TabIndex = 15;
      this.tstSolutionView.Text = "Solution View";
      this.tsbSolutionView_BarChart.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolutionView_BarChart.Image = (Image) Resources.chart;
      this.tsbSolutionView_BarChart.ImageTransparentColor = Color.Magenta;
      this.tsbSolutionView_BarChart.Name = "tsbSolutionView_BarChart";
      this.tsbSolutionView_BarChart.Size = new Size(23, 22);
      this.tsbSolutionView_BarChart.Text = "toolStripButton1";
      this.tsbSolutionView_BarChart.ToolTipText = "View Bar Chart";
      this.tsbSolutionView_BarChart.Click += new EventHandler(this.tsbSolutionView_BarChart_Click);
      this.tsbSolutionView_Results.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolutionView_Results.Image = (Image) Resources.results;
      this.tsbSolutionView_Results.ImageTransparentColor = Color.Magenta;
      this.tsbSolutionView_Results.Name = "tsbSolutionView_Results";
      this.tsbSolutionView_Results.Size = new Size(23, 22);
      this.tsbSolutionView_Results.Text = "toolStripButton1";
      this.tsbSolutionView_Results.ToolTipText = "View Results";
      this.tsbSolutionView_Results.Click += new EventHandler(this.tsbSolutionView_Results_Click);
      this.tsbSolutionView_Performance.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolutionView_Performance.Image = (Image) Resources.performance;
      this.tsbSolutionView_Performance.ImageTransparentColor = Color.Magenta;
      this.tsbSolutionView_Performance.Name = "tsbSolutionView_Performance";
      this.tsbSolutionView_Performance.Size = new Size(23, 22);
      this.tsbSolutionView_Performance.Text = "toolStripButton1";
      this.tsbSolutionView_Performance.ToolTipText = "View Performance";
      this.tsbSolutionView_Performance.Click += new EventHandler(this.tsbSolutionView_Performance_Click);
      this.tsbSolutionView_MarketScanner.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolutionView_MarketScanner.Image = (Image) Resources.market_scanner;
      this.tsbSolutionView_MarketScanner.ImageTransparentColor = Color.Magenta;
      this.tsbSolutionView_MarketScanner.Name = "tsbSolutionView_MarketScanner";
      this.tsbSolutionView_MarketScanner.Size = new Size(23, 22);
      this.tsbSolutionView_MarketScanner.Text = "toolStripButton1";
      this.tsbSolutionView_MarketScanner.ToolTipText = "View Market Scanner";
      this.tsbSolutionView_MarketScanner.Click += new EventHandler(this.tsbSolutionView_MarketScanner_Click);
      this.tsbSolutionView_StrategyLogs.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbSolutionView_StrategyLogs.Image = (Image) componentResourceManager.GetObject("tsbSolutionView_StrategyLogs.Image");
      this.tsbSolutionView_StrategyLogs.ImageTransparentColor = Color.Magenta;
      this.tsbSolutionView_StrategyLogs.Name = "tsbSolutionView_StrategyLogs";
      this.tsbSolutionView_StrategyLogs.Size = new Size(23, 22);
      this.tsbSolutionView_StrategyLogs.Text = "View Strategy Monitor";
      this.tsbSolutionView_StrategyLogs.Click += new EventHandler(this.tsbSolutionView_StrategyLogs_Click);
      this.ntiUpdates.BalloonTipTitle = "OpenQuant Updates";
      this.ntiUpdates.Icon = (Icon) componentResourceManager.GetObject("ntiUpdates.Icon");
      this.ntiUpdates.Text = "OpenQuant Updates. Click icon for details";
      this.ntiUpdates.BalloonTipClicked += new EventHandler(this.ntiUpdates_BalloonTipClicked);
      this.ntiUpdates.Click += new EventHandler(this.ntiUpdates_Click);
      this.tstInstrumentList.set_InstrumentListSource((InstrumentListSource) null);
      ((Control) this.tstInstrumentList).Location = new Point(0, 199);
      ((Control) this.tstInstrumentList).Name = "tstInstrumentList";
      ((Control) this.tstInstrumentList).Size = new Size(595, 25);
      ((Control) this.tstInstrumentList).TabIndex = 10;
      ((Control) this.tstInstrumentList).Text = "Instruments";
      ((Control) this.tstChart).Location = new Point(0, 99);
      ((Control) this.tstChart).Name = "tstChart";
      ((Control) this.tstChart).Size = new Size(595, 25);
      ((Control) this.tstChart).TabIndex = 5;
      ((Control) this.tstChart).Text = "Chart";
      this.menuHelp_CheckForUpdates.Name = "menuHelp_CheckForUpdates";
      this.menuHelp_CheckForUpdates.Size = new Size(234, 22);
      this.menuHelp_CheckForUpdates.Text = "Check for Updates";
      this.menuHelp_CheckForUpdates.Click += new EventHandler(this.menuHelp_CheckForUpdates_Click);
      this.toolStripSeparator32.Name = "toolStripSeparator32";
      this.toolStripSeparator32.Size = new Size(231, 6);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(595, 371);
      this.Controls.Add((Control) this.panel);
      this.Controls.Add((Control) this.tstInstrumentList);
      this.Controls.Add((Control) this.tstMode);
      this.Controls.Add((Control) this.tstSolutionView);
      this.Controls.Add((Control) this.tstSolution);
      this.Controls.Add((Control) this.tstChart);
      this.Controls.Add((Control) this.tstEdit);
      this.Controls.Add((Control) this.tstFile);
      this.Controls.Add((Control) this.tstView);
      this.Controls.Add((Control) this.tspLeft);
      this.Controls.Add((Control) this.tspRight);
      this.Controls.Add((Control) this.tspBottom);
      this.Controls.Add((Control) this.tspTop);
      this.Controls.Add((Control) this.statusStrip);
      this.Controls.Add((Control) this.menuStrip);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip;
      this.Name = "IDE";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.tstSolution.ResumeLayout(false);
      this.tstSolution.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.tstFile.ResumeLayout(false);
      this.tstFile.PerformLayout();
      this.tstEdit.ResumeLayout(false);
      this.tstEdit.PerformLayout();
      this.tstView.ResumeLayout(false);
      this.tstView.PerformLayout();
      this.tstMode.ResumeLayout(false);
      this.tstMode.PerformLayout();
      this.tstSolutionView.ResumeLayout(false);
      this.tstSolutionView.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    protected override void OnLoad(EventArgs e)
    {
      ((OptionsBase) Global.Options).Load();
      this.LoadPlugins();
      this.CheckConfigurationModes();
      if (OpenQuant.Config.Configuration.get_Active().get_Portfolio() != null)
        OpenQuant.Config.Configuration.get_Active().get_Portfolio().Monitored = true;
      this.LoadSettings();
      this.LoadLayout();
      this.WindowState = FormWindowState.Maximized;
      Global.Options.Environment.Layout.Apply();
      switch (Global.Options.Environment.Startup.Action)
      {
        case StartupAction.ShowStartPage:
        case StartupAction.ShowStartPageAndLoadSolution:
          Global.get_DockManager().Open(typeof (StartPageWindow));
          break;
      }
      Global.get_TimerManager().Start((ITimerItem) this);
      this.tspRight.Join(this.tstView, 0);
      this.tspRight.Join(this.tstSolutionView, 0);
      this.tspTop.Join(this.tstMode);
      this.tspTop.Join(this.tstSolution, 0);
      this.tspTop.Join((ToolStrip) this.tstChart, 0);
      this.tspTop.Join((ToolStrip) this.tstInstrumentList, 0);
      this.tspTop.Join(this.tstEdit, 0);
      this.tspTop.Join(this.tstFile, 0);
      Global.Toolbar.Init(this.tstFile, this.tstEdit, this.tstView, this.tstSolution, this.tstSolutionView, this.tstChart, this.tstMode, this.tstInstrumentList);
      Global.EditorManager.Init(new EditorActionItem[9]
      {
        new EditorActionItem((EditorAction) 0, new ToolStripItem[2]
        {
          (ToolStripItem) this.menuFile_Save,
          (ToolStripItem) this.tsbEdit_Save
        }),
        new EditorActionItem((EditorAction) 1, new ToolStripItem[2]
        {
          (ToolStripItem) this.menuEdit_Undo,
          (ToolStripItem) this.tsbEdit_Undo
        }),
        new EditorActionItem((EditorAction) 2, new ToolStripItem[2]
        {
          (ToolStripItem) this.menuEdit_Redo,
          (ToolStripItem) this.tsbEdit_Redo
        }),
        new EditorActionItem((EditorAction) 3, new ToolStripItem[2]
        {
          (ToolStripItem) this.menuEdit_Cut,
          (ToolStripItem) this.tsbEdit_Cut
        }),
        new EditorActionItem((EditorAction) 4, new ToolStripItem[2]
        {
          (ToolStripItem) this.menuEdit_Copy,
          (ToolStripItem) this.tsbEdit_Copy
        }),
        new EditorActionItem((EditorAction) 5, new ToolStripItem[2]
        {
          (ToolStripItem) this.menuEdit_Paste,
          (ToolStripItem) this.tsbEdit_Paste
        }),
        new EditorActionItem((EditorAction) 6, new ToolStripItem[1]
        {
          (ToolStripItem) this.menuEdit_Find
        }),
        new EditorActionItem((EditorAction) 7, new ToolStripItem[1]
        {
          (ToolStripItem) this.menuEdit_Replace
        }),
        new EditorActionItem((EditorAction) 8, new ToolStripItem[1]
        {
          (ToolStripItem) this.menuEdit_Goto
        })
      });
      SimulationProgressBar simulationProgressBar = new SimulationProgressBar((this.statusStrip.Items[2] as ToolStripProgressBar).ProgressBar);
      this.UpdateActiveModeButton();
      this.UpdateStatusMode();
      this.UpdateProjectControls();
      this.tsbSolution_Pause.Visible = false;
      this.menuSolution_Pause.Visible = false;
      this.Text = Global.Setup.get_Product().get_Name();
      this.menuHelp_About.Text = string.Format("About {0}", (object) Global.Setup.get_Product().get_Name());
      Global.Flags.Load();
      this.SetUpdateUIFlag(Global.Flags.UpdateUIRawValue);
      // ISSUE: method pointer
      ((SandDockManager) Global.get_DockManager()).add_DockControlActivated(new DockControlEventHandler((object) this, __methodptr(DockManager_DockControlActivated)));
      // ISSUE: method pointer
      OpenQuant.Config.Configuration.add_ConfigurationModeChanging(new ConfigurationModeChangingEventHandler((object) this, __methodptr(Configuration_ConfigurationModeChanging)));
      OpenQuant.Config.Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      Global.ProjectManager.SolutionOpened += new EventHandler(this.ProjectManager_SolutionOpened);
      Global.ProjectManager.SolutionClosed += new EventHandler(this.ProjectManager_SolutionClosed);
      Runner.Starting += new EventHandler(this.Runner_Starting);
      Runner.Started += new EventHandler(this.Runner_Started);
      Runner.Stopping += new EventHandler(this.Runner_Stopping);
      Runner.Stopped += new EventHandler(this.Runner_Stopped);
      Runner.Error += new EventHandler<RunnerErrorEventArgs>(this.Runner_Error);
      Global.ScriptManager.add_Error(new EventHandler<ScriptRunnerErrorEventArgs>(this.ScriptManager_Error));
      if (Global.Options.Environment.Startup.CheckForUpdates)
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.CheckForUpdates));
      Appearance.set_OutputWindowFont(this.Font);
      EnvironmentListener.Init();
      base.OnLoad(e);
      Global.ScriptManager.RunStartupScripts(Global.Options.Solutions.Build, Global.Options.Solutions.Scripts);
    }

    protected override void OnShown(EventArgs e)
    {
      string[] commandLineArgs = Environment.GetCommandLineArgs();
      if (commandLineArgs.Length > 1)
      {
        string str = commandLineArgs[1];
        if (File.Exists(str))
        {
          Global.ProjectManager.Open(new FileInfo(str));
          if (commandLineArgs.Length > 2 && commandLineArgs[2].ToUpper() == "/R" && (this.BuildProject() && Global.ProjectManager.ActiveSolution.Validate()))
            Runner.Start(Global.ProjectManager.ActiveSolution);
        }
      }
      else
      {
        switch (Global.Options.Environment.Startup.Action)
        {
          case StartupAction.LoadLastLoadedSolution:
          case StartupAction.ShowStartPageAndLoadSolution:
            SolutionInfo lastLoadedSolution = Global.ProjectManager.LastLoadedSolution;
            if (lastLoadedSolution != null)
            {
              Global.ProjectManager.Open(lastLoadedSolution.File);
              break;
            }
            else
              break;
        }
      }
      base.OnShown(e);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (Runner.IsRunning || Runner.IsOptimizing)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, "Cannot close application, because the strategy is running.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        e.Cancel = true;
      }
      else if (Global.ScriptManager.GetRunningScripts().Length > 0)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, "Cannot close application, because some scripts are running.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        e.Cancel = true;
      }
      else
      {
        string str = "";
        foreach (DockControl dockControl in Global.get_DockManager().GetDockControls())
        {
          if (dockControl is IBusyWindow)
          {
            IBusyWindow ibusyWindow = (IBusyWindow) dockControl;
            if (ibusyWindow.get_IsBusy())
              str = str + Environment.NewLine + ibusyWindow.get_BusyWindowMessage();
          }
        }
        if (str != "" && MessageBox.Show((IWin32Window) this, string.Format("The following window(s) may do some important job, are sure that you want to close {0}?{1}{2}", (object) Global.Setup.get_Product().get_Name(), (object) Environment.NewLine, (object) str), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        {
          e.Cancel = true;
        }
        else
        {
          Global.Flags.ApplicationClosing = true;
          this.SaveSettings();
          this.SaveLayout();
          Global.ProjectManager.CloseActiveSolution();
          Global.get_DockManager().CloseAll(false);
          Global.Toolbar.Done();
          Global.Flags.Save();
          Global.get_TimerManager().Stop((ITimerItem) this);
          base.OnFormClosing(e);
        }
      }
    }

    private void SaveLayout()
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (LayoutInfo));
        LayoutInfo layout = Global.get_DockManager().GetLayout();
        using (FileStream fileStream = new FileStream(this.GetLayoutFileName(), FileMode.Create))
          xmlSerializer.Serialize((Stream) fileStream, (object) layout);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Save Layout - Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void LoadLayout()
    {
      try
      {
        string layoutFileName = this.GetLayoutFileName();
        if (!File.Exists(layoutFileName))
          return;
        LayoutInfo layoutInfo;
        using (FileStream fileStream = new FileStream(layoutFileName, FileMode.Open))
          layoutInfo = (LayoutInfo) new XmlSerializer(typeof (LayoutInfo)).Deserialize((Stream) fileStream);
        Global.get_DockManager().SetLayout(layoutInfo);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Load Layout - Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void SaveSettings()
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (SettingsInfo));
        SettingsInfo settings = Global.get_DockManager().GetSettings();
        using (FileStream fileStream = new FileStream(this.GetSettingsFileName(), FileMode.Create))
          xmlSerializer.Serialize((Stream) fileStream, (object) settings);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Save Settings - Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void LoadSettings()
    {
      try
      {
        string settingsFileName = this.GetSettingsFileName();
        if (!File.Exists(settingsFileName))
          return;
        SettingsInfo settingsInfo;
        using (FileStream fileStream = new FileStream(settingsFileName, FileMode.Open))
          settingsInfo = (SettingsInfo) new XmlSerializer(typeof (SettingsInfo)).Deserialize((Stream) fileStream);
        Global.get_DockManager().SetSettings(settingsInfo);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Load Settings - Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private string GetLayoutFileName()
    {
      return string.Format("{0}\\layout.xml", (object) Global.Setup.Folders.Layout.FullName);
    }

    private string GetSettingsFileName()
    {
      return string.Format("{0}\\settings.xml", (object) Global.Setup.Folders.Layout.FullName);
    }

    public void OnElapsed()
    {
      this.statusStrip.Items[3].Text = ((object) Clock.ClockMode).ToString();
      this.statusStrip.Items[4].Text = Clock.Now.ToString();
    }

    private void menuFile_NewProject_Click(object sender, EventArgs e)
    {
      this.NewSolution();
    }

    private void menuFile_OpenProject_Click(object sender, EventArgs e)
    {
      this.OpenProject();
    }

    private void menuFile_CloseProject_Click(object sender, EventArgs e)
    {
      this.CloseProject();
    }

    private void menuFile_RecentProjects_DropDownOpening(object sender, EventArgs e)
    {
      this.menuFile_RecentProjects.DropDownItems.Clear();
      SolutionInfoList recentSolutions = Global.ProjectManager.RecentSolutions;
      if (recentSolutions.Count == 0)
      {
        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("(Empty)");
        toolStripMenuItem.Enabled = false;
        this.menuFile_RecentProjects.DropDownItems.Add((ToolStripItem) toolStripMenuItem);
      }
      else
      {
        for (int index = 0; index < recentSolutions.Count; ++index)
          this.menuFile_RecentProjects.DropDownItems.Add((ToolStripItem) new ProjectInfoMenuItem(index + 1, recentSolutions[index]));
      }
    }

    private void menuFile_RecentProjects_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      Global.ProjectManager.Open((e.ClickedItem as ProjectInfoMenuItem).Project.File);
    }

    private void menuFile_Exit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void menuView_Instruments_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (InstrumentListWindow));
    }

    private void menuView_Indicators_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (IndicatorListWindow));
    }

    private void menuView_OrderManager_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (OrderManagerWindow));
    }

    private void menuView_Portfolio_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PortfolioWindow), (object) OpenQuant.Config.Configuration.get_Active().get_Portfolio());
    }

    private void menuView_BrokerInfo_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (BrokerInfoWindow));
    }

    private void menuView_Providers_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (ProviderListWindow));
    }

    private void menuView_ProviderErrors_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (ProviderErrorListWindow));
    }

    private void menuView_SolutionExplorer_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (SolutionExplorerWindow));
    }

    private void menuView_ScriptExplorer_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (ScriptExplorerWindow));
    }

    private void menuView_QuoteMonitor_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (QuoteMonitorWindow));
    }

    private void menuView_Other_StartPage_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (StartPageWindow));
    }

    private void menuView_Toolbars_DropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
    {
      if (e.CloseReason != ToolStripDropDownCloseReason.ItemClicked)
        return;
      e.Cancel = true;
    }

    private void menuView_Toolbars_DropDownOpening(object sender, EventArgs e)
    {
      this.menuView_Toolbars.DropDownItems.Clear();
      this.menuView_Toolbars.DropDownItems.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) new ToolbarMenuItem(Global.Toolbar.File),
        (ToolStripItem) new ToolbarMenuItem(Global.Toolbar.Edit),
        (ToolStripItem) new ToolbarMenuItem(Global.Toolbar.View),
        (ToolStripItem) new ToolbarMenuItem(Global.Toolbar.Project),
        (ToolStripItem) new ToolbarMenuItem(Global.Toolbar.ProjectView),
        (ToolStripItem) new ToolbarMenuItem((ToolStrip) Global.Toolbar.Chart),
        (ToolStripItem) new ToolbarMenuItem((ToolStrip) Global.Toolbar.InstrumentList)
      });
    }

    private void menuView_Output_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (OutputWindow));
    }

    private void menuView_Properties_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PropertiesWindow));
    }

    private void menuSolution_Build_Click(object sender, EventArgs e)
    {
      this.BuildProject();
    }

    private void menuSolution_ManageReferences_Click(object sender, EventArgs e)
    {
      OptionsForm optionsForm = new OptionsForm();
      optionsForm.SetSelectedOptionsType(typeof (BuildOptions));
      int num = (int) ((Form) optionsForm).ShowDialog((IWin32Window) this);
      ((Component) optionsForm).Dispose();
    }

    private void menuSolution_Optimize_Click(object sender, EventArgs e)
    {
      this.OptimizeSolution();
    }

    private void menuSolution_Run_Click(object sender, EventArgs e)
    {
      this.RunProject();
    }

    private void menuSolution_Pause_Click(object sender, EventArgs e)
    {
      this.PauseProject();
    }

    private void menuSolution_Stop_Click(object sender, EventArgs e)
    {
      this.StopProject();
    }

    private void menuSolution_ExportToQT_Click(object sender, EventArgs e)
    {
      ExportToQuantTraderForm toQuantTraderForm = new ExportToQuantTraderForm();
      toQuantTraderForm.Init(Global.ProjectManager.ActiveSolution);
      int num = (int) toQuantTraderForm.ShowDialog((IWin32Window) this);
      toQuantTraderForm.Dispose();
    }

    private void menuSolution_UpdateUI_Click(object sender, EventArgs e)
    {
      this.SetUpdateUIFlag(this.menuSolution_UpdateUI.Checked);
    }

    private void menuSolution_ViewBarChart_Click(object sender, EventArgs e)
    {
      this.ViewProjectBarChart();
    }

    private void menuSolution_ViewResults_Click(object sender, EventArgs e)
    {
      this.ViewProjectResults();
    }

    private void menuSolution_ViewPerformance_Click(object sender, EventArgs e)
    {
      this.ViewProjectPerformance();
    }

    private void menuSolution_ViewMarketScanner_Click(object sender, EventArgs e)
    {
      this.ViewProjectMarketScanner();
    }

    private void menuSolution_ViewStrategyLogs_Click(object sender, EventArgs e)
    {
      this.ViewProjectLogs();
    }

    private void menuData_Manager_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (DataManagerWindow));
    }

    private void menuData_QuantBaseExplorer_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (QuantBaseExplorerWindow));
    }

    private void menuData_Import_CSV_Click(object sender, EventArgs e)
    {
      ImportWizardForm importWizardForm = new ImportWizardForm(Global.Setup.Folders.Ini);
      int num = (int) ((Form) importWizardForm).ShowDialog((IWin32Window) this);
      ((Component) importWizardForm).Dispose();
    }

    private void menuData_Import_TAQ_Click(object sender, EventArgs e)
    {
      TAQImportForm taqImportForm = new TAQImportForm();
      int num = (int) ((Form) taqImportForm).ShowDialog((IWin32Window) this);
      ((Component) taqImportForm).Dispose();
    }

    private void menuData_Import_NxCore_Click(object sender, EventArgs e)
    {
      ImportWizard.Run((IWin32Window) this);
    }

    private void menuData_Import_Instruments_DropDownOpening(object sender, EventArgs e)
    {
      this.menuData_Import_Instruments.DropDownItems.Clear();
      foreach (IProvider provider in (ProviderList) ProviderManager.InstrumentProviders)
      {
        ProviderMenuItem providerMenuItem = new ProviderMenuItem(provider);
        providerMenuItem.Click += new EventHandler(this.menuData_Import_Instruments_Click);
        this.menuData_Import_Instruments.DropDownItems.Add((ToolStripItem) providerMenuItem);
      }
      if (this.menuData_Import_Instruments.DropDownItems.Count != 0)
        return;
      this.menuData_Import_Instruments.DropDownItems.Add((ToolStripItem) new EmptyListMenuItem());
    }

    private void menuData_Import_Instruments_Click(object sender, EventArgs e)
    {
      IInstrumentProvider instrumentProvider = (sender as ProviderMenuItem).ProviderAsInstrumentProvider;
      InstrumentImportForm instrumentImportForm = new InstrumentImportForm();
      instrumentImportForm.Init(instrumentProvider);
      int num = (int) ((Form) instrumentImportForm).ShowDialog((IWin32Window) this);
      ((Component) instrumentImportForm).Dispose();
    }

    private void menuData_Import_Realtime_DropDownOpening(object sender, EventArgs e)
    {
      this.menuData_Import_Realtime.DropDownItems.Clear();
      foreach (IProvider provider in (ProviderList) ProviderManager.MarketDataProviders)
      {
        if (provider != ProviderManager.MarketDataSimulator)
        {
          ProviderMenuItem providerMenuItem = new ProviderMenuItem(provider);
          providerMenuItem.Click += new EventHandler(this.menuData_Import_Realtime_Click);
          this.menuData_Import_Realtime.DropDownItems.Add((ToolStripItem) providerMenuItem);
        }
      }
      if (this.menuData_Import_Realtime.DropDownItems.Count != 0)
        return;
      this.menuData_Import_Realtime.DropDownItems.Add((ToolStripItem) new EmptyListMenuItem());
    }

    private void menuData_Import_Realtime_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (DataCaptureWindow), (object) (sender as ProviderMenuItem).ProviderAsMarketDataProvider);
    }

    private void menuData_Import_Historical_DropDownOpening(object sender, EventArgs e)
    {
      this.menuData_Import_Historical.DropDownItems.Clear();
      foreach (IProvider provider in (ProviderList) ProviderManager.HistoricalDataProviders)
      {
        ProviderMenuItem providerMenuItem = new ProviderMenuItem(provider);
        providerMenuItem.Click += new EventHandler(this.menuData_Import_Historical_Click);
        this.menuData_Import_Historical.DropDownItems.Add((ToolStripItem) providerMenuItem);
      }
      if (this.menuData_Import_Historical.DropDownItems.Count != 0)
        return;
      this.menuData_Import_Historical.DropDownItems.Add((ToolStripItem) new EmptyListMenuItem());
    }

    private void menuData_Import_Historical_Click(object sender, EventArgs e)
    {
      IHistoricalDataProvider historicalDataProvider = (sender as ProviderMenuItem).ProviderAsHistoricalDataProvider;
      if (!historicalDataProvider.IsConnected)
      {
        if (MessageBox.Show((IWin32Window) this, string.Format("{0} is not connected. Do you want to connect?", (object) historicalDataProvider.Name), "Not Connected.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        Global.get_ProviderHelper().Connect((IProvider) historicalDataProvider);
      }
      if (!historicalDataProvider.IsConnected)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, "Unable to connect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        DownloadForm downloadForm = new DownloadForm();
        downloadForm.SetProvider(historicalDataProvider);
        int num2 = (int) ((Form) downloadForm).ShowDialog((IWin32Window) this);
        ((Component) downloadForm).Dispose();
      }
    }

    private void menuData_CompressBars_Click(object sender, EventArgs e)
    {
      List<IDataSeries> list = new List<IDataSeries>();
      foreach (Instrument instrument in (FIXGroupList) InstrumentManager.Instruments)
      {
        foreach (IDataSeries dataSeries in instrument.GetDataSeries())
          list.Add(dataSeries);
      }
      CompressBarsForm compressBarsForm = new CompressBarsForm();
      compressBarsForm.Init(list.ToArray(), false);
      int num = (int) ((Form) compressBarsForm).ShowDialog((IWin32Window) this);
      ((Component) compressBarsForm).Dispose();
    }

    private void menuTools_ChartColorManager_Click(object sender, EventArgs e)
    {
      ChartColorManagerForm colorManagerForm = new ChartColorManagerForm();
      int num = (int) ((Form) colorManagerForm).ShowDialog((IWin32Window) this);
      ((Component) colorManagerForm).Dispose();
    }

    private void menuTools_PerformanceMonitor_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PerformanceMonitorWindow));
    }

    private void menuTools_Options_Click(object sender, EventArgs e)
    {
      ConfigurationMode activeMode = OpenQuant.Config.Configuration.get_ActiveMode();
      bool persistent = OpenQuant.Config.Configuration.get_Active().get_Persistent();
      OptionsForm optionsForm = new OptionsForm();
      int num = (int) ((Form) optionsForm).ShowDialog((IWin32Window) this);
      ((Component) optionsForm).Dispose();
      if (activeMode == OpenQuant.Config.Configuration.get_ActiveMode() && persistent != OpenQuant.Config.Configuration.get_Active().get_Persistent() && Global.ProjectManager.ActiveSolution != null)
        Global.ProjectManager.ActiveSolution.UpdatePortfoliosPersistent();
      this.UpdateStatusMode();
    }

    private void menuWindow_DropDownOpening(object sender, EventArgs e)
    {
      int index = 0;
      while (index < this.menuWindow.DropDownItems.Count)
      {
        if (this.menuWindow.DropDownItems[index] is WindowMenuItem || this.menuWindow.DropDownItems[index] is WindowsMenuItem)
          this.menuWindow.DropDownItems.RemoveAt(index);
        else
          ++index;
      }
      List<WindowMenuItem> list = new List<WindowMenuItem>();
      foreach (DockControl control in ((SandDockManager) Global.get_DockManager()).get_Documents())
      {
        if (control.get_IsTabbedDocument())
          list.Add(new WindowMenuItem(control));
      }
      this.menuWindow.DropDownItems.AddRange((ToolStripItem[]) list.ToArray());
      this.menuWindow.DropDownItems.Add((ToolStripItem) new WindowsMenuItem());
    }

    private void menuWindow_CloseAllDocuments_Click(object sender, EventArgs e)
    {
      List<DockControl> list = new List<DockControl>();
      foreach (DockControl dockControl in ((SandDockManager) Global.get_DockManager()).get_Documents())
      {
        if (dockControl.get_IsTabbedDocument())
          list.Add(dockControl);
      }
      using (List<DockControl>.Enumerator enumerator = list.GetEnumerator())
      {
        while (enumerator.MoveNext())
          enumerator.Current.Close();
      }
    }

    private void menuHelp_GettingStarted_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(string.Format("{0}\\OpenQuant Getting Started.pdf", (object) Global.Setup.Folders.get_Help().FullName));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void menuHelp_StrategyDevelopment_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(string.Format("{0}\\OpenQuant Strategy Development.pdf", (object) Global.Setup.Folders.get_Help().FullName));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void menuHelp_API_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(string.Format("{0}\\OpenQuant.API.chm", (object) Global.Setup.Folders.get_Help().FullName));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void menuHelp_FAQ_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(string.Format("{0}\\OpenQuant FAQ.pdf", (object) Global.Setup.Folders.get_Help().FullName));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void menuHelp_CheckForUpdates_Click(object sender, EventArgs e)
    {
      string str = ConfigurationManager.AppSettings["rnURL"];
      CheckForUpdatesForm checkForUpdatesForm = new CheckForUpdatesForm();
      checkForUpdatesForm.Init(str);
      int num = (int) ((Form) checkForUpdatesForm).ShowDialog((IWin32Window) this);
      ((Component) checkForUpdatesForm).Dispose();
    }

    private void menuHelp_About_Click(object sender, EventArgs e)
    {
      AboutForm aboutForm = new AboutForm();
      int num = (int) ((Form) aboutForm).ShowDialog((IWin32Window) this);
      ((Component) aboutForm).Dispose();
    }

    private void menuFile_NewSolution_Click(object sender, EventArgs e)
    {
      this.NewSolution();
    }

    private void menuFile_NewProject_Click_1(object sender, EventArgs e)
    {
      this.NewProject();
    }

    private void menuFile_OpenSolution_Click(object sender, EventArgs e)
    {
      this.OpenSolution();
    }

    private void menuFile_OpenProject_Click_1(object sender, EventArgs e)
    {
      this.OpenProject();
    }

    private void tsbFile_New_Solution_Click(object sender, EventArgs e)
    {
      this.NewSolution();
    }

    private void tsbFile_New_Project_Click(object sender, EventArgs e)
    {
      this.NewProject();
    }

    private void tsbFile_Open_Solution_Click(object sender, EventArgs e)
    {
      this.OpenSolution();
    }

    private void tsbFile_Open_Project_Click(object sender, EventArgs e)
    {
      this.OpenProject();
    }

    private void tsbMode_Simulation_Click(object sender, EventArgs e)
    {
      this.SetActiveMode((ConfigurationMode) 0);
    }

    private void tsbMode_Paper_Click(object sender, EventArgs e)
    {
      this.SetActiveMode((ConfigurationMode) 1);
    }

    private void tsbMode_Live_Click(object sender, EventArgs e)
    {
      this.SetActiveMode((ConfigurationMode) 2);
    }

    private void SetActiveMode(ConfigurationMode mode)
    {
      if (MessageBox.Show((IWin32Window) this, string.Format("Are you sure to switch from {0} to {1} mode?", (object) OpenQuant.Config.Configuration.get_ActiveMode(), (object) mode), "Change Active Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      OpenQuant.Config.Configuration.set_ActiveMode(mode);
    }

    private void Configuration_ConfigurationModeChanging(object sender, ConfigurationModeChangingEventArgs args)
    {
      OpenQuant.Config.Configuration.get_Active().get_Portfolio().Monitored = false;
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new EventHandler(this.Configuration_ConfigurationModeChanged), sender, (object) e);
      }
      else
      {
        if (Global.ProjectManager.ActiveSolution != null)
          Global.ProjectManager.ActiveSolution.UpdatePortfolios();
        OpenQuant.Config.Configuration.get_Active().get_Portfolio().Monitored = true;
        this.UpdateActiveModeButton();
        this.UpdateStatusMode();
      }
    }

    private void UpdateStatusMode()
    {
      ToolStripItem toolStripItem1 = this.statusStrip.Items[1];
      switch ((int) OpenQuant.Config.Configuration.get_ActiveMode())
      {
        case 0:
          toolStripItem1.Image = (Image) Resources.mode_simulation;
          toolStripItem1.Text = "";
          break;
        case 1:
          toolStripItem1.Image = (Image) Resources.mode_paper;
          toolStripItem1.Text = OpenQuant.Config.Configuration.get_Active().get_MarketDataProvider().Name;
          break;
        case 2:
          toolStripItem1.Image = (Image) Resources.mode_live;
          toolStripItem1.Text = OpenQuant.Config.Configuration.get_Active().get_MarketDataProvider() != OpenQuant.Config.Configuration.get_Active().get_ExecutionProvider() ? OpenQuant.Config.Configuration.get_Active().get_MarketDataProvider().Name + " : " + OpenQuant.Config.Configuration.get_Active().get_ExecutionProvider().Name : OpenQuant.Config.Configuration.get_Active().get_MarketDataProvider().Name;
          break;
      }
      ToolStripItem toolStripItem2 = toolStripItem1;
      string str = toolStripItem2.Text + "  ";
      toolStripItem2.Text = str;
    }

    private void UpdateActiveModeButton()
    {
      switch ((int) OpenQuant.Config.Configuration.get_ActiveMode())
      {
        case 0:
          this.UpdateActiveModeButton(this.tsbMode_Simulation);
          break;
        case 1:
          this.UpdateActiveModeButton(this.tsbMode_Paper);
          break;
        case 2:
          this.UpdateActiveModeButton(this.tsbMode_Live);
          break;
        default:
          throw new NotSupportedException(string.Format("Unknown configuration mode - {0}", (object) OpenQuant.Config.Configuration.get_ActiveMode()));
      }
    }

    private void UpdateActiveModeButton(ToolStripMenuItem item)
    {
      this.tsbMode.Text = item.Text;
      this.tsbMode.Image = item.Image;
      this.tsbMode.ToolTipText = "Click to change active configuration mode.";
    }

    private void DockManager_DockControlActivated(object sender, DockControlEventArgs e)
    {
      this.Text = e.get_DockControl() == null ? Global.Setup.get_Product().get_Name() : string.Format("{0} - {1}", (object) Global.Setup.get_Product().get_Name(), (object) e.get_DockControl().get_TabText());
    }

    private void tsbFile_NewProject_Click(object sender, EventArgs e)
    {
      this.NewSolution();
    }

    private void tsbFile_OpenProject_Click(object sender, EventArgs e)
    {
      this.OpenProject();
    }

    private void tsbView_Instruments_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (InstrumentListWindow));
    }

    private void tsbView_Indicators_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (IndicatorListWindow));
    }

    private void tsbView_OrderManager_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (OrderManagerWindow));
    }

    private void tsbView_Portfolio_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PortfolioWindow), (object) OpenQuant.Config.Configuration.get_Active().get_Portfolio());
    }

    private void tsbView_BrokerInfo_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (BrokerInfoWindow));
    }

    private void tsbView_Providers_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (ProviderListWindow));
    }

    private void tsbView_ProviderErrors_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (ProviderErrorListWindow));
    }

    private void tsbView_SolutionExplorer_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (SolutionExplorerWindow));
    }

    private void tsbView_ScriptExplorer_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (ScriptExplorerWindow));
    }

    private void tsbView_QuoteMonitor_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (QuoteMonitorWindow));
    }

    private void tsbView_Output_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (OutputWindow));
    }

    private void tsbView_Properties_Click(object sender, EventArgs e)
    {
      Global.get_DockManager().Open(typeof (PropertiesWindow));
    }

    private void tsbSolution_Build_Click(object sender, EventArgs e)
    {
      this.BuildProject();
    }

    private void tsbSolution_Run_Click(object sender, EventArgs e)
    {
      this.RunProject();
    }

    private void tsbSolution_Pause_Click(object sender, EventArgs e)
    {
      this.PauseProject();
    }

    private void tsbSolution_Stop_Click(object sender, EventArgs e)
    {
      this.StopProject();
    }

    private void tsbSolution_UpdateUI_Click(object sender, EventArgs e)
    {
      this.SetUpdateUIFlag(this.tsbSolution_UpdateUI.Checked);
    }

    private void tsbSolutionView_BarChart_Click(object sender, EventArgs e)
    {
      this.ViewProjectBarChart();
    }

    private void tsbSolutionView_Results_Click(object sender, EventArgs e)
    {
      this.ViewProjectResults();
    }

    private void tsbSolutionView_Performance_Click(object sender, EventArgs e)
    {
      this.ViewProjectPerformance();
    }

    private void tsbSolutionView_MarketScanner_Click(object sender, EventArgs e)
    {
      this.ViewProjectMarketScanner();
    }

    private void tsbSolutionView_StrategyLogs_Click(object sender, EventArgs e)
    {
      this.ViewProjectLogs();
    }

    private void ProjectManager_SolutionOpened(object sender, EventArgs e)
    {
      this.UpdateProjectControls();
    }

    private void ProjectManager_SolutionClosed(object sender, EventArgs e)
    {
      this.CloseProjectWindows();
      this.UpdateProjectControls();
    }

    private void Runner_Starting(object sender, EventArgs e)
    {
      this.Invoke((Delegate) (() =>
      {
        this.EnableProjectItems((ToolStripItem) this.menuSolution_ViewBarChart, (ToolStripItem) this.menuSolution_ViewResults, (ToolStripItem) this.menuSolution_ViewPerformance, (ToolStripItem) this.menuSolution_ViewMarketScanner, (ToolStripItem) this.tsbSolutionView_BarChart, (ToolStripItem) this.tsbSolutionView_Results, (ToolStripItem) this.tsbSolutionView_Performance, (ToolStripItem) this.tsbSolutionView_MarketScanner);
        this.DisableProjectItems((ToolStripItem) this.menuFile_New, (ToolStripItem) this.menuFile_Open, (ToolStripItem) this.menuFile_CloseProject, (ToolStripItem) this.menuFile_RecentProjects, (ToolStripItem) this.tsbFile_New, (ToolStripItem) this.tsbFile_Open, (ToolStripItem) this.menuSolution_Build, (ToolStripItem) this.menuSolution_Run, (ToolStripItem) this.menuSolution_Pause, (ToolStripItem) this.menuSolution_Stop, (ToolStripItem) this.menuSolution_Optimize, (ToolStripItem) this.menuSolution_ExportToQT, (ToolStripItem) this.menuSolution_UpdateUI, (ToolStripItem) this.tsbSolution_Build, (ToolStripItem) this.tsbSolution_Run, (ToolStripItem) this.tsbSolution_Pause, (ToolStripItem) this.tsbSolution_Stop, (ToolStripItem) this.tsbSolution_UpdateUI, (ToolStripItem) this.tsbMode);
      }));
    }

    private void Runner_Started(object sender, EventArgs e)
    {
      this.Invoke((Delegate) (() =>
      {
        this.EnableProjectItems((ToolStripItem) this.menuSolution_Pause, (ToolStripItem) this.menuSolution_Stop, (ToolStripItem) this.menuSolution_ViewBarChart, (ToolStripItem) this.menuSolution_ViewResults, (ToolStripItem) this.menuSolution_ViewPerformance, (ToolStripItem) this.menuSolution_ViewMarketScanner, (ToolStripItem) this.tsbSolution_Pause, (ToolStripItem) this.tsbSolution_Stop, (ToolStripItem) this.tsbSolutionView_BarChart, (ToolStripItem) this.tsbSolutionView_Results, (ToolStripItem) this.tsbSolutionView_Performance, (ToolStripItem) this.tsbSolutionView_MarketScanner);
        this.DisableProjectItems((ToolStripItem) this.menuFile_New, (ToolStripItem) this.menuFile_Open, (ToolStripItem) this.menuFile_CloseProject, (ToolStripItem) this.menuFile_RecentProjects, (ToolStripItem) this.tsbFile_New, (ToolStripItem) this.tsbFile_Open, (ToolStripItem) this.menuSolution_Build, (ToolStripItem) this.menuSolution_Run, (ToolStripItem) this.menuSolution_Optimize, (ToolStripItem) this.menuSolution_ExportToQT, (ToolStripItem) this.menuSolution_UpdateUI, (ToolStripItem) this.tsbSolution_Build, (ToolStripItem) this.tsbSolution_Run, (ToolStripItem) this.tsbSolution_UpdateUI, (ToolStripItem) this.tsbMode);
      }));
    }

    private void Runner_Stopping(object sender, EventArgs e)
    {
      this.Invoke((Delegate) (() =>
      {
        this.EnableProjectItems((ToolStripItem) this.menuSolution_ViewBarChart, (ToolStripItem) this.menuSolution_ViewResults, (ToolStripItem) this.menuSolution_ViewPerformance, (ToolStripItem) this.menuSolution_ViewMarketScanner, (ToolStripItem) this.tsbSolutionView_BarChart, (ToolStripItem) this.tsbSolutionView_Results, (ToolStripItem) this.tsbSolutionView_Performance, (ToolStripItem) this.tsbSolutionView_MarketScanner);
        this.DisableProjectItems((ToolStripItem) this.menuFile_New, (ToolStripItem) this.menuFile_Open, (ToolStripItem) this.menuFile_CloseProject, (ToolStripItem) this.menuFile_RecentProjects, (ToolStripItem) this.tsbFile_New, (ToolStripItem) this.tsbFile_Open, (ToolStripItem) this.menuSolution_Build, (ToolStripItem) this.menuSolution_Run, (ToolStripItem) this.menuSolution_Pause, (ToolStripItem) this.menuSolution_Stop, (ToolStripItem) this.menuSolution_Optimize, (ToolStripItem) this.menuSolution_ExportToQT, (ToolStripItem) this.menuSolution_UpdateUI, (ToolStripItem) this.tsbSolution_Build, (ToolStripItem) this.tsbSolution_Run, (ToolStripItem) this.tsbSolution_Pause, (ToolStripItem) this.tsbSolution_Stop, (ToolStripItem) this.tsbSolution_UpdateUI, (ToolStripItem) this.tsbMode);
      }));
    }

    private void Runner_Stopped(object sender, EventArgs e)
    {
      this.Invoke((Delegate) (() =>
      {
        this.EnableProjectItems((ToolStripItem) this.menuFile_New, (ToolStripItem) this.menuFile_Open, (ToolStripItem) this.menuFile_CloseProject, (ToolStripItem) this.menuFile_RecentProjects, (ToolStripItem) this.tsbFile_New, (ToolStripItem) this.tsbFile_Open, (ToolStripItem) this.menuSolution_Build, (ToolStripItem) this.menuSolution_Run, (ToolStripItem) this.menuSolution_Optimize, (ToolStripItem) this.menuSolution_ExportToQT, (ToolStripItem) this.menuSolution_UpdateUI, (ToolStripItem) this.menuSolution_ViewBarChart, (ToolStripItem) this.menuSolution_ViewResults, (ToolStripItem) this.menuSolution_ViewPerformance, (ToolStripItem) this.menuSolution_ViewMarketScanner, (ToolStripItem) this.tsbSolution_Build, (ToolStripItem) this.tsbSolution_Run, (ToolStripItem) this.tsbSolution_UpdateUI, (ToolStripItem) this.tsbSolutionView_BarChart, (ToolStripItem) this.tsbSolutionView_Results, (ToolStripItem) this.tsbSolutionView_Performance, (ToolStripItem) this.tsbSolutionView_MarketScanner, (ToolStripItem) this.tsbMode);
        this.DisableProjectItems((ToolStripItem) this.menuSolution_Pause, (ToolStripItem) this.menuSolution_Stop, (ToolStripItem) this.tsbSolution_Pause, (ToolStripItem) this.tsbSolution_Stop);
        if (!Global.Flags.UpdateUI)
        {
          foreach (DockControl item_0 in Global.get_DockManager().GetDockControls())
          {
            if (item_0 is IUpdateUI)
              ((IUpdateUI) item_0).UpdateUI();
          }
        }
        switch (Global.Options.Solutions.PostRunAction)
        {
          case PostRunAction.None:
            break;
          case PostRunAction.ShowPortfolio:
            Global.get_DockManager().Open(typeof (PortfolioWindow), (object) OpenQuant.Config.Configuration.get_Active().get_Portfolio());
            break;
          case PostRunAction.ShowOrders:
            Global.get_DockManager().Open(typeof (OrderManagerWindow));
            break;
          case PostRunAction.ShowPerformance:
            Global.get_DockManager().Open(typeof (PerformanceWindow), (object) OpenQuant.Config.Configuration.get_Active().get_Portfolio());
            break;
          case PostRunAction.ShowChart:
            Global.get_DockManager().Open(typeof (BarChart), (object) new KeyValuePair<StrategyProject, Instrument>());
            break;
          default:
            throw new NotSupportedException(string.Format("Unknown post run action - {0}", (object) Global.Options.Solutions.PostRunAction));
        }
      }));
    }

    private void Runner_Error(object sender, RunnerErrorEventArgs e)
    {
      int num;
      this.Invoke((Delegate) (() => num = (int) MessageBox.Show((IWin32Window) this, e.Error.Text, "Runner Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
    }

    private void ScriptManager_Error(object sender, ScriptRunnerErrorEventArgs e)
    {
      int num;
      this.Invoke((Delegate) (() => num = (int) MessageBox.Show((IWin32Window) this, ((object) e.get_Error().get_Exception()).ToString(), "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
    }

    private void UpdateProjectControls()
    {
      if (Global.ProjectManager.ActiveSolution == null)
      {
        this.menuSolution.Visible = false;
        this.EnableProjectItems((ToolStripItem) this.menuFile_New, (ToolStripItem) this.menuFile_Open, (ToolStripItem) this.tsbFile_New, (ToolStripItem) this.tsbFile_Open);
        this.DisableProjectItems((ToolStripItem) this.menuFile_CloseProject, (ToolStripItem) this.menuSolution_Build, (ToolStripItem) this.menuSolution_Run, (ToolStripItem) this.menuSolution_Pause, (ToolStripItem) this.menuSolution_Stop, (ToolStripItem) this.menuSolution_UpdateUI, (ToolStripItem) this.menuSolution_ViewBarChart, (ToolStripItem) this.menuSolution_ViewResults, (ToolStripItem) this.menuSolution_ViewPerformance, (ToolStripItem) this.menuSolution_ViewMarketScanner, (ToolStripItem) this.menuSolution_ViewStrategyLogs, (ToolStripItem) this.tsbSolution_Build, (ToolStripItem) this.tsbSolution_Run, (ToolStripItem) this.tsbSolution_Pause, (ToolStripItem) this.tsbSolution_Stop, (ToolStripItem) this.tsbSolution_UpdateUI, (ToolStripItem) this.tsbSolutionView_BarChart, (ToolStripItem) this.tsbSolutionView_Results, (ToolStripItem) this.tsbSolutionView_Performance, (ToolStripItem) this.tsbSolutionView_MarketScanner, (ToolStripItem) this.tsbSolutionView_StrategyLogs);
      }
      else
      {
        this.menuSolution.Visible = true;
        this.EnableProjectItems((ToolStripItem) this.menuFile_New, (ToolStripItem) this.menuFile_Open, (ToolStripItem) this.menuFile_CloseProject, (ToolStripItem) this.tsbFile_New, (ToolStripItem) this.tsbFile_Open, (ToolStripItem) this.menuSolution_Build, (ToolStripItem) this.menuSolution_Run, (ToolStripItem) this.menuSolution_UpdateUI, (ToolStripItem) this.menuSolution_ViewBarChart, (ToolStripItem) this.menuSolution_ViewResults, (ToolStripItem) this.menuSolution_ViewPerformance, (ToolStripItem) this.menuSolution_ViewMarketScanner, (ToolStripItem) this.menuSolution_ViewStrategyLogs, (ToolStripItem) this.tsbSolution_Build, (ToolStripItem) this.tsbSolution_Run, (ToolStripItem) this.tsbSolution_UpdateUI, (ToolStripItem) this.tsbSolutionView_BarChart, (ToolStripItem) this.tsbSolutionView_Results, (ToolStripItem) this.tsbSolutionView_Performance, (ToolStripItem) this.tsbSolutionView_MarketScanner, (ToolStripItem) this.tsbSolutionView_StrategyLogs);
        this.DisableProjectItems((ToolStripItem) this.menuSolution_Pause, (ToolStripItem) this.menuSolution_Stop, (ToolStripItem) this.tsbSolution_Pause, (ToolStripItem) this.tsbSolution_Stop);
      }
    }

    private void EnableProjectItems(params ToolStripItem[] items)
    {
      foreach (ToolStripItem toolStripItem in items)
        toolStripItem.Enabled = true;
    }

    private void DisableProjectItems(params ToolStripItem[] items)
    {
      foreach (ToolStripItem toolStripItem in items)
        toolStripItem.Enabled = false;
    }

    public void CloseProjectWindows()
    {
      using (List<DockControl>.Enumerator enumerator = new List<DockControl>((IEnumerable<DockControl>) Global.get_DockManager().GetDockControls()).GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          DockControl current = enumerator.Current;
          bool flag = false;
          if (current is BarChart || current is PortfolioWindow || (current is ResultsWindow || current is PerformanceWindow) || (current is MarketScanerWindow || current is UserCommandsWindow || current is StrategyMonitorWindow))
            flag = true;
          if (current is ProjectEditorWindow && !(current is ScriptEditorWindow))
            flag = true;
          if (flag)
            ((DockControl) current).Close();
        }
      }
      Global.get_ToolWindowManager().CloseErrorList();
    }

    private void NewProject()
    {
      NewProjectDialog newProjectDialog = new NewProjectDialog((string) null);
      if (newProjectDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        Global.ProjectManager.CreateNewProject(newProjectDialog.SolutionFile, newProjectDialog.SolutionName, newProjectDialog.ProjectFile, newProjectDialog.CodeLang, newProjectDialog.ProjectName, newProjectDialog.ProjectDescription);
        Global.get_DockManager().Open(typeof (SolutionExplorerWindow));
      }
      newProjectDialog.Dispose();
    }

    private void NewSolution()
    {
      Global.ProjectManager.CreateNewSolution();
    }

    private void OpenProject()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Multiselect = false;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = "OpenQuant projects|*.oqp";
      openFileDialog.InitialDirectory = Global.Setup.Folders.Projects.FullName;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        Global.ProjectManager.Open(new FileInfo(openFileDialog.FileName));
        Global.get_DockManager().Open(typeof (SolutionExplorerWindow));
      }
      openFileDialog.Dispose();
    }

    private void OpenSolution()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Multiselect = false;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = "OpenQuant solutions|*.oqs";
      openFileDialog.InitialDirectory = Global.Setup.Folders.Solutions.FullName;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        Global.ProjectManager.Open(new FileInfo(openFileDialog.FileName));
        Global.get_DockManager().Open(typeof (SolutionExplorerWindow));
      }
      openFileDialog.Dispose();
    }

    private void CloseProject()
    {
      Global.ProjectManager.CloseActiveSolution();
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

    private void OptimizeSolution()
    {
      if (!this.BuildProject())
        return;
      OptmizationDialog optmizationDialog = new OptmizationDialog();
      if (optmizationDialog.ShowDialog() != DialogResult.OK)
        return;
      Global.get_DockManager().Open(typeof (OptimizationWindow));
      Runner.Start(Global.ProjectManager.ActiveSolution, optmizationDialog.StrategyOptimizer);
    }

    private void RunProject()
    {
      if (!this.BuildProject())
        return;
      Global.get_ToolWindowManager().ClearOutput();
      if (!Global.ProjectManager.ActiveSolution.Validate() || !IDEHelper.DoRunStrategy())
        return;
      Runner.Start(Global.ProjectManager.ActiveSolution);
    }

    private void PauseProject()
    {
    }

    private void StopProject()
    {
      Runner.Stop(true);
    }

    private void ViewProjectBarChart()
    {
      Global.get_DockManager().Open(typeof (BarChart), (object) new KeyValuePair<StrategyProject, Instrument>((StrategyProject) null, (Instrument) null));
    }

    private void ViewProjectResults()
    {
      Global.get_DockManager().Open(typeof (ResultsWindow), (object) Global.ProjectManager.ActiveSolution);
    }

    private void ViewProjectPerformance()
    {
      Global.get_DockManager().Open(typeof (PerformanceWindow), (object) OpenQuant.Config.Configuration.get_Active().get_Portfolio());
    }

    private void ViewProjectMarketScanner()
    {
      Global.get_DockManager().Open(typeof (MarketScanerWindow), (object) Global.ProjectManager.ActiveSolution);
    }

    private void ViewProjectLogs()
    {
      Global.get_DockManager().Open(typeof (StrategyMonitorWindow), (object) Global.ProjectManager.ActiveSolution.SolutionRunner.get_StrategyLogManager());
    }

    private void SetUpdateUIFlag(bool value)
    {
      Global.Flags.UpdateUIRawValue = value;
      this.menuSolution_UpdateUI.Checked = value;
      this.tsbSolution_UpdateUI.Checked = value;
    }

    private void CheckConfigurationModes()
    {
      bool flag = true;
      using (Dictionary<ConfigurationMode, ConfigurationInfo>.ValueCollection.Enumerator enumerator = ((Dictionary<ConfigurationMode, ConfigurationInfo>) OpenQuant.Config.Configuration.GetConfigurations()).Values.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          ConfigurationInfo current = enumerator.Current;
          if (current.get_MarketDataProvider() == null || current.get_ExecutionProvider() == null)
          {
            flag = false;
            break;
          }
        }
      }
      if (flag || ProviderManager.MarketDataProviders.Count <= 1 || ProviderManager.ExecutionProviders.Count <= 1)
        return;
      RepairConfigurationsForm configurationsForm = new RepairConfigurationsForm();
      if (configurationsForm.ShowDialog((IWin32Window) this) == DialogResult.Abort)
        Environment.Exit(0);
      else
        configurationsForm.Dispose();
    }

    private void CheckForUpdates(object state)
    {
      Thread.Sleep(TimeSpan.FromSeconds(3.0));
      try
      {
        ReleaseInfo[] releases = new UpdateManager().GetReleases(ConfigurationManager.AppSettings["rnURL"]);
        if (releases.Length == 0 || !(releases[0].get_Version() > Global.Setup.get_Product().get_Version()))
          return;
        this.Invoke((Delegate) (() =>
        {
          this.ntiUpdates.Tag = (object) releases;
          this.ntiUpdates.BalloonTipIcon = ToolTipIcon.Info;
          this.ntiUpdates.BalloonTipText = "New version of OpenQuant is available. Click icon for details...";
          this.ntiUpdates.Visible = true;
          this.ntiUpdates.ShowBalloonTip((int) TimeSpan.FromSeconds(7.0).TotalMilliseconds);
        }));
      }
      catch (Exception ex)
      {
        IDE ide = this;
        this.Invoke((Delegate) (() =>
        {
          ide.ntiUpdates.Tag = (object) ex;
          ide.ntiUpdates.BalloonTipIcon = ToolTipIcon.Warning;
          ide.ntiUpdates.BalloonTipText = "Error checking for updates. Click icon for details...";
          ide.ntiUpdates.Visible = true;
          ide.ntiUpdates.ShowBalloonTip((int) TimeSpan.FromSeconds(7.0).TotalMilliseconds);
        }));
      }
    }

    private void ntiUpdates_Click(object sender, EventArgs e)
    {
      this.OnUpdatesClicked();
    }

    private void ntiUpdates_BalloonTipClicked(object sender, EventArgs e)
    {
      this.OnUpdatesClicked();
    }

    private void OnUpdatesClicked()
    {
      this.ntiUpdates.Visible = false;
      if (this.ntiUpdates.Tag is Exception)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, ((Exception) this.ntiUpdates.Tag).Message, "Error Checking For Updates", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      if (!(this.ntiUpdates.Tag is ReleaseInfo[]))
        return;
      ReleaseInfo[] releases = (ReleaseInfo[]) this.ntiUpdates.Tag;
      ReleaseNotesForm releaseNotesForm = new ReleaseNotesForm();
      releaseNotesForm.Init(releases);
      int num2 = (int) releaseNotesForm.ShowDialog((IWin32Window) this);
      releaseNotesForm.Dispose();
    }

    private void tsiMode_Click(object sender, EventArgs e)
    {
      bool persistent = OpenQuant.Config.Configuration.get_Active().get_Persistent();
      OptionsForm optionsForm = new OptionsForm();
      optionsForm.SetSelectedOptionsType(typeof (ConfigurationModeOptions));
      int num = (int) ((Form) optionsForm).ShowDialog((IWin32Window) this);
      ((Component) optionsForm).Dispose();
      if (persistent != OpenQuant.Config.Configuration.get_Active().get_Persistent() && Global.ProjectManager.ActiveSolution != null)
        Global.ProjectManager.ActiveSolution.UpdatePortfoliosPersistent();
      this.UpdateStatusMode();
    }

    private void LoadPlugins()
    {
      Global.get_PluginManager().LoadConfig();
      PluginInfoList plugins = Global.get_PluginManager().get_Plugins();
      PluginInfo pluginInfo1 = new PluginInfo((PluginType) 0, "SmartQuant.Transaq.Transaq", "SmartQuant.Transaq");
      plugins.Remove(pluginInfo1);
      PluginInfo pluginInfo2 = new PluginInfo((PluginType) 0, "OpenQuant.Finam.Transaq", "OpenQuant.Finam");
      if (plugins.TryGet(ref pluginInfo2))
        pluginInfo2.set_x64(true);
      else
        plugins.Add(pluginInfo2);
      PluginInfo pluginInfo3 = new PluginInfo((PluginType) 0, "OpenQuant.QR.QuantRouterProvider", "OpenQuant.QR");
      plugins.Remove(pluginInfo3);
      PluginInfo pluginInfo4 = new PluginInfo((PluginType) 0, "OpenQuant.QB.QuantBaseProvider", "OpenQuant.QB");
      plugins.Remove(pluginInfo4);
      PluginInfo pluginInfo5 = new PluginInfo((PluginType) 0, "OpenQuant.Ivory.Scorpion", "OpenQuant.Ivory");
      if (!plugins.Contains(pluginInfo5))
        plugins.Add(pluginInfo5);
      PluginInfo pluginInfo6 = new PluginInfo((PluginType) 0, "OpenQuant.IQ.IQFeed", "OpenQuant.IQ");
      if (!plugins.Contains(pluginInfo6))
        plugins.Add(pluginInfo6);
      Global.get_PluginManager().LoadPlugins();
    }
  }
}
