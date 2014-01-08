namespace OpenQuant.Finam
{
  public sealed class TransaqMoneyPosition
  {
    public string Register { get; private set; }

    public string Asset { get; private set; }

    public string Client { get; private set; }

    public string ShortName { get; private set; }

    public string SaldoIn { get; private set; }

    public string Bought { get; private set; }

    public string Sold { get; private set; }

    public string Saldo { get; private set; }

    public string OrdBuy { get; private set; }

    public string OrdBuyCond { get; private set; }

    public string Comission { get; private set; }

    public TransaqMoneyPosition(string data)
    {
      this.Register = "default";
      this.Asset = this.Client = this.ShortName = this.SaldoIn = this.Bought = string.Empty;
      this.Sold = this.Saldo = this.OrdBuy = this.OrdBuyCond = this.Comission = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "register":
            this.Register = strArray[index + 1];
            break;
          case "asset":
            this.Asset = strArray[index + 1];
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
          case "bought":
            this.Bought = strArray[index + 1];
            break;
          case "sold":
            this.Sold = strArray[index + 1];
            break;
          case "saldo":
            this.Saldo = strArray[index + 1];
            break;
          case "ordbuy":
            this.OrdBuy = strArray[index + 1];
            break;
          case "ordbuycond":
            this.OrdBuyCond = strArray[index + 1];
            break;
          case "comission":
            this.Comission = strArray[index + 1];
            break;
        }
      }
    }

    public void Update(TransaqMoneyPosition tmpNew)
    {
      if (tmpNew.Asset != string.Empty)
        this.Asset = tmpNew.Asset;
      if (tmpNew.Client != string.Empty)
        this.Client = tmpNew.Client;
      if (tmpNew.ShortName != string.Empty)
        this.ShortName = tmpNew.ShortName;
      if (tmpNew.SaldoIn != string.Empty)
        this.SaldoIn = tmpNew.SaldoIn;
      if (tmpNew.Bought != string.Empty)
        this.Bought = tmpNew.Bought;
      if (tmpNew.Sold != string.Empty)
        this.Sold = tmpNew.Sold;
      if (tmpNew.Saldo != string.Empty)
        this.Saldo = tmpNew.Saldo;
      if (tmpNew.OrdBuy != string.Empty)
        this.OrdBuy = tmpNew.OrdBuy;
      if (tmpNew.OrdBuyCond != string.Empty)
        this.OrdBuyCond = tmpNew.OrdBuyCond;
      if (!(tmpNew.Comission != string.Empty))
        return;
      this.Comission = tmpNew.Comission;
    }
  }
}
