namespace OpenQuant.Finam
{
  public sealed class TransaqClient
  {
    public string Id { get; private set; }

    public string Remove { get; private set; }

    public string Type { get; private set; }

    public string Currency { get; private set; }

    public string Ml_intraday { get; private set; }

    public string Ml_overnight { get; private set; }

    public string Ml_restrict { get; private set; }

    public string Ml_call { get; private set; }

    public string Ml_close { get; private set; }

    public TransaqClient(string data)
    {
      this.Id = this.Remove = this.Type = this.Currency = string.Empty;
      this.Ml_intraday = this.Ml_overnight = this.Ml_restrict = this.Ml_call = this.Ml_close = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      int index = 0;
      while (index < strArray.Length)
      {
        switch (strArray[index])
        {
          case "id":
            this.Id = strArray[index + 1];
            break;
          case "remove":
            this.Remove = strArray[index + 1];
            break;
          case "type":
            this.Type = strArray[index + 1];
            break;
          case "currency":
            this.Currency = strArray[index + 1];
            break;
          case "ml_intraday":
            this.Ml_intraday = strArray[index + 1];
            break;
          case "ml_overnight":
            this.Ml_overnight = strArray[index + 1];
            break;
          case "ml_restrict":
            this.Ml_restrict = strArray[index + 1];
            break;
          case "ml_call":
            this.Ml_call = strArray[index + 1];
            break;
          case "ml_close":
            this.Ml_close = strArray[index + 1];
            break;
        }
        index += 2;
      }
    }
  }
}
