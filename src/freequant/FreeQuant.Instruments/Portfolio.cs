// Type: SmartQuant.Instruments.Portfolio
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.FIX;
using SmartQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class Portfolio
  {
    private const string PZwsidQPL5 = "Naming";
    private const bool RjashrZH84 = true;
    private const bool rSjstETkMn = false;
    private int zbcddHYChn;
    private string lvrdPnsoMs;
    private string WlbdegClB5;
    private TransactionList dvdd2kT4al;
    private PositionList P09d8aTdqt;
    private Account d1XdlJjBqU;
    private bool UYydYjfW5Z;
    private bool nKjdGEyCXa;
    private MarginManager rTVdXwFwmG;
    private Performance NRUd4uRimv;
    private bool Mk5dJuOhmC;
    private object ux7drmUmHV;

    [Browsable(false)]
    public int Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.zbcddHYChn;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.zbcddHYChn = value;
      }
    }

    [Category("Naming")]
    [ReadOnly(true)]
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lvrdPnsoMs;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.lvrdPnsoMs = value;
      }
    }

    [Category("Naming")]
    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WlbdegClB5;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WlbdegClB5 = value;
      }
    }

    [Browsable(false)]
    public PositionList Positions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.P09d8aTdqt;
      }
    }

    [Browsable(false)]
    public TransactionList Transactions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.dvdd2kT4al;
      }
    }

    [Browsable(false)]
    public Account Account
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.d1XdlJjBqU;
      }
    }

    [Browsable(false)]
    public Performance Performance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NRUd4uRimv;
      }
    }

    [DefaultValue(true)]
    public bool Monitored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UYydYjfW5Z;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (value)
        {
          if (!this.UYydYjfW5Z)
            this.G7UsvA9nvQ();
        }
        else if (this.UYydYjfW5Z)
          this.Cats5kfBGV();
        this.UYydYjfW5Z = value;
      }
    }

    [DefaultValue(false)]
    public bool Persistent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nKjdGEyCXa;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.nKjdGEyCXa == value)
          return;
        if (value)
          this.Save();
        this.nKjdGEyCXa = value;
        PortfolioManager.IDgsP9flDf(this);
      }
    }

    public event TransactionEventHandler TransactionAdded;

    public event PositionEventHandler PositionOpened;

    public event PositionEventHandler PositionClosed;

    public event PositionEventHandler PositionChanged;

    public event PositionEventHandler ValueChanged;

    public event EventHandler Cleared;

    public event EventHandler CompositionChanged;

    public event EventHandler ConsolidationStarted;

    public event EventHandler ConsolidationFinished;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Portfolio()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.zbcddHYChn = -1;
      this.dvdd2kT4al = new TransactionList();
      this.P09d8aTdqt = new PositionList();
      this.d1XdlJjBqU = new Account();
      this.d1XdlJjBqU.TransactionAdded += new AccountTransactionEventHandler(this.O3KsaYYaRC);
      this.UYydYjfW5Z = true;
      this.nKjdGEyCXa = false;
      this.rTVdXwFwmG = new MarginManager();
      this.rTVdXwFwmG.Enabled = false;
      this.NRUd4uRimv = new Performance(this);
      this.ux7drmUmHV = new object();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Portfolio(string name, string description)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      this.lvrdPnsoMs = name;
      this.WlbdegClB5 = description;
      PortfolioManager.j2wssyCvhK(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Portfolio(string name)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(DateTime datetime, Side side, double qty, Instrument instrument, double price, double commission, CommType commType)
    {
      this.Add(new Transaction(datetime, side, qty, instrument, price, commission, commType));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(DateTime datetime, Side side, double qty, Instrument instrument, double price)
    {
      this.Add(new Transaction(datetime, side, qty, instrument, price));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(DateTime datetime, Side side, double qty, string symbol, double price, double commission, CommType commType)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        throw new ArgumentException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10924) + this.Name + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11002) + symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11056));
      else
        this.Add(new Transaction(datetime, side, qty, instrument, price, commission, commType));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(DateTime datetime, Side side, double qty, string symbol, double price)
    {
      Instrument instrument = InstrumentManager.Instruments[symbol];
      if (instrument == null)
        throw new ArgumentException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11118) + this.Name + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11196) + symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(11250));
      else
        this.Add(new Transaction(datetime, side, qty, instrument, price));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Transaction transaction)
    {
      lock (this.ux7drmUmHV)
      {
        bool local_0 = false;
        bool local_1 = true;
        bool local_2 = false;
        Position local_3 = this.P09d8aTdqt[transaction.Instrument];
        double local_4 = 0.0;
        double local_5 = 0.0;
        double local_6 = 0.0;
        if (local_3 == null)
        {
          local_3 = new Position(this, transaction);
          this.P09d8aTdqt.Add(local_3);
          if (this.UYydYjfW5Z)
            this.yaesuiSHoR(local_3);
          if (transaction.Margin != 0.0)
          {
            local_4 = transaction.Margin;
            local_6 = 0.0;
            local_5 = transaction.Debt;
            local_3.Margin = transaction.Margin;
            local_3.Debt = transaction.Debt;
          }
          local_0 = true;
        }
        else
        {
          if (transaction.Margin != 0.0)
          {
            if (local_3.Side == PositionSide.Long && transaction.Side == Side.Buy || local_3.Side == PositionSide.Short && (transaction.Side == Side.Sell || transaction.Side == Side.SellShort))
            {
              local_4 = transaction.Margin;
              local_6 = 0.0;
              local_5 = transaction.Debt;
              local_3.Margin += transaction.Margin;
              local_3.Debt += transaction.Debt;
            }
            if (local_3.Side == PositionSide.Long && (transaction.Side == Side.Sell || transaction.Side == Side.SellShort) || local_3.Side == PositionSide.Short && transaction.Side == Side.Buy)
            {
              if (local_3.Qty == transaction.Qty)
              {
                double temp_152 = local_3.Margin;
                local_4 = 0.0;
                local_6 = local_3.Debt;
                local_5 = 0.0;
                local_3.Margin = 0.0;
                local_3.Debt = 0.0;
              }
              else if (local_3.Qty > transaction.Qty)
              {
                double temp_131 = transaction.Margin;
                local_4 = 0.0;
                local_6 = local_3.Debt * transaction.Qty / local_3.Qty;
                local_5 = 0.0;
                local_3.Margin -= transaction.Margin;
                local_3.Debt -= local_6;
              }
              else
              {
                double local_7 = transaction.Qty - local_3.Qty;
                double local_8 = local_7 * transaction.Price;
                if (transaction.Instrument.Factor != 0.0)
                  local_8 *= transaction.Instrument.Factor;
                double temp_110 = local_3.Margin;
                double local_4_1 = transaction.Instrument.Margin * local_7;
                local_6 = local_3.Debt;
                local_5 = local_8 - local_4_1;
                local_3.Margin = local_4_1;
                local_3.Debt = local_5;
              }
            }
          }
          local_3.Add(transaction);
          if (local_3.Qty == 0.0)
          {
            this.P09d8aTdqt.Remove(local_3);
            if (this.UYydYjfW5Z)
              this.McUsSP483C(local_3);
            local_2 = true;
          }
        }
        this.dvdd2kT4al.Add(transaction);
        if (!this.Mk5dJuOhmC && this.nKjdGEyCXa)
          PortfolioManager.LfnseafCc7(this, transaction);
        this.lmWsxlDsUD(transaction);
        if (!this.Mk5dJuOhmC)
          this.d1XdlJjBqU.Add(transaction.CashFlow + local_5 - local_6, transaction.Currency, transaction.DateTime, transaction.Text);
        if (local_0)
          this.Ui2sg7ghMJ(local_3);
        if (local_1)
          this.eY6sogNFDu(local_3);
        if (local_2)
          this.W88s1d36mE(local_3);
        this.AYIsLEwh9x();
        if (this.Mk5dJuOhmC)
          return;
        this.gJYsIOGcWf(local_3);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Portfolio Reconstruct(DateTime dateTime)
    {
      Portfolio portfolio = new Portfolio();
      foreach (Transaction transaction in this.dvdd2kT4al)
      {
        if (transaction.DateTime <= dateTime)
          portfolio.Add(transaction);
      }
      portfolio.Account.Clear();
      foreach (AccountTransaction transaction in this.d1XdlJjBqU.Transactions)
      {
        if (transaction.DateTime <= dateTime)
          portfolio.Account.Add(transaction);
      }
      return portfolio;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Portfolio Consolidate(Portfolio portfolio)
    {
      TransactionList transactionList = new TransactionList();
      foreach (Transaction transaction in this.Transactions)
        transactionList.Add(transaction, false);
      foreach (Transaction transaction in portfolio.Transactions)
        transactionList.Add(transaction, false);
      transactionList.Sort();
      Portfolio portfolio1 = new Portfolio();
      foreach (Transaction transaction in transactionList)
        portfolio1.Add(transaction);
      portfolio1.Account.Clear();
      AccountTransactionList accountTransactionList = new AccountTransactionList();
      foreach (AccountTransaction transaction in this.Account.Transactions)
        accountTransactionList.Add(transaction);
      foreach (AccountTransaction transaction in portfolio.Account.Transactions)
        accountTransactionList.Add(transaction);
      foreach (AccountTransaction transaction in accountTransactionList)
        portfolio1.Account.Add(transaction);
      return portfolio1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(Instrument instrument)
    {
      return this.P09d8aTdqt.Contains(instrument);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPositionValue(DateTime dateTime)
    {
      if (this.dvdd2kT4al.Count == 0)
        return 0.0;
      bool flag = false;
      if (this.dvdd2kT4al.Count != 0 && this.dvdd2kT4al.Last.DateTime > dateTime)
        flag = true;
      Portfolio portfolio = !flag ? this : this.Reconstruct(dateTime);
      double num = 0.0;
      foreach (Position position in (IEnumerable) portfolio.Positions.Clone())
        num += this.zEhsnQPotQ(position.GetValue(dateTime), position.Currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPositionValue()
    {
      double num = 0.0;
      foreach (Position position in (IEnumerable) this.P09d8aTdqt.Clone())
        num += this.zEhsnQPotQ(position.GetValue(), position.Currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAccountValue()
    {
      return this.d1XdlJjBqU.GetValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAccountValue(DateTime dateTime)
    {
      return this.d1XdlJjBqU.GetValue(dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue()
    {
      return this.d1XdlJjBqU.GetValue() + this.GetPositionValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(DateTime dateTime)
    {
      return this.d1XdlJjBqU.GetValue(dateTime) + this.GetPositionValue(dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetMarginValue()
    {
      double num = 0.0;
      foreach (Position position in (IEnumerable) this.P09d8aTdqt.Clone())
        num += this.zEhsnQPotQ(position.GetMarginValue(), position.Currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetMarginValue(DateTime dateTime)
    {
      if (this.dvdd2kT4al.Count == 0)
        return 0.0;
      bool flag = false;
      if (this.dvdd2kT4al.Count != 0 && this.dvdd2kT4al.Last.DateTime > dateTime)
        flag = true;
      Portfolio portfolio = !flag ? this : this.Reconstruct(dateTime);
      double num = 0.0;
      foreach (Position position in (IEnumerable) portfolio.Positions.Clone())
        num += this.zEhsnQPotQ(position.GetMarginValue(), position.Currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDebtValue()
    {
      double num = 0.0;
      foreach (Position position in this.P09d8aTdqt)
        num += this.zEhsnQPotQ(position.GetDebtValue(), position.Currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDebtValue(DateTime dateTime)
    {
      if (this.dvdd2kT4al.Count == 0)
        return 0.0;
      bool flag = false;
      if (this.dvdd2kT4al.Count != 0 && this.dvdd2kT4al.Last.DateTime > dateTime)
        flag = true;
      Portfolio portfolio = !flag ? this : this.Reconstruct(dateTime);
      double num = 0.0;
      foreach (Position position in portfolio.Positions)
        num += this.zEhsnQPotQ(position.GetDebtValue(), position.Currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCoreEquity()
    {
      return this.GetAccountValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCoreEquity(DateTime DateTime)
    {
      return this.GetAccountValue(DateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTotalEquity()
    {
      return this.GetValue() - this.GetDebtValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTotalEquity(DateTime DateTime)
    {
      return this.GetValue(DateTime) - this.GetDebtValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetLeverage()
    {
      double marginValue = this.GetMarginValue();
      if (marginValue == 0.0)
        return 0.0;
      else
        return this.GetValue() / marginValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDebtEquityRatio()
    {
      double totalEquity = this.GetTotalEquity();
      if (totalEquity == 0.0)
        return 0.0;
      else
        return this.GetDebtValue() / totalEquity;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCashFlow()
    {
      double num = 0.0;
      foreach (Position position in this.P09d8aTdqt)
        num += this.zEhsnQPotQ(position.GetCashFlow(), position.Currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNetCashFlow()
    {
      double num = 0.0;
      foreach (Position position in (IEnumerable) this.P09d8aTdqt.Clone())
        num += this.zEhsnQPotQ(position.GetNetCashFlow(), position.Currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetExposure(int tag, string val, PositionSide side)
    {
      double num = 0.0;
      foreach (Position position in (IEnumerable) this.P09d8aTdqt.Clone())
      {
        if (position.Side == side && position.Instrument.GetStringField(tag).Value == val)
          num += position.GetValue();
      }
      return num / this.GetPositionValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetExposure(int tag, string val)
    {
      double num = 0.0;
      foreach (Position position in (IEnumerable) this.P09d8aTdqt.Clone())
      {
        if (position.Instrument.GetStringField(tag).Value == val)
          num += this.zEhsnQPotQ(position.GetValue(), position.Currency);
      }
      return num / this.GetPositionValue();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.Clear(true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(bool clearPerformance)
    {
      this.Cats5kfBGV();
      this.P09d8aTdqt.Clear();
      this.dvdd2kT4al.Clear();
      this.d1XdlJjBqU.Clear();
      if (clearPerformance && this.NRUd4uRimv != null)
        this.NRUd4uRimv.GcxBG7nv0L();
      if (this.nKjdGEyCXa)
        PortfolioManager.iY2s8gqb4S(this);
      if (this.S6KdBSfi4y == null)
        return;
      this.S6KdBSfi4y((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save()
    {
      if (this.nKjdGEyCXa)
        return;
      PortfolioManager.HLQsd4XEGK(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void G7UsvA9nvQ()
    {
      foreach (Position position in this.P09d8aTdqt)
        this.yaesuiSHoR(position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cats5kfBGV()
    {
      foreach (Position position in this.P09d8aTdqt)
        this.McUsSP483C(position);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void yaesuiSHoR([In] Position obj0)
    {
      obj0.Instrument.NewBar += new BarEventHandler(this.naPsZDs2w9);
      obj0.Instrument.NewTrade += new TradeEventHandler(this.LptsANECjj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void McUsSP483C([In] Position obj0)
    {
      obj0.Instrument.NewBar -= new BarEventHandler(this.naPsZDs2w9);
      obj0.Instrument.NewTrade -= new TradeEventHandler(this.LptsANECjj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void naPsZDs2w9([In] object obj0, [In] BarEventArgs obj1)
    {
      lock (this.ux7drmUmHV)
      {
        Position local_0 = this.P09d8aTdqt[(Instrument) obj1.Instrument];
        if (local_0 == null)
          return;
        local_0.s7dBtZ7nOw();
        this.gJYsIOGcWf(local_0);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LptsANECjj([In] object obj0, [In] TradeEventArgs obj1)
    {
      lock (this.ux7drmUmHV)
      {
        Position local_0 = this.P09d8aTdqt[(Instrument) obj1.Instrument];
        if (local_0 == null)
          return;
        local_0.s7dBtZ7nOw();
        this.gJYsIOGcWf(local_0);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TrySuspendUpdates()
    {
      return Monitor.TryEnter(this.ux7drmUmHV);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SuspendUpdates()
    {
      Monitor.Enter(this.ux7drmUmHV);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResumeUpdates()
    {
      Monitor.Exit(this.ux7drmUmHV);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Ui2sg7ghMJ([In] Position obj0)
    {
      if (this.cJcsTZRIto == null)
        return;
      this.cJcsTZRIto((object) this, new PositionEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void W88s1d36mE([In] Position obj0)
    {
      if (this.PXHszRqJsA == null)
        return;
      this.PXHszRqJsA((object) this, new PositionEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eY6sogNFDu([In] Position obj0)
    {
      if (this.oXpdQAbGCD == null)
        return;
      this.oXpdQAbGCD((object) this, new PositionEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lmWsxlDsUD([In] Transaction obj0)
    {
      if (this.oYlswngCFy == null)
        return;
      this.oYlswngCFy((object) this, new TransactionEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gJYsIOGcWf([In] Position obj0)
    {
      if (this.HJ6dWyfgm9 == null)
        return;
      this.HJ6dWyfgm9((object) this, new PositionEventArgs(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void AYIsLEwh9x()
    {
      if (this.Aj9d6OW7UW == null)
        return;
      this.Aj9d6OW7UW((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return this.lvrdPnsoMs;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasPosition(Instrument instrument)
    {
      return this.P09d8aTdqt[instrument] != null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConsolidateFrom(Portfolio[] portfolioList)
    {
      this.ConsolidateFrom(portfolioList, false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConsolidateFrom(Portfolio[] portfolioList, bool cloneTransactions)
    {
      if (this.e2sdEWgJbD != null)
        this.e2sdEWgJbD((object) this, EventArgs.Empty);
      this.Mk5dJuOhmC = true;
      this.Clear(false);
      List<Portfolio> list1 = new List<Portfolio>();
      List<int> list2 = new List<int>();
      foreach (Portfolio portfolio in portfolioList)
      {
        if (portfolio.Transactions.Count > 0)
        {
          list1.Add(portfolio);
          list2.Add(0);
        }
      }
      while (list1.Count > 0)
      {
        DateTime dateTime1 = DateTime.MaxValue;
        int index1 = -1;
        for (int index2 = 0; index2 < list1.Count; ++index2)
        {
          DateTime dateTime2 = list1[index2].Transactions[list2[index2]].DateTime;
          if (dateTime2 < dateTime1)
          {
            dateTime1 = dateTime2;
            index1 = index2;
          }
        }
        Transaction transaction = cloneTransactions ? (Transaction) list1[index1].Transactions[list2[index1]].Clone() : list1[index1].Transactions[list2[index1]];
        this.Add(transaction);
        this.d1XdlJjBqU.Add(transaction.CashFlow, transaction.Currency, transaction.DateTime, transaction.Text);
        List<int> list3;
        int index3;
        (list3 = list2)[index3 = index1] = list3[index3] + 1;
        if (list2[index1] == list1[index1].Transactions.Count)
        {
          list2.RemoveAt(index1);
          list1.RemoveAt(index1);
        }
      }
      this.Mk5dJuOhmC = false;
      if (this.PcjdsX4HQ2 == null)
        return;
      this.PcjdsX4HQ2((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void LwTsbC870d([In] bool obj0)
    {
      this.Mk5dJuOhmC = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void U70sR7lQYS([In] bool obj0)
    {
      this.nKjdGEyCXa = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void O3KsaYYaRC([In] object obj0, [In] AccountTransactionEventArgs obj1)
    {
      if (this.Mk5dJuOhmC || !this.nKjdGEyCXa)
        return;
      PortfolioManager.vwIs2WhnRQ(this, obj1.Transaction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double zEhsnQPotQ([In] double obj0, [In] Currency obj1)
    {
      if (obj1 != null && this.d1XdlJjBqU.Currency != null && obj1 != this.d1XdlJjBqU.Currency)
        return obj1.Convert(obj0, this.d1XdlJjBqU.Currency);
      else
        return obj0;
    }
  }
}
