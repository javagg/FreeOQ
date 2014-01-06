namespace OpenQuant.Finam
{
  public sealed class TransaqFortsMoney
  {
    public string Client { get; private set; }

    public string Current { get; private set; }

    public string Blocked { get; private set; }

    public string Free { get; private set; }

    public string VarMargin { get; private set; }

    public TransaqFortsMoney(string data)
    {
      this.Client = this.Current = this.Blocked = this.Free = this.VarMargin = string.Empty;
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
          case "current":
            this.Current = strArray[index + 1];
            break;
          case "blocked":
            this.Blocked = strArray[index + 1];
            break;
          case "free":
            this.Free = strArray[index + 1];
            break;
          case "varmargin":
            this.VarMargin = strArray[index + 1];
            break;
        }
      }
    }

    public void Update(TransaqFortsMoney tfm)
    {
      if (tfm.Client != string.Empty)
        this.Client = tfm.Client;
      if (tfm.Current != string.Empty)
        this.Current = tfm.Current;
      if (tfm.Blocked != string.Empty)
        this.Blocked = tfm.Blocked;
      if (tfm.Free != string.Empty)
        this.Free = tfm.Free;
      if (!(tfm.VarMargin != string.Empty))
        return;
      this.VarMargin = tfm.VarMargin;
    }
  }
}
