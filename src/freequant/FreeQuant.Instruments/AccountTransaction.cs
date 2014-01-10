using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class AccountTransaction
  {
    internal int pJ6B1pDREG;
    internal DateTime dateTime;
    internal Currency currency;
    internal double value;
    internal Transaction transaction;
    internal string text;

    public AccountAction Action
    {
       get
      {
        return this.value < 0.0 ? AccountAction.Withdraw : AccountAction.Deposit;
      }
    }

    [ReadOnly(true)]
    public double Value
    {
        get
      {
				return this.value; 
      }
       set
      {
        this.value = value;
      }
    }

    public Currency Currency
    {
      get
      {
				return this.currency; 
      }
      set
      {
        this.currency = value;
      }
    }

    [ReadOnly(true)]
    public DateTime DateTime
    {
      get
      {
				return this.dateTime; 
      }
      set
      {
        this.dateTime = value;
      }
    }

    [Browsable(false)]
    public Transaction Transaction
    {
      get
      {
				return this.transaction; 
      }
    }

    public string Text
    {
       get
      {
				return this.text; 
      }
       set
      {
        this.text = value;
      }
    }

    public AccountTransaction()
    {

      this.pJ6B1pDREG = -1;
    }

    public AccountTransaction(double val, Currency currency, DateTime dateTime, string text)
    {
      this.pJ6B1pDREG = -1;
      this.value = val;
      this.currency = currency;
      this.dateTime = dateTime;
      this.text = text;
    }

    public AccountTransaction(double val, Currency currency, DateTime dateTime)
    {
      this.pJ6B1pDREG = -1;
      this.value = val;
      this.currency = currency;
      this.dateTime = dateTime;
    }

    public AccountTransaction(double val, Currency currency, string text)
    {
      this.pJ6B1pDREG = -1;
      this.value = val;
      this.currency = currency;
      this.dateTime = Clock.Now;
      this.text = text;
    }

    
    public AccountTransaction(double val, Currency currency)
    {

      this.pJ6B1pDREG = -1;
      this.value = val;
      this.currency = currency;
      this.dateTime = Clock.Now;
    }

    public AccountTransaction(Transaction transaction)
    {

      this.pJ6B1pDREG = -1;
      this.value = transaction.CashFlow;
      this.currency = transaction.Currency;
      this.dateTime = transaction.DateTime;
      this.text = transaction.Text;
      this.transaction = transaction;
    }

    [SpecialName]
    internal int S0tBZ03o6G()
    {
      return this.pJ6B1pDREG;
    }

    [SpecialName]
    internal void G7YBAhR7LA(int value)
    {
      this.pJ6B1pDREG = value;
    }

    public string ActionToString()
    {
      switch (this.Action)
      {
        case AccountAction.Withdraw:
					return "Withdraw";
        case AccountAction.Deposit:
					return "Deposit";
        default:
					return "NoWithdraw";
      }
    }
  }
}
