namespace OpenQuant.API.Compression
{
  internal class PriceSizeItem
  {
    public double Price { get; private set; }

    public int Size { get; private set; }

    public PriceSizeItem(double price, int size)
    {
      this.Price = price;
      this.Size = size;
    }
  }
}
