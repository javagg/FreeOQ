// Type: OpenQuant.Finam.TransaqOrder
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqOrder
  {
    public long TransactionId { get; private set; }

    public long OrderNo { get; private set; }

    public string Status { get; private set; }

    public double Balance { get; private set; }

    public double Price { get; private set; }

    public int Quantity { get; private set; }

    public string WithdrawTime { get; private set; }

    public string Result { get; private set; }

    public TransaqOrder(string data)
    {
      this.TransactionId = this.OrderNo = (long) (this.Quantity = -1);
      this.Status = this.WithdrawTime = this.Result = string.Empty;
      this.Balance = this.Price = -1.0;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "transactionid":
            this.TransactionId = long.Parse(strArray[index + 1]);
            break;
          case "orderno":
            this.OrderNo = long.Parse(strArray[index + 1]);
            break;
          case "status":
            this.Status = strArray[index + 1];
            break;
          case "balance":
            this.Balance = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "price":
            this.Price = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "quantity":
            this.Quantity = int.Parse(strArray[index + 1]);
            break;
          case "withdrawtime":
            this.WithdrawTime = strArray[index + 1];
            break;
          case "result":
            this.Result = strArray[index + 1];
            break;
        }
      }
    }

    public void Update(TransaqOrder to)
    {
      if (to.TransactionId != -1L)
        this.TransactionId = to.TransactionId;
      if (to.OrderNo != -1L)
        this.OrderNo = to.OrderNo;
      if (to.Status != string.Empty)
        this.Status = to.Status;
      if (to.Balance != -1.0)
        this.Balance = to.Balance;
      if (to.Price != -1.0)
        this.Price = to.Price;
      if (to.Quantity != -1)
        this.Quantity = to.Quantity;
      if (to.WithdrawTime != string.Empty)
        this.WithdrawTime = to.WithdrawTime;
      if (!(to.Result != string.Empty))
        return;
      this.Result = to.Result;
    }
  }
}
