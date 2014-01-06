// Type: SmartQuant.Instruments.AccountTransaction
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wXsBIY4l30;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.wXsBIY4l30 = value;
      }
    }

    public Currency Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.C8eBxkx3Lf;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.C8eBxkx3Lf = value;
      }
    }

    [ReadOnly(true)]
    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.A1pBoCkFfC;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.A1pBoCkFfC = value;
      }
    }

    [Browsable(false)]
    public Transaction Transaction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AccountTransaction()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.pJ6B1pDREG = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int S0tBZ03o6G()
    {
      return this.pJ6B1pDREG;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void G7YBAhR7LA(int value)
    {
      this.pJ6B1pDREG = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return (string) (object) this.A1pBoCkFfC + (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2538) + this.ActionToString() + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2544) + (string) (object) Math.Abs(this.wXsBIY4l30) + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2550) + this.C8eBxkx3Lf.Code + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2556);
    }
  }
}
