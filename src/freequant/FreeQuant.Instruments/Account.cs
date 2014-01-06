// Type: SmartQuant.Instruments.Account
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Instruments
{
  [Serializable]
  public class Account
  {
    private string DgS6XFeLsB;
    private string hsM64apY0X;
    private Currency unN6JryrhI;
    private AccountTransactionList Dpw6ryi1vX;
    private AccountPositionList lUQ63QtJNB;

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
        return this.hsM64apY0X;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.hsM64apY0X = value;
      }
    }

    public AccountTransactionList Transactions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Dpw6ryi1vX;
      }
    }

    public AccountPositionList Positions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lUQ63QtJNB;
      }
    }

    public Currency Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.unN6JryrhI;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.unN6JryrhI = value;
      }
    }

    public double this[Currency currency]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        AccountPosition accountPosition = this.lUQ63QtJNB[currency];
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
      this.Dpw6ryi1vX = new AccountTransactionList();
      this.lUQ63QtJNB = new AccountPositionList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.DgS6XFeLsB = name;
      this.hsM64apY0X = description;
      this.unN6JryrhI = currency;
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
      foreach (AccountPosition accountPosition in this.lUQ63QtJNB)
        num += Currency.Convert(accountPosition.Value, accountPosition.Currency, this.unN6JryrhI);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(DateTime dateTime)
    {
      Account account = new Account(this.unN6JryrhI);
      foreach (AccountTransaction transaction in this.Dpw6ryi1vX)
      {
        if (transaction.DateTime <= dateTime)
          account.Add(transaction);
      }
      double num = 0.0;
      foreach (AccountPosition accountPosition in account.Positions)
        num += Currency.Convert(accountPosition.Value, accountPosition.Currency, this.unN6JryrhI, dateTime);
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.Dpw6ryi1vX.Clear();
      this.lUQ63QtJNB.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(AccountTransaction transaction)
    {
      AccountPosition position = this.lUQ63QtJNB[transaction.Currency];
      if (position == null)
      {
        position = new AccountPosition(transaction.Currency);
        this.lUQ63QtJNB.Add(position);
      }
      this.Dpw6ryi1vX.Add(transaction);
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
      this.Add(val, this.unN6JryrhI, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(double val)
    {
      this.Add(val, this.unN6JryrhI, Clock.Now);
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
      this.Deposit(val, this.unN6JryrhI, Clock.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, DateTime dateTime)
    {
      this.Deposit(val, this.unN6JryrhI, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, string text)
    {
      this.Deposit(val, this.unN6JryrhI, Clock.Now, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deposit(double val, DateTime dateTime, string text)
    {
      this.Deposit(val, this.unN6JryrhI, dateTime, text);
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
      this.Withdraw(val, this.unN6JryrhI, Clock.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, DateTime dateTime)
    {
      this.Withdraw(val, this.unN6JryrhI, dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, string text)
    {
      this.Withdraw(val, this.unN6JryrhI, Clock.Now, text);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Withdraw(double val, DateTime dateTime, string text)
    {
      this.Withdraw(val, this.unN6JryrhI, dateTime, text);
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
