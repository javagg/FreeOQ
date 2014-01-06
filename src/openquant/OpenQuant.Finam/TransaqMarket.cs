// Type: OpenQuant.Finam.TransaqMarket
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

namespace OpenQuant.Finam
{
  public sealed class TransaqMarket
  {
    public int Id { get; private set; }

    public string Name { get; private set; }

    public TransaqMarket(string data)
    {
      this.Name = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "market":
            this.Name = strArray[index + 1];
            break;
          case "id":
            this.Id = int.Parse(strArray[index + 1]);
            break;
        }
      }
    }
  }
}
