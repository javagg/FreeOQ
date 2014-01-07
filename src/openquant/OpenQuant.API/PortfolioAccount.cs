using FreeQuant.Instruments;
using System;

namespace OpenQuant.API
{
  public class PortfolioAccount
  {
    private Account account;

    internal PortfolioAccount(Account account)
    {
      this.account = account;
    }

    public void Clear()
    {
      this.account.Clear();
    }

    public void Deposit(DateTime datetime, double value, string text)
    {
      this.account.Deposit(value, datetime, text);
    }

    public void Deposit(DateTime datetime, double value)
    {
      this.Deposit(datetime, value, string.Empty);
    }

    public void Withdraw(DateTime datetime, double value, string text)
    {
      this.account.Withdraw(value, datetime, text);
    }

    public void Withdraw(DateTime datetime, double value)
    {
      this.Withdraw(datetime, value, string.Empty);
    }

    public void Deposit(string currencyCode, double value, DateTime dateTime)
    {
      FreeQuant.Instruments.Currency currency = CurrencyManager.Currencies[currencyCode];
      this.account.Deposit(value, currency, dateTime);
    }

    public void Deposit(string currencyCode, double value)
    {
      FreeQuant.Instruments.Currency currency = CurrencyManager.Currencies[currencyCode];
      this.account.Deposit(value, currency);
    }

    public void Deposit(string currencyCode, double value, DateTime dateTime, string text)
    {
      FreeQuant.Instruments.Currency currency = CurrencyManager.Currencies[currencyCode];
      this.account.Deposit(value, currency, dateTime, text);
    }

    public void Withdraw(string currencyCode, double value, DateTime dateTime)
    {
      FreeQuant.Instruments.Currency currency = CurrencyManager.Currencies[currencyCode];
      this.account.Withdraw(value, currency, dateTime);
    }

    public void Withdraw(string currencyCode, double value)
    {
      FreeQuant.Instruments.Currency currency = CurrencyManager.Currencies[currencyCode];
      this.account.Withdraw(value, currency);
    }

    public void Withdraw(string currencyCode, double value, DateTime dateTime, string text)
    {
      FreeQuant.Instruments.Currency currency = CurrencyManager.Currencies[currencyCode];
      this.account.Withdraw(value, currency, dateTime, text);
    }
  }
}
