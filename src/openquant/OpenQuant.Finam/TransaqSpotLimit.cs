// Type: OpenQuant.Finam.TransaqSpotLimit
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

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
