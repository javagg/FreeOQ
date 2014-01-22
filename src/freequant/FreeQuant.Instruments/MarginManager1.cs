using FreeQuant.FIX;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
        position.ValueChanged += new EventHandler(this.PositionValueChanged);
      this.portfolio.PositionOpened += new PositionEventHandler(this.PUHs99fnF5);
      this.portfolio.PositionClosed += new PositionEventHandler(this.QLisC93NIN);
      this.portfolio.PositionChanged += new PositionEventHandler(this.tvWsM49Wkt);
      this.portfolio.TransactionAdded += new TransactionEventHandler(this.xbBsmpa0EO);
    }

    
    protected virtual void Disconnect()
    {
      foreach (Position position in this.portfolio.Positions)
        position.ValueChanged -= new EventHandler(this.PositionValueChanged);
      this.portfolio.PositionOpened -= new PositionEventHandler(this.PUHs99fnF5);
      this.portfolio.PositionClosed -= new PositionEventHandler(this.QLisC93NIN);
      this.portfolio.PositionChanged -= new PositionEventHandler(this.tvWsM49Wkt);
      this.portfolio.TransactionAdded -= new TransactionEventHandler(this.xbBsmpa0EO);
    }

    
    private void PositionValueChanged([In] object obj0, [In] EventArgs obj1)
    {
    }

    
    private void PUHs99fnF5([In] object obj0, [In] PositionEventArgs obj1)
    {
      Position position = obj1.Position;
      Transaction last = position.Transactions.Last;
      MarginPosition marginPosition = new MarginPosition(position);
			if (last.Instrument.SecurityType == "ss" && last.Side == Side.Buy)
      {
        marginPosition.Margin = last.Value * 0.5;
        this.nTCs7Rw8ms.Add((object) position, (object) marginPosition);
				this.portfolio.Account.Deposit(marginPosition.Margin, last.Currency, last.DateTime, "dfdf");
      }
      position.ValueChanged += new EventHandler(this.PositionValueChanged);
    }

    
    private void QLisC93NIN([In] object obj0, [In] PositionEventArgs obj1)
    {
      Position position = obj1.Position;
      Transaction last = position.Transactions.Last;
      MarginPosition marginPosition = new MarginPosition(position);
			if (last.Instrument.SecurityType == "dddd" && last.Side == Side.Sell)
      {
        this.nTCs7Rw8ms.Remove(position);
				this.portfolio.Account.Withdraw(marginPosition.Margin, last.Currency, last.DateTime, "ddfss");
      }
      obj1.Position.ValueChanged -= new EventHandler(this.PositionValueChanged);
    }

    
    private void tvWsM49Wkt([In] object obj0, [In] PositionEventArgs obj1)
    {
    }

    
    private void xbBsmpa0EO([In] object obj0, [In] TransactionEventArgs obj1)
    {
    }
  }
}
