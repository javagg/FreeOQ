using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

namespace FreeQuant.Instruments
{
    public class Portfolio
    {
        private const string CATEGORY_NAMING = "Naming";
        private const bool RjashrZH84 = true;
        private const bool rSjstETkMn = false;

        private TransactionList transactions;
        private PositionList positions;
        private Account account;
        private bool monitored;
        private bool persistent;
        private MarginManager marginManager;
        private Performance performance;
        private bool Mk5dJuOhmC;
        private object dataLock;

        [Browsable(false)]
        public int Id { get; set; }

        [Category(CATEGORY_NAMING)]
        [ReadOnly(true)]
        public string Name { get; set; }

        [Category(CATEGORY_NAMING)]
        public string Description { get; set; }

        [Browsable(false)]
        public PositionList Positions
        {
            get
            {
                return this.positions; 
            }
        }

        [Browsable(false)]
        public TransactionList Transactions
        {
            get
            {
                return this.transactions;  
            }
        }

        [Browsable(false)]
        public Account Account
        {
            get
            {
                return this.account;  
            }
        }

        [Browsable(false)]
        public Performance Performance
        {
            get
            {
                return this.performance; 
            }
        }

        [DefaultValue(true)]
        public bool Monitored
        {
            get
            {
                return this.monitored; 
            }
            set
            {
                if (value)
                {
                    if (!this.monitored)
                        this.G7UsvA9nvQ();
                }
                else if (this.monitored)
                    this.Cats5kfBGV();
                this.monitored = value;
            }
        }

