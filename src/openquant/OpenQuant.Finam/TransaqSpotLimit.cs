namespace OpenQuant.Finam
{
  public sealed class TransaqSpotLimit
  {
    public string Client { get; private set; }

    public string BuyLimit { get; private set; }

    public string BuyLimitUsed { get; private set; }

    public TransaqSpotLimit(string data)
    {
      this.Client = this.BuyLimit = this.BuyLimitUsed = string.Empty;
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
          case "buylimit":
            this.BuyLimit = strArray[index + 1];
            break;
          case "buylimitused":
            this.BuyLimitUsed = strArray[index + 1];
            break;
        }
      }
    }

    public void Update(TransaqSpotLimit tsl)
    {
      if (tsl.Client != string.Empty)
        this.Client = tsl.Client;
      if (tsl.BuyLimit != string.Empty)
        this.BuyLimit = tsl.BuyLimit;
      if (!(tsl.BuyLimitUsed != string.Empty))
        return;
      this.BuyLimitUsed = tsl.BuyLimitUsed;
    }
  }
}
