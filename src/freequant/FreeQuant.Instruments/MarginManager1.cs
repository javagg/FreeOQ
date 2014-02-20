using FreeQuant.FIX;
using System;
using System.Collections;

namespace FreeQuant.Instruments
{
    public class MarginManager1
    {
        private Portfolio portfolio;
        private Hashtable nTCs7Rw8ms;

        public MarginManager1(Portfolio portfolio)
        {
            this.nTCs7Rw8ms = new Hashtable();
            this.portfolio = portfolio;
            this.Connect();
        }

        protected virtual void Connect()
        {
            foreach (Position position in this.portfolio.Positions)
                position.ValueChanged += new EventHandler(this.OnPositionValueChanged);
            this.portfolio.PositionOpened += new PositionEventHandler(this.OnPositionOpened);
            this.portfolio.PositionClosed += new PositionEventHandler(this.OnPositionClosed);
            this.portfolio.PositionChanged += new PositionEventHandler(this.OnPositionChanged);
            this.portfolio.TransactionAdded += new TransactionEventHandler(this.OnTransactionAdded);
        }

        protected virtual void Disconnect()
        {
            foreach (Position position in this.portfolio.Positions)
                position.ValueChanged -= new EventHandler(this.OnPositionValueChanged);
            this.portfolio.PositionOpened -= new PositionEventHandler(this.OnPositionOpened);
            this.portfolio.PositionClosed -= new PositionEventHandler(this.OnPositionClosed);
            this.portfolio.PositionChanged -= new PositionEventHandler(this.OnPositionChanged);
            this.portfolio.TransactionAdded -= new TransactionEventHandler(this.OnTransactionAdded);
        }

        private void OnPositionValueChanged(object sender, EventArgs e)
        {
        }

        private void OnPositionOpened(object sender, PositionEventArgs e)
        {
            Position position = e.Position;
            Transaction last = position.Transactions.Last;
            MarginPosition marginPosition = new MarginPosition(position);
            // FIXME: SecurityType == ?
            if (last.Instrument.SecurityType == "?" && last.Side == Side.Buy)
            {
                marginPosition.Margin = last.Value * 0.5;
                this.nTCs7Rw8ms.Add(position, marginPosition);
                this.portfolio.Account.Deposit(marginPosition.Margin, last.Currency, last.DateTime, "dfdf");
            }
            position.ValueChanged += new EventHandler(this.OnPositionValueChanged);
        }

        private void OnPositionClosed(object sender, PositionEventArgs e)
        {
            Position position = e.Position;
            Transaction last = position.Transactions.Last;
            MarginPosition marginPosition = new MarginPosition(position);
            // FIXME: SecurityType == ?
            if (last.Instrument.SecurityType == "?" && last.Side == Side.Sell)
            {
                this.nTCs7Rw8ms.Remove(position);
                this.portfolio.Account.Withdraw(marginPosition.Margin, last.Currency, last.DateTime, "ddfss");
            }
            e.Position.ValueChanged -= new EventHandler(this.OnPositionValueChanged);
        }

        private void OnPositionChanged(object sender, PositionEventArgs e)
        {
        }

        private void OnTransactionAdded(object sender, TransactionEventArgs e)
        {
        }
    }
}
