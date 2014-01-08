namespace OpenQuant.Finam
{
  public sealed class TransaqClientLimit
  {
    public string Client { get; private set; }

    public string CbplLimit { get; private set; }

    public string CbplUsed { get; private set; }

    public string CbplPlanned { get; private set; }

    public string Fob_VarMargin { get; private set; }

    public string Coverage { get; private set; }

    public string Liquidity_C { get; private set; }

    public string Profit { get; private set; }

    public string Money_Current { get; private set; }

    public string Money_Blocked { get; private set; }

    public string Money_Free { get; private set; }

    public string Options_Premium { get; private set; }

    public string Exchange_Fee { get; private set; }

    public string Forts_VarMargin { get; private set; }

    public string VarMargin { get; private set; }

    public string PclMargin { get; private set; }

    public string Options_VM { get; private set; }

    public string Spot_Buy_Limit { get; private set; }

    public string Used_Spot_Buy_Limit { get; private set; }

    public string Collat_Current { get; private set; }

    public string Collat_Blocked { get; private set; }

    public string Collat_Free { get; private set; }

    public TransaqClientLimit(string data)
    {
      this.Client = this.CbplLimit = this.CbplUsed = this.CbplPlanned = this.Fob_VarMargin = this.Coverage = this.Liquidity_C = this.Profit = string.Empty;
      this.Money_Current = this.Money_Blocked = this.Money_Free = this.Options_Premium = this.Exchange_Fee = this.Forts_VarMargin = string.Empty;
      this.VarMargin = this.PclMargin = this.Options_VM = this.Spot_Buy_Limit = this.Used_Spot_Buy_Limit = string.Empty;
      this.Collat_Current = this.Collat_Blocked = this.Collat_Free = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "client":
            this.Client = strArray[index + 1];
            break;
          case "cbplimit":
            this.CbplLimit = strArray[index + 1];
            break;
          case "cbplused":
            this.CbplUsed = strArray[index + 1];
            break;
          case "cbplplanned":
            this.CbplPlanned = strArray[index + 1];
            break;
          case "fob_varmargin":
            this.Fob_VarMargin = strArray[index + 1];
            break;
          case "coverage":
            this.Coverage = strArray[index + 1];
            break;
          case "liquidity_c":
            this.Liquidity_C = strArray[index + 1];
            break;
          case "profit":
            this.Profit = strArray[index + 1];
            break;
          case "money_current":
            this.Money_Current = strArray[index + 1];
            break;
          case "money_blocked":
            this.Money_Blocked = strArray[index + 1];
            break;
          case "money_free":
            this.Money_Free = strArray[index + 1];
            break;
          case "options_premium":
            this.Options_Premium = strArray[index + 1];
            break;
          case "exchange_fee":
            this.Exchange_Fee = strArray[index + 1];
            break;
          case "forts_varmargin":
            this.Forts_VarMargin = strArray[index + 1];
            break;
          case "varmargin":
            this.VarMargin = strArray[index + 1];
            break;
          case "pclmargin":
            this.PclMargin = strArray[index + 1];
            break;
          case "options_vm":
            this.Options_VM = strArray[index + 1];
            break;
          case "spot_buy_limit":
            this.Spot_Buy_Limit = strArray[index + 1];
            break;
          case "used_stop_buy_limit":
            this.Used_Spot_Buy_Limit = strArray[index + 1];
            break;
          case "collat_current":
            this.Collat_Current = strArray[index + 1];
            break;
          case "collat_blocked":
            this.Collat_Blocked = strArray[index + 1];
            break;
          case "collat_free":
            this.Collat_Free = strArray[index + 1];
            break;
        }
      }
    }
  }
}
