// Type: SmartQuant.Instruments.MarginManager1
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.FIX;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class MarginManager1
  {
    private Portfolio IGHsUfjT0E;
    private Hashtable nTCs7Rw8ms;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarginManager1(Portfolio portfolio)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      this.nTCs7Rw8ms = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.IGHsUfjT0E = portfolio;
      this.Connect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Connect()
    {
      foreach (Position position in this.IGHsUfjT0E.Positions)
        position.ValueChanged += new EventHandler(this.ONFsKvHWyc);
      this.IGHsUfjT0E.PositionOpened += new PositionEventHandler(this.PUHs99fnF5);
      this.IGHsUfjT0E.PositionClosed += new PositionEventHandler(this.QLisC93NIN);
      this.IGHsUfjT0E.PositionChanged += new PositionEventHandler(this.tvWsM49Wkt);
      this.IGHsUfjT0E.TransactionAdded += new TransactionEventHandler(this.xbBsmpa0EO);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Disconnect()
    {
      foreach (Position position in this.IGHsUfjT0E.Positions)
        position.ValueChanged -= new EventHandler(this.ONFsKvHWyc);
      this.IGHsUfjT0E.PositionOpened -= new PositionEventHandler(this.PUHs99fnF5);
      this.IGHsUfjT0E.PositionClosed -= new PositionEventHandler(this.QLisC93NIN);
      this.IGHsUfjT0E.PositionChanged -= new PositionEventHandler(this.tvWsM49Wkt);
      this.IGHsUfjT0E.TransactionAdded -= new TransactionEventHandler(this.xbBsmpa0EO);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ONFsKvHWyc([In] object obj0, [In] EventArgs obj1)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PUHs99fnF5([In] object obj0, [In] PositionEventArgs obj1)
    {
      Position position = obj1.Position;
      Transaction last = position.Transactions.Last;
      MarginPosition marginPosition = new MarginPosition(position);
      if (last.Instrument.SecurityType == gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10862) && last.Side == Side.Buy)
      {
        marginPosition.Margin = last.Value * 0.5;
        this.nTCs7Rw8ms.Add((object) position, (object) marginPosition);
        this.IGHsUfjT0E.Account.Deposit(marginPosition.Margin, last.Currency, last.DateTime, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10870));
      }
      position.ValueChanged += new EventHandler(this.ONFsKvHWyc);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QLisC93NIN([In] object obj0, [In] PositionEventArgs obj1)
    {
      Position position = obj1.Position;
      Transaction last = position.Transactions.Last;
      MarginPosition marginPosition = new MarginPosition(position);
      if (last.Instrument.SecurityType == gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10890) && last.Side == Side.Sell)
      {
        this.nTCs7Rw8ms.Remove((object) position);
        this.IGHsUfjT0E.Account.Withdraw(marginPosition.Margin, last.Currency, last.DateTime, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(10898));
      }
      obj1.Position.ValueChanged -= new EventHandler(this.ONFsKvHWyc);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tvWsM49Wkt([In] object obj0, [In] PositionEventArgs obj1)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void xbBsmpa0EO([In] object obj0, [In] TransactionEventArgs obj1)
    {
    }
  }
}
