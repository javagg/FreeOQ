// Type: OpenQuant.Finam.TransaqFortsCollaterals
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

namespace OpenQuant.Finam
{
  public sealed class TransaqFortsCollaterals
  {
    public string Client { get; private set; }

    public string Current { get; private set; }

    public string Blocked { get; private set; }

    public string Free { get; private set; }

    public TransaqFortsCollaterals(string data)
    {
      this.Client = this.Current = this.Blocked = this.Free = string.Empty;
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
        }
      }
    }

    public void Update(TransaqFortsCollaterals tfc)
    {
      if (tfc.Client != string.Empty)
        this.Client = tfc.Client;
      if (tfc.Current != string.Empty)
        this.Current = tfc.Current;
      if (tfc.Blocked != string.Empty)
        this.Blocked = tfc.Blocked;
      if (!(tfc.Free != string.Empty))
        return;
      this.Free = tfc.Free;
    }
  }
}
