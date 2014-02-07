namespace OpenQuant.API.Compression
{
	internal class PriceSizeItem
	{
		public double Price { get; private set; }
		public long Size { get; private set; }

		public PriceSizeItem(double price, long size)
		{
			this.Price = price;
			this.Size = size;
		}
	}
}
