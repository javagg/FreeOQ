// Type: OpenQuant.Finam.TransaqBoard
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

namespace OpenQuant.Finam
{
  public sealed class TransaqBoard
  {
    public string Id { get; private set; }

    public string Name { get; private set; }

    public int Market { get; private set; }

    public int Type { get; private set; }

    public TransaqBoard(string data)
    {
      this.Id = this.Name = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "id":
            this.Id = strArray[index + 1];
            break;
          case "name":
            this.Name = strArray[index + 1];
            break;
          case "market":
            this.Market = int.Parse(strArray[index + 1]);
            break;
          case "type":
            this.Type = int.Parse(strArray[index + 1]);
            break;
        }
      }
    }
  }
}
