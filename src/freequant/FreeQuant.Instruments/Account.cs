using FreeQuant;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
  [Serializable]
  public class Account
  {
    private string DgS6XFeLsB;
    private string description;
	private Currency currency; 
    private AccountTransactionList transactions;
    private AccountPositionList positions;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DgS6XFeLsB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.DgS6XFeLsB = value;
      }
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
				return this.description; 
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.description = value;
      }
    }

    public AccountTransactionList Transactions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
				return this.transactions;
      }
    }

    public AccountPositionList Positions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
				return this.positions; 
      }
    }

    public Currency Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.currency;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.currency = value;
      }
    }

    public double this[Currency currency]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        AccountPosition accountPosition = this.positions[currency];
        if (accountPosition != null)
          return accountPosition.Value;
        else
          return 0.0;
      }
    }

    public event EventHandler AccountChanged;

    public event AccountTransactionEventHandler TransactionAdded;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Account(string name, string description, Currency currency)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.transactions = new AccountTransactionList();
      this.positions = new AccountPositionList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.DgS6XFeLsB = name;
      this.description = description;
      this.currency = currency;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Account(string name, string description)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, description, CurrencyManager.DefaultCurrency);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Account(string name)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Account(string name, Currency currency)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector(name, "", currency);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Account(Currency currency)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector("", currency);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Account()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      this.\u002Ector(CurrencyManager.DefaultCurrency);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue()
    {
      double num = 0.0;
      foreach (AccountPosition accountPosition in this.positions)
        num += Currency.Convert(accountPosition.Value, accountPosition.Currency, this.currency);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(DateTime dateTime)
    {
      Account account = new Account(this.currency);
      foreach (AccountTransaction transaction in this.transactions)
      {
        if (transaction.DateTime <= dateTime)
          account.Add(transaction);
      }
      double num = 0.0;
      foreach (AccountPosition accountPosition in account.Positions)
        num += Currency.Convert(accountPosition.Value, accountPosition.Currency, this.currency, dateTime);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.transactions.Clear();
      this.positions.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(AccountTransaction transaction)
    {
      AccountPosition position = this.positions[transaction.Currency];
      if (position == null)
      {
        position = new AccountPosition(transaction.Currency);
        this.positions.Add(position);
      }
      this.transactions.Add(transaction);
      this.ciP6G6y5gB(transaction);
      position.y1ms0plk33 += transaction.Value;
      this.tom6YJohef();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Transaction transaction)
    {
      this.Add(new AccountTransaction(transaction));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(double val, Currency currency, DateTime dateTime, string text)
    {
      this.Add(new AccountTransaction(val, currency, dateTime, text));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(double val, Currency currency, DateTime dateTime)
    {
      this.Add(new AccountTransaction(val, currency, dateTime));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(double val, Currency currency, string text)
    {
      this.Add(val, currency, Clock.Now, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(double val, Currency currency)
    {
      this.Add(val, currency, Clock.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(double val, DateTime dateTime)
    {
      this.Add(val, this.currency, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(double val)
    {
      this.Add(val, this.currency, Clock.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, Currency currency, DateTime dateTime, string text)
    {
      this.Add(val, currency, dateTime, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, Currency currency, DateTime dateTime)
    {
      this.Add(val, currency, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, Currency currency)
    {
      this.Deposit(val, currency, Clock.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val)
    {
      this.Deposit(val, this.currency, Clock.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, DateTime dateTime)
    {
      this.Deposit(val, this.currency, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, string text)
    {
      this.Deposit(val, this.currency, Clock.Now, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, DateTime dateTime, string text)
    {
      this.Deposit(val, this.currency, dateTime, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, Currency currency, DateTime dateTime, string text)
    {
      this.Add(-Math.Abs(val), currency, dateTime, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, Currency currency, DateTime dateTime)
    {
      this.Add(-Math.Abs(val), currency, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, Currency currency)
    {
      this.Withdraw(val, currency, Clock.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val)
    {
      this.Withdraw(val, this.currency, Clock.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, DateTime dateTime)
    {
      this.Withdraw(val, this.currency, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, string text)
    {
      this.Withdraw(val, this.currency, Clock.Now, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, DateTime dateTime, string text)
    {
      this.Withdraw(val, this.currency, dateTime, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tom6YJohef()
    {
      if (this.V6R6Npn0Yb == null)
        return;
      this.V6R6Npn0Yb((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ciP6G6y5gB([In] AccountTransaction obj0)
    {
      if (this.R7Y6OfFd9f == null)
        return;
      this.R7Y6OfFd9f((object) this, new AccountTransactionEventArgs(obj0));
    }
  }
}
