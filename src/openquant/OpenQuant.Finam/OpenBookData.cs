// Type: OpenQuant.Finam.OpenBookData
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

namespace OpenQuant.Finam
{
  public class OpenBookData
  {
    public double Price { get; set; }

    public int Size { get; set; }

    public OpenBookData(double price, int size)
    {
      this.Price = price;
      this.Size = size;
    }
  }
}
