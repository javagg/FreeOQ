using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;

namespace OpenQuant.API
{
  public class Portfolio
  {
    internal SmartQuant.Instruments.Portfolio portfolio;
    private PositionList positions;
    private TransactionList transactions;
    private PortfolioAccount account;

    public PositionList Positions
    {
      get
      {
        return this.positions;
      }
    }

    public TransactionList Transactions
    {
      get
      {
        return this.transactions;
      }
    }

    public PortfolioAccount Account
    {
      get
      {
        return this.account;
      }
    }

    internal Portfolio(SmartQuant.Instruments.Portfolio portfolio)
    {
      this.portfolio = portfolio;
      this.positions = new PositionList(portfolio.Positions);
      this.transactions = new TransactionList(portfolio.Transactions);
      this.account = new PortfolioAccount(portfolio.Account);
    }

    public double GetPositionValue()
    {
      return this.portfolio.GetPositionValue();
    }

    public double GetAccountValue()
    {
      return this.portfolio.GetAccountValue();
    }

    public double GetValue()
    {
      return this.portfolio.GetValue();
    }

    public double GetMarginValue()
    {
      return this.portfolio.GetMarginValue();
    }

    public double GetDebtValue()
    {
      return this.portfolio.GetDebtValue();
    }

    public double GetCoreEquity()
    {
      return this.portfolio.GetCoreEquity();
    }

    public double GetTotalEquity()
    {
      return this.portfolio.GetTotalEquity();
    }

    public double GetLeverage()
    {
      return this.portfolio.GetLeverage();
    }

    public double GetDebtEquityRatio()
    {
      return this.portfolio.GetDebtEquityRatio();
    }

    public double GetCashFlow()
    {
      return this.portfolio.GetCashFlow();
    }

    public double GetNetCashFlow()
    {
      return this.portfolio.GetNetCashFlow();
    }

    public void Add(DateTime datetime, TransactionSide side, double qty, Instrument instrument, double price, string text)
    {
      Side side1;
      switch (side)
      {
        case TransactionSide.Buy:
          side1 = Side.Buy;
          break;
        case TransactionSide.Sell:
          side1 = Side.Sell;
          break;
        default:
          throw new ArgumentException(string.Format("Unknown TransactionSide - {0} ", (object) side));
      }
      SmartQuant.Instruments.Transaction transaction = new SmartQuant.Instruments.Transaction(datetime, side1, qty, instrument.instrument, price);
      transaction.Currency = CurrencyManager.Currencies[instrument.instrument.Currency];
      if (text != null)
        transaction.Text = text;
      this.portfolio.Add(transaction);
    }

    public void Add(DateTime datetime, TransactionSide side, double qty, Instrument instrument, double price)
    {
      this.Add(datetime, side, qty, instrument, price, (string) null);
    }

    public bool HasPosition(Instrument instrument)
    {
      return this.portfolio.Positions[instrument.instrument] != null;
    }
  }
}