        [DefaultValue(false)]
        public bool Persistent
        {
            get
            {
                return this.persistent; 
            }
            set
            {
                if (this.persistent == value)
                    return;
                if (value)
                    this.Save();
                this.persistent = value;
                PortfolioManager.Update(this);
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

        public Portfolio()
        {
            this.Id = -1;
            this.transactions = new TransactionList();
            this.positions = new PositionList();
            this.account = new Account();
            this.account.TransactionAdded += new AccountTransactionEventHandler(this.O3KsaYYaRC);
            this.monitored = true;
            this.persistent = false;
            this.marginManager = new MarginManager();
            this.marginManager.Enabled = false;
            this.performance = new Performance(this);
            this.dataLock = new object();
        }

        public Portfolio(string name, string description) : this()
        {
            this.Name = name;
            this.Description = description;
            PortfolioManager.Add(this);
        }

        public Portfolio(string name) : this(name, string.Empty)
        {
        }

        public void Add(DateTime datetime, Side side, double qty, Instrument instrument, double price, double commission, CommType commType)
        {
            this.Add(new Transaction(datetime, side, qty, instrument, price, commission, commType));
        }

        public void Add(DateTime datetime, Side side, double qty, Instrument instrument, double price)
        {
            this.Add(new Transaction(datetime, side, qty, instrument, price));
        }

        public void Add(DateTime datetime, Side side, double qty, string symbol, double price, double commission, CommType commType)
        {
            Instrument instrument = InstrumentManager.Instruments[symbol];
            if (instrument == null)
                throw new ArgumentException("ddd" + this.Name + symbol);
            else
                this.Add(new Transaction(datetime, side, qty, instrument, price, commission, commType));
        }

        public void Add(DateTime datetime, Side side, double qty, string symbol, double price)
        {
            Instrument instrument = InstrumentManager.Instruments[symbol];
            if (instrument == null)
                throw new ArgumentException(this.Name + symbol);
            else
                this.Add(new Transaction(datetime, side, qty, instrument, price));
        }

        public void Add(Transaction transaction)
        {
            lock (this.dataLock)
            {
                bool posOpened = false;
                bool posChanged = true;
                bool posClosed = false;
                double local_4 = 0.0;
                double local_5 = 0.0;
                double local_6 = 0.0;

                Position position = this.positions[transaction.Instrument];
                if (position == null)
                {
                    position = new Position(this, transaction);
                    this.positions.Add(position);
                    if (this.monitored)
                        this.WatchPosition(position);
                    if (transaction.Margin != 0.0)
                    {
                        local_4 = transaction.Margin;
                        local_6 = 0.0;
                        local_5 = transaction.Debt;
                        position.Margin = transaction.Margin;
                        position.Debt = transaction.Debt;
                    }
                    posOpened = true;
                }
                else
                {
                    if (transaction.Margin != 0.0)
                    {
                        if (position.Side == PositionSide.Long && transaction.Side == Side.Buy || position.Side == PositionSide.Short && (transaction.Side == Side.Sell || transaction.Side == Side.SellShort))
                        {
                            local_4 = transaction.Margin;
                            local_6 = 0.0;
                            local_5 = transaction.Debt;
                            position.Margin += transaction.Margin;
                            position.Debt += transaction.Debt;
                        }
                        if (position.Side == PositionSide.Long && (transaction.Side == Side.Sell || transaction.Side == Side.SellShort) || position.Side == PositionSide.Short && transaction.Side == Side.Buy)
                        {
                            if (position.Qty == transaction.Qty)
                            {
                                double temp_152 = position.Margin;
                                local_4 = 0.0;
                                local_6 = position.Debt;
                                local_5 = 0.0;
                                position.Margin = 0.0;
                                position.Debt = 0.0;
                            }
                            else if (position.Qty > transaction.Qty)
                            {
                                double temp_131 = transaction.Margin;
                                local_4 = 0.0;
                                local_6 = position.Debt * transaction.Qty / position.Qty;
                                local_5 = 0.0;
                                position.Margin -= transaction.Margin;
                                position.Debt -= local_6;
                            }
                            else
                            {
                                double local_7 = transaction.Qty - position.Qty;
                                double local_8 = local_7 * transaction.Price;
                                if (transaction.Instrument.Factor != 0.0)
                                    local_8 *= transaction.Instrument.Factor;
                                double temp_110 = position.Margin;
                                double local_4_1 = transaction.Instrument.Margin * local_7;
                                local_6 = position.Debt;
                                local_5 = local_8 - local_4_1;
                                position.Margin = local_4_1;
                                position.Debt = local_5;
                            }
                        }
                    }
                    position.Add(transaction);
                    if (position.Qty == 0.0)
                    {
                        this.positions.Remove(position);
                        if (this.monitored)
                            this.UnWatchPosition(position);
                        posClosed = true;
                    }
                }
                this.transactions.Add(transaction);
                if (!this.Mk5dJuOhmC && this.persistent)
                    PortfolioManager.Add(this, transaction);
                this.EmitTransactionAdded(transaction);
                if (!this.Mk5dJuOhmC)
                    this.account.Add(transaction.CashFlow + local_5 - local_6, transaction.Currency, transaction.DateTime, transaction.Text);
                if (posOpened)
                    this.EmitPositionOpened(position);
                if (posChanged)
                    this.EmitPositionChanged(position);
                if (posClosed)
                    this.EmitPositionClosed(position);
                this.EmitCompositionChanged();
                if (this.Mk5dJuOhmC)
                    return;
                this.EmitValueChanged(position);
            }
        }

        public Portfolio Reconstruct(DateTime dateTime)
        {
            Portfolio portfolio = new Portfolio();
            foreach (Transaction transaction in this.transactions)
            {
                if (transaction.DateTime <= dateTime)
                    portfolio.Add(transaction);
            }
            portfolio.Account.Clear();
            foreach (AccountTransaction transaction in this.account.Transactions)
            {
                if (transaction.DateTime <= dateTime)
                    portfolio.Account.Add(transaction);
            }
            return portfolio;
        }

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

        public bool Contains(Instrument instrument)
        {
            return this.positions.Contains(instrument);
        }

        public double GetPositionValue(DateTime dateTime)
        {
            if (this.transactions.Count == 0)
                return 0.0;
            bool flag = false;
            if (this.transactions.Count != 0 && this.transactions.Last.DateTime > dateTime)
                flag = true;
            Portfolio portfolio = !flag ? this : this.Reconstruct(dateTime);
            double num = 0.0;
            foreach (Position position in (IEnumerable) portfolio.Positions.Clone())
                num += this.zEhsnQPotQ(position.GetValue(dateTime), position.Currency);
            return num;
        }

        public double GetPositionValue()
        {
            double num = 0.0;
            foreach (Position position in (IEnumerable) this.positions.Clone())
                num += this.zEhsnQPotQ(position.GetValue(), position.Currency);
            return num;
        }

        public double GetAccountValue()
        {
            return this.account.GetValue();
        }

        public double GetAccountValue(DateTime dateTime)
        {
            return this.account.GetValue(dateTime);
        }

        public double GetValue()
        {
            return this.account.GetValue() + this.GetPositionValue();
        }

        public double GetValue(DateTime dateTime)
        {
            return this.account.GetValue(dateTime) + this.GetPositionValue(dateTime);
        }

        public double GetMarginValue()
        {
            double num = 0.0;
            foreach (Position position in (IEnumerable) this.positions.Clone())
                num += this.zEhsnQPotQ(position.GetMarginValue(), position.Currency);
            return num;
        }

        public double GetMarginValue(DateTime dateTime)
        {
            if (this.transactions.Count == 0)
                return 0.0;
            bool flag = false;
            if (this.transactions.Count != 0 && this.transactions.Last.DateTime > dateTime)
                flag = true;
            Portfolio portfolio = !flag ? this : this.Reconstruct(dateTime);
            double num = 0.0;
            foreach (Position position in (IEnumerable) portfolio.Positions.Clone())
                num += this.zEhsnQPotQ(position.GetMarginValue(), position.Currency);
            return num;
        }

        public double GetDebtValue()
        {
            double num = 0.0;
            foreach (Position position in this.positions)
                num += this.zEhsnQPotQ(position.GetDebtValue(), position.Currency);
            return num;
        }

        public double GetDebtValue(DateTime dateTime)
        {
            if (this.transactions.Count == 0)
                return 0.0;
            bool flag = false;
            if (this.transactions.Count != 0 && this.transactions.Last.DateTime > dateTime)
                flag = true;
            Portfolio portfolio = !flag ? this : this.Reconstruct(dateTime);
            double num = 0.0;
            foreach (Position position in portfolio.Positions)
                num += this.zEhsnQPotQ(position.GetDebtValue(), position.Currency);
            return num;
        }

        public double GetCoreEquity()
        {
            return this.GetAccountValue();
        }

        public double GetCoreEquity(DateTime DateTime)
        {
            return this.GetAccountValue(DateTime);
        }

        public double GetTotalEquity()
        {
            return this.GetValue() - this.GetDebtValue();
        }

        public double GetTotalEquity(DateTime DateTime)
        {
            return this.GetValue(DateTime) - this.GetDebtValue();
        }

        public double GetLeverage()
        {
            double marginValue = this.GetMarginValue();
            if (marginValue == 0.0)
                return 0.0;
            else
                return this.GetValue() / marginValue;
        }

        public double GetDebtEquityRatio()
        {
            double totalEquity = this.GetTotalEquity();
            if (totalEquity == 0.0)
                return 0.0;
            else
                return this.GetDebtValue() / totalEquity;
        }

        public double GetCashFlow()
        {
            double num = 0.0;
            foreach (Position position in this.positions)
                num += this.zEhsnQPotQ(position.GetCashFlow(), position.Currency);
            return num;
        }

        public double GetNetCashFlow()
        {
            double num = 0.0;
            foreach (Position position in (IEnumerable) this.positions.Clone())
                num += this.zEhsnQPotQ(position.GetNetCashFlow(), position.Currency);
            return num;
        }

        public virtual double GetExposure(int tag, string val, PositionSide side)
        {
            double num = 0.0;
            foreach (Position position in (IEnumerable) this.positions.Clone())
            {
                if (position.Side == side && position.Instrument.GetStringField(tag).Value == val)
                    num += position.GetValue();
            }
            return num / this.GetPositionValue();
        }

        public virtual double GetExposure(int tag, string val)
        {
            double num = 0.0;
            foreach (Position position in (IEnumerable) this.positions.Clone())
            {
                if (position.Instrument.GetStringField(tag).Value == val)
                    num += this.zEhsnQPotQ(position.GetValue(), position.Currency);
            }
            return num / this.GetPositionValue();
        }

        public void Clear()
        {
            this.Clear(true);
        }

        public void Clear(bool clearPerformance)
        {
            this.Cats5kfBGV();
            this.positions.Clear();
            this.transactions.Clear();
            this.account.Clear();
            if (clearPerformance && this.performance != null)
                this.performance.GcxBG7nv0L();
            if (this.persistent)
                PortfolioManager.Clear(this);
            if (this.Cleared != null)
                this.Cleared(this, EventArgs.Empty);
        }

        public void Save()
        {
            if (this.persistent)
                return;
            PortfolioManager.Save(this);
        }

        private void G7UsvA9nvQ()
        {
            foreach (Position position in this.positions)
                this.WatchPosition(position);
        }

        private void Cats5kfBGV()
        {
            foreach (Position position in this.positions)
                this.UnWatchPosition(position);
        }

        private void WatchPosition(Position position)
        {
            position.Instrument.NewBar += new BarEventHandler(this.OnNewBar);
            position.Instrument.NewTrade += new TradeEventHandler(this.OnNewTrade);
        }

        private void UnWatchPosition(Position position)
        {
            position.Instrument.NewBar -= new BarEventHandler(this.OnNewBar);
            position.Instrument.NewTrade -= new TradeEventHandler(this.OnNewTrade);
        }

        private void OnNewBar(object sender, BarEventArgs e)
        {
            lock (this.dataLock)
            {
                Position position = this.positions[(Instrument)e.Instrument];
                if (position != null)
                {
                    position.EmitValueChanged();
                    this.EmitValueChanged(position);
                }
            }
        }

        private void OnNewTrade(object sender, TradeEventArgs e)
        {
            lock (this.dataLock)
            {
                Position position = this.positions[(Instrument)e.Instrument];
                if (position != null)
                {
                    position.EmitValueChanged();
                    this.EmitValueChanged(position);
                }
            }
        }

        public bool TrySuspendUpdates()
        {
            return Monitor.TryEnter(this.dataLock);
        }

        public void SuspendUpdates()
        {
            Monitor.Enter(this.dataLock);
        }

        public void ResumeUpdates()
        {
            Monitor.Exit(this.dataLock);
        }

        private void EmitPositionOpened(Position position)
        {
            if (this.PositionOpened != null)
                this.PositionOpened(this, new PositionEventArgs(position));
        }

        private void EmitPositionClosed(Position position)
        {
            if (this.PositionClosed != null)
                this.PositionClosed(this, new PositionEventArgs(position));
        }

        private void EmitPositionChanged(Position position)
        {
            if (this.PositionChanged != null)
                this.PositionChanged(this, new PositionEventArgs(position));
        }

        private void EmitTransactionAdded(Transaction transaction)
        {
            if (this.TransactionAdded != null)
                this.TransactionAdded(this, new TransactionEventArgs(transaction));
        }

        private void EmitValueChanged(Position position)
        {
            if (this.ValueChanged != null)
                this.ValueChanged(this, new PositionEventArgs(position));
        }

        internal void EmitCompositionChanged()
        {
            if (this.CompositionChanged == null)
                return;
            this.CompositionChanged(this, EventArgs.Empty);
        }

        public override string ToString()
        {
            return this.Name;
        }

        public bool HasPosition(Instrument instrument)
        {
            return this.positions[instrument] != null;
        }

        public void ConsolidateFrom(Portfolio[] portfolioList)
        {
            this.ConsolidateFrom(portfolioList, false);
        }

        public void ConsolidateFrom(Portfolio[] portfolioList, bool cloneTransactions)
        {
            if (this.ConsolidationStarted != null)
                this.ConsolidationStarted(this, EventArgs.Empty);

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
                Transaction transaction = cloneTransactions ? (Transaction)list1[index1].Transactions[list2[index1]].Clone() : list1[index1].Transactions[list2[index1]];
                this.Add(transaction);
                this.account.Add(transaction.CashFlow, transaction.Currency, transaction.DateTime, transaction.Text);
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
            if (this.ConsolidationFinished != null)
                this.ConsolidationFinished(this, EventArgs.Empty);
        }

        internal void LwTsbC870d(bool obj0)
        {
            this.Mk5dJuOhmC = obj0;
        }

        internal void U70sR7lQYS(bool obj0)
        {
            this.persistent = obj0;
        }

        private void O3KsaYYaRC(object sender, AccountTransactionEventArgs e)
        {
            if (this.Mk5dJuOhmC || !this.persistent)
                return;
            PortfolioManager.vwIs2WhnRQ(this, e.Transaction);
        }

        private double zEhsnQPotQ(double obj0, Currency obj1)
        {
            if (obj1 != null && this.account.Currency != null && obj1 != this.account.Currency)
                return obj1.Convert(obj0, this.account.Currency);
            else
                return obj0;
        }
    }
}
