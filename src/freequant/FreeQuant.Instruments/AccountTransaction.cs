using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class AccountTransaction
  {
    internal int pJ6B1pDREG;
    internal DateTime A1pBoCkFfC;
    internal Currency C8eBxkx3Lf;
    internal double wXsBIY4l30;
    internal Transaction ftTBL1sOMg;
    internal string xWfBbRh100;

    public AccountAction Action
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wXsBIY4l30 < 0.0 ? AccountAction.Withdraw : AccountAction.Deposit;
      }
    }

    [ReadOnly(true)]
    public double Value
    {
        get
      {
        return this.wXsBIY4l30;
      }
       set
      {
        this.wXsBIY4l30 = value;
      }
    }

    public Currency Currency
    {
      get
      {
        return this.C8eBxkx3Lf;
      }
      set
      {
        this.C8eBxkx3Lf = value;
      }
    }

    [ReadOnly(true)]
    public DateTime DateTime
    {
      get
      {
        return this.A1pBoCkFfC;
      }
      set
      {
        this.A1pBoCkFfC = value;
      }
    }

    [Browsable(false)]
    public Transaction Transaction
    {
      get
      {
        return this.ftTBL1sOMg;
      }
    }

    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.xWfBbRh100;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.xWfBbRh100 = value;
      }
    }

    public AccountTransaction()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.pJ6B1pDREG = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public AccountTransaction(double val, Currency currency, DateTime dateTime, string text)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.pJ6B1pDREG = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.wXsBIY4l30 = val;
      this.C8eBxkx3Lf = currency;
      this.A1pBoCkFfC = dateTime;
      this.xWfBbRh100 = text;
    }

    public AccountTransaction(double val, Currency currency, DateTime dateTime)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.pJ6B1pDREG = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.wXsBIY4l30 = val;
      this.C8eBxkx3Lf = currency;
      this.A1pBoCkFfC = dateTime;
    }

    public AccountTransaction(double val, Currency currency, string text)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.pJ6B1pDREG = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.wXsBIY4l30 = val;
      this.C8eBxkx3Lf = currency;
      this.A1pBoCkFfC = Clock.Now;
      this.xWfBbRh100 = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AccountTransaction(double val, Currency currency)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.pJ6B1pDREG = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.wXsBIY4l30 = val;
      this.C8eBxkx3Lf = currency;
      this.A1pBoCkFfC = Clock.Now;
    }

    public AccountTransaction(Transaction transaction)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.pJ6B1pDREG = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.wXsBIY4l30 = transaction.CashFlow;
      this.C8eBxkx3Lf = transaction.Currency;
      this.A1pBoCkFfC = transaction.DateTime;
      this.xWfBbRh100 = transaction.Text;
      this.ftTBL1sOMg = transaction;
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
          return gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2478);
        case AccountAction.Deposit:
          return gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2498);
        default:
          return gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2516);
      }
    }

    public override string ToString()
    {
      return (string) (object) this.A1pBoCkFfC + (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2538) + this.ActionToString() + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2544) + (string) (object) Math.Abs(this.wXsBIY4l30) + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2550) + this.C8eBxkx3Lf.Code + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2556);
    }
  }
}
