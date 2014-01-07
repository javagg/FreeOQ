// Type: OpenQuant.Portfolios.PortfolioWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.Properties;
using SmartQuant.Docking.WinForms;
using SmartQuant.Execution;
using SmartQuant.FIX;
using SmartQuant.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Portfolios
{
  public class PortfolioWindow : DockControl, IUpdateUI
  {
    private bool consolidating;
    private Portfolio portfolio;
    private Dictionary<Position, PositionViewItem> positionItems;
    private bool initOnLoad;
    private IContainer components;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabControl tabControl2;
    private TabPage tabPage3;
    private Splitter splitter1;
    private SplitContainer splitContainer1;
    private ListView ltvPortfolio;
    private ImageList images;
    private TabControl tabControl3;
    private TabPage tabPage4;
    private ListView ltvTransactions;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private SplitContainer splitContainer2;
    private TabControl tabControl4;
    private TabPage tabPage5;
    private ListView ltvAccountTransactions;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader9;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader10;
    private TabControl tabControl5;
    private TabPage tabPage6;
    private ListView ltvPositions;
    private ColumnHeader columnHeader11;
    private ColumnHeader columnHeader12;
    private ColumnHeader columnHeader13;
    private ColumnHeader columnHeader14;
    private TabControl tabControl6;
    private TabPage tabPage7;
    private ListView ltvAccountPositions;
    private ColumnHeader columnHeader15;
    private ColumnHeader columnHeader16;
    private ColumnHeader columnHeader17;
    private ColumnHeader columnHeader18;
    private ColumnHeader columnHeader19;
    private ColumnHeader columnHeader20;
    private ColumnHeader columnHeader21;
    private ColumnHeader columnHeader22;
    private ColumnHeader columnHeader23;
    private ColumnHeader columnHeader24;
    private ColumnHeader columnHeader25;
    private ColumnHeader columnHeader26;
    private ColumnHeader columnHeader27;
    private ColumnHeader columnHeader28;
    private ColumnHeader columnHeader29;
    private ColumnHeader columnHeader30;
    private ColumnHeader columnHeader31;
    private ColumnHeader columnHeader32;
    private ColumnHeader columnHeader33;
    private ColumnHeader columnHeader34;
    private ColumnHeader columnHeader35;
    private ColumnHeader columnHeader36;
    private ContextMenuStrip ctxPosition;
    private ToolStripMenuItem ctxPosition_Close;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem ctxPosition_CloseAll;

    public PortfolioWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
      this.ltvPortfolio.Items.Add(new ListViewItem(new string[this.ltvPortfolio.Columns.Count]));
      this.positionItems = new Dictionary<Position, PositionViewItem>();
    }

    protected virtual void OnInit()
    {
      this.portfolio = this.get_Key() as Portfolio;
      if (this.portfolio == Configuration.get_Active().get_Portfolio())
      {
        ((Control) this).Text = "Portfolio";
      }
      else
      {
        string str = this.portfolio.Name;
        if ((int) str[str.Length - 2] == 95)
          str = str.Remove(str.Length - 2, 2);
        if (this.portfolio == Global.ProjectManager.ActiveSolution.SolutionRunner.get_Portfolio())
          str = str.Remove(str.Length - "_Solution".Length, "_Solution".Length);
        ((Control) this).Text = "Portfolio (" + str + ")";
      }
      if (Global.Flags.UpdateUI || !Runner.IsRunning)
      {
        this.initOnLoad = true;
      }
      else
      {
        this.initOnLoad = false;
        this.Connect();
      }
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
    }

    public void UpdateUI()
    {
      ((Control) this).Invoke((Delegate) (() => this.InitPortfolio()));
    }

    protected virtual void OnLoad(EventArgs e)
    {
      if (this.initOnLoad)
        ((Control) this).BeginInvoke((Delegate) new Action(this.InitPortfolioAndConnect));
      ((DockControl) this).OnLoad(e);
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      this.Disconnect();
      Configuration.remove_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
      ((DockControl) this).OnClosing(e);
    }

    private void InitPortfolio()
    {
      if (this.consolidating)
        return;
      this.positionItems.Clear();
      this.ltvPositions.BeginUpdate();
      this.ltvPositions.Items.Clear();
      foreach (Position position in this.portfolio.Positions)
        this.AddPosition(position);
      this.ltvPositions.EndUpdate();
      this.ltvTransactions.BeginUpdate();
      this.ltvTransactions.Items.Clear();
      foreach (Transaction transaction in this.portfolio.Transactions)
        this.AddTransaction(transaction);
      this.ltvTransactions.EndUpdate();
      this.ltvAccountPositions.BeginUpdate();
      this.ltvAccountPositions.Items.Clear();
      foreach (AccountPosition position in this.portfolio.Account.Positions)
        this.AddAccountPosition(position);
      this.ltvAccountPositions.EndUpdate();
      this.ltvAccountTransactions.BeginUpdate();
      this.ltvAccountTransactions.Items.Clear();
      foreach (AccountTransaction transaction in this.portfolio.Account.Transactions)
        this.AddAccountTransaction(transaction);
      this.ltvAccountTransactions.EndUpdate();
      this.UpdatePortfolioValue();
    }

    private void InitPortfolioAndConnect()
    {
      if (this.portfolio.TrySuspendUpdates())
      {
        this.InitPortfolio();
        this.Connect();
        this.portfolio.ResumeUpdates();
      }
      else
      {
        Application.DoEvents();
        ((Control) this).BeginInvoke((Delegate) new Action(this.InitPortfolioAndConnect));
      }
    }

    private void Connect()
    {
      this.portfolio.TransactionAdded += new TransactionEventHandler(this.portfolio_TransactionAdded);
      this.portfolio.PositionOpened += new PositionEventHandler(this.portfolio_PositionOpened);
      this.portfolio.PositionChanged += new PositionEventHandler(this.portfolio_PositionChanged);
      this.portfolio.PositionClosed += new PositionEventHandler(this.portfolio_PositionClosed);
      this.portfolio.ValueChanged += new PositionEventHandler(this.portfolio_ValueChanged);
      this.portfolio.Account.TransactionAdded += new AccountTransactionEventHandler(this.Account_TransactionAdded);
      this.portfolio.Account.AccountChanged += new EventHandler(this.Account_AccountChanged);
      this.portfolio.Cleared += new EventHandler(this.portfolio_Cleared);
      this.portfolio.ConsolidationStarted += new EventHandler(this.portfolio_ConsolidationStarted);
      this.portfolio.ConsolidationFinished += new EventHandler(this.portfolio_ConsolidationFinished);
    }

    private void Disconnect()
    {
      this.portfolio.TransactionAdded -= new TransactionEventHandler(this.portfolio_TransactionAdded);
      this.portfolio.PositionOpened -= new PositionEventHandler(this.portfolio_PositionOpened);
      this.portfolio.PositionChanged -= new PositionEventHandler(this.portfolio_PositionChanged);
      this.portfolio.PositionClosed -= new PositionEventHandler(this.portfolio_PositionClosed);
      this.portfolio.ValueChanged -= new PositionEventHandler(this.portfolio_ValueChanged);
      this.portfolio.Account.TransactionAdded -= new AccountTransactionEventHandler(this.Account_TransactionAdded);
      this.portfolio.Account.AccountChanged -= new EventHandler(this.Account_AccountChanged);
      this.portfolio.Cleared -= new EventHandler(this.portfolio_Cleared);
      this.portfolio.ConsolidationStarted -= new EventHandler(this.portfolio_ConsolidationStarted);
      this.portfolio.ConsolidationFinished -= new EventHandler(this.portfolio_ConsolidationFinished);
    }

    private void portfolio_TransactionAdded(object sender, TransactionEventArgs args)
    {
      if (this.consolidating || !Global.Flags.UpdateUI)
        return;
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).Invoke((Delegate) (() => this.AddTransaction(args.Transaction)), sender, (object) args));
    }

    private void portfolio_PositionOpened(object sender, PositionEventArgs args)
    {
      if (this.consolidating || !Global.Flags.UpdateUI)
        return;
      ((Control) this).Invoke((Delegate) (() => this.AddPosition(args.Position)));
    }

    private void portfolio_PositionChanged(object sender, PositionEventArgs args)
    {
      if (this.consolidating || !Global.Flags.UpdateUI)
        return;
      ((Control) this).Invoke((Delegate) (() => this.UpdatePosition(args.Position)));
    }

    private void portfolio_PositionClosed(object sender, PositionEventArgs args)
    {
      if (this.consolidating || !Global.Flags.UpdateUI)
        return;
      ((Control) this).Invoke((Delegate) (() => this.RemovePosition(args.Position)));
    }

    private void portfolio_ValueChanged(object sender, PositionEventArgs args)
    {
      if (this.consolidating || !Global.Flags.UpdateUI)
        return;
      ((Control) this).Invoke((Delegate) (() =>
      {
        this.UpdatePosition(args.Position);
        this.UpdatePortfolioValue();
      }));
    }

    private void Account_TransactionAdded(object sender, AccountTransactionEventArgs args)
    {
      if (this.consolidating || !Global.Flags.UpdateUI)
        return;
      ((Control) this).Invoke((Delegate) (() => this.AddAccountTransaction(args.Transaction)));
    }

    private void Account_AccountChanged(object sender, EventArgs e)
    {
      if (this.consolidating || !Global.Flags.UpdateUI)
        return;
      ((Control) this).Invoke((Delegate) (() =>
      {
        this.ltvAccountPositions.BeginUpdate();
        this.ltvAccountPositions.Items.Clear();
        foreach (AccountPosition item_0 in this.portfolio.Account.Positions)
          this.AddAccountPosition(item_0);
        this.ltvAccountPositions.EndUpdate();
      }));
    }

    private void portfolio_Cleared(object sender, EventArgs e)
    {
      if (this.consolidating)
        return;
      ((Control) this).Invoke((Delegate) (() => this.InitPortfolio()));
    }

    private void portfolio_ConsolidationStarted(object sender, EventArgs e)
    {
      this.consolidating = true;
    }

    private void portfolio_ConsolidationFinished(object sender, EventArgs e)
    {
      this.consolidating = false;
      ((Control) this).Invoke((Delegate) (() => this.InitPortfolio()));
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      this.Disconnect();
      Portfolio portfolio;
      if (this.portfolio.Name == "Live" || this.portfolio.Name == "Simulation" || this.portfolio.Name == "Paper")
      {
        portfolio = Configuration.get_Active().get_Portfolio();
      }
      else
      {
        string index = this.portfolio.Name.Remove(this.portfolio.Name.Length - 2, 2);
        portfolio = !(index == Global.ProjectManager.ActiveSolution.Name + "_Solution") ? Global.ProjectManager.ActiveSolution.Projects[index].StrategyRunner.get_Portfolio() : Global.ProjectManager.ActiveSolution.SolutionRunner.get_Portfolio();
      }
      this.portfolio = portfolio;
      if (Global.Flags.UpdateUI || !Runner.IsRunning)
        ((Control) this).BeginInvoke((Delegate) new Action(this.InitPortfolioAndConnect));
      else
        this.Connect();
    }

    private void AddPosition(Position position)
    {
      PositionViewItem positionViewItem = new PositionViewItem(position);
      lock (this)
        this.ltvPositions.Items.Add((ListViewItem) positionViewItem);
      this.positionItems.Add(position, positionViewItem);
    }

    private void RemovePosition(Position position)
    {
      PositionViewItem positionViewItem = this.positionItems[position];
      lock (this)
        positionViewItem.Remove();
      this.positionItems.Remove(position);
    }

    private void UpdatePosition(Position position)
    {
      PositionViewItem positionViewItem = (PositionViewItem) null;
      if (!this.positionItems.TryGetValue(position, out positionViewItem))
        return;
      positionViewItem.UpdateValues();
    }

    private void AddTransaction(Transaction transaction)
    {
      this.ltvTransactions.Items.Insert(0, (ListViewItem) new TransactionViewItem(transaction));
    }

    private void AddAccountPosition(AccountPosition position)
    {
      this.ltvAccountPositions.Items.Add((ListViewItem) new AccountPositionViewItem(position));
    }

    private void AddAccountTransaction(AccountTransaction transaction)
    {
      this.ltvAccountTransactions.Items.Insert(0, (ListViewItem) new AccountTransactionViewItem(transaction));
    }

    private void UpdatePortfolioValue()
    {
      string format = "F2";
      this.ltvPortfolio.BeginUpdate();
      this.ltvPortfolio.Items[0].SubItems[0].Text = this.portfolio.Account.Currency.ToString();
      this.ltvPortfolio.Items[0].SubItems[1].Text = this.portfolio.GetAccountValue().ToString(format);
      this.ltvPortfolio.Items[0].SubItems[2].Text = this.portfolio.GetPositionValue().ToString(format);
      this.ltvPortfolio.Items[0].SubItems[3].Text = this.portfolio.GetValue().ToString(format);
      this.ltvPortfolio.Items[0].SubItems[4].Text = this.portfolio.GetMarginValue().ToString(format);
      this.ltvPortfolio.Items[0].SubItems[5].Text = this.portfolio.GetDebtValue().ToString(format);
      this.ltvPortfolio.Items[0].SubItems[6].Text = this.portfolio.GetTotalEquity().ToString(format);
      this.ltvPortfolio.Items[0].SubItems[7].Text = this.portfolio.GetLeverage().ToString(format);
      this.ltvPortfolio.EndUpdate();
    }

    private void ctxPosition_Close_Click(object sender, EventArgs e)
    {
      Position position = (Position) null;
      lock (this)
      {
        if (this.ltvPositions.SelectedItems.Count > 0)
          position = (this.ltvPositions.SelectedItems[0] as PositionViewItem).PortfolioPosition;
      }
      if (position == null)
        return;
      this.ClosePositions(new Position[1]
      {
        position
      });
    }

    private void ClosePositions(Position[] list)
    {
      foreach (Position position in list)
      {
        SingleOrder singleOrder = new SingleOrder();
        singleOrder.Instrument = position.Instrument;
        singleOrder.Portfolio = position.Portfolio;
        singleOrder.Provider = Configuration.get_Active().get_ExecutionProvider();
        switch (position.Side)
        {
          case PositionSide.Long:
            singleOrder.Side = Side.Sell;
            break;
          case PositionSide.Short:
            singleOrder.Side = Side.Buy;
            break;
        }
        singleOrder.OrdType = OrdType.Market;
        singleOrder.OrderQty = position.Qty;
        singleOrder.Persistent = position.Portfolio.Persistent;
        if (singleOrder.Provider.IsConnected)
        {
          singleOrder.Send();
        }
        else
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "Provider is not connected.", "Not Connected.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
    }

    private void ctxPosition_Opening(object sender, CancelEventArgs e)
    {
      this.ctxPosition_Close.Enabled = this.ctxPosition_CloseAll.Enabled = this.ltvPositions.SelectedItems.Count > 0;
    }

    private void ctxPosition_CloseAll_Click(object sender, EventArgs e)
    {
      Position[] list;
      lock (this)
      {
        list = new Position[this.portfolio.Positions.Count];
        for (int local_1 = 0; local_1 < this.ltvPositions.Items.Count; ++local_1)
          list[local_1] = (this.ltvPositions.Items[local_1] as PositionViewItem).PortfolioPosition;
      }
      this.ClosePositions(list);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PortfolioWindow));
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.splitContainer1 = new SplitContainer();
      this.tabControl5 = new TabControl();
      this.tabPage6 = new TabPage();
      this.ltvPositions = new ListView();
      this.columnHeader11 = new ColumnHeader();
      this.columnHeader12 = new ColumnHeader();
      this.columnHeader13 = new ColumnHeader();
      this.columnHeader14 = new ColumnHeader();
      this.columnHeader21 = new ColumnHeader();
      this.columnHeader22 = new ColumnHeader();
      this.columnHeader23 = new ColumnHeader();
      this.columnHeader24 = new ColumnHeader();
      this.columnHeader25 = new ColumnHeader();
      this.columnHeader26 = new ColumnHeader();
      this.columnHeader27 = new ColumnHeader();
      this.ctxPosition = new ContextMenuStrip(this.components);
      this.ctxPosition_Close = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripSeparator();
      this.ctxPosition_CloseAll = new ToolStripMenuItem();
      this.tabControl3 = new TabControl();
      this.tabPage4 = new TabPage();
      this.ltvTransactions = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader28 = new ColumnHeader();
      this.columnHeader29 = new ColumnHeader();
      this.columnHeader30 = new ColumnHeader();
      this.columnHeader31 = new ColumnHeader();
      this.columnHeader32 = new ColumnHeader();
      this.tabPage2 = new TabPage();
      this.splitContainer2 = new SplitContainer();
      this.tabControl6 = new TabControl();
      this.tabPage7 = new TabPage();
      this.ltvAccountPositions = new ListView();
      this.columnHeader15 = new ColumnHeader();
      this.columnHeader16 = new ColumnHeader();
      this.tabControl4 = new TabControl();
      this.tabPage5 = new TabPage();
      this.ltvAccountTransactions = new ListView();
      this.columnHeader6 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.columnHeader8 = new ColumnHeader();
      this.columnHeader9 = new ColumnHeader();
      this.columnHeader10 = new ColumnHeader();
      this.tabControl2 = new TabControl();
      this.tabPage3 = new TabPage();
      this.ltvPortfolio = new ListView();
      this.columnHeader17 = new ColumnHeader();
      this.columnHeader18 = new ColumnHeader();
      this.columnHeader19 = new ColumnHeader();
      this.columnHeader20 = new ColumnHeader();
      this.columnHeader33 = new ColumnHeader();
      this.columnHeader34 = new ColumnHeader();
      this.columnHeader35 = new ColumnHeader();
      this.columnHeader36 = new ColumnHeader();
      this.images = new ImageList(this.components);
      this.splitter1 = new Splitter();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabControl5.SuspendLayout();
      this.tabPage6.SuspendLayout();
      this.ctxPosition.SuspendLayout();
      this.tabControl3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.splitContainer2.BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.tabControl6.SuspendLayout();
      this.tabPage7.SuspendLayout();
      this.tabControl4.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(680, 317);
      this.tabControl1.TabIndex = 1;
      this.tabPage1.Controls.Add((Control) this.splitContainer1);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(672, 291);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Composition";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.tabControl5);
      this.splitContainer1.Panel2.Controls.Add((Control) this.tabControl3);
      this.splitContainer1.Size = new Size(666, 285);
      this.splitContainer1.SplitterDistance = 94;
      this.splitContainer1.TabIndex = 0;
      this.tabControl5.Controls.Add((Control) this.tabPage6);
      this.tabControl5.Dock = DockStyle.Fill;
      this.tabControl5.Location = new Point(0, 0);
      this.tabControl5.Name = "tabControl5";
      this.tabControl5.SelectedIndex = 0;
      this.tabControl5.Size = new Size(666, 94);
      this.tabControl5.TabIndex = 0;
      this.tabPage6.Controls.Add((Control) this.ltvPositions);
      this.tabPage6.Location = new Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new Padding(3);
      this.tabPage6.Size = new Size(658, 68);
      this.tabPage6.TabIndex = 0;
      this.tabPage6.Text = "Positions";
      this.tabPage6.UseVisualStyleBackColor = true;
      this.ltvPositions.Columns.AddRange(new ColumnHeader[11]
      {
        this.columnHeader11,
        this.columnHeader12,
        this.columnHeader13,
        this.columnHeader14,
        this.columnHeader21,
        this.columnHeader22,
        this.columnHeader23,
        this.columnHeader24,
        this.columnHeader25,
        this.columnHeader26,
        this.columnHeader27
      });
      this.ltvPositions.ContextMenuStrip = this.ctxPosition;
      this.ltvPositions.Dock = DockStyle.Fill;
      this.ltvPositions.FullRowSelect = true;
      this.ltvPositions.GridLines = true;
      this.ltvPositions.HideSelection = false;
      this.ltvPositions.Location = new Point(3, 3);
      this.ltvPositions.MultiSelect = false;
      this.ltvPositions.Name = "ltvPositions";
      this.ltvPositions.ShowGroups = false;
      this.ltvPositions.Size = new Size(652, 62);
      this.ltvPositions.TabIndex = 0;
      this.ltvPositions.UseCompatibleStateImageBehavior = false;
      this.ltvPositions.View = View.Details;
      this.columnHeader11.Text = "Symbol";
      this.columnHeader11.Width = 83;
      this.columnHeader12.Text = "Side";
      this.columnHeader12.TextAlign = HorizontalAlignment.Right;
      this.columnHeader12.Width = 66;
      this.columnHeader13.Text = "Price";
      this.columnHeader13.TextAlign = HorizontalAlignment.Right;
      this.columnHeader13.Width = 67;
      this.columnHeader14.Text = "Qty";
      this.columnHeader14.TextAlign = HorizontalAlignment.Right;
      this.columnHeader14.Width = 56;
      this.columnHeader21.Text = "Bought";
      this.columnHeader21.TextAlign = HorizontalAlignment.Right;
      this.columnHeader22.Text = "Sold";
      this.columnHeader22.TextAlign = HorizontalAlignment.Right;
      this.columnHeader23.Text = "Short";
      this.columnHeader23.TextAlign = HorizontalAlignment.Right;
      this.columnHeader24.Text = "Margin";
      this.columnHeader24.TextAlign = HorizontalAlignment.Right;
      this.columnHeader25.Text = "Debt";
      this.columnHeader25.TextAlign = HorizontalAlignment.Right;
      this.columnHeader26.Text = "Value";
      this.columnHeader26.TextAlign = HorizontalAlignment.Right;
      this.columnHeader27.Text = "PnL";
      this.columnHeader27.TextAlign = HorizontalAlignment.Right;
      this.ctxPosition.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ctxPosition_Close,
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.ctxPosition_CloseAll
      });
      this.ctxPosition.Name = "ctxPosition";
      this.ctxPosition.Size = new Size(126, 54);
      this.ctxPosition.Opening += new CancelEventHandler(this.ctxPosition_Opening);
      this.ctxPosition_Close.Image = (Image) Resources.remove;
      this.ctxPosition_Close.Name = "ctxPosition_Close";
      this.ctxPosition_Close.Size = new Size(125, 22);
      this.ctxPosition_Close.Text = "Close";
      this.ctxPosition_Close.Click += new EventHandler(this.ctxPosition_Close_Click);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(122, 6);
      this.ctxPosition_CloseAll.Name = "ctxPosition_CloseAll";
      this.ctxPosition_CloseAll.Size = new Size(125, 22);
      this.ctxPosition_CloseAll.Text = "Close All";
      this.ctxPosition_CloseAll.Click += new EventHandler(this.ctxPosition_CloseAll_Click);
      this.tabControl3.Controls.Add((Control) this.tabPage4);
      this.tabControl3.Dock = DockStyle.Fill;
      this.tabControl3.Location = new Point(0, 0);
      this.tabControl3.Name = "tabControl3";
      this.tabControl3.SelectedIndex = 0;
      this.tabControl3.Size = new Size(666, 187);
      this.tabControl3.TabIndex = 0;
      this.tabPage4.Controls.Add((Control) this.ltvTransactions);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(658, 161);
      this.tabPage4.TabIndex = 0;
      this.tabPage4.Text = "Transactions";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.ltvTransactions.Columns.AddRange(new ColumnHeader[10]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader28,
        this.columnHeader29,
        this.columnHeader30,
        this.columnHeader31,
        this.columnHeader32
      });
      this.ltvTransactions.Dock = DockStyle.Fill;
      this.ltvTransactions.FullRowSelect = true;
      this.ltvTransactions.GridLines = true;
      this.ltvTransactions.HideSelection = false;
      this.ltvTransactions.Location = new Point(3, 3);
      this.ltvTransactions.MultiSelect = false;
      this.ltvTransactions.Name = "ltvTransactions";
      this.ltvTransactions.ShowGroups = false;
      this.ltvTransactions.Size = new Size(652, 155);
      this.ltvTransactions.TabIndex = 2;
      this.ltvTransactions.UseCompatibleStateImageBehavior = false;
      this.ltvTransactions.View = View.Details;
      this.columnHeader1.Text = "DateTime";
      this.columnHeader1.Width = 129;
      this.columnHeader2.Text = "Symbol";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 71;
      this.columnHeader3.Text = "Side";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 63;
      this.columnHeader4.Text = "Price";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 62;
      this.columnHeader5.Text = "Qty";
      this.columnHeader5.TextAlign = HorizontalAlignment.Right;
      this.columnHeader28.Text = "Value";
      this.columnHeader28.TextAlign = HorizontalAlignment.Right;
      this.columnHeader29.Text = "Cost";
      this.columnHeader29.TextAlign = HorizontalAlignment.Right;
      this.columnHeader30.Text = "PnL";
      this.columnHeader30.TextAlign = HorizontalAlignment.Right;
      this.columnHeader31.Text = "Currency";
      this.columnHeader31.TextAlign = HorizontalAlignment.Right;
      this.columnHeader32.Text = "Comment";
      this.columnHeader32.Width = 160;
      this.tabPage2.Controls.Add((Control) this.splitContainer2);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(672, 291);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Account";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.splitContainer2.Dock = DockStyle.Fill;
      this.splitContainer2.Location = new Point(3, 3);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = Orientation.Horizontal;
      this.splitContainer2.Panel1.Controls.Add((Control) this.tabControl6);
      this.splitContainer2.Panel2.Controls.Add((Control) this.tabControl4);
      this.splitContainer2.Size = new Size(666, 285);
      this.splitContainer2.SplitterDistance = 99;
      this.splitContainer2.TabIndex = 0;
      this.tabControl6.Controls.Add((Control) this.tabPage7);
      this.tabControl6.Dock = DockStyle.Fill;
      this.tabControl6.Location = new Point(0, 0);
      this.tabControl6.Name = "tabControl6";
      this.tabControl6.SelectedIndex = 0;
      this.tabControl6.Size = new Size(666, 99);
      this.tabControl6.TabIndex = 0;
      this.tabPage7.Controls.Add((Control) this.ltvAccountPositions);
      this.tabPage7.Location = new Point(4, 22);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Padding = new Padding(3);
      this.tabPage7.Size = new Size(658, 73);
      this.tabPage7.TabIndex = 0;
      this.tabPage7.Text = "Positions";
      this.tabPage7.UseVisualStyleBackColor = true;
      this.ltvAccountPositions.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader15,
        this.columnHeader16
      });
      this.ltvAccountPositions.Dock = DockStyle.Fill;
      this.ltvAccountPositions.FullRowSelect = true;
      this.ltvAccountPositions.GridLines = true;
      this.ltvAccountPositions.HideSelection = false;
      this.ltvAccountPositions.Location = new Point(3, 3);
      this.ltvAccountPositions.MultiSelect = false;
      this.ltvAccountPositions.Name = "ltvAccountPositions";
      this.ltvAccountPositions.ShowGroups = false;
      this.ltvAccountPositions.Size = new Size(652, 67);
      this.ltvAccountPositions.TabIndex = 0;
      this.ltvAccountPositions.UseCompatibleStateImageBehavior = false;
      this.ltvAccountPositions.View = View.Details;
      this.columnHeader15.Text = "Currency";
      this.columnHeader15.Width = 69;
      this.columnHeader16.Text = "Value";
      this.columnHeader16.TextAlign = HorizontalAlignment.Right;
      this.columnHeader16.Width = 106;
      this.tabControl4.Controls.Add((Control) this.tabPage5);
      this.tabControl4.Dock = DockStyle.Fill;
      this.tabControl4.Location = new Point(0, 0);
      this.tabControl4.Name = "tabControl4";
      this.tabControl4.SelectedIndex = 0;
      this.tabControl4.Size = new Size(666, 182);
      this.tabControl4.TabIndex = 0;
      this.tabPage5.Controls.Add((Control) this.ltvAccountTransactions);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(658, 156);
      this.tabPage5.TabIndex = 0;
      this.tabPage5.Text = "Transactions";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.ltvAccountTransactions.Columns.AddRange(new ColumnHeader[5]
      {
        this.columnHeader6,
        this.columnHeader7,
        this.columnHeader8,
        this.columnHeader9,
        this.columnHeader10
      });
      this.ltvAccountTransactions.Dock = DockStyle.Fill;
      this.ltvAccountTransactions.FullRowSelect = true;
      this.ltvAccountTransactions.GridLines = true;
      this.ltvAccountTransactions.HideSelection = false;
      this.ltvAccountTransactions.Location = new Point(3, 3);
      this.ltvAccountTransactions.MultiSelect = false;
      this.ltvAccountTransactions.Name = "ltvAccountTransactions";
      this.ltvAccountTransactions.ShowGroups = false;
      this.ltvAccountTransactions.Size = new Size(652, 150);
      this.ltvAccountTransactions.TabIndex = 1;
      this.ltvAccountTransactions.UseCompatibleStateImageBehavior = false;
      this.ltvAccountTransactions.View = View.Details;
      this.columnHeader6.Text = "DateTime";
      this.columnHeader6.Width = 117;
      this.columnHeader7.Text = "Action";
      this.columnHeader7.TextAlign = HorizontalAlignment.Right;
      this.columnHeader7.Width = 80;
      this.columnHeader8.Text = "Value";
      this.columnHeader8.TextAlign = HorizontalAlignment.Right;
      this.columnHeader8.Width = 64;
      this.columnHeader9.Text = "Currency";
      this.columnHeader9.TextAlign = HorizontalAlignment.Right;
      this.columnHeader9.Width = 67;
      this.columnHeader10.Text = "Text";
      this.columnHeader10.Width = 182;
      this.tabControl2.Controls.Add((Control) this.tabPage3);
      this.tabControl2.Dock = DockStyle.Bottom;
      this.tabControl2.ImageList = this.images;
      this.tabControl2.Location = new Point(0, 321);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(680, 79);
      this.tabControl2.TabIndex = 2;
      this.tabPage3.Controls.Add((Control) this.ltvPortfolio);
      this.tabPage3.ImageIndex = 0;
      this.tabPage3.Location = new Point(4, 23);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(672, 52);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.UseVisualStyleBackColor = true;
      this.ltvPortfolio.Columns.AddRange(new ColumnHeader[8]
      {
        this.columnHeader17,
        this.columnHeader18,
        this.columnHeader19,
        this.columnHeader20,
        this.columnHeader33,
        this.columnHeader34,
        this.columnHeader35,
        this.columnHeader36
      });
      this.ltvPortfolio.Dock = DockStyle.Fill;
      this.ltvPortfolio.FullRowSelect = true;
      this.ltvPortfolio.Location = new Point(3, 3);
      this.ltvPortfolio.MultiSelect = false;
      this.ltvPortfolio.Name = "ltvPortfolio";
      this.ltvPortfolio.ShowGroups = false;
      this.ltvPortfolio.Size = new Size(666, 46);
      this.ltvPortfolio.TabIndex = 0;
      this.ltvPortfolio.UseCompatibleStateImageBehavior = false;
      this.ltvPortfolio.View = View.Details;
      this.columnHeader17.Text = "Currency";
      this.columnHeader17.Width = 68;
      this.columnHeader18.Text = "Account";
      this.columnHeader18.TextAlign = HorizontalAlignment.Right;
      this.columnHeader18.Width = 90;
      this.columnHeader19.Text = "Position";
      this.columnHeader19.TextAlign = HorizontalAlignment.Right;
      this.columnHeader19.Width = 81;
      this.columnHeader20.Text = "Value";
      this.columnHeader20.TextAlign = HorizontalAlignment.Right;
      this.columnHeader20.Width = 89;
      this.columnHeader33.Text = "Margin";
      this.columnHeader33.TextAlign = HorizontalAlignment.Right;
      this.columnHeader34.Text = "Debt";
      this.columnHeader34.TextAlign = HorizontalAlignment.Right;
      this.columnHeader35.Text = "Equity";
      this.columnHeader35.TextAlign = HorizontalAlignment.Right;
      this.columnHeader36.Text = "Leverage";
      this.columnHeader36.TextAlign = HorizontalAlignment.Right;
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "moneybag.png");
      this.splitter1.Dock = DockStyle.Bottom;
      this.splitter1.Location = new Point(0, 317);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(680, 4);
      this.splitter1.TabIndex = 3;
      this.splitter1.TabStop = false;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.tabControl1);
      ((Control) this).Controls.Add((Control) this.splitter1);
      ((Control) this).Controls.Add((Control) this.tabControl2);
      this.set_DefaultDockLocation((ContainerDockLocation) 5);
      ((Control) this).Name = "PortfolioWindow";
      ((DockControl) this).set_PersistState(false);
      ((Control) this).Size = new Size(680, 400);
      ((DockControl) this).set_TabImage((Image) Resources.portfolio);
      ((Control) this).Text = "Portfolio";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabControl5.ResumeLayout(false);
      this.tabPage6.ResumeLayout(false);
      this.ctxPosition.ResumeLayout(false);
      this.tabControl3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.tabControl6.ResumeLayout(false);
      this.tabPage7.ResumeLayout(false);
      this.tabControl4.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
    }
  }
}
