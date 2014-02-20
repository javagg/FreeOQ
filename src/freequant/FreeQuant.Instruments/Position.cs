using FreeQuant;
using System;
using System.ComponentModel;

namespace FreeQuant.Instruments
{
    public class Position
    {
        private int rik6WLpoo8;
        private TransactionList transactions;
        private Portfolio portfolio;
        private Instrument instrument;
        private double qtyBought;
        private double qtySold;
        private double qtySoldShort;
        private double margin;
        private double debt;
        private int GIf68BaEWm;
        private double WLw6lrSTTe;

        public string Name
        {
            get
            {
                if (this.instrument == null)
                    throw new ApplicationException("Instrument is null");
                else
                    return this.instrument.Symbol;
            }
        }

        public Portfolio Portfolio
        {
            get
            {
                return this.portfolio; 
            }
        }

        public Instrument Instrument { get; private set; }

        [Browsable(false)]
        public TransactionList Transactions
        {
            get
            {
                return this.transactions;  
            }
        }

        public Currency Currency
        {
            get
            {
                return this.transactions[0].Currency;
            }
        }

        public PositionSide Side
        {
            get
            {
                return this.Amount >= 0.0 ? PositionSide.Long : PositionSide.Short;
            }
        }

        public double EntryPrice
        {
            get
            {
                return this.transactions[0].Price;
            }
        }

        public DateTime EntryDate
        {
            get
            {
                return this.transactions[0].DateTime;
            }
        }

        public double EntryQty
        {
            get
            {
                return this.transactions[0].Qty;
            }
        }

        public double Amount
        {
            get
            {
                return this.qtyBought - this.qtySold - this.qtySoldShort;
            }
        }

        public double Qty
        {
            get
            {
                return Math.Abs(this.Amount);
            }
        }

        public double QtyBought
        {
            get
            {
                return this.qtyBought; 
            }
        }

        public double QtySold
        {
            get
            {
                return this.qtySold; 
            }
        }

        public double QtySoldShort
        {
            get
            {
                return this.qtySoldShort; 
            }
        }

        [ReadOnly(true)]
        public double Margin
        {
            get
            {
                return this.margin; 
            }
            set
            {
                this.margin = value;
            }
        }

        [ReadOnly(true)]
        public double Debt
        {
            get
            {
                return this.debt; 
            }
            set
            {
                this.debt = value;
            }
        }

        public event EventHandler ValueChanged;

        public Position(Portfolio portfolio, Instrument instrument)
        {

            this.rik6WLpoo8 = -1;
            this.transactions = new TransactionList();
            this.GIf68BaEWm = -1;
            this.portfolio = portfolio;
            this.instrument = instrument;
        }

        public Position(Portfolio portfolio, Transaction transaction)
        {

            this.rik6WLpoo8 = -1;
            this.transactions = new TransactionList();
            this.GIf68BaEWm = -1;

            this.portfolio = portfolio;
            this.instrument = transaction.Instrument;
            this.Add(transaction);
        }

        internal void EmitValueChanged()
        {
            if (this.ValueChanged != null)
                this.ValueChanged(this, EventArgs.Empty);
        }

        internal int sZ3BwAXKCB()
        {
            return this.rik6WLpoo8;
        }

        internal void jgrBTalT0J(int value)
        {
            this.rik6WLpoo8 = value;
        }

        public string SideToString()
        {
            switch (this.Side)
            {
                case PositionSide.Long:
                    return "Long";
                case PositionSide.Short:
                    return "Short";
                default:
                    throw new NotSupportedException("" + (object)this.Side);
            }
        }

