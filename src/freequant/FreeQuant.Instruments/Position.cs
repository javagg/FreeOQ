using FreeQuant;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VFUvY5knK01pUIalDo;

namespace FreeQuant.Instruments
{
  public class Position
  {
    private int rik6WLpoo8;
    private TransactionList RR46BSfRFD;
    private Portfolio TvR66c2yCp;
    private Instrument FnF6EobBEB;
    private double zIo6sRiKur;
    private double mPJ6dZYH8B;
    private double pWB6PQN9mh;
    private double kBv6elQGRa;
    private double GEw62kXNBB;
    private int GIf68BaEWm;
    private double WLw6lrSTTe;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.FnF6EobBEB == null)
          throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2788));
        else
          return this.FnF6EobBEB.Symbol;
      }
    }

    public Portfolio Portfolio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TvR66c2yCp;
      }
    }

    public Instrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FnF6EobBEB;
      }
    }

    [Browsable(false)]
    public TransactionList Transactions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RR46BSfRFD;
      }
    }

    public Currency Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RR46BSfRFD[0].Currency;
      }
    }

    public PositionSide Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Amount >= 0.0 ? PositionSide.Long : PositionSide.Short;
      }
    }

    public double EntryPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RR46BSfRFD[0].Price;
      }
    }

    public DateTime EntryDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RR46BSfRFD[0].DateTime;
      }
    }

    public double EntryQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RR46BSfRFD[0].Qty;
      }
    }

    public double Amount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.zIo6sRiKur - this.mPJ6dZYH8B - this.pWB6PQN9mh;
      }
    }

    public double Qty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Math.Abs(this.Amount);
      }
    }

    public double QtyBought
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.zIo6sRiKur;
      }
    }

    public double QtySold
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mPJ6dZYH8B;
      }
    }

    public double QtySoldShort
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pWB6PQN9mh;
      }
    }

    [ReadOnly(true)]
    public double Margin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kBv6elQGRa;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.kBv6elQGRa = value;
      }
    }

    [ReadOnly(true)]
    public double Debt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GEw62kXNBB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GEw62kXNBB = value;
      }
    }

    public event EventHandler ValueChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position(Portfolio portfolio, Instrument instrument)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.rik6WLpoo8 = -1;
      this.RR46BSfRFD = new TransactionList();
      this.GIf68BaEWm = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.TvR66c2yCp = portfolio;
      this.FnF6EobBEB = instrument;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position(Portfolio portfolio, Transaction transaction)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.rik6WLpoo8 = -1;
      this.RR46BSfRFD = new TransactionList();
      this.GIf68BaEWm = -1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.TvR66c2yCp = portfolio;
      this.FnF6EobBEB = transaction.Instrument;
      this.Add(transaction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void s7dBtZ7nOw()
    {
      if (this.OFd6QXsNIJ == null)
        return;
      this.OFd6QXsNIJ((object) this, EventArgs.Empty);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int sZ3BwAXKCB()
    {
      return this.rik6WLpoo8;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void jgrBTalT0J(int value)
    {
      this.rik6WLpoo8 = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string SideToString()
    {
      switch (this.Side)
      {
        case PositionSide.Long:
          return gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2922);
        case PositionSide.Short:
          return gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2934);
        default:
          throw new NotSupportedException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(2948) + (object) this.Side);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Transaction transaction)
    {
      if (this.FnF6EobBEB != transaction.Instrument)
        throw new ArgumentException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3000) + transaction.Instrument.Symbol + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3104) + this.FnF6EobBEB.Symbol);
      double num1 = 0.0;
      double num2 = 0.0;
      int num3 = Math.Sign(transaction.Amount);
      if (this.RR46BSfRFD.Count == 0)
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
        num2 += num5 * (transaction.Cost / transaction.Qty + this.RR46BSfRFD[this.GIf68BaEWm].Cost / this.RR46BSfRFD[this.GIf68BaEWm].Qty);
        num1 += (transaction.Price - this.RR46BSfRFD[this.GIf68BaEWm].Price) * num5 * (double) -num3;
        for (; qty > num6 && index < this.RR46BSfRFD.Count; ++index)
        {
          Transaction transaction1 = this.RR46BSfRFD[index];
          if (Math.Sign(transaction1.Amount) != num3)
          {
            double num7 = Math.Min(qty - num6, transaction1.Qty);
            num2 += num7 * (transaction.Cost / transaction.Qty + transaction1.Cost / transaction1.Qty);
            num1 += (transaction.Price - transaction1.Price) * num7 * (double) -num3;
            num6 += transaction1.Qty;
          }
        }
        this.WLw6lrSTTe = Math.Abs(qty - num6);
        this.GIf68BaEWm = qty == num6 && index == this.RR46BSfRFD.Count || qty > num6 ? this.RR46BSfRFD.Count : index - 1;
      }
      if (this.FnF6EobBEB.Factor != 0.0)
        num1 *= this.FnF6EobBEB.Factor;
      transaction.PnL = num1 - transaction.Cost;
      transaction.RealizedPnL = num1 - num2;
      if ((this.Amount + transaction.Amount) * this.Amount < 0.0)
      {
        if (transaction.Amount < 0.0)
        {
          this.pWB6PQN9mh += this.WLw6lrSTTe;
          this.mPJ6dZYH8B += transaction.Qty - this.WLw6lrSTTe;
        }
        else
          this.zIo6sRiKur += transaction.Qty;
      }
      else if (transaction.Amount < 0.0)
      {
        if (this.Amount <= 0.0)
          this.pWB6PQN9mh += transaction.Qty;
        else
          this.mPJ6dZYH8B += transaction.Qty;
      }
      else
        this.zIo6sRiKur += transaction.Qty;
      this.RR46BSfRFD.Add(transaction);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Price(DateTime datetime)
    {
      return this.FnF6EobBEB.Price(datetime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Price()
    {
      return PortfolioManager.Pricer.Price(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(DateTime datetime)
    {
      if (this.FnF6EobBEB.Factor != 0.0)
        return this.Price(datetime) * this.Amount * this.FnF6EobBEB.Factor;
      else
        return this.Price(datetime) * this.Amount;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue()
    {
      if (this.FnF6EobBEB.Factor != 0.0)
        return this.Price() * this.Amount * this.FnF6EobBEB.Factor;
      else
        return this.Price() * this.Amount;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetMarginValue()
    {
      return this.kBv6elQGRa;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDebtValue()
    {
      return this.GEw62kXNBB;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetLeverage()
    {
      double marginValue = this.GetMarginValue();
      if (marginValue == 0.0)
        return 0.0;
      else
        return this.GetValue() / marginValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCashFlow()
    {
      double num = 0.0;
      foreach (Transaction transaction in this.RR46BSfRFD)
        num += transaction.CashFlow;
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNetCashFlow()
    {
      double num = 0.0;
      foreach (Transaction transaction in this.RR46BSfRFD)
        num += transaction.NetCashFlow;
      return num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPnL()
    {
      return this.GetValue() + this.GetCashFlow();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNetPnL()
    {
      return this.GetValue() + this.GetNetCashFlow();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPnLPercent()
    {
      return this.GetPnL() / this.RR46BSfRFD[0].Value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNetPnLPercent()
    {
      return this.GetNetPnL() / this.RR46BSfRFD[0].Value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetUnrealizedPnL()
    {
      if (this.Qty == 0.0)
        return 0.0;
      double num1 = this.FnF6EobBEB.Price();
      double num2 = 0.0;
      int num3 = this.Side == PositionSide.Long ? -1 : 1;
      double num4 = this.WLw6lrSTTe;
      double num5 = num2 + (num1 - this.RR46BSfRFD[this.GIf68BaEWm].Price) * num4 * (double) -num3;
      for (int index = this.GIf68BaEWm + 1; index < this.RR46BSfRFD.Count; ++index)
      {
        Transaction transaction = this.RR46BSfRFD[index];
        num5 += (num1 - transaction.Price) * num4 * (double) -num3;
      }
      if (this.Instrument.Factor != 0.0)
        return num5 * this.Instrument.Factor;
      else
        return num5;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSpan GetDuration()
    {
      return Clock.Now - this.RR46BSfRFD[0].DateTime;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return this.SideToString() + (object) gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3184) + (string) (object) this.Qty + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(3190) + this.FnF6EobBEB.Symbol;
    }
  }
}
