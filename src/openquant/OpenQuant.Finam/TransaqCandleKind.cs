// Type: OpenQuant.Finam.TransaqCandleKind
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

namespace OpenQuant.Finam
{
  public sealed class TransaqCandleKind
  {
    public int Id { get; private set; }

    public long Period { get; private set; }

    public string Name { get; private set; }

    public TransaqCandleKind(string data)
    {
      this.Name = string.Empty;
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
            this.Id = int.Parse(strArray[index + 1]);
            break;
          case "period":
            this.Period = long.Parse(strArray[index + 1]);
            break;
          case "name":
            this.Name = strArray[index + 1];
            break;
        }
        index += 2;
      }
    }
  }
}
