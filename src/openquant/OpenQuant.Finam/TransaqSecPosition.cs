// Type: OpenQuant.Finam.TransaqSecPosition
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqSecPosition
  {
    public int SecId { get; private set; }

    public int Market { get; private set; }

    public string SecCode { get; private set; }

    public string Register { get; private set; }

    public string Client { get; private set; }

    public string ShortName { get; private set; }

    public string SaldoIn { get; private set; }

    public string SaldoMin { get; private set; }

    public int Bought { get; private set; }

    public int Sold { get; private set; }

    public double Saldo { get; private set; }

    public string OrderBuy { get; private set; }

    public string OrderSell { get; private set; }

    public TransaqSecPosition(string data)
    {
      this.SecId = this.Market = this.Bought = this.Sold = -1;
      this.Register = "default";
      this.SecCode = this.Client = this.ShortName = this.SaldoIn = this.SaldoMin = this.OrderBuy = this.OrderSell = string.Empty;
      this.Saldo = double.MaxValue;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "secid":
            this.SecId = int.Parse(strArray[index + 1]);
            break;
          case "market":
            this.Market = int.Parse(strArray[index + 1]);
            break;
          case "seccode":
            this.SecCode = strArray[index + 1];
            break;
          case "register":
            this.Register = strArray[index + 1];
            break;
          case "client":
            this.Client = strArray[index + 1];
            break;
          case "shortname":
            this.ShortName = strArray[index + 1];
            break;
          case "saldoin":
            this.SaldoIn = strArray[index + 1];
            break;
          case "saldomin":
            this.SaldoMin = strArray[index + 1];
            break;
          case "bought":
            this.Bought = int.Parse(strArray[index + 1]);
            break;
          case "sold":
            this.Sold = int.Parse(strArray[index + 1]);
            break;
          case "saldo":
            this.Saldo = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "orderbuy":
            this.OrderBuy = strArray[index + 1];
            break;
          case "ordersell":
            this.OrderSell = strArray[index + 1];
            break;
        }
      }
    }

    public void Update(TransaqSecPosition tsp)
    {
      if (tsp.SecId != -1)
        this.SecId = tsp.SecId;
      if (tsp.Client != string.Empty)
        this.Client = tsp.Client;
      if (tsp.ShortName != string.Empty)
        this.ShortName = tsp.ShortName;
      if (tsp.SaldoIn != string.Empty)
        this.SaldoIn = tsp.SaldoIn;
      if (tsp.SaldoMin != string.Empty)
        this.SaldoMin = tsp.SaldoMin;
      if (tsp.Bought != -1)
        this.Bought = tsp.Bought;
      if (tsp.Sold != -1)
        this.Sold = tsp.Sold;
      if (tsp.Saldo != double.MaxValue)
        this.Saldo = tsp.Saldo;
      if (tsp.OrderBuy != string.Empty)
        this.OrderBuy = tsp.OrderBuy;
      if (!(tsp.OrderSell != string.Empty))
        return;
      this.OrderSell = tsp.OrderSell;
    }
  }
}