        public void Add(Transaction transaction)
        {
            if (this.instrument != transaction.Instrument)
                throw new ArgumentException("dfsf" + transaction.Instrument.Symbol + this.instrument.Symbol);
            double num1 = 0.0;
            double num2 = 0.0;
            int num3 = Math.Sign(transaction.Amount);
            if (this.transactions.Count == 0)
            {
                this.GIf68BaEWm = 0;
                this.WLw6lrSTTe = transaction.Qty;
            }
            else if (this.Side == PositionSide.Long && num3 == -1 || this.Side == PositionSide.Short && num3 == 1)
            {
                int index = this.GIf68BaEWm + 1;
                double qty = transaction.Qty;
                double num4 = 0.0;
                double num5 = Math.Min(qty, this.WLw6lrSTTe);
                double num6 = num4 + this.WLw6lrSTTe;
                num2 += num5 * (transaction.Cost / transaction.Qty + this.transactions[this.GIf68BaEWm].Cost / this.transactions[this.GIf68BaEWm].Qty);
                num1 += (transaction.Price - this.transactions[this.GIf68BaEWm].Price) * num5 * (double)-num3;
                for (; qty > num6 && index < this.transactions.Count; ++index)
                {
                    Transaction transaction1 = this.transactions[index];
                    if (Math.Sign(transaction1.Amount) != num3)
                    {
                        double num7 = Math.Min(qty - num6, transaction1.Qty);
                        num2 += num7 * (transaction.Cost / transaction.Qty + transaction1.Cost / transaction1.Qty);
                        num1 += (transaction.Price - transaction1.Price) * num7 * (double)-num3;
                        num6 += transaction1.Qty;
                    }
                }
                this.WLw6lrSTTe = Math.Abs(qty - num6);
                this.GIf68BaEWm = qty == num6 && index == this.transactions.Count || qty > num6 ? this.transactions.Count : index - 1;
            }
            if (this.instrument.Factor != 0.0)
                num1 *= this.instrument.Factor;
            transaction.PnL = num1 - transaction.Cost;
            transaction.RealizedPnL = num1 - num2;
            if ((this.Amount + transaction.Amount) * this.Amount < 0.0)
            {
                if (transaction.Amount < 0.0)
                {
                    this.qtySoldShort += this.WLw6lrSTTe;
                    this.qtySold += transaction.Qty - this.WLw6lrSTTe;
                }
                else
                    this.qtyBought += transaction.Qty;
            }
            else if (transaction.Amount < 0.0)
            {
                if (this.Amount <= 0.0)
                    this.qtySoldShort += transaction.Qty;
                else
                    this.qtySold += transaction.Qty;
            }
            else
                this.qtyBought += transaction.Qty;
            this.transactions.Add(transaction);
        }

        public double Price(DateTime datetime)
        {
            return this.instrument.Price(datetime);
        }

        public double Price()
        {
            return PortfolioManager.Pricer.Price(this);
        }

        public double GetValue(DateTime datetime)
        {
            if (this.instrument.Factor != 0.0)
                return this.Price(datetime) * this.Amount * this.instrument.Factor;
            else
                return this.Price(datetime) * this.Amount;
        }

        public double GetValue()
        {
            if (this.instrument.Factor != 0.0)
                return this.Price() * this.Amount * this.instrument.Factor;
            else
                return this.Price() * this.Amount;
        }

        public double GetMarginValue()
        {
            return this.margin;
        }

        public double GetDebtValue()
        {
            return this.debt;
        }

        public double GetLeverage()
        {
            double marginValue = this.GetMarginValue();
            if (marginValue == 0.0)
                return 0.0;
            else
                return this.GetValue() / marginValue;
        }

        public double GetCashFlow()
        {
            double num = 0.0;
            foreach (Transaction transaction in this.transactions)
                num += transaction.CashFlow;
            return num;
        }

        public double GetNetCashFlow()
        {
            double num = 0.0;
            foreach (Transaction transaction in this.transactions)
                num += transaction.NetCashFlow;
            return num;
        }

        public double GetPnL()
        {
            return this.GetValue() + this.GetCashFlow();
        }

        public double GetNetPnL()
        {
            return this.GetValue() + this.GetNetCashFlow();
        }

        public double GetPnLPercent()
        {
            return this.GetPnL() / this.transactions[0].Value;
        }

        public double GetNetPnLPercent()
        {
            return this.GetNetPnL() / this.transactions[0].Value;
        }

        public double GetUnrealizedPnL()
        {
            if (this.Qty == 0.0)
                return 0.0;
            double num1 = this.instrument.Price();
            double num2 = 0.0;
            int num3 = this.Side == PositionSide.Long ? -1 : 1;
            double num4 = this.WLw6lrSTTe;
            double num5 = num2 + (num1 - this.transactions[this.GIf68BaEWm].Price) * num4 * (double)-num3;
            for (int index = this.GIf68BaEWm + 1; index < this.transactions.Count; ++index)
            {
                Transaction transaction = this.transactions[index];
                num5 += (num1 - transaction.Price) * num4 * (double)-num3;
            }
            if (this.Instrument.Factor != 0.0)
                return num5 * this.Instrument.Factor;
            else
                return num5;
        }

        public TimeSpan GetDuration()
        {
            return Clock.Now - this.transactions[0].DateTime;
        }

        public override string ToString()
        {
            return this.SideToString() + (string)(object)this.Qty + this.instrument.Symbol;
        }
    }
}
