// Type: OpenQuant.Finam.TransaqServerStatus
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

namespace OpenQuant.Finam
{
  public sealed class TransaqServerStatus
  {
    public int Id { get; private set; }

    public string Connected { get; private set; }

    public string Recover { get; private set; }

    public string ErrorMessage { get; private set; }

    public TransaqServerStatus(string data)
    {
      this.Connected = this.Recover = this.ErrorMessage = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "id":
            this.Id = int.Parse(strArray[index + 1]);
            break;
          case "connected":
            this.Connected = strArray[index + 1];
            if (this.Connected == "error")
            {
              this.ErrorMessage = strArray[index + 2];
              break;
            }
            else
              break;
          case "recover":
            this.Recover = strArray[index + 1];
            break;
        }
      }
    }
  }
}
