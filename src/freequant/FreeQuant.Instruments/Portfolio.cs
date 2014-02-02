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
		private const string PZwsidQPL5 = "Naming";
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
		private object ux7drmUmHV;

		[Browsable(false)]
		public int Id { get; set; }

		[Category("Naming")]
		[ReadOnly(true)]
		public string Name { get; set; }

		[Category("Naming")]
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
			this.ux7drmUmHV = new object();
		}

		public Portfolio(string name, string description)
		{
			this.Name = name;
			this.Description = description;
			PortfolioManager.Add(this);
		}

		public Portfolio(string name) : this(name, String.Empty)
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
			lock (this.ux7drmUmHV)
			{
				bool local_0 = false;
				bool local_1 = true;
				bool local_2 = false;
				Position local_3 = this.positions[transaction.Instrument];
				double local_4 = 0.0;
				double local_5 = 0.0;
				double local_6 = 0.0;
				if (local_3 == null)
				{
					local_3 = new Position(this, transaction);
					this.positions.Add(local_3);
					if (this.monitored)
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
						this.positions.Remove(local_3);
						if (this.monitored)
							this.McUsSP483C(local_3);
						local_2 = true;
					}
				}
				this.transactions.Add(transaction);
				if (!this.Mk5dJuOhmC && this.persistent)
					PortfolioManager.LfnseafCc7(this, transaction);
				this.lmWsxlDsUD(transaction);
				if (!this.Mk5dJuOhmC)
					this.account.Add(transaction.CashFlow + local_5 - local_6, transaction.Currency, transaction.DateTime, transaction.Text);
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
//      if (this.S6KdBSfi4y == null)
//        return;
//      this.S6KdBSfi4y((object) this, EventArgs.Empty);
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
				this.yaesuiSHoR(position);
		}

		private void Cats5kfBGV()
		{
			foreach (Position position in this.positions)
				this.McUsSP483C(position);
		}

		private void yaesuiSHoR([In] Position obj0)
		{
			obj0.Instrument.NewBar += new BarEventHandler(this.naPsZDs2w9);
			obj0.Instrument.NewTrade += new TradeEventHandler(this.LptsANECjj);
		}

		private void McUsSP483C([In] Position obj0)
		{
			obj0.Instrument.NewBar -= new BarEventHandler(this.naPsZDs2w9);
			obj0.Instrument.NewTrade -= new TradeEventHandler(this.LptsANECjj);
		}

		private void naPsZDs2w9([In] object obj0, [In] BarEventArgs obj1)
		{
			lock (this.ux7drmUmHV)
			{
				Position local_0 = this.positions[(Instrument)obj1.Instrument];
				if (local_0 == null)
					return;
				local_0.s7dBtZ7nOw();
				this.gJYsIOGcWf(local_0);
			}
		}

		private void LptsANECjj([In] object obj0, [In] TradeEventArgs obj1)
		{
			lock (this.ux7drmUmHV)
			{
				Position local_0 = this.positions[(Instrument)obj1.Instrument];
				if (local_0 == null)
					return;
				local_0.s7dBtZ7nOw();
				this.gJYsIOGcWf(local_0);
			}
		}

		public bool TrySuspendUpdates()
		{
			return Monitor.TryEnter(this.ux7drmUmHV);
		}

		public void SuspendUpdates()
		{
			Monitor.Enter(this.ux7drmUmHV);
		}

		public void ResumeUpdates()
		{
			Monitor.Exit(this.ux7drmUmHV);
		}

		private void Ui2sg7ghMJ([In] Position obj0)
		{
//      if (this.cJcsTZRIto == null)
//        return;
//      this.cJcsTZRIto((object) this, new PositionEventArgs(obj0));
		}

		private void W88s1d36mE([In] Position obj0)
		{
//      if (this.PXHszRqJsA == null)
//        return;
//      this.PXHszRqJsA((object) this, new PositionEventArgs(obj0));
		}

		private void eY6sogNFDu([In] Position obj0)
		{
//      if (this.oXpdQAbGCD == null)
//        return;
//      this.oXpdQAbGCD((object) this, new PositionEventArgs(obj0));
		}

		private void lmWsxlDsUD([In] Transaction obj0)
		{
//      if (this.oYlswngCFy == null)
//        return;
//      this.oYlswngCFy((object) this, new TransactionEventArgs(obj0));
		}

		private void gJYsIOGcWf([In] Position obj0)
		{
//      if (this.HJ6dWyfgm9 == null)
//        return;
//      this.HJ6dWyfgm9((object) this, new PositionEventArgs(obj0));
		}

		internal void AYIsLEwh9x()
		{
//      if (this.Aj9d6OW7UW == null)
//        return;
//      this.Aj9d6OW7UW((object) this, EventArgs.Empty);
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
//      if (this.e2sdEWgJbD != null)
//        this.e2sdEWgJbD((object) this, EventArgs.Empty);
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
//        list3 = list2)[index3 = index1] = list3[index3] + 1;
				if (list2[index1] == list1[index1].Transactions.Count)
				{
					list2.RemoveAt(index1);
					list1.RemoveAt(index1);
				}
			}
			this.Mk5dJuOhmC = false;
//      if (this.PcjdsX4HQ2 == null)
//        return;
//      this.PcjdsX4HQ2((object) this, EventArgs.Empty);
		}

		internal void LwTsbC870d([In] bool obj0)
		{
			this.Mk5dJuOhmC = obj0;
		}

		internal void U70sR7lQYS([In] bool obj0)
		{
			this.persistent = obj0;
		}

		private void O3KsaYYaRC([In] object obj0, [In] AccountTransactionEventArgs obj1)
		{
			if (this.Mk5dJuOhmC || !this.persistent)
				return;
			PortfolioManager.vwIs2WhnRQ(this, obj1.Transaction);
		}

		private double zEhsnQPotQ([In] double obj0, [In] Currency obj1)
		{
			if (obj1 != null && this.account.Currency != null && obj1 != this.account.Currency)
				return obj1.Convert(obj0, this.account.Currency);
			else
				return obj0;
		}
	}
}
