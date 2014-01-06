// Type: OpenQuant.Finam.TransaqStopOrder
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

namespace OpenQuant.Finam
{
  public sealed class TransaqStopOrder
  {
    public long TransactionId { get; private set; }

    public long ActiveOrderNo { get; private set; }

    public string Status { get; private set; }

    public string WithdrawTime { get; private set; }

    public string Result { get; private set; }

    public TransaqStoploss StopLoss { get; private set; }

    public TransaqTakeprofit TakeProfit { get; private set; }

    public TransaqStopOrder(string data)
    {
      this.TransactionId = this.ActiveOrderNo = -1L;
      this.Status = this.WithdrawTime = this.Result = string.Empty;
      this.StopLoss = new TransaqStoploss(string.Empty);
      this.TakeProfit = new TransaqTakeprofit(string.Empty);
      string[] strArray1 = data.Split(new char[1]
      {
        '|'
      });
      for (int index1 = 0; index1 < strArray1.Length; ++index1)
      {
        string[] strArray2 = strArray1[index1].Split(new char[1]
        {
          ';'
        });
        if (strArray2[0] == "stoporder")
        {
          int index2 = 1;
          while (index2 < strArray2.Length)
          {
            switch (strArray2[index2])
            {
              case "transactionid":
                this.TransactionId = long.Parse(strArray2[index2 + 1]);
                break;
              case "activeorderno":
                this.ActiveOrderNo = long.Parse(strArray2[index2 + 1]);
                break;
              case "status":
                this.Status = strArray2[index2 + 1];
                break;
              case "withdrawtime":
                this.WithdrawTime = strArray2[index2 + 1];
                break;
              case "result":
                this.Result = strArray2[index2 + 1];
                break;
            }
            index2 += 2;
          }
        }
        if (strArray2[0] == "stoploss")
          this.StopLoss = new TransaqStoploss(strArray1[index1]);
        if (strArray2[0] == "takeprofit")
          this.TakeProfit = new TransaqTakeprofit(strArray1[index1]);
      }
    }

    public void Update(TransaqStopOrder tso)
    {
      if (tso.TransactionId != -1L)
        this.TransactionId = tso.TransactionId;
      if (tso.ActiveOrderNo != -1L)
        this.ActiveOrderNo = tso.ActiveOrderNo;
      if (tso.Status != string.Empty)
        this.Status = tso.Status;
      if (tso.WithdrawTime != string.Empty)
        this.WithdrawTime = tso.WithdrawTime;
      if (tso.Result != string.Empty)
        this.Result = tso.Result;
      this.StopLoss.Update(tso.StopLoss);
      this.TakeProfit.Update(tso.TakeProfit);
    }
  }
}
